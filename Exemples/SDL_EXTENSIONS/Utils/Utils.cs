using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace SDL_EXTENSIONS.Utils;

public static class Utils
{
    static readonly byte[] key =
    {
        0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
        0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
    };

    static readonly JsonSerializerOptions options = new(){ IncludeFields = true };

    /// <summary>
    /// Add environment path in this process for any operate system
    /// </summary>
    /// <param name="path"></param>
    public static void AddEnvironmentPath(string path)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath(path));
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(path));
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(path));
    }

    /// <summary>
    /// Serializes an object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="serializableObject"></param>
    /// <param name="fileName"></param>
    public static void SerializeObject<T>(T serializableObject, string fileName, SerializeType type = SerializeType.html)
    {
        switch (type)
        {
            case SerializeType.html:
                SerializeObjectHtml(serializableObject, fileName);
                break;
            case SerializeType.json:
                SerializeObjectJson(serializableObject, fileName);
                break;
            case SerializeType.binary:
                SerializeObjectBinary(serializableObject, fileName);
                break;
            case SerializeType.htmlProtect:
                SerializeObjectHtmlProtect(serializableObject, fileName);
                break;
            case SerializeType.jsonProtect:
                SerializeObjectJsonProtect(serializableObject, fileName);
                break;
            case SerializeType.binaryProtect:
                SerializeObjectBinaryProtect(serializableObject, fileName);
                break;
            default:
                return;
        }
    }

    private static void SerializeObjectHtml<T>(T serializableObject, string fileName)
    {
        if (serializableObject == null) return;

        try
        {
            XmlDocument xmlDocument = new();
            XmlSerializer serializer = new(serializableObject.GetType());
            using MemoryStream stream = new();
            serializer.Serialize(stream, serializableObject);
            stream.Position = 0;
            xmlDocument.Load(stream);
            xmlDocument.Save(fileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void SerializeObjectJson<T>(T serializableObject, string fileName)
    {
        if (serializableObject == null) return;

        try
        {
            using FileStream createStream = File.Create(fileName);
            JsonSerializer.Serialize(createStream, serializableObject, options);
            createStream.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void SerializeObjectBinary<T>(T serializableObject, string fileName)
    {
        if (serializableObject == null) return;

        try
        {
            FileStream stream = new(fileName, FileMode.Create);
            ProtoBuf.Serializer.Serialize(stream, serializableObject);
            stream.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void SerializeObjectHtmlProtect<T>(T serializableObject, string fileName)
    {
        if (serializableObject == null) return;

        try
        {
            using FileStream createStream = File.Create(fileName);

            using Aes aes = Aes.Create();
            aes.Key = key;

            byte[] iv = aes.IV;
            createStream.Write(iv, 0, iv.Length);

            using CryptoStream cryptoStream = new(
                createStream,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write);
            using StreamWriter encryptWriter = new(cryptoStream);
            XmlDocument xmlDocument = new();
            XmlSerializer serializer = new(serializableObject.GetType());
            using MemoryStream stream = new();
            serializer.Serialize(stream, serializableObject);
            stream.Position = 0;
            xmlDocument.Load(stream);
            encryptWriter.Write(xmlDocument.OuterXml);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void SerializeObjectJsonProtect<T>(T serializableObject, string fileName)
    {
        if (serializableObject == null) return;

        try
        {
            using FileStream createStream = File.Create(fileName);

            using Aes aes = Aes.Create();
            aes.Key = key;

            byte[] iv = aes.IV;
            createStream.Write(iv, 0, iv.Length);

            using CryptoStream cryptoStream = new(
                createStream,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write);
            using StreamWriter encryptWriter = new(cryptoStream);
            string jsonString = JsonSerializer.Serialize(serializableObject, options);
            encryptWriter.Write(jsonString);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void SerializeObjectBinaryProtect<T>(T serializableObject, string fileName)
    {
        if (serializableObject == null) return;

        try
        {
            using FileStream createStream = File.Create(fileName);

            using Aes aes = Aes.Create();
            aes.Key = key;

            byte[] iv = aes.IV;
            createStream.Write(iv, 0, iv.Length);

            using CryptoStream cryptoStream = new(
                createStream,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write);
            using StreamWriter encryptWriter = new(cryptoStream);
            using var ms = new MemoryStream();
            ProtoBuf.Serializer.Serialize(ms, serializableObject);
            encryptWriter.Write(Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    /// <summary>
    /// Deserializes an xml file into an object list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static T DeSerializeObject<T>(string fileName, SerializeType type = SerializeType.html)
    {
        return type switch
        {
            SerializeType.html => DeSerializeObjectHtml<T>(fileName),
            SerializeType.json => DeSerializeObjectJson<T>(fileName),
            SerializeType.binary => DeSerializeObjectBinary<T>(fileName),
            SerializeType.htmlProtect => DeSerializeObjectHtmlProtect<T>(fileName),
            SerializeType.jsonProtect => DeSerializeObjectJsonProtect<T>(fileName),
            SerializeType.binaryProtect => DeSerializeObjectBinaryProtect<T>(fileName),
            _ => default,
        };
    }

    private static T DeSerializeObjectHtml<T>(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return default;
        T objectOut = default;

        try
        {
            XmlDocument xmlDocument = new();
            xmlDocument.Load(fileName);
            string xmlString = xmlDocument.OuterXml;

            using StringReader read = new(xmlString);
            Type outType = typeof(T);

            XmlSerializer serializer = new(outType);
            using XmlReader reader = new XmlTextReader(read);
            objectOut = (T)serializer.Deserialize(reader);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return objectOut;
    }

    private static T DeSerializeObjectJson<T>(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return default;
        T objectOut = default;

        try
        {
            string jsonString = File.ReadAllText(fileName);
            objectOut = JsonSerializer.Deserialize<T>(jsonString, options);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return objectOut;
    }

    private static T DeSerializeObjectBinary<T>(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return default;
        T objectOut = default;

        try
        {
            FileStream stream = new(fileName, FileMode.Open);
            objectOut = ProtoBuf.Serializer.Deserialize<T>(stream);
            stream.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return objectOut;
    }

    private static T DeSerializeObjectHtmlProtect<T>(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return default;
        T objectOut = default;

        try
        {
            using FileStream fileStream = new(fileName, FileMode.Open);
            using Aes aes = Aes.Create();
            byte[] iv = new byte[aes.IV.Length];
            int numBytesToRead = aes.IV.Length;
            int numBytesRead = 0;
            while (numBytesToRead > 0)
            {
                int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                if (n == 0) break;

                numBytesRead += n;
                numBytesToRead -= n;
            }

            using CryptoStream cryptoStream = new(
               fileStream,
               aes.CreateDecryptor(key, iv),
               CryptoStreamMode.Read);
            using StreamReader decryptReader = new(cryptoStream);
            string decryptedMessage = decryptReader.ReadToEnd();

            XmlSerializer serializer = new(typeof(T));
            using TextReader reader = new StringReader(decryptedMessage);
            objectOut = (T)serializer.Deserialize(reader);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return objectOut;
    }

    private static T DeSerializeObjectJsonProtect<T>(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return default;
        T objectOut = default;

        try
        {
            using FileStream fileStream = new(fileName, FileMode.Open);
            using Aes aes = Aes.Create();
            byte[] iv = new byte[aes.IV.Length];
            int numBytesToRead = aes.IV.Length;
            int numBytesRead = 0;
            while (numBytesToRead > 0)
            {
                int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                if (n == 0) break;

                numBytesRead += n;
                numBytesToRead -= n;
            }

            using CryptoStream cryptoStream = new(
               fileStream,
               aes.CreateDecryptor(key, iv),
               CryptoStreamMode.Read);
            using StreamReader decryptReader = new(cryptoStream);
            string decryptedMessage = decryptReader.ReadToEnd();

            objectOut = JsonSerializer.Deserialize<T>(decryptedMessage, options);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return objectOut;
    }

    private static T DeSerializeObjectBinaryProtect<T>(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return default;
        T objectOut = default;

        try
        {
            using FileStream fileStream = new(fileName, FileMode.Open);
            using Aes aes = Aes.Create();
            byte[] iv = new byte[aes.IV.Length];
            int numBytesToRead = aes.IV.Length;
            int numBytesRead = 0;
            while (numBytesToRead > 0)
            {
                int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                if (n == 0) break;

                numBytesRead += n;
                numBytesToRead -= n;
            }

            using CryptoStream cryptoStream = new(
               fileStream,
               aes.CreateDecryptor(key, iv),
               CryptoStreamMode.Read);
            using StreamReader decryptReader = new(cryptoStream);
            string decryptedMessage = decryptReader.ReadToEnd();

            var arr = Convert.FromBase64String(decryptedMessage);
            using var ms = new MemoryStream(arr);
            objectOut = ProtoBuf.Serializer.Deserialize<T>(ms);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return objectOut;
    }
}

public enum SerializeType
{
    html,
    json,
    binary,
    htmlProtect,
    jsonProtect,
    binaryProtect,
}