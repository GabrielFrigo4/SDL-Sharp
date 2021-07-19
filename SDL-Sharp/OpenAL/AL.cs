#region License
// Copyright (c) 2013 Antonie Blom
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SDL_Sharp.OpenAL
{
	public static partial class AL {

		public static void Enable(ALCapability capability) {
			AL32.alEnable((int)capability);
		}
		public static void Disable(ALCapability capability) {
			AL32.alDisable((int)capability);
		} 
		public static bool IsEnabled(ALCapability capability) {
			return AL32.alIsEnabled((int)capability);
		} 
		public static unsafe string GetString(ALGetString param) {
			sbyte * bptr = AL32.alGetString((int)param);
			return new string(bptr);
		}
		public static void GetBoolean(ALGetInteger param, bool[] data) {
			AL32.alGetBooleanv((int)param, data);
		}
		public static void GetInteger(ALGetInteger param, int[] data) {
			AL32.alGetIntegerv((int)param, data);
		}
		public static void GetFloat(ALGetFloat param, float[] data) {
			AL32.alGetFloatv((int)param, data);
		}
		public static bool GetBoolean(ALGetInteger param) {
			return AL32.alGetBoolean((int)param);
		}
		public static int GetInteger(ALGetInteger param) {
			return AL32.alGetInteger((int)param);
		}
		public static float GetFloat(ALGetFloat param) {
			return AL32.alGetFloat((int)param);
		}
		public static double GetDouble(int param) {
			return AL32.alGetDouble(param);
		}
		public static int GetError() {
			return AL32.alGetError();
		}
		public static bool IsExtensionPresent(string extname) {
			return AL32.alIsExtensionPresent(extname);
		}
		public static IntPtr GetProcAddress(string fname) {
			return AL32.alGetProcAddress(fname);
		}
		public static int GetEnumValue(string ename) {
			return AL32.alGetEnumValue(ename);
		}
		public static void Listener(ALListenerf param, float value) {
			AL32.alListenerf((int)param, value);
		}
		public static void Listener(ALListener3f param, float value1, float value2, float value3) {
			AL32.alListener3f((int)param, value1, value2, value3);
		}
		public static void Listener(ALListenerfv param, float[] values) {
			AL32.alListenerfv((int)param, values);
		} 
		public static void GetListener(ALListenerf param, out float value) {
			AL32.alGetListenerf((int)param, out value);
		}
		public static void GetListener(ALListener3f param, out float value1, out float value2, out float value3) {
			AL32.alGetListener3f((int)param, out value1, out value2, out value3);
		}
		public static void GetListener(ALListenerfv param, float[] values) {
			AL32.alGetListenerfv((int)param, values);
		}
		public static void GenSources(int n, uint[] sources) {
			AL32.alGenSources(n, sources);
		} 
		public static void GenSources(int n, out uint source) {
			AL32.alGenSource(n, out source);
		}
		public static uint GenSource()
		{
			AL32.alGenSource(1, out uint source);
			return source;
		}
		public static void DeleteSources(int n, uint[] sources) {
			AL32.alDeleteSources(n, sources);
		}
		public static void DeleteSources(int n, ref uint source) {
			AL32.alDeleteSource(n, ref source);
		}
		public static void DeleteSource(uint source)
		{
			AL32.alDeleteSource(1, ref source);
		}
		public static bool IsSource(uint sid) {
			return AL32.alIsSource(sid);
		} 
		public static void Source(uint sid, ALSourcef param, float value) {
			AL32.alSourcef(sid, (int)param, value);
		} 
		public static void Source(uint sid, ALSource3f param, float value1, float value2, float value3) {
			AL32.alSource3f(sid, (int)param, value1, value2, value3);
		}
		public static void Source(uint sid, ALSourcei param, int value) {
			AL32.alSourcei(sid, (int)param, value);
		} 
		public static void Source(uint sid, ALSource3i param, int value1, int value2, int value3) {
			AL32.alSource3i(sid, (int)param, value1, value2, value3);
		}
		public static void Source(uint sid, ALSourceb param, bool value) {
			AL32.alSourcei(sid, (int)param, value ? 1 : 0);
		}
		public static void GetSource(uint sid, ALSourcef param, out float value) {
			AL32.alGetSourcef(sid, (int)param, out value);
		}
		public static void GetSource(uint sid, ALSource3f param, out float value1, out float value2, out float value3) {
			AL32.alGetSource3f(sid, (int)param, out value1, out value2, out value3);
		}
		public static void GetSource(uint sid, ALSourcei param, out int value) {
			AL32.alGetSourcei(sid, (int)param, out value);
		}
		public static void GetSource(uint sid, ALSource3i param, out int value1, out int value2, out int value3) {
			AL32.alGetSource3i(sid, (int)param, out value1, out value2, out value3);
		}
		public static void GetSource(uint sid, ALSourceb param, out bool value) {
			int ivalue;
			AL32.alGetSourcei(sid, (int)param, out ivalue);
			value = (ivalue != 0);
		}
		public static void SourcePlay(int ns, uint[]sids) {
			AL32.alSourcePlayv(ns, sids);
		}
		public static void SourceStop(int ns, uint[]sids) {
			AL32.alSourceStopv(ns, sids);
		}
		public static void SourceRewind(int ns, uint[]sids) {
			AL32.alSourceRewindv(ns, sids);
		}
		public static void SourcePause(int ns, uint[]sids) {
			AL32.alSourcePausev(ns, sids);
		}
		public static void SourcePlay(uint sid) {
			AL32.alSourcePlay(sid);
		}
		public static void SourceStop(uint sid) {
			AL32.alSourceStop(sid);
		}
		public static void SourceRewind(uint sid) {
			AL32.alSourceRewind(sid);
		}
		public static void SourcePause(uint sid) {
			AL32.alSourcePause(sid);
		}
		public static void SourceQueueBuffers(uint sid, int numEntries, uint[]bids) {
			AL32.alSourceQueueBuffers(sid, numEntries, bids);
		}
		public static void SourceUnqueueBuffers(uint sid, int numEntries, uint[]bids) {
			AL32.alSourceUnqueueBuffers(sid, numEntries, bids);
		}
		public static void GenBuffers(int n, uint[] buffers) {
			AL32.alGenBuffers(n, buffers);
		}
		public static void GenBuffers(int n, out uint buffer) {
			AL32.alGenBuffer(n, out buffer);
		}
		public static uint GenBuffer()
		{
			AL32.alGenBuffer(1, out uint buffer);
			return buffer;
		}
		public static void DeleteBuffers(int n, uint[] buffers) {
			AL32.alDeleteBuffers(n, buffers);
		}
		public static void DeleteBuffers(int n, ref uint buffer) {
			AL32.alDeleteBuffer(n, ref buffer);
		}
		public static void DeleteBuffer(uint buffer)
		{
			AL32.alDeleteBuffer(1, ref buffer);
		}
		public static bool IsBuffer(uint bid) {
			return AL32.alIsBuffer(bid);
		}
		public static void BufferData(uint bid, ALFormat format, IntPtr data, int size, int freq) {
			AL32.alBufferData(bid, (int)format, data, size, freq);
		}
		public static void GetBuffer(uint bid, ALGetBufferi param, out int value) {
			AL32.alGetBufferi(bid, (int)param, out value);
		}
		public static void DopplerFactor(float value) {
			AL32.alDopplerFactor(value);
		}
		public static void DopplerVelocity(float value) {
			AL32.alDopplerVelocity(value);
		}
		public static void SpeedOfSound(float value) {
			AL32.alSpeedOfSound(value);
		}
		public static void DistanceModel(int distanceModel) {
			AL32.alDistanceModel(distanceModel);
		}
	}
}