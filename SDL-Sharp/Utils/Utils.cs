using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace SDL_Sharp.Utility;
public class Utils
{
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
            JsonSerializer.Serialize(createStream, serializableObject);
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
            BinaryFormatter formatter = new();
            FileStream stream = new(fileName, FileMode.Create);
#pragma warning disable SYSLIB0011 // O tipo ou membro é obsoleto
            formatter.Serialize(stream, serializableObject);
#pragma warning restore SYSLIB0011 // O tipo ou membro é obsoleto
            stream.Close();
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
            objectOut = JsonSerializer.Deserialize<T>(jsonString);
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
            BinaryFormatter formatter = new();
            FileStream stream = new(fileName, FileMode.Open);
#pragma warning disable SYSLIB0011 // O tipo ou membro é obsoleto
            objectOut = (T)formatter.Deserialize(stream);
#pragma warning restore SYSLIB0011 // O tipo ou membro é obsoleto
            stream.Close();
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
}