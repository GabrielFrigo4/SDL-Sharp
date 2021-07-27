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

namespace SDL_Sharp.OpenGL
{
    public enum MemoryBarrierMask : int {
        VertexAttribArrayBarrierBit = ((int)0x00000001) ,
        VertexAttribArrayBarrierBitExt = ((int)0x00000001),
        ElementArrayBarrierBit = ((int)0x00000002),
        ElementArrayBarrierBitExt = ((int)0x00000002),
        UniformBarrierBit = ((int)0x00000004),
        UniformBarrierBitExt = ((int)0x00000004),
        TextureFetchBarrierBit = ((int)0x00000008),
        TextureFetchBarrierBitExt = ((int)0x00000008),
        ShaderGlobalAccessBarrierBitNV = ((int)0x00000010),
        ShaderImageAccessBarrierBit = ((int)0x00000020),
        ShaderImageAccessBarrierBitExt = ((int)0x00000020),
        CommandBarrierBit = ((int)0x00000040),
        CommandBarrierBitExt = ((int)0x00000040),
        PixelBufferBarrierBit = ((int)0x00000080),
        PixelBufferBarrierBitExt = ((int)0x00000080),
        TextureUpdateBarrierBit = ((int)0x00000100),
        TextureUpdateBarrierBitExt = ((int)0x00000100),
        BufferUpdateBarrierBit = ((int)0x00000200),
        BufferUpdateBarrierBitExt = ((int)0x00000200),
        FrameBufferBarrierBit = ((int)0x00000400),
        FrameBufferBarrierBitExt = ((int)0x00000400),
        TransformFeedbackBarrierBit = ((int)0x00000800),
        TransformFeedbackBarrierBitExt = ((int)0x00000800),
        AtomicCounterBarrierBit = ((int)0x00001000),
        AtomicCounterBarrierBitExt = ((int)0x00001000),
        ShaderStorageBarrierBit = ((int)0x00002000),
        AllBarrierBits = (-1),
        AllBarrierBitsExt = (-1),
    }

	public enum AccumOp : int {
		Accum = ((int)0x0100)		,
		Load = ((int)0x0101)		,
		Return = ((int)0x0102)		,
		Mult = ((int)0x0103)		,
		Add = ((int)0x0104)		,
	}
	public enum ActiveAttribType : int {
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		FloatVec2 = ((int)0x8B50)		,
		FloatVec3 = ((int)0x8B51)		,
		FloatVec4 = ((int)0x8B52)		,
		IntVec2 = ((int)0x8B53)		,
		IntVec3 = ((int)0x8B54)		,
		IntVec4 = ((int)0x8B55)		,
		FloatMat2 = ((int)0x8B5A)		,
		FloatMat3 = ((int)0x8B5B)		,
		FloatMat4 = ((int)0x8B5C)		,
		UnsignedIntVec2 = ((int)0x8DC6)		,
		UnsignedIntVec3 = ((int)0x8DC7)		,
		UnsignedIntVec4 = ((int)0x8DC8)		,
		DoubleMat2 = ((int)0x8F46)		,
		DoubleMat3 = ((int)0x8F47)		,
		DoubleMat4 = ((int)0x8F48)		,
		DoubleMat2x3 = ((int)0x8F49)		,
		DoubleMat2x4 = ((int)0x8F4A)		,
		DoubleMat3x2 = ((int)0x8F4B)		,
		DoubleMat3x4 = ((int)0x8F4C)		,
		DoubleMat4x2 = ((int)0x8F4D)		,
		DoubleMat4x3 = ((int)0x8F4E)		,
		DoubleVec2 = ((int)0x8FFC)		,
		DoubleVec3 = ((int)0x8FFD)		,
		DoubleVec4 = ((int)0x8FFE)		,
	}
	public enum ActiveSubroutineUniformParameter : int {
		UniformSize = ((int)0x8A38)		,
		UniformNameLength = ((int)0x8A39)		,
		NumCompatibleSubroutines = ((int)0x8E4A)		,
		CompatibleSubroutines = ((int)0x8E4B)		,
	}
	public enum ActiveUniformBlockParameter : int {
		UniformBlockReferencedByTessControlShader = ((int)0x84F0)		,
		UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1)		,
		UniformBlockBinding = ((int)0x8A3F)		,
		UniformBlockDataSize = ((int)0x8A40)		,
		UniformBlockNameLength = ((int)0x8A41)		,
		UniformBlockActiveUniforms = ((int)0x8A42)		,
		UniformBlockActiveUniformIndices = ((int)0x8A43)		,
		UniformBlockReferencedByVertexShader = ((int)0x8A44)		,
		UniformBlockReferencedByGeometryShader = ((int)0x8A45)		,
		UniformBlockReferencedByFragmentShader = ((int)0x8A46)		,
	}
	public enum ActiveUniformParameter : int {
		UniformType = ((int)0x8A37)		,
		UniformSize = ((int)0x8A38)		,
		UniformNameLength = ((int)0x8A39)		,
		UniformBlockIndex = ((int)0x8A3A)		,
		UniformOffset = ((int)0x8A3B)		,
		UniformArrayStride = ((int)0x8A3C)		,
		UniformMatrixStride = ((int)0x8A3D)		,
		UniformIsRowMajor = ((int)0x8A3E)		,
	}
	public enum ActiveUniformType : int {
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		FloatVec2 = ((int)0x8B50)		,
		FloatVec3 = ((int)0x8B51)		,
		FloatVec4 = ((int)0x8B52)		,
		IntVec2 = ((int)0x8B53)		,
		IntVec3 = ((int)0x8B54)		,
		IntVec4 = ((int)0x8B55)		,
		Bool = ((int)0x8B56)		,
		BoolVec2 = ((int)0x8B57)		,
		BoolVec3 = ((int)0x8B58)		,
		BoolVec4 = ((int)0x8B59)		,
		FloatMat2 = ((int)0x8B5A)		,
		FloatMat3 = ((int)0x8B5B)		,
		FloatMat4 = ((int)0x8B5C)		,
		Sampler1D = ((int)0x8B5D)		,
		Sampler2D = ((int)0x8B5E)		,
		Sampler3D = ((int)0x8B5F)		,
		SamplerCube = ((int)0x8B60)		,
		Sampler1DShadow = ((int)0x8B61)		,
		Sampler2DShadow = ((int)0x8B62)		,
		Sampler2DRect = ((int)0x8B63)		,
		Sampler2DRectShadow = ((int)0x8B64)		,
		FloatMat2x3 = ((int)0x8B65)		,
		FloatMat2x4 = ((int)0x8B66)		,
		FloatMat3x2 = ((int)0x8B67)		,
		FloatMat3x4 = ((int)0x8B68)		,
		FloatMat4x2 = ((int)0x8B69)		,
		FloatMat4x3 = ((int)0x8B6A)		,
		Sampler1DArray = ((int)0x8DC0)		,
		Sampler2DArray = ((int)0x8DC1)		,
		SamplerBuffer = ((int)0x8DC2)		,
		Sampler1DArrayShadow = ((int)0x8DC3)		,
		Sampler2DArrayShadow = ((int)0x8DC4)		,
		SamplerCubeShadow = ((int)0x8DC5)		,
		UnsignedIntVec2 = ((int)0x8DC6)		,
		UnsignedIntVec3 = ((int)0x8DC7)		,
		UnsignedIntVec4 = ((int)0x8DC8)		,
		IntSampler1D = ((int)0x8DC9)		,
		IntSampler2D = ((int)0x8DCA)		,
		IntSampler3D = ((int)0x8DCB)		,
		IntSamplerCube = ((int)0x8DCC)		,
		IntSampler2DRect = ((int)0x8DCD)		,
		IntSampler1DArray = ((int)0x8DCE)		,
		IntSampler2DArray = ((int)0x8DCF)		,
		IntSamplerBuffer = ((int)0x8DD0)		,
		UnsignedIntSampler1D = ((int)0x8DD1)		,
		UnsignedIntSampler2D = ((int)0x8DD2)		,
		UnsignedIntSampler3D = ((int)0x8DD3)		,
		UnsignedIntSamplerCube = ((int)0x8DD4)		,
		UnsignedIntSampler2DRect = ((int)0x8DD5)		,
		UnsignedIntSampler1DArray = ((int)0x8DD6)		,
		UnsignedIntSampler2DArray = ((int)0x8DD7)		,
		UnsignedIntSamplerBuffer = ((int)0x8DD8)		,
		DoubleMat2 = ((int)0x8F46)		,
		DoubleMat3 = ((int)0x8F47)		,
		DoubleMat4 = ((int)0x8F48)		,
		DoubleMat2x3 = ((int)0x8F49)		,
		DoubleMat2x4 = ((int)0x8F4A)		,
		DoubleMat3x2 = ((int)0x8F4B)		,
		DoubleMat3x4 = ((int)0x8F4C)		,
		DoubleMat4x2 = ((int)0x8F4D)		,
		DoubleMat4x3 = ((int)0x8F4E)		,
		DoubleVec2 = ((int)0x8FFC)		,
		DoubleVec3 = ((int)0x8FFD)		,
		DoubleVec4 = ((int)0x8FFE)		,
		SamplerCubeMapArray = ((int)0x900C)		,
		SamplerCubeMapArrayShadow = ((int)0x900D)		,
		IntSamplerCubeMapArray = ((int)0x900E)		,
		UnsignedIntSamplerCubeMapArray = ((int)0x900F)		,
		Sampler2DMultisample = ((int)0x9108)		,
		IntSampler2DMultisample = ((int)0x9109)		,
		UnsignedIntSampler2DMultisample = ((int)0x910A)		,
		Sampler2DMultisampleArray = ((int)0x910B)		,
		IntSampler2DMultisampleArray = ((int)0x910C)		,
		UnsignedIntSampler2DMultisampleArray = ((int)0x910D)		,
	}
	public enum AlphaFunction : int {
		Never = ((int)0x0200)		,
		Less = ((int)0x0201)		,
		Equal = ((int)0x0202)		,
		Lequal = ((int)0x0203)		,
		Greater = ((int)0x0204)		,
		Notequal = ((int)0x0205)		,
		Gequal = ((int)0x0206)		,
		Always = ((int)0x0207)		,
	}
	/*public enum AmdBlendMinmaxFactor : int {
		FactorMinAmd = ((int)0x901C)		,
		FactorMaxAmd = ((int)0x901D)		,
	}
	public enum AmdCompressed3DcTexture : int {
		Gl3DcXAmd = ((int)0x87F9)		,
		Gl3DcXyAmd = ((int)0x87FA)		,
	}
	public enum AmdCompressedAtcTexture : int {
		AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE)		,
		AtcRgbAmd = ((int)0x8C92)		,
		AtcRgbaExplicitAlphaAmd = ((int)0x8C93)		,
	}
	public enum AmdConservativeDepth : int {
	}
	public enum AmdDebugOutput : int {
		MaxDebugLoggedMessagesAmd = ((int)0x9144)		,
		DebugLoggedMessagesAmd = ((int)0x9145)		,
		DebugSeverityHighAmd = ((int)0x9146)		,
		DebugSeverityMediumAmd = ((int)0x9147)		,
		DebugSeverityLowAmd = ((int)0x9148)		,
		DebugCategoryApiErrorAmd = ((int)0x9149)		,
		DebugCategoryWindowSystemAmd = ((int)0x914A)		,
		DebugCategoryDeprecationAmd = ((int)0x914B)		,
		DebugCategoryUndefinedBehaviorAmd = ((int)0x914C)		,
		DebugCategoryPerformanceAmd = ((int)0x914D)		,
		DebugCategoryShaderCompilerAmd = ((int)0x914E)		,
		DebugCategoryApplicationAmd = ((int)0x914F)		,
		DebugCategoryOtherAmd = ((int)0x9150)		,
	}
	public enum AmdDepthClampSeparate : int {
		DepthClampNearAmd = ((int)0x901E)		,
		DepthClampFarAmd = ((int)0x901F)		,
	}
	public enum AmdDrawBuffersBlend : int {
	}
	public enum AmdMultiDrawIndirect : int {
	}
	public enum AmdNameGenDelete : int {
		DataBufferAmd = ((int)0x9151)		,
		PerformanceMonitorAmd = ((int)0x9152)		,
		QueryObjectAmd = ((int)0x9153)		,
		VertexArrayObjectAmd = ((int)0x9154)		,
		SamplerObjectAmd = ((int)0x9155)		,
	}
	public enum AmdPerformanceMonitor : int {
		CounterTypeAmd = ((int)0x8BC0)		,
		CounterRangeAmd = ((int)0x8BC1)		,
		UnsignedInt64Amd = ((int)0x8BC2)		,
		PercentageAmd = ((int)0x8BC3)		,
		PerfmonResultAvailableAmd = ((int)0x8BC4)		,
		PerfmonResultSizeAmd = ((int)0x8BC5)		,
		PerfmonResultAmd = ((int)0x8BC6)		,
	}
	public enum AmdProgramBinaryZ400 : int {
		Z400BinaryAmd = ((int)0x8740)		,
	}
	public enum AmdSamplePositions : int {
		SubsampleDistanceAmd = ((int)0x883F)		,
	}
	public enum AmdSeamlessCubemapPerTexture : int {
		TextureCubeMapSeamless = ((int)0x884F)		,
	}
	public enum AmdShaderStencilExport : int {
	}
	public enum AmdTextureTexture4 : int {
	}
	public enum AmdTransformFeedback3LinesTriangles : int {
	}
	public enum AmdVertexShaderTesselator : int {
		SamplerBufferAmd = ((int)0x9001)		,
		IntSamplerBufferAmd = ((int)0x9002)		,
		UnsignedIntSamplerBufferAmd = ((int)0x9003)		,
		TessellationModeAmd = ((int)0x9004)		,
		TessellationFactorAmd = ((int)0x9005)		,
		DiscreteAmd = ((int)0x9006)		,
		ContinuousAmd = ((int)0x9007)		,
	}*/
	public enum AngleFramebufferBlit : int {
		FramebufferBindingAngle = ((int)0x8CA6)		,
		RenderbufferBindingAngle = ((int)0x8CA7)		,
		ReadFramebufferAngle = ((int)0x8CA8)		,
		DrawFramebufferAngle = ((int)0x8CA9)		,
	}
	public enum AngleFramebufferMultisample : int {
		RenderbufferSamplesAngle = ((int)0x8CAB)		,
		FramebufferIncompleteMultisampleAngle = ((int)0x8D56)		,
		MaxSamplesAngle = ((int)0x8D57)		,
	}
	/*public enum AppleAuxDepthStencil : int {
		AuxDepthStencilApple = ((int)0x8A14)		,
	}
	public enum AppleClientStorage : int {
		UnpackClientStorageApple = ((int)0x85B2)		,
	}
	public enum AppleElementArray : int {
		ElementArrayApple = ((int)0x8A0C)		,
		ElementArrayTypeApple = ((int)0x8A0D)		,
		ElementArrayPointerApple = ((int)0x8A0E)		,
	}
	public enum AppleFence : int {
		DrawPixelsApple = ((int)0x8A0A)		,
		FenceApple = ((int)0x8A0B)		,
	}
	public enum AppleFloatPixels : int {
		HalfApple = ((int)0x140B)		,
		RgbaFloat32Apple = ((int)0x8814)		,
		RgbFloat32Apple = ((int)0x8815)		,
		AlphaFloat32Apple = ((int)0x8816)		,
		IntensityFloat32Apple = ((int)0x8817)		,
		LuminanceFloat32Apple = ((int)0x8818)		,
		LuminanceAlphaFloat32Apple = ((int)0x8819)		,
		RgbaFloat16Apple = ((int)0x881A)		,
		RgbFloat16Apple = ((int)0x881B)		,
		AlphaFloat16Apple = ((int)0x881C)		,
		IntensityFloat16Apple = ((int)0x881D)		,
		LuminanceFloat16Apple = ((int)0x881E)		,
		LuminanceAlphaFloat16Apple = ((int)0x881F)		,
		ColorFloatApple = ((int)0x8A0F)		,
	}
	public enum AppleFlushBufferRange : int {
		BufferSerializedModifyApple = ((int)0x8A12)		,
		BufferFlushingUnmapApple = ((int)0x8A13)		,
	}
	public enum AppleObjectPurgeable : int {
		BufferObjectApple = ((int)0x85B3)		,
		ReleasedApple = ((int)0x8A19)		,
		VolatileApple = ((int)0x8A1A)		,
		RetainedApple = ((int)0x8A1B)		,
		UndefinedApple = ((int)0x8A1C)		,
		PurgeableApple = ((int)0x8A1D)		,
	}
	public enum AppleRgb422 : int {
		UnsignedShort88Apple = ((int)0x85BA)		,
		UnsignedShort88RevApple = ((int)0x85BB)		,
		Rgb422Apple = ((int)0x8A1F)		,
	}
	public enum AppleRowBytes : int {
		PackRowBytesApple = ((int)0x8A15)		,
		UnpackRowBytesApple = ((int)0x8A16)		,
	}
	public enum AppleSpecularVector : int {
		LightModelSpecularVectorApple = ((int)0x85B0)		,
	}
	public enum AppleTextureRange : int {
		TextureRangeLengthApple = ((int)0x85B7)		,
		TextureRangePointerApple = ((int)0x85B8)		,
		TextureStorageHintApple = ((int)0x85BC)		,
		StoragePrivateApple = ((int)0x85BD)		,
		StorageCachedApple = ((int)0x85BE)		,
		StorageSharedApple = ((int)0x85BF)		,
	}
	public enum AppleTransformHint : int {
		TransformHintApple = ((int)0x85B1)		,
	}
	public enum AppleVertexArrayObject : int {
		VertexArrayBindingApple = ((int)0x85B5)		,
	}
	public enum AppleVertexArrayRange : int {
		VertexArrayRangeApple = ((int)0x851D)		,
		VertexArrayRangeLengthApple = ((int)0x851E)		,
		VertexArrayStorageHintApple = ((int)0x851F)		,
		VertexArrayRangePointerApple = ((int)0x8521)		,
		StorageClientApple = ((int)0x85B4)		,
		StorageCachedApple = ((int)0x85BE)		,
		StorageSharedApple = ((int)0x85BF)		,
	}
	public enum AppleVertexProgramEvaluators : int {
		VertexAttribMap1Apple = ((int)0x8A00)		,
		VertexAttribMap2Apple = ((int)0x8A01)		,
		VertexAttribMap1SizeApple = ((int)0x8A02)		,
		VertexAttribMap1CoeffApple = ((int)0x8A03)		,
		VertexAttribMap1OrderApple = ((int)0x8A04)		,
		VertexAttribMap1DomainApple = ((int)0x8A05)		,
		VertexAttribMap2SizeApple = ((int)0x8A06)		,
		VertexAttribMap2CoeffApple = ((int)0x8A07)		,
		VertexAttribMap2OrderApple = ((int)0x8A08)		,
		VertexAttribMap2DomainApple = ((int)0x8A09)		,
	}
	public enum AppleYcbcr422 : int {
		Ycbcr422Apple = ((int)0x85B9)		,
		UnsignedShort88Apple = ((int)0x85BA)		,
		UnsignedShort88RevApple = ((int)0x85BB)		,
	}*/
	/*public enum ArbBlendFuncExtended : int {
		Src1Alpha = ((int)0x8589)		,
		Src1Color = ((int)0x88F9)		,
		OneMinusSrc1Color = ((int)0x88FA)		,
		OneMinusSrc1Alpha = ((int)0x88FB)		,
		MaxDualSourceDrawBuffers = ((int)0x88FC)		,
	}
	public enum ArbClEvent : int {
		SyncClEventArb = ((int)0x8240)		,
		SyncClEventCompleteArb = ((int)0x8241)		,
	}
	public enum ArbColorBufferFloat : int {
		RgbaFloatModeArb = ((int)0x8820)		,
		ClampVertexColorArb = ((int)0x891A)		,
		ClampFragmentColorArb = ((int)0x891B)		,
		ClampReadColorArb = ((int)0x891C)		,
		FixedOnlyArb = ((int)0x891D)		,
	}
	public enum ArbCompatibility : int {
	}
	public enum ArbCopyBuffer : int {
		CopyReadBuffer = ((int)0x8F36)		,
		CopyWriteBuffer = ((int)0x8F37)		,
	}
	public enum ArbDebugOutput : int {
		DebugOutputSynchronousArb = ((int)0x8242)		,
		DebugNextLoggedMessageLengthArb = ((int)0x8243)		,
		DebugCallbackFunctionArb = ((int)0x8244)		,
		DebugCallbackUserParamArb = ((int)0x8245)		,
		DebugSourceApiArb = ((int)0x8246)		,
		DebugSourceWindowSystemArb = ((int)0x8247)		,
		DebugSourceShaderCompilerArb = ((int)0x8248)		,
		DebugSourceThirdPartyArb = ((int)0x8249)		,
		DebugSourceApplicationArb = ((int)0x824A)		,
		DebugSourceOtherArb = ((int)0x824B)		,
		DebugTypeErrorArb = ((int)0x824C)		,
		DebugTypeDeprecatedBehaviorArb = ((int)0x824D)		,
		DebugTypeUndefinedBehaviorArb = ((int)0x824E)		,
		DebugTypePortabilityArb = ((int)0x824F)		,
		DebugTypePerformanceArb = ((int)0x8250)		,
		DebugTypeOtherArb = ((int)0x8251)		,
		MaxDebugMessageLengthArb = ((int)0x9143)		,
		MaxDebugLoggedMessagesArb = ((int)0x9144)		,
		DebugLoggedMessagesArb = ((int)0x9145)		,
		DebugSeverityHighArb = ((int)0x9146)		,
		DebugSeverityMediumArb = ((int)0x9147)		,
		DebugSeverityLowArb = ((int)0x9148)		,
	}
	public enum ArbDepthBufferFloat : int {
		DepthComponent32f = ((int)0x8CAC)		,
		Depth32fStencil8 = ((int)0x8CAD)		,
		Float32UnsignedInt248Rev = ((int)0x8DAD)		,
	}
	public enum ArbDepthClamp : int {
		DepthClamp = ((int)0x864F)		,
	}
	public enum ArbDepthTexture : int {
		DepthComponent16Arb = ((int)0x81A5)		,
		DepthComponent24Arb = ((int)0x81A6)		,
		DepthComponent32Arb = ((int)0x81A7)		,
		TextureDepthSizeArb = ((int)0x884A)		,
		DepthTextureModeArb = ((int)0x884B)		,
	}
	public enum ArbDrawBuffers : int {
		MaxDrawBuffersArb = ((int)0x8824)		,
		DrawBuffer0Arb = ((int)0x8825)		,
		DrawBuffer1Arb = ((int)0x8826)		,
		DrawBuffer2Arb = ((int)0x8827)		,
		DrawBuffer3Arb = ((int)0x8828)		,
		DrawBuffer4Arb = ((int)0x8829)		,
		DrawBuffer5Arb = ((int)0x882A)		,
		DrawBuffer6Arb = ((int)0x882B)		,
		DrawBuffer7Arb = ((int)0x882C)		,
		DrawBuffer8Arb = ((int)0x882D)		,
		DrawBuffer9Arb = ((int)0x882E)		,
		DrawBuffer10Arb = ((int)0x882F)		,
		DrawBuffer11Arb = ((int)0x8830)		,
		DrawBuffer12Arb = ((int)0x8831)		,
		DrawBuffer13Arb = ((int)0x8832)		,
		DrawBuffer14Arb = ((int)0x8833)		,
		DrawBuffer15Arb = ((int)0x8834)		,
	}
	public enum ArbDrawBuffersBlend : int {
	}
	public enum ArbDrawElementsBaseVertex : int {
	}*/
	public enum ArbDrawIndirect : int {
		DrawIndirectBuffer = ((int)0x8F3F)		,
		DrawIndirectBufferBinding = ((int)0x8F43)		,
	}
	/*public enum ArbDrawInstanced : int {
	}
	public enum ArbEs2Compatibility : int {
		Fixed = ((int)0x140C)		,
		ImplementationColorReadType = ((int)0x8B9A)		,
		ImplementationColorReadFormat = ((int)0x8B9B)		,
		LowFloat = ((int)0x8DF0)		,
		MediumFloat = ((int)0x8DF1)		,
		HighFloat = ((int)0x8DF2)		,
		LowInt = ((int)0x8DF3)		,
		MediumInt = ((int)0x8DF4)		,
		HighInt = ((int)0x8DF5)		,
		ShaderBinaryFormats = ((int)0x8DF8)		,
		NumShaderBinaryFormats = ((int)0x8DF9)		,
		ShaderCompiler = ((int)0x8DFA)		,
		MaxVertexUniformVectors = ((int)0x8DFB)		,
		MaxVaryingVectors = ((int)0x8DFC)		,
		MaxFragmentUniformVectors = ((int)0x8DFD)		,
	}
	public enum ArbExplicitAttribLocation : int {
	}
	public enum ArbFragmentCoordConventions : int {
	}
	public enum ArbFragmentProgram : int {
		VertexProgramArb = ((int)0x8620)		,
		VertexAttribArrayEnabledArb = ((int)0x8622)		,
		VertexAttribArraySizeArb = ((int)0x8623)		,
		VertexAttribArrayStrideArb = ((int)0x8624)		,
		VertexAttribArrayTypeArb = ((int)0x8625)		,
		CurrentVertexAttribArb = ((int)0x8626)		,
		ProgramLengthArb = ((int)0x8627)		,
		ProgramStringArb = ((int)0x8628)		,
		MaxProgramMatrixStackDepthArb = ((int)0x862E)		,
		MaxProgramMatricesArb = ((int)0x862F)		,
		CurrentMatrixStackDepthArb = ((int)0x8640)		,
		CurrentMatrixArb = ((int)0x8641)		,
		VertexProgramPointSizeArb = ((int)0x8642)		,
		VertexProgramTwoSideArb = ((int)0x8643)		,
		VertexAttribArrayPointerArb = ((int)0x8645)		,
		ProgramErrorPositionArb = ((int)0x864B)		,
		ProgramBindingArb = ((int)0x8677)		,
		FragmentProgramArb = ((int)0x8804)		,
		ProgramAluInstructionsArb = ((int)0x8805)		,
		ProgramTexInstructionsArb = ((int)0x8806)		,
		ProgramTexIndirectionsArb = ((int)0x8807)		,
		ProgramNativeAluInstructionsArb = ((int)0x8808)		,
		ProgramNativeTexInstructionsArb = ((int)0x8809)		,
		ProgramNativeTexIndirectionsArb = ((int)0x880A)		,
		MaxProgramAluInstructionsArb = ((int)0x880B)		,
		MaxProgramTexInstructionsArb = ((int)0x880C)		,
		MaxProgramTexIndirectionsArb = ((int)0x880D)		,
		MaxProgramNativeAluInstructionsArb = ((int)0x880E)		,
		MaxProgramNativeTexInstructionsArb = ((int)0x880F)		,
		MaxProgramNativeTexIndirectionsArb = ((int)0x8810)		,
		MaxTextureCoordsArb = ((int)0x8871)		,
		MaxTextureImageUnitsArb = ((int)0x8872)		,
		ProgramErrorStringArb = ((int)0x8874)		,
		ProgramFormatAsciiArb = ((int)0x8875)		,
		ProgramFormatArb = ((int)0x8876)		,
		ProgramInstructionsArb = ((int)0x88A0)		,
		MaxProgramInstructionsArb = ((int)0x88A1)		,
		ProgramNativeInstructionsArb = ((int)0x88A2)		,
		MaxProgramNativeInstructionsArb = ((int)0x88A3)		,
		ProgramTemporariesArb = ((int)0x88A4)		,
		MaxProgramTemporariesArb = ((int)0x88A5)		,
		ProgramNativeTemporariesArb = ((int)0x88A6)		,
		MaxProgramNativeTemporariesArb = ((int)0x88A7)		,
		ProgramParametersArb = ((int)0x88A8)		,
		MaxProgramParametersArb = ((int)0x88A9)		,
		ProgramNativeParametersArb = ((int)0x88AA)		,
		MaxProgramNativeParametersArb = ((int)0x88AB)		,
		ProgramAttribsArb = ((int)0x88AC)		,
		MaxProgramAttribsArb = ((int)0x88AD)		,
		ProgramNativeAttribsArb = ((int)0x88AE)		,
		MaxProgramNativeAttribsArb = ((int)0x88AF)		,
		ProgramAddressRegistersArb = ((int)0x88B0)		,
		MaxProgramAddressRegistersArb = ((int)0x88B1)		,
		ProgramNativeAddressRegistersArb = ((int)0x88B2)		,
		MaxProgramNativeAddressRegistersArb = ((int)0x88B3)		,
		MaxProgramLocalParametersArb = ((int)0x88B4)		,
		MaxProgramEnvParametersArb = ((int)0x88B5)		,
		ProgramUnderNativeLimitsArb = ((int)0x88B6)		,
		TransposeCurrentMatrixArb = ((int)0x88B7)		,
		Matrix0Arb = ((int)0x88C0)		,
		Matrix1Arb = ((int)0x88C1)		,
		Matrix2Arb = ((int)0x88C2)		,
		Matrix3Arb = ((int)0x88C3)		,
		Matrix4Arb = ((int)0x88C4)		,
		Matrix5Arb = ((int)0x88C5)		,
		Matrix6Arb = ((int)0x88C6)		,
		Matrix7Arb = ((int)0x88C7)		,
		Matrix8Arb = ((int)0x88C8)		,
		Matrix9Arb = ((int)0x88C9)		,
		Matrix10Arb = ((int)0x88CA)		,
		Matrix11Arb = ((int)0x88CB)		,
		Matrix12Arb = ((int)0x88CC)		,
		Matrix13Arb = ((int)0x88CD)		,
		Matrix14Arb = ((int)0x88CE)		,
		Matrix15Arb = ((int)0x88CF)		,
		Matrix16Arb = ((int)0x88D0)		,
		Matrix17Arb = ((int)0x88D1)		,
		Matrix18Arb = ((int)0x88D2)		,
		Matrix19Arb = ((int)0x88D3)		,
		Matrix20Arb = ((int)0x88D4)		,
		Matrix21Arb = ((int)0x88D5)		,
		Matrix22Arb = ((int)0x88D6)		,
		Matrix23Arb = ((int)0x88D7)		,
		Matrix24Arb = ((int)0x88D8)		,
		Matrix25Arb = ((int)0x88D9)		,
		Matrix26Arb = ((int)0x88DA)		,
		Matrix27Arb = ((int)0x88DB)		,
		Matrix28Arb = ((int)0x88DC)		,
		Matrix29Arb = ((int)0x88DD)		,
		Matrix30Arb = ((int)0x88DE)		,
		Matrix31Arb = ((int)0x88DF)		,
	}
	public enum ArbFragmentProgramShadow : int {
	}
	public enum ArbFragmentShader : int {
		FragmentShaderArb = ((int)0x8B30)		,
		MaxFragmentUniformComponentsArb = ((int)0x8B49)		,
		FragmentShaderDerivativeHintArb = ((int)0x8B8B)		,
	}
	public enum ArbFramebufferObject : int {
		InvalidFramebufferOperation = ((int)0x0506)		,
		FramebufferAttachmentColorEncoding = ((int)0x8210)		,
		FramebufferAttachmentComponentType = ((int)0x8211)		,
		FramebufferAttachmentRedSize = ((int)0x8212)		,
		FramebufferAttachmentGreenSize = ((int)0x8213)		,
		FramebufferAttachmentBlueSize = ((int)0x8214)		,
		FramebufferAttachmentAlphaSize = ((int)0x8215)		,
		FramebufferAttachmentDepthSize = ((int)0x8216)		,
		FramebufferAttachmentStencilSize = ((int)0x8217)		,
		FramebufferDefault = ((int)0x8218)		,
		FramebufferUndefined = ((int)0x8219)		,
		DepthStencilAttachment = ((int)0x821A)		,
		Index = ((int)0x8222)		,
		MaxRenderbufferSize = ((int)0x84E8)		,
		DepthStencil = ((int)0x84F9)		,
		UnsignedInt248 = ((int)0x84FA)		,
		Depth24Stencil8 = ((int)0x88F0)		,
		TextureStencilSize = ((int)0x88F1)		,
		TextureRedType = ((int)0x8C10)		,
		TextureGreenType = ((int)0x8C11)		,
		TextureBlueType = ((int)0x8C12)		,
		TextureAlphaType = ((int)0x8C13)		,
		TextureLuminanceType = ((int)0x8C14)		,
		TextureIntensityType = ((int)0x8C15)		,
		TextureDepthType = ((int)0x8C16)		,
		UnsignedNormalized = ((int)0x8C17)		,
		DrawFramebufferBinding = ((int)0x8CA6)		,
		FramebufferBinding = ((int)0x8CA6)		,
		RenderbufferBinding = ((int)0x8CA7)		,
		ReadFramebuffer = ((int)0x8CA8)		,
		DrawFramebuffer = ((int)0x8CA9)		,
		ReadFramebufferBinding = ((int)0x8CAA)		,
		RenderbufferSamples = ((int)0x8CAB)		,
		FramebufferAttachmentObjectType = ((int)0x8CD0)		,
		FramebufferAttachmentObjectName = ((int)0x8CD1)		,
		FramebufferAttachmentTextureLevel = ((int)0x8CD2)		,
		FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)		,
		FramebufferAttachmentTextureLayer = ((int)0x8CD4)		,
		FramebufferComplete = ((int)0x8CD5)		,
		FramebufferIncompleteAttachment = ((int)0x8CD6)		,
		FramebufferIncompleteMissingAttachment = ((int)0x8CD7)		,
		FramebufferIncompleteDrawBuffer = ((int)0x8CDB)		,
		FramebufferIncompleteReadBuffer = ((int)0x8CDC)		,
		FramebufferUnsupported = ((int)0x8CDD)		,
		MaxColorAttachments = ((int)0x8CDF)		,
		ColorAttachment0 = ((int)0x8CE0)		,
		ColorAttachment1 = ((int)0x8CE1)		,
		ColorAttachment2 = ((int)0x8CE2)		,
		ColorAttachment3 = ((int)0x8CE3)		,
		ColorAttachment4 = ((int)0x8CE4)		,
		ColorAttachment5 = ((int)0x8CE5)		,
		ColorAttachment6 = ((int)0x8CE6)		,
		ColorAttachment7 = ((int)0x8CE7)		,
		ColorAttachment8 = ((int)0x8CE8)		,
		ColorAttachment9 = ((int)0x8CE9)		,
		ColorAttachment10 = ((int)0x8CEA)		,
		ColorAttachment11 = ((int)0x8CEB)		,
		ColorAttachment12 = ((int)0x8CEC)		,
		ColorAttachment13 = ((int)0x8CED)		,
		ColorAttachment14 = ((int)0x8CEE)		,
		ColorAttachment15 = ((int)0x8CEF)		,
		DepthAttachment = ((int)0x8D00)		,
		StencilAttachment = ((int)0x8D20)		,
		Framebuffer = ((int)0x8D40)		,
		Renderbuffer = ((int)0x8D41)		,
		RenderbufferWidth = ((int)0x8D42)		,
		RenderbufferHeight = ((int)0x8D43)		,
		RenderbufferInternalFormat = ((int)0x8D44)		,
		StencilIndex1 = ((int)0x8D46)		,
		StencilIndex4 = ((int)0x8D47)		,
		StencilIndex8 = ((int)0x8D48)		,
		StencilIndex16 = ((int)0x8D49)		,
		RenderbufferRedSize = ((int)0x8D50)		,
		RenderbufferGreenSize = ((int)0x8D51)		,
		RenderbufferBlueSize = ((int)0x8D52)		,
		RenderbufferAlphaSize = ((int)0x8D53)		,
		RenderbufferDepthSize = ((int)0x8D54)		,
		RenderbufferStencilSize = ((int)0x8D55)		,
		FramebufferIncompleteMultisample = ((int)0x8D56)		,
		MaxSamples = ((int)0x8D57)		,
	}
	public enum ArbFramebufferObjectDeprecated : int {
		Index = ((int)0x8222)		,
		TextureLuminanceType = ((int)0x8C14)		,
		TextureIntensityType = ((int)0x8C15)		,
	}
	public enum ArbFramebufferSrgb : int {
		FramebufferSrgb = ((int)0x8DB9)		,
	}
	public enum ArbGeometryShader4 : int {
		LinesAdjacencyArb = ((int)0x000A)		,
		LineStripAdjacencyArb = ((int)0x000B)		,
		TrianglesAdjacencyArb = ((int)0x000C)		,
		TriangleStripAdjacencyArb = ((int)0x000D)		,
		ProgramPointSizeArb = ((int)0x8642)		,
		MaxVaryingComponents = ((int)0x8B4B)		,
		MaxGeometryTextureImageUnitsArb = ((int)0x8C29)		,
		FramebufferAttachmentTextureLayer = ((int)0x8CD4)		,
		FramebufferAttachmentLayeredArb = ((int)0x8DA7)		,
		FramebufferIncompleteLayerTargetsArb = ((int)0x8DA8)		,
		FramebufferIncompleteLayerCountArb = ((int)0x8DA9)		,
		GeometryShaderArb = ((int)0x8DD9)		,
		GeometryVerticesOutArb = ((int)0x8DDA)		,
		GeometryInputTypeArb = ((int)0x8DDB)		,
		GeometryOutputTypeArb = ((int)0x8DDC)		,
		MaxGeometryVaryingComponentsArb = ((int)0x8DDD)		,
		MaxVertexVaryingComponentsArb = ((int)0x8DDE)		,
		MaxGeometryUniformComponentsArb = ((int)0x8DDF)		,
		MaxGeometryOutputVerticesArb = ((int)0x8DE0)		,
		MaxGeometryTotalOutputComponentsArb = ((int)0x8DE1)		,
	}
	public enum ArbGetProgramBinary : int {
		ProgramBinaryRetrievableHint = ((int)0x8257)		,
		ProgramBinaryLength = ((int)0x8741)		,
		NumProgramBinaryFormats = ((int)0x87FE)		,
		ProgramBinaryFormats = ((int)0x87FF)		,
	}
	public enum ArbGpuShader5 : int {
		GeometryShaderInvocations = ((int)0x887F)		,
		MaxGeometryShaderInvocations = ((int)0x8E5A)		,
		MinFragmentInterpolationOffset = ((int)0x8E5B)		,
		MaxFragmentInterpolationOffset = ((int)0x8E5C)		,
		FragmentInterpolationOffsetBits = ((int)0x8E5D)		,
		MaxVertexStreams = ((int)0x8E71)		,
	}
	public enum ArbGpuShaderFp64 : int {
		Double = ((int)0x140A)		,
		DoubleMat2 = ((int)0x8F46)		,
		DoubleMat3 = ((int)0x8F47)		,
		DoubleMat4 = ((int)0x8F48)		,
		DoubleMat2x3 = ((int)0x8F49)		,
		DoubleMat2x4 = ((int)0x8F4A)		,
		DoubleMat3x2 = ((int)0x8F4B)		,
		DoubleMat3x4 = ((int)0x8F4C)		,
		DoubleMat4x2 = ((int)0x8F4D)		,
		DoubleMat4x3 = ((int)0x8F4E)		,
		DoubleVec2 = ((int)0x8FFC)		,
		DoubleVec3 = ((int)0x8FFD)		,
		DoubleVec4 = ((int)0x8FFE)		,
	}
	public enum ArbHalfFloatPixel : int {
		HalfFloatArb = ((int)0x140B)		,
	}
	public enum ArbHalfFloatVertex : int {
		HalfFloat = ((int)0x140B)		,
	}
	public enum ArbImaging : int {
		ConstantColor = ((int)0x8001)		,
		OneMinusConstantColor = ((int)0x8002)		,
		ConstantAlpha = ((int)0x8003)		,
		OneMinusConstantAlpha = ((int)0x8004)		,
		BlendColor = ((int)0x8005)		,
		FuncAdd = ((int)0x8006)		,
		Min = ((int)0x8007)		,
		Max = ((int)0x8008)		,
		BlendEquation = ((int)0x8009)		,
		FuncSubtract = ((int)0x800A)		,
		FuncReverseSubtract = ((int)0x800B)		,
	}
	public enum ArbImagingDeprecated : int {
		Convolution1D = ((int)0x8010)		,
		Convolution2D = ((int)0x8011)		,
		Separable2D = ((int)0x8012)		,
		ConvolutionBorderMode = ((int)0x8013)		,
		ConvolutionFilterScale = ((int)0x8014)		,
		ConvolutionFilterBias = ((int)0x8015)		,
		Reduce = ((int)0x8016)		,
		ConvolutionFormat = ((int)0x8017)		,
		ConvolutionWidth = ((int)0x8018)		,
		ConvolutionHeight = ((int)0x8019)		,
		MaxConvolutionWidth = ((int)0x801A)		,
		MaxConvolutionHeight = ((int)0x801B)		,
		PostConvolutionRedScale = ((int)0x801C)		,
		PostConvolutionGreenScale = ((int)0x801D)		,
		PostConvolutionBlueScale = ((int)0x801E)		,
		PostConvolutionAlphaScale = ((int)0x801F)		,
		PostConvolutionRedBias = ((int)0x8020)		,
		PostConvolutionGreenBias = ((int)0x8021)		,
		PostConvolutionBlueBias = ((int)0x8022)		,
		PostConvolutionAlphaBias = ((int)0x8023)		,
		Histogram = ((int)0x8024)		,
		ProxyHistogram = ((int)0x8025)		,
		HistogramWidth = ((int)0x8026)		,
		HistogramFormat = ((int)0x8027)		,
		HistogramRedSize = ((int)0x8028)		,
		HistogramGreenSize = ((int)0x8029)		,
		HistogramBlueSize = ((int)0x802A)		,
		HistogramAlphaSize = ((int)0x802B)		,
		HistogramLuminanceSize = ((int)0x802C)		,
		HistogramSink = ((int)0x802D)		,
		Minmax = ((int)0x802E)		,
		MinmaxFormat = ((int)0x802F)		,
		MinmaxSink = ((int)0x8030)		,
		TableTooLarge = ((int)0x8031)		,
		ColorMatrix = ((int)0x80B1)		,
		ColorMatrixStackDepth = ((int)0x80B2)		,
		MaxColorMatrixStackDepth = ((int)0x80B3)		,
		PostColorMatrixRedScale = ((int)0x80B4)		,
		PostColorMatrixGreenScale = ((int)0x80B5)		,
		PostColorMatrixBlueScale = ((int)0x80B6)		,
		PostColorMatrixAlphaScale = ((int)0x80B7)		,
		PostColorMatrixRedBias = ((int)0x80B8)		,
		PostColorMatrixGreenBias = ((int)0x80B9)		,
		PostColorMatrixBlueBias = ((int)0x80BA)		,
		PostColorMatrixAlphaBias = ((int)0x80BB)		,
		ColorTable = ((int)0x80D0)		,
		PostConvolutionColorTable = ((int)0x80D1)		,
		PostColorMatrixColorTable = ((int)0x80D2)		,
		ProxyColorTable = ((int)0x80D3)		,
		ProxyPostConvolutionColorTable = ((int)0x80D4)		,
		ProxyPostColorMatrixColorTable = ((int)0x80D5)		,
		ColorTableScale = ((int)0x80D6)		,
		ColorTableBias = ((int)0x80D7)		,
		ColorTableFormat = ((int)0x80D8)		,
		ColorTableWidth = ((int)0x80D9)		,
		ColorTableRedSize = ((int)0x80DA)		,
		ColorTableGreenSize = ((int)0x80DB)		,
		ColorTableBlueSize = ((int)0x80DC)		,
		ColorTableAlphaSize = ((int)0x80DD)		,
		ColorTableLuminanceSize = ((int)0x80DE)		,
		ColorTableIntensitySize = ((int)0x80DF)		,
		ConstantBorder = ((int)0x8151)		,
		ReplicateBorder = ((int)0x8153)		,
		ConvolutionBorderColor = ((int)0x8154)		,
	}
	public enum ArbInstancedArrays : int {
		VertexAttribArrayDivisorArb = ((int)0x88FE)		,
	}
	public enum ArbMapBufferRange : int {
		MapReadBit = ((int)0x0001)		,
		MapWriteBit = ((int)0x0002)		,
		MapInvalidateRangeBit = ((int)0x0004)		,
		MapInvalidateBufferBit = ((int)0x0008)		,
		MapFlushExplicitBit = ((int)0x0010)		,
		MapUnsynchronizedBit = ((int)0x0020)		,
	}
	public enum ArbMatrixPalette : int {
		MatrixPaletteArb = ((int)0x8840)		,
		MaxMatrixPaletteStackDepthArb = ((int)0x8841)		,
		MaxPaletteMatricesArb = ((int)0x8842)		,
		CurrentPaletteMatrixArb = ((int)0x8843)		,
		MatrixIndexArrayArb = ((int)0x8844)		,
		CurrentMatrixIndexArb = ((int)0x8845)		,
		MatrixIndexArraySizeArb = ((int)0x8846)		,
		MatrixIndexArrayTypeArb = ((int)0x8847)		,
		MatrixIndexArrayStrideArb = ((int)0x8848)		,
		MatrixIndexArrayPointerArb = ((int)0x8849)		,
	}
	public enum ArbMultisample : int {
		MultisampleBitArb = ((int)0x20000000)		,
		MultisampleArb = ((int)0x809D)		,
		SampleAlphaToCoverageArb = ((int)0x809E)		,
		SampleAlphaToOneArb = ((int)0x809F)		,
		SampleCoverageArb = ((int)0x80A0)		,
		SampleBuffersArb = ((int)0x80A8)		,
		SamplesArb = ((int)0x80A9)		,
		SampleCoverageValueArb = ((int)0x80AA)		,
		SampleCoverageInvertArb = ((int)0x80AB)		,
	}
	public enum ArbMultitexture : int {
		Texture0Arb = ((int)0x84C0)		,
		Texture1Arb = ((int)0x84C1)		,
		Texture2Arb = ((int)0x84C2)		,
		Texture3Arb = ((int)0x84C3)		,
		Texture4Arb = ((int)0x84C4)		,
		Texture5Arb = ((int)0x84C5)		,
		Texture6Arb = ((int)0x84C6)		,
		Texture7Arb = ((int)0x84C7)		,
		Texture8Arb = ((int)0x84C8)		,
		Texture9Arb = ((int)0x84C9)		,
		Texture10Arb = ((int)0x84CA)		,
		Texture11Arb = ((int)0x84CB)		,
		Texture12Arb = ((int)0x84CC)		,
		Texture13Arb = ((int)0x84CD)		,
		Texture14Arb = ((int)0x84CE)		,
		Texture15Arb = ((int)0x84CF)		,
		Texture16Arb = ((int)0x84D0)		,
		Texture17Arb = ((int)0x84D1)		,
		Texture18Arb = ((int)0x84D2)		,
		Texture19Arb = ((int)0x84D3)		,
		Texture20Arb = ((int)0x84D4)		,
		Texture21Arb = ((int)0x84D5)		,
		Texture22Arb = ((int)0x84D6)		,
		Texture23Arb = ((int)0x84D7)		,
		Texture24Arb = ((int)0x84D8)		,
		Texture25Arb = ((int)0x84D9)		,
		Texture26Arb = ((int)0x84DA)		,
		Texture27Arb = ((int)0x84DB)		,
		Texture28Arb = ((int)0x84DC)		,
		Texture29Arb = ((int)0x84DD)		,
		Texture30Arb = ((int)0x84DE)		,
		Texture31Arb = ((int)0x84DF)		,
		ActiveTextureArb = ((int)0x84E0)		,
		ClientActiveTextureArb = ((int)0x84E1)		,
		MaxTextureUnitsArb = ((int)0x84E2)		,
	}
	public enum ArbOcclusionQuery : int {
		QueryCounterBitsArb = ((int)0x8864)		,
		CurrentQueryArb = ((int)0x8865)		,
		QueryResultArb = ((int)0x8866)		,
		QueryResultAvailableArb = ((int)0x8867)		,
		SamplesPassedArb = ((int)0x8914)		,
	}
	public enum ArbOcclusionQuery2 : int {
		AnySamplesPassed = ((int)0x8C2F)		,
	}
	public enum ArbPixelBufferObject : int {
		PixelPackBufferArb = ((int)0x88EB)		,
		PixelUnpackBufferArb = ((int)0x88EC)		,
		PixelPackBufferBindingArb = ((int)0x88ED)		,
		PixelUnpackBufferBindingArb = ((int)0x88EF)		,
	}
	public enum ArbPointParameters : int {
		PointSizeMinArb = ((int)0x8126)		,
		PointSizeMaxArb = ((int)0x8127)		,
		PointFadeThresholdSizeArb = ((int)0x8128)		,
		PointDistanceAttenuationArb = ((int)0x8129)		,
	}
	public enum ArbPointSprite : int {
		PointSpriteArb = ((int)0x8861)		,
		CoordReplaceArb = ((int)0x8862)		,
	}
	public enum ArbProvokingVertex : int {
		QuadsFollowProvokingVertexConvention = ((int)0x8E4C)		,
		FirstVertexConvention = ((int)0x8E4D)		,
		LastVertexConvention = ((int)0x8E4E)		,
		ProvokingVertex = ((int)0x8E4F)		,
	}
	public enum ArbRobustness : int {
		NoError = ((int)0)		,
		ContextFlagRobustAccessBitArb = ((int)0x00000004)		,
		LoseContextOnResetArb = ((int)0x8252)		,
		GuiltyContextResetArb = ((int)0x8253)		,
		InnocentContextResetArb = ((int)0x8254)		,
		UnknownContextResetArb = ((int)0x8255)		,
		ResetNotificationStrategyArb = ((int)0x8256)		,
		NoResetNotificationArb = ((int)0x8261)		,
	}*/
	public enum ArbSamplerObjects : int {
		SamplerBinding = ((int)0x8919)		,
	}
	/*public enum ArbSampleShading : int {
		SampleShadingArb = ((int)0x8C36)		,
		MinSampleShadingValueArb = ((int)0x8C37)		,
	}
	public enum ArbSeamlessCubeMap : int {
		TextureCubeMapSeamless = ((int)0x884F)		,
	}
	public enum ArbSeparateShaderObjects : int {
		VertexShaderBit = ((int)0x00000001)		,
		FragmentShaderBit = ((int)0x00000002)		,
		GeometryShaderBit = ((int)0x00000004)		,
		TessControlShaderBit = ((int)0x00000008)		,
		TessEvaluationShaderBit = ((int)0x00000010)		,
		ProgramSeparable = ((int)0x8258)		,
		ActiveProgram = ((int)0x8259)		,
		ProgramPipelineBinding = ((int)0x825A)		,
		AllShaderBits = unchecked((int)0xFFFFFFFF)		,
	}
	public enum ArbShaderBitEncoding : int {
	}
	public enum ArbShaderObjects : int {
		ProgramObjectArb = ((int)0x8B40)		,
		ShaderObjectArb = ((int)0x8B48)		,
		ObjectTypeArb = ((int)0x8B4E)		,
		ObjectSubtypeArb = ((int)0x8B4F)		,
		FloatVec2Arb = ((int)0x8B50)		,
		FloatVec3Arb = ((int)0x8B51)		,
		FloatVec4Arb = ((int)0x8B52)		,
		IntVec2Arb = ((int)0x8B53)		,
		IntVec3Arb = ((int)0x8B54)		,
		IntVec4Arb = ((int)0x8B55)		,
		BoolArb = ((int)0x8B56)		,
		BoolVec2Arb = ((int)0x8B57)		,
		BoolVec3Arb = ((int)0x8B58)		,
		BoolVec4Arb = ((int)0x8B59)		,
		FloatMat2Arb = ((int)0x8B5A)		,
		FloatMat3Arb = ((int)0x8B5B)		,
		FloatMat4Arb = ((int)0x8B5C)		,
		Sampler1DArb = ((int)0x8B5D)		,
		Sampler2DArb = ((int)0x8B5E)		,
		Sampler3DArb = ((int)0x8B5F)		,
		SamplerCubeArb = ((int)0x8B60)		,
		Sampler1DShadowArb = ((int)0x8B61)		,
		Sampler2DShadowArb = ((int)0x8B62)		,
		Sampler2DRectArb = ((int)0x8B63)		,
		Sampler2DRectShadowArb = ((int)0x8B64)		,
		ObjectDeleteStatusArb = ((int)0x8B80)		,
		ObjectCompileStatusArb = ((int)0x8B81)		,
		ObjectLinkStatusArb = ((int)0x8B82)		,
		ObjectValidateStatusArb = ((int)0x8B83)		,
		ObjectInfoLogLengthArb = ((int)0x8B84)		,
		ObjectAttachedObjectsArb = ((int)0x8B85)		,
		ObjectActiveUniformsArb = ((int)0x8B86)		,
		ObjectActiveUniformMaxLengthArb = ((int)0x8B87)		,
		ObjectShaderSourceLengthArb = ((int)0x8B88)		,
	}
	public enum ArbShaderPrecision : int {
	}
	public enum ArbShaderStencilExport : int {
	}
	public enum ArbShaderSubroutine : int {
		UniformSize = ((int)0x8A38)		,
		UniformNameLength = ((int)0x8A39)		,
		ActiveSubroutines = ((int)0x8DE5)		,
		ActiveSubroutineUniforms = ((int)0x8DE6)		,
		MaxSubroutines = ((int)0x8DE7)		,
		MaxSubroutineUniformLocations = ((int)0x8DE8)		,
		ActiveSubroutineUniformLocations = ((int)0x8E47)		,
		ActiveSubroutineMaxLength = ((int)0x8E48)		,
		ActiveSubroutineUniformMaxLength = ((int)0x8E49)		,
		NumCompatibleSubroutines = ((int)0x8E4A)		,
		CompatibleSubroutines = ((int)0x8E4B)		,
	}
	public enum ArbShaderTextureLod : int {
	}
	public enum ArbShadingLanguage100 : int {
		ShadingLanguageVersionArb = ((int)0x8B8C)		,
	}
	public enum ArbShadingLanguageInclude : int {
		ShaderIncludeArb = ((int)0x8DAE)		,
		NamedStringLengthArb = ((int)0x8DE9)		,
		NamedStringTypeArb = ((int)0x8DEA)		,
	}
	public enum ArbShadow : int {
		TextureCompareModeArb = ((int)0x884C)		,
		TextureCompareFuncArb = ((int)0x884D)		,
		CompareRToTextureArb = ((int)0x884E)		,
	}
	public enum ArbShadowAmbient : int {
		TextureCompareFailValueArb = ((int)0x80BF)		,
	}*/
	public enum ArbSync : int {
		SyncFlushCommandsBit = ((int)0x00000001)		,
		MaxServerWaitTimeout = ((int)0x9111)		,
		ObjectType = ((int)0x9112)		,
		SyncCondition = ((int)0x9113)		,
		SyncStatus = ((int)0x9114)		,
		SyncFlags = ((int)0x9115)		,
		SyncFence = ((int)0x9116)		,
		SyncGpuCommandsComplete = ((int)0x9117)		,
		Unsignaled = ((int)0x9118)		,
		Signaled = ((int)0x9119)		,
		AlreadySignaled = ((int)0x911A)		,
		TimeoutExpired = ((int)0x911B)		,
		ConditionSatisfied = ((int)0x911C)		,
		WaitFailed = ((int)0x911D)		,
		TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)		,
	}
	/*public enum ArbTessellationShader : int {
		Triangles = ((int)0x0004)		,
		Quads = ((int)0x0007)		,
		Patches = ((int)0x000E)		,
		Equal = ((int)0x0202)		,
		Cw = ((int)0x0900)		,
		Ccw = ((int)0x0901)		,
		UniformBlockReferencedByTessControlShader = ((int)0x84F0)		,
		UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1)		,
		MaxTessControlInputComponents = ((int)0x886C)		,
		MaxTessEvaluationInputComponents = ((int)0x886D)		,
		MaxCombinedTessControlUniformComponents = ((int)0x8E1E)		,
		MaxCombinedTessEvaluationUniformComponents = ((int)0x8E1F)		,
		PatchVertices = ((int)0x8E72)		,
		PatchDefaultInnerLevel = ((int)0x8E73)		,
		PatchDefaultOuterLevel = ((int)0x8E74)		,
		TessControlOutputVertices = ((int)0x8E75)		,
		TessGenMode = ((int)0x8E76)		,
		TessGenSpacing = ((int)0x8E77)		,
		TessGenVertexOrder = ((int)0x8E78)		,
		TessGenPointMode = ((int)0x8E79)		,
		Isolines = ((int)0x8E7A)		,
		FractionalOdd = ((int)0x8E7B)		,
		FractionalEven = ((int)0x8E7C)		,
		MaxPatchVertices = ((int)0x8E7D)		,
		MaxTessGenLevel = ((int)0x8E7E)		,
		MaxTessControlUniformComponents = ((int)0x8E7F)		,
		MaxTessEvaluationUniformComponents = ((int)0x8E80)		,
		MaxTessControlTextureImageUnits = ((int)0x8E81)		,
		MaxTessEvaluationTextureImageUnits = ((int)0x8E82)		,
		MaxTessControlOutputComponents = ((int)0x8E83)		,
		MaxTessPatchComponents = ((int)0x8E84)		,
		MaxTessControlTotalOutputComponents = ((int)0x8E85)		,
		MaxTessEvaluationOutputComponents = ((int)0x8E86)		,
		TessEvaluationShader = ((int)0x8E87)		,
		TessControlShader = ((int)0x8E88)		,
		MaxTessControlUniformBlocks = ((int)0x8E89)		,
		MaxTessEvaluationUniformBlocks = ((int)0x8E8A)		,
	}
	public enum ArbTextureBorderClamp : int {
		ClampToBorderArb = ((int)0x812D)		,
	}
	public enum ArbTextureBufferObject : int {
		TextureBufferArb = ((int)0x8C2A)		,
		MaxTextureBufferSizeArb = ((int)0x8C2B)		,
		TextureBindingBufferArb = ((int)0x8C2C)		,
		TextureBufferDataStoreBindingArb = ((int)0x8C2D)		,
		TextureBufferFormatArb = ((int)0x8C2E)		,
	}
	public enum ArbTextureBufferObjectRgb32 : int {
		Rgb32f = ((int)0x8815)		,
		Rgb32ui = ((int)0x8D71)		,
		Rgb32i = ((int)0x8D83)		,
	}
	public enum ArbTextureCompression : int {
		CompressedAlphaArb = ((int)0x84E9)		,
		CompressedLuminanceArb = ((int)0x84EA)		,
		CompressedLuminanceAlphaArb = ((int)0x84EB)		,
		CompressedIntensityArb = ((int)0x84EC)		,
		CompressedRgbArb = ((int)0x84ED)		,
		CompressedRgbaArb = ((int)0x84EE)		,
		TextureCompressionHintArb = ((int)0x84EF)		,
		TextureCompressedImageSizeArb = ((int)0x86A0)		,
		TextureCompressedArb = ((int)0x86A1)		,
		NumCompressedTextureFormatsArb = ((int)0x86A2)		,
		CompressedTextureFormatsArb = ((int)0x86A3)		,
	}
	public enum ArbTextureCompressionBptc : int {
		CompressedRgbaBptcUnormArb = ((int)0x8E8C)		,
		CompressedSrgbAlphaBptcUnormArb = ((int)0x8E8D)		,
		CompressedRgbBptcSignedFloatArb = ((int)0x8E8E)		,
		CompressedRgbBptcUnsignedFloatArb = ((int)0x8E8F)		,
	}
	public enum ArbTextureCompressionRgtc : int {
		CompressedRedRgtc1 = ((int)0x8DBB)		,
		CompressedSignedRedRgtc1 = ((int)0x8DBC)		,
		CompressedRgRgtc2 = ((int)0x8DBD)		,
		CompressedSignedRgRgtc2 = ((int)0x8DBE)		,
	}
	public enum ArbTextureCubeMap : int {
		NormalMapArb = ((int)0x8511)		,
		ReflectionMapArb = ((int)0x8512)		,
		TextureCubeMapArb = ((int)0x8513)		,
		TextureBindingCubeMapArb = ((int)0x8514)		,
		TextureCubeMapPositiveXArb = ((int)0x8515)		,
		TextureCubeMapNegativeXArb = ((int)0x8516)		,
		TextureCubeMapPositiveYArb = ((int)0x8517)		,
		TextureCubeMapNegativeYArb = ((int)0x8518)		,
		TextureCubeMapPositiveZArb = ((int)0x8519)		,
		TextureCubeMapNegativeZArb = ((int)0x851A)		,
		ProxyTextureCubeMapArb = ((int)0x851B)		,
		MaxCubeMapTextureSizeArb = ((int)0x851C)		,
	}
	public enum ArbTextureCubeMapArray : int {
		TextureCubeMapArray = ((int)0x9009)		,
		TextureCubeMapArrayArb = ((int)0x9009)		,
		TextureBindingCubeMapArray = ((int)0x900A)		,
		TextureBindingCubeMapArrayArb = ((int)0x900A)		,
		ProxyTextureCubeMapArray = ((int)0x900B)		,
		ProxyTextureCubeMapArrayArb = ((int)0x900B)		,
		SamplerCubeMapArray = ((int)0x900C)		,
		SamplerCubeMapArrayArb = ((int)0x900C)		,
		SamplerCubeMapArrayShadow = ((int)0x900D)		,
		SamplerCubeMapArrayShadowArb = ((int)0x900D)		,
		IntSamplerCubeMapArray = ((int)0x900E)		,
		IntSamplerCubeMapArrayArb = ((int)0x900E)		,
		UnsignedIntSamplerCubeMapArray = ((int)0x900F)		,
		UnsignedIntSamplerCubeMapArrayArb = ((int)0x900F)		,
	}
	public enum ArbTextureEnvAdd : int {
	}
	public enum ArbTextureEnvCombine : int {
		SubtractArb = ((int)0x84E7)		,
		CombineArb = ((int)0x8570)		,
		CombineRgbArb = ((int)0x8571)		,
		CombineAlphaArb = ((int)0x8572)		,
		RgbScaleArb = ((int)0x8573)		,
		AddSignedArb = ((int)0x8574)		,
		InterpolateArb = ((int)0x8575)		,
		ConstantArb = ((int)0x8576)		,
		PrimaryColorArb = ((int)0x8577)		,
		PreviousArb = ((int)0x8578)		,
		Source0RgbArb = ((int)0x8580)		,
		Source1RgbArb = ((int)0x8581)		,
		Source2RgbArb = ((int)0x8582)		,
		Source0AlphaArb = ((int)0x8588)		,
		Source1AlphaArb = ((int)0x8589)		,
		Source2AlphaArb = ((int)0x858A)		,
		Operand0RgbArb = ((int)0x8590)		,
		Operand1RgbArb = ((int)0x8591)		,
		Operand2RgbArb = ((int)0x8592)		,
		Operand0AlphaArb = ((int)0x8598)		,
		Operand1AlphaArb = ((int)0x8599)		,
		Operand2AlphaArb = ((int)0x859A)		,
	}
	public enum ArbTextureEnvCrossbar : int {
	}
	public enum ArbTextureEnvDot3 : int {
		Dot3RgbArb = ((int)0x86AE)		,
		Dot3RgbaArb = ((int)0x86AF)		,
	}
	public enum ArbTextureFloat : int {
		Rgba32fArb = ((int)0x8814)		,
		Rgb32fArb = ((int)0x8815)		,
		Alpha32fArb = ((int)0x8816)		,
		Intensity32fArb = ((int)0x8817)		,
		Luminance32fArb = ((int)0x8818)		,
		LuminanceAlpha32fArb = ((int)0x8819)		,
		Rgba16fArb = ((int)0x881A)		,
		Rgb16fArb = ((int)0x881B)		,
		Alpha16fArb = ((int)0x881C)		,
		Intensity16fArb = ((int)0x881D)		,
		Luminance16fArb = ((int)0x881E)		,
		LuminanceAlpha16fArb = ((int)0x881F)		,
		TextureRedTypeArb = ((int)0x8C10)		,
		TextureGreenTypeArb = ((int)0x8C11)		,
		TextureBlueTypeArb = ((int)0x8C12)		,
		TextureAlphaTypeArb = ((int)0x8C13)		,
		TextureLuminanceTypeArb = ((int)0x8C14)		,
		TextureIntensityTypeArb = ((int)0x8C15)		,
		TextureDepthTypeArb = ((int)0x8C16)		,
		UnsignedNormalizedArb = ((int)0x8C17)		,
	}
	public enum ArbTextureGather : int {
		MinProgramTextureGatherOffset = ((int)0x8E5E)		,
		MinProgramTextureGatherOffsetArb = ((int)0x8E5E)		,
		MaxProgramTextureGatherOffset = ((int)0x8E5F)		,
		MaxProgramTextureGatherOffsetArb = ((int)0x8E5F)		,
		MaxProgramTextureGatherComponents = ((int)0x8F9F)		,
	}
	public enum ArbTextureMirroredRepeat : int {
		MirroredRepeatArb = ((int)0x8370)		,
	}
	public enum ArbTextureMultisample : int {
		SamplePosition = ((int)0x8E50)		,
		SampleMask = ((int)0x8E51)		,
		SampleMaskValue = ((int)0x8E52)		,
		MaxSampleMaskWords = ((int)0x8E59)		,
		Texture2DMultisample = ((int)0x9100)		,
		ProxyTexture2DMultisample = ((int)0x9101)		,
		Texture2DMultisampleArray = ((int)0x9102)		,
		ProxyTexture2DMultisampleArray = ((int)0x9103)		,
		TextureBinding2DMultisample = ((int)0x9104)		,
		TextureBinding2DMultisampleArray = ((int)0x9105)		,
		TextureSamples = ((int)0x9106)		,
		TextureFixedSampleLocations = ((int)0x9107)		,
		Sampler2DMultisample = ((int)0x9108)		,
		IntSampler2DMultisample = ((int)0x9109)		,
		UnsignedIntSampler2DMultisample = ((int)0x910A)		,
		Sampler2DMultisampleArray = ((int)0x910B)		,
		IntSampler2DMultisampleArray = ((int)0x910C)		,
		UnsignedIntSampler2DMultisampleArray = ((int)0x910D)		,
		MaxColorTextureSamples = ((int)0x910E)		,
		MaxDepthTextureSamples = ((int)0x910F)		,
		MaxIntegerSamples = ((int)0x9110)		,
	}
	public enum ArbTextureNonPowerOfTwo : int {
	}
	public enum ArbTextureQueryLod : int {
	}
	public enum ArbTextureRectangle : int {
		TextureRectangleArb = ((int)0x84F5)		,
		TextureBindingRectangleArb = ((int)0x84F6)		,
		ProxyTextureRectangleArb = ((int)0x84F7)		,
		MaxRectangleTextureSizeArb = ((int)0x84F8)		,
	}
	public enum ArbTextureRg : int {
		Rg = ((int)0x8227)		,
		RgInteger = ((int)0x8228)		,
		R8 = ((int)0x8229)		,
		R16 = ((int)0x822A)		,
		Rg8 = ((int)0x822B)		,
		Rg16 = ((int)0x822C)		,
		R16f = ((int)0x822D)		,
		R32f = ((int)0x822E)		,
		Rg16f = ((int)0x822F)		,
		Rg32f = ((int)0x8230)		,
		R8i = ((int)0x8231)		,
		R8ui = ((int)0x8232)		,
		R16i = ((int)0x8233)		,
		R16ui = ((int)0x8234)		,
		R32i = ((int)0x8235)		,
		R32ui = ((int)0x8236)		,
		Rg8i = ((int)0x8237)		,
		Rg8ui = ((int)0x8238)		,
		Rg16i = ((int)0x8239)		,
		Rg16ui = ((int)0x823A)		,
		Rg32i = ((int)0x823B)		,
		Rg32ui = ((int)0x823C)		,
	}
	public enum ArbTextureRgb10A2ui : int {
		Rgb10A2ui = ((int)0x906F)		,
	}
	public enum ArbTextureSwizzle : int {
		TextureSwizzleR = ((int)0x8E42)		,
		TextureSwizzleG = ((int)0x8E43)		,
		TextureSwizzleB = ((int)0x8E44)		,
		TextureSwizzleA = ((int)0x8E45)		,
		TextureSwizzleRgba = ((int)0x8E46)		,
	}
	public enum ArbTimerQuery : int {
		TimeElapsed = ((int)0x88BF)		,
		Timestamp = ((int)0x8E28)		,
	}
	public enum ArbTransformFeedback2 : int {
		TransformFeedback = ((int)0x8E22)		,
		TransformFeedbackBufferPaused = ((int)0x8E23)		,
		TransformFeedbackBufferActive = ((int)0x8E24)		,
		TransformFeedbackBinding = ((int)0x8E25)		,
	}
	public enum ArbTransformFeedback3 : int {
		MaxTransformFeedbackBuffers = ((int)0x8E70)		,
		MaxVertexStreams = ((int)0x8E71)		,
	}
	public enum ArbTransposeMatrix : int {
		TransposeModelviewMatrixArb = ((int)0x84E3)		,
		TransposeProjectionMatrixArb = ((int)0x84E4)		,
		TransposeTextureMatrixArb = ((int)0x84E5)		,
		TransposeColorMatrixArb = ((int)0x84E6)		,
	}
	public enum ArbUniformBufferObject : int {
		UniformBuffer = ((int)0x8A11)		,
		UniformBufferBinding = ((int)0x8A28)		,
		UniformBufferStart = ((int)0x8A29)		,
		UniformBufferSize = ((int)0x8A2A)		,
		MaxVertexUniformBlocks = ((int)0x8A2B)		,
		MaxGeometryUniformBlocks = ((int)0x8A2C)		,
		MaxFragmentUniformBlocks = ((int)0x8A2D)		,
		MaxCombinedUniformBlocks = ((int)0x8A2E)		,
		MaxUniformBufferBindings = ((int)0x8A2F)		,
		MaxUniformBlockSize = ((int)0x8A30)		,
		MaxCombinedVertexUniformComponents = ((int)0x8A31)		,
		MaxCombinedGeometryUniformComponents = ((int)0x8A32)		,
		MaxCombinedFragmentUniformComponents = ((int)0x8A33)		,
		UniformBufferOffsetAlignment = ((int)0x8A34)		,
		ActiveUniformBlockMaxNameLength = ((int)0x8A35)		,
		ActiveUniformBlocks = ((int)0x8A36)		,
		UniformType = ((int)0x8A37)		,
		UniformSize = ((int)0x8A38)		,
		UniformNameLength = ((int)0x8A39)		,
		UniformBlockIndex = ((int)0x8A3A)		,
		UniformOffset = ((int)0x8A3B)		,
		UniformArrayStride = ((int)0x8A3C)		,
		UniformMatrixStride = ((int)0x8A3D)		,
		UniformIsRowMajor = ((int)0x8A3E)		,
		UniformBlockBinding = ((int)0x8A3F)		,
		UniformBlockDataSize = ((int)0x8A40)		,
		UniformBlockNameLength = ((int)0x8A41)		,
		UniformBlockActiveUniforms = ((int)0x8A42)		,
		UniformBlockActiveUniformIndices = ((int)0x8A43)		,
		UniformBlockReferencedByVertexShader = ((int)0x8A44)		,
		UniformBlockReferencedByGeometryShader = ((int)0x8A45)		,
		UniformBlockReferencedByFragmentShader = ((int)0x8A46)		,
		InvalidIndex = unchecked((int)0xFFFFFFFF)		,
	}
	public enum ArbVertexArrayBgra : int {
		Bgra = ((int)0x80E1)		,
	}
	public enum ArbVertexArrayObject : int {
		VertexArrayBinding = ((int)0x85B5)		,
	}
	public enum ArbVertexAttrib64bit : int {
		Rgb32i = ((int)0x8D83)		,
		DoubleMat2 = ((int)0x8F46)		,
		DoubleMat3 = ((int)0x8F47)		,
		DoubleMat4 = ((int)0x8F48)		,
		DoubleMat2x3 = ((int)0x8F49)		,
		DoubleMat2x4 = ((int)0x8F4A)		,
		DoubleMat3x2 = ((int)0x8F4B)		,
		DoubleMat3x4 = ((int)0x8F4C)		,
		DoubleMat4x2 = ((int)0x8F4D)		,
		DoubleMat4x3 = ((int)0x8F4E)		,
		DoubleVec2 = ((int)0x8FFC)		,
		DoubleVec3 = ((int)0x8FFD)		,
		DoubleVec4 = ((int)0x8FFE)		,
	}
	public enum ArbVertexBlend : int {
		Modelview0Arb = ((int)0x1700)		,
		Modelview1Arb = ((int)0x850A)		,
		MaxVertexUnitsArb = ((int)0x86A4)		,
		ActiveVertexUnitsArb = ((int)0x86A5)		,
		WeightSumUnityArb = ((int)0x86A6)		,
		VertexBlendArb = ((int)0x86A7)		,
		CurrentWeightArb = ((int)0x86A8)		,
		WeightArrayTypeArb = ((int)0x86A9)		,
		WeightArrayStrideArb = ((int)0x86AA)		,
		WeightArraySizeArb = ((int)0x86AB)		,
		WeightArrayPointerArb = ((int)0x86AC)		,
		WeightArrayArb = ((int)0x86AD)		,
		Modelview2Arb = ((int)0x8722)		,
		Modelview3Arb = ((int)0x8723)		,
		Modelview4Arb = ((int)0x8724)		,
		Modelview5Arb = ((int)0x8725)		,
		Modelview6Arb = ((int)0x8726)		,
		Modelview7Arb = ((int)0x8727)		,
		Modelview8Arb = ((int)0x8728)		,
		Modelview9Arb = ((int)0x8729)		,
		Modelview10Arb = ((int)0x872A)		,
		Modelview11Arb = ((int)0x872B)		,
		Modelview12Arb = ((int)0x872C)		,
		Modelview13Arb = ((int)0x872D)		,
		Modelview14Arb = ((int)0x872E)		,
		Modelview15Arb = ((int)0x872F)		,
		Modelview16Arb = ((int)0x8730)		,
		Modelview17Arb = ((int)0x8731)		,
		Modelview18Arb = ((int)0x8732)		,
		Modelview19Arb = ((int)0x8733)		,
		Modelview20Arb = ((int)0x8734)		,
		Modelview21Arb = ((int)0x8735)		,
		Modelview22Arb = ((int)0x8736)		,
		Modelview23Arb = ((int)0x8737)		,
		Modelview24Arb = ((int)0x8738)		,
		Modelview25Arb = ((int)0x8739)		,
		Modelview26Arb = ((int)0x873A)		,
		Modelview27Arb = ((int)0x873B)		,
		Modelview28Arb = ((int)0x873C)		,
		Modelview29Arb = ((int)0x873D)		,
		Modelview30Arb = ((int)0x873E)		,
		Modelview31Arb = ((int)0x873F)		,
	}
	public enum ArbVertexBufferObject : int {
		BufferSizeArb = ((int)0x8764)		,
		BufferUsageArb = ((int)0x8765)		,
		ArrayBufferArb = ((int)0x8892)		,
		ElementArrayBufferArb = ((int)0x8893)		,
		ArrayBufferBindingArb = ((int)0x8894)		,
		ElementArrayBufferBindingArb = ((int)0x8895)		,
		VertexArrayBufferBindingArb = ((int)0x8896)		,
		NormalArrayBufferBindingArb = ((int)0x8897)		,
		ColorArrayBufferBindingArb = ((int)0x8898)		,
		IndexArrayBufferBindingArb = ((int)0x8899)		,
		TextureCoordArrayBufferBindingArb = ((int)0x889A)		,
		EdgeFlagArrayBufferBindingArb = ((int)0x889B)		,
		SecondaryColorArrayBufferBindingArb = ((int)0x889C)		,
		FogCoordinateArrayBufferBindingArb = ((int)0x889D)		,
		WeightArrayBufferBindingArb = ((int)0x889E)		,
		VertexAttribArrayBufferBindingArb = ((int)0x889F)		,
		ReadOnlyArb = ((int)0x88B8)		,
		WriteOnlyArb = ((int)0x88B9)		,
		ReadWriteArb = ((int)0x88BA)		,
		BufferAccessArb = ((int)0x88BB)		,
		BufferMappedArb = ((int)0x88BC)		,
		BufferMapPointerArb = ((int)0x88BD)		,
		StreamDrawArb = ((int)0x88E0)		,
		StreamReadArb = ((int)0x88E1)		,
		StreamCopyArb = ((int)0x88E2)		,
		StaticDrawArb = ((int)0x88E4)		,
		StaticReadArb = ((int)0x88E5)		,
		StaticCopyArb = ((int)0x88E6)		,
		DynamicDrawArb = ((int)0x88E8)		,
		DynamicReadArb = ((int)0x88E9)		,
		DynamicCopyArb = ((int)0x88EA)		,
	}
	public enum ArbVertexProgram : int {
		ColorSumArb = ((int)0x8458)		,
		VertexProgramArb = ((int)0x8620)		,
		VertexAttribArrayEnabledArb = ((int)0x8622)		,
		VertexAttribArraySizeArb = ((int)0x8623)		,
		VertexAttribArrayStrideArb = ((int)0x8624)		,
		VertexAttribArrayTypeArb = ((int)0x8625)		,
		CurrentVertexAttribArb = ((int)0x8626)		,
		ProgramLengthArb = ((int)0x8627)		,
		ProgramStringArb = ((int)0x8628)		,
		MaxProgramMatrixStackDepthArb = ((int)0x862E)		,
		MaxProgramMatricesArb = ((int)0x862F)		,
		CurrentMatrixStackDepthArb = ((int)0x8640)		,
		CurrentMatrixArb = ((int)0x8641)		,
		VertexProgramPointSizeArb = ((int)0x8642)		,
		VertexProgramTwoSideArb = ((int)0x8643)		,
		VertexAttribArrayPointerArb = ((int)0x8645)		,
		ProgramErrorPositionArb = ((int)0x864B)		,
		ProgramBindingArb = ((int)0x8677)		,
		MaxVertexAttribsArb = ((int)0x8869)		,
		VertexAttribArrayNormalizedArb = ((int)0x886A)		,
		ProgramErrorStringArb = ((int)0x8874)		,
		ProgramFormatAsciiArb = ((int)0x8875)		,
		ProgramFormatArb = ((int)0x8876)		,
		ProgramInstructionsArb = ((int)0x88A0)		,
		MaxProgramInstructionsArb = ((int)0x88A1)		,
		ProgramNativeInstructionsArb = ((int)0x88A2)		,
		MaxProgramNativeInstructionsArb = ((int)0x88A3)		,
		ProgramTemporariesArb = ((int)0x88A4)		,
		MaxProgramTemporariesArb = ((int)0x88A5)		,
		ProgramNativeTemporariesArb = ((int)0x88A6)		,
		MaxProgramNativeTemporariesArb = ((int)0x88A7)		,
		ProgramParametersArb = ((int)0x88A8)		,
		MaxProgramParametersArb = ((int)0x88A9)		,
		ProgramNativeParametersArb = ((int)0x88AA)		,
		MaxProgramNativeParametersArb = ((int)0x88AB)		,
		ProgramAttribsArb = ((int)0x88AC)		,
		MaxProgramAttribsArb = ((int)0x88AD)		,
		ProgramNativeAttribsArb = ((int)0x88AE)		,
		MaxProgramNativeAttribsArb = ((int)0x88AF)		,
		ProgramAddressRegistersArb = ((int)0x88B0)		,
		MaxProgramAddressRegistersArb = ((int)0x88B1)		,
		ProgramNativeAddressRegistersArb = ((int)0x88B2)		,
		MaxProgramNativeAddressRegistersArb = ((int)0x88B3)		,
		MaxProgramLocalParametersArb = ((int)0x88B4)		,
		MaxProgramEnvParametersArb = ((int)0x88B5)		,
		ProgramUnderNativeLimitsArb = ((int)0x88B6)		,
		TransposeCurrentMatrixArb = ((int)0x88B7)		,
		Matrix0Arb = ((int)0x88C0)		,
		Matrix1Arb = ((int)0x88C1)		,
		Matrix2Arb = ((int)0x88C2)		,
		Matrix3Arb = ((int)0x88C3)		,
		Matrix4Arb = ((int)0x88C4)		,
		Matrix5Arb = ((int)0x88C5)		,
		Matrix6Arb = ((int)0x88C6)		,
		Matrix7Arb = ((int)0x88C7)		,
		Matrix8Arb = ((int)0x88C8)		,
		Matrix9Arb = ((int)0x88C9)		,
		Matrix10Arb = ((int)0x88CA)		,
		Matrix11Arb = ((int)0x88CB)		,
		Matrix12Arb = ((int)0x88CC)		,
		Matrix13Arb = ((int)0x88CD)		,
		Matrix14Arb = ((int)0x88CE)		,
		Matrix15Arb = ((int)0x88CF)		,
		Matrix16Arb = ((int)0x88D0)		,
		Matrix17Arb = ((int)0x88D1)		,
		Matrix18Arb = ((int)0x88D2)		,
		Matrix19Arb = ((int)0x88D3)		,
		Matrix20Arb = ((int)0x88D4)		,
		Matrix21Arb = ((int)0x88D5)		,
		Matrix22Arb = ((int)0x88D6)		,
		Matrix23Arb = ((int)0x88D7)		,
		Matrix24Arb = ((int)0x88D8)		,
		Matrix25Arb = ((int)0x88D9)		,
		Matrix26Arb = ((int)0x88DA)		,
		Matrix27Arb = ((int)0x88DB)		,
		Matrix28Arb = ((int)0x88DC)		,
		Matrix29Arb = ((int)0x88DD)		,
		Matrix30Arb = ((int)0x88DE)		,
		Matrix31Arb = ((int)0x88DF)		,
	}
	public enum ArbVertexShader : int {
		VertexShaderArb = ((int)0x8B31)		,
		MaxVertexUniformComponentsArb = ((int)0x8B4A)		,
		MaxVaryingFloatsArb = ((int)0x8B4B)		,
		MaxVertexTextureImageUnitsArb = ((int)0x8B4C)		,
		MaxCombinedTextureImageUnitsArb = ((int)0x8B4D)		,
		ObjectActiveAttributesArb = ((int)0x8B89)		,
		ObjectActiveAttributeMaxLengthArb = ((int)0x8B8A)		,
	}
	public enum ArbVertexType2101010Rev : int {
		UnsignedInt2101010Rev = ((int)0x8368)		,
		Int2101010Rev = ((int)0x8D9F)		,
	}
	public enum ArbViewportArray : int {
		DepthRange = ((int)0x0B70)		,
		Viewport = ((int)0x0BA2)		,
		ScissorBox = ((int)0x0C10)		,
		ScissorTest = ((int)0x0C11)		,
		MaxViewports = ((int)0x825B)		,
		ViewportSubpixelBits = ((int)0x825C)		,
		ViewportBoundsRange = ((int)0x825D)		,
		LayerProvokingVertex = ((int)0x825E)		,
		ViewportIndexProvokingVertex = ((int)0x825F)		,
		UndefinedVertex = ((int)0x8260)		,
		FirstVertexConvention = ((int)0x8E4D)		,
		LastVertexConvention = ((int)0x8E4E)		,
		ProvokingVertex = ((int)0x8E4F)		,
	}
	public enum ArbWindowPos : int {
	}*/
	public enum ArmMaliShaderBinary : int {
		MaliShaderBinaryArm = ((int)0x8F60)		,
	}
	public enum ArrayCap : int {
		VertexArray = ((int)0x8074)		,
		NormalArray = ((int)0x8075)		,
		ColorArray = ((int)0x8076)		,
		IndexArray = ((int)0x8077)		,
		TextureCoordArray = ((int)0x8078)		,
		EdgeFlagArray = ((int)0x8079)		,
		FogCoordArray = ((int)0x8457)		,
		SecondaryColorArray = ((int)0x845E)		,
	}
	/*public enum AssemblyProgramFormatArb : int {
		ProgramFormatAsciiArb = ((int)0x8875)		,
	}*/
	public enum AssemblyProgramParameterArb : int {
		ProgramBinaryRetrievableHint = ((int)0x8257)		,
		ProgramSeparable = ((int)0x8258)		,
		ProgramLength = ((int)0x8627)		,
		ProgramBinding = ((int)0x8677)		,
		ProgramAluInstructionsArb = ((int)0x8805)		,
		ProgramTexInstructionsArb = ((int)0x8806)		,
		ProgramTexIndirectionsArb = ((int)0x8807)		,
		ProgramNativeAluInstructionsArb = ((int)0x8808)		,
		ProgramNativeTexInstructionsArb = ((int)0x8809)		,
		ProgramNativeTexIndirectionsArb = ((int)0x880A)		,
		MaxProgramAluInstructionsArb = ((int)0x880B)		,
		MaxProgramTexInstructionsArb = ((int)0x880C)		,
		MaxProgramTexIndirectionsArb = ((int)0x880D)		,
		MaxProgramNativeAluInstructionsArb = ((int)0x880E)		,
		MaxProgramNativeTexInstructionsArb = ((int)0x880F)		,
		MaxProgramNativeTexIndirectionsArb = ((int)0x8810)		,
		ProgramFormat = ((int)0x8876)		,
		ProgramInstruction = ((int)0x88A0)		,
		MaxProgramInstructions = ((int)0x88A1)		,
		ProgramNativeInstructions = ((int)0x88A2)		,
		MaxProgramNativeInstructions = ((int)0x88A3)		,
		ProgramTemporaries = ((int)0x88A4)		,
		MaxProgramTemporaries = ((int)0x88A5)		,
		ProgramNativeTemporaries = ((int)0x88A6)		,
		MaxProgramNativeTemporaries = ((int)0x88A7)		,
		ProgramParameters = ((int)0x88A8)		,
		MaxProgramParameters = ((int)0x88A9)		,
		ProgramNativeParameters = ((int)0x88AA)		,
		MaxProgramNativeParameters = ((int)0x88AB)		,
		ProgramAttribs = ((int)0x88AC)		,
		MaxProgramAttribs = ((int)0x88AD)		,
		ProgramNativeAttribs = ((int)0x88AE)		,
		MaxProgramNativeAttribs = ((int)0x88AF)		,
		ProgramAddressRegisters = ((int)0x88B0)		,
		MaxProgramAddressRegisters = ((int)0x88B1)		,
		ProgramNativeAddressRegisters = ((int)0x88B2)		,
		MaxProgramNativeAddressRegisters = ((int)0x88B3)		,
		MaxProgramLocalParameters = ((int)0x88B4)		,
		MaxProgramEnvParameters = ((int)0x88B5)		,
		ProgramUnderNativeLimits = ((int)0x88B6)		,
		GeometryVerticesOut = ((int)0x8916)		,
		GeometryInputType = ((int)0x8917)		,
		GeometryOutputType = ((int)0x8918)		,
	}
	/*public enum AssemblyProgramStringParameterArb : int {
		ProgramString = ((int)0x8628)		,
	}
	public enum AssemblyProgramTargetArb : int {
		VertexProgram = ((int)0x8620)		,
		FragmentProgram = ((int)0x8804)		,
		GeometryProgramNv = ((int)0x8C26)		,
	}*/
	[Flags]
	public enum AttribMask : int {
		CurrentBit = ((int)0x00000001)		,
		PointBit = ((int)0x00000002)		,
		LineBit = ((int)0x00000004)		,
		PolygonBit = ((int)0x00000008)		,
		PolygonStippleBit = ((int)0x00000010)		,
		PixelModeBit = ((int)0x00000020)		,
		LightingBit = ((int)0x00000040)		,
		FogBit = ((int)0x00000080)		,
		DepthBufferBit = ((int)0x00000100)		,
		AccumBufferBit = ((int)0x00000200)		,
		StencilBufferBit = ((int)0x00000400)		,
		ViewportBit = ((int)0x00000800)		,
		TransformBit = ((int)0x00001000)		,
		EnableBit = ((int)0x00002000)		,
		ColorBufferBit = ((int)0x00004000)		,
		HintBit = ((int)0x00008000)		,
		EvalBit = ((int)0x00010000)		,
		ListBit = ((int)0x00020000)		,
		TextureBit = ((int)0x00040000)		,
		ScissorBit = ((int)0x00080000)		,
		MultisampleBit = ((int)0x20000000)		,
		AllAttribBits = unchecked((int)0xFFFFFFFF)		,
	}
	public enum BeginFeedbackMode : int {
		Points = ((int)0x0000)		,
		Lines = ((int)0x0001)		,
		Triangles = ((int)0x0004)		,
	}
	public enum BeginMode : int {
		Points = ((int)0x0000)		,
		Lines = ((int)0x0001)		,
		LineLoop = ((int)0x0002)		,
		LineStrip = ((int)0x0003)		,
		Triangles = ((int)0x0004)		,
		TriangleStrip = ((int)0x0005)		,
		TriangleFan = ((int)0x0006)		,
		Quads = ((int)0x0007)		,
		QuadStrip = ((int)0x0008)		,
		Polygon = ((int)0x0009)		,
		Patches = ((int)0x000E)		,
		LinesAdjacency = ((int)0xA)		,
		LineStripAdjacency = ((int)0xB)		,
		TrianglesAdjacency = ((int)0xC)		,
		TriangleStripAdjacency = ((int)0xD)		,
	}
	public enum BinaryFormat : int {
	}
	public enum BlendEquationMode : int {
		FuncAdd = ((int)0x8006)		,
		Min = ((int)0x8007)		,
		Max = ((int)0x8008)		,
		FuncSubtract = ((int)0x800A)		,
		FuncReverseSubtract = ((int)0x800B)		,
	}
	/*public enum BlendEquationModeExt : int {
		LogicOp = ((int)0x0BF1)		,
		FuncAddExt = ((int)0x8006)		,
		MinExt = ((int)0x8007)		,
		MaxExt = ((int)0x8008)		,
		FuncSubtractExt = ((int)0x800A)		,
		FuncReverseSubtractExt = ((int)0x800B)		,
		AlphaMinSgix = ((int)0x8320)		,
		AlphaMaxSgix = ((int)0x8321)		,
	}*/
	public enum BlendingFactorDest : int {
		Zero = ((int)0)		,
		SrcColor = ((int)0x0300)		,
		OneMinusSrcColor = ((int)0x0301)		,
		SrcAlpha = ((int)0x0302)		,
		OneMinusSrcAlpha = ((int)0x0303)		,
		DstAlpha = ((int)0x0304)		,
		OneMinusDstAlpha = ((int)0x0305)		,
		ConstantColor = ((int)0x8001)		,
		ConstantColorExt = ((int)0x8001)		,
		OneMinusConstantColor = ((int)0x8002)		,
		OneMinusConstantColorExt = ((int)0x8002)		,
		ConstantAlpha = ((int)0x8003)		,
		ConstantAlphaExt = ((int)0x8003)		,
		OneMinusConstantAlpha = ((int)0x8004)		,
		OneMinusConstantAlphaExt = ((int)0x8004)		,
		Src1Alpha = ((int)0x8589)		,
		Src1Color = ((int)0x88F9)		,
		OneMinusSrc1Color = ((int)0x88FA)		,
		OneMinusSrc1Alpha = ((int)0x88FB)		,
		One = ((int)1)		,
	}
	public enum BlendingFactorSrc : int {
		Zero = ((int)0)		,
		SrcAlpha = ((int)0x0302)		,
		OneMinusSrcAlpha = ((int)0x0303)		,
		DstAlpha = ((int)0x0304)		,
		OneMinusDstAlpha = ((int)0x0305)		,
		DstColor = ((int)0x0306)		,
		OneMinusDstColor = ((int)0x0307)		,
		SrcAlphaSaturate = ((int)0x0308)		,
		ConstantColor = ((int)0x8001)		,
		ConstantColorExt = ((int)0x8001)		,
		OneMinusConstantColor = ((int)0x8002)		,
		OneMinusConstantColorExt = ((int)0x8002)		,
		ConstantAlpha = ((int)0x8003)		,
		ConstantAlphaExt = ((int)0x8003)		,
		OneMinusConstantAlpha = ((int)0x8004)		,
		OneMinusConstantAlphaExt = ((int)0x8004)		,
		Src1Alpha = ((int)0x8589)		,
		Src1Color = ((int)0x88F9)		,
		OneMinusSrc1Color = ((int)0x88FA)		,
		OneMinusSrc1Alpha = ((int)0x88FB)		,
		One = ((int)1)		,
	}
	public enum BlitFramebufferFilter : int {
		Nearest = ((int)0x2600)		,
		Linear = ((int)0x2601)		,
	}
	public enum BufferAccess : int {
		ReadOnly = ((int)0x88B8)		,
		WriteOnly = ((int)0x88B9)		,
		ReadWrite = ((int)0x88BA)		,
	}
	/*public enum BufferAccessArb : int {
		ReadOnly = ((int)0x88B8)		,
		WriteOnly = ((int)0x88B9)		,
		ReadWrite = ((int)0x88BA)		,
	}*/
	
	[Flags]
	public enum BufferAccessMask : int {
		MapReadBit = ((int)0x0001)		,
		MapWriteBit = ((int)0x0002)		,
		MapInvalidateRangeBit = ((int)0x0004)		,
		MapInvalidateBufferBit = ((int)0x0008)		,
		MapFlushExplicitBit = ((int)0x0010)		,
		MapUnsynchronizedBit = ((int)0x0020)		,
	}
	public enum BufferParameterApple : int {
		BufferSerializedModifyApple = ((int)0x8A12)		,
		BufferFlushingUnmapApple = ((int)0x8A13)		,
	}
	public enum BufferParameterName : int {
		BufferSize = ((int)0x8764)		,
		BufferUsage = ((int)0x8765)		,
		BufferAccess = ((int)0x88BB)		,
		BufferMapped = ((int)0x88BC)		,
	}
	/*public enum BufferParameterNameArb : int {
		BufferSize = ((int)0x8764)		,
		BufferUsage = ((int)0x8765)		,
		BufferAccess = ((int)0x88BB)		,
		BufferMapped = ((int)0x88BC)		,
	}*/
	public enum BufferPointer : int {
		BufferMapPointer = ((int)0x88BD)		,
	}
	/*public enum BufferPointerNameArb : int {
		BufferMapPointer = ((int)0x88BD)		,
	}*/
	public enum BufferTarget : int {
		ArrayBuffer = ((int)0x8892)		,
		ElementArrayBuffer = ((int)0x8893)		,
		PixelPackBuffer = ((int)0x88EB)		,
		PixelUnpackBuffer = ((int)0x88EC)		,
		UniformBuffer = ((int)0x8A11)		,
		TextureBuffer = ((int)0x8C2A)		,
		TransformFeedbackBuffer = ((int)0x8C8E)		,
		CopyReadBuffer = ((int)0x8F36)		,
		CopyWriteBuffer = ((int)0x8F37)		,
		DrawIndirectBuffer = ((int)0x8F3F)		,
        // Manual added
        AtomicCounterBuffer = ((int)0x92C0) ,
        DispatchIndirectBuffer = ((int)0x90EE),
        ShaderStorageBuffer = ((int)0x90D2) ,


	}
	/*public enum BufferTargetArb : int {
		ArrayBuffer = ((int)0x8892)		,
		ElementArrayBuffer = ((int)0x8893)		,
		TextureBuffer = ((int)0x8C2A)		,
	}
	public enum BufferUsageArb : int {
		StreamDraw = ((int)0x88E0)		,
		StreamRead = ((int)0x88E1)		,
		StreamCopy = ((int)0x88E2)		,
		StaticDraw = ((int)0x88E4)		,
		StaticRead = ((int)0x88E5)		,
		StaticCopy = ((int)0x88E6)		,
		DynamicDraw = ((int)0x88E8)		,
		DynamicRead = ((int)0x88E9)		,
		DynamicCopy = ((int)0x88EA)		,
	}*/
	public enum BufferUsageHint : int {
		StreamDraw = ((int)0x88E0)		,
		StreamRead = ((int)0x88E1)		,
		StreamCopy = ((int)0x88E2)		,
		StaticDraw = ((int)0x88E4)		,
		StaticRead = ((int)0x88E5)		,
		StaticCopy = ((int)0x88E6)		,
		DynamicDraw = ((int)0x88E8)		,
		DynamicRead = ((int)0x88E9)		,
		DynamicCopy = ((int)0x88EA)		,
	}
	public enum ClampColorMode : int {
		False = ((int)0)		,
		FixedOnly = ((int)0x891D)		,
		True = ((int)1)		,
	}
	public enum ClampColorTarget : int {
		ClampVertexColor = ((int)0x891A)		,
		ClampFragmentColor = ((int)0x891B)		,
		ClampReadColor = ((int)0x891C)		,
	}
	public enum ClearBuffer : int {
		Color = ((int)0x1800)		,
		Depth = ((int)0x1801)		,
		Stencil = ((int)0x1802)		,
		DepthStencil = ((int)0x84F9)		,
	}
	
	[Flags]
	public enum ClearBufferMask : int {
		DepthBufferBit = ((int)0x00000100)		,
		AccumBufferBit = ((int)0x00000200)		,
		StencilBufferBit = ((int)0x00000400)		,
		ColorBufferBit = ((int)0x00004000)		,
		CoverageBufferBitNv = ((int)0x00008000)		,
	}
	[Flags]
	public enum ClientAttribMask : int {
		ClientPixelStoreBit = ((int)0x00000001)		,
		ClientVertexArrayBit = ((int)0x00000002)		,
		ClientAllAttribBits = unchecked((int)0xFFFFFFFF)		,
	}
	public enum ClipPlaneName : int {
		ClipPlane0 = ((int)0x3000)		,
		ClipPlane1 = ((int)0x3001)		,
		ClipPlane2 = ((int)0x3002)		,
		ClipPlane3 = ((int)0x3003)		,
		ClipPlane4 = ((int)0x3004)		,
		ClipPlane5 = ((int)0x3005)		,
	}
	public enum ColorMaterialFace : int {
		Front = ((int)0x0404)		,
		Back = ((int)0x0405)		,
		FrontAndBack = ((int)0x0408)		,
	}
	public enum ColorMaterialParameter : int {
		Ambient = ((int)0x1200)		,
		Diffuse = ((int)0x1201)		,
		Specular = ((int)0x1202)		,
		Emission = ((int)0x1600)		,
		AmbientAndDiffuse = ((int)0x1602)		,
	}
	public enum ColorPointerType : int {
		Byte = ((int)0x1400)		,
		UnsignedByte = ((int)0x1401)		,
		Short = ((int)0x1402)		,
		UnsignedShort = ((int)0x1403)		,
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		HalfFloat = ((int)0x140B)		,
		UnsignedInt2101010Rev = ((int)0x8368)		,
		Int2101010Rev = ((int)0x8D9F)		,
	}
	public enum ColorTableParameterPName : int {
		ColorTableScale = ((int)0x80D6)		,
		ColorTableBias = ((int)0x80D7)		,
	}
	public enum ColorTableParameterPNameSgi : int {
		ColorTableScaleSgi = ((int)0x80D6)		,
		ColorTableBiasSgi = ((int)0x80D7)		,
	}
	public enum ColorTableTarget : int {
		ColorTable = ((int)0x80D0)		,
		PostConvolutionColorTable = ((int)0x80D1)		,
		PostColorMatrixColorTable = ((int)0x80D2)		,
		ProxyColorTable = ((int)0x80D3)		,
		ProxyPostConvolutionColorTable = ((int)0x80D4)		,
		ProxyPostColorMatrixColorTable = ((int)0x80D5)		,
	}
	public enum ColorTableTargetSgi : int {
		TextureColorTableSgi = ((int)0x80BC)		,
		ProxyTextureColorTableSgi = ((int)0x80BD)		,
		ColorTableSgi = ((int)0x80D0)		,
		PostConvolutionColorTableSgi = ((int)0x80D1)		,
		PostColorMatrixColorTableSgi = ((int)0x80D2)		,
		ProxyColorTableSgi = ((int)0x80D3)		,
		ProxyPostConvolutionColorTableSgi = ((int)0x80D4)		,
		ProxyPostColorMatrixColorTableSgi = ((int)0x80D5)		,
	}
	public enum ConditionalRenderType : int {
		QueryWait = ((int)0x8E13)		,
		QueryNoWait = ((int)0x8E14)		,
		QueryByRegionWait = ((int)0x8E15)		,
		QueryByRegionNoWait = ((int)0x8E16)		,
	}
	public enum ConvolutionBorderModeExt : int {
		ReduceExt = ((int)0x8016)		,
	}
	public enum ConvolutionParameter : int {
		ConvolutionBorderMode = ((int)0x8013)		,
		ConvolutionFilterScale = ((int)0x8014)		,
		ConvolutionFilterBias = ((int)0x8015)		,
	}
	public enum ConvolutionParameterExt : int {
		ConvolutionBorderModeExt = ((int)0x8013)		,
		ConvolutionFilterScaleExt = ((int)0x8014)		,
		ConvolutionFilterBiasExt = ((int)0x8015)		,
	}
	public enum ConvolutionParameterValue : int {
		Reduce = ((int)0x8016)		,
		ConstantBorder = ((int)0x8151)		,
		ReplicateBorder = ((int)0x8153)		,
	}
	public enum ConvolutionTarget : int {
		Convolution1D = ((int)0x8010)		,
		Convolution2D = ((int)0x8011)		,
		Separable2D = ((int)0x8012)		,
	}
	public enum ConvolutionTargetExt : int {
		Convolution1DExt = ((int)0x8010)		,
		Convolution2DExt = ((int)0x8011)		,
	}
	public enum CullFaceMode : int {
		Front = ((int)0x0404)		,
		Back = ((int)0x0405)		,
		FrontAndBack = ((int)0x0408)		,
	}
	public enum DataType : int {
		Byte = ((int)0x1400)		,
		UnsignedByte = ((int)0x1401)		,
		Short = ((int)0x1402)		,
		UnsignedShort = ((int)0x1403)		,
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
		Float = ((int)0x1406)		,
		Gl2Bytes = ((int)0x1407)		,
		Gl3Bytes = ((int)0x1408)		,
		Gl4Bytes = ((int)0x1409)		,
		Double = ((int)0x140A)		,
		DoubleExt = ((int)0x140A)		,
	}
	public enum DepthFunction : int {
		Never = ((int)0x0200)		,
		Less = ((int)0x0201)		,
		Equal = ((int)0x0202)		,
		Lequal = ((int)0x0203)		,
		Greater = ((int)0x0204)		,
		Notequal = ((int)0x0205)		,
		Gequal = ((int)0x0206)		,
		Always = ((int)0x0207)		,
	}
	public enum DmpShaderBinary : int {
		ShaderBinaryDmp = ((int)0x9250)		,
	}
	public enum DrawBufferMode : int {
		None = ((int)0)		,
		FrontLeft = ((int)0x0400)		,
		FrontRight = ((int)0x0401)		,
		BackLeft = ((int)0x0402)		,
		BackRight = ((int)0x0403)		,
		Front = ((int)0x0404)		,
		Back = ((int)0x0405)		,
		Left = ((int)0x0406)		,
		Right = ((int)0x0407)		,
		FrontAndBack = ((int)0x0408)		,
		Aux0 = ((int)0x0409)		,
		Aux1 = ((int)0x040A)		,
		Aux2 = ((int)0x040B)		,
		Aux3 = ((int)0x040C)		,
		ColorAttachment0 = ((int)0x8CE0)		,
		ColorAttachment1 = ((int)0x8CE1)		,
		ColorAttachment2 = ((int)0x8CE2)		,
		ColorAttachment3 = ((int)0x8CE3)		,
		ColorAttachment4 = ((int)0x8CE4)		,
		ColorAttachment5 = ((int)0x8CE5)		,
		ColorAttachment6 = ((int)0x8CE6)		,
		ColorAttachment7 = ((int)0x8CE7)		,
		ColorAttachment8 = ((int)0x8CE8)		,
		ColorAttachment9 = ((int)0x8CE9)		,
		ColorAttachment10 = ((int)0x8CEA)		,
		ColorAttachment11 = ((int)0x8CEB)		,
		ColorAttachment12 = ((int)0x8CEC)		,
		ColorAttachment13 = ((int)0x8CED)		,
		ColorAttachment14 = ((int)0x8CEE)		,
		ColorAttachment15 = ((int)0x8CEF)		,
	}
	public enum DrawBuffersEnum : int {
		None = ((int)0)		,
		FrontLeft = ((int)0x0400)		,
		FrontRight = ((int)0x0401)		,
		BackLeft = ((int)0x0402)		,
		BackRight = ((int)0x0403)		,
		Aux0 = ((int)0x0409)		,
		Aux1 = ((int)0x040A)		,
		Aux2 = ((int)0x040B)		,
		Aux3 = ((int)0x040C)		,
		ColorAttachment0 = ((int)0x8CE0)		,
		ColorAttachment1 = ((int)0x8CE1)		,
		ColorAttachment2 = ((int)0x8CE2)		,
		ColorAttachment3 = ((int)0x8CE3)		,
		ColorAttachment4 = ((int)0x8CE4)		,
		ColorAttachment5 = ((int)0x8CE5)		,
		ColorAttachment6 = ((int)0x8CE6)		,
		ColorAttachment7 = ((int)0x8CE7)		,
		ColorAttachment8 = ((int)0x8CE8)		,
		ColorAttachment9 = ((int)0x8CE9)		,
		ColorAttachment10 = ((int)0x8CEA)		,
		ColorAttachment11 = ((int)0x8CEB)		,
		ColorAttachment12 = ((int)0x8CEC)		,
		ColorAttachment13 = ((int)0x8CED)		,
		ColorAttachment14 = ((int)0x8CEE)		,
		ColorAttachment15 = ((int)0x8CEF)		,
	}
	public enum DrawElementsType : int {
		UnsignedByte = ((int)0x1401)		,
		UnsignedShort = ((int)0x1403)		,
		UnsignedInt = ((int)0x1405)		,
	}
	public enum EnableCap : int {
		PointSmooth = ((int)0x0B10)		,
		LineSmooth = ((int)0x0B20)		,
		LineStipple = ((int)0x0B24)		,
		PolygonSmooth = ((int)0x0B41)		,
		PolygonStipple = ((int)0x0B42)		,
		CullFace = ((int)0x0B44)		,
		Lighting = ((int)0x0B50)		,
		ColorMaterial = ((int)0x0B57)		,
		Fog = ((int)0x0B60)		,
		DepthTest = ((int)0x0B71)		,
		StencilTest = ((int)0x0B90)		,
		Normalize = ((int)0x0BA1)		,
		AlphaTest = ((int)0x0BC0)		,
		Dither = ((int)0x0BD0)		,
		Blend = ((int)0x0BE2)		,
		IndexLogicOp = ((int)0x0BF1)		,
		ColorLogicOp = ((int)0x0BF2)		,
		ScissorTest = ((int)0x0C11)		,
		TextureGenS = ((int)0x0C60)		,
		TextureGenT = ((int)0x0C61)		,
		TextureGenR = ((int)0x0C62)		,
		TextureGenQ = ((int)0x0C63)		,
		AutoNormal = ((int)0x0D80)		,
		Map1Color4 = ((int)0x0D90)		,
		Map1Index = ((int)0x0D91)		,
		Map1Normal = ((int)0x0D92)		,
		Map1TextureCoord1 = ((int)0x0D93)		,
		Map1TextureCoord2 = ((int)0x0D94)		,
		Map1TextureCoord3 = ((int)0x0D95)		,
		Map1TextureCoord4 = ((int)0x0D96)		,
		Map1Vertex3 = ((int)0x0D97)		,
		Map1Vertex4 = ((int)0x0D98)		,
		Map2Color4 = ((int)0x0DB0)		,
		Map2Index = ((int)0x0DB1)		,
		Map2Normal = ((int)0x0DB2)		,
		Map2TextureCoord1 = ((int)0x0DB3)		,
		Map2TextureCoord2 = ((int)0x0DB4)		,
		Map2TextureCoord3 = ((int)0x0DB5)		,
		Map2TextureCoord4 = ((int)0x0DB6)		,
		Map2Vertex3 = ((int)0x0DB7)		,
		Map2Vertex4 = ((int)0x0DB8)		,
		Texture1D = ((int)0x0DE0)		,
		Texture2D = ((int)0x0DE1)		,
		PolygonOffsetPoint = ((int)0x2A01)		,
		PolygonOffsetLine = ((int)0x2A02)		,
		ClipPlane0 = ((int)0x3000)		,
		ClipPlane1 = ((int)0x3001)		,
		ClipPlane2 = ((int)0x3002)		,
		ClipPlane3 = ((int)0x3003)		,
		ClipPlane4 = ((int)0x3004)		,
		ClipPlane5 = ((int)0x3005)		,
		Light0 = ((int)0x4000)		,
		Light1 = ((int)0x4001)		,
		Light2 = ((int)0x4002)		,
		Light3 = ((int)0x4003)		,
		Light4 = ((int)0x4004)		,
		Light5 = ((int)0x4005)		,
		Light6 = ((int)0x4006)		,
		Light7 = ((int)0x4007)		,
		Convolution1D = ((int)0x8010)		,
		Convolution1DExt = ((int)0x8010)		,
		Convolution2D = ((int)0x8011)		,
		Convolution2DExt = ((int)0x8011)		,
		Separable2D = ((int)0x8012)		,
		Separable2DExt = ((int)0x8012)		,
		Histogram = ((int)0x8024)		,
		HistogramExt = ((int)0x8024)		,
		MinmaxExt = ((int)0x802E)		,
		PolygonOffsetFill = ((int)0x8037)		,
		RescaleNormal = ((int)0x803A)		,
		RescaleNormalExt = ((int)0x803A)		,
		Texture3DExt = ((int)0x806F)		,
		VertexArray = ((int)0x8074)		,
		NormalArray = ((int)0x8075)		,
		ColorArray = ((int)0x8076)		,
		IndexArray = ((int)0x8077)		,
		TextureCoordArray = ((int)0x8078)		,
		EdgeFlagArray = ((int)0x8079)		,
		InterlaceSgix = ((int)0x8094)		,
		Multisample = ((int)0x809D)		,
		MultisampleSgis = ((int)0x809D)		,
		SampleAlphaToCoverage = ((int)0x809E)		,
		SampleAlphaToMaskSgis = ((int)0x809E)		,
		SampleAlphaToOne = ((int)0x809F)		,
		SampleAlphaToOneSgis = ((int)0x809F)		,
		SampleCoverage = ((int)0x80A0)		,
		SampleMaskSgis = ((int)0x80A0)		,
		TextureColorTableSgi = ((int)0x80BC)		,
		ColorTable = ((int)0x80D0)		,
		ColorTableSgi = ((int)0x80D0)		,
		PostConvolutionColorTable = ((int)0x80D1)		,
		PostConvolutionColorTableSgi = ((int)0x80D1)		,
		PostColorMatrixColorTable = ((int)0x80D2)		,
		PostColorMatrixColorTableSgi = ((int)0x80D2)		,
		Texture4DSgis = ((int)0x8134)		,
		PixelTexGenSgix = ((int)0x8139)		,
		SpriteSgix = ((int)0x8148)		,
		ReferencePlaneSgix = ((int)0x817D)		,
		IrInstrument1Sgix = ((int)0x817F)		,
		CalligraphicFragmentSgix = ((int)0x8183)		,
		FramezoomSgix = ((int)0x818B)		,
		FogOffsetSgix = ((int)0x8198)		,
		SharedTexturePaletteExt = ((int)0x81FB)		,
		AsyncHistogramSgix = ((int)0x832C)		,
		PixelTextureSgis = ((int)0x8353)		,
		AsyncTexImageSgix = ((int)0x835C)		,
		AsyncDrawPixelsSgix = ((int)0x835D)		,
		AsyncReadPixelsSgix = ((int)0x835E)		,
		FragmentLightingSgix = ((int)0x8400)		,
		FragmentColorMaterialSgix = ((int)0x8401)		,
		FragmentLight0Sgix = ((int)0x840C)		,
		FragmentLight1Sgix = ((int)0x840D)		,
		FragmentLight2Sgix = ((int)0x840E)		,
		FragmentLight3Sgix = ((int)0x840F)		,
		FragmentLight4Sgix = ((int)0x8410)		,
		FragmentLight5Sgix = ((int)0x8411)		,
		FragmentLight6Sgix = ((int)0x8412)		,
		FragmentLight7Sgix = ((int)0x8413)		,
		FogCoordArray = ((int)0x8457)		,
		ColorSum = ((int)0x8458)		,
		SecondaryColorArray = ((int)0x845E)		,
		TextureRectangle = ((int)0x84F5)		,
		TextureCubeMap = ((int)0x8513)		,
		ProgramPointSize = ((int)0x8642)		,
		VertexProgramPointSize = ((int)0x8642)		,
		VertexProgramTwoSide = ((int)0x8643)		,
		DepthClamp = ((int)0x864F)		,
		TextureCubeMapSeamless = ((int)0x884F)		,
		PointSprite = ((int)0x8861)		,
		SampleShading = ((int)0x8C36)		,
		RasterizerDiscard = ((int)0x8C89)		,
		FramebufferSrgb = ((int)0x8DB9)		,
		SampleMask = ((int)0x8E51)		,
		PrimitiveRestart = ((int)0x8F9D)		,
	}
	public enum ErrorCode : int {
		NoError = ((int)0)		,
		InvalidEnum = ((int)0x0500)		,
		InvalidValue = ((int)0x0501)		,
		InvalidOperation = ((int)0x0502)		,
		StackOverflow = ((int)0x0503)		,
		StackUnderflow = ((int)0x0504)		,
		OutOfMemory = ((int)0x0505)		,
		InvalidFramebufferOperation = ((int)0x0506)		,
		InvalidFramebufferOperationExt = ((int)0x0506)		,
		TableTooLargeExt = ((int)0x8031)		,
		TextureTooLargeExt = ((int)0x8065)		,
	}
	/*public enum Ext422Pixels : int {
		Gl422Ext = ((int)0x80CC)		,
		Gl422RevExt = ((int)0x80CD)		,
		Gl422AverageExt = ((int)0x80CE)		,
		Gl422RevAverageExt = ((int)0x80CF)		,
	}
	public enum ExtAbgr : int {
		AbgrExt = ((int)0x8000)		,
	}
	public enum ExtBgra : int {
		BgrExt = ((int)0x80E0)		,
		BgraExt = ((int)0x80E1)		,
	}
	public enum ExtBindableUniform : int {
		MaxVertexBindableUniformsExt = ((int)0x8DE2)		,
		MaxFragmentBindableUniformsExt = ((int)0x8DE3)		,
		MaxGeometryBindableUniformsExt = ((int)0x8DE4)		,
		MaxBindableUniformSizeExt = ((int)0x8DED)		,
		UniformBufferExt = ((int)0x8DEE)		,
		UniformBufferBindingExt = ((int)0x8DEF)		,
	}
	public enum ExtBlendColor : int {
		ConstantColorExt = ((int)0x8001)		,
		OneMinusConstantColorExt = ((int)0x8002)		,
		ConstantAlphaExt = ((int)0x8003)		,
		OneMinusConstantAlphaExt = ((int)0x8004)		,
		BlendColorExt = ((int)0x8005)		,
	}
	public enum ExtBlendEquationSeparate : int {
		BlendEquationRgbExt = ((int)0x8009)		,
		BlendEquationAlphaExt = ((int)0x883D)		,
	}
	public enum ExtBlendFuncSeparate : int {
		BlendDstRgbExt = ((int)0x80C8)		,
		BlendSrcRgbExt = ((int)0x80C9)		,
		BlendDstAlphaExt = ((int)0x80CA)		,
		BlendSrcAlphaExt = ((int)0x80CB)		,
	}
	public enum ExtBlendLogicOp : int {
	}
	public enum ExtBlendMinmax : int {
		FuncAdd = ((int)0x8006)		,
		FuncAddExt = ((int)0x8006)		,
		Min = ((int)0x8007)		,
		MinExt = ((int)0x8007)		,
		Max = ((int)0x8008)		,
		MaxExt = ((int)0x8008)		,
		BlendEquation = ((int)0x8009)		,
		BlendEquationExt = ((int)0x8009)		,
	}
	public enum ExtBlendSubtract : int {
		FuncSubtract = ((int)0x800A)		,
		FuncSubtractExt = ((int)0x800A)		,
		FuncReverseSubtract = ((int)0x800B)		,
		FuncReverseSubtractExt = ((int)0x800B)		,
	}
	public enum ExtClipVolumeHint : int {
		ClipVolumeClippingHintExt = ((int)0x80F0)		,
	}
	public enum ExtCmyka : int {
		CmykExt = ((int)0x800C)		,
		CmykaExt = ((int)0x800D)		,
		PackCmykHintExt = ((int)0x800E)		,
		UnpackCmykHintExt = ((int)0x800F)		,
	}
	public enum ExtColorSubtable : int {
	}
	public enum ExtCompiledVertexArray : int {
		ArrayElementLockFirstExt = ((int)0x81A8)		,
		ArrayElementLockCountExt = ((int)0x81A9)		,
	}
	public enum ExtConvolution : int {
		Convolution1DExt = ((int)0x8010)		,
		Convolution2DExt = ((int)0x8011)		,
		Separable2DExt = ((int)0x8012)		,
		ConvolutionBorderModeExt = ((int)0x8013)		,
		ConvolutionFilterScaleExt = ((int)0x8014)		,
		ConvolutionFilterBiasExt = ((int)0x8015)		,
		ReduceExt = ((int)0x8016)		,
		ConvolutionFormatExt = ((int)0x8017)		,
		ConvolutionWidthExt = ((int)0x8018)		,
		ConvolutionHeightExt = ((int)0x8019)		,
		MaxConvolutionWidthExt = ((int)0x801A)		,
		MaxConvolutionHeightExt = ((int)0x801B)		,
		PostConvolutionRedScaleExt = ((int)0x801C)		,
		PostConvolutionGreenScaleExt = ((int)0x801D)		,
		PostConvolutionBlueScaleExt = ((int)0x801E)		,
		PostConvolutionAlphaScaleExt = ((int)0x801F)		,
		PostConvolutionRedBiasExt = ((int)0x8020)		,
		PostConvolutionGreenBiasExt = ((int)0x8021)		,
		PostConvolutionBlueBiasExt = ((int)0x8022)		,
		PostConvolutionAlphaBiasExt = ((int)0x8023)		,
	}
	public enum ExtCoordinateFrame : int {
		TangentArrayExt = ((int)0x8439)		,
		BinormalArrayExt = ((int)0x843A)		,
		CurrentTangentExt = ((int)0x843B)		,
		CurrentBinormalExt = ((int)0x843C)		,
		TangentArrayTypeExt = ((int)0x843E)		,
		TangentArrayStrideExt = ((int)0x843F)		,
		BinormalArrayTypeExt = ((int)0x8440)		,
		BinormalArrayStrideExt = ((int)0x8441)		,
		TangentArrayPointerExt = ((int)0x8442)		,
		BinormalArrayPointerExt = ((int)0x8443)		,
		Map1TangentExt = ((int)0x8444)		,
		Map2TangentExt = ((int)0x8445)		,
		Map1BinormalExt = ((int)0x8446)		,
		Map2BinormalExt = ((int)0x8447)		,
	}
	public enum ExtCopyTexture : int {
	}
	public enum ExtCullVertex : int {
		CullVertexExt = ((int)0x81AA)		,
		CullVertexEyePositionExt = ((int)0x81AB)		,
		CullVertexObjectPositionExt = ((int)0x81AC)		,
	}
	public enum ExtDepthBoundsTest : int {
		DepthBoundsTestExt = ((int)0x8890)		,
		DepthBoundsExt = ((int)0x8891)		,
	}
	public enum ExtDirectStateAccess : int {
		ProgramMatrixExt = ((int)0x8E2D)		,
		TransposeProgramMatrixExt = ((int)0x8E2E)		,
		ProgramMatrixStackDepthExt = ((int)0x8E2F)		,
	}
	public enum ExtDiscardFramebuffer : int {
		ColorExt = ((int)0x1800)		,
		DepthExt = ((int)0x1801)		,
		StencilExt = ((int)0x1802)		,
	}
	public enum ExtDrawBuffers2 : int {
	}
	public enum ExtDrawInstanced : int {
	}
	public enum ExtDrawRangeElements : int {
		MaxElementsVerticesExt = ((int)0x80E8)		,
		MaxElementsIndicesExt = ((int)0x80E9)		,
	}
	public enum ExtFogCoord : int {
		FogCoordinateSourceExt = ((int)0x8450)		,
		FogCoordinateExt = ((int)0x8451)		,
		FragmentDepthExt = ((int)0x8452)		,
		CurrentFogCoordinateExt = ((int)0x8453)		,
		FogCoordinateArrayTypeExt = ((int)0x8454)		,
		FogCoordinateArrayStrideExt = ((int)0x8455)		,
		FogCoordinateArrayPointerExt = ((int)0x8456)		,
		FogCoordinateArrayExt = ((int)0x8457)		,
	}
	public enum ExtFramebufferBlit : int {
		DrawFramebufferBindingExt = ((int)0x8CA6)		,
		ReadFramebufferExt = ((int)0x8CA8)		,
		DrawFramebufferExt = ((int)0x8CA9)		,
		ReadFramebufferBindingExt = ((int)0x8CAA)		,
	}
	public enum ExtFramebufferMultisample : int {
		RenderbufferSamplesExt = ((int)0x8CAB)		,
		FramebufferIncompleteMultisampleExt = ((int)0x8D56)		,
		MaxSamplesExt = ((int)0x8D57)		,
	}
	public enum ExtFramebufferMultisampleBlitScaled : int {
		ScaledResolveFastestExt = ((int)0x90BA)		,
		ScaledResolveNicestExt = ((int)0x90BB)		,
	}
	public enum ExtFramebufferObject : int {
		InvalidFramebufferOperationExt = ((int)0x0506)		,
		MaxRenderbufferSizeExt = ((int)0x84E8)		,
		FramebufferBindingExt = ((int)0x8CA6)		,
		RenderbufferBindingExt = ((int)0x8CA7)		,
		FramebufferAttachmentObjectType = ((int)0x8CD0)		,
		FramebufferAttachmentObjectTypeExt = ((int)0x8CD0)		,
		FramebufferAttachmentObjectName = ((int)0x8CD1)		,
		FramebufferAttachmentObjectNameExt = ((int)0x8CD1)		,
		FramebufferAttachmentTextureLevel = ((int)0x8CD2)		,
		FramebufferAttachmentTextureLevelExt = ((int)0x8CD2)		,
		FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)		,
		FramebufferAttachmentTextureCubeMapFaceExt = ((int)0x8CD3)		,
		FramebufferAttachmentTexture3DZoffsetExt = ((int)0x8CD4)		,
		FramebufferAttachmentTextureLayer = ((int)0x8CD4)		,
		FramebufferComplete = ((int)0x8CD5)		,
		FramebufferCompleteExt = ((int)0x8CD5)		,
		FramebufferIncompleteAttachment = ((int)0x8CD6)		,
		FramebufferIncompleteAttachmentExt = ((int)0x8CD6)		,
		FramebufferIncompleteMissingAttachment = ((int)0x8CD7)		,
		FramebufferIncompleteMissingAttachmentExt = ((int)0x8CD7)		,
		FramebufferIncompleteDimensionsExt = ((int)0x8CD9)		,
		FramebufferIncompleteFormatsExt = ((int)0x8CDA)		,
		FramebufferIncompleteDrawBuffer = ((int)0x8CDB)		,
		FramebufferIncompleteDrawBufferExt = ((int)0x8CDB)		,
		FramebufferIncompleteReadBuffer = ((int)0x8CDC)		,
		FramebufferIncompleteReadBufferExt = ((int)0x8CDC)		,
		FramebufferUnsupported = ((int)0x8CDD)		,
		FramebufferUnsupportedExt = ((int)0x8CDD)		,
		MaxColorAttachments = ((int)0x8CDF)		,
		MaxColorAttachmentsExt = ((int)0x8CDF)		,
		ColorAttachment0 = ((int)0x8CE0)		,
		ColorAttachment0Ext = ((int)0x8CE0)		,
		ColorAttachment1 = ((int)0x8CE1)		,
		ColorAttachment1Ext = ((int)0x8CE1)		,
		ColorAttachment2 = ((int)0x8CE2)		,
		ColorAttachment2Ext = ((int)0x8CE2)		,
		ColorAttachment3 = ((int)0x8CE3)		,
		ColorAttachment3Ext = ((int)0x8CE3)		,
		ColorAttachment4 = ((int)0x8CE4)		,
		ColorAttachment4Ext = ((int)0x8CE4)		,
		ColorAttachment5 = ((int)0x8CE5)		,
		ColorAttachment5Ext = ((int)0x8CE5)		,
		ColorAttachment6 = ((int)0x8CE6)		,
		ColorAttachment6Ext = ((int)0x8CE6)		,
		ColorAttachment7 = ((int)0x8CE7)		,
		ColorAttachment7Ext = ((int)0x8CE7)		,
		ColorAttachment8 = ((int)0x8CE8)		,
		ColorAttachment8Ext = ((int)0x8CE8)		,
		ColorAttachment9 = ((int)0x8CE9)		,
		ColorAttachment9Ext = ((int)0x8CE9)		,
		ColorAttachment10 = ((int)0x8CEA)		,
		ColorAttachment10Ext = ((int)0x8CEA)		,
		ColorAttachment11 = ((int)0x8CEB)		,
		ColorAttachment11Ext = ((int)0x8CEB)		,
		ColorAttachment12 = ((int)0x8CEC)		,
		ColorAttachment12Ext = ((int)0x8CEC)		,
		ColorAttachment13 = ((int)0x8CED)		,
		ColorAttachment13Ext = ((int)0x8CED)		,
		ColorAttachment14 = ((int)0x8CEE)		,
		ColorAttachment14Ext = ((int)0x8CEE)		,
		ColorAttachment15 = ((int)0x8CEF)		,
		ColorAttachment15Ext = ((int)0x8CEF)		,
		DepthAttachment = ((int)0x8D00)		,
		DepthAttachmentExt = ((int)0x8D00)		,
		StencilAttachment = ((int)0x8D20)		,
		StencilAttachmentExt = ((int)0x8D20)		,
		Framebuffer = ((int)0x8D40)		,
		FramebufferExt = ((int)0x8D40)		,
		Renderbuffer = ((int)0x8D41)		,
		RenderbufferExt = ((int)0x8D41)		,
		RenderbufferWidth = ((int)0x8D42)		,
		RenderbufferWidthExt = ((int)0x8D42)		,
		RenderbufferHeight = ((int)0x8D43)		,
		RenderbufferHeightExt = ((int)0x8D43)		,
		RenderbufferInternalFormat = ((int)0x8D44)		,
		RenderbufferInternalFormatExt = ((int)0x8D44)		,
		StencilIndex1 = ((int)0x8D46)		,
		StencilIndex1Ext = ((int)0x8D46)		,
		StencilIndex4 = ((int)0x8D47)		,
		StencilIndex4Ext = ((int)0x8D47)		,
		StencilIndex8 = ((int)0x8D48)		,
		StencilIndex8Ext = ((int)0x8D48)		,
		StencilIndex16 = ((int)0x8D49)		,
		StencilIndex16Ext = ((int)0x8D49)		,
		RenderbufferRedSize = ((int)0x8D50)		,
		RenderbufferRedSizeExt = ((int)0x8D50)		,
		RenderbufferGreenSize = ((int)0x8D51)		,
		RenderbufferGreenSizeExt = ((int)0x8D51)		,
		RenderbufferBlueSize = ((int)0x8D52)		,
		RenderbufferBlueSizeExt = ((int)0x8D52)		,
		RenderbufferAlphaSize = ((int)0x8D53)		,
		RenderbufferAlphaSizeExt = ((int)0x8D53)		,
		RenderbufferDepthSize = ((int)0x8D54)		,
		RenderbufferDepthSizeExt = ((int)0x8D54)		,
		RenderbufferStencilSize = ((int)0x8D55)		,
		RenderbufferStencilSizeExt = ((int)0x8D55)		,
	}
	public enum ExtFramebufferSrgb : int {
		FramebufferSrgbExt = ((int)0x8DB9)		,
		FramebufferSrgbCapableExt = ((int)0x8DBA)		,
	}
	public enum ExtGeometryShader4 : int {
		LinesAdjacencyExt = ((int)0x000A)		,
		LineStripAdjacencyExt = ((int)0x000B)		,
		TrianglesAdjacencyExt = ((int)0x000C)		,
		TriangleStripAdjacencyExt = ((int)0x000D)		,
		ProgramPointSizeExt = ((int)0x8642)		,
		MaxVaryingComponentsExt = ((int)0x8B4B)		,
		MaxGeometryTextureImageUnitsExt = ((int)0x8C29)		,
		FramebufferAttachmentTextureLayerExt = ((int)0x8CD4)		,
		FramebufferAttachmentLayeredExt = ((int)0x8DA7)		,
		FramebufferIncompleteLayerTargetsExt = ((int)0x8DA8)		,
		FramebufferIncompleteLayerCountExt = ((int)0x8DA9)		,
		GeometryShaderExt = ((int)0x8DD9)		,
		GeometryVerticesOutExt = ((int)0x8DDA)		,
		GeometryInputTypeExt = ((int)0x8DDB)		,
		GeometryOutputTypeExt = ((int)0x8DDC)		,
		MaxGeometryVaryingComponentsExt = ((int)0x8DDD)		,
		MaxVertexVaryingComponentsExt = ((int)0x8DDE)		,
		MaxGeometryUniformComponentsExt = ((int)0x8DDF)		,
		MaxGeometryOutputVerticesExt = ((int)0x8DE0)		,
		MaxGeometryTotalOutputComponentsExt = ((int)0x8DE1)		,
	}
	public enum ExtGpuProgramParameters : int {
	}
	public enum ExtGpuShader4 : int {
		Sampler1DArrayExt = ((int)0x8DC0)		,
		Sampler2DArrayExt = ((int)0x8DC1)		,
		SamplerBufferExt = ((int)0x8DC2)		,
		Sampler1DArrayShadowExt = ((int)0x8DC3)		,
		Sampler2DArrayShadowExt = ((int)0x8DC4)		,
		SamplerCubeShadowExt = ((int)0x8DC5)		,
		UnsignedIntVec2Ext = ((int)0x8DC6)		,
		UnsignedIntVec3Ext = ((int)0x8DC7)		,
		UnsignedIntVec4Ext = ((int)0x8DC8)		,
		IntSampler1DExt = ((int)0x8DC9)		,
		IntSampler2DExt = ((int)0x8DCA)		,
		IntSampler3DExt = ((int)0x8DCB)		,
		IntSamplerCubeExt = ((int)0x8DCC)		,
		IntSampler2DRectExt = ((int)0x8DCD)		,
		IntSampler1DArrayExt = ((int)0x8DCE)		,
		IntSampler2DArrayExt = ((int)0x8DCF)		,
		IntSamplerBufferExt = ((int)0x8DD0)		,
		UnsignedIntSampler1DExt = ((int)0x8DD1)		,
		UnsignedIntSampler2DExt = ((int)0x8DD2)		,
		UnsignedIntSampler3DExt = ((int)0x8DD3)		,
		UnsignedIntSamplerCubeExt = ((int)0x8DD4)		,
		UnsignedIntSampler2DRectExt = ((int)0x8DD5)		,
		UnsignedIntSampler1DArrayExt = ((int)0x8DD6)		,
		UnsignedIntSampler2DArrayExt = ((int)0x8DD7)		,
		UnsignedIntSamplerBufferExt = ((int)0x8DD8)		,
	}
	public enum ExtHistogram : int {
		HistogramExt = ((int)0x8024)		,
		ProxyHistogramExt = ((int)0x8025)		,
		HistogramWidthExt = ((int)0x8026)		,
		HistogramFormatExt = ((int)0x8027)		,
		HistogramRedSizeExt = ((int)0x8028)		,
		HistogramGreenSizeExt = ((int)0x8029)		,
		HistogramBlueSizeExt = ((int)0x802A)		,
		HistogramAlphaSizeExt = ((int)0x802B)		,
		HistogramLuminanceSize = ((int)0x802C)		,
		HistogramLuminanceSizeExt = ((int)0x802C)		,
		HistogramSinkExt = ((int)0x802D)		,
		MinmaxExt = ((int)0x802E)		,
		MinmaxFormatExt = ((int)0x802F)		,
		MinmaxSinkExt = ((int)0x8030)		,
		TableTooLargeExt = ((int)0x8031)		,
	}
	public enum ExtIndexArrayFormats : int {
		IuiV2fExt = ((int)0x81AD)		,
		IuiV3fExt = ((int)0x81AE)		,
		IuiN3fV2fExt = ((int)0x81AF)		,
		IuiN3fV3fExt = ((int)0x81B0)		,
		T2fIuiV2fExt = ((int)0x81B1)		,
		T2fIuiV3fExt = ((int)0x81B2)		,
		T2fIuiN3fV2fExt = ((int)0x81B3)		,
		T2fIuiN3fV3fExt = ((int)0x81B4)		,
	}
	public enum ExtIndexFunc : int {
		IndexTestExt = ((int)0x81B5)		,
		IndexTestFuncExt = ((int)0x81B6)		,
		IndexTestRefExt = ((int)0x81B7)		,
	}
	public enum ExtIndexMaterial : int {
		IndexMaterialExt = ((int)0x81B8)		,
		IndexMaterialParameterExt = ((int)0x81B9)		,
		IndexMaterialFaceExt = ((int)0x81BA)		,
	}
	public enum ExtIndexTexture : int {
	}
	public enum ExtLightTexture : int {
		FragmentMaterialExt = ((int)0x8349)		,
		FragmentNormalExt = ((int)0x834A)		,
		FragmentColorExt = ((int)0x834C)		,
		AttenuationExt = ((int)0x834D)		,
		ShadowAttenuationExt = ((int)0x834E)		,
		TextureApplicationModeExt = ((int)0x834F)		,
		TextureLightExt = ((int)0x8350)		,
		TextureMaterialFaceExt = ((int)0x8351)		,
		TextureMaterialParameterExt = ((int)0x8352)		,
		FragmentDepthExt = ((int)0x8452)		,
	}
	public enum ExtMiscAttribute : int {
	}
	public enum ExtMultiDrawArrays : int {
	}
	public enum ExtMultisample : int {
		MultisampleBitExt = ((int)0x20000000)		,
		MultisampleExt = ((int)0x809D)		,
		SampleAlphaToMaskExt = ((int)0x809E)		,
		SampleAlphaToOneExt = ((int)0x809F)		,
		SampleMaskExt = ((int)0x80A0)		,
		Gl1PassExt = ((int)0x80A1)		,
		Gl2Pass0Ext = ((int)0x80A2)		,
		Gl2Pass1Ext = ((int)0x80A3)		,
		Gl4Pass0Ext = ((int)0x80A4)		,
		Gl4Pass1Ext = ((int)0x80A5)		,
		Gl4Pass2Ext = ((int)0x80A6)		,
		Gl4Pass3Ext = ((int)0x80A7)		,
		SampleBuffersExt = ((int)0x80A8)		,
		SamplesExt = ((int)0x80A9)		,
		SampleMaskValueExt = ((int)0x80AA)		,
		SampleMaskInvertExt = ((int)0x80AB)		,
		SamplePatternExt = ((int)0x80AC)		,
	}
	public enum ExtPackedDepthStencil : int {
		DepthStencilExt = ((int)0x84F9)		,
		UnsignedInt248Ext = ((int)0x84FA)		,
		Depth24Stencil8Ext = ((int)0x88F0)		,
		TextureStencilSizeExt = ((int)0x88F1)		,
	}
	public enum ExtPackedFloat : int {
		R11fG11fB10fExt = ((int)0x8C3A)		,
		UnsignedInt10F11F11FRevExt = ((int)0x8C3B)		,
		RgbaSignedComponentsExt = ((int)0x8C3C)		,
	}
	public enum ExtPackedPixels : int {
		UnsignedByte332Ext = ((int)0x8032)		,
		UnsignedShort4444Ext = ((int)0x8033)		,
		UnsignedShort5551Ext = ((int)0x8034)		,
		UnsignedInt8888Ext = ((int)0x8035)		,
		UnsignedInt1010102Ext = ((int)0x8036)		,
		UnsignedByte233RevExt = ((int)0x8362)		,
		UnsignedShort565Ext = ((int)0x8363)		,
		UnsignedShort565RevExt = ((int)0x8364)		,
		UnsignedShort4444RevExt = ((int)0x8365)		,
		UnsignedShort1555RevExt = ((int)0x8366)		,
		UnsignedInt8888RevExt = ((int)0x8367)		,
		UnsignedInt2101010RevExt = ((int)0x8368)		,
	}
	public enum ExtPalettedTexture : int {
		ColorIndex1Ext = ((int)0x80E2)		,
		ColorIndex2Ext = ((int)0x80E3)		,
		ColorIndex4Ext = ((int)0x80E4)		,
		ColorIndex8Ext = ((int)0x80E5)		,
		ColorIndex12Ext = ((int)0x80E6)		,
		ColorIndex16Ext = ((int)0x80E7)		,
		TextureIndexSizeExt = ((int)0x80ED)		,
	}
	public enum ExtPixelBufferObject : int {
		PixelPackBufferExt = ((int)0x88EB)		,
		PixelUnpackBufferExt = ((int)0x88EC)		,
		PixelPackBufferBindingExt = ((int)0x88ED)		,
		PixelUnpackBufferBindingExt = ((int)0x88EF)		,
	}
	public enum ExtPixelTransform : int {
		PixelTransform2DExt = ((int)0x8330)		,
		PixelMagFilterExt = ((int)0x8331)		,
		PixelMinFilterExt = ((int)0x8332)		,
		PixelCubicWeightExt = ((int)0x8333)		,
		CubicExt = ((int)0x8334)		,
		AverageExt = ((int)0x8335)		,
		PixelTransform2DStackDepthExt = ((int)0x8336)		,
		MaxPixelTransform2DStackDepthExt = ((int)0x8337)		,
		PixelTransform2DMatrixExt = ((int)0x8338)		,
	}
	public enum ExtPixelTransformColorTable : int {
	}
	public enum ExtPointParameters : int {
		PointSizeMinExt = ((int)0x8126)		,
		PointSizeMaxExt = ((int)0x8127)		,
		PointFadeThresholdSizeExt = ((int)0x8128)		,
		DistanceAttenuationExt = ((int)0x8129)		,
	}
	public enum ExtPolygonOffset : int {
		PolygonOffsetExt = ((int)0x8037)		,
		PolygonOffsetFactorExt = ((int)0x8038)		,
		PolygonOffsetBiasExt = ((int)0x8039)		,
	}
	public enum ExtProvokingVertex : int {
		QuadsFollowProvokingVertexConventionExt = ((int)0x8E4C)		,
		FirstVertexConventionExt = ((int)0x8E4D)		,
		LastVertexConventionExt = ((int)0x8E4E)		,
		ProvokingVertexExt = ((int)0x8E4F)		,
	}
	public enum ExtRescaleNormal : int {
		RescaleNormalExt = ((int)0x803A)		,
	}
	public enum ExtSecondaryColor : int {
		ColorSumExt = ((int)0x8458)		,
		CurrentSecondaryColorExt = ((int)0x8459)		,
		SecondaryColorArraySizeExt = ((int)0x845A)		,
		SecondaryColorArrayTypeExt = ((int)0x845B)		,
		SecondaryColorArrayStrideExt = ((int)0x845C)		,
		SecondaryColorArrayPointerExt = ((int)0x845D)		,
		SecondaryColorArrayExt = ((int)0x845E)		,
	}
	public enum ExtSeparateShaderObjects : int {
		ActiveProgramExt = ((int)0x8B8D)		,
	}
	public enum ExtSeparateSpecularColor : int {
		LightModelColorControlExt = ((int)0x81F8)		,
		SingleColorExt = ((int)0x81F9)		,
		SeparateSpecularColorExt = ((int)0x81FA)		,
	}
	public enum ExtShaderImageLoadStore : int {
		VertexAttribArrayBarrierBitExt = ((int)0x00000001)		,
		ElementArrayBarrierBitExt = ((int)0x00000002)		,
		UniformBarrierBitExt = ((int)0x00000004)		,
		TextureFetchBarrierBitExt = ((int)0x00000008)		,
		ShaderImageAccessBarrierBitExt = ((int)0x00000020)		,
		CommandBarrierBitExt = ((int)0x00000040)		,
		PixelBufferBarrierBitExt = ((int)0x00000080)		,
		TextureUpdateBarrierBitExt = ((int)0x00000100)		,
		BufferUpdateBarrierBitExt = ((int)0x00000200)		,
		FramebufferBarrierBitExt = ((int)0x00000400)		,
		TransformFeedbackBarrierBitExt = ((int)0x00000800)		,
		AtomicCounterBarrierBitExt = ((int)0x00001000)		,
		MaxImageUnitsExt = ((int)0x8F38)		,
		MaxCombinedImageUnitsAndFragmentOutputsExt = ((int)0x8F39)		,
		ImageBindingNameExt = ((int)0x8F3A)		,
		ImageBindingLevelExt = ((int)0x8F3B)		,
		ImageBindingLayeredExt = ((int)0x8F3C)		,
		ImageBindingLayerExt = ((int)0x8F3D)		,
		ImageBindingAccessExt = ((int)0x8F3E)		,
		Image1DExt = ((int)0x904C)		,
		Image2DExt = ((int)0x904D)		,
		Image3DExt = ((int)0x904E)		,
		Image2DRectExt = ((int)0x904F)		,
		ImageCubeExt = ((int)0x9050)		,
		ImageBufferExt = ((int)0x9051)		,
		Image1DArrayExt = ((int)0x9052)		,
		Image2DArrayExt = ((int)0x9053)		,
		ImageCubeMapArrayExt = ((int)0x9054)		,
		Image2DMultisampleExt = ((int)0x9055)		,
		Image2DMultisampleArrayExt = ((int)0x9056)		,
		IntImage1DExt = ((int)0x9057)		,
		IntImage2DExt = ((int)0x9058)		,
		IntImage3DExt = ((int)0x9059)		,
		IntImage2DRectExt = ((int)0x905A)		,
		IntImageCubeExt = ((int)0x905B)		,
		IntImageBufferExt = ((int)0x905C)		,
		IntImage1DArrayExt = ((int)0x905D)		,
		IntImage2DArrayExt = ((int)0x905E)		,
		IntImageCubeMapArrayExt = ((int)0x905F)		,
		IntImage2DMultisampleExt = ((int)0x9060)		,
		IntImage2DMultisampleArrayExt = ((int)0x9061)		,
		UnsignedIntImage1DExt = ((int)0x9062)		,
		UnsignedIntImage2DExt = ((int)0x9063)		,
		UnsignedIntImage3DExt = ((int)0x9064)		,
		UnsignedIntImage2DRectExt = ((int)0x9065)		,
		UnsignedIntImageCubeExt = ((int)0x9066)		,
		UnsignedIntImageBufferExt = ((int)0x9067)		,
		UnsignedIntImage1DArrayExt = ((int)0x9068)		,
		UnsignedIntImage2DArrayExt = ((int)0x9069)		,
		UnsignedIntImageCubeMapArrayExt = ((int)0x906A)		,
		UnsignedIntImage2DMultisampleExt = ((int)0x906B)		,
		UnsignedIntImage2DMultisampleArrayExt = ((int)0x906C)		,
		MaxImageSamplesExt = ((int)0x906D)		,
		ImageBindingFormatExt = ((int)0x906E)		,
		AllBarrierBitsExt = unchecked((int)0xFFFFFFFF)		,
	}
	public enum ExtShadowFuncs : int {
	}
	public enum ExtSharedTexturePalette : int {
		SharedTexturePaletteExt = ((int)0x81FB)		,
	}
	public enum ExtStencilClearTag : int {
		StencilTagBitsExt = ((int)0x88F2)		,
		StencilClearTagValueExt = ((int)0x88F3)		,
	}
	public enum ExtStencilTwoSide : int {
		StencilTestTwoSideExt = ((int)0x8910)		,
		ActiveStencilFaceExt = ((int)0x8911)		,
	}
	public enum ExtStencilWrap : int {
		IncrWrapExt = ((int)0x8507)		,
		DecrWrapExt = ((int)0x8508)		,
	}
	public enum ExtSubtexture : int {
	}
	public enum ExtTexture : int {
		Alpha4Ext = ((int)0x803B)		,
		Alpha8Ext = ((int)0x803C)		,
		Alpha12Ext = ((int)0x803D)		,
		Alpha16Ext = ((int)0x803E)		,
		Luminance4Ext = ((int)0x803F)		,
		Luminance8Ext = ((int)0x8040)		,
		Luminance12Ext = ((int)0x8041)		,
		Luminance16Ext = ((int)0x8042)		,
		Luminance4Alpha4Ext = ((int)0x8043)		,
		Luminance6Alpha2Ext = ((int)0x8044)		,
		Luminance8Alpha8Ext = ((int)0x8045)		,
		Luminance12Alpha4Ext = ((int)0x8046)		,
		Luminance12Alpha12Ext = ((int)0x8047)		,
		Luminance16Alpha16Ext = ((int)0x8048)		,
		IntensityExt = ((int)0x8049)		,
		Intensity4Ext = ((int)0x804A)		,
		Intensity8Ext = ((int)0x804B)		,
		Intensity12Ext = ((int)0x804C)		,
		Intensity16Ext = ((int)0x804D)		,
		Rgb2Ext = ((int)0x804E)		,
		Rgb4Ext = ((int)0x804F)		,
		Rgb5Ext = ((int)0x8050)		,
		Rgb8Ext = ((int)0x8051)		,
		Rgb10Ext = ((int)0x8052)		,
		Rgb12Ext = ((int)0x8053)		,
		Rgb16Ext = ((int)0x8054)		,
		Rgba2Ext = ((int)0x8055)		,
		Rgba4Ext = ((int)0x8056)		,
		Rgb5A1Ext = ((int)0x8057)		,
		Rgba8Ext = ((int)0x8058)		,
		Rgb10A2Ext = ((int)0x8059)		,
		Rgba12Ext = ((int)0x805A)		,
		Rgba16Ext = ((int)0x805B)		,
		TextureRedSizeExt = ((int)0x805C)		,
		TextureGreenSizeExt = ((int)0x805D)		,
		TextureBlueSizeExt = ((int)0x805E)		,
		TextureAlphaSizeExt = ((int)0x805F)		,
		TextureLuminanceSizeExt = ((int)0x8060)		,
		TextureIntensitySizeExt = ((int)0x8061)		,
		ReplaceExt = ((int)0x8062)		,
		ProxyTexture1DExt = ((int)0x8063)		,
		ProxyTexture2DExt = ((int)0x8064)		,
		TextureTooLargeExt = ((int)0x8065)		,
	}
	public enum ExtTexture3D : int {
		PackSkipImagesExt = ((int)0x806B)		,
		PackImageHeightExt = ((int)0x806C)		,
		UnpackSkipImagesExt = ((int)0x806D)		,
		UnpackImageHeightExt = ((int)0x806E)		,
		Texture3DExt = ((int)0x806F)		,
		ProxyTexture3DExt = ((int)0x8070)		,
		TextureDepthExt = ((int)0x8071)		,
		TextureWrapRExt = ((int)0x8072)		,
		Max3DTextureSizeExt = ((int)0x8073)		,
	}
	public enum ExtTextureArray : int {
		CompareRefDepthToTextureExt = ((int)0x884E)		,
		MaxArrayTextureLayersExt = ((int)0x88FF)		,
		Texture1DArrayExt = ((int)0x8C18)		,
		ProxyTexture1DArrayExt = ((int)0x8C19)		,
		Texture2DArrayExt = ((int)0x8C1A)		,
		ProxyTexture2DArrayExt = ((int)0x8C1B)		,
		TextureBinding1DArrayExt = ((int)0x8C1C)		,
		TextureBinding2DArrayExt = ((int)0x8C1D)		,
		FramebufferAttachmentTextureLayerExt = ((int)0x8CD4)		,
	}
	public enum ExtTextureBufferObject : int {
		TextureBufferExt = ((int)0x8C2A)		,
		MaxTextureBufferSizeExt = ((int)0x8C2B)		,
		TextureBindingBufferExt = ((int)0x8C2C)		,
		TextureBufferDataStoreBindingExt = ((int)0x8C2D)		,
		TextureBufferFormatExt = ((int)0x8C2E)		,
	}
	public enum ExtTextureCompressionLatc : int {
		CompressedLuminanceLatc1Ext = ((int)0x8C70)		,
		CompressedSignedLuminanceLatc1Ext = ((int)0x8C71)		,
		CompressedLuminanceAlphaLatc2Ext = ((int)0x8C72)		,
		CompressedSignedLuminanceAlphaLatc2Ext = ((int)0x8C73)		,
	}
	public enum ExtTextureCompressionRgtc : int {
		CompressedRedRgtc1Ext = ((int)0x8DBB)		,
		CompressedSignedRedRgtc1Ext = ((int)0x8DBC)		,
		CompressedRedGreenRgtc2Ext = ((int)0x8DBD)		,
		CompressedSignedRedGreenRgtc2Ext = ((int)0x8DBE)		,
	}
	public enum ExtTextureCompressionS3tc : int {
		CompressedRgbS3tcDxt1Ext = ((int)0x83F0)		,
		CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)		,
		CompressedRgbaS3tcDxt3Ext = ((int)0x83F2)		,
		CompressedRgbaS3tcDxt5Ext = ((int)0x83F3)		,
	}
	public enum ExtTextureCubeMap : int {
		NormalMapExt = ((int)0x8511)		,
		ReflectionMapExt = ((int)0x8512)		,
		TextureCubeMapExt = ((int)0x8513)		,
		TextureBindingCubeMapExt = ((int)0x8514)		,
		TextureCubeMapPositiveXExt = ((int)0x8515)		,
		TextureCubeMapNegativeXExt = ((int)0x8516)		,
		TextureCubeMapPositiveYExt = ((int)0x8517)		,
		TextureCubeMapNegativeYExt = ((int)0x8518)		,
		TextureCubeMapPositiveZExt = ((int)0x8519)		,
		TextureCubeMapNegativeZExt = ((int)0x851A)		,
		ProxyTextureCubeMapExt = ((int)0x851B)		,
		MaxCubeMapTextureSizeExt = ((int)0x851C)		,
	}
	public enum ExtTextureEnvAdd : int {
	}
	public enum ExtTextureEnvCombine : int {
		CombineExt = ((int)0x8570)		,
		CombineRgbExt = ((int)0x8571)		,
		CombineAlphaExt = ((int)0x8572)		,
		RgbScaleExt = ((int)0x8573)		,
		AddSignedExt = ((int)0x8574)		,
		InterpolateExt = ((int)0x8575)		,
		ConstantExt = ((int)0x8576)		,
		PrimaryColorExt = ((int)0x8577)		,
		PreviousExt = ((int)0x8578)		,
		Source0RgbExt = ((int)0x8580)		,
		Source1RgbExt = ((int)0x8581)		,
		Source2RgbExt = ((int)0x8582)		,
		Source0AlphaExt = ((int)0x8588)		,
		Source1AlphaExt = ((int)0x8589)		,
		Source2AlphaExt = ((int)0x858A)		,
		Operand0RgbExt = ((int)0x8590)		,
		Operand1RgbExt = ((int)0x8591)		,
		Operand2RgbExt = ((int)0x8592)		,
		Operand0AlphaExt = ((int)0x8598)		,
		Operand1AlphaExt = ((int)0x8599)		,
		Operand2AlphaExt = ((int)0x859A)		,
	}
	public enum ExtTextureEnvDot3 : int {
		Dot3RgbExt = ((int)0x8740)		,
		Dot3RgbaExt = ((int)0x8741)		,
	}
	public enum ExtTextureFilterAnisotropic : int {
		TextureMaxAnisotropyExt = ((int)0x84FE)		,
		MaxTextureMaxAnisotropyExt = ((int)0x84FF)		,
	}
	public enum ExtTextureInteger : int {
		Rgba32ui = ((int)0x8D70)		,
		Rgba32uiExt = ((int)0x8D70)		,
		Rgb32ui = ((int)0x8D71)		,
		Rgb32uiExt = ((int)0x8D71)		,
		Alpha32uiExt = ((int)0x8D72)		,
		Intensity32uiExt = ((int)0x8D73)		,
		Luminance32uiExt = ((int)0x8D74)		,
		LuminanceAlpha32uiExt = ((int)0x8D75)		,
		Rgba16ui = ((int)0x8D76)		,
		Rgba16uiExt = ((int)0x8D76)		,
		Rgb16ui = ((int)0x8D77)		,
		Rgb16uiExt = ((int)0x8D77)		,
		Alpha16uiExt = ((int)0x8D78)		,
		Intensity16uiExt = ((int)0x8D79)		,
		Luminance16uiExt = ((int)0x8D7A)		,
		LuminanceAlpha16uiExt = ((int)0x8D7B)		,
		Rgba8ui = ((int)0x8D7C)		,
		Rgba8uiExt = ((int)0x8D7C)		,
		Rgb8ui = ((int)0x8D7D)		,
		Rgb8uiExt = ((int)0x8D7D)		,
		Alpha8uiExt = ((int)0x8D7E)		,
		Intensity8uiExt = ((int)0x8D7F)		,
		Luminance8uiExt = ((int)0x8D80)		,
		LuminanceAlpha8uiExt = ((int)0x8D81)		,
		Rgba32i = ((int)0x8D82)		,
		Rgba32iExt = ((int)0x8D82)		,
		Rgb32i = ((int)0x8D83)		,
		Rgb32iExt = ((int)0x8D83)		,
		Alpha32iExt = ((int)0x8D84)		,
		Intensity32iExt = ((int)0x8D85)		,
		Luminance32iExt = ((int)0x8D86)		,
		LuminanceAlpha32iExt = ((int)0x8D87)		,
		Rgba16i = ((int)0x8D88)		,
		Rgba16iExt = ((int)0x8D88)		,
		Rgb16i = ((int)0x8D89)		,
		Rgb16iExt = ((int)0x8D89)		,
		Alpha16iExt = ((int)0x8D8A)		,
		Intensity16iExt = ((int)0x8D8B)		,
		Luminance16iExt = ((int)0x8D8C)		,
		LuminanceAlpha16iExt = ((int)0x8D8D)		,
		Rgba8i = ((int)0x8D8E)		,
		Rgba8iExt = ((int)0x8D8E)		,
		Rgb8i = ((int)0x8D8F)		,
		Rgb8iExt = ((int)0x8D8F)		,
		Alpha8iExt = ((int)0x8D90)		,
		Intensity8iExt = ((int)0x8D91)		,
		Luminance8iExt = ((int)0x8D92)		,
		LuminanceAlpha8iExt = ((int)0x8D93)		,
		RedInteger = ((int)0x8D94)		,
		RedIntegerExt = ((int)0x8D94)		,
		GreenInteger = ((int)0x8D95)		,
		GreenIntegerExt = ((int)0x8D95)		,
		BlueInteger = ((int)0x8D96)		,
		BlueIntegerExt = ((int)0x8D96)		,
		AlphaInteger = ((int)0x8D97)		,
		AlphaIntegerExt = ((int)0x8D97)		,
		RgbInteger = ((int)0x8D98)		,
		RgbIntegerExt = ((int)0x8D98)		,
		RgbaInteger = ((int)0x8D99)		,
		RgbaIntegerExt = ((int)0x8D99)		,
		BgrInteger = ((int)0x8D9A)		,
		BgrIntegerExt = ((int)0x8D9A)		,
		BgraInteger = ((int)0x8D9B)		,
		BgraIntegerExt = ((int)0x8D9B)		,
		LuminanceIntegerExt = ((int)0x8D9C)		,
		LuminanceAlphaIntegerExt = ((int)0x8D9D)		,
		RgbaIntegerModeExt = ((int)0x8D9E)		,
	}
	public enum ExtTextureLodBias : int {
		MaxTextureLodBiasExt = ((int)0x84FD)		,
		TextureFilterControlExt = ((int)0x8500)		,
		TextureLodBiasExt = ((int)0x8501)		,
	}
	public enum ExtTextureMirrorClamp : int {
		MirrorClampExt = ((int)0x8742)		,
		MirrorClampToEdgeExt = ((int)0x8743)		,
		MirrorClampToBorderExt = ((int)0x8912)		,
	}
	public enum ExtTextureObject : int {
		TexturePriorityExt = ((int)0x8066)		,
		TextureResidentExt = ((int)0x8067)		,
		Texture1DBindingExt = ((int)0x8068)		,
		Texture2DBindingExt = ((int)0x8069)		,
		Texture3DBindingExt = ((int)0x806A)		,
	}
	public enum ExtTexturePerturbNormal : int {
		PerturbExt = ((int)0x85AE)		,
		TextureNormalExt = ((int)0x85AF)		,
	}
	public enum ExtTextureSharedExponent : int {
		Rgb9E5Ext = ((int)0x8C3D)		,
		UnsignedInt5999RevExt = ((int)0x8C3E)		,
		TextureSharedSizeExt = ((int)0x8C3F)		,
	}
	public enum ExtTextureSnorm : int {
		RedSnorm = ((int)0x8F90)		,
		RgSnorm = ((int)0x8F91)		,
		RgbSnorm = ((int)0x8F92)		,
		RgbaSnorm = ((int)0x8F93)		,
		R8Snorm = ((int)0x8F94)		,
		Rg8Snorm = ((int)0x8F95)		,
		Rgb8Snorm = ((int)0x8F96)		,
		Rgba8Snorm = ((int)0x8F97)		,
		R16Snorm = ((int)0x8F98)		,
		Rg16Snorm = ((int)0x8F99)		,
		Rgb16Snorm = ((int)0x8F9A)		,
		Rgba16Snorm = ((int)0x8F9B)		,
		SignedNormalized = ((int)0x8F9C)		,
		AlphaSnorm = ((int)0x9010)		,
		LuminanceSnorm = ((int)0x9011)		,
		LuminanceAlphaSnorm = ((int)0x9012)		,
		IntensitySnorm = ((int)0x9013)		,
		Alpha8Snorm = ((int)0x9014)		,
		Luminance8Snorm = ((int)0x9015)		,
		Luminance8Alpha8Snorm = ((int)0x9016)		,
		Intensity8Snorm = ((int)0x9017)		,
		Alpha16Snorm = ((int)0x9018)		,
		Luminance16Snorm = ((int)0x9019)		,
		Luminance16Alpha16Snorm = ((int)0x901A)		,
		Intensity16Snorm = ((int)0x901B)		,
	}
	public enum ExtTextureSrgb : int {
		SrgbExt = ((int)0x8C40)		,
		Srgb8Ext = ((int)0x8C41)		,
		SrgbAlphaExt = ((int)0x8C42)		,
		Srgb8Alpha8Ext = ((int)0x8C43)		,
		SluminanceAlphaExt = ((int)0x8C44)		,
		Sluminance8Alpha8Ext = ((int)0x8C45)		,
		SluminanceExt = ((int)0x8C46)		,
		Sluminance8Ext = ((int)0x8C47)		,
		CompressedSrgbExt = ((int)0x8C48)		,
		CompressedSrgbAlphaExt = ((int)0x8C49)		,
		CompressedSluminanceExt = ((int)0x8C4A)		,
		CompressedSluminanceAlphaExt = ((int)0x8C4B)		,
		CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C)		,
		CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D)		,
		CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E)		,
		CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F)		,
	}
	public enum ExtTextureSrgbDecode : int {
		TextureSrgbDecodeExt = ((int)0x8A48)		,
		DecodeExt = ((int)0x8A49)		,
		SkipDecodeExt = ((int)0x8A4A)		,
	}
	public enum ExtTextureSwizzle : int {
		TextureSwizzleRExt = ((int)0x8E42)		,
		TextureSwizzleGExt = ((int)0x8E43)		,
		TextureSwizzleBExt = ((int)0x8E44)		,
		TextureSwizzleAExt = ((int)0x8E45)		,
		TextureSwizzleRgbaExt = ((int)0x8E46)		,
	}
	public enum ExtTextureType2101010Rev : int {
	}
	public enum ExtTimerQuery : int {
		TimeElapsedExt = ((int)0x88BF)		,
	}
	public enum ExtTransformFeedback : int {
		TransformFeedbackVaryingMaxLengthExt = ((int)0x8C76)		,
		TransformFeedbackBufferModeExt = ((int)0x8C7F)		,
		MaxTransformFeedbackSeparateComponentsExt = ((int)0x8C80)		,
		TransformFeedbackVaryingsExt = ((int)0x8C83)		,
		TransformFeedbackBufferStartExt = ((int)0x8C84)		,
		TransformFeedbackBufferSizeExt = ((int)0x8C85)		,
		PrimitivesGeneratedExt = ((int)0x8C87)		,
		TransformFeedbackPrimitivesWrittenExt = ((int)0x8C88)		,
		RasterizerDiscardExt = ((int)0x8C89)		,
		MaxTransformFeedbackInterleavedComponentsExt = ((int)0x8C8A)		,
		MaxTransformFeedbackSeparateAttribsExt = ((int)0x8C8B)		,
		InterleavedAttribsExt = ((int)0x8C8C)		,
		SeparateAttribsExt = ((int)0x8C8D)		,
		TransformFeedbackBufferExt = ((int)0x8C8E)		,
		TransformFeedbackBufferBindingExt = ((int)0x8C8F)		,
	}
	public enum ExtVertexArray : int {
		VertexArrayExt = ((int)0x8074)		,
		NormalArrayExt = ((int)0x8075)		,
		ColorArrayExt = ((int)0x8076)		,
		IndexArrayExt = ((int)0x8077)		,
		TextureCoordArrayExt = ((int)0x8078)		,
		EdgeFlagArrayExt = ((int)0x8079)		,
		VertexArraySizeExt = ((int)0x807A)		,
		VertexArrayTypeExt = ((int)0x807B)		,
		VertexArrayStrideExt = ((int)0x807C)		,
		VertexArrayCountExt = ((int)0x807D)		,
		NormalArrayTypeExt = ((int)0x807E)		,
		NormalArrayStrideExt = ((int)0x807F)		,
		NormalArrayCountExt = ((int)0x8080)		,
		ColorArraySizeExt = ((int)0x8081)		,
		ColorArrayTypeExt = ((int)0x8082)		,
		ColorArrayStrideExt = ((int)0x8083)		,
		ColorArrayCountExt = ((int)0x8084)		,
		IndexArrayTypeExt = ((int)0x8085)		,
		IndexArrayStrideExt = ((int)0x8086)		,
		IndexArrayCountExt = ((int)0x8087)		,
		TextureCoordArraySizeExt = ((int)0x8088)		,
		TextureCoordArrayTypeExt = ((int)0x8089)		,
		TextureCoordArrayStrideExt = ((int)0x808A)		,
		TextureCoordArrayCountExt = ((int)0x808B)		,
		EdgeFlagArrayStrideExt = ((int)0x808C)		,
		EdgeFlagArrayCountExt = ((int)0x808D)		,
		VertexArrayPointerExt = ((int)0x808E)		,
		NormalArrayPointerExt = ((int)0x808F)		,
		ColorArrayPointerExt = ((int)0x8090)		,
		IndexArrayPointerExt = ((int)0x8091)		,
		TextureCoordArrayPointerExt = ((int)0x8092)		,
		EdgeFlagArrayPointerExt = ((int)0x8093)		,
	}
	public enum ExtVertexArrayBgra : int {
		Bgra = ((int)0x80E1)		,
	}
	public enum ExtVertexAttrib64bit : int {
		Double = ((int)0x140A)		,
		DoubleMat2Ext = ((int)0x8F46)		,
		DoubleMat3Ext = ((int)0x8F47)		,
		DoubleMat4Ext = ((int)0x8F48)		,
		DoubleMat2x3Ext = ((int)0x8F49)		,
		DoubleMat2x4Ext = ((int)0x8F4A)		,
		DoubleMat3x2Ext = ((int)0x8F4B)		,
		DoubleMat3x4Ext = ((int)0x8F4C)		,
		DoubleMat4x2Ext = ((int)0x8F4D)		,
		DoubleMat4x3Ext = ((int)0x8F4E)		,
		DoubleVec2Ext = ((int)0x8FFC)		,
		DoubleVec3Ext = ((int)0x8FFD)		,
		DoubleVec4Ext = ((int)0x8FFE)		,
	}
	public enum ExtVertexShader : int {
		VertexShaderExt = ((int)0x8780)		,
		VertexShaderBindingExt = ((int)0x8781)		,
		OpIndexExt = ((int)0x8782)		,
		OpNegateExt = ((int)0x8783)		,
		OpDot3Ext = ((int)0x8784)		,
		OpDot4Ext = ((int)0x8785)		,
		OpMulExt = ((int)0x8786)		,
		OpAddExt = ((int)0x8787)		,
		OpMaddExt = ((int)0x8788)		,
		OpFracExt = ((int)0x8789)		,
		OpMaxExt = ((int)0x878A)		,
		OpMinExt = ((int)0x878B)		,
		OpSetGeExt = ((int)0x878C)		,
		OpSetLtExt = ((int)0x878D)		,
		OpClampExt = ((int)0x878E)		,
		OpFloorExt = ((int)0x878F)		,
		OpRoundExt = ((int)0x8790)		,
		OpExpBase2Ext = ((int)0x8791)		,
		OpLogBase2Ext = ((int)0x8792)		,
		OpPowerExt = ((int)0x8793)		,
		OpRecipExt = ((int)0x8794)		,
		OpRecipSqrtExt = ((int)0x8795)		,
		OpSubExt = ((int)0x8796)		,
		OpCrossProductExt = ((int)0x8797)		,
		OpMultiplyMatrixExt = ((int)0x8798)		,
		OpMovExt = ((int)0x8799)		,
		OutputVertexExt = ((int)0x879A)		,
		OutputColor0Ext = ((int)0x879B)		,
		OutputColor1Ext = ((int)0x879C)		,
		OutputTextureCoord0Ext = ((int)0x879D)		,
		OutputTextureCoord1Ext = ((int)0x879E)		,
		OutputTextureCoord2Ext = ((int)0x879F)		,
		OutputTextureCoord3Ext = ((int)0x87A0)		,
		OutputTextureCoord4Ext = ((int)0x87A1)		,
		OutputTextureCoord5Ext = ((int)0x87A2)		,
		OutputTextureCoord6Ext = ((int)0x87A3)		,
		OutputTextureCoord7Ext = ((int)0x87A4)		,
		OutputTextureCoord8Ext = ((int)0x87A5)		,
		OutputTextureCoord9Ext = ((int)0x87A6)		,
		OutputTextureCoord10Ext = ((int)0x87A7)		,
		OutputTextureCoord11Ext = ((int)0x87A8)		,
		OutputTextureCoord12Ext = ((int)0x87A9)		,
		OutputTextureCoord13Ext = ((int)0x87AA)		,
		OutputTextureCoord14Ext = ((int)0x87AB)		,
		OutputTextureCoord15Ext = ((int)0x87AC)		,
		OutputTextureCoord16Ext = ((int)0x87AD)		,
		OutputTextureCoord17Ext = ((int)0x87AE)		,
		OutputTextureCoord18Ext = ((int)0x87AF)		,
		OutputTextureCoord19Ext = ((int)0x87B0)		,
		OutputTextureCoord20Ext = ((int)0x87B1)		,
		OutputTextureCoord21Ext = ((int)0x87B2)		,
		OutputTextureCoord22Ext = ((int)0x87B3)		,
		OutputTextureCoord23Ext = ((int)0x87B4)		,
		OutputTextureCoord24Ext = ((int)0x87B5)		,
		OutputTextureCoord25Ext = ((int)0x87B6)		,
		OutputTextureCoord26Ext = ((int)0x87B7)		,
		OutputTextureCoord27Ext = ((int)0x87B8)		,
		OutputTextureCoord28Ext = ((int)0x87B9)		,
		OutputTextureCoord29Ext = ((int)0x87BA)		,
		OutputTextureCoord30Ext = ((int)0x87BB)		,
		OutputTextureCoord31Ext = ((int)0x87BC)		,
		OutputFogExt = ((int)0x87BD)		,
		ScalarExt = ((int)0x87BE)		,
		VectorExt = ((int)0x87BF)		,
		MatrixExt = ((int)0x87C0)		,
		VariantExt = ((int)0x87C1)		,
		InvariantExt = ((int)0x87C2)		,
		LocalConstantExt = ((int)0x87C3)		,
		LocalExt = ((int)0x87C4)		,
		MaxVertexShaderInstructionsExt = ((int)0x87C5)		,
		MaxVertexShaderVariantsExt = ((int)0x87C6)		,
		MaxVertexShaderInvariantsExt = ((int)0x87C7)		,
		MaxVertexShaderLocalConstantsExt = ((int)0x87C8)		,
		MaxVertexShaderLocalsExt = ((int)0x87C9)		,
		MaxOptimizedVertexShaderInstructionsExt = ((int)0x87CA)		,
		MaxOptimizedVertexShaderVariantsExt = ((int)0x87CB)		,
		MaxOptimizedVertexShaderLocalConstantsExt = ((int)0x87CC)		,
		MaxOptimizedVertexShaderInvariantsExt = ((int)0x87CD)		,
		MaxOptimizedVertexShaderLocalsExt = ((int)0x87CE)		,
		VertexShaderInstructionsExt = ((int)0x87CF)		,
		VertexShaderVariantsExt = ((int)0x87D0)		,
		VertexShaderInvariantsExt = ((int)0x87D1)		,
		VertexShaderLocalConstantsExt = ((int)0x87D2)		,
		VertexShaderLocalsExt = ((int)0x87D3)		,
		VertexShaderOptimizedExt = ((int)0x87D4)		,
		XExt = ((int)0x87D5)		,
		YExt = ((int)0x87D6)		,
		ZExt = ((int)0x87D7)		,
		WExt = ((int)0x87D8)		,
		NegativeXExt = ((int)0x87D9)		,
		NegativeYExt = ((int)0x87DA)		,
		NegativeZExt = ((int)0x87DB)		,
		NegativeWExt = ((int)0x87DC)		,
		ZeroExt = ((int)0x87DD)		,
		OneExt = ((int)0x87DE)		,
		NegativeOneExt = ((int)0x87DF)		,
		NormalizedRangeExt = ((int)0x87E0)		,
		FullRangeExt = ((int)0x87E1)		,
		CurrentVertexExt = ((int)0x87E2)		,
		MvpMatrixExt = ((int)0x87E3)		,
		VariantValueExt = ((int)0x87E4)		,
		VariantDatatypeExt = ((int)0x87E5)		,
		VariantArrayStrideExt = ((int)0x87E6)		,
		VariantArrayTypeExt = ((int)0x87E7)		,
		VariantArrayExt = ((int)0x87E8)		,
		VariantArrayPointerExt = ((int)0x87E9)		,
		InvariantValueExt = ((int)0x87EA)		,
		InvariantDatatypeExt = ((int)0x87EB)		,
		LocalConstantValueExt = ((int)0x87EC)		,
		LocalConstantDatatypeExt = ((int)0x87ED)		,
	}
	public enum ExtVertexWeighting : int {
		Modelview0StackDepthExt = ((int)0x0BA3)		,
		Modelview0MatrixExt = ((int)0x0BA6)		,
		Modelview0Ext = ((int)0x1700)		,
		Modelview1StackDepthExt = ((int)0x8502)		,
		Modelview1MatrixExt = ((int)0x8506)		,
		ModelviewMatrix1Ext = ((int)0x8506)		,
		VertexWeightingExt = ((int)0x8509)		,
		Modelview1Ext = ((int)0x850A)		,
		CurrentVertexWeightExt = ((int)0x850B)		,
		VertexWeightArrayExt = ((int)0x850C)		,
		VertexWeightArraySizeExt = ((int)0x850D)		,
		VertexWeightArrayTypeExt = ((int)0x850E)		,
		VertexWeightArrayStrideExt = ((int)0x850F)		,
		VertexWeightArrayPointerExt = ((int)0x8510)		,
	}
	public enum ExtX11SyncObject : int {
		SyncX11FenceExt = ((int)0x90E1)		,
	}*/
	public enum FeedBackToken : int {
		PassThroughToken = ((int)0x0700)		,
		PointToken = ((int)0x0701)		,
		LineToken = ((int)0x0702)		,
		PolygonToken = ((int)0x0703)		,
		BitmapToken = ((int)0x0704)		,
		DrawPixelToken = ((int)0x0705)		,
		CopyPixelToken = ((int)0x0706)		,
		LineResetToken = ((int)0x0707)		,
	}
	public enum FeedbackType : int {
		Gl2D = ((int)0x0600)		,
		Gl3D = ((int)0x0601)		,
		Gl3DColor = ((int)0x0602)		,
		Gl3DColorTexture = ((int)0x0603)		,
		Gl4DColorTexture = ((int)0x0604)		,
	}
	/*[Flags]
	public enum FfdMaskSgix : int {
		TextureDeformationBitSgix = ((int)0x00000001)		,
		GeometryDeformationBitSgix = ((int)0x00000002)		,
	}
	public enum FfdTargetSgix : int {
		GeometryDeformationSgix = ((int)0x8194)		,
		TextureDeformationSgix = ((int)0x8195)		,
	}*/
	public enum FogMode : int {
		Exp = ((int)0x0800)		,
		Exp2 = ((int)0x0801)		,
		Linear = ((int)0x2601)		,
		FogFuncSgis = ((int)0x812A)		,
		FogCoord = ((int)0x8451)		,
		FragmentDepth = ((int)0x8452)		,
	}
	public enum FogParameter : int {
		FogIndex = ((int)0x0B61)		,
		FogDensity = ((int)0x0B62)		,
		FogStart = ((int)0x0B63)		,
		FogEnd = ((int)0x0B64)		,
		FogMode = ((int)0x0B65)		,
		FogColor = ((int)0x0B66)		,
		FogOffsetValueSgix = ((int)0x8199)		,
		FogCoordSrc = ((int)0x8450)		,
	}
	
	public enum FogPointerType : int {
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		HalfFloat = ((int)0x140B)		,
	}
	public enum FragmentLightModelParameterSgix : int {
		FragmentLightModelLocalViewerSgix = ((int)0x8408)		,
		FragmentLightModelTwoSideSgix = ((int)0x8409)		,
		FragmentLightModelAmbientSgix = ((int)0x840A)		,
		FragmentLightModelNormalInterpolationSgix = ((int)0x840B)		,
	}
	public enum FramebufferAttachment : int {
		DepthStencilAttachment = ((int)0x821A)		,
		ColorAttachment0 = ((int)0x8CE0)		,
		ColorAttachment0Ext = ((int)0x8CE0)		,
		ColorAttachment1 = ((int)0x8CE1)		,
		ColorAttachment1Ext = ((int)0x8CE1)		,
		ColorAttachment2 = ((int)0x8CE2)		,
		ColorAttachment2Ext = ((int)0x8CE2)		,
		ColorAttachment3 = ((int)0x8CE3)		,
		ColorAttachment3Ext = ((int)0x8CE3)		,
		ColorAttachment4 = ((int)0x8CE4)		,
		ColorAttachment4Ext = ((int)0x8CE4)		,
		ColorAttachment5 = ((int)0x8CE5)		,
		ColorAttachment5Ext = ((int)0x8CE5)		,
		ColorAttachment6 = ((int)0x8CE6)		,
		ColorAttachment6Ext = ((int)0x8CE6)		,
		ColorAttachment7 = ((int)0x8CE7)		,
		ColorAttachment7Ext = ((int)0x8CE7)		,
		ColorAttachment8 = ((int)0x8CE8)		,
		ColorAttachment8Ext = ((int)0x8CE8)		,
		ColorAttachment9 = ((int)0x8CE9)		,
		ColorAttachment9Ext = ((int)0x8CE9)		,
		ColorAttachment10 = ((int)0x8CEA)		,
		ColorAttachment10Ext = ((int)0x8CEA)		,
		ColorAttachment11 = ((int)0x8CEB)		,
		ColorAttachment11Ext = ((int)0x8CEB)		,
		ColorAttachment12 = ((int)0x8CEC)		,
		ColorAttachment12Ext = ((int)0x8CEC)		,
		ColorAttachment13 = ((int)0x8CED)		,
		ColorAttachment13Ext = ((int)0x8CED)		,
		ColorAttachment14 = ((int)0x8CEE)		,
		ColorAttachment14Ext = ((int)0x8CEE)		,
		ColorAttachment15 = ((int)0x8CEF)		,
		ColorAttachment15Ext = ((int)0x8CEF)		,
		DepthAttachment = ((int)0x8D00)		,
		DepthAttachmentExt = ((int)0x8D00)		,
		StencilAttachment = ((int)0x8D20)		,
		StencilAttachmentExt = ((int)0x8D20)		,
	}
	public enum FramebufferAttachmentComponentType : int {
		Int = ((int)0x1404)		,
		Float = ((int)0x1406)		,
		Index = ((int)0x8222)		,
		UnsignedNormalized = ((int)0x8C17)		,
	}
	public enum FramebufferAttachmentObjectType : int {
		None = ((int)0)		,
		Texture = ((int)0x1702)		,
		FramebufferDefault = ((int)0x8218)		,
		Renderbuffer = ((int)0x8D41)		,
	}
	public enum FramebufferErrorCode : int {
		FramebufferUndefined = ((int)0x8219)		,
		FramebufferComplete = ((int)0x8CD5)		,
		FramebufferCompleteExt = ((int)0x8CD5)		,
		FramebufferIncompleteAttachment = ((int)0x8CD6)		,
		FramebufferIncompleteAttachmentExt = ((int)0x8CD6)		,
		FramebufferIncompleteMissingAttachment = ((int)0x8CD7)		,
		FramebufferIncompleteMissingAttachmentExt = ((int)0x8CD7)		,
		FramebufferIncompleteDimensionsExt = ((int)0x8CD9)		,
		FramebufferIncompleteFormatsExt = ((int)0x8CDA)		,
		FramebufferIncompleteDrawBuffer = ((int)0x8CDB)		,
		FramebufferIncompleteDrawBufferExt = ((int)0x8CDB)		,
		FramebufferIncompleteReadBuffer = ((int)0x8CDC)		,
		FramebufferIncompleteReadBufferExt = ((int)0x8CDC)		,
		FramebufferUnsupported = ((int)0x8CDD)		,
		FramebufferUnsupportedExt = ((int)0x8CDD)		,
		FramebufferIncompleteMultisample = ((int)0x8D56)		,
		FramebufferIncompleteLayerTargets = ((int)0x8DA8)		,
		FramebufferIncompleteLayerCount = ((int)0x8DA9)		,
	}
	public enum FramebufferParameterName : int {
		FramebufferAttachmentColorEncoding = ((int)0x8210)		,
		FramebufferAttachmentComponentType = ((int)0x8211)		,
		FramebufferAttachmentRedSize = ((int)0x8212)		,
		FramebufferAttachmentGreenSize = ((int)0x8213)		,
		FramebufferAttachmentBlueSize = ((int)0x8214)		,
		FramebufferAttachmentAlphaSize = ((int)0x8215)		,
		FramebufferAttachmentDepthSize = ((int)0x8216)		,
		FramebufferAttachmentStencilSize = ((int)0x8217)		,
		FramebufferAttachmentObjectType = ((int)0x8CD0)		,
		FramebufferAttachmentObjectTypeExt = ((int)0x8CD0)		,
		FramebufferAttachmentObjectName = ((int)0x8CD1)		,
		FramebufferAttachmentObjectNameExt = ((int)0x8CD1)		,
		FramebufferAttachmentTextureLevel = ((int)0x8CD2)		,
		FramebufferAttachmentTextureLevelExt = ((int)0x8CD2)		,
		FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)		,
		FramebufferAttachmentTextureCubeMapFaceExt = ((int)0x8CD3)		,
		FramebufferAttachmentTexture3DZoffsetExt = ((int)0x8CD4)		,
		FramebufferAttachmentTextureLayer = ((int)0x8CD4)		,
		FramebufferAttachmentLayered = ((int)0x8DA7)		,
	}
	public enum FramebufferTarget : int {
		ReadFramebuffer = ((int)0x8CA8)		,
		DrawFramebuffer = ((int)0x8CA9)		,
		Framebuffer = ((int)0x8D40)		,
		FramebufferExt = ((int)0x8D40)		,
	}
	public enum FrontFaceDirection : int {
		Cw = ((int)0x0900)		,
		Ccw = ((int)0x0901)		,
	}
	public enum GenerateMipmapTarget : int {
		Texture1D = ((int)0x0DE0)		,
		Texture2D = ((int)0x0DE1)		,
		Texture3D = ((int)0x806F)		,
		TextureCubeMap = ((int)0x8513)		,
		Texture1DArray = ((int)0x8C18)		,
		Texture2DArray = ((int)0x8C1A)		,
		Texture2DMultisample = ((int)0x9100)		,
		Texture2DMultisampleArray = ((int)0x9102)		,
	}
	public enum GetColorTableParameterPName : int {
		ColorTableScale = ((int)0x80D6)		,
		ColorTableBias = ((int)0x80D7)		,
		ColorTableFormat = ((int)0x80D8)		,
		ColorTableWidth = ((int)0x80D9)		,
		ColorTableRedSize = ((int)0x80DA)		,
		ColorTableGreenSize = ((int)0x80DB)		,
		ColorTableBlueSize = ((int)0x80DC)		,
		ColorTableAlphaSize = ((int)0x80DD)		,
		ColorTableLuminanceSize = ((int)0x80DE)		,
		ColorTableIntensitySize = ((int)0x80DF)		,
	}
	public enum GetColorTableParameterPNameSgi : int {
		ColorTableScaleSgi = ((int)0x80D6)		,
		ColorTableBiasSgi = ((int)0x80D7)		,
		ColorTableFormatSgi = ((int)0x80D8)		,
		ColorTableWidthSgi = ((int)0x80D9)		,
		ColorTableRedSizeSgi = ((int)0x80DA)		,
		ColorTableGreenSizeSgi = ((int)0x80DB)		,
		ColorTableBlueSizeSgi = ((int)0x80DC)		,
		ColorTableAlphaSizeSgi = ((int)0x80DD)		,
		ColorTableLuminanceSizeSgi = ((int)0x80DE)		,
		ColorTableIntensitySizeSgi = ((int)0x80DF)		,
	}
	public enum GetConvolutionParameter : int {
		ConvolutionBorderModeExt = ((int)0x8013)		,
		ConvolutionFilterScaleExt = ((int)0x8014)		,
		ConvolutionFilterBiasExt = ((int)0x8015)		,
		ConvolutionFormatExt = ((int)0x8017)		,
		ConvolutionWidthExt = ((int)0x8018)		,
		ConvolutionHeightExt = ((int)0x8019)		,
		MaxConvolutionWidthExt = ((int)0x801A)		,
		MaxConvolutionHeightExt = ((int)0x801B)		,
	}
	public enum GetConvolutionParameterPName : int {
		ConvolutionBorderMode = ((int)0x8013)		,
		ConvolutionFilterScale = ((int)0x8014)		,
		ConvolutionFilterBias = ((int)0x8015)		,
		ConvolutionFormat = ((int)0x8017)		,
		ConvolutionWidth = ((int)0x8018)		,
		ConvolutionHeight = ((int)0x8019)		,
		MaxConvolutionWidth = ((int)0x801A)		,
		MaxConvolutionHeight = ((int)0x801B)		,
		ConvolutionBorderColor = ((int)0x8154)		,
	}
	public enum GetHistogramParameterPName : int {
		HistogramWidth = ((int)0x8026)		,
		HistogramFormat = ((int)0x8027)		,
		HistogramRedSize = ((int)0x8028)		,
		HistogramGreenSize = ((int)0x8029)		,
		HistogramBlueSize = ((int)0x802A)		,
		HistogramAlphaSize = ((int)0x802B)		,
		HistogramLuminanceSize = ((int)0x802C)		,
		HistogramSink = ((int)0x802D)		,
	}
	public enum GetHistogramParameterPNameExt : int {
		HistogramWidthExt = ((int)0x8026)		,
		HistogramFormatExt = ((int)0x8027)		,
		HistogramRedSizeExt = ((int)0x8028)		,
		HistogramGreenSizeExt = ((int)0x8029)		,
		HistogramBlueSizeExt = ((int)0x802A)		,
		HistogramAlphaSizeExt = ((int)0x802B)		,
		HistogramLuminanceSizeExt = ((int)0x802C)		,
		HistogramSinkExt = ((int)0x802D)		,
	}
	public enum GetIndexedPName : int {
		DepthRange = ((int)0x0B70)		,
		Viewport = ((int)0x0BA2)		,
		ScissorBox = ((int)0x0C10)		,
		ColorWritemask = ((int)0x0C23)		,
		UniformBufferBinding = ((int)0x8A28)		,
		UniformBufferStart = ((int)0x8A29)		,
		UniformBufferSize = ((int)0x8A2A)		,
		TransformFeedbackBufferStart = ((int)0x8C84)		,
		TransformFeedbackBufferSize = ((int)0x8C85)		,
		TransformFeedbackBufferBinding = ((int)0x8C8F)		,
		SampleMaskValue = ((int)0x8E52)		,
	}
	public enum GetMapQuery : int {
		Coeff = ((int)0x0A00)		,
		Order = ((int)0x0A01)		,
		Domain = ((int)0x0A02)		,
	}
	public enum GetMinmaxParameterPName : int {
		MinmaxFormat = ((int)0x802F)		,
		MinmaxSink = ((int)0x8030)		,
	}
	public enum GetMinmaxParameterPNameExt : int {
		MinmaxFormatExt = ((int)0x802F)		,
		MinmaxSinkExt = ((int)0x8030)		,
	}
	public enum GetMultisamplePName : int {
		SamplePosition = ((int)0x8E50)		,
	}
	public enum GetPixelMap : int {
		PixelMapIToI = ((int)0x0C70)		,
		PixelMapSToS = ((int)0x0C71)		,
		PixelMapIToR = ((int)0x0C72)		,
		PixelMapIToG = ((int)0x0C73)		,
		PixelMapIToB = ((int)0x0C74)		,
		PixelMapIToA = ((int)0x0C75)		,
		PixelMapRToR = ((int)0x0C76)		,
		PixelMapGToG = ((int)0x0C77)		,
		PixelMapBToB = ((int)0x0C78)		,
		PixelMapAToA = ((int)0x0C79)		,
	}
	public enum GetPName : int {
		CurrentColor = ((int)0x0B00)		,
		CurrentIndex = ((int)0x0B01)		,
		CurrentNormal = ((int)0x0B02)		,
		CurrentTextureCoords = ((int)0x0B03)		,
		CurrentRasterColor = ((int)0x0B04)		,
		CurrentRasterIndex = ((int)0x0B05)		,
		CurrentRasterTextureCoords = ((int)0x0B06)		,
		CurrentRasterPosition = ((int)0x0B07)		,
		CurrentRasterPositionValid = ((int)0x0B08)		,
		CurrentRasterDistance = ((int)0x0B09)		,
		PointSmooth = ((int)0x0B10)		,
		PointSize = ((int)0x0B11)		,
		PointSizeRange = ((int)0x0B12)		,
		SmoothPointSizeRange = ((int)0x0B12)		,
		PointSizeGranularity = ((int)0x0B13)		,
		SmoothPointSizeGranularity = ((int)0x0B13)		,
		LineSmooth = ((int)0x0B20)		,
		LineWidth = ((int)0x0B21)		,
		LineWidthRange = ((int)0x0B22)		,
		SmoothLineWidthRange = ((int)0x0B22)		,
		LineWidthGranularity = ((int)0x0B23)		,
		SmoothLineWidthGranularity = ((int)0x0B23)		,
		LineStipple = ((int)0x0B24)		,
		LineStipplePattern = ((int)0x0B25)		,
		LineStippleRepeat = ((int)0x0B26)		,
		ListMode = ((int)0x0B30)		,
		MaxListNesting = ((int)0x0B31)		,
		ListBase = ((int)0x0B32)		,
		ListIndex = ((int)0x0B33)		,
		PolygonMode = ((int)0x0B40)		,
		PolygonSmooth = ((int)0x0B41)		,
		PolygonStipple = ((int)0x0B42)		,
		EdgeFlag = ((int)0x0B43)		,
		CullFace = ((int)0x0B44)		,
		CullFaceMode = ((int)0x0B45)		,
		FrontFace = ((int)0x0B46)		,
		Lighting = ((int)0x0B50)		,
		LightModelLocalViewer = ((int)0x0B51)		,
		LightModelTwoSide = ((int)0x0B52)		,
		LightModelAmbient = ((int)0x0B53)		,
		ShadeModel = ((int)0x0B54)		,
		ColorMaterialFace = ((int)0x0B55)		,
		ColorMaterialParameter = ((int)0x0B56)		,
		ColorMaterial = ((int)0x0B57)		,
		Fog = ((int)0x0B60)		,
		FogIndex = ((int)0x0B61)		,
		FogDensity = ((int)0x0B62)		,
		FogStart = ((int)0x0B63)		,
		FogEnd = ((int)0x0B64)		,
		FogMode = ((int)0x0B65)		,
		FogColor = ((int)0x0B66)		,
		DepthRange = ((int)0x0B70)		,
		DepthTest = ((int)0x0B71)		,
		DepthWritemask = ((int)0x0B72)		,
		DepthClearValue = ((int)0x0B73)		,
		DepthFunc = ((int)0x0B74)		,
		AccumClearValue = ((int)0x0B80)		,
		StencilTest = ((int)0x0B90)		,
		StencilClearValue = ((int)0x0B91)		,
		StencilFunc = ((int)0x0B92)		,
		StencilValueMask = ((int)0x0B93)		,
		StencilFail = ((int)0x0B94)		,
		StencilPassDepthFail = ((int)0x0B95)		,
		StencilPassDepthPass = ((int)0x0B96)		,
		StencilRef = ((int)0x0B97)		,
		StencilWritemask = ((int)0x0B98)		,
		MatrixMode = ((int)0x0BA0)		,
		Normalize = ((int)0x0BA1)		,
		Viewport = ((int)0x0BA2)		,
		ModelviewStackDepth = ((int)0x0BA3)		,
		ProjectionStackDepth = ((int)0x0BA4)		,
		TextureStackDepth = ((int)0x0BA5)		,
		ModelviewMatrix = ((int)0x0BA6)		,
		ProjectionMatrix = ((int)0x0BA7)		,
		TextureMatrix = ((int)0x0BA8)		,
		AttribStackDepth = ((int)0x0BB0)		,
		ClientAttribStackDepth = ((int)0x0BB1)		,
		AlphaTest = ((int)0x0BC0)		,
		AlphaTestFunc = ((int)0x0BC1)		,
		AlphaTestRef = ((int)0x0BC2)		,
		Dither = ((int)0x0BD0)		,
		BlendDst = ((int)0x0BE0)		,
		BlendSrc = ((int)0x0BE1)		,
		Blend = ((int)0x0BE2)		,
		LogicOpMode = ((int)0x0BF0)		,
		IndexLogicOp = ((int)0x0BF1)		,
		LogicOp = ((int)0x0BF1)		,
		ColorLogicOp = ((int)0x0BF2)		,
		AuxBuffers = ((int)0x0C00)		,
		DrawBuffer = ((int)0x0C01)		,
		ReadBuffer = ((int)0x0C02)		,
		ScissorBox = ((int)0x0C10)		,
		ScissorTest = ((int)0x0C11)		,
		IndexClearValue = ((int)0x0C20)		,
		IndexWritemask = ((int)0x0C21)		,
		ColorClearValue = ((int)0x0C22)		,
		ColorWritemask = ((int)0x0C23)		,
		IndexMode = ((int)0x0C30)		,
		RgbaMode = ((int)0x0C31)		,
		Doublebuffer = ((int)0x0C32)		,
		Stereo = ((int)0x0C33)		,
		RenderMode = ((int)0x0C40)		,
		PerspectiveCorrectionHint = ((int)0x0C50)		,
		PointSmoothHint = ((int)0x0C51)		,
		LineSmoothHint = ((int)0x0C52)		,
		PolygonSmoothHint = ((int)0x0C53)		,
		FogHint = ((int)0x0C54)		,
		TextureGenS = ((int)0x0C60)		,
		TextureGenT = ((int)0x0C61)		,
		TextureGenR = ((int)0x0C62)		,
		TextureGenQ = ((int)0x0C63)		,
		PixelMapIToISize = ((int)0x0CB0)		,
		PixelMapSToSSize = ((int)0x0CB1)		,
		PixelMapIToRSize = ((int)0x0CB2)		,
		PixelMapIToGSize = ((int)0x0CB3)		,
		PixelMapIToBSize = ((int)0x0CB4)		,
		PixelMapIToASize = ((int)0x0CB5)		,
		PixelMapRToRSize = ((int)0x0CB6)		,
		PixelMapGToGSize = ((int)0x0CB7)		,
		PixelMapBToBSize = ((int)0x0CB8)		,
		PixelMapAToASize = ((int)0x0CB9)		,
		UnpackSwapBytes = ((int)0x0CF0)		,
		UnpackLsbFirst = ((int)0x0CF1)		,
		UnpackRowLength = ((int)0x0CF2)		,
		UnpackSkipRows = ((int)0x0CF3)		,
		UnpackSkipPixels = ((int)0x0CF4)		,
		UnpackAlignment = ((int)0x0CF5)		,
		PackSwapBytes = ((int)0x0D00)		,
		PackLsbFirst = ((int)0x0D01)		,
		PackRowLength = ((int)0x0D02)		,
		PackSkipRows = ((int)0x0D03)		,
		PackSkipPixels = ((int)0x0D04)		,
		PackAlignment = ((int)0x0D05)		,
		MapColor = ((int)0x0D10)		,
		MapStencil = ((int)0x0D11)		,
		IndexShift = ((int)0x0D12)		,
		IndexOffset = ((int)0x0D13)		,
		RedScale = ((int)0x0D14)		,
		RedBias = ((int)0x0D15)		,
		ZoomX = ((int)0x0D16)		,
		ZoomY = ((int)0x0D17)		,
		GreenScale = ((int)0x0D18)		,
		GreenBias = ((int)0x0D19)		,
		BlueScale = ((int)0x0D1A)		,
		BlueBias = ((int)0x0D1B)		,
		AlphaScale = ((int)0x0D1C)		,
		AlphaBias = ((int)0x0D1D)		,
		DepthScale = ((int)0x0D1E)		,
		DepthBias = ((int)0x0D1F)		,
		MaxEvalOrder = ((int)0x0D30)		,
		MaxLights = ((int)0x0D31)		,
		MaxClipDistances = ((int)0x0D32)		,
		MaxClipPlanes = ((int)0x0D32)		,
		MaxTextureSize = ((int)0x0D33)		,
		MaxPixelMapTable = ((int)0x0D34)		,
		MaxAttribStackDepth = ((int)0x0D35)		,
		MaxModelviewStackDepth = ((int)0x0D36)		,
		MaxNameStackDepth = ((int)0x0D37)		,
		MaxProjectionStackDepth = ((int)0x0D38)		,
		MaxTextureStackDepth = ((int)0x0D39)		,
		MaxViewportDims = ((int)0x0D3A)		,
		MaxClientAttribStackDepth = ((int)0x0D3B)		,
		SubpixelBits = ((int)0x0D50)		,
		IndexBits = ((int)0x0D51)		,
		RedBits = ((int)0x0D52)		,
		GreenBits = ((int)0x0D53)		,
		BlueBits = ((int)0x0D54)		,
		AlphaBits = ((int)0x0D55)		,
		DepthBits = ((int)0x0D56)		,
		StencilBits = ((int)0x0D57)		,
		AccumRedBits = ((int)0x0D58)		,
		AccumGreenBits = ((int)0x0D59)		,
		AccumBlueBits = ((int)0x0D5A)		,
		AccumAlphaBits = ((int)0x0D5B)		,
		NameStackDepth = ((int)0x0D70)		,
		AutoNormal = ((int)0x0D80)		,
		Map1Color4 = ((int)0x0D90)		,
		Map1Index = ((int)0x0D91)		,
		Map1Normal = ((int)0x0D92)		,
		Map1TextureCoord1 = ((int)0x0D93)		,
		Map1TextureCoord2 = ((int)0x0D94)		,
		Map1TextureCoord3 = ((int)0x0D95)		,
		Map1TextureCoord4 = ((int)0x0D96)		,
		Map1Vertex3 = ((int)0x0D97)		,
		Map1Vertex4 = ((int)0x0D98)		,
		Map2Color4 = ((int)0x0DB0)		,
		Map2Index = ((int)0x0DB1)		,
		Map2Normal = ((int)0x0DB2)		,
		Map2TextureCoord1 = ((int)0x0DB3)		,
		Map2TextureCoord2 = ((int)0x0DB4)		,
		Map2TextureCoord3 = ((int)0x0DB5)		,
		Map2TextureCoord4 = ((int)0x0DB6)		,
		Map2Vertex3 = ((int)0x0DB7)		,
		Map2Vertex4 = ((int)0x0DB8)		,
		Map1GridDomain = ((int)0x0DD0)		,
		Map1GridSegments = ((int)0x0DD1)		,
		Map2GridDomain = ((int)0x0DD2)		,
		Map2GridSegments = ((int)0x0DD3)		,
		Texture1D = ((int)0x0DE0)		,
		Texture2D = ((int)0x0DE1)		,
		FeedbackBufferSize = ((int)0x0DF1)		,
		FeedbackBufferType = ((int)0x0DF2)		,
		SelectionBufferSize = ((int)0x0DF4)		,
		PolygonOffsetUnits = ((int)0x2A00)		,
		PolygonOffsetPoint = ((int)0x2A01)		,
		PolygonOffsetLine = ((int)0x2A02)		,
		ClipPlane0 = ((int)0x3000)		,
		ClipPlane1 = ((int)0x3001)		,
		ClipPlane2 = ((int)0x3002)		,
		ClipPlane3 = ((int)0x3003)		,
		ClipPlane4 = ((int)0x3004)		,
		ClipPlane5 = ((int)0x3005)		,
		Light0 = ((int)0x4000)		,
		Light1 = ((int)0x4001)		,
		Light2 = ((int)0x4002)		,
		Light3 = ((int)0x4003)		,
		Light4 = ((int)0x4004)		,
		Light5 = ((int)0x4005)		,
		Light6 = ((int)0x4006)		,
		Light7 = ((int)0x4007)		,
		BlendColorExt = ((int)0x8005)		,
		BlendEquationExt = ((int)0x8009)		,
		BlendEquationRgb = ((int)0x8009)		,
		PackCmykHintExt = ((int)0x800E)		,
		UnpackCmykHintExt = ((int)0x800F)		,
		Convolution1DExt = ((int)0x8010)		,
		Convolution2DExt = ((int)0x8011)		,
		Separable2DExt = ((int)0x8012)		,
		PostConvolutionRedScaleExt = ((int)0x801C)		,
		PostConvolutionGreenScaleExt = ((int)0x801D)		,
		PostConvolutionBlueScaleExt = ((int)0x801E)		,
		PostConvolutionAlphaScaleExt = ((int)0x801F)		,
		PostConvolutionRedBiasExt = ((int)0x8020)		,
		PostConvolutionGreenBiasExt = ((int)0x8021)		,
		PostConvolutionBlueBiasExt = ((int)0x8022)		,
		PostConvolutionAlphaBiasExt = ((int)0x8023)		,
		HistogramExt = ((int)0x8024)		,
		MinmaxExt = ((int)0x802E)		,
		PolygonOffsetFill = ((int)0x8037)		,
		PolygonOffsetFactor = ((int)0x8038)		,
		PolygonOffsetBiasExt = ((int)0x8039)		,
		RescaleNormalExt = ((int)0x803A)		,
		TextureBinding1D = ((int)0x8068)		,
		TextureBinding2D = ((int)0x8069)		,
		Texture3DBindingExt = ((int)0x806A)		,
		TextureBinding3D = ((int)0x806A)		,
		PackSkipImagesExt = ((int)0x806B)		,
		PackImageHeightExt = ((int)0x806C)		,
		UnpackSkipImagesExt = ((int)0x806D)		,
		UnpackImageHeightExt = ((int)0x806E)		,
		Texture3DExt = ((int)0x806F)		,
		Max3DTextureSize = ((int)0x8073)		,
		Max3DTextureSizeExt = ((int)0x8073)		,
		VertexArray = ((int)0x8074)		,
		NormalArray = ((int)0x8075)		,
		ColorArray = ((int)0x8076)		,
		IndexArray = ((int)0x8077)		,
		TextureCoordArray = ((int)0x8078)		,
		EdgeFlagArray = ((int)0x8079)		,
		VertexArraySize = ((int)0x807A)		,
		VertexArrayType = ((int)0x807B)		,
		VertexArrayStride = ((int)0x807C)		,
		VertexArrayCountExt = ((int)0x807D)		,
		NormalArrayType = ((int)0x807E)		,
		NormalArrayStride = ((int)0x807F)		,
		NormalArrayCountExt = ((int)0x8080)		,
		ColorArraySize = ((int)0x8081)		,
		ColorArrayType = ((int)0x8082)		,
		ColorArrayStride = ((int)0x8083)		,
		ColorArrayCountExt = ((int)0x8084)		,
		IndexArrayType = ((int)0x8085)		,
		IndexArrayStride = ((int)0x8086)		,
		IndexArrayCountExt = ((int)0x8087)		,
		TextureCoordArraySize = ((int)0x8088)		,
		TextureCoordArrayType = ((int)0x8089)		,
		TextureCoordArrayStride = ((int)0x808A)		,
		TextureCoordArrayCountExt = ((int)0x808B)		,
		EdgeFlagArrayStride = ((int)0x808C)		,
		EdgeFlagArrayCountExt = ((int)0x808D)		,
		InterlaceSgix = ((int)0x8094)		,
		DetailTexture2DBindingSgis = ((int)0x8096)		,
		Multisample = ((int)0x809D)		,
		MultisampleSgis = ((int)0x809D)		,
		SampleAlphaToCoverage = ((int)0x809E)		,
		SampleAlphaToMaskSgis = ((int)0x809E)		,
		SampleAlphaToOne = ((int)0x809F)		,
		SampleAlphaToOneSgis = ((int)0x809F)		,
		SampleCoverage = ((int)0x80A0)		,
		SampleMaskSgis = ((int)0x80A0)		,
		SampleBuffers = ((int)0x80A8)		,
		SampleBuffersSgis = ((int)0x80A8)		,
		Samples = ((int)0x80A9)		,
		SamplesSgis = ((int)0x80A9)		,
		SampleCoverageValue = ((int)0x80AA)		,
		SampleMaskValueSgis = ((int)0x80AA)		,
		SampleCoverageInvert = ((int)0x80AB)		,
		SampleMaskInvertSgis = ((int)0x80AB)		,
		SamplePatternSgis = ((int)0x80AC)		,
		ColorMatrixSgi = ((int)0x80B1)		,
		ColorMatrixStackDepthSgi = ((int)0x80B2)		,
		MaxColorMatrixStackDepthSgi = ((int)0x80B3)		,
		PostColorMatrixRedScaleSgi = ((int)0x80B4)		,
		PostColorMatrixGreenScaleSgi = ((int)0x80B5)		,
		PostColorMatrixBlueScaleSgi = ((int)0x80B6)		,
		PostColorMatrixAlphaScaleSgi = ((int)0x80B7)		,
		PostColorMatrixRedBiasSgi = ((int)0x80B8)		,
		PostColorMatrixGreenBiasSgi = ((int)0x80B9)		,
		PostColorMatrixBlueBiasSgi = ((int)0x80BA)		,
		PostColorMatrixAlphaBiasSgi = ((int)0x80BB)		,
		TextureColorTableSgi = ((int)0x80BC)		,
		BlendDstRgb = ((int)0x80C8)		,
		BlendSrcRgb = ((int)0x80C9)		,
		BlendDstAlpha = ((int)0x80CA)		,
		BlendSrcAlpha = ((int)0x80CB)		,
		ColorTableSgi = ((int)0x80D0)		,
		PostConvolutionColorTableSgi = ((int)0x80D1)		,
		PostColorMatrixColorTableSgi = ((int)0x80D2)		,
		MaxElementsVertices = ((int)0x80E8)		,
		MaxElementsIndices = ((int)0x80E9)		,
		PointSizeMin = ((int)0x8126)		,
		PointSizeMinSgis = ((int)0x8126)		,
		PointSizeMax = ((int)0x8127)		,
		PointSizeMaxSgis = ((int)0x8127)		,
		PointFadeThresholdSize = ((int)0x8128)		,
		PointFadeThresholdSizeSgis = ((int)0x8128)		,
		DistanceAttenuationSgis = ((int)0x8129)		,
		PointDistanceAttenuation = ((int)0x8129)		,
		FogFuncPointsSgis = ((int)0x812B)		,
		MaxFogFuncPointsSgis = ((int)0x812C)		,
		PackSkipVolumesSgis = ((int)0x8130)		,
		PackImageDepthSgis = ((int)0x8131)		,
		UnpackSkipVolumesSgis = ((int)0x8132)		,
		UnpackImageDepthSgis = ((int)0x8133)		,
		Texture4DSgis = ((int)0x8134)		,
		Max4DTextureSizeSgis = ((int)0x8138)		,
		PixelTexGenSgix = ((int)0x8139)		,
		PixelTileBestAlignmentSgix = ((int)0x813E)		,
		PixelTileCacheIncrementSgix = ((int)0x813F)		,
		PixelTileWidthSgix = ((int)0x8140)		,
		PixelTileHeightSgix = ((int)0x8141)		,
		PixelTileGridWidthSgix = ((int)0x8142)		,
		PixelTileGridHeightSgix = ((int)0x8143)		,
		PixelTileGridDepthSgix = ((int)0x8144)		,
		PixelTileCacheSizeSgix = ((int)0x8145)		,
		SpriteSgix = ((int)0x8148)		,
		SpriteModeSgix = ((int)0x8149)		,
		SpriteAxisSgix = ((int)0x814A)		,
		SpriteTranslationSgix = ((int)0x814B)		,
		Texture4DBindingSgis = ((int)0x814F)		,
		MaxClipmapDepthSgix = ((int)0x8177)		,
		MaxClipmapVirtualDepthSgix = ((int)0x8178)		,
		PostTextureFilterBiasRangeSgix = ((int)0x817B)		,
		PostTextureFilterScaleRangeSgix = ((int)0x817C)		,
		ReferencePlaneSgix = ((int)0x817D)		,
		ReferencePlaneEquationSgix = ((int)0x817E)		,
		IrInstrument1Sgix = ((int)0x817F)		,
		InstrumentMeasurementsSgix = ((int)0x8181)		,
		CalligraphicFragmentSgix = ((int)0x8183)		,
		FramezoomSgix = ((int)0x818B)		,
		FramezoomFactorSgix = ((int)0x818C)		,
		MaxFramezoomFactorSgix = ((int)0x818D)		,
		GenerateMipmapHint = ((int)0x8192)		,
		GenerateMipmapHintSgis = ((int)0x8192)		,
		DeformationsMaskSgix = ((int)0x8196)		,
		FogOffsetSgix = ((int)0x8198)		,
		FogOffsetValueSgix = ((int)0x8199)		,
		LightModelColorControl = ((int)0x81F8)		,
		SharedTexturePaletteExt = ((int)0x81FB)		,
		MajorVersion = ((int)0x821B)		,
		MinorVersion = ((int)0x821C)		,
		NumExtensions = ((int)0x821D)		,
		ContextFlags = ((int)0x821E)		,
		ProgramPipelineBinding = ((int)0x825A)		,
		MaxViewports = ((int)0x825B)		,
		ViewportSubpixelBits = ((int)0x825C)		,
		ViewportBoundsRange = ((int)0x825D)		,
		LayerProvokingVertex = ((int)0x825E)		,
		ViewportIndexProvokingVertex = ((int)0x825F)		,
		ConvolutionHintSgix = ((int)0x8316)		,
		AsyncMarkerSgix = ((int)0x8329)		,
		PixelTexGenModeSgix = ((int)0x832B)		,
		AsyncHistogramSgix = ((int)0x832C)		,
		MaxAsyncHistogramSgix = ((int)0x832D)		,
		PixelTextureSgis = ((int)0x8353)		,
		AsyncTexImageSgix = ((int)0x835C)		,
		AsyncDrawPixelsSgix = ((int)0x835D)		,
		AsyncReadPixelsSgix = ((int)0x835E)		,
		MaxAsyncTexImageSgix = ((int)0x835F)		,
		MaxAsyncDrawPixelsSgix = ((int)0x8360)		,
		MaxAsyncReadPixelsSgix = ((int)0x8361)		,
		VertexPreclipSgix = ((int)0x83EE)		,
		VertexPreclipHintSgix = ((int)0x83EF)		,
		FragmentLightingSgix = ((int)0x8400)		,
		FragmentColorMaterialSgix = ((int)0x8401)		,
		FragmentColorMaterialFaceSgix = ((int)0x8402)		,
		FragmentColorMaterialParameterSgix = ((int)0x8403)		,
		MaxFragmentLightsSgix = ((int)0x8404)		,
		MaxActiveLightsSgix = ((int)0x8405)		,
		LightEnvModeSgix = ((int)0x8407)		,
		FragmentLightModelLocalViewerSgix = ((int)0x8408)		,
		FragmentLightModelTwoSideSgix = ((int)0x8409)		,
		FragmentLightModelAmbientSgix = ((int)0x840A)		,
		FragmentLightModelNormalInterpolationSgix = ((int)0x840B)		,
		FragmentLight0Sgix = ((int)0x840C)		,
		PackResampleSgix = ((int)0x842C)		,
		UnpackResampleSgix = ((int)0x842D)		,
		CurrentFogCoord = ((int)0x8453)		,
		FogCoordArrayType = ((int)0x8454)		,
		FogCoordArrayStride = ((int)0x8455)		,
		ColorSum = ((int)0x8458)		,
		CurrentSecondaryColor = ((int)0x8459)		,
		SecondaryColorArraySize = ((int)0x845A)		,
		SecondaryColorArrayType = ((int)0x845B)		,
		SecondaryColorArrayStride = ((int)0x845C)		,
		CurrentRasterSecondaryColor = ((int)0x845F)		,
		AliasedPointSizeRange = ((int)0x846D)		,
		AliasedLineWidthRange = ((int)0x846E)		,
		ActiveTexture = ((int)0x84E0)		,
		ClientActiveTexture = ((int)0x84E1)		,
		MaxTextureUnits = ((int)0x84E2)		,
		TransposeModelviewMatrix = ((int)0x84E3)		,
		TransposeProjectionMatrix = ((int)0x84E4)		,
		TransposeTextureMatrix = ((int)0x84E5)		,
		TransposeColorMatrix = ((int)0x84E6)		,
		MaxRenderbufferSize = ((int)0x84E8)		,
		MaxRenderbufferSizeExt = ((int)0x84E8)		,
		TextureCompressionHint = ((int)0x84EF)		,
		TextureBindingRectangle = ((int)0x84F6)		,
		MaxRectangleTextureSize = ((int)0x84F8)		,
		MaxTextureLodBias = ((int)0x84FD)		,
		TextureCubeMap = ((int)0x8513)		,
		TextureBindingCubeMap = ((int)0x8514)		,
		MaxCubeMapTextureSize = ((int)0x851C)		,
		PackSubsampleRateSgix = ((int)0x85A0)		,
		UnpackSubsampleRateSgix = ((int)0x85A1)		,
		VertexArrayBinding = ((int)0x85B5)		,
		ProgramPointSize = ((int)0x8642)		,
		DepthClamp = ((int)0x864F)		,
		NumCompressedTextureFormats = ((int)0x86A2)		,
		CompressedTextureFormats = ((int)0x86A3)		,
		NumProgramBinaryFormats = ((int)0x87FE)		,
		ProgramBinaryFormats = ((int)0x87FF)		,
		StencilBackFunc = ((int)0x8800)		,
		StencilBackFail = ((int)0x8801)		,
		StencilBackPassDepthFail = ((int)0x8802)		,
		StencilBackPassDepthPass = ((int)0x8803)		,
		RgbaFloatMode = ((int)0x8820)		,
		MaxDrawBuffers = ((int)0x8824)		,
		DrawBuffer0 = ((int)0x8825)		,
		DrawBuffer1 = ((int)0x8826)		,
		DrawBuffer2 = ((int)0x8827)		,
		DrawBuffer3 = ((int)0x8828)		,
		DrawBuffer4 = ((int)0x8829)		,
		DrawBuffer5 = ((int)0x882A)		,
		DrawBuffer6 = ((int)0x882B)		,
		DrawBuffer7 = ((int)0x882C)		,
		DrawBuffer8 = ((int)0x882D)		,
		DrawBuffer9 = ((int)0x882E)		,
		DrawBuffer10 = ((int)0x882F)		,
		DrawBuffer11 = ((int)0x8830)		,
		DrawBuffer12 = ((int)0x8831)		,
		DrawBuffer13 = ((int)0x8832)		,
		DrawBuffer14 = ((int)0x8833)		,
		DrawBuffer15 = ((int)0x8834)		,
		BlendEquationAlpha = ((int)0x883D)		,
		TextureCubeMapSeamless = ((int)0x884F)		,
		PointSprite = ((int)0x8861)		,
		MaxVertexAttribs = ((int)0x8869)		,
		MaxTessControlInputComponents = ((int)0x886C)		,
		MaxTessEvaluationInputComponents = ((int)0x886D)		,
		MaxTextureCoords = ((int)0x8871)		,
		MaxTextureImageUnits = ((int)0x8872)		,
		ArrayBufferBinding = ((int)0x8894)		,
		ElementArrayBufferBinding = ((int)0x8895)		,
		VertexArrayBufferBinding = ((int)0x8896)		,
		NormalArrayBufferBinding = ((int)0x8897)		,
		ColorArrayBufferBinding = ((int)0x8898)		,
		IndexArrayBufferBinding = ((int)0x8899)		,
		TextureCoordArrayBufferBinding = ((int)0x889A)		,
		EdgeFlagArrayBufferBinding = ((int)0x889B)		,
		SecondaryColorArrayBufferBinding = ((int)0x889C)		,
		FogCoordArrayBufferBinding = ((int)0x889D)		,
		WeightArrayBufferBinding = ((int)0x889E)		,
		VertexAttribArrayBufferBinding = ((int)0x889F)		,
		PixelPackBufferBinding = ((int)0x88ED)		,
		PixelUnpackBufferBinding = ((int)0x88EF)		,
		MaxDualSourceDrawBuffers = ((int)0x88FC)		,
		MaxArrayTextureLayers = ((int)0x88FF)		,
		MinProgramTexelOffset = ((int)0x8904)		,
		MaxProgramTexelOffset = ((int)0x8905)		,
		SamplerBinding = ((int)0x8919)		,
		ClampVertexColor = ((int)0x891A)		,
		ClampFragmentColor = ((int)0x891B)		,
		ClampReadColor = ((int)0x891C)		,
		MaxVertexUniformBlocks = ((int)0x8A2B)		,
		MaxGeometryUniformBlocks = ((int)0x8A2C)		,
		MaxFragmentUniformBlocks = ((int)0x8A2D)		,
		MaxCombinedUniformBlocks = ((int)0x8A2E)		,
		MaxUniformBufferBindings = ((int)0x8A2F)		,
		MaxUniformBlockSize = ((int)0x8A30)		,
		MaxCombinedVertexUniformComponents = ((int)0x8A31)		,
		MaxCombinedGeometryUniformComponents = ((int)0x8A32)		,
		MaxCombinedFragmentUniformComponents = ((int)0x8A33)		,
		UniformBufferOffsetAlignment = ((int)0x8A34)		,
		MaxFragmentUniformComponents = ((int)0x8B49)		,
		MaxVertexUniformComponents = ((int)0x8B4A)		,
		MaxVaryingComponents = ((int)0x8B4B)		,
		MaxVaryingFloats = ((int)0x8B4B)		,
		MaxVertexTextureImageUnits = ((int)0x8B4C)		,
		MaxCombinedTextureImageUnits = ((int)0x8B4D)		,
		FragmentShaderDerivativeHint = ((int)0x8B8B)		,
		CurrentProgram = ((int)0x8B8D)		,
		ImplementationColorReadType = ((int)0x8B9A)		,
		ImplementationColorReadFormat = ((int)0x8B9B)		,
		TextureBinding1DArray = ((int)0x8C1C)		,
		TextureBinding2DArray = ((int)0x8C1D)		,
		MaxGeometryTextureImageUnits = ((int)0x8C29)		,
		TextureBuffer = ((int)0x8C2A)		,
		MaxTextureBufferSize = ((int)0x8C2B)		,
		TextureBindingBuffer = ((int)0x8C2C)		,
		TextureBufferDataStoreBinding = ((int)0x8C2D)		,
		TextureBufferFormat = ((int)0x8C2E)		,
		SampleShading = ((int)0x8C36)		,
		MinSampleShadingValue = ((int)0x8C37)		,
		MaxTransformFeedbackSeparateComponents = ((int)0x8C80)		,
		MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)		,
		MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)		,
		StencilBackRef = ((int)0x8CA3)		,
		StencilBackValueMask = ((int)0x8CA4)		,
		StencilBackWritemask = ((int)0x8CA5)		,
		DrawFramebufferBinding = ((int)0x8CA6)		,
		FramebufferBinding = ((int)0x8CA6)		,
		FramebufferBindingExt = ((int)0x8CA6)		,
		RenderbufferBinding = ((int)0x8CA7)		,
		RenderbufferBindingExt = ((int)0x8CA7)		,
		ReadFramebufferBinding = ((int)0x8CAA)		,
		MaxColorAttachments = ((int)0x8CDF)		,
		MaxColorAttachmentsExt = ((int)0x8CDF)		,
		MaxSamples = ((int)0x8D57)		,
		FramebufferSrgb = ((int)0x8DB9)		,
		MaxGeometryVaryingComponents = ((int)0x8DDD)		,
		MaxVertexVaryingComponents = ((int)0x8DDE)		,
		MaxGeometryUniformComponents = ((int)0x8DDF)		,
		MaxGeometryOutputVertices = ((int)0x8DE0)		,
		MaxGeometryTotalOutputComponents = ((int)0x8DE1)		,
		MaxSubroutines = ((int)0x8DE7)		,
		MaxSubroutineUniformLocations = ((int)0x8DE8)		,
		ShaderBinaryFormats = ((int)0x8DF8)		,
		NumShaderBinaryFormats = ((int)0x8DF9)		,
		ShaderCompiler = ((int)0x8DFA)		,
		MaxVertexUniformVectors = ((int)0x8DFB)		,
		MaxVaryingVectors = ((int)0x8DFC)		,
		MaxFragmentUniformVectors = ((int)0x8DFD)		,
		MaxCombinedTessControlUniformComponents = ((int)0x8E1E)		,
		MaxCombinedTessEvaluationUniformComponents = ((int)0x8E1F)		,
		TransformFeedbackBufferPaused = ((int)0x8E23)		,
		TransformFeedbackBufferActive = ((int)0x8E24)		,
		TransformFeedbackBinding = ((int)0x8E25)		,
		Timestamp = ((int)0x8E28)		,
		QuadsFollowProvokingVertexConvention = ((int)0x8E4C)		,
		ProvokingVertex = ((int)0x8E4F)		,
		SampleMask = ((int)0x8E51)		,
		MaxSampleMaskWords = ((int)0x8E59)		,
		MaxGeometryShaderInvocations = ((int)0x8E5A)		,
		MinFragmentInterpolationOffset = ((int)0x8E5B)		,
		MaxFragmentInterpolationOffset = ((int)0x8E5C)		,
		FragmentInterpolationOffsetBits = ((int)0x8E5D)		,
		MinProgramTextureGatherOffset = ((int)0x8E5E)		,
		MaxProgramTextureGatherOffset = ((int)0x8E5F)		,
		MaxTransformFeedbackBuffers = ((int)0x8E70)		,
		MaxVertexStreams = ((int)0x8E71)		,
		PatchVertices = ((int)0x8E72)		,
		PatchDefaultInnerLevel = ((int)0x8E73)		,
		PatchDefaultOuterLevel = ((int)0x8E74)		,
		MaxTessGenLevel = ((int)0x8E7E)		,
		MaxTessControlUniformComponents = ((int)0x8E7F)		,
		MaxTessEvaluationUniformComponents = ((int)0x8E80)		,
		MaxTessControlTextureImageUnits = ((int)0x8E81)		,
		MaxTessEvaluationTextureImageUnits = ((int)0x8E82)		,
		MaxTessControlOutputComponents = ((int)0x8E83)		,
		MaxTessPatchComponents = ((int)0x8E84)		,
		MaxTessControlTotalOutputComponents = ((int)0x8E85)		,
		MaxTessEvaluationOutputComponents = ((int)0x8E86)		,
		MaxTessControlUniformBlocks = ((int)0x8E89)		,
		MaxTessEvaluationUniformBlocks = ((int)0x8E8A)		,
		DrawIndirectBufferBinding = ((int)0x8F43)		,
		MaxProgramTextureGatherComponents = ((int)0x8F9F)		,
		TextureBinding2DMultisample = ((int)0x9104)		,
		TextureBinding2DMultisampleArray = ((int)0x9105)		,
		MaxColorTextureSamples = ((int)0x910E)		,
		MaxDepthTextureSamples = ((int)0x910F)		,
		MaxIntegerSamples = ((int)0x9110)		,
		MaxVertexOutputComponents = ((int)0x9122)		,
		MaxGeometryInputComponents = ((int)0x9123)		,
		MaxGeometryOutputComponents = ((int)0x9124)		,
		MaxFragmentInputComponents = ((int)0x9125)		,
        // Manual added
        MaxComputeUniformBlocks = ((int)0x91BB),
        MaxComputeTextureImageUnits = ((int)0x91BC),
        MaxComputeImageUniforms = ((int)0x91BD),
        MaxComputeSharedMemorySize = ((int)0x8262),
        MaxComputeUniformComponents = ((int)0x8263),
        MaxComputeAtomicCounterBuffers = ((int)0x8264),
        MaxComputeAtomicCounters = ((int)0x8265),
        MaxCombinedComputeUniformComponents = ((int)0x8266),
        MaxComputeWorkGroupInvocations = ((int)0x90EB),
        MaxComputeWorkGroupCount = ((int)0x91BE),
        MaxComputeWorkGroupSize = ((int)0x91BF),
        ComputeWorkGroupSize = ((int)0x8267),
        MaxShaderStorageBlockSize = ((int)0x90DE),
        UniformBlockReferencedByComputeShader = ((int)0x90EC),
        AtomicCounterBufferReferencedByComputeShader = ((int)0x90ED),
        DispatchIndirectBufferBinding = ((int)0x90EF),
	}
	public enum GetPointervPName : int {
		FeedbackBufferPointer = ((int)0x0DF0)		,
		SelectionBufferPointer = ((int)0x0DF3)		,
		VertexArrayPointer = ((int)0x808E)		,
		NormalArrayPointer = ((int)0x808F)		,
		ColorArrayPointer = ((int)0x8090)		,
		IndexArrayPointer = ((int)0x8091)		,
		TextureCoordArrayPointer = ((int)0x8092)		,
		EdgeFlagArrayPointer = ((int)0x8093)		,
		InstrumentBufferPointerSgix = ((int)0x8180)		,
		FogCoordArrayPointer = ((int)0x8456)		,
		SecondaryColorArrayPointer = ((int)0x845D)		,
	}
	public enum GetQueryObjectParam : int {
		QueryResult = ((int)0x8866)		,
		QueryResultAvailable = ((int)0x8867)		,
	}
	public enum GetQueryParam : int {
		QueryCounterBits = ((int)0x8864)		,
		CurrentQuery = ((int)0x8865)		,
	}
	public enum GetTextureParameter : int {
		TextureWidth = ((int)0x1000)		,
		TextureHeight = ((int)0x1001)		,
		TextureComponents = ((int)0x1003)		,
		TextureInternalFormat = ((int)0x1003)		,
		TextureBorderColor = ((int)0x1004)		,
		TextureBorder = ((int)0x1005)		,
		TextureMagFilter = ((int)0x2800)		,
		TextureMinFilter = ((int)0x2801)		,
		TextureWrapS = ((int)0x2802)		,
		TextureWrapT = ((int)0x2803)		,
		TextureRedSize = ((int)0x805C)		,
		TextureGreenSize = ((int)0x805D)		,
		TextureBlueSize = ((int)0x805E)		,
		TextureAlphaSize = ((int)0x805F)		,
		TextureLuminanceSize = ((int)0x8060)		,
		TextureIntensitySize = ((int)0x8061)		,
		TexturePriority = ((int)0x8066)		,
		TextureResident = ((int)0x8067)		,
		TextureDepth = ((int)0x8071)		,
		TextureDepthExt = ((int)0x8071)		,
		TextureWrapR = ((int)0x8072)		,
		TextureWrapRExt = ((int)0x8072)		,
		DetailTextureLevelSgis = ((int)0x809A)		,
		DetailTextureModeSgis = ((int)0x809B)		,
		DetailTextureFuncPointsSgis = ((int)0x809C)		,
		SharpenTextureFuncPointsSgis = ((int)0x80B0)		,
		ShadowAmbientSgix = ((int)0x80BF)		,
		DualTextureSelectSgis = ((int)0x8124)		,
		QuadTextureSelectSgis = ((int)0x8125)		,
		Texture4DsizeSgis = ((int)0x8136)		,
		TextureWrapQSgis = ((int)0x8137)		,
		TextureMinLod = ((int)0x813A)		,
		TextureMinLodSgis = ((int)0x813A)		,
		TextureMaxLod = ((int)0x813B)		,
		TextureMaxLodSgis = ((int)0x813B)		,
		TextureBaseLevel = ((int)0x813C)		,
		TextureBaseLevelSgis = ((int)0x813C)		,
		TextureMaxLevel = ((int)0x813D)		,
		TextureMaxLevelSgis = ((int)0x813D)		,
		TextureFilter4SizeSgis = ((int)0x8147)		,
		TextureClipmapCenterSgix = ((int)0x8171)		,
		TextureClipmapFrameSgix = ((int)0x8172)		,
		TextureClipmapOffsetSgix = ((int)0x8173)		,
		TextureClipmapVirtualDepthSgix = ((int)0x8174)		,
		TextureClipmapLodOffsetSgix = ((int)0x8175)		,
		TextureClipmapDepthSgix = ((int)0x8176)		,
		PostTextureFilterBiasSgix = ((int)0x8179)		,
		PostTextureFilterScaleSgix = ((int)0x817A)		,
		TextureLodBiasSSgix = ((int)0x818E)		,
		TextureLodBiasTSgix = ((int)0x818F)		,
		TextureLodBiasRSgix = ((int)0x8190)		,
		GenerateMipmap = ((int)0x8191)		,
		GenerateMipmapSgis = ((int)0x8191)		,
		TextureCompareSgix = ((int)0x819A)		,
		TextureCompareOperatorSgix = ((int)0x819B)		,
		TextureLequalRSgix = ((int)0x819C)		,
		TextureGequalRSgix = ((int)0x819D)		,
		TextureMaxClampSSgix = ((int)0x8369)		,
		TextureMaxClampTSgix = ((int)0x836A)		,
		TextureMaxClampRSgix = ((int)0x836B)		,
		TextureCompressedImageSize = ((int)0x86A0)		,
		TextureCompressed = ((int)0x86A1)		,
		TextureDepthSize = ((int)0x884A)		,
		DepthTextureMode = ((int)0x884B)		,
		TextureCompareMode = ((int)0x884C)		,
		TextureCompareFunc = ((int)0x884D)		,
		TextureStencilSize = ((int)0x88F1)		,
		TextureRedType = ((int)0x8C10)		,
		TextureGreenType = ((int)0x8C11)		,
		TextureBlueType = ((int)0x8C12)		,
		TextureAlphaType = ((int)0x8C13)		,
		TextureLuminanceType = ((int)0x8C14)		,
		TextureIntensityType = ((int)0x8C15)		,
		TextureDepthType = ((int)0x8C16)		,
		TextureSharedSize = ((int)0x8C3F)		,
		TextureSwizzleR = ((int)0x8E42)		,
		TextureSwizzleG = ((int)0x8E43)		,
		TextureSwizzleB = ((int)0x8E44)		,
		TextureSwizzleA = ((int)0x8E45)		,
		TextureSwizzleRgba = ((int)0x8E46)		,
		TextureSamples = ((int)0x9106)		,
		TextureFixedSampleLocations = ((int)0x9107)		,
	}
	/*public enum Gl3DfxMultisample : int {
		MultisampleBit3Dfx = ((int)0x20000000)		,
		Multisample3Dfx = ((int)0x86B2)		,
		SampleBuffers3Dfx = ((int)0x86B3)		,
		Samples3Dfx = ((int)0x86B4)		,
	}
	public enum Gl3DfxTbuffer : int {
	}
	public enum Gl3DfxTextureCompressionFxt1 : int {
		CompressedRgbFxt13Dfx = ((int)0x86B0)		,
		CompressedRgbaFxt13Dfx = ((int)0x86B1)		,
	}*/
	public enum GremedyFrameTerminator : int {
	}
	public enum GremedyStringMarker : int {
	}
	public enum HintMode : int {
		DontCare = ((int)0x1100)		,
		Fastest = ((int)0x1101)		,
		Nicest = ((int)0x1102)		,
	}
	public enum HintTarget : int {
		PerspectiveCorrectionHint = ((int)0x0C50)		,
		PointSmoothHint = ((int)0x0C51)		,
		LineSmoothHint = ((int)0x0C52)		,
		PolygonSmoothHint = ((int)0x0C53)		,
		FogHint = ((int)0x0C54)		,
		PackCmykHintExt = ((int)0x800E)		,
		UnpackCmykHintExt = ((int)0x800F)		,
		TextureMultiBufferHintSgix = ((int)0x812E)		,
		GenerateMipmapHint = ((int)0x8192)		,
		GenerateMipmapHintSgis = ((int)0x8192)		,
		ConvolutionHintSgix = ((int)0x8316)		,
		VertexPreclipHintSgix = ((int)0x83EF)		,
		TextureCompressionHint = ((int)0x84EF)		,
		FragmentShaderDerivativeHint = ((int)0x8B8B)		,
	}
	public enum HistogramTarget : int {
		Histogram = ((int)0x8024)		,
		ProxyHistogram = ((int)0x8025)		,
	}
	public enum HistogramTargetExt : int {
		HistogramExt = ((int)0x8024)		,
		ProxyHistogramExt = ((int)0x8025)		,
	}
	/*public enum HpConvolutionBorderModes : int {
		IgnoreBorderHp = ((int)0x8150)		,
		ConstantBorderHp = ((int)0x8151)		,
		ReplicateBorderHp = ((int)0x8153)		,
		ConvolutionBorderColorHp = ((int)0x8154)		,
	}
	public enum HpImageTransform : int {
		ImageScaleXHp = ((int)0x8155)		,
		ImageScaleYHp = ((int)0x8156)		,
		ImageTranslateXHp = ((int)0x8157)		,
		ImageTranslateYHp = ((int)0x8158)		,
		ImageRotateAngleHp = ((int)0x8159)		,
		ImageRotateOriginXHp = ((int)0x815A)		,
		ImageRotateOriginYHp = ((int)0x815B)		,
		ImageMagFilterHp = ((int)0x815C)		,
		ImageMinFilterHp = ((int)0x815D)		,
		ImageCubicWeightHp = ((int)0x815E)		,
		CubicHp = ((int)0x815F)		,
		AverageHp = ((int)0x8160)		,
		ImageTransform2DHp = ((int)0x8161)		,
		PostImageTransformColorTableHp = ((int)0x8162)		,
		ProxyPostImageTransformColorTableHp = ((int)0x8163)		,
	}
	public enum HpOcclusionTest : int {
		OcclusionTestHp = ((int)0x8165)		,
		OcclusionTestResultHp = ((int)0x8166)		,
	}
	public enum HpTextureLighting : int {
		TextureLightingModeHp = ((int)0x8167)		,
		TexturePostSpecularHp = ((int)0x8168)		,
		TexturePreSpecularHp = ((int)0x8169)		,
	}*/
	/*public enum IbmCullVertex : int {
		CullVertexIbm = ((int)103050)		,
	}
	public enum IbmMultimodeDrawArrays : int {
	}
	public enum IbmRasterposClip : int {
		RasterPositionUnclippedIbm = ((int)0x19262)		,
	}
	public enum IbmTextureMirroredRepeat : int {
		MirroredRepeatIbm = ((int)0x8370)		,
	}
	public enum IbmVertexArrayLists : int {
		VertexArrayListIbm = ((int)103070)		,
		NormalArrayListIbm = ((int)103071)		,
		ColorArrayListIbm = ((int)103072)		,
		IndexArrayListIbm = ((int)103073)		,
		TextureCoordArrayListIbm = ((int)103074)		,
		EdgeFlagArrayListIbm = ((int)103075)		,
		FogCoordinateArrayListIbm = ((int)103076)		,
		SecondaryColorArrayListIbm = ((int)103077)		,
		VertexArrayListStrideIbm = ((int)103080)		,
		NormalArrayListStrideIbm = ((int)103081)		,
		ColorArrayListStrideIbm = ((int)103082)		,
		IndexArrayListStrideIbm = ((int)103083)		,
		TextureCoordArrayListStrideIbm = ((int)103084)		,
		EdgeFlagArrayListStrideIbm = ((int)103085)		,
		FogCoordinateArrayListStrideIbm = ((int)103086)		,
		SecondaryColorArrayListStrideIbm = ((int)103087)		,
	}*/
	public enum ImgMultisampledRenderToTexture : int {
		RenderbufferSamplesImg = ((int)0x9133)		,
		FramebufferIncompleteMultisampleImg = ((int)0x9134)		,
		MaxSamplesImg = ((int)0x9135)		,
		TextureSamplesImg = ((int)0x9136)		,
	}
	public enum ImgProgramBinary : int {
		SgxProgramBinaryImg = ((int)0x9130)		,
	}
	public enum ImgShaderBinary : int {
		SgxBinaryImg = ((int)0x8C0A)		,
	}
	public enum ImgTextureCompressionPvrtc : int {
		CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00)		,
		CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01)		,
		CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02)		,
		CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03)		,
	}
	public enum ImgTextureEnvEnhancedFixedFunction : int {
		Dot3RgbaImg = ((int)0x86AF)		,
		ModulateColorImg = ((int)0x8C04)		,
		RecipAddSignedAlphaImg = ((int)0x8C05)		,
		TextureAlphaModulateImg = ((int)0x8C06)		,
		FactorAlphaModulateImg = ((int)0x8C07)		,
		FragmentAlphaModulateImg = ((int)0x8C08)		,
		AddBlendImg = ((int)0x8C09)		,
	}
	public enum IndexedEnableCap : int {
		Blend = ((int)0x0BE2)		,
		ScissorTest = ((int)0x0C11)		,
	}
	public enum IndexPointerType : int {
		Short = ((int)0x1402)		,
		Int = ((int)0x1404)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
	}
	public enum InterleavedArrayFormat : int {
		V2f = ((int)0x2A20)		,
		V3f = ((int)0x2A21)		,
		C4ubV2f = ((int)0x2A22)		,
		C4ubV3f = ((int)0x2A23)		,
		C3fV3f = ((int)0x2A24)		,
		N3fV3f = ((int)0x2A25)		,
		C4fN3fV3f = ((int)0x2A26)		,
		T2fV3f = ((int)0x2A27)		,
		T4fV4f = ((int)0x2A28)		,
		T2fC4ubV3f = ((int)0x2A29)		,
		T2fC3fV3f = ((int)0x2A2A)		,
		T2fN3fV3f = ((int)0x2A2B)		,
		T2fC4fN3fV3f = ((int)0x2A2C)		,
		T4fC4fN3fV4f = ((int)0x2A2D)		,
	}
	public enum LightModelParameter : int {
		LightModelLocalViewer = ((int)0x0B51)		,
		LightModelTwoSide = ((int)0x0B52)		,
		LightModelAmbient = ((int)0x0B53)		,
		LightModelColorControl = ((int)0x81F8)		,
	}
	public enum LightName : int {
		Light0 = ((int)0x4000)		,
		Light1 = ((int)0x4001)		,
		Light2 = ((int)0x4002)		,
		Light3 = ((int)0x4003)		,
		Light4 = ((int)0x4004)		,
		Light5 = ((int)0x4005)		,
		Light6 = ((int)0x4006)		,
		Light7 = ((int)0x4007)		,
		FragmentLight0Sgix = ((int)0x840C)		,
		FragmentLight1Sgix = ((int)0x840D)		,
		FragmentLight2Sgix = ((int)0x840E)		,
		FragmentLight3Sgix = ((int)0x840F)		,
		FragmentLight4Sgix = ((int)0x8410)		,
		FragmentLight5Sgix = ((int)0x8411)		,
		FragmentLight6Sgix = ((int)0x8412)		,
		FragmentLight7Sgix = ((int)0x8413)		,
	}
	public enum LightParameter : int {
		Ambient = ((int)0x1200)		,
		Diffuse = ((int)0x1201)		,
		Specular = ((int)0x1202)		,
		Position = ((int)0x1203)		,
		SpotDirection = ((int)0x1204)		,
		SpotExponent = ((int)0x1205)		,
		SpotCutoff = ((int)0x1206)		,
		ConstantAttenuation = ((int)0x1207)		,
		LinearAttenuation = ((int)0x1208)		,
		QuadraticAttenuation = ((int)0x1209)		,
	}
	public enum ListMode : int {
		Compile = ((int)0x1300)		,
		CompileAndExecute = ((int)0x1301)		,
	}
	public enum ListNameType : int {
		Byte = ((int)0x1400)		,
		UnsignedByte = ((int)0x1401)		,
		Short = ((int)0x1402)		,
		UnsignedShort = ((int)0x1403)		,
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
		Float = ((int)0x1406)		,
		Gl2Bytes = ((int)0x1407)		,
		Gl3Bytes = ((int)0x1408)		,
		Gl4Bytes = ((int)0x1409)		,
	}
	public enum ListParameterName : int {
		ListPrioritySgix = ((int)0x8182)		,
	}
	public enum LogicOp : int {
		Clear = ((int)0x1500)		,
		And = ((int)0x1501)		,
		AndReverse = ((int)0x1502)		,
		Copy = ((int)0x1503)		,
		AndInverted = ((int)0x1504)		,
		Noop = ((int)0x1505)		,
		Xor = ((int)0x1506)		,
		Or = ((int)0x1507)		,
		Nor = ((int)0x1508)		,
		Equiv = ((int)0x1509)		,
		Invert = ((int)0x150A)		,
		OrReverse = ((int)0x150B)		,
		CopyInverted = ((int)0x150C)		,
		OrInverted = ((int)0x150D)		,
		Nand = ((int)0x150E)		,
		Set = ((int)0x150F)		,
	}
	
	public enum MapTarget : int {
		Map1Color4 = ((int)0x0D90)		,
		Map1Index = ((int)0x0D91)		,
		Map1Normal = ((int)0x0D92)		,
		Map1TextureCoord1 = ((int)0x0D93)		,
		Map1TextureCoord2 = ((int)0x0D94)		,
		Map1TextureCoord3 = ((int)0x0D95)		,
		Map1TextureCoord4 = ((int)0x0D96)		,
		Map1Vertex3 = ((int)0x0D97)		,
		Map1Vertex4 = ((int)0x0D98)		,
		Map2Color4 = ((int)0x0DB0)		,
		Map2Index = ((int)0x0DB1)		,
		Map2Normal = ((int)0x0DB2)		,
		Map2TextureCoord1 = ((int)0x0DB3)		,
		Map2TextureCoord2 = ((int)0x0DB4)		,
		Map2TextureCoord3 = ((int)0x0DB5)		,
		Map2TextureCoord4 = ((int)0x0DB6)		,
		Map2Vertex3 = ((int)0x0DB7)		,
		Map2Vertex4 = ((int)0x0DB8)		,
		GeometryDeformationSgix = ((int)0x8194)		,
		TextureDeformationSgix = ((int)0x8195)		,
	}
	public enum MaterialFace : int {
		Front = ((int)0x0404)		,
		Back = ((int)0x0405)		,
		FrontAndBack = ((int)0x0408)		,
	}
	public enum MaterialParameter : int {
		Ambient = ((int)0x1200)		,
		Diffuse = ((int)0x1201)		,
		Specular = ((int)0x1202)		,
		Emission = ((int)0x1600)		,
		Shininess = ((int)0x1601)		,
		AmbientAndDiffuse = ((int)0x1602)		,
		ColorIndexes = ((int)0x1603)		,
	}
	public enum MatrixMode : int {
		Modelview = ((int)0x1700)		,
		Projection = ((int)0x1701)		,
		Texture = ((int)0x1702)		,
		Color = ((int)0x1800)		,
	}

	/*public enum MesaProgramDebug : int {
		FragmentProgramPositionMesa = ((int)0x8BB0)		,
		FragmentProgramCallbackMesa = ((int)0x8BB1)		,
		FragmentProgramCallbackFuncMesa = ((int)0x8BB2)		,
		FragmentProgramCallbackDataMesa = ((int)0x8BB3)		,
		VertexProgramCallbackMesa = ((int)0x8BB4)		,
		VertexProgramPositionMesa = ((int)0x8BB4)		,
		VertexProgramCallbackFuncMesa = ((int)0x8BB6)		,
		VertexProgramCallbackDataMesa = ((int)0x8BB7)		,
	}
	public enum MesaResizeBuffers : int {
	}
	public enum MesaShaderDebug : int {
		DebugObjectMesa = ((int)0x8759)		,
		DebugPrintMesa = ((int)0x875A)		,
		DebugAssertMesa = ((int)0x875B)		,
	}
	public enum MesaTrace : int {
		TraceOperationsBitMesa = ((int)0x0001)		,
		TracePrimitivesBitMesa = ((int)0x0002)		,
		TraceArraysBitMesa = ((int)0x0004)		,
		TraceTexturesBitMesa = ((int)0x0008)		,
		TracePixelsBitMesa = ((int)0x0010)		,
		TraceErrorsBitMesa = ((int)0x0020)		,
		TraceMaskMesa = ((int)0x8755)		,
		TraceNameMesa = ((int)0x8756)		,
		TraceAllBitsMesa = ((int)0xFFFF)		,
	}
	public enum MesaWindowPos : int {
	}
	public enum MesaxTextureStack : int {
		Texture1DStackMesax = ((int)0x8759)		,
		Texture2DStackMesax = ((int)0x875A)		,
		ProxyTexture1DStackMesax = ((int)0x875B)		,
		ProxyTexture2DStackMesax = ((int)0x875C)		,
		Texture1DStackBindingMesax = ((int)0x875D)		,
		Texture2DStackBindingMesax = ((int)0x875E)		,
	}
	public enum MesaYcbcrTexture : int {
		UnsignedShort88Mesa = ((int)0x85BA)		,
		UnsignedShort88RevMesa = ((int)0x85BB)		,
		YcbcrMesa = ((int)0x8757)		,
	}*/

	public enum MeshMode1 : int {
		Point = ((int)0x1B00)		,
		Line = ((int)0x1B01)		,
	}
	public enum MeshMode2 : int {
		Point = ((int)0x1B00)		,
		Line = ((int)0x1B01)		,
		Fill = ((int)0x1B02)		,
	}
	public enum MinmaxTarget : int {
		Minmax = ((int)0x802E)		,
	}
	public enum MinmaxTargetExt : int {
		MinmaxExt = ((int)0x802E)		,
	}
	public enum NormalPointerType : int {
		Byte = ((int)0x1400)		,
		Short = ((int)0x1402)		,
		Int = ((int)0x1404)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		HalfFloat = ((int)0x140B)		,
		UnsignedInt2101010Rev = ((int)0x8368)		,
		Int2101010Rev = ((int)0x8D9F)		,
	}
	/*public enum NvBlendSquare : int {
	}
	public enum NvConditionalRender : int {
		QueryWaitNv = ((int)0x8E13)		,
		QueryNoWaitNv = ((int)0x8E14)		,
		QueryByRegionWaitNv = ((int)0x8E15)		,
		QueryByRegionNoWaitNv = ((int)0x8E16)		,
	}
	public enum NvCopyDepthToColor : int {
		DepthStencilToRgbaNv = ((int)0x886E)		,
		DepthStencilToBgraNv = ((int)0x886F)		,
	}
	public enum NvCopyImage : int {
	}
	public enum NvCoverageSample : int {
		CoverageBufferBitNv = ((int)0x00008000)		,
		CoverageComponentNv = ((int)0x8ED0)		,
		CoverageComponent4Nv = ((int)0x8ED1)		,
		CoverageAttachmentNv = ((int)0x8ED2)		,
		CoverageBuffersNv = ((int)0x8ED3)		,
		CoverageSamplesNv = ((int)0x8ED4)		,
		CoverageAllFragmentsNv = ((int)0x8ED5)		,
		CoverageEdgeFragmentsNv = ((int)0x8ED6)		,
		CoverageAutomaticNv = ((int)0x8ED7)		,
	}
	public enum NvDepthBufferFloat : int {
		DepthComponent32fNv = ((int)0x8DAB)		,
		Depth32fStencil8Nv = ((int)0x8DAC)		,
		Float32UnsignedInt248RevNv = ((int)0x8DAD)		,
		DepthBufferFloatModeNv = ((int)0x8DAF)		,
	}
	public enum NvDepthClamp : int {
		DepthClampNv = ((int)0x864F)		,
	}
	public enum NvDepthNonlinear : int {
		DepthComponent16NonlinearNv = ((int)0x8E2C)		,
	}
	public enum NvEvaluators : int {
		Eval2DNv = ((int)0x86C0)		,
		EvalTriangular2DNv = ((int)0x86C1)		,
		MapTessellationNv = ((int)0x86C2)		,
		MapAttribUOrderNv = ((int)0x86C3)		,
		MapAttribVOrderNv = ((int)0x86C4)		,
		EvalFractionalTessellationNv = ((int)0x86C5)		,
		EvalVertexAtrrib0Nv = ((int)0x86C6)		,
		EvalVertexAttrib0Nv = ((int)0x86C6)		,
		EvalVertexAtrrib1Nv = ((int)0x86C7)		,
		EvalVertexAttrib1Nv = ((int)0x86C7)		,
		EvalVertexAtrrib2Nv = ((int)0x86C8)		,
		EvalVertexAttrib2Nv = ((int)0x86C8)		,
		EvalVertexAtrrib3Nv = ((int)0x86C9)		,
		EvalVertexAttrib3Nv = ((int)0x86C9)		,
		EvalVertexAtrrib4Nv = ((int)0x86CA)		,
		EvalVertexAttrib4Nv = ((int)0x86CA)		,
		EvalVertexAtrrib5Nv = ((int)0x86CB)		,
		EvalVertexAttrib5Nv = ((int)0x86CB)		,
		EvalVertexAtrrib6Nv = ((int)0x86CC)		,
		EvalVertexAttrib6Nv = ((int)0x86CC)		,
		EvalVertexAtrrib7Nv = ((int)0x86CD)		,
		EvalVertexAttrib7Nv = ((int)0x86CD)		,
		EvalVertexAtrrib8Nv = ((int)0x86CE)		,
		EvalVertexAttrib8Nv = ((int)0x86CE)		,
		EvalVertexAtrrib9Nv = ((int)0x86CF)		,
		EvalVertexAttrib9Nv = ((int)0x86CF)		,
		EvalVertexAtrrib10Nv = ((int)0x86D0)		,
		EvalVertexAttrib10Nv = ((int)0x86D0)		,
		EvalVertexAtrrib11Nv = ((int)0x86D1)		,
		EvalVertexAttrib11Nv = ((int)0x86D1)		,
		EvalVertexAtrrib12Nv = ((int)0x86D2)		,
		EvalVertexAttrib12Nv = ((int)0x86D2)		,
		EvalVertexAtrrib13Nv = ((int)0x86D3)		,
		EvalVertexAttrib13Nv = ((int)0x86D3)		,
		EvalVertexAtrrib14Nv = ((int)0x86D4)		,
		EvalVertexAttrib14Nv = ((int)0x86D4)		,
		EvalVertexAtrrib15Nv = ((int)0x86D5)		,
		EvalVertexAttrib15Nv = ((int)0x86D5)		,
		MaxMapTessellationNv = ((int)0x86D6)		,
		MaxRationalEvalOrderNv = ((int)0x86D7)		,
	}
	public enum NvExplicitMultisample : int {
		SamplePositionNv = ((int)0x8E50)		,
		SampleMaskNv = ((int)0x8E51)		,
		SampleMaskValueNv = ((int)0x8E52)		,
		TextureBindingRenderbufferNv = ((int)0x8E53)		,
		TextureRenderbufferDataStoreBindingNv = ((int)0x8E54)		,
		TextureRenderbufferNv = ((int)0x8E55)		,
		SamplerRenderbufferNv = ((int)0x8E56)		,
		IntSamplerRenderbufferNv = ((int)0x8E57)		,
		UnsignedIntSamplerRenderbufferNv = ((int)0x8E58)		,
		MaxSampleMaskWordsNv = ((int)0x8E59)		,
	}
	public enum NvFence : int {
		AllCompletedNv = ((int)0x84F2)		,
		FenceStatusNv = ((int)0x84F3)		,
		FenceConditionNv = ((int)0x84F4)		,
	}
	public enum NvFloatBuffer : int {
		FloatRNv = ((int)0x8880)		,
		FloatRgNv = ((int)0x8881)		,
		FloatRgbNv = ((int)0x8882)		,
		FloatRgbaNv = ((int)0x8883)		,
		FloatR16Nv = ((int)0x8884)		,
		FloatR32Nv = ((int)0x8885)		,
		FloatRg16Nv = ((int)0x8886)		,
		FloatRg32Nv = ((int)0x8887)		,
		FloatRgb16Nv = ((int)0x8888)		,
		FloatRgb32Nv = ((int)0x8889)		,
		FloatRgba16Nv = ((int)0x888A)		,
		FloatRgba32Nv = ((int)0x888B)		,
		TextureFloatComponentsNv = ((int)0x888C)		,
		FloatClearColorValueNv = ((int)0x888D)		,
		FloatRgbaModeNv = ((int)0x888E)		,
	}
	public enum NvFogDistance : int {
		EyePlane = ((int)0x2502)		,
		FogDistanceModeNv = ((int)0x855A)		,
		FogGenModeNv = ((int)0x855A)		,
		EyeRadialNv = ((int)0x855B)		,
		EyePlaneAbsoluteNv = ((int)0x855C)		,
	}
	public enum NvFragmentProgram : int {
		MaxFragmentProgramLocalParametersNv = ((int)0x8868)		,
		FragmentProgramNv = ((int)0x8870)		,
		MaxTextureCoordsNv = ((int)0x8871)		,
		MaxTextureImageUnitsNv = ((int)0x8872)		,
		FragmentProgramBindingNv = ((int)0x8873)		,
		ProgramErrorStringNv = ((int)0x8874)		,
	}
	public enum NvFragmentProgram2 : int {
		MaxProgramExecInstructionsNv = ((int)0x88F4)		,
		MaxProgramCallDepthNv = ((int)0x88F5)		,
		MaxProgramIfDepthNv = ((int)0x88F6)		,
		MaxProgramLoopDepthNv = ((int)0x88F7)		,
		MaxProgramLoopCountNv = ((int)0x88F8)		,
	}
	public enum NvFragmentProgram4 : int {
	}
	public enum NvFragmentProgramOption : int {
	}
	public enum NvFramebufferMultisampleCoverage : int {
		RenderbufferCoverageSamplesNv = ((int)0x8CAB)		,
		RenderbufferColorSamplesNv = ((int)0x8E10)		,
		MaxMultisampleCoverageModesNv = ((int)0x8E11)		,
		MultisampleCoverageModesNv = ((int)0x8E12)		,
	}
	public enum NvGeometryProgram4 : int {
		LinesAdjacencyExt = ((int)0x000A)		,
		LineStripAdjacencyExt = ((int)0x000B)		,
		TrianglesAdjacencyExt = ((int)0x000C)		,
		TriangleStripAdjacencyExt = ((int)0x000D)		,
		ProgramPointSizeExt = ((int)0x8642)		,
		GeometryProgramNv = ((int)0x8C26)		,
		MaxProgramOutputVerticesNv = ((int)0x8C27)		,
		MaxProgramTotalOutputComponentsNv = ((int)0x8C28)		,
		MaxGeometryTextureImageUnitsExt = ((int)0x8C29)		,
		FramebufferAttachmentTextureLayerExt = ((int)0x8CD4)		,
		FramebufferAttachmentLayeredExt = ((int)0x8DA7)		,
		FramebufferIncompleteLayerTargetsExt = ((int)0x8DA8)		,
		FramebufferIncompleteLayerCountExt = ((int)0x8DA9)		,
		GeometryVerticesOutExt = ((int)0x8DDA)		,
		GeometryInputTypeExt = ((int)0x8DDB)		,
		GeometryOutputTypeExt = ((int)0x8DDC)		,
	}
	public enum NvGeometryShader4 : int {
	}
	public enum NvGpuProgram4 : int {
		MinProgramTexelOffsetNv = ((int)0x8904)		,
		MaxProgramTexelOffsetNv = ((int)0x8905)		,
		ProgramAttribComponentsNv = ((int)0x8906)		,
		ProgramResultComponentsNv = ((int)0x8907)		,
		MaxProgramAttribComponentsNv = ((int)0x8908)		,
		MaxProgramResultComponentsNv = ((int)0x8909)		,
		MaxProgramGenericAttribsNv = ((int)0x8DA5)		,
		MaxProgramGenericResultsNv = ((int)0x8DA6)		,
	}
	public enum NvGpuProgram5 : int {
		MaxGeometryProgramInvocationsNv = ((int)0x8E5A)		,
		MinFragmentInterpolationOffsetNv = ((int)0x8E5B)		,
		MaxFragmentInterpolationOffsetNv = ((int)0x8E5C)		,
		FragmentProgramInterpolationOffsetBitsNv = ((int)0x8E5D)		,
		MinProgramTextureGatherOffsetNv = ((int)0x8E5E)		,
		MaxProgramTextureGatherOffsetNv = ((int)0x8E5F)		,
		MaxProgramSubroutineParametersNv = ((int)0x8F44)		,
		MaxProgramSubroutineNumNv = ((int)0x8F45)		,
	}
	public enum NvGpuShader5 : int {
		Patches = ((int)0x000E)		,
		Int64Nv = ((int)0x140E)		,
		UnsignedInt64Nv = ((int)0x140F)		,
		Int8Nv = ((int)0x8FE0)		,
		Int8Vec2Nv = ((int)0x8FE1)		,
		Int8Vec3Nv = ((int)0x8FE2)		,
		Int8Vec4Nv = ((int)0x8FE3)		,
		Int16Nv = ((int)0x8FE4)		,
		Int16Vec2Nv = ((int)0x8FE5)		,
		Int16Vec3Nv = ((int)0x8FE6)		,
		Int16Vec4Nv = ((int)0x8FE7)		,
		Int64Vec2Nv = ((int)0x8FE9)		,
		Int64Vec3Nv = ((int)0x8FEA)		,
		Int64Vec4Nv = ((int)0x8FEB)		,
		UnsignedInt8Nv = ((int)0x8FEC)		,
		UnsignedInt8Vec2Nv = ((int)0x8FED)		,
		UnsignedInt8Vec3Nv = ((int)0x8FEE)		,
		UnsignedInt8Vec4Nv = ((int)0x8FEF)		,
		UnsignedInt16Nv = ((int)0x8FF0)		,
		UnsignedInt16Vec2Nv = ((int)0x8FF1)		,
		UnsignedInt16Vec3Nv = ((int)0x8FF2)		,
		UnsignedInt16Vec4Nv = ((int)0x8FF3)		,
		UnsignedInt64Vec2Nv = ((int)0x8FF5)		,
		UnsignedInt64Vec3Nv = ((int)0x8FF6)		,
		UnsignedInt64Vec4Nv = ((int)0x8FF7)		,
		Float16Nv = ((int)0x8FF8)		,
		Float16Vec2Nv = ((int)0x8FF9)		,
		Float16Vec3Nv = ((int)0x8FFA)		,
		Float16Vec4Nv = ((int)0x8FFB)		,
	}
	public enum NvHalfFloat : int {
		HalfFloatNv = ((int)0x140B)		,
	}
	public enum NvLightMaxExponent : int {
		MaxShininessNv = ((int)0x8504)		,
		MaxSpotExponentNv = ((int)0x8505)		,
	}
	public enum NvMultisampleCoverage : int {
		CoverageSamplesNv = ((int)0x80A9)		,
		ColorSamplesNv = ((int)0x8E20)		,
	}
	public enum NvMultisampleFilterHint : int {
		MultisampleFilterHintNv = ((int)0x8534)		,
	}
	public enum NvOcclusionQuery : int {
		PixelCounterBitsNv = ((int)0x8864)		,
		CurrentOcclusionQueryIdNv = ((int)0x8865)		,
		PixelCountNv = ((int)0x8866)		,
		PixelCountAvailableNv = ((int)0x8867)		,
	}
	public enum NvPackedDepthStencil : int {
		DepthStencilNv = ((int)0x84F9)		,
		UnsignedInt248Nv = ((int)0x84FA)		,
	}
	public enum NvParameterBufferObject : int {
		MaxProgramParameterBufferBindingsNv = ((int)0x8DA0)		,
		MaxProgramParameterBufferSizeNv = ((int)0x8DA1)		,
		VertexProgramParameterBufferNv = ((int)0x8DA2)		,
		GeometryProgramParameterBufferNv = ((int)0x8DA3)		,
		FragmentProgramParameterBufferNv = ((int)0x8DA4)		,
	}
	public enum NvParameterBufferObject2 : int {
	}
	public enum NvPixelDataRange : int {
		WritePixelDataRangeNv = ((int)0x8878)		,
		ReadPixelDataRangeNv = ((int)0x8879)		,
		WritePixelDataRangeLengthNv = ((int)0x887A)		,
		ReadPixelDataRangeLengthNv = ((int)0x887B)		,
		WritePixelDataRangePointerNv = ((int)0x887C)		,
		ReadPixelDataRangePointerNv = ((int)0x887D)		,
	}
	public enum NvPointSprite : int {
		PointSpriteNv = ((int)0x8861)		,
		CoordReplaceNv = ((int)0x8862)		,
		PointSpriteRModeNv = ((int)0x8863)		,
	}
	public enum NvPresentVideo : int {
		FrameNv = ((int)0x8E26)		,
		FieldsNv = ((int)0x8E27)		,
		CurrentTimeNv = ((int)0x8E28)		,
		NumFillStreamsNv = ((int)0x8E29)		,
		PresentTimeNv = ((int)0x8E2A)		,
		PresentDurationNv = ((int)0x8E2B)		,
	}
	public enum NvPrimitiveRestart : int {
		PrimitiveRestartNv = ((int)0x8558)		,
		PrimitiveRestartIndexNv = ((int)0x8559)		,
	}
	public enum NvRegisterCombiners : int {
		None = ((int)0)		,
		Zero = ((int)0)		,
		Fog = ((int)0x0B60)		,
		Texture0Arb = ((int)0x84C0)		,
		Texture1Arb = ((int)0x84C1)		,
		RegisterCombinersNv = ((int)0x8522)		,
		VariableANv = ((int)0x8523)		,
		VariableBNv = ((int)0x8524)		,
		VariableCNv = ((int)0x8525)		,
		VariableDNv = ((int)0x8526)		,
		VariableENv = ((int)0x8527)		,
		VariableFNv = ((int)0x8528)		,
		VariableGNv = ((int)0x8529)		,
		ConstantColor0Nv = ((int)0x852A)		,
		ConstantColor1Nv = ((int)0x852B)		,
		PrimaryColorNv = ((int)0x852C)		,
		SecondaryColorNv = ((int)0x852D)		,
		Spare0Nv = ((int)0x852E)		,
		Spare1Nv = ((int)0x852F)		,
		DiscardNv = ((int)0x8530)		,
		ETimesFNv = ((int)0x8531)		,
		Spare0PlusSecondaryColorNv = ((int)0x8532)		,
		VertexArrayRangeWithoutFlushNv = ((int)0x8533)		,
		MultisampleFilterHintNv = ((int)0x8534)		,
		UnsignedIdentityNv = ((int)0x8536)		,
		UnsignedInvertNv = ((int)0x8537)		,
		ExpandNormalNv = ((int)0x8538)		,
		ExpandNegateNv = ((int)0x8539)		,
		HalfBiasNormalNv = ((int)0x853A)		,
		HalfBiasNegateNv = ((int)0x853B)		,
		SignedIdentityNv = ((int)0x853C)		,
		SignedNegateNv = ((int)0x853D)		,
		UnsignedNegateNv = ((int)0x853D)		,
		ScaleByTwoNv = ((int)0x853E)		,
		ScaleByFourNv = ((int)0x853F)		,
		ScaleByOneHalfNv = ((int)0x8540)		,
		BiasByNegativeOneHalfNv = ((int)0x8541)		,
		CombinerInputNv = ((int)0x8542)		,
		CombinerMappingNv = ((int)0x8543)		,
		CombinerComponentUsageNv = ((int)0x8544)		,
		CombinerAbDotProductNv = ((int)0x8545)		,
		CombinerCdDotProductNv = ((int)0x8546)		,
		CombinerMuxSumNv = ((int)0x8547)		,
		CombinerScaleNv = ((int)0x8548)		,
		CombinerBiasNv = ((int)0x8549)		,
		CombinerAbOutputNv = ((int)0x854A)		,
		CombinerCdOutputNv = ((int)0x854B)		,
		CombinerSumOutputNv = ((int)0x854C)		,
		MaxGeneralCombinersNv = ((int)0x854D)		,
		NumGeneralCombinersNv = ((int)0x854E)		,
		ColorSumClampNv = ((int)0x854F)		,
		Combiner0Nv = ((int)0x8550)		,
		Combiner1Nv = ((int)0x8551)		,
		Combiner2Nv = ((int)0x8552)		,
		Combiner3Nv = ((int)0x8553)		,
		Combiner4Nv = ((int)0x8554)		,
		Combiner5Nv = ((int)0x8555)		,
		Combiner6Nv = ((int)0x8556)		,
		Combiner7Nv = ((int)0x8557)		,
	}
	public enum NvRegisterCombiners2 : int {
		PerStageConstantsNv = ((int)0x8535)		,
	}
	public enum NvShaderBufferLoad : int {
		BufferGpuAddressNv = ((int)0x8F1D)		,
		GpuAddressNv = ((int)0x8F34)		,
		MaxShaderBufferAddressNv = ((int)0x8F35)		,
	}
	public enum NvShaderBufferStore : int {
		ShaderGlobalAccessBarrierBitNv = ((int)0x00000010)		,
		WriteOnly = ((int)0x88B9)		,
		ReadWrite = ((int)0x88BA)		,
	}
	public enum NvTessellationProgram5 : int {
		MaxProgramPatchAttribsNv = ((int)0x86D8)		,
		TessControlProgramNv = ((int)0x891E)		,
		TessEvaluationProgramNv = ((int)0x891F)		,
		TessControlProgramParameterBufferNv = ((int)0x8C74)		,
		TessEvaluationProgramParameterBufferNv = ((int)0x8C75)		,
	}
	public enum NvTexgenEmboss : int {
		EmbossLightNv = ((int)0x855D)		,
		EmbossConstantNv = ((int)0x855E)		,
		EmbossMapNv = ((int)0x855F)		,
	}
	public enum NvTexgenReflection : int {
		NormalMap = ((int)0x8511)		,
		NormalMapNv = ((int)0x8511)		,
		ReflectionMap = ((int)0x8512)		,
		ReflectionMapNv = ((int)0x8512)		,
	}
	public enum NvTextureBarrier : int {
	}
	public enum NvTextureCompressionVtc : int {
	}
	public enum NvTextureEnvCombine4 : int {
		Combine4Nv = ((int)0x8503)		,
		Source3RgbNv = ((int)0x8583)		,
		Source3AlphaNv = ((int)0x858B)		,
		Operand3RgbNv = ((int)0x8593)		,
		Operand3AlphaNv = ((int)0x859B)		,
	}
	public enum NvTextureExpandNormal : int {
		TextureUnsignedRemapModeNv = ((int)0x888F)		,
	}
	public enum NvTextureMultisample : int {
		TextureCoverageSamplesNv = ((int)0x9045)		,
		TextureColorSamplesNv = ((int)0x9046)		,
	}
	public enum NvTextureRectangle : int {
		TextureRectangleNv = ((int)0x84F5)		,
		TextureBindingRectangleNv = ((int)0x84F6)		,
		ProxyTextureRectangleNv = ((int)0x84F7)		,
		MaxRectangleTextureSizeNv = ((int)0x84F8)		,
	}
	public enum NvTextureShader : int {
		OffsetTextureRectangleNv = ((int)0x864C)		,
		OffsetTextureRectangleScaleNv = ((int)0x864D)		,
		DotProductTextureRectangleNv = ((int)0x864E)		,
		RgbaUnsignedDotProductMappingNv = ((int)0x86D9)		,
		UnsignedIntS8S888Nv = ((int)0x86DA)		,
		UnsignedInt88S8S8RevNv = ((int)0x86DB)		,
		DsdtMagIntensityNv = ((int)0x86DC)		,
		ShaderConsistentNv = ((int)0x86DD)		,
		TextureShaderNv = ((int)0x86DE)		,
		ShaderOperationNv = ((int)0x86DF)		,
		CullModesNv = ((int)0x86E0)		,
		OffsetTexture2DMatrixNv = ((int)0x86E1)		,
		OffsetTextureMatrixNv = ((int)0x86E1)		,
		OffsetTexture2DScaleNv = ((int)0x86E2)		,
		OffsetTextureScaleNv = ((int)0x86E2)		,
		OffsetTexture2DBiasNv = ((int)0x86E3)		,
		OffsetTextureBiasNv = ((int)0x86E3)		,
		PreviousTextureInputNv = ((int)0x86E4)		,
		ConstEyeNv = ((int)0x86E5)		,
		PassThroughNv = ((int)0x86E6)		,
		CullFragmentNv = ((int)0x86E7)		,
		OffsetTexture2DNv = ((int)0x86E8)		,
		DependentArTexture2DNv = ((int)0x86E9)		,
		DependentGbTexture2DNv = ((int)0x86EA)		,
		DotProductNv = ((int)0x86EC)		,
		DotProductDepthReplaceNv = ((int)0x86ED)		,
		DotProductTexture2DNv = ((int)0x86EE)		,
		DotProductTextureCubeMapNv = ((int)0x86F0)		,
		DotProductDiffuseCubeMapNv = ((int)0x86F1)		,
		DotProductReflectCubeMapNv = ((int)0x86F2)		,
		DotProductConstEyeReflectCubeMapNv = ((int)0x86F3)		,
		HiloNv = ((int)0x86F4)		,
		DsdtNv = ((int)0x86F5)		,
		DsdtMagNv = ((int)0x86F6)		,
		DsdtMagVibNv = ((int)0x86F7)		,
		Hilo16Nv = ((int)0x86F8)		,
		SignedHiloNv = ((int)0x86F9)		,
		SignedHilo16Nv = ((int)0x86FA)		,
		SignedRgbaNv = ((int)0x86FB)		,
		SignedRgba8Nv = ((int)0x86FC)		,
		SignedRgbNv = ((int)0x86FE)		,
		SignedRgb8Nv = ((int)0x86FF)		,
		SignedLuminanceNv = ((int)0x8701)		,
		SignedLuminance8Nv = ((int)0x8702)		,
		SignedLuminanceAlphaNv = ((int)0x8703)		,
		SignedLuminance8Alpha8Nv = ((int)0x8704)		,
		SignedAlphaNv = ((int)0x8705)		,
		SignedAlpha8Nv = ((int)0x8706)		,
		SignedIntensityNv = ((int)0x8707)		,
		SignedIntensity8Nv = ((int)0x8708)		,
		Dsdt8Nv = ((int)0x8709)		,
		Dsdt8Mag8Nv = ((int)0x870A)		,
		Dsdt8Mag8Intensity8Nv = ((int)0x870B)		,
		SignedRgbUnsignedAlphaNv = ((int)0x870C)		,
		SignedRgb8UnsignedAlpha8Nv = ((int)0x870D)		,
		HiScaleNv = ((int)0x870E)		,
		LoScaleNv = ((int)0x870F)		,
		DsScaleNv = ((int)0x8710)		,
		DtScaleNv = ((int)0x8711)		,
		MagnitudeScaleNv = ((int)0x8712)		,
		VibranceScaleNv = ((int)0x8713)		,
		HiBiasNv = ((int)0x8714)		,
		LoBiasNv = ((int)0x8715)		,
		DsBiasNv = ((int)0x8716)		,
		DtBiasNv = ((int)0x8717)		,
		MagnitudeBiasNv = ((int)0x8718)		,
		VibranceBiasNv = ((int)0x8719)		,
		TextureBorderValuesNv = ((int)0x871A)		,
		TextureHiSizeNv = ((int)0x871B)		,
		TextureLoSizeNv = ((int)0x871C)		,
		TextureDsSizeNv = ((int)0x871D)		,
		TextureDtSizeNv = ((int)0x871E)		,
		TextureMagSizeNv = ((int)0x871F)		,
	}
	public enum NvTextureShader2 : int {
		DotProductTexture3DNv = ((int)0x86EF)		,
	}
	public enum NvTextureShader3 : int {
		OffsetProjectiveTexture2DNv = ((int)0x8850)		,
		OffsetProjectiveTexture2DScaleNv = ((int)0x8851)		,
		OffsetProjectiveTextureRectangleNv = ((int)0x8852)		,
		OffsetProjectiveTextureRectangleScaleNv = ((int)0x8853)		,
		OffsetHiloTexture2DNv = ((int)0x8854)		,
		OffsetHiloTextureRectangleNv = ((int)0x8855)		,
		OffsetHiloProjectiveTexture2DNv = ((int)0x8856)		,
		OffsetHiloProjectiveTextureRectangleNv = ((int)0x8857)		,
		DependentHiloTexture2DNv = ((int)0x8858)		,
		DependentRgbTexture3DNv = ((int)0x8859)		,
		DependentRgbTextureCubeMapNv = ((int)0x885A)		,
		DotProductPassThroughNv = ((int)0x885B)		,
		DotProductTexture1DNv = ((int)0x885C)		,
		DotProductAffineDepthReplaceNv = ((int)0x885D)		,
		Hilo8Nv = ((int)0x885E)		,
		SignedHilo8Nv = ((int)0x885F)		,
		ForceBlueToOneNv = ((int)0x8860)		,
	}
	public enum NvTransformFeedback : int {
		TransformFeedbackVaryingMaxLength = ((int)0x8C76)		,
		TransformFeedbackVaryingMaxLengthExt = ((int)0x8C76)		,
		BackPrimaryColorNv = ((int)0x8C77)		,
		BackSecondaryColorNv = ((int)0x8C78)		,
		TextureCoordNv = ((int)0x8C79)		,
		ClipDistanceNv = ((int)0x8C7A)		,
		VertexIdNv = ((int)0x8C7B)		,
		PrimitiveIdNv = ((int)0x8C7C)		,
		GenericAttribNv = ((int)0x8C7D)		,
		TransformFeedbackAttribsNv = ((int)0x8C7E)		,
		TransformFeedbackBufferMode = ((int)0x8C7F)		,
		TransformFeedbackBufferModeExt = ((int)0x8C7F)		,
		TransformFeedbackBufferModeNv = ((int)0x8C7F)		,
		MaxTransformFeedbackSeparateComponents = ((int)0x8C80)		,
		MaxTransformFeedbackSeparateComponentsExt = ((int)0x8C80)		,
		MaxTransformFeedbackSeparateComponentsNv = ((int)0x8C80)		,
		ActiveVaryingsNv = ((int)0x8C81)		,
		ActiveVaryingMaxLengthNv = ((int)0x8C82)		,
		TransformFeedbackVaryings = ((int)0x8C83)		,
		TransformFeedbackVaryingsExt = ((int)0x8C83)		,
		TransformFeedbackVaryingsNv = ((int)0x8C83)		,
		TransformFeedbackBufferStart = ((int)0x8C84)		,
		TransformFeedbackBufferStartExt = ((int)0x8C84)		,
		TransformFeedbackBufferStartNv = ((int)0x8C84)		,
		TransformFeedbackBufferSize = ((int)0x8C85)		,
		TransformFeedbackBufferSizeExt = ((int)0x8C85)		,
		TransformFeedbackBufferSizeNv = ((int)0x8C85)		,
		TransformFeedbackRecordNv = ((int)0x8C86)		,
		PrimitivesGenerated = ((int)0x8C87)		,
		PrimitivesGeneratedExt = ((int)0x8C87)		,
		PrimitivesGeneratedNv = ((int)0x8C87)		,
		TransformFeedbackPrimitivesWritten = ((int)0x8C88)		,
		TransformFeedbackPrimitivesWrittenExt = ((int)0x8C88)		,
		TransformFeedbackPrimitivesWrittenNv = ((int)0x8C88)		,
		RasterizerDiscard = ((int)0x8C89)		,
		RasterizerDiscardExt = ((int)0x8C89)		,
		RasterizerDiscardNv = ((int)0x8C89)		,
		MaxTransformFeedbackInterleavedAttribsNv = ((int)0x8C8A)		,
		MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)		,
		MaxTransformFeedbackInterleavedComponentsExt = ((int)0x8C8A)		,
		MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)		,
		MaxTransformFeedbackSeparateAttribsExt = ((int)0x8C8B)		,
		MaxTransformFeedbackSeparateAttribsNv = ((int)0x8C8B)		,
		InterleavedAttribs = ((int)0x8C8C)		,
		InterleavedAttribsExt = ((int)0x8C8C)		,
		InterleavedAttribsNv = ((int)0x8C8C)		,
		SeparateAttribs = ((int)0x8C8D)		,
		SeparateAttribsExt = ((int)0x8C8D)		,
		SeparateAttribsNv = ((int)0x8C8D)		,
		TransformFeedbackBuffer = ((int)0x8C8E)		,
		TransformFeedbackBufferExt = ((int)0x8C8E)		,
		TransformFeedbackBufferNv = ((int)0x8C8E)		,
		TransformFeedbackBufferBinding = ((int)0x8C8F)		,
		TransformFeedbackBufferBindingExt = ((int)0x8C8F)		,
		TransformFeedbackBufferBindingNv = ((int)0x8C8F)		,
		LayerNv = ((int)0x8DAA)		,
		NextBufferNv = ((int)2)		,
		SkipComponents4Nv = ((int)3)		,
		SkipComponents3Nv = ((int)4)		,
		SkipComponents2Nv = ((int)5)		,
		SkipComponents1Nv = ((int)6)		,
	}
	public enum NvTransformFeedback2 : int {
		TransformFeedbackNv = ((int)0x8E22)		,
		TransformFeedbackBufferPausedNv = ((int)0x8E23)		,
		TransformFeedbackBufferActiveNv = ((int)0x8E24)		,
		TransformFeedbackBindingNv = ((int)0x8E25)		,
	}
	public enum NvVdpauInterop : int {
		SurfaceStateNv = ((int)0x86EB)		,
		SurfaceRegisteredNv = ((int)0x86FD)		,
		SurfaceMappedNv = ((int)0x8700)		,
		WriteDiscardNv = ((int)0x88BE)		,
	}
	public enum NvVertexArrayRange : int {
		VertexArrayRangeNv = ((int)0x851D)		,
		VertexArrayRangeLengthNv = ((int)0x851E)		,
		VertexArrayRangeValidNv = ((int)0x851F)		,
		MaxVertexArrayRangeElementNv = ((int)0x8520)		,
		VertexArrayRangePointerNv = ((int)0x8521)		,
	}
	public enum NvVertexArrayRange2 : int {
		VertexArrayRangeWithoutFlushNv = ((int)0x8533)		,
	}
	public enum NvVertexAttribInteger64bit : int {
		Int64Nv = ((int)0x140E)		,
		UnsignedInt64Nv = ((int)0x140F)		,
	}
	public enum NvVertexBufferUnifiedMemory : int {
		VertexAttribArrayUnifiedNv = ((int)0x8F1E)		,
		ElementArrayUnifiedNv = ((int)0x8F1F)		,
		VertexAttribArrayAddressNv = ((int)0x8F20)		,
		VertexArrayAddressNv = ((int)0x8F21)		,
		NormalArrayAddressNv = ((int)0x8F22)		,
		ColorArrayAddressNv = ((int)0x8F23)		,
		IndexArrayAddressNv = ((int)0x8F24)		,
		TextureCoordArrayAddressNv = ((int)0x8F25)		,
		EdgeFlagArrayAddressNv = ((int)0x8F26)		,
		SecondaryColorArrayAddressNv = ((int)0x8F27)		,
		FogCoordArrayAddressNv = ((int)0x8F28)		,
		ElementArrayAddressNv = ((int)0x8F29)		,
		VertexAttribArrayLengthNv = ((int)0x8F2A)		,
		VertexArrayLengthNv = ((int)0x8F2B)		,
		NormalArrayLengthNv = ((int)0x8F2C)		,
		ColorArrayLengthNv = ((int)0x8F2D)		,
		IndexArrayLengthNv = ((int)0x8F2E)		,
		TextureCoordArrayLengthNv = ((int)0x8F2F)		,
		EdgeFlagArrayLengthNv = ((int)0x8F30)		,
		SecondaryColorArrayLengthNv = ((int)0x8F31)		,
		FogCoordArrayLengthNv = ((int)0x8F32)		,
		ElementArrayLengthNv = ((int)0x8F33)		,
		DrawIndirectUnifiedNv = ((int)0x8F40)		,
		DrawIndirectAddressNv = ((int)0x8F41)		,
		DrawIndirectLengthNv = ((int)0x8F42)		,
	}
	public enum NvVertexProgram : int {
		VertexProgramNv = ((int)0x8620)		,
		VertexStateProgramNv = ((int)0x8621)		,
		AttribArraySizeNv = ((int)0x8623)		,
		AttribArrayStrideNv = ((int)0x8624)		,
		AttribArrayTypeNv = ((int)0x8625)		,
		CurrentAttribNv = ((int)0x8626)		,
		ProgramLengthNv = ((int)0x8627)		,
		ProgramStringNv = ((int)0x8628)		,
		ModelviewProjectionNv = ((int)0x8629)		,
		IdentityNv = ((int)0x862A)		,
		InverseNv = ((int)0x862B)		,
		TransposeNv = ((int)0x862C)		,
		InverseTransposeNv = ((int)0x862D)		,
		MaxTrackMatrixStackDepthNv = ((int)0x862E)		,
		MaxTrackMatricesNv = ((int)0x862F)		,
		Matrix0Nv = ((int)0x8630)		,
		Matrix1Nv = ((int)0x8631)		,
		Matrix2Nv = ((int)0x8632)		,
		Matrix3Nv = ((int)0x8633)		,
		Matrix4Nv = ((int)0x8634)		,
		Matrix5Nv = ((int)0x8635)		,
		Matrix6Nv = ((int)0x8636)		,
		Matrix7Nv = ((int)0x8637)		,
		CurrentMatrixStackDepthNv = ((int)0x8640)		,
		CurrentMatrixNv = ((int)0x8641)		,
		VertexProgramPointSizeNv = ((int)0x8642)		,
		VertexProgramTwoSideNv = ((int)0x8643)		,
		ProgramParameterNv = ((int)0x8644)		,
		AttribArrayPointerNv = ((int)0x8645)		,
		ProgramTargetNv = ((int)0x8646)		,
		ProgramResidentNv = ((int)0x8647)		,
		TrackMatrixNv = ((int)0x8648)		,
		TrackMatrixTransformNv = ((int)0x8649)		,
		VertexProgramBindingNv = ((int)0x864A)		,
		ProgramErrorPositionNv = ((int)0x864B)		,
		VertexAttribArray0Nv = ((int)0x8650)		,
		VertexAttribArray1Nv = ((int)0x8651)		,
		VertexAttribArray2Nv = ((int)0x8652)		,
		VertexAttribArray3Nv = ((int)0x8653)		,
		VertexAttribArray4Nv = ((int)0x8654)		,
		VertexAttribArray5Nv = ((int)0x8655)		,
		VertexAttribArray6Nv = ((int)0x8656)		,
		VertexAttribArray7Nv = ((int)0x8657)		,
		VertexAttribArray8Nv = ((int)0x8658)		,
		VertexAttribArray9Nv = ((int)0x8659)		,
		VertexAttribArray10Nv = ((int)0x865A)		,
		VertexAttribArray11Nv = ((int)0x865B)		,
		VertexAttribArray12Nv = ((int)0x865C)		,
		VertexAttribArray13Nv = ((int)0x865D)		,
		VertexAttribArray14Nv = ((int)0x865E)		,
		VertexAttribArray15Nv = ((int)0x865F)		,
		Map1VertexAttrib04Nv = ((int)0x8660)		,
		Map1VertexAttrib14Nv = ((int)0x8661)		,
		Map1VertexAttrib24Nv = ((int)0x8662)		,
		Map1VertexAttrib34Nv = ((int)0x8663)		,
		Map1VertexAttrib44Nv = ((int)0x8664)		,
		Map1VertexAttrib54Nv = ((int)0x8665)		,
		Map1VertexAttrib64Nv = ((int)0x8666)		,
		Map1VertexAttrib74Nv = ((int)0x8667)		,
		Map1VertexAttrib84Nv = ((int)0x8668)		,
		Map1VertexAttrib94Nv = ((int)0x8669)		,
		Map1VertexAttrib104Nv = ((int)0x866A)		,
		Map1VertexAttrib114Nv = ((int)0x866B)		,
		Map1VertexAttrib124Nv = ((int)0x866C)		,
		Map1VertexAttrib134Nv = ((int)0x866D)		,
		Map1VertexAttrib144Nv = ((int)0x866E)		,
		Map1VertexAttrib154Nv = ((int)0x866F)		,
		Map2VertexAttrib04Nv = ((int)0x8670)		,
		Map2VertexAttrib14Nv = ((int)0x8671)		,
		Map2VertexAttrib24Nv = ((int)0x8672)		,
		Map2VertexAttrib34Nv = ((int)0x8673)		,
		Map2VertexAttrib44Nv = ((int)0x8674)		,
		Map2VertexAttrib54Nv = ((int)0x8675)		,
		Map2VertexAttrib64Nv = ((int)0x8676)		,
		Map2VertexAttrib74Nv = ((int)0x8677)		,
		Map2VertexAttrib84Nv = ((int)0x8678)		,
		Map2VertexAttrib94Nv = ((int)0x8679)		,
		Map2VertexAttrib104Nv = ((int)0x867A)		,
		Map2VertexAttrib114Nv = ((int)0x867B)		,
		Map2VertexAttrib124Nv = ((int)0x867C)		,
		Map2VertexAttrib134Nv = ((int)0x867D)		,
		Map2VertexAttrib144Nv = ((int)0x867E)		,
		Map2VertexAttrib154Nv = ((int)0x867F)		,
	}
	public enum NvVertexProgram11 : int {
	}
	public enum NvVertexProgram2 : int {
	}
	public enum NvVertexProgram2Option : int {
		MaxProgramExecInstructionsNv = ((int)0x88F4)		,
		MaxProgramCallDepthNv = ((int)0x88F5)		,
	}
	public enum NvVertexProgram3 : int {
		FragmentShader = ((int)0x8B30)		,
		FragmentShaderArb = ((int)0x8B30)		,
		VertexShader = ((int)0x8B31)		,
		VertexShaderArb = ((int)0x8B31)		,
		ProgramObjectArb = ((int)0x8B40)		,
		ShaderObjectArb = ((int)0x8B48)		,
		MaxFragmentUniformComponents = ((int)0x8B49)		,
		MaxFragmentUniformComponentsArb = ((int)0x8B49)		,
		MaxVertexUniformComponents = ((int)0x8B4A)		,
		MaxVertexUniformComponentsArb = ((int)0x8B4A)		,
		MaxVaryingFloats = ((int)0x8B4B)		,
		MaxVaryingFloatsArb = ((int)0x8B4B)		,
		MaxVertexTextureImageUnits = ((int)0x8B4C)		,
		MaxVertexTextureImageUnitsArb = ((int)0x8B4C)		,
		MaxCombinedTextureImageUnits = ((int)0x8B4D)		,
		MaxCombinedTextureImageUnitsArb = ((int)0x8B4D)		,
		ObjectTypeArb = ((int)0x8B4E)		,
		ObjectSubtypeArb = ((int)0x8B4F)		,
		ShaderType = ((int)0x8B4F)		,
		FloatVec2 = ((int)0x8B50)		,
		FloatVec2Arb = ((int)0x8B50)		,
		FloatVec3 = ((int)0x8B51)		,
		FloatVec3Arb = ((int)0x8B51)		,
		FloatVec4 = ((int)0x8B52)		,
		FloatVec4Arb = ((int)0x8B52)		,
		IntVec2 = ((int)0x8B53)		,
		IntVec2Arb = ((int)0x8B53)		,
		IntVec3 = ((int)0x8B54)		,
		IntVec3Arb = ((int)0x8B54)		,
		IntVec4 = ((int)0x8B55)		,
		IntVec4Arb = ((int)0x8B55)		,
		Bool = ((int)0x8B56)		,
		BoolArb = ((int)0x8B56)		,
		BoolVec2 = ((int)0x8B57)		,
		BoolVec2Arb = ((int)0x8B57)		,
		BoolVec3 = ((int)0x8B58)		,
		BoolVec3Arb = ((int)0x8B58)		,
		BoolVec4 = ((int)0x8B59)		,
		BoolVec4Arb = ((int)0x8B59)		,
		FloatMat2 = ((int)0x8B5A)		,
		FloatMat2Arb = ((int)0x8B5A)		,
		FloatMat3 = ((int)0x8B5B)		,
		FloatMat3Arb = ((int)0x8B5B)		,
		FloatMat4 = ((int)0x8B5C)		,
		FloatMat4Arb = ((int)0x8B5C)		,
		Sampler1D = ((int)0x8B5D)		,
		Sampler1DArb = ((int)0x8B5D)		,
		Sampler2D = ((int)0x8B5E)		,
		Sampler2DArb = ((int)0x8B5E)		,
		Sampler3D = ((int)0x8B5F)		,
		Sampler3DArb = ((int)0x8B5F)		,
		SamplerCube = ((int)0x8B60)		,
		SamplerCubeArb = ((int)0x8B60)		,
		Sampler1DShadow = ((int)0x8B61)		,
		Sampler1DShadowArb = ((int)0x8B61)		,
		Sampler2DShadow = ((int)0x8B62)		,
		Sampler2DShadowArb = ((int)0x8B62)		,
		Sampler2DRectArb = ((int)0x8B63)		,
		Sampler2DRectShadowArb = ((int)0x8B64)		,
		FloatMat2x3 = ((int)0x8B65)		,
		FloatMat2x4 = ((int)0x8B66)		,
		FloatMat3x2 = ((int)0x8B67)		,
		FloatMat3x4 = ((int)0x8B68)		,
		FloatMat4x2 = ((int)0x8B69)		,
		FloatMat4x3 = ((int)0x8B6A)		,
		DeleteStatus = ((int)0x8B80)		,
		ObjectDeleteStatusArb = ((int)0x8B80)		,
		CompileStatus = ((int)0x8B81)		,
		ObjectCompileStatusArb = ((int)0x8B81)		,
		LinkStatus = ((int)0x8B82)		,
		ObjectLinkStatusArb = ((int)0x8B82)		,
		ObjectValidateStatusArb = ((int)0x8B83)		,
		ValidateStatus = ((int)0x8B83)		,
		InfoLogLength = ((int)0x8B84)		,
		ObjectInfoLogLengthArb = ((int)0x8B84)		,
		AttachedShaders = ((int)0x8B85)		,
		ObjectAttachedObjectsArb = ((int)0x8B85)		,
		ActiveUniforms = ((int)0x8B86)		,
		ObjectActiveUniformsArb = ((int)0x8B86)		,
		ActiveUniformMaxLength = ((int)0x8B87)		,
		ObjectActiveUniformMaxLengthArb = ((int)0x8B87)		,
		ObjectShaderSourceLengthArb = ((int)0x8B88)		,
		ShaderSourceLength = ((int)0x8B88)		,
		ActiveAttributes = ((int)0x8B89)		,
		ObjectActiveAttributesArb = ((int)0x8B89)		,
		ActiveAttributeMaxLength = ((int)0x8B8A)		,
		ObjectActiveAttributeMaxLengthArb = ((int)0x8B8A)		,
		FragmentShaderDerivativeHint = ((int)0x8B8B)		,
		FragmentShaderDerivativeHintArb = ((int)0x8B8B)		,
		ShadingLanguageVersion = ((int)0x8B8C)		,
		ShadingLanguageVersionArb = ((int)0x8B8C)		,
	}
	public enum NvVertexProgram4 : int {
		VertexAttribArrayIntegerNv = ((int)0x88FD)		,
	}
	public enum NvVideoCapture : int {
		VideoBufferNv = ((int)0x9020)		,
		VideoBufferBindingNv = ((int)0x9021)		,
		FieldUpperNv = ((int)0x9022)		,
		FieldLowerNv = ((int)0x9023)		,
		NumVideoCaptureStreamsNv = ((int)0x9024)		,
		NextVideoCaptureBufferStatusNv = ((int)0x9025)		,
		VideoCaptureTo422SupportedNv = ((int)0x9026)		,
		LastVideoCaptureStatusNv = ((int)0x9027)		,
		VideoBufferPitchNv = ((int)0x9028)		,
		VideoColorConversionMatrixNv = ((int)0x9029)		,
		VideoColorConversionMaxNv = ((int)0x902A)		,
		VideoColorConversionMinNv = ((int)0x902B)		,
		VideoColorConversionOffsetNv = ((int)0x902C)		,
		VideoBufferInternalFormatNv = ((int)0x902D)		,
		PartialSuccessNv = ((int)0x902E)		,
		SuccessNv = ((int)0x902F)		,
		FailureNv = ((int)0x9030)		,
		Ycbycr8422Nv = ((int)0x9031)		,
		Ycbaycr8A4224Nv = ((int)0x9032)		,
		Z6y10z6cb10z6y10z6cr10422Nv = ((int)0x9033)		,
		Z6y10z6cb10z6A10z6y10z6cr10z6A104224Nv = ((int)0x9034)		,
		Z4y12z4cb12z4y12z4cr12422Nv = ((int)0x9035)		,
		Z4y12z4cb12z4A12z4y12z4cr12z4A124224Nv = ((int)0x9036)		,
		Z4y12z4cb12z4cr12444Nv = ((int)0x9037)		,
		VideoCaptureFrameWidthNv = ((int)0x9038)		,
		VideoCaptureFrameHeightNv = ((int)0x9039)		,
		VideoCaptureFieldUpperHeightNv = ((int)0x903A)		,
		VideoCaptureFieldLowerHeightNv = ((int)0x903B)		,
		VideoCaptureSurfaceOriginNv = ((int)0x903C)		,
	}*/
	/*public enum OesBlendEquationSeparate : int {
		BlendEquationRgbOes = ((int)0x8009)		,
		BlendEquationAlphaOes = ((int)0x883D)		,
	}
	public enum OesBlendFuncSeparate : int {
		BlendDstRgbOes = ((int)0x80C8)		,
		BlendSrcRgbOes = ((int)0x80C9)		,
		BlendDstAlphaOes = ((int)0x80CA)		,
		BlendSrcAlphaOes = ((int)0x80CB)		,
	}
	public enum OesBlendSubtract : int {
		FuncAddOes = ((int)0x8006)		,
		BlendEquationOes = ((int)0x8009)		,
		FuncSubtractOes = ((int)0x800A)		,
		FuncReverseSubtractOes = ((int)0x800B)		,
	}
	public enum OesCompressedEtc1Rgb8Texture : int {
		Etc1Rgb8Oes = ((int)0x8D64)		,
	}
	public enum OesCompressedPalettedTexture : int {
		Palette4Rgb8Oes = ((int)0x8B90)		,
		Palette4Rgba8Oes = ((int)0x8B91)		,
		Palette4R5G6B5Oes = ((int)0x8B92)		,
		Palette4Rgba4Oes = ((int)0x8B93)		,
		Palette4Rgb5A1Oes = ((int)0x8B94)		,
		Palette8Rgb8Oes = ((int)0x8B95)		,
		Palette8Rgba8Oes = ((int)0x8B96)		,
		Palette8R5G6B5Oes = ((int)0x8B97)		,
		Palette8Rgba4Oes = ((int)0x8B98)		,
		Palette8Rgb5A1Oes = ((int)0x8B99)		,
	}
	public enum OesDepth24 : int {
		DepthComponent24Oes = ((int)0x81A6)		,
	}
	public enum OesDepth32 : int {
		DepthComponent32Oes = ((int)0x81A7)		,
	}
	public enum OesDepthTexture : int {
	}
	public enum OesDrawTexture : int {
		TextureCropRectOes = ((int)0x8B9D)		,
	}
	public enum OesEglImageExternal : int {
		TextureExternalOes = ((int)0x8D65)		,
		SamplerExternalOes = ((int)0x8D66)		,
		TextureBindingExternalOes = ((int)0x8D67)		,
		RequiredTextureImageUnitsOes = ((int)0x8D68)		,
	}
	public enum OesElementIndexUint : int {
	}
	public enum OesFixedPoint : int {
		FixedOes = ((int)0x140C)		,
	}
	public enum OesFramebufferObject : int {
		InvalidFramebufferOperationOes = ((int)0x0506)		,
		Rgba4Oes = ((int)0x8056)		,
		Rgb5A1Oes = ((int)0x8057)		,
		DepthComponent16Oes = ((int)0x81A5)		,
		MaxRenderbufferSizeOes = ((int)0x84E8)		,
		FramebufferBindingOes = ((int)0x8CA6)		,
		RenderbufferBindingOes = ((int)0x8CA7)		,
		FramebufferAttachmentObjectTypeOes = ((int)0x8CD0)		,
		FramebufferAttachmentObjectNameOes = ((int)0x8CD1)		,
		FramebufferAttachmentTextureLevelOes = ((int)0x8CD2)		,
		FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3)		,
		FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4)		,
		FramebufferCompleteOes = ((int)0x8CD5)		,
		FramebufferIncompleteAttachmentOes = ((int)0x8CD6)		,
		FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7)		,
		FramebufferIncompleteDimensionsOes = ((int)0x8CD9)		,
		FramebufferIncompleteFormatsOes = ((int)0x8CDA)		,
		FramebufferIncompleteDrawBufferOes = ((int)0x8CDB)		,
		FramebufferIncompleteReadBufferOes = ((int)0x8CDC)		,
		FramebufferUnsupportedOes = ((int)0x8CDD)		,
		ColorAttachment0Oes = ((int)0x8CE0)		,
		DepthAttachmentOes = ((int)0x8D00)		,
		StencilAttachmentOes = ((int)0x8D20)		,
		FramebufferOes = ((int)0x8D40)		,
		RenderbufferOes = ((int)0x8D41)		,
		RenderbufferWidthOes = ((int)0x8D42)		,
		RenderbufferHeightOes = ((int)0x8D43)		,
		RenderbufferInternalFormatOes = ((int)0x8D44)		,
		StencilIndex1Oes = ((int)0x8D46)		,
		StencilIndex4Oes = ((int)0x8D47)		,
		StencilIndex8Oes = ((int)0x8D48)		,
		RenderbufferRedSizeOes = ((int)0x8D50)		,
		RenderbufferGreenSizeOes = ((int)0x8D51)		,
		RenderbufferBlueSizeOes = ((int)0x8D52)		,
		RenderbufferAlphaSizeOes = ((int)0x8D53)		,
		RenderbufferDepthSizeOes = ((int)0x8D54)		,
		RenderbufferStencilSizeOes = ((int)0x8D55)		,
		Rgb565Oes = ((int)0x8D62)		,
	}
	public enum OesGetProgramBinary : int {
		ProgramBinaryLengthOes = ((int)0x8741)		,
		NumProgramBinaryFormatsOes = ((int)0x87FE)		,
		ProgramBinaryFormatsOes = ((int)0x87FF)		,
	}
	public enum OesMapbuffer : int {
		WriteOnlyOes = ((int)0x88B9)		,
		BufferAccessOes = ((int)0x88BB)		,
		BufferMappedOes = ((int)0x88BC)		,
		BufferMapPointerOes = ((int)0x88BD)		,
	}
	public enum OesMatrixGet : int {
		ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D)		,
		ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E)		,
		TextureMatrixFloatAsIntBitsOes = ((int)0x898F)		,
	}
	public enum OesMatrixPalette : int {
		MaxVertexUnitsOes = ((int)0x86A4)		,
		WeightArrayTypeOes = ((int)0x86A9)		,
		WeightArrayStrideOes = ((int)0x86AA)		,
		WeightArraySizeOes = ((int)0x86AB)		,
		WeightArrayPointerOes = ((int)0x86AC)		,
		WeightArrayOes = ((int)0x86AD)		,
		MatrixPaletteOes = ((int)0x8840)		,
		MaxPaletteMatricesOes = ((int)0x8842)		,
		CurrentPaletteMatrixOes = ((int)0x8843)		,
		MatrixIndexArrayOes = ((int)0x8844)		,
		MatrixIndexArraySizeOes = ((int)0x8846)		,
		MatrixIndexArrayTypeOes = ((int)0x8847)		,
		MatrixIndexArrayStrideOes = ((int)0x8848)		,
		MatrixIndexArrayPointerOes = ((int)0x8849)		,
		WeightArrayBufferBindingOes = ((int)0x889E)		,
		MatrixIndexArrayBufferBindingOes = ((int)0x8B9E)		,
	}
	public enum OesPackedDepthStencil : int {
		DepthStencilOes = ((int)0x84F9)		,
		UnsignedInt248Oes = ((int)0x84FA)		,
		Depth24Stencil8Oes = ((int)0x88F0)		,
	}
	public enum OesPointSizeArray : int {
		PointSizeArrayTypeOes = ((int)0x898A)		,
		PointSizeArrayStrideOes = ((int)0x898B)		,
		PointSizeArrayPointerOes = ((int)0x898C)		,
		PointSizeArrayOes = ((int)0x8B9C)		,
		PointSizeArrayBufferBindingOes = ((int)0x8B9F)		,
	}
	public enum OesPointSprite : int {
		PointSpriteArb = ((int)0x8861)		,
		CoordReplaceArb = ((int)0x8862)		,
	}
	public enum OesReadFormat : int {
		ImplementationColorReadTypeOes = ((int)0x8B9A)		,
		ImplementationColorReadFormatOes = ((int)0x8B9B)		,
	}
	public enum OesRgb8Rgba8 : int {
		Rgb8 = ((int)0x8051)		,
		Rgba8 = ((int)0x8058)		,
	}
	public enum OesStandardDerivatives : int {
		FragmentShaderDerivativeHintOes = ((int)0x8B8B)		,
	}
	public enum OesStencil1 : int {
		StencilIndex1Oes = ((int)0x8D46)		,
	}
	public enum OesStencil4 : int {
		StencilIndex4Oes = ((int)0x8D47)		,
	}
	public enum OesStencil8 : int {
		StencilIndex8Oes = ((int)0x8D48)		,
	}
	public enum OesStencilWrap : int {
		IncrWrapOes = ((int)0x8507)		,
		DecrWrapOes = ((int)0x8508)		,
	}
	public enum OesTexture3D : int {
		Texture3DBindingOes = ((int)0x806A)		,
		Texture3DOes = ((int)0x806F)		,
		TextureWrapROes = ((int)0x8072)		,
		Max3DTextureSizeOes = ((int)0x8073)		,
		Sampler3DOes = ((int)0x8B5F)		,
		FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4)		,
	}
	public enum OesTextureCubeMap : int {
		TextureGenMode = ((int)0x2500)		,
		NormalMapOes = ((int)0x8511)		,
		ReflectionMapOes = ((int)0x8512)		,
		TextureCubeMapOes = ((int)0x8513)		,
		TextureBindingCubeMapOes = ((int)0x8514)		,
		TextureCubeMapPositiveXOes = ((int)0x8515)		,
		TextureCubeMapNegativeXOes = ((int)0x8516)		,
		TextureCubeMapPositiveYOes = ((int)0x8517)		,
		TextureCubeMapNegativeYOes = ((int)0x8518)		,
		TextureCubeMapPositiveZOes = ((int)0x8519)		,
		TextureCubeMapNegativeZOes = ((int)0x851A)		,
		MaxCubeMapTextureSizeOes = ((int)0x851C)		,
		TextureGenStrOes = ((int)0x8D60)		,
	}
	public enum OesTextureEnvCrossbar : int {
		Texture0 = ((int)0x84C0)		,
		Texture1 = ((int)0x84C1)		,
		Texture2 = ((int)0x84C2)		,
		Texture3 = ((int)0x84C3)		,
		Texture4 = ((int)0x84C4)		,
		Texture5 = ((int)0x84C5)		,
		Texture6 = ((int)0x84C6)		,
		Texture7 = ((int)0x84C7)		,
		Texture8 = ((int)0x84C8)		,
		Texture9 = ((int)0x84C9)		,
		Texture10 = ((int)0x84CA)		,
		Texture11 = ((int)0x84CB)		,
		Texture12 = ((int)0x84CC)		,
		Texture13 = ((int)0x84CD)		,
		Texture14 = ((int)0x84CE)		,
		Texture15 = ((int)0x84CF)		,
		Texture16 = ((int)0x84D0)		,
		Texture17 = ((int)0x84D1)		,
		Texture18 = ((int)0x84D2)		,
		Texture19 = ((int)0x84D3)		,
		Texture20 = ((int)0x84D4)		,
		Texture21 = ((int)0x84D5)		,
		Texture22 = ((int)0x84D6)		,
		Texture23 = ((int)0x84D7)		,
		Texture24 = ((int)0x84D8)		,
		Texture25 = ((int)0x84D9)		,
		Texture26 = ((int)0x84DA)		,
		Texture27 = ((int)0x84DB)		,
		Texture28 = ((int)0x84DC)		,
		Texture29 = ((int)0x84DD)		,
		Texture30 = ((int)0x84DE)		,
		Texture31 = ((int)0x84DF)		,
	}
	public enum OesTextureFloat : int {
		HalfFloatOes = ((int)0x8D61)		,
	}
	public enum OesTextureMirroredRepeat : int {
		MirroredRepeatOes = ((int)0x8370)		,
	}
	public enum OesVertexHalfFloat : int {
		HalfFloatOes = ((int)0x8D61)		,
	}
	public enum OesVertexType1010102 : int {
		UnsignedInt1010102Oes = ((int)0x8DF6)		,
		Int1010102Oes = ((int)0x8DF7)		,
	}*/
	/*public enum OmlInterlace : int {
		InterlaceOml = ((int)0x8980)		,
		InterlaceReadOml = ((int)0x8981)		,
	}
	public enum OmlResample : int {
		PackResampleOml = ((int)0x8984)		,
		UnpackResampleOml = ((int)0x8985)		,
		ResampleReplicateOml = ((int)0x8986)		,
		ResampleZeroFillOml = ((int)0x8987)		,
		ResampleAverageOml = ((int)0x8988)		,
		ResampleDecimateOml = ((int)0x8989)		,
	}
	public enum OmlSubsample : int {
		FormatSubsample2424Oml = ((int)0x8982)		,
		FormatSubsample244244Oml = ((int)0x8983)		,
	}*/
	public enum PackedPointerType : int {
		UnsignedInt2101010Rev = ((int)0x8368)		,
		Int2101010Rev = ((int)0x8D9F)		,
	}
	public enum PatchParameterFloat : int {
		PatchDefaultInnerLevel = ((int)0x8E73)		,
		PatchDefaultOuterLevel = ((int)0x8E74)		,
	}
	public enum PatchParameterInt : int {
		PatchVertices = ((int)0x8E72)		,
	}
	/*public enum PgiMiscHints : int {
		PreferDoublebufferHintPgi = ((int)0x1A1F8)		,
		ConserveMemoryHintPgi = ((int)0x1A1FD)		,
		ReclaimMemoryHintPgi = ((int)0x1A1FE)		,
		NativeGraphicsHandlePgi = ((int)0x1A202)		,
		NativeGraphicsBeginHintPgi = ((int)0x1A203)		,
		NativeGraphicsEndHintPgi = ((int)0x1A204)		,
		AlwaysFastHintPgi = ((int)0x1A20C)		,
		AlwaysSoftHintPgi = ((int)0x1A20D)		,
		AllowDrawObjHintPgi = ((int)0x1A20E)		,
		AllowDrawWinHintPgi = ((int)0x1A20F)		,
		AllowDrawFrgHintPgi = ((int)0x1A210)		,
		AllowDrawMemHintPgi = ((int)0x1A211)		,
		StrictDepthfuncHintPgi = ((int)0x1A216)		,
		StrictLightingHintPgi = ((int)0x1A217)		,
		StrictScissorHintPgi = ((int)0x1A218)		,
		FullStippleHintPgi = ((int)0x1A219)		,
		ClipNearHintPgi = ((int)0x1A220)		,
		ClipFarHintPgi = ((int)0x1A221)		,
		WideLineHintPgi = ((int)0x1A222)		,
		BackNormalsHintPgi = ((int)0x1A223)		,
	}
	public enum PgiVertexHints : int {
		Vertex23BitPgi = ((int)0x00000004)		,
		Vertex4BitPgi = ((int)0x00000008)		,
		Color3BitPgi = ((int)0x00010000)		,
		Color4BitPgi = ((int)0x00020000)		,
		EdgeflagBitPgi = ((int)0x00040000)		,
		IndexBitPgi = ((int)0x00080000)		,
		MatAmbientBitPgi = ((int)0x00100000)		,
		MatAmbientAndDiffuseBitPgi = ((int)0x00200000)		,
		MatDiffuseBitPgi = ((int)0x00400000)		,
		MatEmissionBitPgi = ((int)0x00800000)		,
		MatColorIndexesBitPgi = ((int)0x01000000)		,
		MatShininessBitPgi = ((int)0x02000000)		,
		MatSpecularBitPgi = ((int)0x04000000)		,
		NormalBitPgi = ((int)0x08000000)		,
		Texcoord1BitPgi = ((int)0x10000000)		,
		VertexDataHintPgi = ((int)0x1A22A)		,
		VertexConsistentHintPgi = ((int)0x1A22B)		,
		MaterialSideHintPgi = ((int)0x1A22C)		,
		MaxVertexHintPgi = ((int)0x1A22D)		,
		Texcoord2BitPgi = ((int)0x20000000)		,
		Texcoord3BitPgi = ((int)0x40000000)		,
		Texcoord4BitPgi = unchecked((int)0x80000000)		,
	}*/
	public enum PixelCopyType : int {
		Color = ((int)0x1800)		,
		Depth = ((int)0x1801)		,
		Stencil = ((int)0x1802)		,
	}
	public enum PixelFormat : int {
		ColorIndex = ((int)0x1900)		,
		StencilIndex = ((int)0x1901)		,
		DepthComponent = ((int)0x1902)		,
		Red = ((int)0x1903)		,
		Green = ((int)0x1904)		,
		Blue = ((int)0x1905)		,
		Alpha = ((int)0x1906)		,
		Rgb = ((int)0x1907)		,
		Rgba = ((int)0x1908)		,
		Luminance = ((int)0x1909)		,
		LuminanceAlpha = ((int)0x190A)		,
		AbgrExt = ((int)0x8000)		,
		CmykExt = ((int)0x800C)		,
		CmykaExt = ((int)0x800D)		,
		Bgr = ((int)0x80E0)		,
		Bgra = ((int)0x80E1)		,
		Ycrcb422Sgix = ((int)0x81BB)		,
		Ycrcb444Sgix = ((int)0x81BC)		,
		Rg = ((int)0x8227)		,
		RgInteger = ((int)0x8228)		,
		DepthStencil = ((int)0x84F9)		,
		RedInteger = ((int)0x8D94)		,
		GreenInteger = ((int)0x8D95)		,
		BlueInteger = ((int)0x8D96)		,
		AlphaInteger = ((int)0x8D97)		,
		RgbInteger = ((int)0x8D98)		,
		RgbaInteger = ((int)0x8D99)		,
		BgrInteger = ((int)0x8D9A)		,
		BgraInteger = ((int)0x8D9B)		,
	}
	public enum PixelInternalFormat : int {
		DepthComponent = ((int)0x1902)		,
		Alpha = ((int)0x1906)		,
		Rgb = ((int)0x1907)		,
		Rgba = ((int)0x1908)		,
		Luminance = ((int)0x1909)		,
		LuminanceAlpha = ((int)0x190A)		,
		R3G3B2 = ((int)0x2A10)		,
		Alpha4 = ((int)0x803B)		,
		Alpha8 = ((int)0x803C)		,
		Alpha12 = ((int)0x803D)		,
		Alpha16 = ((int)0x803E)		,
		Luminance4 = ((int)0x803F)		,
		Luminance8 = ((int)0x8040)		,
		Luminance12 = ((int)0x8041)		,
		Luminance16 = ((int)0x8042)		,
		Luminance4Alpha4 = ((int)0x8043)		,
		Luminance6Alpha2 = ((int)0x8044)		,
		Luminance8Alpha8 = ((int)0x8045)		,
		Luminance12Alpha4 = ((int)0x8046)		,
		Luminance12Alpha12 = ((int)0x8047)		,
		Luminance16Alpha16 = ((int)0x8048)		,
		Intensity = ((int)0x8049)		,
		Intensity4 = ((int)0x804A)		,
		Intensity8 = ((int)0x804B)		,
		Intensity12 = ((int)0x804C)		,
		Intensity16 = ((int)0x804D)		,
		Rgb2Ext = ((int)0x804E)		,
		Rgb4 = ((int)0x804F)		,
		Rgb5 = ((int)0x8050)		,
		Rgb8 = ((int)0x8051)		,
		Rgb10 = ((int)0x8052)		,
		Rgb12 = ((int)0x8053)		,
		Rgb16 = ((int)0x8054)		,
		Rgba2 = ((int)0x8055)		,
		Rgba4 = ((int)0x8056)		,
		Rgb5A1 = ((int)0x8057)		,
		Rgba8 = ((int)0x8058)		,
		Rgb10A2 = ((int)0x8059)		,
		Rgba12 = ((int)0x805A)		,
		Rgba16 = ((int)0x805B)		,
		DualAlpha4Sgis = ((int)0x8110)		,
		DualAlpha8Sgis = ((int)0x8111)		,
		DualAlpha12Sgis = ((int)0x8112)		,
		DualAlpha16Sgis = ((int)0x8113)		,
		DualLuminance4Sgis = ((int)0x8114)		,
		DualLuminance8Sgis = ((int)0x8115)		,
		DualLuminance12Sgis = ((int)0x8116)		,
		DualLuminance16Sgis = ((int)0x8117)		,
		DualIntensity4Sgis = ((int)0x8118)		,
		DualIntensity8Sgis = ((int)0x8119)		,
		DualIntensity12Sgis = ((int)0x811A)		,
		DualIntensity16Sgis = ((int)0x811B)		,
		DualLuminanceAlpha4Sgis = ((int)0x811C)		,
		DualLuminanceAlpha8Sgis = ((int)0x811D)		,
		QuadAlpha4Sgis = ((int)0x811E)		,
		QuadAlpha8Sgis = ((int)0x811F)		,
		QuadLuminance4Sgis = ((int)0x8120)		,
		QuadLuminance8Sgis = ((int)0x8121)		,
		QuadIntensity4Sgis = ((int)0x8122)		,
		QuadIntensity8Sgis = ((int)0x8123)		,
		DepthComponent16 = ((int)0x81a5)		,
		DepthComponent16Sgix = ((int)0x81A5)		,
		DepthComponent24 = ((int)0x81a6)		,
		DepthComponent24Sgix = ((int)0x81A6)		,
		DepthComponent32 = ((int)0x81a7)		,
		DepthComponent32Sgix = ((int)0x81A7)		,
		CompressedRed = ((int)0x8225)		,
		CompressedRg = ((int)0x8226)		,
		R8 = ((int)0x8229)		,
		R16 = ((int)0x822A)		,
		Rg8 = ((int)0x822B)		,
		Rg16 = ((int)0x822C)		,
		R16f = ((int)0x822D)		,
		R32f = ((int)0x822E)		,
		Rg16f = ((int)0x822F)		,
		Rg32f = ((int)0x8230)		,
		R8i = ((int)0x8231)		,
		R8ui = ((int)0x8232)		,
		R16i = ((int)0x8233)		,
		R16ui = ((int)0x8234)		,
		R32i = ((int)0x8235)		,
		R32ui = ((int)0x8236)		,
		Rg8i = ((int)0x8237)		,
		Rg8ui = ((int)0x8238)		,
		Rg16i = ((int)0x8239)		,
		Rg16ui = ((int)0x823A)		,
		Rg32i = ((int)0x823B)		,
		Rg32ui = ((int)0x823C)		,
		CompressedRgbS3tcDxt1Ext = ((int)0x83F0)		,
		CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)		,
		CompressedRgbaS3tcDxt3Ext = ((int)0x83F2)		,
		CompressedRgbaS3tcDxt5Ext = ((int)0x83F3)		,
		CompressedAlpha = ((int)0x84E9)		,
		CompressedLuminance = ((int)0x84EA)		,
		CompressedLuminanceAlpha = ((int)0x84EB)		,
		CompressedIntensity = ((int)0x84EC)		,
		CompressedRgb = ((int)0x84ED)		,
		CompressedRgba = ((int)0x84EE)		,
		DepthStencil = ((int)0x84F9)		,
		Rgba32f = ((int)0x8814)		,
		Rgb32f = ((int)0x8815)		,
		Rgba16f = ((int)0x881A)		,
		Rgb16f = ((int)0x881B)		,
		Depth24Stencil8 = ((int)0x88F0)		,
		R11fG11fB10f = ((int)0x8C3A)		,
		Rgb9E5 = ((int)0x8C3D)		,
		Srgb = ((int)0x8C40)		,
		Srgb8 = ((int)0x8C41)		,
		SrgbAlpha = ((int)0x8C42)		,
		Srgb8Alpha8 = ((int)0x8C43)		,
		SluminanceAlpha = ((int)0x8C44)		,
		Sluminance8Alpha8 = ((int)0x8C45)		,
		Sluminance = ((int)0x8C46)		,
		Sluminance8 = ((int)0x8C47)		,
		CompressedSrgb = ((int)0x8C48)		,
		CompressedSrgbAlpha = ((int)0x8C49)		,
		CompressedSluminance = ((int)0x8C4A)		,
		CompressedSluminanceAlpha = ((int)0x8C4B)		,
		CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C)		,
		CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D)		,
		CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E)		,
		CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F)		,
		DepthComponent32f = ((int)0x8CAC)		,
		Depth32fStencil8 = ((int)0x8CAD)		,
		Rgba32ui = ((int)0x8D70)		,
		Rgb32ui = ((int)0x8D71)		,
		Rgba16ui = ((int)0x8D76)		,
		Rgb16ui = ((int)0x8D77)		,
		Rgba8ui = ((int)0x8D7C)		,
		Rgb8ui = ((int)0x8D7D)		,
		Rgba32i = ((int)0x8D82)		,
		Rgb32i = ((int)0x8D83)		,
		Rgba16i = ((int)0x8D88)		,
		Rgb16i = ((int)0x8D89)		,
		Rgba8i = ((int)0x8D8E)		,
		Rgb8i = ((int)0x8D8F)		,
		Float32UnsignedInt248Rev = ((int)0x8DAD)		,
		CompressedRedRgtc1 = ((int)0x8DBB)		,
		CompressedSignedRedRgtc1 = ((int)0x8DBC)		,
		CompressedRgRgtc2 = ((int)0x8DBD)		,
		CompressedSignedRgRgtc2 = ((int)0x8DBE)		,
		Rgb10A2ui = ((int)0x906F)		,
		One = ((int)1)		,
		Two = ((int)2)		,
		Three = ((int)3)		,
		Four = ((int)4)		,
	}
	public enum PixelMap : int {
		PixelMapIToI = ((int)0x0C70)		,
		PixelMapSToS = ((int)0x0C71)		,
		PixelMapIToR = ((int)0x0C72)		,
		PixelMapIToG = ((int)0x0C73)		,
		PixelMapIToB = ((int)0x0C74)		,
		PixelMapIToA = ((int)0x0C75)		,
		PixelMapRToR = ((int)0x0C76)		,
		PixelMapGToG = ((int)0x0C77)		,
		PixelMapBToB = ((int)0x0C78)		,
		PixelMapAToA = ((int)0x0C79)		,
	}
	public enum PixelStoreParameter : int {
		UnpackSwapBytes = ((int)0x0CF0)		,
		UnpackLsbFirst = ((int)0x0CF1)		,
		UnpackRowLength = ((int)0x0CF2)		,
		UnpackSkipRows = ((int)0x0CF3)		,
		UnpackSkipPixels = ((int)0x0CF4)		,
		UnpackAlignment = ((int)0x0CF5)		,
		PackSwapBytes = ((int)0x0D00)		,
		PackLsbFirst = ((int)0x0D01)		,
		PackRowLength = ((int)0x0D02)		,
		PackSkipRows = ((int)0x0D03)		,
		PackSkipPixels = ((int)0x0D04)		,
		PackAlignment = ((int)0x0D05)		,
		PackSkipImages = ((int)0x806B)		,
		PackSkipImagesExt = ((int)0x806B)		,
		PackImageHeight = ((int)0x806C)		,
		PackImageHeightExt = ((int)0x806C)		,
		UnpackSkipImages = ((int)0x806D)		,
		UnpackSkipImagesExt = ((int)0x806D)		,
		UnpackImageHeight = ((int)0x806E)		,
		UnpackImageHeightExt = ((int)0x806E)		,
		PackSkipVolumesSgis = ((int)0x8130)		,
		PackImageDepthSgis = ((int)0x8131)		,
		UnpackSkipVolumesSgis = ((int)0x8132)		,
		UnpackImageDepthSgis = ((int)0x8133)		,
		PixelTileWidthSgix = ((int)0x8140)		,
		PixelTileHeightSgix = ((int)0x8141)		,
		PixelTileGridWidthSgix = ((int)0x8142)		,
		PixelTileGridHeightSgix = ((int)0x8143)		,
		PixelTileGridDepthSgix = ((int)0x8144)		,
		PixelTileCacheSizeSgix = ((int)0x8145)		,
		PackResampleSgix = ((int)0x842C)		,
		UnpackResampleSgix = ((int)0x842D)		,
		PackSubsampleRateSgix = ((int)0x85A0)		,
		UnpackSubsampleRateSgix = ((int)0x85A1)		,
	}
	public enum PixelStoreResampleMode : int {
		ResampleReplicateSgix = ((int)0x842E)		,
		ResampleZeroFillSgix = ((int)0x842F)		,
		ResampleDecimateSgix = ((int)0x8430)		,
	}
	public enum PixelStoreSubsampleRate : int {
		PixelSubsample4444Sgix = ((int)0x85A2)		,
		PixelSubsample2424Sgix = ((int)0x85A3)		,
		PixelSubsample4242Sgix = ((int)0x85A4)		,
	}
	public enum PixelTexGenMode : int {
		None = ((int)0)		,
		Rgb = ((int)0x1907)		,
		Rgba = ((int)0x1908)		,
		Luminance = ((int)0x1909)		,
		LuminanceAlpha = ((int)0x190A)		,
		PixelTexGenAlphaReplaceSgix = ((int)0x8187)		,
		PixelTexGenAlphaNoReplaceSgix = ((int)0x8188)		,
		PixelTexGenAlphaLsSgix = ((int)0x8189)		,
		PixelTexGenAlphaMsSgix = ((int)0x818A)		,
	}
	/*public enum PixelTexGenParameterNameSgis : int {
		PixelFragmentRgbSourceSgis = ((int)0x8354)		,
		PixelFragmentAlphaSourceSgis = ((int)0x8355)		,
	}*/
	public enum PixelTransferParameter : int {
		MapColor = ((int)0x0D10)		,
		MapStencil = ((int)0x0D11)		,
		IndexShift = ((int)0x0D12)		,
		IndexOffset = ((int)0x0D13)		,
		RedScale = ((int)0x0D14)		,
		RedBias = ((int)0x0D15)		,
		GreenScale = ((int)0x0D18)		,
		GreenBias = ((int)0x0D19)		,
		BlueScale = ((int)0x0D1A)		,
		BlueBias = ((int)0x0D1B)		,
		AlphaScale = ((int)0x0D1C)		,
		AlphaBias = ((int)0x0D1D)		,
		DepthScale = ((int)0x0D1E)		,
		DepthBias = ((int)0x0D1F)		,
		PostConvolutionRedScaleExt = ((int)0x801C)		,
		PostConvolutionGreenScaleExt = ((int)0x801D)		,
		PostConvolutionBlueScaleExt = ((int)0x801E)		,
		PostConvolutionAlphaScaleExt = ((int)0x801F)		,
		PostConvolutionRedBiasExt = ((int)0x8020)		,
		PostConvolutionGreenBiasExt = ((int)0x8021)		,
		PostConvolutionBlueBiasExt = ((int)0x8022)		,
		PostConvolutionAlphaBiasExt = ((int)0x8023)		,
		PostColorMatrixRedScaleSgi = ((int)0x80B4)		,
		PostColorMatrixGreenScaleSgi = ((int)0x80B5)		,
		PostColorMatrixBlueScaleSgi = ((int)0x80B6)		,
		PostColorMatrixAlphaScaleSgi = ((int)0x80B7)		,
		PostColorMatrixRedBiasSgi = ((int)0x80B8)		,
		PostColorMatrixGreenBiasSgi = ((int)0x80B9)		,
		PostColorMatrixBlueBiasSgi = ((int)0x80BA)		,
		PostColorMatrixAlphaBiasSgi = ((int)0x80BB)		,
	}
	public enum PixelType : int {
		Byte = ((int)0x1400)		,
		UnsignedByte = ((int)0x1401)		,
		Short = ((int)0x1402)		,
		UnsignedShort = ((int)0x1403)		,
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
		Float = ((int)0x1406)		,
		HalfFloat = ((int)0x140B)		,
		Bitmap = ((int)0x1A00)		,
		UnsignedByte332 = ((int)0x8032)		,
		UnsignedByte332Ext = ((int)0x8032)		,
		UnsignedShort4444 = ((int)0x8033)		,
		UnsignedShort4444Ext = ((int)0x8033)		,
		UnsignedShort5551 = ((int)0x8034)		,
		UnsignedShort5551Ext = ((int)0x8034)		,
		UnsignedInt8888 = ((int)0x8035)		,
		UnsignedInt8888Ext = ((int)0x8035)		,
		UnsignedInt1010102 = ((int)0x8036)		,
		UnsignedInt1010102Ext = ((int)0x8036)		,
		UnsignedByte233Reversed = ((int)0x8362)		,
		UnsignedShort565 = ((int)0x8363)		,
		UnsignedShort565Reversed = ((int)0x8364)		,
		UnsignedShort4444Reversed = ((int)0x8365)		,
		UnsignedShort1555Reversed = ((int)0x8366)		,
		UnsignedInt8888Reversed = ((int)0x8367)		,
		UnsignedInt2101010Reversed = ((int)0x8368)		,
		UnsignedInt248 = ((int)0x84FA)		,
		UnsignedInt10F11F11FRev = ((int)0x8C3B)		,
		UnsignedInt5999Rev = ((int)0x8C3E)		,
		Float32UnsignedInt248Rev = ((int)0x8DAD)		,
	}
	public enum PointParameterName : int {
		PointSizeMin = ((int)0x8126)		,
		PointSizeMax = ((int)0x8127)		,
		PointFadeThresholdSize = ((int)0x8128)		,
		PointDistanceAttenuation = ((int)0x8129)		,
		PointSpriteCoordOrigin = ((int)0x8CA0)		,
	}
	public enum PointParameterNameSgis : int {
		PointSizeMinSgis = ((int)0x8126)		,
		PointSizeMaxSgis = ((int)0x8127)		,
		PointFadeThresholdSizeSgis = ((int)0x8128)		,
		DistanceAttenuationSgis = ((int)0x8129)		,
	}
	public enum PointSpriteCoordOriginParameter : int {
		LowerLeft = ((int)0x8CA1)		,
		UpperLeft = ((int)0x8CA2)		,
	}
	public enum PolygonMode : int {
		Point = ((int)0x1B00)		,
		Line = ((int)0x1B01)		,
		Fill = ((int)0x1B02)		,
	}
	public enum ProgramParameter : int {
		ProgramBinaryRetrievableHint = ((int)0x8257)		,
		ProgramSeparable = ((int)0x8258)		,
		ProgramBinaryLength = ((int)0x8741)		,
		GeometryShaderInvocations = ((int)0x887F)		,
		ActiveUniformBlockMaxNameLength = ((int)0x8A35)		,
		ActiveUniformBlocks = ((int)0x8A36)		,
		DeleteStatus = ((int)0x8B80)		,
		LinkStatus = ((int)0x8B82)		,
		ValidateStatus = ((int)0x8B83)		,
		InfoLogLength = ((int)0x8B84)		,
		AttachedShaders = ((int)0x8B85)		,
		ActiveUniforms = ((int)0x8B86)		,
		ActiveUniformMaxLength = ((int)0x8B87)		,
		ActiveAttributes = ((int)0x8B89)		,
		ActiveAttributeMaxLength = ((int)0x8B8A)		,
		TransformFeedbackVaryingMaxLength = ((int)0x8C76)		,
		TransformFeedbackBufferMode = ((int)0x8C7F)		,
		TransformFeedbackVaryings = ((int)0x8C83)		,
		GeometryVerticesOut = ((int)0x8DDA)		,
		GeometryInputType = ((int)0x8DDB)		,
		GeometryOutputType = ((int)0x8DDC)		,
		TessControlOutputVertices = ((int)0x8E75)		,
		TessGenMode = ((int)0x8E76)		,
		TessGenSpacing = ((int)0x8E77)		,
		TessGenVertexOrder = ((int)0x8E78)		,
		TessGenPointMode = ((int)0x8E79)		,
	}
	
	public enum ProgramPipelineParameter : int {
		ActiveProgram = ((int)0x8259)		,
	}
	[Flags]
	public enum ProgramStageMask : int {
		VertexShaderBit = ((int)0x00000001)		,
		FragmentShaderBit = ((int)0x00000002)		,
		GeometryShaderBit = ((int)0x00000004)		,
		TessControlShaderBit = ((int)0x00000008)		,
		TessEvaluationShaderBit = ((int)0x00000010)		,
		AllShaderBits = unchecked((int)0xFFFFFFFF)		,
        // Manual added
        ComputeShaderBit = ((int)0x00000020),
	}
	
	public enum ProgramStageParameter : int {
		ActiveSubroutines = ((int)0x8DE5)		,
		ActiveSubroutineUniforms = ((int)0x8DE6)		,
		ActiveSubroutineUniformLocations = ((int)0x8E47)		,
		ActiveSubroutineMaxLength = ((int)0x8E48)		,
		ActiveSubroutineUniformMaxLength = ((int)0x8E49)		,
	}
	public enum ProvokingVertexMode : int {
		FirstVertexConvention = ((int)0x8E4D)		,
		LastVertexConvention = ((int)0x8E4E)		,
	}
	public enum QcomAlphaTest : int {
		AlphaTestQcom = ((int)0x0BC0)		,
		AlphaTestFuncQcom = ((int)0x0BC1)		,
		AlphaTestRefQcom = ((int)0x0BC2)		,
	}
	public enum QcomDriverControl : int {
		PerfmonGlobalModeQcom = ((int)0x8FA0)		,
	}
	public enum QcomExtendedGet : int {
		TextureWidthQcom = ((int)0x8BD2)		,
		TextureHeightQcom = ((int)0x8BD3)		,
		TextureDepthQcom = ((int)0x8BD4)		,
		TextureInternalFormatQcom = ((int)0x8BD5)		,
		TextureFormatQcom = ((int)0x8BD6)		,
		TextureTypeQcom = ((int)0x8BD7)		,
		TextureImageValidQcom = ((int)0x8BD8)		,
		TextureNumLevelsQcom = ((int)0x8BD9)		,
		TextureTargetQcom = ((int)0x8BDA)		,
		TextureObjectValidQcom = ((int)0x8BDB)		,
		StateRestore = ((int)0x8BDC)		,
	}
	public enum QcomWriteonlyRendering : int {
		WriteonlyRenderingQcom = ((int)0x8823)		,
	}
	public enum QueryCounterTarget : int {
		Timestamp = ((int)0x8E28)		,
	}
	public enum QueryTarget : int {
		TimeElapsed = ((int)0x88BF)		,
		SamplesPassed = ((int)0x8914)		,
		AnySamplesPassed = ((int)0x8C2F)		,
		PrimitivesGenerated = ((int)0x8C87)		,
		TransformFeedbackPrimitivesWritten = ((int)0x8C88)		,
		Timestamp = ((int)0x8E28)		,
	}
	public enum ReadBufferMode : int {
		None = ((int)0)		,
		FrontLeft = ((int)0x0400)		,
		FrontRight = ((int)0x0401)		,
		BackLeft = ((int)0x0402)		,
		BackRight = ((int)0x0403)		,
		Front = ((int)0x0404)		,
		Back = ((int)0x0405)		,
		Left = ((int)0x0406)		,
		Right = ((int)0x0407)		,
		Aux0 = ((int)0x0409)		,
		Aux1 = ((int)0x040A)		,
		Aux2 = ((int)0x040B)		,
		Aux3 = ((int)0x040C)		,
		ColorAttachment0 = ((int)0x8CE0)		,
		ColorAttachment1 = ((int)0x8CE1)		,
		ColorAttachment2 = ((int)0x8CE2)		,
		ColorAttachment3 = ((int)0x8CE3)		,
		ColorAttachment4 = ((int)0x8CE4)		,
		ColorAttachment5 = ((int)0x8CE5)		,
		ColorAttachment6 = ((int)0x8CE6)		,
		ColorAttachment7 = ((int)0x8CE7)		,
		ColorAttachment8 = ((int)0x8CE8)		,
		ColorAttachment9 = ((int)0x8CE9)		,
		ColorAttachment10 = ((int)0x8CEA)		,
		ColorAttachment11 = ((int)0x8CEB)		,
		ColorAttachment12 = ((int)0x8CEC)		,
		ColorAttachment13 = ((int)0x8CED)		,
		ColorAttachment14 = ((int)0x8CEE)		,
		ColorAttachment15 = ((int)0x8CEF)		,
	}
	public enum RenderbufferParameterName : int {
		RenderbufferSamples = ((int)0x8CAB)		,
		RenderbufferWidth = ((int)0x8D42)		,
		RenderbufferWidthExt = ((int)0x8D42)		,
		RenderbufferHeight = ((int)0x8D43)		,
		RenderbufferHeightExt = ((int)0x8D43)		,
		RenderbufferInternalFormat = ((int)0x8D44)		,
		RenderbufferInternalFormatExt = ((int)0x8D44)		,
		RenderbufferRedSize = ((int)0x8D50)		,
		RenderbufferRedSizeExt = ((int)0x8D50)		,
		RenderbufferGreenSize = ((int)0x8D51)		,
		RenderbufferGreenSizeExt = ((int)0x8D51)		,
		RenderbufferBlueSize = ((int)0x8D52)		,
		RenderbufferBlueSizeExt = ((int)0x8D52)		,
		RenderbufferAlphaSize = ((int)0x8D53)		,
		RenderbufferAlphaSizeExt = ((int)0x8D53)		,
		RenderbufferDepthSize = ((int)0x8D54)		,
		RenderbufferDepthSizeExt = ((int)0x8D54)		,
		RenderbufferStencilSize = ((int)0x8D55)		,
		RenderbufferStencilSizeExt = ((int)0x8D55)		,
	}
	public enum RenderbufferStorage : int {
		R3G3B2 = ((int)0x2A10)		,
		Alpha4 = ((int)0x803B)		,
		Alpha8 = ((int)0x803C)		,
		Alpha12 = ((int)0x803D)		,
		Alpha16 = ((int)0x803E)		,
		Rgb4 = ((int)0x804F)		,
		Rgb5 = ((int)0x8050)		,
		Rgb8 = ((int)0x8051)		,
		Rgb10 = ((int)0x8052)		,
		Rgb12 = ((int)0x8053)		,
		Rgb16 = ((int)0x8054)		,
		Rgba2 = ((int)0x8055)		,
		Rgba4 = ((int)0x8056)		,
		Rgba8 = ((int)0x8058)		,
		Rgb10A2 = ((int)0x8059)		,
		Rgba12 = ((int)0x805A)		,
		Rgba16 = ((int)0x805B)		,
		DepthComponent16 = ((int)0x81a5)		,
		DepthComponent24 = ((int)0x81a6)		,
		DepthComponent32 = ((int)0x81a7)		,
		R8 = ((int)0x8229)		,
		R16 = ((int)0x822A)		,
		Rg8 = ((int)0x822B)		,
		Rg16 = ((int)0x822C)		,
		R16f = ((int)0x822D)		,
		R32f = ((int)0x822E)		,
		Rg16f = ((int)0x822F)		,
		Rg32f = ((int)0x8230)		,
		R8i = ((int)0x8231)		,
		R8ui = ((int)0x8232)		,
		R16i = ((int)0x8233)		,
		R16ui = ((int)0x8234)		,
		R32i = ((int)0x8235)		,
		R32ui = ((int)0x8236)		,
		Rg8i = ((int)0x8237)		,
		Rg8ui = ((int)0x8238)		,
		Rg16i = ((int)0x8239)		,
		Rg16ui = ((int)0x823A)		,
		Rg32i = ((int)0x823B)		,
		Rg32ui = ((int)0x823C)		,
		Rgba32f = ((int)0x8814)		,
		Rgb32f = ((int)0x8815)		,
		Rgba16f = ((int)0x881A)		,
		Rgb16f = ((int)0x881B)		,
		Depth24Stencil8 = ((int)0x88F0)		,
		R11fG11fB10f = ((int)0x8C3A)		,
		Rgb9E5 = ((int)0x8C3D)		,
		Srgb8 = ((int)0x8C41)		,
		Srgb8Alpha8 = ((int)0x8C43)		,
		DepthComponent32f = ((int)0x8CAC)		,
		Depth32fStencil8 = ((int)0x8CAD)		,
		StencilIndex1 = ((int)0x8D46)		,
		StencilIndex1Ext = ((int)0x8D46)		,
		StencilIndex4 = ((int)0x8D47)		,
		StencilIndex4Ext = ((int)0x8D47)		,
		StencilIndex8 = ((int)0x8D48)		,
		StencilIndex8Ext = ((int)0x8D48)		,
		StencilIndex16 = ((int)0x8D49)		,
		StencilIndex16Ext = ((int)0x8D49)		,
		Rgba32ui = ((int)0x8D70)		,
		Rgb32ui = ((int)0x8D71)		,
		Rgba16ui = ((int)0x8D76)		,
		Rgb16ui = ((int)0x8D77)		,
		Rgba8ui = ((int)0x8D7C)		,
		Rgb8ui = ((int)0x8D7D)		,
		Rgba32i = ((int)0x8D82)		,
		Rgb32i = ((int)0x8D83)		,
		Rgba16i = ((int)0x8D88)		,
		Rgb16i = ((int)0x8D89)		,
		Rgba8i = ((int)0x8D8E)		,
		Rgb8i = ((int)0x8D8F)		,
		Rgb10A2ui = ((int)0x906F)		,
	}
	public enum RenderbufferTarget : int {
		Renderbuffer = ((int)0x8D41)		,
		RenderbufferExt = ((int)0x8D41)		,
	}
	public enum RenderingMode : int {
		Render = ((int)0x1C00)		,
		Feedback = ((int)0x1C01)		,
		Select = ((int)0x1C02)		,
	}
	public enum RendScreenCoordinates : int {
		ScreenCoordinatesRend = ((int)0x8490)		,
		InvertedScreenWRend = ((int)0x8491)		,
	}
	/*public enum S3S3tc : int {
		RgbS3tc = ((int)0x83A0)		,
		Rgb4S3tc = ((int)0x83A1)		,
		RgbaS3tc = ((int)0x83A2)		,
		Rgba4S3tc = ((int)0x83A3)		,
	}
	public enum SamplePatternSgis : int {
		Gl1PassSgis = ((int)0x80A1)		,
		Gl2Pass0Sgis = ((int)0x80A2)		,
		Gl2Pass1Sgis = ((int)0x80A3)		,
		Gl4Pass0Sgis = ((int)0x80A4)		,
		Gl4Pass1Sgis = ((int)0x80A5)		,
		Gl4Pass2Sgis = ((int)0x80A6)		,
		Gl4Pass3Sgis = ((int)0x80A7)		,
	}*/
	public enum SamplerParameter : int {
		TextureBorderColor = ((int)0x1004)		,
		TextureMagFilter = ((int)0x2800)		,
		TextureMinFilter = ((int)0x2801)		,
		TextureWrapS = ((int)0x2802)		,
		TextureWrapT = ((int)0x2803)		,
		TextureWrapR = ((int)0x8072)		,
		TextureMinLod = ((int)0x813A)		,
		TextureMaxLod = ((int)0x813B)		,
		TextureMaxAnisotropyExt = ((int)0x84FE)		,
		TextureLodBias = ((int)0x8501)		,
		TextureCompareMode = ((int)0x884C)		,
		TextureCompareFunc = ((int)0x884D)		,
	}
	public enum SeparableTarget : int {
		Separable2D = ((int)0x8012)		,
	}
	/*public enum SeparableTargetExt : int {
		Separable2DExt = ((int)0x8012)		,
	}
	public enum SgiColorMatrix : int {
		ColorMatrixSgi = ((int)0x80B1)		,
		ColorMatrixStackDepthSgi = ((int)0x80B2)		,
		MaxColorMatrixStackDepthSgi = ((int)0x80B3)		,
		PostColorMatrixRedScaleSgi = ((int)0x80B4)		,
		PostColorMatrixGreenScaleSgi = ((int)0x80B5)		,
		PostColorMatrixBlueScaleSgi = ((int)0x80B6)		,
		PostColorMatrixAlphaScaleSgi = ((int)0x80B7)		,
		PostColorMatrixRedBiasSgi = ((int)0x80B8)		,
		PostColorMatrixGreenBiasSgi = ((int)0x80B9)		,
		PostColorMatrixBlueBiasSgi = ((int)0x80BA)		,
		PostColorMatrixAlphaBiasSgi = ((int)0x80BB)		,
	}
	public enum SgiColorTable : int {
		ColorTableSgi = ((int)0x80D0)		,
		PostConvolutionColorTableSgi = ((int)0x80D1)		,
		PostColorMatrixColorTableSgi = ((int)0x80D2)		,
		ProxyColorTableSgi = ((int)0x80D3)		,
		ProxyPostConvolutionColorTableSgi = ((int)0x80D4)		,
		ProxyPostColorMatrixColorTableSgi = ((int)0x80D5)		,
		ColorTableScaleSgi = ((int)0x80D6)		,
		ColorTableBiasSgi = ((int)0x80D7)		,
		ColorTableFormatSgi = ((int)0x80D8)		,
		ColorTableWidthSgi = ((int)0x80D9)		,
		ColorTableRedSizeSgi = ((int)0x80DA)		,
		ColorTableGreenSizeSgi = ((int)0x80DB)		,
		ColorTableBlueSizeSgi = ((int)0x80DC)		,
		ColorTableAlphaSizeSgi = ((int)0x80DD)		,
		ColorTableLuminanceSizeSgi = ((int)0x80DE)		,
		ColorTableIntensitySizeSgi = ((int)0x80DF)		,
	}
	public enum SgiDepthPassInstrument : int {
		DepthPassInstrumentSgix = ((int)0x8310)		,
		DepthPassInstrumentCountersSgix = ((int)0x8311)		,
		DepthPassInstrumentMaxSgix = ((int)0x8312)		,
	}
	public enum SgisDetailTexture : int {
		DetailTexture2DSgis = ((int)0x8095)		,
		DetailTexture2DBindingSgis = ((int)0x8096)		,
		LinearDetailSgis = ((int)0x8097)		,
		LinearDetailAlphaSgis = ((int)0x8098)		,
		LinearDetailColorSgis = ((int)0x8099)		,
		DetailTextureLevelSgis = ((int)0x809A)		,
		DetailTextureModeSgis = ((int)0x809B)		,
		DetailTextureFuncPointsSgis = ((int)0x809C)		,
	}
	public enum SgisFogFunction : int {
		FogFuncSgis = ((int)0x812A)		,
		FogFuncPointsSgis = ((int)0x812B)		,
		MaxFogFuncPointsSgis = ((int)0x812C)		,
	}
	public enum SgisGenerateMipmap : int {
		GenerateMipmapSgis = ((int)0x8191)		,
		GenerateMipmapHintSgis = ((int)0x8192)		,
	}
	public enum SgisMultisample : int {
		MultisampleSgis = ((int)0x809D)		,
		SampleAlphaToMaskSgis = ((int)0x809E)		,
		SampleAlphaToOneSgis = ((int)0x809F)		,
		SampleMaskSgis = ((int)0x80A0)		,
		Gl1PassSgis = ((int)0x80A1)		,
		Gl2Pass0Sgis = ((int)0x80A2)		,
		Gl2Pass1Sgis = ((int)0x80A3)		,
		Gl4Pass0Sgis = ((int)0x80A4)		,
		Gl4Pass1Sgis = ((int)0x80A5)		,
		Gl4Pass2Sgis = ((int)0x80A6)		,
		Gl4Pass3Sgis = ((int)0x80A7)		,
		SampleBuffersSgis = ((int)0x80A8)		,
		SamplesSgis = ((int)0x80A9)		,
		SampleMaskValueSgis = ((int)0x80AA)		,
		SampleMaskInvertSgis = ((int)0x80AB)		,
		SamplePatternSgis = ((int)0x80AC)		,
	}
	public enum SgisPixelTexture : int {
		PixelTextureSgis = ((int)0x8353)		,
		PixelFragmentRgbSourceSgis = ((int)0x8354)		,
		PixelFragmentAlphaSourceSgis = ((int)0x8355)		,
		PixelGroupColorSgis = ((int)0x8356)		,
	}
	public enum SgisPointLineTexgen : int {
		EyeDistanceToPointSgis = ((int)0x81F0)		,
		ObjectDistanceToPointSgis = ((int)0x81F1)		,
		EyeDistanceToLineSgis = ((int)0x81F2)		,
		ObjectDistanceToLineSgis = ((int)0x81F3)		,
		EyePointSgis = ((int)0x81F4)		,
		ObjectPointSgis = ((int)0x81F5)		,
		EyeLineSgis = ((int)0x81F6)		,
		ObjectLineSgis = ((int)0x81F7)		,
	}
	public enum SgisPointParameters : int {
		PointSizeMinSgis = ((int)0x8126)		,
		PointSizeMaxSgis = ((int)0x8127)		,
		PointFadeThresholdSizeSgis = ((int)0x8128)		,
		DistanceAttenuationSgis = ((int)0x8129)		,
	}
	public enum SgisSharpenTexture : int {
		LinearSharpenSgis = ((int)0x80AD)		,
		LinearSharpenAlphaSgis = ((int)0x80AE)		,
		LinearSharpenColorSgis = ((int)0x80AF)		,
		SharpenTextureFuncPointsSgis = ((int)0x80B0)		,
	}
	public enum SgisTexture4D : int {
		PackSkipVolumesSgis = ((int)0x8130)		,
		PackImageDepthSgis = ((int)0x8131)		,
		UnpackSkipVolumesSgis = ((int)0x8132)		,
		UnpackImageDepthSgis = ((int)0x8133)		,
		Texture4DSgis = ((int)0x8134)		,
		ProxyTexture4DSgis = ((int)0x8135)		,
		Texture4DsizeSgis = ((int)0x8136)		,
		TextureWrapQSgis = ((int)0x8137)		,
		Max4DTextureSizeSgis = ((int)0x8138)		,
		Texture4DBindingSgis = ((int)0x814F)		,
	}
	public enum SgisTextureBorderClamp : int {
		ClampToBorderSgis = ((int)0x812D)		,
	}
	[Flags]
	public enum SgisTextureColorMask : int {
		TextureColorWritemaskSgis = ((int)0x81EF)		,
	}
	public enum SgisTextureEdgeClamp : int {
		ClampToEdgeSgis = ((int)0x812F)		,
	}
	public enum SgisTextureFilter4 : int {
		Filter4Sgis = ((int)0x8146)		,
		TextureFilter4SizeSgis = ((int)0x8147)		,
	}
	public enum SgisTextureLod : int {
		TextureMinLodSgis = ((int)0x813A)		,
		TextureMaxLodSgis = ((int)0x813B)		,
		TextureBaseLevelSgis = ((int)0x813C)		,
		TextureMaxLevelSgis = ((int)0x813D)		,
	}
	public enum SgisTextureSelect : int {
		DualAlpha4Sgis = ((int)0x8110)		,
		DualAlpha8Sgis = ((int)0x8111)		,
		DualAlpha12Sgis = ((int)0x8112)		,
		DualAlpha16Sgis = ((int)0x8113)		,
		DualLuminance4Sgis = ((int)0x8114)		,
		DualLuminance8Sgis = ((int)0x8115)		,
		DualLuminance12Sgis = ((int)0x8116)		,
		DualLuminance16Sgis = ((int)0x8117)		,
		DualIntensity4Sgis = ((int)0x8118)		,
		DualIntensity8Sgis = ((int)0x8119)		,
		DualIntensity12Sgis = ((int)0x811A)		,
		DualIntensity16Sgis = ((int)0x811B)		,
		DualLuminanceAlpha4Sgis = ((int)0x811C)		,
		DualLuminanceAlpha8Sgis = ((int)0x811D)		,
		QuadAlpha4Sgis = ((int)0x811E)		,
		QuadAlpha8Sgis = ((int)0x811F)		,
		QuadLuminance4Sgis = ((int)0x8120)		,
		QuadLuminance8Sgis = ((int)0x8121)		,
		QuadIntensity4Sgis = ((int)0x8122)		,
		QuadIntensity8Sgis = ((int)0x8123)		,
		DualTextureSelectSgis = ((int)0x8124)		,
		QuadTextureSelectSgis = ((int)0x8125)		,
	}
	public enum SgiTextureColorTable : int {
		TextureColorTableSgi = ((int)0x80BC)		,
		ProxyTextureColorTableSgi = ((int)0x80BD)		,
	}
	public enum SgixAsync : int {
		AsyncMarkerSgix = ((int)0x8329)		,
	}
	public enum SgixAsyncHistogram : int {
		AsyncHistogramSgix = ((int)0x832C)		,
		MaxAsyncHistogramSgix = ((int)0x832D)		,
	}
	public enum SgixAsyncPixel : int {
		AsyncTexImageSgix = ((int)0x835C)		,
		AsyncDrawPixelsSgix = ((int)0x835D)		,
		AsyncReadPixelsSgix = ((int)0x835E)		,
		MaxAsyncTexImageSgix = ((int)0x835F)		,
		MaxAsyncDrawPixelsSgix = ((int)0x8360)		,
		MaxAsyncReadPixelsSgix = ((int)0x8361)		,
	}
	public enum SgixBlendAlphaMinmax : int {
		AlphaMinSgix = ((int)0x8320)		,
		AlphaMaxSgix = ((int)0x8321)		,
	}
	public enum SgixCalligraphicFragment : int {
		CalligraphicFragmentSgix = ((int)0x8183)		,
	}
	public enum SgixClipmap : int {
		LinearClipmapLinearSgix = ((int)0x8170)		,
		TextureClipmapCenterSgix = ((int)0x8171)		,
		TextureClipmapFrameSgix = ((int)0x8172)		,
		TextureClipmapOffsetSgix = ((int)0x8173)		,
		TextureClipmapVirtualDepthSgix = ((int)0x8174)		,
		TextureClipmapLodOffsetSgix = ((int)0x8175)		,
		TextureClipmapDepthSgix = ((int)0x8176)		,
		MaxClipmapDepthSgix = ((int)0x8177)		,
		MaxClipmapVirtualDepthSgix = ((int)0x8178)		,
		NearestClipmapNearestSgix = ((int)0x844D)		,
		NearestClipmapLinearSgix = ((int)0x844E)		,
		LinearClipmapNearestSgix = ((int)0x844F)		,
	}
	public enum SgixConvolutionAccuracy : int {
		ConvolutionHintSgix = ((int)0x8316)		,
	}
	public enum SgixDepthPassInstrument : int {
		DepthPassInstrumentSgix = ((int)0x8310)		,
		DepthPassInstrumentCountersSgix = ((int)0x8311)		,
		DepthPassInstrumentMaxSgix = ((int)0x8312)		,
	}
	public enum SgixDepthTexture : int {
		DepthComponent16Sgix = ((int)0x81A5)		,
		DepthComponent24Sgix = ((int)0x81A6)		,
		DepthComponent32Sgix = ((int)0x81A7)		,
	}
	public enum SgixFlushRaster : int {
	}
	public enum SgixFogOffset : int {
		FogOffsetSgix = ((int)0x8198)		,
		FogOffsetValueSgix = ((int)0x8199)		,
	}
	public enum SgixFogScale : int {
		FogScaleSgix = ((int)0x81FC)		,
		FogScaleValueSgix = ((int)0x81FD)		,
	}
	public enum SgixFragmentLighting : int {
		FragmentLightingSgix = ((int)0x8400)		,
		FragmentColorMaterialSgix = ((int)0x8401)		,
		FragmentColorMaterialFaceSgix = ((int)0x8402)		,
		FragmentColorMaterialParameterSgix = ((int)0x8403)		,
		MaxFragmentLightsSgix = ((int)0x8404)		,
		MaxActiveLightsSgix = ((int)0x8405)		,
		CurrentRasterNormalSgix = ((int)0x8406)		,
		LightEnvModeSgix = ((int)0x8407)		,
		FragmentLightModelLocalViewerSgix = ((int)0x8408)		,
		FragmentLightModelTwoSideSgix = ((int)0x8409)		,
		FragmentLightModelAmbientSgix = ((int)0x840A)		,
		FragmentLightModelNormalInterpolationSgix = ((int)0x840B)		,
		FragmentLight0Sgix = ((int)0x840C)		,
		FragmentLight1Sgix = ((int)0x840D)		,
		FragmentLight2Sgix = ((int)0x840E)		,
		FragmentLight3Sgix = ((int)0x840F)		,
		FragmentLight4Sgix = ((int)0x8410)		,
		FragmentLight5Sgix = ((int)0x8411)		,
		FragmentLight6Sgix = ((int)0x8412)		,
		FragmentLight7Sgix = ((int)0x8413)		,
	}
	public enum SgixFragmentsInstrument : int {
		FragmentsInstrumentSgix = ((int)0x8313)		,
		FragmentsInstrumentCountersSgix = ((int)0x8314)		,
		FragmentsInstrumentMaxSgix = ((int)0x8315)		,
	}
	public enum SgixFramezoom : int {
		FramezoomSgix = ((int)0x818B)		,
		FramezoomFactorSgix = ((int)0x818C)		,
		MaxFramezoomFactorSgix = ((int)0x818D)		,
	}
	public enum SgixIccTexture : int {
	}
	public enum SgixImpactPixelTexture : int {
		PixelTexGenQCeilingSgix = ((int)0x8184)		,
		PixelTexGenQRoundSgix = ((int)0x8185)		,
		PixelTexGenQFloorSgix = ((int)0x8186)		,
		PixelTexGenAlphaReplaceSgix = ((int)0x8187)		,
		PixelTexGenAlphaNoReplaceSgix = ((int)0x8188)		,
		PixelTexGenAlphaLsSgix = ((int)0x8189)		,
		PixelTexGenAlphaMsSgix = ((int)0x818A)		,
	}
	public enum SgixInstruments : int {
		InstrumentBufferPointerSgix = ((int)0x8180)		,
		InstrumentMeasurementsSgix = ((int)0x8181)		,
	}
	public enum SgixInterlace : int {
		InterlaceSgix = ((int)0x8094)		,
	}
	public enum SgixIrInstrument1 : int {
		IrInstrument1Sgix = ((int)0x817F)		,
	}
	public enum SgixLineQualityHint : int {
		LineQualityHintSgix = ((int)0x835B)		,
	}
	public enum SgixListPriority : int {
		ListPrioritySgix = ((int)0x8182)		,
	}
	public enum SgixPixelTexture : int {
		PixelTexGenSgix = ((int)0x8139)		,
		PixelTexGenModeSgix = ((int)0x832B)		,
	}
	public enum SgixPixelTiles : int {
		PixelTileBestAlignmentSgix = ((int)0x813E)		,
		PixelTileCacheIncrementSgix = ((int)0x813F)		,
		PixelTileWidthSgix = ((int)0x8140)		,
		PixelTileHeightSgix = ((int)0x8141)		,
		PixelTileGridWidthSgix = ((int)0x8142)		,
		PixelTileGridHeightSgix = ((int)0x8143)		,
		PixelTileGridDepthSgix = ((int)0x8144)		,
		PixelTileCacheSizeSgix = ((int)0x8145)		,
	}
	public enum SgixPolynomialFfd : int {
		GeometryDeformationSgix = ((int)0x8194)		,
		TextureDeformationSgix = ((int)0x8195)		,
		DeformationsMaskSgix = ((int)0x8196)		,
		MaxDeformationOrderSgix = ((int)0x8197)		,
	}
	public enum SgixReferencePlane : int {
		ReferencePlaneSgix = ((int)0x817D)		,
		ReferencePlaneEquationSgix = ((int)0x817E)		,
	}
	public enum SgixResample : int {
		PackResampleSgix = ((int)0x842C)		,
		UnpackResampleSgix = ((int)0x842D)		,
		ResampleReplicateSgix = ((int)0x842E)		,
		ResampleZeroFillSgix = ((int)0x842F)		,
		ResampleDecimateSgix = ((int)0x8430)		,
	}
	public enum SgixScalebiasHint : int {
		ScalebiasHintSgix = ((int)0x8322)		,
	}
	public enum SgixShadow : int {
		TextureCompareSgix = ((int)0x819A)		,
		TextureCompareOperatorSgix = ((int)0x819B)		,
		TextureLequalRSgix = ((int)0x819C)		,
		TextureGequalRSgix = ((int)0x819D)		,
	}
	public enum SgixShadowAmbient : int {
		ShadowAmbientSgix = ((int)0x80BF)		,
	}
	public enum SgixSlim : int {
		UnpackCompressedSizeSgix = ((int)0x831A)		,
		PackMaxCompressedSizeSgix = ((int)0x831B)		,
		PackCompressedSizeSgix = ((int)0x831C)		,
		Slim8uSgix = ((int)0x831D)		,
		Slim10uSgix = ((int)0x831E)		,
		Slim12sSgix = ((int)0x831F)		,
	}
	public enum SgixSprite : int {
		SpriteSgix = ((int)0x8148)		,
		SpriteModeSgix = ((int)0x8149)		,
		SpriteAxisSgix = ((int)0x814A)		,
		SpriteTranslationSgix = ((int)0x814B)		,
		SpriteAxialSgix = ((int)0x814C)		,
		SpriteObjectAlignedSgix = ((int)0x814D)		,
		SpriteEyeAlignedSgix = ((int)0x814E)		,
	}
	public enum SgixSubsample : int {
		PackSubsampleRateSgix = ((int)0x85A0)		,
		UnpackSubsampleRateSgix = ((int)0x85A1)		,
		PixelSubsample4444Sgix = ((int)0x85A2)		,
		PixelSubsample2424Sgix = ((int)0x85A3)		,
		PixelSubsample4242Sgix = ((int)0x85A4)		,
	}
	public enum SgixTagSampleBuffer : int {
	}
	public enum SgixTextureAddEnv : int {
		TextureEnvBiasSgix = ((int)0x80BE)		,
	}
	public enum SgixTextureCoordinateClamp : int {
		TextureMaxClampSSgix = ((int)0x8369)		,
		TextureMaxClampTSgix = ((int)0x836A)		,
		TextureMaxClampRSgix = ((int)0x836B)		,
		FogFactorToAlphaSgix = ((int)0x836F)		,
	}
	public enum SgixTextureLodBias : int {
		TextureLodBiasSSgix = ((int)0x818E)		,
		TextureLodBiasTSgix = ((int)0x818F)		,
		TextureLodBiasRSgix = ((int)0x8190)		,
	}
	public enum SgixTextureMultiBuffer : int {
		TextureMultiBufferHintSgix = ((int)0x812E)		,
	}
	public enum SgixTextureScaleBias : int {
		PostTextureFilterBiasSgix = ((int)0x8179)		,
		PostTextureFilterScaleSgix = ((int)0x817A)		,
		PostTextureFilterBiasRangeSgix = ((int)0x817B)		,
		PostTextureFilterScaleRangeSgix = ((int)0x817C)		,
	}
	public enum SgixVertexPreclip : int {
		VertexPreclipSgix = ((int)0x83EE)		,
		VertexPreclipHintSgix = ((int)0x83EF)		,
	}
	public enum SgixYcrcb : int {
		Ycrcb422Sgix = ((int)0x81BB)		,
		Ycrcb444Sgix = ((int)0x81BC)		,
	}
	public enum SgixYcrcba : int {
		YcrcbSgix = ((int)0x8318)		,
		YcrcbaSgix = ((int)0x8319)		,
	}
	public enum SgixYcrcbSubsample : int {
		PackSubsampleRateSgix = ((int)0x85A0)		,
		UnpackSubsampleRateSgix = ((int)0x85A1)		,
		PixelSubsample4444Sgix = ((int)0x85A2)		,
		PixelSubsample2424Sgix = ((int)0x85A3)		,
		PixelSubsample4242Sgix = ((int)0x85A4)		,
	}*/
	public enum ShaderParameter : int {
		ShaderType = ((int)0x8B4F)		,
		DeleteStatus = ((int)0x8B80)		,
		CompileStatus = ((int)0x8B81)		,
		InfoLogLength = ((int)0x8B84)		,
		ShaderSourceLength = ((int)0x8B88)		,
	}
	
	public enum ShaderPrecisionType : int {
		LowFloat = ((int)0x8DF0)		,
		MediumFloat = ((int)0x8DF1)		,
		HighFloat = ((int)0x8DF2)		,
		LowInt = ((int)0x8DF3)		,
		MediumInt = ((int)0x8DF4)		,
		HighInt = ((int)0x8DF5)		,
	}
	public enum ShaderType : int {
		FragmentShader = ((int)0x8B30)		,
		VertexShader = ((int)0x8B31)		,
		GeometryShader = ((int)0x8DD9)		,
		GeometryShaderExt = ((int)0x8DD9)		,
		TessEvaluationShader = ((int)0x8E87)		,
		TessControlShader = ((int)0x8E88)		,
        // Manual added
        ComputeShader = ((int)0x91B9),
	}
	public enum ShadingModel : int {
		Flat = ((int)0x1D00)		,
		Smooth = ((int)0x1D01)		,
	}
	public enum SizedInternalFormat : int {
		Rgba8 = ((int)0x8058)		,
		Rgba16 = ((int)0x805B)		,
		R8 = ((int)0x8229)		,
		R16 = ((int)0x822A)		,
		Rg8 = ((int)0x822B)		,
		Rg16 = ((int)0x822C)		,
		R16f = ((int)0x822D)		,
		R32f = ((int)0x822E)		,
		Rg16f = ((int)0x822F)		,
		Rg32f = ((int)0x8230)		,
		R8i = ((int)0x8231)		,
		R8ui = ((int)0x8232)		,
		R16i = ((int)0x8233)		,
		R16ui = ((int)0x8234)		,
		R32i = ((int)0x8235)		,
		R32ui = ((int)0x8236)		,
		Rg8i = ((int)0x8237)		,
		Rg8ui = ((int)0x8238)		,
		Rg16i = ((int)0x8239)		,
		Rg16ui = ((int)0x823A)		,
		Rg32i = ((int)0x823B)		,
		Rg32ui = ((int)0x823C)		,
		Rgba32f = ((int)0x8814)		,
		Rgba16f = ((int)0x881A)		,
		Rgba32ui = ((int)0x8D70)		,
		Rgba16ui = ((int)0x8D76)		,
		Rgba8ui = ((int)0x8D7C)		,
		Rgba32i = ((int)0x8D82)		,
		Rgba16i = ((int)0x8D88)		,
		Rgba8i = ((int)0x8D8E)		,
	}
	public enum StencilFace : int {
		Front = ((int)0x0404)		,
		Back = ((int)0x0405)		,
		FrontAndBack = ((int)0x0408)		,
	}
	public enum StencilFunction : int {
		Never = ((int)0x0200)		,
		Less = ((int)0x0201)		,
		Equal = ((int)0x0202)		,
		Lequal = ((int)0x0203)		,
		Greater = ((int)0x0204)		,
		Notequal = ((int)0x0205)		,
		Gequal = ((int)0x0206)		,
		Always = ((int)0x0207)		,
	}
	
	public enum StencilOp : int {
		Zero = ((int)0)		,
		Invert = ((int)0x150A)		,
		Keep = ((int)0x1E00)		,
		Replace = ((int)0x1E01)		,
		Incr = ((int)0x1E02)		,
		Decr = ((int)0x1E03)		,
		IncrWrap = ((int)0x8507)		,
		DecrWrap = ((int)0x8508)		,
	}
	public enum StringName : int {
		Vendor = ((int)0x1F00)		,
		Renderer = ((int)0x1F01)		,
		Version = ((int)0x1F02)		,
		Extensions = ((int)0x1F03)		,
		ShadingLanguageVersion = ((int)0x8B8C)		,
	}
	/*public enum SunConvolutionBorderModes : int {
		WrapBorderSun = ((int)0x81D4)		,
	}
	public enum SunGlobalAlpha : int {
		GlobalAlphaSun = ((int)0x81D9)		,
		GlobalAlphaFactorSun = ((int)0x81DA)		,
	}
	public enum SunMeshArray : int {
		QuadMeshSun = ((int)0x8614)		,
		TriangleMeshSun = ((int)0x8615)		,
	}
	public enum SunSliceAccum : int {
		SliceAccumSun = ((int)0x85CC)		,
	}
	public enum SunTriangleList : int {
		RestartSun = ((int)0x0001)		,
		ReplaceMiddleSun = ((int)0x0002)		,
		ReplaceOldestSun = ((int)0x0003)		,
		TriangleListSun = ((int)0x81D7)		,
		ReplacementCodeSun = ((int)0x81D8)		,
		ReplacementCodeArraySun = ((int)0x85C0)		,
		ReplacementCodeArrayTypeSun = ((int)0x85C1)		,
		ReplacementCodeArrayStrideSun = ((int)0x85C2)		,
		ReplacementCodeArrayPointerSun = ((int)0x85C3)		,
		R1uiV3fSun = ((int)0x85C4)		,
		R1uiC4ubV3fSun = ((int)0x85C5)		,
		R1uiC3fV3fSun = ((int)0x85C6)		,
		R1uiN3fV3fSun = ((int)0x85C7)		,
		R1uiC4fN3fV3fSun = ((int)0x85C8)		,
		R1uiT2fV3fSun = ((int)0x85C9)		,
		R1uiT2fN3fV3fSun = ((int)0x85CA)		,
		R1uiT2fC4fN3fV3fSun = ((int)0x85CB)		,
	}
	public enum SunVertex : int {
	}
	public enum SunxConstantData : int {
		UnpackConstantDataSunx = ((int)0x81D5)		,
		TextureConstantDataSunx = ((int)0x81D6)		,
	}
	public enum SunxGeneralTriangleList : int {
		RestartSun = ((int)0x0001)		,
		ReplaceMiddleSun = ((int)0x0002)		,
		ReplaceOldestSun = ((int)0x0003)		,
		WrapBorderSun = ((int)0x81D4)		,
		TriangleListSun = ((int)0x81D7)		,
		ReplacementCodeSun = ((int)0x81D8)		,
		ReplacementCodeArraySun = ((int)0x85C0)		,
		ReplacementCodeArrayTypeSun = ((int)0x85C1)		,
		ReplacementCodeArrayStrideSun = ((int)0x85C2)		,
		ReplacementCodeArrayPointerSun = ((int)0x85C3)		,
		R1uiV3fSun = ((int)0x85C4)		,
		R1uiC4ubV3fSun = ((int)0x85C5)		,
		R1uiC3fV3fSun = ((int)0x85C6)		,
		R1uiN3fV3fSun = ((int)0x85C7)		,
		R1uiC4fN3fV3fSun = ((int)0x85C8)		,
		R1uiT2fV3fSun = ((int)0x85C9)		,
		R1uiT2fN3fV3fSun = ((int)0x85CA)		,
		R1uiT2fC4fN3fV3fSun = ((int)0x85CB)		,
	}*/
	public enum TexCoordPointerType : int {
		Short = ((int)0x1402)		,
		Int = ((int)0x1404)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		HalfFloat = ((int)0x140B)		,
		UnsignedInt2101010Rev = ((int)0x8368)		,
		Int2101010Rev = ((int)0x8D9F)		,
	}
	public enum TextureBufferTarget : int {
		TextureBuffer = ((int)0x8C2A)		,
	}
	public enum TextureCompareMode : int {
		None = ((int)0)		,
		CompareRefToTexture = ((int)0x884E)		,
		CompareRToTexture = ((int)0x884E)		,
	}
	public enum TextureCoordName : int {
		S = ((int)0x2000)		,
		T = ((int)0x2001)		,
		R = ((int)0x2002)		,
		Q = ((int)0x2003)		,
	}
	public enum TextureEnvMode : int {
		Add = ((int)0x0104)		,
		Blend = ((int)0x0BE2)		,
		Replace = ((int)0x1E01)		,
		Modulate = ((int)0x2100)		,
		Decal = ((int)0x2101)		,
		ReplaceExt = ((int)0x8062)		,
		TextureEnvBiasSgix = ((int)0x80BE)		,
		Combine = ((int)0x8570)		,
	}
	public enum TextureEnvModeCombine : int {
		Add = ((int)0x0104)		,
		Replace = ((int)0x1E01)		,
		Modulate = ((int)0x2100)		,
		Subtract = ((int)0x84E7)		,
		AddSigned = ((int)0x8574)		,
		Interpolate = ((int)0x8575)		,
		Dot3Rgb = ((int)0x86AE)		,
		Dot3Rgba = ((int)0x86AF)		,
	}
	public enum TextureEnvModeOperandAlpha : int {
		SrcAlpha = ((int)0x0302)		,
		OneMinusSrcAlpha = ((int)0x0303)		,
	}
	public enum TextureEnvModeOperandRgb : int {
		SrcColor = ((int)0x0300)		,
		OneMinusSrcColor = ((int)0x0301)		,
		SrcAlpha = ((int)0x0302)		,
		OneMinusSrcAlpha = ((int)0x0303)		,
	}
	public enum TextureEnvModePointSprite : int {
		False = ((int)0)		,
		True = ((int)1)		,
	}
	public enum TextureEnvModeScale : int {
		One = ((int)1)		,
		Two = ((int)2)		,
		Four = ((int)4)		,
	}
	public enum TextureEnvModeSource : int {
		Texture = ((int)0x1702)		,
		Texture0 = ((int)0x84C0)		,
		Texture1 = ((int)0x84C1)		,
		Texture2 = ((int)0x84C2)		,
		Texture3 = ((int)0x84C3)		,
		Texture4 = ((int)0x84C4)		,
		Texture5 = ((int)0x84C5)		,
		Texture6 = ((int)0x84C6)		,
		Texture7 = ((int)0x84C7)		,
		Texture8 = ((int)0x84C8)		,
		Texture9 = ((int)0x84C9)		,
		Texture10 = ((int)0x84CA)		,
		Texture11 = ((int)0x84CB)		,
		Texture12 = ((int)0x84CC)		,
		Texture13 = ((int)0x84CD)		,
		Texture14 = ((int)0x84CE)		,
		Texture15 = ((int)0x84CF)		,
		Texture16 = ((int)0x84D0)		,
		Texture17 = ((int)0x84D1)		,
		Texture18 = ((int)0x84D2)		,
		Texture19 = ((int)0x84D3)		,
		Texture20 = ((int)0x84D4)		,
		Texture21 = ((int)0x84D5)		,
		Texture22 = ((int)0x84D6)		,
		Texture23 = ((int)0x84D7)		,
		Texture24 = ((int)0x84D8)		,
		Texture25 = ((int)0x84D9)		,
		Texture26 = ((int)0x84DA)		,
		Texture27 = ((int)0x84DB)		,
		Texture28 = ((int)0x84DC)		,
		Texture29 = ((int)0x84DD)		,
		Texture30 = ((int)0x84DE)		,
		Texture31 = ((int)0x84DF)		,
		Constant = ((int)0x8576)		,
		PrimaryColor = ((int)0x8577)		,
		Previous = ((int)0x8578)		,
	}
	public enum TextureEnvParameter : int {
		AlphaScale = ((int)0x0D1C)		,
		TextureEnvMode = ((int)0x2200)		,
		TextureEnvColor = ((int)0x2201)		,
		TextureLodBias = ((int)0x8501)		,
		CombineRgb = ((int)0x8571)		,
		CombineAlpha = ((int)0x8572)		,
		RgbScale = ((int)0x8573)		,
		Source0Rgb = ((int)0x8580)		,
		Src1Rgb = ((int)0x8581)		,
		Src2Rgb = ((int)0x8582)		,
		Src0Alpha = ((int)0x8588)		,
		Src1Alpha = ((int)0x8589)		,
		Src2Alpha = ((int)0x858A)		,
		Operand0Rgb = ((int)0x8590)		,
		Operand1Rgb = ((int)0x8591)		,
		Operand2Rgb = ((int)0x8592)		,
		Operand0Alpha = ((int)0x8598)		,
		Operand1Alpha = ((int)0x8599)		,
		Operand2Alpha = ((int)0x859A)		,
		CoordReplace = ((int)0x8862)		,
	}
	public enum TextureEnvTarget : int {
		TextureEnv = ((int)0x2300)		,
		TextureFilterControl = ((int)0x8500)		,
		PointSprite = ((int)0x8861)		,
	}
	public enum TextureFilterFuncSgis : int {
		Filter4Sgis = ((int)0x8146)		,
	}
	public enum TextureGenMode : int {
		EyeLinear = ((int)0x2400)		,
		ObjectLinear = ((int)0x2401)		,
		SphereMap = ((int)0x2402)		,
		EyeDistanceToPointSgis = ((int)0x81F0)		,
		ObjectDistanceToPointSgis = ((int)0x81F1)		,
		EyeDistanceToLineSgis = ((int)0x81F2)		,
		ObjectDistanceToLineSgis = ((int)0x81F3)		,
		NormalMap = ((int)0x8511)		,
		ReflectionMap = ((int)0x8512)		,
	}
	public enum TextureGenParameter : int {
		TextureGenMode = ((int)0x2500)		,
		ObjectPlane = ((int)0x2501)		,
		EyePlane = ((int)0x2502)		,
		EyePointSgis = ((int)0x81F4)		,
		ObjectPointSgis = ((int)0x81F5)		,
		EyeLineSgis = ((int)0x81F6)		,
		ObjectLineSgis = ((int)0x81F7)		,
	}
	public enum TextureMagFilter : int {
		Nearest = ((int)0x2600)		,
		Linear = ((int)0x2601)		,
		LinearDetailSgis = ((int)0x8097)		,
		LinearDetailAlphaSgis = ((int)0x8098)		,
		LinearDetailColorSgis = ((int)0x8099)		,
		LinearSharpenSgis = ((int)0x80AD)		,
		LinearSharpenAlphaSgis = ((int)0x80AE)		,
		LinearSharpenColorSgis = ((int)0x80AF)		,
		Filter4Sgis = ((int)0x8146)		,
		PixelTexGenQCeilingSgix = ((int)0x8184)		,
		PixelTexGenQRoundSgix = ((int)0x8185)		,
		PixelTexGenQFloorSgix = ((int)0x8186)		,
	}
	public enum TextureMinFilter : int {
		Nearest = ((int)0x2600)		,
		Linear = ((int)0x2601)		,
		NearestMipmapNearest = ((int)0x2700)		,
		LinearMipmapNearest = ((int)0x2701)		,
		NearestMipmapLinear = ((int)0x2702)		,
		LinearMipmapLinear = ((int)0x2703)		,
		Filter4Sgis = ((int)0x8146)		,
		LinearClipmapLinearSgix = ((int)0x8170)		,
		PixelTexGenQCeilingSgix = ((int)0x8184)		,
		PixelTexGenQRoundSgix = ((int)0x8185)		,
		PixelTexGenQFloorSgix = ((int)0x8186)		,
		NearestClipmapNearestSgix = ((int)0x844D)		,
		NearestClipmapLinearSgix = ((int)0x844E)		,
		LinearClipmapNearestSgix = ((int)0x844F)		,
	}
	public enum TextureParameterName : int {
		TextureBorderColor = ((int)0x1004)		,
		TextureMagFilter = ((int)0x2800)		,
		TextureMinFilter = ((int)0x2801)		,
		TextureWrapS = ((int)0x2802)		,
		TextureWrapT = ((int)0x2803)		,
		TexturePriority = ((int)0x8066)		,
		TextureDepth = ((int)0x8071)		,
		TextureWrapR = ((int)0x8072)		,
		TextureWrapRExt = ((int)0x8072)		,
		DetailTextureLevelSgis = ((int)0x809A)		,
		DetailTextureModeSgis = ((int)0x809B)		,
		ShadowAmbientSgix = ((int)0x80BF)		,
		TextureCompareFailValue = ((int)0x80BF)		,
		DualTextureSelectSgis = ((int)0x8124)		,
		QuadTextureSelectSgis = ((int)0x8125)		,
		ClampToBorder = ((int)0x812D)		,
		ClampToEdge = ((int)0x812F)		,
		TextureWrapQSgis = ((int)0x8137)		,
		TextureMinLod = ((int)0x813A)		,
		TextureMaxLod = ((int)0x813B)		,
		TextureBaseLevel = ((int)0x813C)		,
		TextureMaxLevel = ((int)0x813D)		,
		TextureClipmapCenterSgix = ((int)0x8171)		,
		TextureClipmapFrameSgix = ((int)0x8172)		,
		TextureClipmapOffsetSgix = ((int)0x8173)		,
		TextureClipmapVirtualDepthSgix = ((int)0x8174)		,
		TextureClipmapLodOffsetSgix = ((int)0x8175)		,
		TextureClipmapDepthSgix = ((int)0x8176)		,
		PostTextureFilterBiasSgix = ((int)0x8179)		,
		PostTextureFilterScaleSgix = ((int)0x817A)		,
		TextureLodBiasSSgix = ((int)0x818E)		,
		TextureLodBiasTSgix = ((int)0x818F)		,
		TextureLodBiasRSgix = ((int)0x8190)		,
		GenerateMipmap = ((int)0x8191)		,
		GenerateMipmapSgis = ((int)0x8191)		,
		TextureCompareSgix = ((int)0x819A)		,
		TextureCompareOperatorSgix = ((int)0x819B)		,
		TextureMaxClampSSgix = ((int)0x8369)		,
		TextureMaxClampTSgix = ((int)0x836A)		,
		TextureMaxClampRSgix = ((int)0x836B)		,
		TextureLodBias = ((int)0x8501)		,
		DepthTextureMode = ((int)0x884B)		,
		TextureCompareMode = ((int)0x884C)		,
		TextureCompareFunc = ((int)0x884D)		,
		TextureSwizzleR = ((int)0x8E42)		,
		TextureSwizzleG = ((int)0x8E43)		,
		TextureSwizzleB = ((int)0x8E44)		,
		TextureSwizzleA = ((int)0x8E45)		,
		TextureSwizzleRgba = ((int)0x8E46)		,
	}
	public enum TextureTarget : int {
		Texture1D = ((int)0x0DE0)		,
		Texture2D = ((int)0x0DE1)		,
		ProxyTexture1D = ((int)0x8063)		,
		ProxyTexture2D = ((int)0x8064)		,
		Texture3D = ((int)0x806F)		,
		Texture3DExt = ((int)0x806F)		,
		ProxyTexture3D = ((int)0x8070)		,
		ProxyTexture3DExt = ((int)0x8070)		,
		DetailTexture2DSgis = ((int)0x8095)		,
		Texture4DSgis = ((int)0x8134)		,
		ProxyTexture4DSgis = ((int)0x8135)		,
		TextureMinLodSgis = ((int)0x813A)		,
		TextureMaxLodSgis = ((int)0x813B)		,
		TextureBaseLevelSgis = ((int)0x813C)		,
		TextureMaxLevelSgis = ((int)0x813D)		,
		TextureRectangle = ((int)0x84F5)		,
		TextureRectangleArb = ((int)0x84F5)		,
		TextureRectangleNv = ((int)0x84F5)		,
		ProxyTextureRectangle = ((int)0x84F7)		,
		TextureCubeMap = ((int)0x8513)		,
		TextureBindingCubeMap = ((int)0x8514)		,
		TextureCubeMapPositiveX = ((int)0x8515)		,
		TextureCubeMapNegativeX = ((int)0x8516)		,
		TextureCubeMapPositiveY = ((int)0x8517)		,
		TextureCubeMapNegativeY = ((int)0x8518)		,
		TextureCubeMapPositiveZ = ((int)0x8519)		,
		TextureCubeMapNegativeZ = ((int)0x851A)		,
		ProxyTextureCubeMap = ((int)0x851B)		,
		Texture1DArray = ((int)0x8C18)		,
		ProxyTexture1DArray = ((int)0x8C19)		,
		Texture2DArray = ((int)0x8C1A)		,
		ProxyTexture2DArray = ((int)0x8C1B)		,
		TextureBuffer = ((int)0x8C2A)		,
		TextureCubeMapArray = ((int)0x9009)		,
		ProxyTextureCubeMapArray = ((int)0x900B)		,
		Texture2DMultisample = ((int)0x9100)		,
		ProxyTexture2DMultisample = ((int)0x9101)		,
		Texture2DMultisampleArray = ((int)0x9102)		,
		ProxyTexture2DMultisampleArray = ((int)0x9103)		,
	}
	public enum TextureTargetMultisample : int {
		Texture2DMultisample = ((int)0x9100)		,
		ProxyTexture2DMultisample = ((int)0x9101)		,
		Texture2DMultisampleArray = ((int)0x9102)		,
		ProxyTexture2DMultisampleArray = ((int)0x9103)		,
	}
	public enum TextureUnit : int {
		Texture0 = ((int)0x84C0)		,
		Texture1 = ((int)0x84C1)		,
		Texture2 = ((int)0x84C2)		,
		Texture3 = ((int)0x84C3)		,
		Texture4 = ((int)0x84C4)		,
		Texture5 = ((int)0x84C5)		,
		Texture6 = ((int)0x84C6)		,
		Texture7 = ((int)0x84C7)		,
		Texture8 = ((int)0x84C8)		,
		Texture9 = ((int)0x84C9)		,
		Texture10 = ((int)0x84CA)		,
		Texture11 = ((int)0x84CB)		,
		Texture12 = ((int)0x84CC)		,
		Texture13 = ((int)0x84CD)		,
		Texture14 = ((int)0x84CE)		,
		Texture15 = ((int)0x84CF)		,
		Texture16 = ((int)0x84D0)		,
		Texture17 = ((int)0x84D1)		,
		Texture18 = ((int)0x84D2)		,
		Texture19 = ((int)0x84D3)		,
		Texture20 = ((int)0x84D4)		,
		Texture21 = ((int)0x84D5)		,
		Texture22 = ((int)0x84D6)		,
		Texture23 = ((int)0x84D7)		,
		Texture24 = ((int)0x84D8)		,
		Texture25 = ((int)0x84D9)		,
		Texture26 = ((int)0x84DA)		,
		Texture27 = ((int)0x84DB)		,
		Texture28 = ((int)0x84DC)		,
		Texture29 = ((int)0x84DD)		,
		Texture30 = ((int)0x84DE)		,
		Texture31 = ((int)0x84DF)		,
	}
	public enum TextureWrapMode : int {
		Clamp = ((int)0x2900)		,
		Repeat = ((int)0x2901)		,
		ClampToBorder = ((int)0x812D)		,
		ClampToBorderSgis = ((int)0x812D)		,
		ClampToEdge = ((int)0x812F)		,
		ClampToEdgeSgis = ((int)0x812F)		,
		MirroredRepeat = ((int)0x8370)		,
	}
	public enum TransformFeedbackMode : int {
		InterleavedAttribs = ((int)0x8C8C)		,
		SeparateAttribs = ((int)0x8C8D)		,
	}
	public enum TransformFeedbackTarget : int {
		TransformFeedback = ((int)0x8E22)		,
	}
	/*public enum Version11 : int {
		False = ((int)0)		,
		NoError = ((int)0)		,
		None = ((int)0)		,
		Zero = ((int)0)		,
		Points = ((int)0x0000)		,
		DepthBufferBit = ((int)0x00000100)		,
		StencilBufferBit = ((int)0x00000400)		,
		ColorBufferBit = ((int)0x00004000)		,
		Lines = ((int)0x0001)		,
		LineLoop = ((int)0x0002)		,
		LineStrip = ((int)0x0003)		,
		Triangles = ((int)0x0004)		,
		TriangleStrip = ((int)0x0005)		,
		TriangleFan = ((int)0x0006)		,
		Never = ((int)0x0200)		,
		Less = ((int)0x0201)		,
		Equal = ((int)0x0202)		,
		Lequal = ((int)0x0203)		,
		Greater = ((int)0x0204)		,
		Notequal = ((int)0x0205)		,
		Gequal = ((int)0x0206)		,
		Always = ((int)0x0207)		,
		SrcColor = ((int)0x0300)		,
		OneMinusSrcColor = ((int)0x0301)		,
		SrcAlpha = ((int)0x0302)		,
		OneMinusSrcAlpha = ((int)0x0303)		,
		DstAlpha = ((int)0x0304)		,
		OneMinusDstAlpha = ((int)0x0305)		,
		DstColor = ((int)0x0306)		,
		OneMinusDstColor = ((int)0x0307)		,
		SrcAlphaSaturate = ((int)0x0308)		,
		FrontLeft = ((int)0x0400)		,
		FrontRight = ((int)0x0401)		,
		BackLeft = ((int)0x0402)		,
		BackRight = ((int)0x0403)		,
		Front = ((int)0x0404)		,
		Back = ((int)0x0405)		,
		Left = ((int)0x0406)		,
		Right = ((int)0x0407)		,
		FrontAndBack = ((int)0x0408)		,
		InvalidEnum = ((int)0x0500)		,
		InvalidValue = ((int)0x0501)		,
		InvalidOperation = ((int)0x0502)		,
		OutOfMemory = ((int)0x0505)		,
		Cw = ((int)0x0900)		,
		Ccw = ((int)0x0901)		,
		PointSize = ((int)0x0B11)		,
		PointSizeRange = ((int)0x0B12)		,
		PointSizeGranularity = ((int)0x0B13)		,
		LineSmooth = ((int)0x0B20)		,
		LineWidth = ((int)0x0B21)		,
		LineWidthRange = ((int)0x0B22)		,
		LineWidthGranularity = ((int)0x0B23)		,
		PolygonSmooth = ((int)0x0B41)		,
		CullFace = ((int)0x0B44)		,
		CullFaceMode = ((int)0x0B45)		,
		FrontFace = ((int)0x0B46)		,
		DepthRange = ((int)0x0B70)		,
		DepthTest = ((int)0x0B71)		,
		DepthWritemask = ((int)0x0B72)		,
		DepthClearValue = ((int)0x0B73)		,
		DepthFunc = ((int)0x0B74)		,
		StencilTest = ((int)0x0B90)		,
		StencilClearValue = ((int)0x0B91)		,
		StencilFunc = ((int)0x0B92)		,
		StencilValueMask = ((int)0x0B93)		,
		StencilFail = ((int)0x0B94)		,
		StencilPassDepthFail = ((int)0x0B95)		,
		StencilPassDepthPass = ((int)0x0B96)		,
		StencilRef = ((int)0x0B97)		,
		StencilWritemask = ((int)0x0B98)		,
		Viewport = ((int)0x0BA2)		,
		Dither = ((int)0x0BD0)		,
		BlendDst = ((int)0x0BE0)		,
		BlendSrc = ((int)0x0BE1)		,
		Blend = ((int)0x0BE2)		,
		LogicOpMode = ((int)0x0BF0)		,
		ColorLogicOp = ((int)0x0BF2)		,
		DrawBuffer = ((int)0x0C01)		,
		ReadBuffer = ((int)0x0C02)		,
		ScissorBox = ((int)0x0C10)		,
		ScissorTest = ((int)0x0C11)		,
		ColorClearValue = ((int)0x0C22)		,
		ColorWritemask = ((int)0x0C23)		,
		Doublebuffer = ((int)0x0C32)		,
		Stereo = ((int)0x0C33)		,
		LineSmoothHint = ((int)0x0C52)		,
		PolygonSmoothHint = ((int)0x0C53)		,
		UnpackSwapBytes = ((int)0x0CF0)		,
		UnpackLsbFirst = ((int)0x0CF1)		,
		UnpackRowLength = ((int)0x0CF2)		,
		UnpackSkipRows = ((int)0x0CF3)		,
		UnpackSkipPixels = ((int)0x0CF4)		,
		UnpackAlignment = ((int)0x0CF5)		,
		PackSwapBytes = ((int)0x0D00)		,
		PackLsbFirst = ((int)0x0D01)		,
		PackRowLength = ((int)0x0D02)		,
		PackSkipRows = ((int)0x0D03)		,
		PackSkipPixels = ((int)0x0D04)		,
		PackAlignment = ((int)0x0D05)		,
		MaxTextureSize = ((int)0x0D33)		,
		MaxViewportDims = ((int)0x0D3A)		,
		SubpixelBits = ((int)0x0D50)		,
		Texture1D = ((int)0x0DE0)		,
		Texture2D = ((int)0x0DE1)		,
		TextureWidth = ((int)0x1000)		,
		TextureHeight = ((int)0x1001)		,
		TextureInternalFormat = ((int)0x1003)		,
		TextureBorderColor = ((int)0x1004)		,
		DontCare = ((int)0x1100)		,
		Fastest = ((int)0x1101)		,
		Nicest = ((int)0x1102)		,
		Byte = ((int)0x1400)		,
		UnsignedByte = ((int)0x1401)		,
		Short = ((int)0x1402)		,
		UnsignedShort = ((int)0x1403)		,
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		Clear = ((int)0x1500)		,
		And = ((int)0x1501)		,
		AndReverse = ((int)0x1502)		,
		Copy = ((int)0x1503)		,
		AndInverted = ((int)0x1504)		,
		Noop = ((int)0x1505)		,
		Xor = ((int)0x1506)		,
		Or = ((int)0x1507)		,
		Nor = ((int)0x1508)		,
		Equiv = ((int)0x1509)		,
		Invert = ((int)0x150A)		,
		OrReverse = ((int)0x150B)		,
		CopyInverted = ((int)0x150C)		,
		OrInverted = ((int)0x150D)		,
		Nand = ((int)0x150E)		,
		Set = ((int)0x150F)		,
		Texture = ((int)0x1702)		,
		Color = ((int)0x1800)		,
		Depth = ((int)0x1801)		,
		Stencil = ((int)0x1802)		,
		StencilIndex = ((int)0x1901)		,
		DepthComponent = ((int)0x1902)		,
		Red = ((int)0x1903)		,
		Green = ((int)0x1904)		,
		Blue = ((int)0x1905)		,
		Alpha = ((int)0x1906)		,
		Rgb = ((int)0x1907)		,
		Rgba = ((int)0x1908)		,
		Point = ((int)0x1B00)		,
		Line = ((int)0x1B01)		,
		Fill = ((int)0x1B02)		,
		Keep = ((int)0x1E00)		,
		Replace = ((int)0x1E01)		,
		Incr = ((int)0x1E02)		,
		Decr = ((int)0x1E03)		,
		Vendor = ((int)0x1F00)		,
		Renderer = ((int)0x1F01)		,
		Version = ((int)0x1F02)		,
		Extensions = ((int)0x1F03)		,
		Nearest = ((int)0x2600)		,
		Linear = ((int)0x2601)		,
		NearestMipmapNearest = ((int)0x2700)		,
		LinearMipmapNearest = ((int)0x2701)		,
		NearestMipmapLinear = ((int)0x2702)		,
		LinearMipmapLinear = ((int)0x2703)		,
		TextureMagFilter = ((int)0x2800)		,
		TextureMinFilter = ((int)0x2801)		,
		TextureWrapS = ((int)0x2802)		,
		TextureWrapT = ((int)0x2803)		,
		Repeat = ((int)0x2901)		,
		PolygonOffsetUnits = ((int)0x2A00)		,
		PolygonOffsetPoint = ((int)0x2A01)		,
		PolygonOffsetLine = ((int)0x2A02)		,
		R3G3B2 = ((int)0x2A10)		,
		PolygonOffsetFill = ((int)0x8037)		,
		PolygonOffsetFactor = ((int)0x8038)		,
		Rgb4 = ((int)0x804F)		,
		Rgb5 = ((int)0x8050)		,
		Rgb8 = ((int)0x8051)		,
		Rgb10 = ((int)0x8052)		,
		Rgb12 = ((int)0x8053)		,
		Rgb16 = ((int)0x8054)		,
		Rgba2 = ((int)0x8055)		,
		Rgba4 = ((int)0x8056)		,
		Rgb5A1 = ((int)0x8057)		,
		Rgba8 = ((int)0x8058)		,
		Rgb10A2 = ((int)0x8059)		,
		Rgba12 = ((int)0x805A)		,
		Rgba16 = ((int)0x805B)		,
		TextureRedSize = ((int)0x805C)		,
		TextureGreenSize = ((int)0x805D)		,
		TextureBlueSize = ((int)0x805E)		,
		TextureAlphaSize = ((int)0x805F)		,
		ProxyTexture1D = ((int)0x8063)		,
		ProxyTexture2D = ((int)0x8064)		,
		TextureBinding1D = ((int)0x8068)		,
		TextureBinding2D = ((int)0x8069)		,
		One = ((int)1)		,
		True = ((int)1)		,
	}
	public enum Version11Deprecated : int {
		ClientPixelStoreBit = ((int)0x00000001)		,
		CurrentBit = ((int)0x00000001)		,
		ClientVertexArrayBit = ((int)0x00000002)		,
		PointBit = ((int)0x00000002)		,
		LineBit = ((int)0x00000004)		,
		PolygonBit = ((int)0x00000008)		,
		PolygonStippleBit = ((int)0x00000010)		,
		PixelModeBit = ((int)0x00000020)		,
		LightingBit = ((int)0x00000040)		,
		FogBit = ((int)0x00000080)		,
		AccumBufferBit = ((int)0x00000200)		,
		ViewportBit = ((int)0x00000800)		,
		TransformBit = ((int)0x00001000)		,
		EnableBit = ((int)0x00002000)		,
		HintBit = ((int)0x00008000)		,
		EvalBit = ((int)0x00010000)		,
		ListBit = ((int)0x00020000)		,
		TextureBit = ((int)0x00040000)		,
		Quads = ((int)0x0007)		,
		QuadStrip = ((int)0x0008)		,
		ScissorBit = ((int)0x00080000)		,
		Polygon = ((int)0x0009)		,
		Accum = ((int)0x0100)		,
		Load = ((int)0x0101)		,
		Return = ((int)0x0102)		,
		Mult = ((int)0x0103)		,
		Add = ((int)0x0104)		,
		Aux0 = ((int)0x0409)		,
		Aux1 = ((int)0x040A)		,
		Aux2 = ((int)0x040B)		,
		Aux3 = ((int)0x040C)		,
		StackOverflow = ((int)0x0503)		,
		StackUnderflow = ((int)0x0504)		,
		Gl2D = ((int)0x0600)		,
		Gl3D = ((int)0x0601)		,
		Gl3DColor = ((int)0x0602)		,
		Gl3DColorTexture = ((int)0x0603)		,
		Gl4DColorTexture = ((int)0x0604)		,
		PassThroughToken = ((int)0x0700)		,
		PointToken = ((int)0x0701)		,
		LineToken = ((int)0x0702)		,
		PolygonToken = ((int)0x0703)		,
		BitmapToken = ((int)0x0704)		,
		DrawPixelToken = ((int)0x0705)		,
		CopyPixelToken = ((int)0x0706)		,
		LineResetToken = ((int)0x0707)		,
		Exp = ((int)0x0800)		,
		Exp2 = ((int)0x0801)		,
		Coeff = ((int)0x0A00)		,
		Order = ((int)0x0A01)		,
		Domain = ((int)0x0A02)		,
		CurrentColor = ((int)0x0B00)		,
		CurrentIndex = ((int)0x0B01)		,
		CurrentNormal = ((int)0x0B02)		,
		CurrentTextureCoords = ((int)0x0B03)		,
		CurrentRasterColor = ((int)0x0B04)		,
		CurrentRasterIndex = ((int)0x0B05)		,
		CurrentRasterTextureCoords = ((int)0x0B06)		,
		CurrentRasterPosition = ((int)0x0B07)		,
		CurrentRasterPositionValid = ((int)0x0B08)		,
		CurrentRasterDistance = ((int)0x0B09)		,
		PointSmooth = ((int)0x0B10)		,
		LineStipple = ((int)0x0B24)		,
		LineStipplePattern = ((int)0x0B25)		,
		LineStippleRepeat = ((int)0x0B26)		,
		ListMode = ((int)0x0B30)		,
		MaxListNesting = ((int)0x0B31)		,
		ListBase = ((int)0x0B32)		,
		ListIndex = ((int)0x0B33)		,
		PolygonMode = ((int)0x0B40)		,
		PolygonStipple = ((int)0x0B42)		,
		EdgeFlag = ((int)0x0B43)		,
		Lighting = ((int)0x0B50)		,
		LightModelLocalViewer = ((int)0x0B51)		,
		LightModelTwoSide = ((int)0x0B52)		,
		LightModelAmbient = ((int)0x0B53)		,
		ShadeModel = ((int)0x0B54)		,
		ColorMaterialFace = ((int)0x0B55)		,
		ColorMaterialParameter = ((int)0x0B56)		,
		ColorMaterial = ((int)0x0B57)		,
		Fog = ((int)0x0B60)		,
		FogIndex = ((int)0x0B61)		,
		FogDensity = ((int)0x0B62)		,
		FogStart = ((int)0x0B63)		,
		FogEnd = ((int)0x0B64)		,
		FogMode = ((int)0x0B65)		,
		FogColor = ((int)0x0B66)		,
		AccumClearValue = ((int)0x0B80)		,
		MatrixMode = ((int)0x0BA0)		,
		Normalize = ((int)0x0BA1)		,
		ModelviewStackDepth = ((int)0x0BA3)		,
		ProjectionStackDepth = ((int)0x0BA4)		,
		TextureStackDepth = ((int)0x0BA5)		,
		ModelviewMatrix = ((int)0x0BA6)		,
		ProjectionMatrix = ((int)0x0BA7)		,
		TextureMatrix = ((int)0x0BA8)		,
		AttribStackDepth = ((int)0x0BB0)		,
		ClientAttribStackDepth = ((int)0x0BB1)		,
		AlphaTest = ((int)0x0BC0)		,
		AlphaTestFunc = ((int)0x0BC1)		,
		AlphaTestRef = ((int)0x0BC2)		,
		IndexLogicOp = ((int)0x0BF1)		,
		LogicOp = ((int)0x0BF1)		,
		AuxBuffers = ((int)0x0C00)		,
		IndexClearValue = ((int)0x0C20)		,
		IndexWritemask = ((int)0x0C21)		,
		IndexMode = ((int)0x0C30)		,
		RgbaMode = ((int)0x0C31)		,
		RenderMode = ((int)0x0C40)		,
		PerspectiveCorrectionHint = ((int)0x0C50)		,
		PointSmoothHint = ((int)0x0C51)		,
		FogHint = ((int)0x0C54)		,
		TextureGenS = ((int)0x0C60)		,
		TextureGenT = ((int)0x0C61)		,
		TextureGenR = ((int)0x0C62)		,
		TextureGenQ = ((int)0x0C63)		,
		PixelMapIToI = ((int)0x0C70)		,
		PixelMapSToS = ((int)0x0C71)		,
		PixelMapIToR = ((int)0x0C72)		,
		PixelMapIToG = ((int)0x0C73)		,
		PixelMapIToB = ((int)0x0C74)		,
		PixelMapIToA = ((int)0x0C75)		,
		PixelMapRToR = ((int)0x0C76)		,
		PixelMapGToG = ((int)0x0C77)		,
		PixelMapBToB = ((int)0x0C78)		,
		PixelMapAToA = ((int)0x0C79)		,
		PixelMapIToISize = ((int)0x0CB0)		,
		PixelMapSToSSize = ((int)0x0CB1)		,
		PixelMapIToRSize = ((int)0x0CB2)		,
		PixelMapIToGSize = ((int)0x0CB3)		,
		PixelMapIToBSize = ((int)0x0CB4)		,
		PixelMapIToASize = ((int)0x0CB5)		,
		PixelMapRToRSize = ((int)0x0CB6)		,
		PixelMapGToGSize = ((int)0x0CB7)		,
		PixelMapBToBSize = ((int)0x0CB8)		,
		PixelMapAToASize = ((int)0x0CB9)		,
		MapColor = ((int)0x0D10)		,
		MapStencil = ((int)0x0D11)		,
		IndexShift = ((int)0x0D12)		,
		IndexOffset = ((int)0x0D13)		,
		RedScale = ((int)0x0D14)		,
		RedBias = ((int)0x0D15)		,
		ZoomX = ((int)0x0D16)		,
		ZoomY = ((int)0x0D17)		,
		GreenScale = ((int)0x0D18)		,
		GreenBias = ((int)0x0D19)		,
		BlueScale = ((int)0x0D1A)		,
		BlueBias = ((int)0x0D1B)		,
		AlphaScale = ((int)0x0D1C)		,
		AlphaBias = ((int)0x0D1D)		,
		DepthScale = ((int)0x0D1E)		,
		DepthBias = ((int)0x0D1F)		,
		MaxEvalOrder = ((int)0x0D30)		,
		MaxLights = ((int)0x0D31)		,
		MaxClipPlanes = ((int)0x0D32)		,
		MaxPixelMapTable = ((int)0x0D34)		,
		MaxAttribStackDepth = ((int)0x0D35)		,
		MaxModelviewStackDepth = ((int)0x0D36)		,
		MaxNameStackDepth = ((int)0x0D37)		,
		MaxProjectionStackDepth = ((int)0x0D38)		,
		MaxTextureStackDepth = ((int)0x0D39)		,
		MaxClientAttribStackDepth = ((int)0x0D3B)		,
		IndexBits = ((int)0x0D51)		,
		RedBits = ((int)0x0D52)		,
		GreenBits = ((int)0x0D53)		,
		BlueBits = ((int)0x0D54)		,
		AlphaBits = ((int)0x0D55)		,
		DepthBits = ((int)0x0D56)		,
		StencilBits = ((int)0x0D57)		,
		AccumRedBits = ((int)0x0D58)		,
		AccumGreenBits = ((int)0x0D59)		,
		AccumBlueBits = ((int)0x0D5A)		,
		AccumAlphaBits = ((int)0x0D5B)		,
		NameStackDepth = ((int)0x0D70)		,
		AutoNormal = ((int)0x0D80)		,
		Map1Color4 = ((int)0x0D90)		,
		Map1Index = ((int)0x0D91)		,
		Map1Normal = ((int)0x0D92)		,
		Map1TextureCoord1 = ((int)0x0D93)		,
		Map1TextureCoord2 = ((int)0x0D94)		,
		Map1TextureCoord3 = ((int)0x0D95)		,
		Map1TextureCoord4 = ((int)0x0D96)		,
		Map1Vertex3 = ((int)0x0D97)		,
		Map1Vertex4 = ((int)0x0D98)		,
		Map2Color4 = ((int)0x0DB0)		,
		Map2Index = ((int)0x0DB1)		,
		Map2Normal = ((int)0x0DB2)		,
		Map2TextureCoord1 = ((int)0x0DB3)		,
		Map2TextureCoord2 = ((int)0x0DB4)		,
		Map2TextureCoord3 = ((int)0x0DB5)		,
		Map2TextureCoord4 = ((int)0x0DB6)		,
		Map2Vertex3 = ((int)0x0DB7)		,
		Map2Vertex4 = ((int)0x0DB8)		,
		Map1GridDomain = ((int)0x0DD0)		,
		Map1GridSegments = ((int)0x0DD1)		,
		Map2GridDomain = ((int)0x0DD2)		,
		Map2GridSegments = ((int)0x0DD3)		,
		FeedbackBufferPointer = ((int)0x0DF0)		,
		FeedbackBufferSize = ((int)0x0DF1)		,
		FeedbackBufferType = ((int)0x0DF2)		,
		SelectionBufferPointer = ((int)0x0DF3)		,
		SelectionBufferSize = ((int)0x0DF4)		,
		TextureComponents = ((int)0x1003)		,
		TextureBorder = ((int)0x1005)		,
		Ambient = ((int)0x1200)		,
		Diffuse = ((int)0x1201)		,
		Specular = ((int)0x1202)		,
		Position = ((int)0x1203)		,
		SpotDirection = ((int)0x1204)		,
		SpotExponent = ((int)0x1205)		,
		SpotCutoff = ((int)0x1206)		,
		ConstantAttenuation = ((int)0x1207)		,
		LinearAttenuation = ((int)0x1208)		,
		QuadraticAttenuation = ((int)0x1209)		,
		Compile = ((int)0x1300)		,
		CompileAndExecute = ((int)0x1301)		,
		Gl2Bytes = ((int)0x1407)		,
		Gl3Bytes = ((int)0x1408)		,
		Gl4Bytes = ((int)0x1409)		,
		Emission = ((int)0x1600)		,
		Shininess = ((int)0x1601)		,
		AmbientAndDiffuse = ((int)0x1602)		,
		ColorIndexes = ((int)0x1603)		,
		Modelview = ((int)0x1700)		,
		Projection = ((int)0x1701)		,
		ColorIndex = ((int)0x1900)		,
		Luminance = ((int)0x1909)		,
		LuminanceAlpha = ((int)0x190A)		,
		Bitmap = ((int)0x1A00)		,
		Render = ((int)0x1C00)		,
		Feedback = ((int)0x1C01)		,
		Select = ((int)0x1C02)		,
		Flat = ((int)0x1D00)		,
		Smooth = ((int)0x1D01)		,
		S = ((int)0x2000)		,
		T = ((int)0x2001)		,
		R = ((int)0x2002)		,
		Q = ((int)0x2003)		,
		Modulate = ((int)0x2100)		,
		Decal = ((int)0x2101)		,
		TextureEnvMode = ((int)0x2200)		,
		TextureEnvColor = ((int)0x2201)		,
		TextureEnv = ((int)0x2300)		,
		EyeLinear = ((int)0x2400)		,
		ObjectLinear = ((int)0x2401)		,
		SphereMap = ((int)0x2402)		,
		TextureGenMode = ((int)0x2500)		,
		ObjectPlane = ((int)0x2501)		,
		EyePlane = ((int)0x2502)		,
		Clamp = ((int)0x2900)		,
		V2f = ((int)0x2A20)		,
		V3f = ((int)0x2A21)		,
		C4ubV2f = ((int)0x2A22)		,
		C4ubV3f = ((int)0x2A23)		,
		C3fV3f = ((int)0x2A24)		,
		N3fV3f = ((int)0x2A25)		,
		C4fN3fV3f = ((int)0x2A26)		,
		T2fV3f = ((int)0x2A27)		,
		T4fV4f = ((int)0x2A28)		,
		T2fC4ubV3f = ((int)0x2A29)		,
		T2fC3fV3f = ((int)0x2A2A)		,
		T2fN3fV3f = ((int)0x2A2B)		,
		T2fC4fN3fV3f = ((int)0x2A2C)		,
		T4fC4fN3fV4f = ((int)0x2A2D)		,
		ClipPlane0 = ((int)0x3000)		,
		ClipPlane1 = ((int)0x3001)		,
		ClipPlane2 = ((int)0x3002)		,
		ClipPlane3 = ((int)0x3003)		,
		ClipPlane4 = ((int)0x3004)		,
		ClipPlane5 = ((int)0x3005)		,
		Light0 = ((int)0x4000)		,
		Light1 = ((int)0x4001)		,
		Light2 = ((int)0x4002)		,
		Light3 = ((int)0x4003)		,
		Light4 = ((int)0x4004)		,
		Light5 = ((int)0x4005)		,
		Light6 = ((int)0x4006)		,
		Light7 = ((int)0x4007)		,
		Alpha4 = ((int)0x803B)		,
		Alpha8 = ((int)0x803C)		,
		Alpha12 = ((int)0x803D)		,
		Alpha16 = ((int)0x803E)		,
		Luminance4 = ((int)0x803F)		,
		Luminance8 = ((int)0x8040)		,
		Luminance12 = ((int)0x8041)		,
		Luminance16 = ((int)0x8042)		,
		Luminance4Alpha4 = ((int)0x8043)		,
		Luminance6Alpha2 = ((int)0x8044)		,
		Luminance8Alpha8 = ((int)0x8045)		,
		Luminance12Alpha4 = ((int)0x8046)		,
		Luminance12Alpha12 = ((int)0x8047)		,
		Luminance16Alpha16 = ((int)0x8048)		,
		Intensity = ((int)0x8049)		,
		Intensity4 = ((int)0x804A)		,
		Intensity8 = ((int)0x804B)		,
		Intensity12 = ((int)0x804C)		,
		Intensity16 = ((int)0x804D)		,
		TextureLuminanceSize = ((int)0x8060)		,
		TextureIntensitySize = ((int)0x8061)		,
		TexturePriority = ((int)0x8066)		,
		TextureResident = ((int)0x8067)		,
		VertexArray = ((int)0x8074)		,
		NormalArray = ((int)0x8075)		,
		ColorArray = ((int)0x8076)		,
		IndexArray = ((int)0x8077)		,
		TextureCoordArray = ((int)0x8078)		,
		EdgeFlagArray = ((int)0x8079)		,
		VertexArraySize = ((int)0x807A)		,
		VertexArrayType = ((int)0x807B)		,
		VertexArrayStride = ((int)0x807C)		,
		NormalArrayType = ((int)0x807E)		,
		NormalArrayStride = ((int)0x807F)		,
		ColorArraySize = ((int)0x8081)		,
		ColorArrayType = ((int)0x8082)		,
		ColorArrayStride = ((int)0x8083)		,
		IndexArrayType = ((int)0x8085)		,
		IndexArrayStride = ((int)0x8086)		,
		TextureCoordArraySize = ((int)0x8088)		,
		TextureCoordArrayType = ((int)0x8089)		,
		TextureCoordArrayStride = ((int)0x808A)		,
		EdgeFlagArrayStride = ((int)0x808C)		,
		VertexArrayPointer = ((int)0x808E)		,
		NormalArrayPointer = ((int)0x808F)		,
		ColorArrayPointer = ((int)0x8090)		,
		IndexArrayPointer = ((int)0x8091)		,
		TextureCoordArrayPointer = ((int)0x8092)		,
		EdgeFlagArrayPointer = ((int)0x8093)		,
		AllAttribBits = unchecked((int)0xFFFFFFFF)		,
		ClientAllAttribBits = unchecked((int)0xFFFFFFFF)		,
	}
	public enum Version12 : int {
		SmoothPointSizeRange = ((int)0x0B12)		,
		SmoothPointSizeGranularity = ((int)0x0B13)		,
		SmoothLineWidthRange = ((int)0x0B22)		,
		SmoothLineWidthGranularity = ((int)0x0B23)		,
		ConstantColor = ((int)0x8001)		,
		OneMinusConstantColor = ((int)0x8002)		,
		ConstantAlpha = ((int)0x8003)		,
		OneMinusConstantAlpha = ((int)0x8004)		,
		BlendColor = ((int)0x8005)		,
		Convolution1D = ((int)0x8010)		,
		Convolution2D = ((int)0x8011)		,
		Separable2D = ((int)0x8012)		,
		ConvolutionBorderMode = ((int)0x8013)		,
		ConvolutionFilterScale = ((int)0x8014)		,
		ConvolutionFilterBias = ((int)0x8015)		,
		Reduce = ((int)0x8016)		,
		ConvolutionFormat = ((int)0x8017)		,
		ConvolutionWidth = ((int)0x8018)		,
		ConvolutionHeight = ((int)0x8019)		,
		MaxConvolutionWidth = ((int)0x801A)		,
		MaxConvolutionHeight = ((int)0x801B)		,
		PostConvolutionRedScale = ((int)0x801C)		,
		PostConvolutionGreenScale = ((int)0x801D)		,
		PostConvolutionBlueScale = ((int)0x801E)		,
		PostConvolutionAlphaScale = ((int)0x801F)		,
		PostConvolutionRedBias = ((int)0x8020)		,
		PostConvolutionGreenBias = ((int)0x8021)		,
		PostConvolutionBlueBias = ((int)0x8022)		,
		PostConvolutionAlphaBias = ((int)0x8023)		,
		Histogram = ((int)0x8024)		,
		ProxyHistogram = ((int)0x8025)		,
		HistogramWidth = ((int)0x8026)		,
		HistogramFormat = ((int)0x8027)		,
		HistogramRedSize = ((int)0x8028)		,
		HistogramGreenSize = ((int)0x8029)		,
		HistogramBlueSize = ((int)0x802A)		,
		HistogramAlphaSize = ((int)0x802B)		,
		HistogramSink = ((int)0x802D)		,
		Minmax = ((int)0x802E)		,
		MinmaxFormat = ((int)0x802F)		,
		MinmaxSink = ((int)0x8030)		,
		TableTooLarge = ((int)0x8031)		,
		UnsignedByte332 = ((int)0x8032)		,
		UnsignedShort4444 = ((int)0x8033)		,
		UnsignedShort5551 = ((int)0x8034)		,
		UnsignedInt8888 = ((int)0x8035)		,
		UnsignedInt1010102 = ((int)0x8036)		,
		RescaleNormal = ((int)0x803A)		,
		TextureBinding3D = ((int)0x806A)		,
		PackSkipImages = ((int)0x806B)		,
		PackImageHeight = ((int)0x806C)		,
		UnpackSkipImages = ((int)0x806D)		,
		UnpackImageHeight = ((int)0x806E)		,
		Texture3D = ((int)0x806F)		,
		ProxyTexture3D = ((int)0x8070)		,
		TextureDepth = ((int)0x8071)		,
		TextureWrapR = ((int)0x8072)		,
		Max3DTextureSize = ((int)0x8073)		,
		ColorMatrix = ((int)0x80B1)		,
		ColorMatrixStackDepth = ((int)0x80B2)		,
		MaxColorMatrixStackDepth = ((int)0x80B3)		,
		PostColorMatrixRedScale = ((int)0x80B4)		,
		PostColorMatrixGreenScale = ((int)0x80B5)		,
		PostColorMatrixBlueScale = ((int)0x80B6)		,
		PostColorMatrixAlphaScale = ((int)0x80B7)		,
		PostColorMatrixRedBias = ((int)0x80B8)		,
		PostColorMatrixGreenBias = ((int)0x80B9)		,
		PostColorMatrixBlueBias = ((int)0x80BA)		,
		PostColorMatrixAlphaBias = ((int)0x80BB)		,
		ColorTable = ((int)0x80D0)		,
		PostConvolutionColorTable = ((int)0x80D1)		,
		PostColorMatrixColorTable = ((int)0x80D2)		,
		ProxyColorTable = ((int)0x80D3)		,
		ProxyPostConvolutionColorTable = ((int)0x80D4)		,
		ProxyPostColorMatrixColorTable = ((int)0x80D5)		,
		ColorTableScale = ((int)0x80D6)		,
		ColorTableBias = ((int)0x80D7)		,
		ColorTableFormat = ((int)0x80D8)		,
		ColorTableWidth = ((int)0x80D9)		,
		ColorTableRedSize = ((int)0x80DA)		,
		ColorTableGreenSize = ((int)0x80DB)		,
		ColorTableBlueSize = ((int)0x80DC)		,
		ColorTableAlphaSize = ((int)0x80DD)		,
		ColorTableLuminanceSize = ((int)0x80DE)		,
		ColorTableIntensitySize = ((int)0x80DF)		,
		Bgr = ((int)0x80E0)		,
		Bgra = ((int)0x80E1)		,
		MaxElementsVertices = ((int)0x80E8)		,
		MaxElementsIndices = ((int)0x80E9)		,
		ClampToEdge = ((int)0x812F)		,
		TextureMinLod = ((int)0x813A)		,
		TextureMaxLod = ((int)0x813B)		,
		TextureBaseLevel = ((int)0x813C)		,
		TextureMaxLevel = ((int)0x813D)		,
		ConstantBorder = ((int)0x8151)		,
		ReplicateBorder = ((int)0x8153)		,
		ConvolutionBorderColor = ((int)0x8154)		,
		LightModelColorControl = ((int)0x81F8)		,
		SingleColor = ((int)0x81F9)		,
		SeparateSpecularColor = ((int)0x81FA)		,
		UnsignedByte233Rev = ((int)0x8362)		,
		UnsignedShort565 = ((int)0x8363)		,
		UnsignedShort565Rev = ((int)0x8364)		,
		UnsignedShort4444Rev = ((int)0x8365)		,
		UnsignedShort1555Rev = ((int)0x8366)		,
		UnsignedInt8888Rev = ((int)0x8367)		,
		UnsignedInt2101010Rev = ((int)0x8368)		,
		AliasedPointSizeRange = ((int)0x846D)		,
		AliasedLineWidthRange = ((int)0x846E)		,
	}
	public enum Version12Deprecated : int {
		RescaleNormal = ((int)0x803A)		,
		LightModelColorControl = ((int)0x81F8)		,
		SingleColor = ((int)0x81F9)		,
		SeparateSpecularColor = ((int)0x81FA)		,
		AliasedPointSizeRange = ((int)0x846D)		,
	}
	public enum Version13 : int {
		MultisampleBit = ((int)0x20000000)		,
		Multisample = ((int)0x809D)		,
		SampleAlphaToCoverage = ((int)0x809E)		,
		SampleAlphaToOne = ((int)0x809F)		,
		SampleCoverage = ((int)0x80A0)		,
		SampleBuffers = ((int)0x80A8)		,
		Samples = ((int)0x80A9)		,
		SampleCoverageValue = ((int)0x80AA)		,
		SampleCoverageInvert = ((int)0x80AB)		,
		ClampToBorder = ((int)0x812D)		,
		Texture0 = ((int)0x84C0)		,
		Texture1 = ((int)0x84C1)		,
		Texture2 = ((int)0x84C2)		,
		Texture3 = ((int)0x84C3)		,
		Texture4 = ((int)0x84C4)		,
		Texture5 = ((int)0x84C5)		,
		Texture6 = ((int)0x84C6)		,
		Texture7 = ((int)0x84C7)		,
		Texture8 = ((int)0x84C8)		,
		Texture9 = ((int)0x84C9)		,
		Texture10 = ((int)0x84CA)		,
		Texture11 = ((int)0x84CB)		,
		Texture12 = ((int)0x84CC)		,
		Texture13 = ((int)0x84CD)		,
		Texture14 = ((int)0x84CE)		,
		Texture15 = ((int)0x84CF)		,
		Texture16 = ((int)0x84D0)		,
		Texture17 = ((int)0x84D1)		,
		Texture18 = ((int)0x84D2)		,
		Texture19 = ((int)0x84D3)		,
		Texture20 = ((int)0x84D4)		,
		Texture21 = ((int)0x84D5)		,
		Texture22 = ((int)0x84D6)		,
		Texture23 = ((int)0x84D7)		,
		Texture24 = ((int)0x84D8)		,
		Texture25 = ((int)0x84D9)		,
		Texture26 = ((int)0x84DA)		,
		Texture27 = ((int)0x84DB)		,
		Texture28 = ((int)0x84DC)		,
		Texture29 = ((int)0x84DD)		,
		Texture30 = ((int)0x84DE)		,
		Texture31 = ((int)0x84DF)		,
		ActiveTexture = ((int)0x84E0)		,
		ClientActiveTexture = ((int)0x84E1)		,
		MaxTextureUnits = ((int)0x84E2)		,
		TransposeModelviewMatrix = ((int)0x84E3)		,
		TransposeProjectionMatrix = ((int)0x84E4)		,
		TransposeTextureMatrix = ((int)0x84E5)		,
		TransposeColorMatrix = ((int)0x84E6)		,
		Subtract = ((int)0x84E7)		,
		CompressedAlpha = ((int)0x84E9)		,
		CompressedLuminance = ((int)0x84EA)		,
		CompressedLuminanceAlpha = ((int)0x84EB)		,
		CompressedIntensity = ((int)0x84EC)		,
		CompressedRgb = ((int)0x84ED)		,
		CompressedRgba = ((int)0x84EE)		,
		TextureCompressionHint = ((int)0x84EF)		,
		NormalMap = ((int)0x8511)		,
		ReflectionMap = ((int)0x8512)		,
		TextureCubeMap = ((int)0x8513)		,
		TextureBindingCubeMap = ((int)0x8514)		,
		TextureCubeMapPositiveX = ((int)0x8515)		,
		TextureCubeMapNegativeX = ((int)0x8516)		,
		TextureCubeMapPositiveY = ((int)0x8517)		,
		TextureCubeMapNegativeY = ((int)0x8518)		,
		TextureCubeMapPositiveZ = ((int)0x8519)		,
		TextureCubeMapNegativeZ = ((int)0x851A)		,
		ProxyTextureCubeMap = ((int)0x851B)		,
		MaxCubeMapTextureSize = ((int)0x851C)		,
		Combine = ((int)0x8570)		,
		CombineRgb = ((int)0x8571)		,
		CombineAlpha = ((int)0x8572)		,
		RgbScale = ((int)0x8573)		,
		AddSigned = ((int)0x8574)		,
		Interpolate = ((int)0x8575)		,
		Constant = ((int)0x8576)		,
		PrimaryColor = ((int)0x8577)		,
		Previous = ((int)0x8578)		,
		Source0Rgb = ((int)0x8580)		,
		Source1Rgb = ((int)0x8581)		,
		Source2Rgb = ((int)0x8582)		,
		Source0Alpha = ((int)0x8588)		,
		Source1Alpha = ((int)0x8589)		,
		Source2Alpha = ((int)0x858A)		,
		Operand0Rgb = ((int)0x8590)		,
		Operand1Rgb = ((int)0x8591)		,
		Operand2Rgb = ((int)0x8592)		,
		Operand0Alpha = ((int)0x8598)		,
		Operand1Alpha = ((int)0x8599)		,
		Operand2Alpha = ((int)0x859A)		,
		TextureCompressedImageSize = ((int)0x86A0)		,
		TextureCompressed = ((int)0x86A1)		,
		NumCompressedTextureFormats = ((int)0x86A2)		,
		CompressedTextureFormats = ((int)0x86A3)		,
		Dot3Rgb = ((int)0x86AE)		,
		Dot3Rgba = ((int)0x86AF)		,
	}
	public enum Version13Deprecated : int {
		MultisampleBit = ((int)0x20000000)		,
		ClientActiveTexture = ((int)0x84E1)		,
		MaxTextureUnits = ((int)0x84E2)		,
		TransposeModelviewMatrix = ((int)0x84E3)		,
		TransposeProjectionMatrix = ((int)0x84E4)		,
		TransposeTextureMatrix = ((int)0x84E5)		,
		TransposeColorMatrix = ((int)0x84E6)		,
		Subtract = ((int)0x84E7)		,
		CompressedAlpha = ((int)0x84E9)		,
		CompressedLuminance = ((int)0x84EA)		,
		CompressedLuminanceAlpha = ((int)0x84EB)		,
		CompressedIntensity = ((int)0x84EC)		,
		NormalMap = ((int)0x8511)		,
		ReflectionMap = ((int)0x8512)		,
		Combine = ((int)0x8570)		,
		CombineRgb = ((int)0x8571)		,
		CombineAlpha = ((int)0x8572)		,
		RgbScale = ((int)0x8573)		,
		AddSigned = ((int)0x8574)		,
		Interpolate = ((int)0x8575)		,
		Constant = ((int)0x8576)		,
		PrimaryColor = ((int)0x8577)		,
		Previous = ((int)0x8578)		,
		Source0Rgb = ((int)0x8580)		,
		Source1Rgb = ((int)0x8581)		,
		Source2Rgb = ((int)0x8582)		,
		Source0Alpha = ((int)0x8588)		,
		Source1Alpha = ((int)0x8589)		,
		Source2Alpha = ((int)0x858A)		,
		Operand0Rgb = ((int)0x8590)		,
		Operand1Rgb = ((int)0x8591)		,
		Operand2Rgb = ((int)0x8592)		,
		Operand0Alpha = ((int)0x8598)		,
		Operand1Alpha = ((int)0x8599)		,
		Operand2Alpha = ((int)0x859A)		,
		Dot3Rgb = ((int)0x86AE)		,
		Dot3Rgba = ((int)0x86AF)		,
	}
	public enum Version14 : int {
		BlendDstRgb = ((int)0x80C8)		,
		BlendSrcRgb = ((int)0x80C9)		,
		BlendDstAlpha = ((int)0x80CA)		,
		BlendSrcAlpha = ((int)0x80CB)		,
		PointSizeMin = ((int)0x8126)		,
		PointSizeMax = ((int)0x8127)		,
		PointFadeThresholdSize = ((int)0x8128)		,
		PointDistanceAttenuation = ((int)0x8129)		,
		GenerateMipmap = ((int)0x8191)		,
		GenerateMipmapHint = ((int)0x8192)		,
		DepthComponent16 = ((int)0x81A5)		,
		DepthComponent24 = ((int)0x81A6)		,
		DepthComponent32 = ((int)0x81A7)		,
		MirroredRepeat = ((int)0x8370)		,
		FogCoordinateSource = ((int)0x8450)		,
		FogCoordinate = ((int)0x8451)		,
		FragmentDepth = ((int)0x8452)		,
		CurrentFogCoordinate = ((int)0x8453)		,
		FogCoordinateArrayType = ((int)0x8454)		,
		FogCoordinateArrayStride = ((int)0x8455)		,
		FogCoordinateArrayPointer = ((int)0x8456)		,
		FogCoordinateArray = ((int)0x8457)		,
		ColorSum = ((int)0x8458)		,
		CurrentSecondaryColor = ((int)0x8459)		,
		SecondaryColorArraySize = ((int)0x845A)		,
		SecondaryColorArrayType = ((int)0x845B)		,
		SecondaryColorArrayStride = ((int)0x845C)		,
		SecondaryColorArrayPointer = ((int)0x845D)		,
		SecondaryColorArray = ((int)0x845E)		,
		MaxTextureLodBias = ((int)0x84FD)		,
		TextureFilterControl = ((int)0x8500)		,
		TextureLodBias = ((int)0x8501)		,
		IncrWrap = ((int)0x8507)		,
		DecrWrap = ((int)0x8508)		,
		TextureDepthSize = ((int)0x884A)		,
		DepthTextureMode = ((int)0x884B)		,
		TextureCompareMode = ((int)0x884C)		,
		TextureCompareFunc = ((int)0x884D)		,
		CompareRToTexture = ((int)0x884E)		,
	}
	public enum Version14Deprecated : int {
		PointSizeMin = ((int)0x8126)		,
		PointSizeMax = ((int)0x8127)		,
		PointDistanceAttenuation = ((int)0x8129)		,
		GenerateMipmap = ((int)0x8191)		,
		GenerateMipmapHint = ((int)0x8192)		,
		FogCoordinateSource = ((int)0x8450)		,
		FogCoordinate = ((int)0x8451)		,
		FragmentDepth = ((int)0x8452)		,
		CurrentFogCoordinate = ((int)0x8453)		,
		FogCoordinateArrayType = ((int)0x8454)		,
		FogCoordinateArrayStride = ((int)0x8455)		,
		FogCoordinateArrayPointer = ((int)0x8456)		,
		FogCoordinateArray = ((int)0x8457)		,
		ColorSum = ((int)0x8458)		,
		CurrentSecondaryColor = ((int)0x8459)		,
		SecondaryColorArraySize = ((int)0x845A)		,
		SecondaryColorArrayType = ((int)0x845B)		,
		SecondaryColorArrayStride = ((int)0x845C)		,
		SecondaryColorArrayPointer = ((int)0x845D)		,
		SecondaryColorArray = ((int)0x845E)		,
		TextureFilterControl = ((int)0x8500)		,
		DepthTextureMode = ((int)0x884B)		,
		CompareRToTexture = ((int)0x884E)		,
	}
	public enum Version15 : int {
		FogCoordSrc = ((int)0x8450)		,
		FogCoord = ((int)0x8451)		,
		CurrentFogCoord = ((int)0x8453)		,
		FogCoordArrayType = ((int)0x8454)		,
		FogCoordArrayStride = ((int)0x8455)		,
		FogCoordArrayPointer = ((int)0x8456)		,
		FogCoordArray = ((int)0x8457)		,
		Src0Rgb = ((int)0x8580)		,
		Src1Rgb = ((int)0x8581)		,
		Src2Rgb = ((int)0x8582)		,
		Src0Alpha = ((int)0x8588)		,
		Src1Alpha = ((int)0x8589)		,
		Src2Alpha = ((int)0x858A)		,
		BufferSize = ((int)0x8764)		,
		BufferUsage = ((int)0x8765)		,
		QueryCounterBits = ((int)0x8864)		,
		CurrentQuery = ((int)0x8865)		,
		QueryResult = ((int)0x8866)		,
		QueryResultAvailable = ((int)0x8867)		,
		ArrayBuffer = ((int)0x8892)		,
		ElementArrayBuffer = ((int)0x8893)		,
		ArrayBufferBinding = ((int)0x8894)		,
		ElementArrayBufferBinding = ((int)0x8895)		,
		VertexArrayBufferBinding = ((int)0x8896)		,
		NormalArrayBufferBinding = ((int)0x8897)		,
		ColorArrayBufferBinding = ((int)0x8898)		,
		IndexArrayBufferBinding = ((int)0x8899)		,
		TextureCoordArrayBufferBinding = ((int)0x889A)		,
		EdgeFlagArrayBufferBinding = ((int)0x889B)		,
		SecondaryColorArrayBufferBinding = ((int)0x889C)		,
		FogCoordArrayBufferBinding = ((int)0x889D)		,
		FogCoordinateArrayBufferBinding = ((int)0x889D)		,
		WeightArrayBufferBinding = ((int)0x889E)		,
		VertexAttribArrayBufferBinding = ((int)0x889F)		,
		ReadOnly = ((int)0x88B8)		,
		WriteOnly = ((int)0x88B9)		,
		ReadWrite = ((int)0x88BA)		,
		BufferAccess = ((int)0x88BB)		,
		BufferMapped = ((int)0x88BC)		,
		BufferMapPointer = ((int)0x88BD)		,
		StreamDraw = ((int)0x88E0)		,
		StreamRead = ((int)0x88E1)		,
		StreamCopy = ((int)0x88E2)		,
		StaticDraw = ((int)0x88E4)		,
		StaticRead = ((int)0x88E5)		,
		StaticCopy = ((int)0x88E6)		,
		DynamicDraw = ((int)0x88E8)		,
		DynamicRead = ((int)0x88E9)		,
		DynamicCopy = ((int)0x88EA)		,
		SamplesPassed = ((int)0x8914)		,
	}
	public enum Version15Deprecated : int {
		FogCoordSrc = ((int)0x8450)		,
		FogCoord = ((int)0x8451)		,
		CurrentFogCoord = ((int)0x8453)		,
		FogCoordArrayType = ((int)0x8454)		,
		FogCoordArrayStride = ((int)0x8455)		,
		FogCoordArrayPointer = ((int)0x8456)		,
		FogCoordArray = ((int)0x8457)		,
		Src0Rgb = ((int)0x8580)		,
		Src1Rgb = ((int)0x8581)		,
		Src2Rgb = ((int)0x8582)		,
		Src0Alpha = ((int)0x8588)		,
		Src1Alpha = ((int)0x8589)		,
		Src2Alpha = ((int)0x858A)		,
		VertexArrayBufferBinding = ((int)0x8896)		,
		NormalArrayBufferBinding = ((int)0x8897)		,
		ColorArrayBufferBinding = ((int)0x8898)		,
		IndexArrayBufferBinding = ((int)0x8899)		,
		TextureCoordArrayBufferBinding = ((int)0x889A)		,
		EdgeFlagArrayBufferBinding = ((int)0x889B)		,
		SecondaryColorArrayBufferBinding = ((int)0x889C)		,
		FogCoordArrayBufferBinding = ((int)0x889D)		,
		FogCoordinateArrayBufferBinding = ((int)0x889D)		,
		WeightArrayBufferBinding = ((int)0x889E)		,
	}
	public enum Version20 : int {
		BlendEquationRgb = ((int)0x8009)		,
		VertexAttribArrayEnabled = ((int)0x8622)		,
		VertexAttribArraySize = ((int)0x8623)		,
		VertexAttribArrayStride = ((int)0x8624)		,
		VertexAttribArrayType = ((int)0x8625)		,
		CurrentVertexAttrib = ((int)0x8626)		,
		VertexProgramPointSize = ((int)0x8642)		,
		VertexProgramTwoSide = ((int)0x8643)		,
		VertexAttribArrayPointer = ((int)0x8645)		,
		StencilBackFunc = ((int)0x8800)		,
		StencilBackFail = ((int)0x8801)		,
		StencilBackFailAti = ((int)0x8801)		,
		StencilBackPassDepthFail = ((int)0x8802)		,
		StencilBackPassDepthPass = ((int)0x8803)		,
		MaxDrawBuffers = ((int)0x8824)		,
		DrawBuffer0 = ((int)0x8825)		,
		DrawBuffer1 = ((int)0x8826)		,
		DrawBuffer2 = ((int)0x8827)		,
		DrawBuffer3 = ((int)0x8828)		,
		DrawBuffer4 = ((int)0x8829)		,
		DrawBuffer5 = ((int)0x882A)		,
		DrawBuffer6 = ((int)0x882B)		,
		DrawBuffer7 = ((int)0x882C)		,
		DrawBuffer8 = ((int)0x882D)		,
		DrawBuffer9 = ((int)0x882E)		,
		DrawBuffer10 = ((int)0x882F)		,
		DrawBuffer11 = ((int)0x8830)		,
		DrawBuffer12 = ((int)0x8831)		,
		DrawBuffer13 = ((int)0x8832)		,
		DrawBuffer14 = ((int)0x8833)		,
		DrawBuffer15 = ((int)0x8834)		,
		BlendEquationAlpha = ((int)0x883D)		,
		PointSprite = ((int)0x8861)		,
		CoordReplace = ((int)0x8862)		,
		MaxVertexAttribs = ((int)0x8869)		,
		VertexAttribArrayNormalized = ((int)0x886A)		,
		MaxTextureCoords = ((int)0x8871)		,
		MaxTextureImageUnits = ((int)0x8872)		,
		FragmentShader = ((int)0x8B30)		,
		VertexShader = ((int)0x8B31)		,
		MaxFragmentUniformComponents = ((int)0x8B49)		,
		MaxVertexUniformComponents = ((int)0x8B4A)		,
		MaxVaryingFloats = ((int)0x8B4B)		,
		MaxVertexTextureImageUnits = ((int)0x8B4C)		,
		MaxCombinedTextureImageUnits = ((int)0x8B4D)		,
		ShaderType = ((int)0x8B4F)		,
		FloatVec2 = ((int)0x8B50)		,
		FloatVec3 = ((int)0x8B51)		,
		FloatVec4 = ((int)0x8B52)		,
		IntVec2 = ((int)0x8B53)		,
		IntVec3 = ((int)0x8B54)		,
		IntVec4 = ((int)0x8B55)		,
		Bool = ((int)0x8B56)		,
		BoolVec2 = ((int)0x8B57)		,
		BoolVec3 = ((int)0x8B58)		,
		BoolVec4 = ((int)0x8B59)		,
		FloatMat2 = ((int)0x8B5A)		,
		FloatMat3 = ((int)0x8B5B)		,
		FloatMat4 = ((int)0x8B5C)		,
		Sampler1D = ((int)0x8B5D)		,
		Sampler2D = ((int)0x8B5E)		,
		Sampler3D = ((int)0x8B5F)		,
		SamplerCube = ((int)0x8B60)		,
		Sampler1DShadow = ((int)0x8B61)		,
		Sampler2DShadow = ((int)0x8B62)		,
		DeleteStatus = ((int)0x8B80)		,
		CompileStatus = ((int)0x8B81)		,
		LinkStatus = ((int)0x8B82)		,
		ValidateStatus = ((int)0x8B83)		,
		InfoLogLength = ((int)0x8B84)		,
		AttachedShaders = ((int)0x8B85)		,
		ActiveUniforms = ((int)0x8B86)		,
		ActiveUniformMaxLength = ((int)0x8B87)		,
		ShaderSourceLength = ((int)0x8B88)		,
		ActiveAttributes = ((int)0x8B89)		,
		ActiveAttributeMaxLength = ((int)0x8B8A)		,
		FragmentShaderDerivativeHint = ((int)0x8B8B)		,
		ShadingLanguageVersion = ((int)0x8B8C)		,
		CurrentProgram = ((int)0x8B8D)		,
		PointSpriteCoordOrigin = ((int)0x8CA0)		,
		LowerLeft = ((int)0x8CA1)		,
		UpperLeft = ((int)0x8CA2)		,
		StencilBackRef = ((int)0x8CA3)		,
		StencilBackValueMask = ((int)0x8CA4)		,
		StencilBackWritemask = ((int)0x8CA5)		,
	}
	public enum Version20Deprecated : int {
		VertexProgramTwoSide = ((int)0x8643)		,
		PointSprite = ((int)0x8861)		,
		CoordReplace = ((int)0x8862)		,
		MaxTextureCoords = ((int)0x8871)		,
	}
	public enum Version21 : int {
		CurrentRasterSecondaryColor = ((int)0x845F)		,
		PixelPackBuffer = ((int)0x88EB)		,
		PixelUnpackBuffer = ((int)0x88EC)		,
		PixelPackBufferBinding = ((int)0x88ED)		,
		PixelUnpackBufferBinding = ((int)0x88EF)		,
		FloatMat2x3 = ((int)0x8B65)		,
		FloatMat2x4 = ((int)0x8B66)		,
		FloatMat3x2 = ((int)0x8B67)		,
		FloatMat3x4 = ((int)0x8B68)		,
		FloatMat4x2 = ((int)0x8B69)		,
		FloatMat4x3 = ((int)0x8B6A)		,
		Srgb = ((int)0x8C40)		,
		Srgb8 = ((int)0x8C41)		,
		SrgbAlpha = ((int)0x8C42)		,
		Srgb8Alpha8 = ((int)0x8C43)		,
		SluminanceAlpha = ((int)0x8C44)		,
		Sluminance8Alpha8 = ((int)0x8C45)		,
		Sluminance = ((int)0x8C46)		,
		Sluminance8 = ((int)0x8C47)		,
		CompressedSrgb = ((int)0x8C48)		,
		CompressedSrgbAlpha = ((int)0x8C49)		,
		CompressedSluminance = ((int)0x8C4A)		,
		CompressedSluminanceAlpha = ((int)0x8C4B)		,
	}
	public enum Version21Deprecated : int {
		CurrentRasterSecondaryColor = ((int)0x845F)		,
		SluminanceAlpha = ((int)0x8C44)		,
		Sluminance8Alpha8 = ((int)0x8C45)		,
		Sluminance = ((int)0x8C46)		,
		Sluminance8 = ((int)0x8C47)		,
		CompressedSluminance = ((int)0x8C4A)		,
		CompressedSluminanceAlpha = ((int)0x8C4B)		,
	}
	public enum Version30 : int {
		ContextFlagForwardCompatibleBit = ((int)0x00000001)		,
		MapReadBit = ((int)0x0001)		,
		MapWriteBit = ((int)0x0002)		,
		MapInvalidateRangeBit = ((int)0x0004)		,
		MapInvalidateBufferBit = ((int)0x0008)		,
		MapFlushExplicitBit = ((int)0x0010)		,
		MapUnsynchronizedBit = ((int)0x0020)		,
		InvalidFramebufferOperation = ((int)0x0506)		,
		MaxClipDistances = ((int)0x0D32)		,
		HalfFloat = ((int)0x140B)		,
		ClipDistance0 = ((int)0x3000)		,
		ClipDistance1 = ((int)0x3001)		,
		ClipDistance2 = ((int)0x3002)		,
		ClipDistance3 = ((int)0x3003)		,
		ClipDistance4 = ((int)0x3004)		,
		ClipDistance5 = ((int)0x3005)		,
		ClipDistance6 = ((int)0x3006)		,
		ClipDistance7 = ((int)0x3007)		,
		FramebufferAttachmentColorEncoding = ((int)0x8210)		,
		FramebufferAttachmentComponentType = ((int)0x8211)		,
		FramebufferAttachmentRedSize = ((int)0x8212)		,
		FramebufferAttachmentGreenSize = ((int)0x8213)		,
		FramebufferAttachmentBlueSize = ((int)0x8214)		,
		FramebufferAttachmentAlphaSize = ((int)0x8215)		,
		FramebufferAttachmentDepthSize = ((int)0x8216)		,
		FramebufferAttachmentStencilSize = ((int)0x8217)		,
		FramebufferDefault = ((int)0x8218)		,
		FramebufferUndefined = ((int)0x8219)		,
		DepthStencilAttachment = ((int)0x821A)		,
		MajorVersion = ((int)0x821B)		,
		MinorVersion = ((int)0x821C)		,
		NumExtensions = ((int)0x821D)		,
		ContextFlags = ((int)0x821E)		,
		Index = ((int)0x8222)		,
		DepthBuffer = ((int)0x8223)		,
		StencilBuffer = ((int)0x8224)		,
		CompressedRed = ((int)0x8225)		,
		CompressedRg = ((int)0x8226)		,
		Rg = ((int)0x8227)		,
		RgInteger = ((int)0x8228)		,
		R8 = ((int)0x8229)		,
		R16 = ((int)0x822A)		,
		Rg8 = ((int)0x822B)		,
		Rg16 = ((int)0x822C)		,
		R16f = ((int)0x822D)		,
		R32f = ((int)0x822E)		,
		Rg16f = ((int)0x822F)		,
		Rg32f = ((int)0x8230)		,
		R8i = ((int)0x8231)		,
		R8ui = ((int)0x8232)		,
		R16i = ((int)0x8233)		,
		R16ui = ((int)0x8234)		,
		R32i = ((int)0x8235)		,
		R32ui = ((int)0x8236)		,
		Rg8i = ((int)0x8237)		,
		Rg8ui = ((int)0x8238)		,
		Rg16i = ((int)0x8239)		,
		Rg16ui = ((int)0x823A)		,
		Rg32i = ((int)0x823B)		,
		Rg32ui = ((int)0x823C)		,
		MaxRenderbufferSize = ((int)0x84E8)		,
		DepthStencil = ((int)0x84F9)		,
		UnsignedInt248 = ((int)0x84FA)		,
		VertexArrayBinding = ((int)0x85B5)		,
		Rgba32f = ((int)0x8814)		,
		Rgb32f = ((int)0x8815)		,
		Rgba16f = ((int)0x881A)		,
		Rgb16f = ((int)0x881B)		,
		CompareRefToTexture = ((int)0x884E)		,
		Depth24Stencil8 = ((int)0x88F0)		,
		TextureStencilSize = ((int)0x88F1)		,
		VertexAttribArrayInteger = ((int)0x88FD)		,
		MaxArrayTextureLayers = ((int)0x88FF)		,
		MinProgramTexelOffset = ((int)0x8904)		,
		MaxProgramTexelOffset = ((int)0x8905)		,
		ClampVertexColor = ((int)0x891A)		,
		ClampFragmentColor = ((int)0x891B)		,
		ClampReadColor = ((int)0x891C)		,
		FixedOnly = ((int)0x891D)		,
		MaxVaryingComponents = ((int)0x8B4B)		,
		TextureRedType = ((int)0x8C10)		,
		TextureGreenType = ((int)0x8C11)		,
		TextureBlueType = ((int)0x8C12)		,
		TextureAlphaType = ((int)0x8C13)		,
		TextureLuminanceType = ((int)0x8C14)		,
		TextureIntensityType = ((int)0x8C15)		,
		TextureDepthType = ((int)0x8C16)		,
		UnsignedNormalized = ((int)0x8C17)		,
		Texture1DArray = ((int)0x8C18)		,
		ProxyTexture1DArray = ((int)0x8C19)		,
		Texture2DArray = ((int)0x8C1A)		,
		ProxyTexture2DArray = ((int)0x8C1B)		,
		TextureBinding1DArray = ((int)0x8C1C)		,
		TextureBinding2DArray = ((int)0x8C1D)		,
		R11fG11fB10f = ((int)0x8C3A)		,
		UnsignedInt10F11F11FRev = ((int)0x8C3B)		,
		Rgb9E5 = ((int)0x8C3D)		,
		UnsignedInt5999Rev = ((int)0x8C3E)		,
		TextureSharedSize = ((int)0x8C3F)		,
		TransformFeedbackVaryingMaxLength = ((int)0x8C76)		,
		TransformFeedbackBufferMode = ((int)0x8C7F)		,
		MaxTransformFeedbackSeparateComponents = ((int)0x8C80)		,
		TransformFeedbackVaryings = ((int)0x8C83)		,
		TransformFeedbackBufferStart = ((int)0x8C84)		,
		TransformFeedbackBufferSize = ((int)0x8C85)		,
		PrimitivesGenerated = ((int)0x8C87)		,
		TransformFeedbackPrimitivesWritten = ((int)0x8C88)		,
		RasterizerDiscard = ((int)0x8C89)		,
		MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)		,
		MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)		,
		InterleavedAttribs = ((int)0x8C8C)		,
		SeparateAttribs = ((int)0x8C8D)		,
		TransformFeedbackBuffer = ((int)0x8C8E)		,
		TransformFeedbackBufferBinding = ((int)0x8C8F)		,
		DrawFramebufferBinding = ((int)0x8CA6)		,
		FramebufferBinding = ((int)0x8CA6)		,
		RenderbufferBinding = ((int)0x8CA7)		,
		ReadFramebuffer = ((int)0x8CA8)		,
		DrawFramebuffer = ((int)0x8CA9)		,
		ReadFramebufferBinding = ((int)0x8CAA)		,
		RenderbufferSamples = ((int)0x8CAB)		,
		DepthComponent32f = ((int)0x8CAC)		,
		Depth32fStencil8 = ((int)0x8CAD)		,
		FramebufferAttachmentObjectType = ((int)0x8CD0)		,
		FramebufferAttachmentObjectName = ((int)0x8CD1)		,
		FramebufferAttachmentTextureLevel = ((int)0x8CD2)		,
		FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)		,
		FramebufferAttachmentTextureLayer = ((int)0x8CD4)		,
		FramebufferComplete = ((int)0x8CD5)		,
		FramebufferIncompleteAttachment = ((int)0x8CD6)		,
		FramebufferIncompleteMissingAttachment = ((int)0x8CD7)		,
		FramebufferIncompleteDrawBuffer = ((int)0x8CDB)		,
		FramebufferIncompleteReadBuffer = ((int)0x8CDC)		,
		FramebufferUnsupported = ((int)0x8CDD)		,
		MaxColorAttachments = ((int)0x8CDF)		,
		ColorAttachment0 = ((int)0x8CE0)		,
		ColorAttachment1 = ((int)0x8CE1)		,
		ColorAttachment2 = ((int)0x8CE2)		,
		ColorAttachment3 = ((int)0x8CE3)		,
		ColorAttachment4 = ((int)0x8CE4)		,
		ColorAttachment5 = ((int)0x8CE5)		,
		ColorAttachment6 = ((int)0x8CE6)		,
		ColorAttachment7 = ((int)0x8CE7)		,
		ColorAttachment8 = ((int)0x8CE8)		,
		ColorAttachment9 = ((int)0x8CE9)		,
		ColorAttachment10 = ((int)0x8CEA)		,
		ColorAttachment11 = ((int)0x8CEB)		,
		ColorAttachment12 = ((int)0x8CEC)		,
		ColorAttachment13 = ((int)0x8CED)		,
		ColorAttachment14 = ((int)0x8CEE)		,
		ColorAttachment15 = ((int)0x8CEF)		,
		DepthAttachment = ((int)0x8D00)		,
		StencilAttachment = ((int)0x8D20)		,
		Framebuffer = ((int)0x8D40)		,
		Renderbuffer = ((int)0x8D41)		,
		RenderbufferWidth = ((int)0x8D42)		,
		RenderbufferHeight = ((int)0x8D43)		,
		RenderbufferInternalFormat = ((int)0x8D44)		,
		StencilIndex1 = ((int)0x8D46)		,
		StencilIndex4 = ((int)0x8D47)		,
		StencilIndex8 = ((int)0x8D48)		,
		StencilIndex16 = ((int)0x8D49)		,
		RenderbufferRedSize = ((int)0x8D50)		,
		RenderbufferGreenSize = ((int)0x8D51)		,
		RenderbufferBlueSize = ((int)0x8D52)		,
		RenderbufferAlphaSize = ((int)0x8D53)		,
		RenderbufferDepthSize = ((int)0x8D54)		,
		RenderbufferStencilSize = ((int)0x8D55)		,
		FramebufferIncompleteMultisample = ((int)0x8D56)		,
		MaxSamples = ((int)0x8D57)		,
		Rgba32ui = ((int)0x8D70)		,
		Rgb32ui = ((int)0x8D71)		,
		Rgba16ui = ((int)0x8D76)		,
		Rgb16ui = ((int)0x8D77)		,
		Rgba8ui = ((int)0x8D7C)		,
		Rgb8ui = ((int)0x8D7D)		,
		Rgba32i = ((int)0x8D82)		,
		Rgb32i = ((int)0x8D83)		,
		Rgba16i = ((int)0x8D88)		,
		Rgb16i = ((int)0x8D89)		,
		Rgba8i = ((int)0x8D8E)		,
		Rgb8i = ((int)0x8D8F)		,
		RedInteger = ((int)0x8D94)		,
		GreenInteger = ((int)0x8D95)		,
		BlueInteger = ((int)0x8D96)		,
		RgbInteger = ((int)0x8D98)		,
		RgbaInteger = ((int)0x8D99)		,
		BgrInteger = ((int)0x8D9A)		,
		BgraInteger = ((int)0x8D9B)		,
		Float32UnsignedInt248Rev = ((int)0x8DAD)		,
		FramebufferSrgb = ((int)0x8DB9)		,
		CompressedRedRgtc1 = ((int)0x8DBB)		,
		CompressedSignedRedRgtc1 = ((int)0x8DBC)		,
		CompressedRgRgtc2 = ((int)0x8DBD)		,
		CompressedSignedRgRgtc2 = ((int)0x8DBE)		,
		Sampler1DArray = ((int)0x8DC0)		,
		Sampler2DArray = ((int)0x8DC1)		,
		Sampler1DArrayShadow = ((int)0x8DC3)		,
		Sampler2DArrayShadow = ((int)0x8DC4)		,
		SamplerCubeShadow = ((int)0x8DC5)		,
		UnsignedIntVec2 = ((int)0x8DC6)		,
		UnsignedIntVec3 = ((int)0x8DC7)		,
		UnsignedIntVec4 = ((int)0x8DC8)		,
		IntSampler1D = ((int)0x8DC9)		,
		IntSampler2D = ((int)0x8DCA)		,
		IntSampler3D = ((int)0x8DCB)		,
		IntSamplerCube = ((int)0x8DCC)		,
		IntSampler1DArray = ((int)0x8DCE)		,
		IntSampler2DArray = ((int)0x8DCF)		,
		UnsignedIntSampler1D = ((int)0x8DD1)		,
		UnsignedIntSampler2D = ((int)0x8DD2)		,
		UnsignedIntSampler3D = ((int)0x8DD3)		,
		UnsignedIntSamplerCube = ((int)0x8DD4)		,
		UnsignedIntSampler1DArray = ((int)0x8DD6)		,
		UnsignedIntSampler2DArray = ((int)0x8DD7)		,
		QueryWait = ((int)0x8E13)		,
		QueryNoWait = ((int)0x8E14)		,
		QueryByRegionWait = ((int)0x8E15)		,
		QueryByRegionNoWait = ((int)0x8E16)		,
		BufferAccessFlags = ((int)0x911F)		,
		BufferMapLength = ((int)0x9120)		,
		BufferMapOffset = ((int)0x9121)		,
	}
	public enum Version30Deprecated : int {
		ClampVertexColor = ((int)0x891A)		,
		ClampFragmentColor = ((int)0x891B)		,
		TextureLuminanceType = ((int)0x8C14)		,
		TextureIntensityType = ((int)0x8C15)		,
		AlphaInteger = ((int)0x8D97)		,
	}
	public enum Version31 : int {
		TextureRectangle = ((int)0x84F5)		,
		TextureBindingRectangle = ((int)0x84F6)		,
		ProxyTextureRectangle = ((int)0x84F7)		,
		MaxRectangleTextureSize = ((int)0x84F8)		,
		UniformBuffer = ((int)0x8A11)		,
		UniformBufferBinding = ((int)0x8A28)		,
		UniformBufferStart = ((int)0x8A29)		,
		UniformBufferSize = ((int)0x8A2A)		,
		MaxVertexUniformBlocks = ((int)0x8A2B)		,
		MaxGeometryUniformBlocks = ((int)0x8A2C)		,
		MaxFragmentUniformBlocks = ((int)0x8A2D)		,
		MaxCombinedUniformBlocks = ((int)0x8A2E)		,
		MaxUniformBufferBindings = ((int)0x8A2F)		,
		MaxUniformBlockSize = ((int)0x8A30)		,
		MaxCombinedVertexUniformComponents = ((int)0x8A31)		,
		MaxCombinedGeometryUniformComponents = ((int)0x8A32)		,
		MaxCombinedFragmentUniformComponents = ((int)0x8A33)		,
		UniformBufferOffsetAlignment = ((int)0x8A34)		,
		ActiveUniformBlockMaxNameLength = ((int)0x8A35)		,
		ActiveUniformBlocks = ((int)0x8A36)		,
		UniformType = ((int)0x8A37)		,
		UniformSize = ((int)0x8A38)		,
		UniformNameLength = ((int)0x8A39)		,
		UniformBlockIndex = ((int)0x8A3A)		,
		UniformOffset = ((int)0x8A3B)		,
		UniformArrayStride = ((int)0x8A3C)		,
		UniformMatrixStride = ((int)0x8A3D)		,
		UniformIsRowMajor = ((int)0x8A3E)		,
		UniformBlockBinding = ((int)0x8A3F)		,
		UniformBlockDataSize = ((int)0x8A40)		,
		UniformBlockNameLength = ((int)0x8A41)		,
		UniformBlockActiveUniforms = ((int)0x8A42)		,
		UniformBlockActiveUniformIndices = ((int)0x8A43)		,
		UniformBlockReferencedByVertexShader = ((int)0x8A44)		,
		UniformBlockReferencedByGeometryShader = ((int)0x8A45)		,
		UniformBlockReferencedByFragmentShader = ((int)0x8A46)		,
		Sampler2DRect = ((int)0x8B63)		,
		Sampler2DRectShadow = ((int)0x8B64)		,
		TextureBuffer = ((int)0x8C2A)		,
		MaxTextureBufferSize = ((int)0x8C2B)		,
		TextureBindingBuffer = ((int)0x8C2C)		,
		TextureBufferDataStoreBinding = ((int)0x8C2D)		,
		TextureBufferFormat = ((int)0x8C2E)		,
		SamplerBuffer = ((int)0x8DC2)		,
		IntSampler2DRect = ((int)0x8DCD)		,
		IntSamplerBuffer = ((int)0x8DD0)		,
		UnsignedIntSampler2DRect = ((int)0x8DD5)		,
		UnsignedIntSamplerBuffer = ((int)0x8DD8)		,
		CopyReadBuffer = ((int)0x8F36)		,
		CopyWriteBuffer = ((int)0x8F37)		,
		RedSnorm = ((int)0x8F90)		,
		RgSnorm = ((int)0x8F91)		,
		RgbSnorm = ((int)0x8F92)		,
		RgbaSnorm = ((int)0x8F93)		,
		R8Snorm = ((int)0x8F94)		,
		Rg8Snorm = ((int)0x8F95)		,
		Rgb8Snorm = ((int)0x8F96)		,
		Rgba8Snorm = ((int)0x8F97)		,
		R16Snorm = ((int)0x8F98)		,
		Rg16Snorm = ((int)0x8F99)		,
		Rgb16Snorm = ((int)0x8F9A)		,
		Rgba16Snorm = ((int)0x8F9B)		,
		SignedNormalized = ((int)0x8F9C)		,
		PrimitiveRestart = ((int)0x8F9D)		,
		PrimitiveRestartIndex = ((int)0x8F9E)		,
		InvalidIndex = unchecked((int)0xFFFFFFFF)		,
	}
	public enum Version32 : int {
		ContextCoreProfileBit = ((int)0x00000001)		,
		SyncFlushCommandsBit = ((int)0x00000001)		,
		ContextCompatibilityProfileBit = ((int)0x00000002)		,
		LinesAdjacency = ((int)0x000A)		,
		LineStripAdjacency = ((int)0x000B)		,
		TrianglesAdjacency = ((int)0x000C)		,
		TriangleStripAdjacency = ((int)0x000D)		,
		ProgramPointSize = ((int)0x8642)		,
		DepthClamp = ((int)0x864F)		,
		TextureCubeMapSeamless = ((int)0x884F)		,
		GeometryVerticesOut = ((int)0x8916)		,
		GeometryInputType = ((int)0x8917)		,
		GeometryOutputType = ((int)0x8918)		,
		MaxVaryingComponents = ((int)0x8B4B)		,
		MaxGeometryTextureImageUnits = ((int)0x8C29)		,
		FramebufferAttachmentTextureLayer = ((int)0x8CD4)		,
		FramebufferAttachmentLayered = ((int)0x8DA7)		,
		FramebufferIncompleteLayerTargets = ((int)0x8DA8)		,
		GeometryShader = ((int)0x8DD9)		,
		MaxGeometryUniformComponents = ((int)0x8DDF)		,
		MaxGeometryOutputVertices = ((int)0x8DE0)		,
		MaxGeometryTotalOutputComponents = ((int)0x8DE1)		,
		QuadsFollowProvokingVertexConvention = ((int)0x8E4C)		,
		FirstVertexConvention = ((int)0x8E4D)		,
		LastVertexConvention = ((int)0x8E4E)		,
		ProvokingVertex = ((int)0x8E4F)		,
		SamplePosition = ((int)0x8E50)		,
		SampleMask = ((int)0x8E51)		,
		SampleMaskValue = ((int)0x8E52)		,
		MaxSampleMaskWords = ((int)0x8E59)		,
		Texture2DMultisample = ((int)0x9100)		,
		ProxyTexture2DMultisample = ((int)0x9101)		,
		Texture2DMultisampleArray = ((int)0x9102)		,
		ProxyTexture2DMultisampleArray = ((int)0x9103)		,
		TextureBinding2DMultisample = ((int)0x9104)		,
		TextureBinding2DMultisampleArray = ((int)0x9105)		,
		TextureSamples = ((int)0x9106)		,
		TextureFixedSampleLocations = ((int)0x9107)		,
		Sampler2DMultisample = ((int)0x9108)		,
		IntSampler2DMultisample = ((int)0x9109)		,
		UnsignedIntSampler2DMultisample = ((int)0x910A)		,
		Sampler2DMultisampleArray = ((int)0x910B)		,
		IntSampler2DMultisampleArray = ((int)0x910C)		,
		UnsignedIntSampler2DMultisampleArray = ((int)0x910D)		,
		MaxColorTextureSamples = ((int)0x910E)		,
		MaxDepthTextureSamples = ((int)0x910F)		,
		MaxIntegerSamples = ((int)0x9110)		,
		MaxServerWaitTimeout = ((int)0x9111)		,
		ObjectType = ((int)0x9112)		,
		SyncCondition = ((int)0x9113)		,
		SyncStatus = ((int)0x9114)		,
		SyncFlags = ((int)0x9115)		,
		SyncFence = ((int)0x9116)		,
		SyncGpuCommandsComplete = ((int)0x9117)		,
		Unsignaled = ((int)0x9118)		,
		Signaled = ((int)0x9119)		,
		AlreadySignaled = ((int)0x911A)		,
		TimeoutExpired = ((int)0x911B)		,
		ConditionSatisfied = ((int)0x911C)		,
		WaitFailed = ((int)0x911D)		,
		MaxVertexOutputComponents = ((int)0x9122)		,
		MaxGeometryInputComponents = ((int)0x9123)		,
		MaxGeometryOutputComponents = ((int)0x9124)		,
		MaxFragmentInputComponents = ((int)0x9125)		,
		ContextProfileMask = ((int)0x9126)		,
		TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)		,
	}
	public enum Version33 : int {
		TimeElapsed = ((int)0x88BF)		,
		Src1Color = ((int)0x88F9)		,
		OneMinusSrc1Color = ((int)0x88FA)		,
		OneMinusSrc1Alpha = ((int)0x88FB)		,
		MaxDualSourceDrawBuffers = ((int)0x88FC)		,
		VertexAttribArrayDivisor = ((int)0x88FE)		,
		SamplerBinding = ((int)0x8919)		,
		AnySamplesPassed = ((int)0x8C2F)		,
		Int2101010Rev = ((int)0x8D9F)		,
		Timestamp = ((int)0x8E28)		,
		TextureSwizzleR = ((int)0x8E42)		,
		TextureSwizzleG = ((int)0x8E43)		,
		TextureSwizzleB = ((int)0x8E44)		,
		TextureSwizzleA = ((int)0x8E45)		,
		TextureSwizzleRgba = ((int)0x8E46)		,
		Rgb10A2ui = ((int)0x906F)		,
	}*/
	public enum Version40 : int {
		Patches = ((int)0x000E)		,
		UniformBlockReferencedByTessControlShader = ((int)0x84F0)		,
		UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1)		,
		MaxTessControlInputComponents = ((int)0x886C)		,
		MaxTessEvaluationInputComponents = ((int)0x886D)		,
		GeometryShaderInvocations = ((int)0x887F)		,
		SampleShading = ((int)0x8C36)		,
		MinSampleShadingValue = ((int)0x8C37)		,
		ActiveSubroutines = ((int)0x8DE5)		,
		ActiveSubroutineUniforms = ((int)0x8DE6)		,
		MaxSubroutines = ((int)0x8DE7)		,
		MaxSubroutineUniformLocations = ((int)0x8DE8)		,
		MaxCombinedTessControlUniformComponents = ((int)0x8E1E)		,
		MaxCombinedTessEvaluationUniformComponents = ((int)0x8E1F)		,
		TransformFeedback = ((int)0x8E22)		,
		TransformFeedbackBufferPaused = ((int)0x8E23)		,
		TransformFeedbackBufferActive = ((int)0x8E24)		,
		TransformFeedbackBinding = ((int)0x8E25)		,
		ActiveSubroutineUniformLocations = ((int)0x8E47)		,
		ActiveSubroutineMaxLength = ((int)0x8E48)		,
		ActiveSubroutineUniformMaxLength = ((int)0x8E49)		,
		NumCompatibleSubroutines = ((int)0x8E4A)		,
		CompatibleSubroutines = ((int)0x8E4B)		,
		MaxGeometryShaderInvocations = ((int)0x8E5A)		,
		MinFragmentInterpolationOffset = ((int)0x8E5B)		,
		MaxFragmentInterpolationOffset = ((int)0x8E5C)		,
		FragmentInterpolationOffsetBits = ((int)0x8E5D)		,
		MinProgramTextureGatherOffset = ((int)0x8E5E)		,
		MaxProgramTextureGatherOffset = ((int)0x8E5F)		,
		MaxTransformFeedbackBuffers = ((int)0x8E70)		,
		MaxVertexStreams = ((int)0x8E71)		,
		PatchVertices = ((int)0x8E72)		,
		PatchDefaultInnerLevel = ((int)0x8E73)		,
		PatchDefaultOuterLevel = ((int)0x8E74)		,
		TessControlOutputVertices = ((int)0x8E75)		,
		TessGenMode = ((int)0x8E76)		,
		TessGenSpacing = ((int)0x8E77)		,
		TessGenVertexOrder = ((int)0x8E78)		,
		TessGenPointMode = ((int)0x8E79)		,
		Isolines = ((int)0x8E7A)		,
		FractionalOdd = ((int)0x8E7B)		,
		FractionalEven = ((int)0x8E7C)		,
		MaxPatchVertices = ((int)0x8E7D)		,
		MaxTessGenLevel = ((int)0x8E7E)		,
		MaxTessControlUniformComponents = ((int)0x8E7F)		,
		MaxTessEvaluationUniformComponents = ((int)0x8E80)		,
		MaxTessControlTextureImageUnits = ((int)0x8E81)		,
		MaxTessEvaluationTextureImageUnits = ((int)0x8E82)		,
		MaxTessControlOutputComponents = ((int)0x8E83)		,
		MaxTessPatchComponents = ((int)0x8E84)		,
		MaxTessControlTotalOutputComponents = ((int)0x8E85)		,
		MaxTessEvaluationOutputComponents = ((int)0x8E86)		,
		TessEvaluationShader = ((int)0x8E87)		,
		TessControlShader = ((int)0x8E88)		,
		MaxTessControlUniformBlocks = ((int)0x8E89)		,
		MaxTessEvaluationUniformBlocks = ((int)0x8E8A)		,
		DrawIndirectBuffer = ((int)0x8F3F)		,
		DrawIndirectBufferBinding = ((int)0x8F43)		,
		DoubleMat2 = ((int)0x8F46)		,
		DoubleMat3 = ((int)0x8F47)		,
		DoubleMat4 = ((int)0x8F48)		,
		DoubleMat2x3 = ((int)0x8F49)		,
		DoubleMat2x4 = ((int)0x8F4A)		,
		DoubleMat3x2 = ((int)0x8F4B)		,
		DoubleMat3x4 = ((int)0x8F4C)		,
		DoubleMat4x2 = ((int)0x8F4D)		,
		DoubleMat4x3 = ((int)0x8F4E)		,
		DoubleVec2 = ((int)0x8FFC)		,
		DoubleVec3 = ((int)0x8FFD)		,
		DoubleVec4 = ((int)0x8FFE)		,
		TextureCubeMapArray = ((int)0x9009)		,
		TextureBindingCubeMapArray = ((int)0x900A)		,
		ProxyTextureCubeMapArray = ((int)0x900B)		,
		SamplerCubeMapArray = ((int)0x900C)		,
		SamplerCubeMapArrayShadow = ((int)0x900D)		,
		IntSamplerCubeMapArray = ((int)0x900E)		,
		UnsignedIntSamplerCubeMapArray = ((int)0x900F)		,
	}
	/*public enum Version41 : int {
		VertexShaderBit = ((int)0x00000001)		,
		FragmentShaderBit = ((int)0x00000002)		,
		GeometryShaderBit = ((int)0x00000004)		,
		TessControlShaderBit = ((int)0x00000008)		,
		TessEvaluationShaderBit = ((int)0x00000010)		,
		Fixed = ((int)0x140C)		,
		ProgramBinaryRetrievableHint = ((int)0x8257)		,
		ProgramSeparable = ((int)0x8258)		,
		ActiveProgram = ((int)0x8259)		,
		ProgramPipelineBinding = ((int)0x825A)		,
		MaxViewports = ((int)0x825B)		,
		ViewportSubpixelBits = ((int)0x825C)		,
		ViewportBoundsRange = ((int)0x825D)		,
		LayerProvokingVertex = ((int)0x825E)		,
		ViewportIndexProvokingVertex = ((int)0x825F)		,
		UndefinedVertex = ((int)0x8260)		,
		ProgramBinaryLength = ((int)0x8741)		,
		NumProgramBinaryFormats = ((int)0x87FE)		,
		ProgramBinaryFormats = ((int)0x87FF)		,
		ImplementationColorReadType = ((int)0x8B9A)		,
		ImplementationColorReadFormat = ((int)0x8B9B)		,
		LowFloat = ((int)0x8DF0)		,
		MediumFloat = ((int)0x8DF1)		,
		HighFloat = ((int)0x8DF2)		,
		LowInt = ((int)0x8DF3)		,
		MediumInt = ((int)0x8DF4)		,
		HighInt = ((int)0x8DF5)		,
		NumShaderBinaryFormats = ((int)0x8DF9)		,
		ShaderCompiler = ((int)0x8DFA)		,
		MaxVertexUniformVectors = ((int)0x8DFB)		,
		MaxVaryingVectors = ((int)0x8DFC)		,
		MaxFragmentUniformVectors = ((int)0x8DFD)		,
		AllShaderBits = unchecked((int)0xFFFFFFFF)		,
	}*/
	public enum VertexAttribDPointerType : int {
		Double = ((int)0x140A)		,
	}
	public enum VertexAttribIPointerType : int {
		Byte = ((int)0x1400)		,
		UnsignedByte = ((int)0x1401)		,
		Short = ((int)0x1402)		,
		UnsignedShort = ((int)0x1403)		,
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
	}
	public enum VertexAttribParameter : int {
		ArrayEnabled = ((int)0x8622)		,
		ArraySize = ((int)0x8623)		,
		ArrayStride = ((int)0x8624)		,
		ArrayType = ((int)0x8625)		,
		CurrentVertexAttrib = ((int)0x8626)		,
		ArrayNormalized = ((int)0x886A)		,
		VertexAttribArrayInteger = ((int)0x88FD)		,
		VertexAttribArrayDivisor = ((int)0x88FE)		,
	}
	public enum VertexAttribPointerParameter : int {
		ArrayPointer = ((int)0x8645)		,
	}
	public enum VertexAttribPointerType : int {
		Byte = ((int)0x1400)		,
		UnsignedByte = ((int)0x1401)		,
		Short = ((int)0x1402)		,
		UnsignedShort = ((int)0x1403)		,
		Int = ((int)0x1404)		,
		UnsignedInt = ((int)0x1405)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		HalfFloat = ((int)0x140B)		,
		Fixed = ((int)0x140C)		,
		UnsignedInt2101010Rev = ((int)0x8368)		,
		Int2101010Rev = ((int)0x8D9F)		,
	}
	public enum VertexPointerType : int {
		Short = ((int)0x1402)		,
		Int = ((int)0x1404)		,
		Float = ((int)0x1406)		,
		Double = ((int)0x140A)		,
		HalfFloat = ((int)0x140B)		,
		UnsignedInt2101010Rev = ((int)0x8368)		,
		Int2101010Rev = ((int)0x8D9F)		,
	}
    public enum All : int {
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000
        MultisampleBufferBit7Qcom = int.MinValue,
        //
        // Resumo:
        //     Original was GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        AllBarrierBits = -1,
        //
        // Resumo:
        //     Original was GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF
        AllBarrierBitsExt = -1,
        //
        // Resumo:
        //     Original was GL_ALL_SHADER_BITS = 0xFFFFFFFF
        AllShaderBits = -1,
        //
        // Resumo:
        //     Original was GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF
        AllShaderBitsExt = -1,
        //
        // Resumo:
        //     Original was GL_GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        GlAllBarrierBits = -1,
        //
        // Resumo:
        //     Original was GL_INVALID_INDEX = 0xFFFFFFFF
        InvalidIndex = -1,
        //
        // Resumo:
        //     Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        QueryAllEventBitsAmd = -1,
        //
        // Resumo:
        //     Original was GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF
        TimeoutIgnored = -1,
        //
        // Resumo:
        //     Original was GL_FALSE = 0
        False = 0,
        //
        // Resumo:
        //     Original was GL_LAYOUT_DEFAULT_INTEL = 0
        LayoutDefaultIntel = 0,
        //
        // Resumo:
        //     Original was GL_NO_ERROR = 0
        NoError = 0,
        //
        // Resumo:
        //     Original was GL_NONE = 0
        None = 0,
        //
        // Resumo:
        //     Original was GL_NONE_OES = 0
        NoneOes = 0,
        //
        // Resumo:
        //     Original was GL_ZERO = 0
        Zero = 0,
        //
        // Resumo:
        //     Original was GL_CLOSE_PATH_NV = 0x00
        ClosePathNv = 0,
        //
        // Resumo:
        //     Original was GL_Points = 0x0000
        Points = 0,
        //
        // Resumo:
        //     Original was GL_TERMINATE_SEQUENCE_COMMAND_NV = 0x0000
        TerminateSequenceCommandNv = 0,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000
        PerfquerySingleContextIntel = 0,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT0_QCOM = 0x00000001
        ColorBufferBit0Qcom = 1,
        //
        // Resumo:
        //     Original was GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001
        ContextCoreProfileBit = 1,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001
        ContextFlagForwardCompatibleBit = 1,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001
        PerfqueryGlobalContextIntel = 1,
        //
        // Resumo:
        //     Original was GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001
        QueryDepthPassEventBitAmd = 1,
        //
        // Resumo:
        //     Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        SyncFlushCommandsBit = 1,
        //
        // Resumo:
        //     Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        SyncFlushCommandsBitApple = 1,
        //
        // Resumo:
        //     Original was GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001
        TextureStorageSparseBitAmd = 1,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001
        VertexAttribArrayBarrierBit = 1,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001
        VertexAttribArrayBarrierBitExt = 1,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_BIT = 0x00000001
        VertexShaderBit = 1,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_BIT_EXT = 0x00000001
        VertexShaderBitExt = 1,
        //
        // Resumo:
        //     Original was GL_Lines = 0x0001
        Lines = 1,
        //
        // Resumo:
        //     Original was GL_MAP_READ_BIT = 0x0001
        MapReadBit = 1,
        //
        // Resumo:
        //     Original was GL_MAP_READ_BIT_EXT = 0x0001
        MapReadBitExt = 1,
        //
        // Resumo:
        //     Original was GL_NOP_COMMAND_NV = 0x0001
        NopCommandNv = 1,
        //
        // Resumo:
        //     Original was GL_BOLD_BIT_NV = 0x01
        BoldBitNv = 1,
        //
        // Resumo:
        //     Original was GL_GLYPH_WIDTH_BIT_NV = 0x01
        GlyphWidthBitNv = 1,
        //
        // Resumo:
        //     Original was GL_LAYOUT_LINEAR_INTEL = 1
        LayoutLinearIntel = 1,
        //
        // Resumo:
        //     Original was GL_ONE = 1
        One = 1,
        //
        // Resumo:
        //     Original was GL_TRUE = 1
        True = 1,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002
        ColorBufferBit1Qcom = 2,
        //
        // Resumo:
        //     Original was GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002
        ContextCompatibilityProfileBit = 2,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002
        ContextFlagDebugBit = 2,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002
        ContextFlagDebugBitKhr = 2,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002
        ElementArrayBarrierBit = 2,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002
        ElementArrayBarrierBitExt = 2,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_BIT = 0x00000002
        FragmentShaderBit = 2,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_BIT_EXT = 0x00000002
        FragmentShaderBitExt = 2,
        //
        // Resumo:
        //     Original was GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002
        QueryDepthFailEventBitAmd = 2,
        //
        // Resumo:
        //     Original was GL_DRAW_ELEMENTS_COMMAND_NV = 0x0002
        DrawElementsCommandNv = 2,
        //
        // Resumo:
        //     Original was GL_LINE_LOOP = 0x0002
        LineLoop = 2,
        //
        // Resumo:
        //     Original was GL_MAP_WRITE_BIT = 0x0002
        MapWriteBit = 2,
        //
        // Resumo:
        //     Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        MapWriteBitExt = 2,
        //
        // Resumo:
        //     Original was GL_GLYPH_HEIGHT_BIT_NV = 0x02
        GlyphHeightBitNv = 2,
        //
        // Resumo:
        //     Original was GL_ITALIC_BIT_NV = 0x02
        ItalicBitNv = 2,
        //
        // Resumo:
        //     Original was GL_MOVE_TO_NV = 0x02
        MoveToNv = 2,
        //
        // Resumo:
        //     Original was GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2
        LayoutLinearCpuCachedIntel = 2,
        //
        // Resumo:
        //     Original was GL_TWO = 2
        Two = 2,
        //
        // Resumo:
        //     Original was GL_DRAW_ARRAYS_COMMAND_NV = 0x0003
        DrawArraysCommandNv = 3,
        //
        // Resumo:
        //     Original was GL_LINE_STRIP = 0x0003
        LineStrip = 3,
        //
        // Resumo:
        //     Original was GL_RELATIVE_MOVE_TO_NV = 0x03
        RelativeMoveToNv = 3,
        //
        // Resumo:
        //     Original was GL_THREE = 3
        Three = 3,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004
        ColorBufferBit2Qcom = 4,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004
        ContextFlagRobustAccessBit = 4,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004
        ContextFlagRobustAccessBitArb = 4,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER_BIT = 0x00000004
        GeometryShaderBit = 4,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER_BIT_EXT = 0x00000004
        GeometryShaderBitExt = 4,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER_BIT_OES = 0x00000004
        GeometryShaderBitOes = 4,
        //
        // Resumo:
        //     Original was GL_GL_UNIFORM_BARRIER_BIT = 0x00000004
        GlUniformBarrierBit = 4,
        //
        // Resumo:
        //     Original was GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004
        QueryStencilFailEventBitAmd = 4,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        UniformBarrierBit = 4,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004
        UniformBarrierBitExt = 4,
        //
        // Resumo:
        //     Original was GL_DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004
        DrawElementsStripCommandNv = 4,
        //
        // Resumo:
        //     Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        MapInvalidateRangeBit = 4,
        //
        // Resumo:
        //     Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004
        MapInvalidateRangeBitExt = 4,
        //
        // Resumo:
        //     Original was GL_Triangles = 0x0004
        Triangles = 4,
        //
        // Resumo:
        //     Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04
        GlyphHorizontalBearingXBitNv = 4,
        //
        // Resumo:
        //     Original was GL_LINE_TO_NV = 0x04
        LineToNv = 4,
        //
        // Resumo:
        //     Original was GL_FOUR = 4
        Four = 4,
        //
        // Resumo:
        //     Original was GL_DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005
        DrawArraysStripCommandNv = 5,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_STRIP = 0x0005
        TriangleStrip = 5,
        //
        // Resumo:
        //     Original was GL_RELATIVE_LINE_TO_NV = 0x05
        RelativeLineToNv = 5,
        //
        // Resumo:
        //     Original was GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006
        DrawElementsInstancedCommandNv = 6,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_FAN = 0x0006
        TriangleFan = 6,
        //
        // Resumo:
        //     Original was GL_HORIZONTAL_LINE_TO_NV = 0x06
        HorizontalLineToNv = 6,
        //
        // Resumo:
        //     Original was GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007
        DrawArraysInstancedCommandNv = 7,
        //
        // Resumo:
        //     Original was GL_QUADS = 0x0007
        Quads = 7,
        //
        // Resumo:
        //     Original was GL_QUADS_EXT = 0x0007
        QuadsExt = 7,
        //
        // Resumo:
        //     Original was GL_RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07
        RelativeHorizontalLineToNv = 7,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT3_QCOM = 0x00000008
        ColorBufferBit3Qcom = 8,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008
        ContextFlagNoErrorBit = 8,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008
        ContextFlagNoErrorBitKhr = 8,
        //
        // Resumo:
        //     Original was GL_GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008
        GlTextureFetchBarrierBit = 8,
        //
        // Resumo:
        //     Original was GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008
        QueryDepthBoundsFailEventBitAmd = 8,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_SHADER_BIT = 0x00000008
        TessControlShaderBit = 8,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_SHADER_BIT_EXT = 0x00000008
        TessControlShaderBitExt = 8,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_SHADER_BIT_OES = 0x00000008
        TessControlShaderBitOes = 8,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008
        TextureFetchBarrierBit = 8,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008
        TextureFetchBarrierBitExt = 8,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ADDRESS_COMMAND_NV = 0x0008
        ElementAddressCommandNv = 8,
        //
        // Resumo:
        //     Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        MapInvalidateBufferBit = 8,
        //
        // Resumo:
        //     Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        MapInvalidateBufferBitExt = 8,
        //
        // Resumo:
        //     Original was GL_QUAD_STRIP = 0x0008
        QuadStrip = 8,
        //
        // Resumo:
        //     Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08
        GlyphHorizontalBearingYBitNv = 8,
        //
        // Resumo:
        //     Original was GL_VERTICAL_LINE_TO_NV = 0x08
        VerticalLineToNv = 8,
        //
        // Resumo:
        //     Original was GL_ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009
        AttributeAddressCommandNv = 9,
        //
        // Resumo:
        //     Original was GL_POLYGON = 0x0009
        Polygon = 9,
        //
        // Resumo:
        //     Original was GL_RELATIVE_VERTICAL_LINE_TO_NV = 0x09
        RelativeVerticalLineToNv = 9,
        //
        // Resumo:
        //     Original was GL_LINES_ADJACENCY = 0x000A
        LinesAdjacency = 10,
        //
        // Resumo:
        //     Original was GL_LINES_ADJACENCY_ARB = 0x000A
        LinesAdjacencyArb = 10,
        //
        // Resumo:
        //     Original was GL_LINES_ADJACENCY_EXT = 0x000A
        LinesAdjacencyExt = 10,
        //
        // Resumo:
        //     Original was GL_UNIFORM_ADDRESS_COMMAND_NV = 0x000A
        UniformAddressCommandNv = 10,
        //
        // Resumo:
        //     Original was GL_QUADRATIC_CURVE_TO_NV = 0x0A
        QuadraticCurveToNv = 10,
        //
        // Resumo:
        //     Original was GL_BLEND_COLOR_COMMAND_NV = 0x000B
        BlendColorCommandNv = 11,
        //
        // Resumo:
        //     Original was GL_LINE_STRIP_ADJACENCY = 0x000B
        LineStripAdjacency = 11,
        //
        // Resumo:
        //     Original was GL_LINE_STRIP_ADJACENCY_ARB = 0x000B
        LineStripAdjacencyArb = 11,
        //
        // Resumo:
        //     Original was GL_LINE_STRIP_ADJACENCY_EXT = 0x000B
        LineStripAdjacencyExt = 11,
        //
        // Resumo:
        //     Original was GL_RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B
        RelativeQuadraticCurveToNv = 11,
        //
        // Resumo:
        //     Original was GL_STENCIL_REF_COMMAND_NV = 0x000C
        StencilRefCommandNv = 12,
        //
        // Resumo:
        //     Original was GL_TRIANGLES_ADJACENCY = 0x000C
        TrianglesAdjacency = 12,
        //
        // Resumo:
        //     Original was GL_TRIANGLES_ADJACENCY_ARB = 0x000C
        TrianglesAdjacencyArb = 12,
        //
        // Resumo:
        //     Original was GL_TRIANGLES_ADJACENCY_EXT = 0x000C
        TrianglesAdjacencyExt = 12,
        //
        // Resumo:
        //     Original was GL_CUBIC_CURVE_TO_NV = 0x0C
        CubicCurveToNv = 12,
        //
        // Resumo:
        //     Original was GL_LINE_WIDTH_COMMAND_NV = 0x000D
        LineWidthCommandNv = 13,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_STRIP_ADJACENCY = 0x000D
        TriangleStripAdjacency = 13,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D
        TriangleStripAdjacencyArb = 13,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D
        TriangleStripAdjacencyExt = 13,
        //
        // Resumo:
        //     Original was GL_RELATIVE_CUBIC_CURVE_TO_NV = 0x0D
        RelativeCubicCurveToNv = 13,
        //
        // Resumo:
        //     Original was GL_PATCHES = 0x000E
        Patches = 14,
        //
        // Resumo:
        //     Original was GL_PATCHES_EXT = 0x000E
        PatchesExt = 14,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_COMMAND_NV = 0x000E
        PolygonOffsetCommandNv = 14,
        //
        // Resumo:
        //     Original was GL_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E
        SmoothQuadraticCurveToNv = 14,
        //
        // Resumo:
        //     Original was GL_ALPHA_REF_COMMAND_NV = 0x000F
        AlphaRefCommandNv = 15,
        //
        // Resumo:
        //     Original was GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F
        RelativeSmoothQuadraticCurveToNv = 15,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT4_QCOM = 0x00000010
        ColorBufferBit4Qcom = 16,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010
        ContextFlagProtectedContentBitExt = 16,
        //
        // Resumo:
        //     Original was GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010
        ShaderGlobalAccessBarrierBitNv = 16,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_SHADER_BIT = 0x00000010
        TessEvaluationShaderBit = 16,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_SHADER_BIT_EXT = 0x00000010
        TessEvaluationShaderBitExt = 16,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_SHADER_BIT_OES = 0x00000010
        TessEvaluationShaderBitOes = 16,
        //
        // Resumo:
        //     Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        MapFlushExplicitBit = 16,
        //
        // Resumo:
        //     Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010
        MapFlushExplicitBitExt = 16,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_COMMAND_NV = 0x0010
        ViewportCommandNv = 16,
        //
        // Resumo:
        //     Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        GlyphHorizontalBearingAdvanceBitNv = 16,
        //
        // Resumo:
        //     Original was GL_SMOOTH_CUBIC_CURVE_TO_NV = 0x10
        SmoothCubicCurveToNv = 16,
        //
        // Resumo:
        //     Original was GL_SCISSOR_COMMAND_NV = 0x0011
        ScissorCommandNv = 17,
        //
        // Resumo:
        //     Original was GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11
        RelativeSmoothCubicCurveToNv = 17,
        //
        // Resumo:
        //     Original was GL_FRONT_FACE_COMMAND_NV = 0x0012
        FrontFaceCommandNv = 18,
        //
        // Resumo:
        //     Original was GL_SMALL_CCW_ARC_TO_NV = 0x12
        SmallCcwArcToNv = 18,
        //
        // Resumo:
        //     Original was GL_RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13
        RelativeSmallCcwArcToNv = 19,
        //
        // Resumo:
        //     Original was GL_SMALL_CW_ARC_TO_NV = 0x14
        SmallCwArcToNv = 20,
        //
        // Resumo:
        //     Original was GL_RELATIVE_SMALL_CW_ARC_TO_NV = 0x15
        RelativeSmallCwArcToNv = 21,
        //
        // Resumo:
        //     Original was GL_LARGE_CCW_ARC_TO_NV = 0x16
        LargeCcwArcToNv = 22,
        //
        // Resumo:
        //     Original was GL_RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17
        RelativeLargeCcwArcToNv = 23,
        //
        // Resumo:
        //     Original was GL_LARGE_CW_ARC_TO_NV = 0x18
        LargeCwArcToNv = 24,
        //
        // Resumo:
        //     Original was GL_RELATIVE_LARGE_CW_ARC_TO_NV = 0x19
        RelativeLargeCwArcToNv = 25,
        //
        // Resumo:
        //     Original was GL_CONIC_CURVE_TO_NV = 0x1A
        ConicCurveToNv = 26,
        //
        // Resumo:
        //     Original was GL_RELATIVE_CONIC_CURVE_TO_NV = 0x1B
        RelativeConicCurveToNv = 27,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT5_QCOM = 0x00000020
        ColorBufferBit5Qcom = 32,
        //
        // Resumo:
        //     Original was GL_COMPUTE_SHADER_BIT = 0x00000020
        ComputeShaderBit = 32,
        //
        // Resumo:
        //     Original was GL_GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020
        GlShaderImageAccessBarrierBit = 32,
        //
        // Resumo:
        //     Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020
        ShaderImageAccessBarrierBit = 32,
        //
        // Resumo:
        //     Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020
        ShaderImageAccessBarrierBitExt = 32,
        //
        // Resumo:
        //     Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        MapUnsynchronizedBit = 32,
        //
        // Resumo:
        //     Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        MapUnsynchronizedBitExt = 32,
        //
        // Resumo:
        //     Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
        GlyphVerticalBearingXBitNv = 32,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT6_QCOM = 0x00000040
        ColorBufferBit6Qcom = 64,
        //
        // Resumo:
        //     Original was GL_COMMAND_BARRIER_BIT = 0x00000040
        CommandBarrierBit = 64,
        //
        // Resumo:
        //     Original was GL_COMMAND_BARRIER_BIT_EXT = 0x00000040
        CommandBarrierBitExt = 64,
        //
        // Resumo:
        //     Original was GL_MAP_PERSISTENT_BIT = 0x0040
        MapPersistentBit = 64,
        //
        // Resumo:
        //     Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        MapPersistentBitExt = 64,
        //
        // Resumo:
        //     Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
        GlyphVerticalBearingYBitNv = 64,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT7_QCOM = 0x00000080
        ColorBufferBit7Qcom = 128,
        //
        // Resumo:
        //     Original was GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080
        PixelBufferBarrierBit = 128,
        //
        // Resumo:
        //     Original was GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080
        PixelBufferBarrierBitExt = 128,
        //
        // Resumo:
        //     Original was GL_MAP_COHERENT_BIT = 0x0080
        MapCoherentBit = 128,
        //
        // Resumo:
        //     Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        MapCoherentBitExt = 128,
        //
        // Resumo:
        //     Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
        GlyphVerticalBearingAdvanceBitNv = 128,
        //
        // Resumo:
        //     Original was GL_SHARED_EDGE_NV = 0xC0
        SharedEdgeNv = 192,
        //
        // Resumo:
        //     Original was GL_ROUNDED_RECT_NV = 0xE8
        RoundedRectNv = 232,
        //
        // Resumo:
        //     Original was GL_RELATIVE_ROUNDED_RECT_NV = 0xE9
        RelativeRoundedRectNv = 233,
        //
        // Resumo:
        //     Original was GL_ROUNDED_RECT2_NV = 0xEA
        RoundedRect2Nv = 234,
        //
        // Resumo:
        //     Original was GL_RELATIVE_ROUNDED_RECT2_NV = 0xEB
        RelativeRoundedRect2Nv = 235,
        //
        // Resumo:
        //     Original was GL_ROUNDED_RECT4_NV = 0xEC
        RoundedRect4Nv = 236,
        //
        // Resumo:
        //     Original was GL_RELATIVE_ROUNDED_RECT4_NV = 0xED
        RelativeRoundedRect4Nv = 237,
        //
        // Resumo:
        //     Original was GL_ROUNDED_RECT8_NV = 0xEE
        RoundedRect8Nv = 238,
        //
        // Resumo:
        //     Original was GL_RELATIVE_ROUNDED_RECT8_NV = 0xEF
        RelativeRoundedRect8Nv = 239,
        //
        // Resumo:
        //     Original was GL_RESTART_PATH_NV = 0xF0
        RestartPathNv = 240,
        //
        // Resumo:
        //     Original was GL_DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2
        DupFirstCubicCurveToNv = 242,
        //
        // Resumo:
        //     Original was GL_DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4
        DupLastCubicCurveToNv = 244,
        //
        // Resumo:
        //     Original was GL_RECT_NV = 0xF6
        RectNv = 246,
        //
        // Resumo:
        //     Original was GL_RELATIVE_RECT_NV = 0xF7
        RelativeRectNv = 247,
        //
        // Resumo:
        //     Original was GL_CIRCULAR_CCW_ARC_TO_NV = 0xF8
        CircularCcwArcToNv = 248,
        //
        // Resumo:
        //     Original was GL_CIRCULAR_CW_ARC_TO_NV = 0xFA
        CircularCwArcToNv = 250,
        //
        // Resumo:
        //     Original was GL_CIRCULAR_TANGENT_ARC_TO_NV = 0xFC
        CircularTangentArcToNv = 252,
        //
        // Resumo:
        //     Original was GL_ARC_TO_NV = 0xFE
        ArcToNv = 254,
        //
        // Resumo:
        //     Original was GL_RELATIVE_ARC_TO_NV = 0xFF
        RelativeArcToNv = 255,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        DepthBufferBit = 256,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT0_QCOM = 0x00000100
        DepthBufferBit0Qcom = 256,
        //
        // Resumo:
        //     Original was GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100
        TextureUpdateBarrierBit = 256,
        //
        // Resumo:
        //     Original was GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100
        TextureUpdateBarrierBitExt = 256,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_STORAGE_BIT = 0x0100
        DynamicStorageBit = 256,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100
        DynamicStorageBitExt = 256,
        //
        // Resumo:
        //     Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        GlyphHasKerningBitNv = 256,
        //
        // Resumo:
        //     Original was GL_ADD = 0x0104
        Add = 260,
        //
        // Resumo:
        //     Original was GL_ACCUM_BUFFER_BIT = 0x00000200
        AccumBufferBit = 512,
        //
        // Resumo:
        //     Original was GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200
        BufferUpdateBarrierBit = 512,
        //
        // Resumo:
        //     Original was GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200
        BufferUpdateBarrierBitExt = 512,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT1_QCOM = 0x00000200
        DepthBufferBit1Qcom = 512,
        //
        // Resumo:
        //     Original was GL_CLIENT_STORAGE_BIT = 0x0200
        ClientStorageBit = 512,
        //
        // Resumo:
        //     Original was GL_CLIENT_STORAGE_BIT_EXT = 0x0200
        ClientStorageBitExt = 512,
        //
        // Resumo:
        //     Original was GL_NEVER = 0x0200
        Never = 512,
        //
        // Resumo:
        //     Original was GL_LESS = 0x0201
        Less = 513,
        //
        // Resumo:
        //     Original was GL_EQUAL = 0x0202
        Equal = 514,
        //
        // Resumo:
        //     Original was GL_LEQUAL = 0x0203
        Lequal = 515,
        //
        // Resumo:
        //     Original was GL_GREATER = 0x0204
        Greater = 516,
        //
        // Resumo:
        //     Original was GL_NOTEQUAL = 0x0205
        Notequal = 517,
        //
        // Resumo:
        //     Original was GL_GEQUAL = 0x0206
        Gequal = 518,
        //
        // Resumo:
        //     Original was GL_ALWAYS = 0x0207
        Always = 519,
        //
        // Resumo:
        //     Original was GL_SRC_COLOR = 0x0300
        SrcColor = 768,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        OneMinusSrcColor = 769,
        //
        // Resumo:
        //     Original was GL_SRC_ALPHA = 0x0302
        SrcAlpha = 770,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        OneMinusSrcAlpha = 771,
        //
        // Resumo:
        //     Original was GL_DST_ALPHA = 0x0304
        DstAlpha = 772,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        OneMinusDstAlpha = 773,
        //
        // Resumo:
        //     Original was GL_DST_COLOR = 0x0306
        DstColor = 774,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        OneMinusDstColor = 775,
        //
        // Resumo:
        //     Original was GL_SRC_ALPHA_SATURATE = 0x0308
        SrcAlphaSaturate = 776,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT2_QCOM = 0x00000400
        DepthBufferBit2Qcom = 1024,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400
        FramebufferBarrierBit = 1024,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400
        FramebufferBarrierBitExt = 1024,
        //
        // Resumo:
        //     Original was GL_GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400
        GlFramebufferBarrierBit = 1024,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        StencilBufferBit = 1024,
        //
        // Resumo:
        //     Original was GL_FRONT_LEFT = 0x0400
        FrontLeft = 1024,
        //
        // Resumo:
        //     Original was GL_SPARSE_STORAGE_BIT_ARB = 0x0400
        SparseStorageBitArb = 1024,
        //
        // Resumo:
        //     Original was GL_FRONT_RIGHT = 0x0401
        FrontRight = 1025,
        //
        // Resumo:
        //     Original was GL_BACK_LEFT = 0x0402
        BackLeft = 1026,
        //
        // Resumo:
        //     Original was GL_BACK_RIGHT = 0x0403
        BackRight = 1027,
        //
        // Resumo:
        //     Original was GL_FRONT = 0x0404
        Front = 1028,
        //
        // Resumo:
        //     Original was GL_BACK = 0x0405
        Back = 1029,
        //
        // Resumo:
        //     Original was GL_LEFT = 0x0406
        Left = 1030,
        //
        // Resumo:
        //     Original was GL_RIGHT = 0x0407
        Right = 1031,
        //
        // Resumo:
        //     Original was GL_FRONT_AND_BACK = 0x0408
        FrontAndBack = 1032,
        //
        // Resumo:
        //     Original was GL_AUX0 = 0x0409
        Aux0 = 1033,
        //
        // Resumo:
        //     Original was GL_AUX1 = 0x040A
        Aux1 = 1034,
        //
        // Resumo:
        //     Original was GL_AUX2 = 0x040B
        Aux2 = 1035,
        //
        // Resumo:
        //     Original was GL_AUX3 = 0x040C
        Aux3 = 1036,
        //
        // Resumo:
        //     Original was GL_INVALID_ENUM = 0x0500
        InvalidEnum = 1280,
        //
        // Resumo:
        //     Original was GL_INVALID_VALUE = 0x0501
        InvalidValue = 1281,
        //
        // Resumo:
        //     Original was GL_INVALID_OPERATION = 0x0502
        InvalidOperation = 1282,
        //
        // Resumo:
        //     Original was GL_STACK_OVERFLOW = 0x0503
        StackOverflow = 1283,
        //
        // Resumo:
        //     Original was GL_STACK_OVERFLOW_KHR = 0x0503
        StackOverflowKhr = 1283,
        //
        // Resumo:
        //     Original was GL_STACK_UNDERFLOW = 0x0504
        StackUnderflow = 1284,
        //
        // Resumo:
        //     Original was GL_STACK_UNDERFLOW_KHR = 0x0504
        StackUnderflowKhr = 1284,
        //
        // Resumo:
        //     Original was GL_OUT_OF_MEMORY = 0x0505
        OutOfMemory = 1285,
        //
        // Resumo:
        //     Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        InvalidFramebufferOperation = 1286,
        //
        // Resumo:
        //     Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506
        InvalidFramebufferOperationExt = 1286,
        //
        // Resumo:
        //     Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        InvalidFramebufferOperationOes = 1286,
        //
        // Resumo:
        //     Original was GL_CONTEXT_LOST = 0x0507
        ContextLost = 1287,
        //
        // Resumo:
        //     Original was GL_CONTEXT_LOST_KHR = 0x0507
        ContextLostKhr = 1287,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT3_QCOM = 0x00000800
        DepthBufferBit3Qcom = 2048,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800
        TransformFeedbackBarrierBit = 2048,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800
        TransformFeedbackBarrierBitExt = 2048,
        //
        // Resumo:
        //     Original was GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800
        LgpuSeparateStorageBitNvx = 2048,
        //
        // Resumo:
        //     Original was GL_PER_GPU_STORAGE_BIT_NV = 0x0800
        PerGpuStorageBitNv = 2048,
        //
        // Resumo:
        //     Original was GL_CW = 0x0900
        Cw = 2304,
        //
        // Resumo:
        //     Original was GL_CCW = 0x0901
        Ccw = 2305,
        //
        // Resumo:
        //     Original was GL_COEFF = 0x0A00
        Coeff = 2560,
        //
        // Resumo:
        //     Original was GL_ORDER = 0x0A01
        Order = 2561,
        //
        // Resumo:
        //     Original was GL_DOMAIN = 0x0A02
        Domain = 2562,
        //
        // Resumo:
        //     Original was GL_POINT_SMOOTH = 0x0B10
        PointSmooth = 2832,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE = 0x0B11
        PointSize = 2833,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_RANGE = 0x0B12
        PointSizeRange = 2834,
        //
        // Resumo:
        //     Original was GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12
        SmoothPointSizeRange = 2834,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_GRANULARITY = 0x0B13
        PointSizeGranularity = 2835,
        //
        // Resumo:
        //     Original was GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13
        SmoothPointSizeGranularity = 2835,
        //
        // Resumo:
        //     Original was GL_LINE_SMOOTH = 0x0B20
        LineSmooth = 2848,
        //
        // Resumo:
        //     Original was GL_LINE_WIDTH = 0x0B21
        LineWidth = 2849,
        //
        // Resumo:
        //     Original was GL_LINE_WIDTH_RANGE = 0x0B22
        LineWidthRange = 2850,
        //
        // Resumo:
        //     Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22
        SmoothLineWidthRange = 2850,
        //
        // Resumo:
        //     Original was GL_LINE_WIDTH_GRANULARITY = 0x0B23
        LineWidthGranularity = 2851,
        //
        // Resumo:
        //     Original was GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23
        SmoothLineWidthGranularity = 2851,
        //
        // Resumo:
        //     Original was GL_LINE_STIPPLE = 0x0B24
        LineStipple = 2852,
        //
        // Resumo:
        //     Original was GL_POLYGON_MODE = 0x0B40
        PolygonMode = 2880,
        //
        // Resumo:
        //     Original was GL_POLYGON_SMOOTH = 0x0B41
        PolygonSmooth = 2881,
        //
        // Resumo:
        //     Original was GL_POLYGON_STIPPLE = 0x0B42
        PolygonStipple = 2882,
        //
        // Resumo:
        //     Original was GL_CULL_FACE = 0x0B44
        CullFace = 2884,
        //
        // Resumo:
        //     Original was GL_CULL_FACE_MODE = 0x0B45
        CullFaceMode = 2885,
        //
        // Resumo:
        //     Original was GL_FRONT_FACE = 0x0B46
        FrontFace = 2886,
        //
        // Resumo:
        //     Original was GL_LIGHTING = 0x0B50
        Lighting = 2896,
        //
        // Resumo:
        //     Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        LightModelLocalViewer = 2897,
        //
        // Resumo:
        //     Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        LightModelTwoSide = 2898,
        //
        // Resumo:
        //     Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        LightModelAmbient = 2899,
        //
        // Resumo:
        //     Original was GL_COLOR_MATERIAL = 0x0B57
        ColorMaterial = 2903,
        //
        // Resumo:
        //     Original was GL_FOG = 0x0B60
        Fog = 2912,
        //
        // Resumo:
        //     Original was GL_FOG_INDEX = 0x0B61
        FogIndex = 2913,
        //
        // Resumo:
        //     Original was GL_FOG_DENSITY = 0x0B62
        FogDensity = 2914,
        //
        // Resumo:
        //     Original was GL_FOG_START = 0x0B63
        FogStart = 2915,
        //
        // Resumo:
        //     Original was GL_FOG_END = 0x0B64
        FogEnd = 2916,
        //
        // Resumo:
        //     Original was GL_FOG_MODE = 0x0B65
        FogMode = 2917,
        //
        // Resumo:
        //     Original was GL_FOG_COLOR = 0x0B66
        FogColor = 2918,
        //
        // Resumo:
        //     Original was GL_DEPTH_RANGE = 0x0B70
        DepthRange = 2928,
        //
        // Resumo:
        //     Original was GL_DEPTH_TEST = 0x0B71
        DepthTest = 2929,
        //
        // Resumo:
        //     Original was GL_DEPTH_WRITEMASK = 0x0B72
        DepthWritemask = 2930,
        //
        // Resumo:
        //     Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        DepthClearValue = 2931,
        //
        // Resumo:
        //     Original was GL_DEPTH_FUNC = 0x0B74
        DepthFunc = 2932,
        //
        // Resumo:
        //     Original was GL_STENCIL_TEST = 0x0B90
        StencilTest = 2960,
        //
        // Resumo:
        //     Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        StencilClearValue = 2961,
        //
        // Resumo:
        //     Original was GL_STENCIL_FUNC = 0x0B92
        StencilFunc = 2962,
        //
        // Resumo:
        //     Original was GL_STENCIL_VALUE_MASK = 0x0B93
        StencilValueMask = 2963,
        //
        // Resumo:
        //     Original was GL_STENCIL_FAIL = 0x0B94
        StencilFail = 2964,
        //
        // Resumo:
        //     Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        StencilPassDepthFail = 2965,
        //
        // Resumo:
        //     Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        StencilPassDepthPass = 2966,
        //
        // Resumo:
        //     Original was GL_STENCIL_REF = 0x0B97
        StencilRef = 2967,
        //
        // Resumo:
        //     Original was GL_STENCIL_WRITEMASK = 0x0B98
        StencilWritemask = 2968,
        //
        // Resumo:
        //     Original was GL_NORMALIZE = 0x0BA1
        Normalize = 2977,
        //
        // Resumo:
        //     Original was GL_VIEWPORT = 0x0BA2
        Viewport = 2978,
        //
        // Resumo:
        //     Original was GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3
        Modelview0StackDepthExt = 2979,
        //
        // Resumo:
        //     Original was GL_PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3
        PathModelviewStackDepthNv = 2979,
        //
        // Resumo:
        //     Original was GL_PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4
        PathProjectionStackDepthNv = 2980,
        //
        // Resumo:
        //     Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        Modelview0MatrixExt = 2982,
        //
        // Resumo:
        //     Original was GL_PATH_MODELVIEW_MATRIX_NV = 0x0BA6
        PathModelviewMatrixNv = 2982,
        //
        // Resumo:
        //     Original was GL_PATH_PROJECTION_MATRIX_NV = 0x0BA7
        PathProjectionMatrixNv = 2983,
        //
        // Resumo:
        //     Original was GL_ALPHA_TEST = 0x0BC0
        AlphaTest = 3008,
        //
        // Resumo:
        //     Original was GL_ALPHA_TEST_QCOM = 0x0BC0
        AlphaTestQcom = 3008,
        //
        // Resumo:
        //     Original was GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1
        AlphaTestFuncQcom = 3009,
        //
        // Resumo:
        //     Original was GL_ALPHA_TEST_REF_QCOM = 0x0BC2
        AlphaTestRefQcom = 3010,
        //
        // Resumo:
        //     Original was GL_DITHER = 0x0BD0
        Dither = 3024,
        //
        // Resumo:
        //     Original was GL_BLEND_DST = 0x0BE0
        BlendDst = 3040,
        //
        // Resumo:
        //     Original was GL_BLEND_SRC = 0x0BE1
        BlendSrc = 3041,
        //
        // Resumo:
        //     Original was GL_BLEND = 0x0BE2
        Blend = 3042,
        //
        // Resumo:
        //     Original was GL_LOGIC_OP_MODE = 0x0BF0
        LogicOpMode = 3056,
        //
        // Resumo:
        //     Original was GL_INDEX_LOGIC_OP = 0x0BF1
        IndexLogicOp = 3057,
        //
        // Resumo:
        //     Original was GL_LOGIC_OP = 0x0BF1
        LogicOp = 3057,
        //
        // Resumo:
        //     Original was GL_COLOR_LOGIC_OP = 0x0BF2
        ColorLogicOp = 3058,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER = 0x0C01
        DrawBuffer = 3073,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER_EXT = 0x0C01
        DrawBufferExt = 3073,
        //
        // Resumo:
        //     Original was GL_READ_BUFFER = 0x0C02
        ReadBuffer = 3074,
        //
        // Resumo:
        //     Original was GL_READ_BUFFER_EXT = 0x0C02
        ReadBufferExt = 3074,
        //
        // Resumo:
        //     Original was GL_READ_BUFFER_NV = 0x0C02
        ReadBufferNv = 3074,
        //
        // Resumo:
        //     Original was GL_SCISSOR_BOX = 0x0C10
        ScissorBox = 3088,
        //
        // Resumo:
        //     Original was GL_SCISSOR_TEST = 0x0C11
        ScissorTest = 3089,
        //
        // Resumo:
        //     Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        ColorClearValue = 3106,
        //
        // Resumo:
        //     Original was GL_COLOR_WRITEMASK = 0x0C23
        ColorWritemask = 3107,
        //
        // Resumo:
        //     Original was GL_DOUBLEBUFFER = 0x0C32
        Doublebuffer = 3122,
        //
        // Resumo:
        //     Original was GL_STEREO = 0x0C33
        Stereo = 3123,
        //
        // Resumo:
        //     Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        PerspectiveCorrectionHint = 3152,
        //
        // Resumo:
        //     Original was GL_POINT_SMOOTH_HINT = 0x0C51
        PointSmoothHint = 3153,
        //
        // Resumo:
        //     Original was GL_LINE_SMOOTH_HINT = 0x0C52
        LineSmoothHint = 3154,
        //
        // Resumo:
        //     Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        PolygonSmoothHint = 3155,
        //
        // Resumo:
        //     Original was GL_FOG_HINT = 0x0C54
        FogHint = 3156,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GEN_S = 0x0C60
        TextureGenS = 3168,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GEN_T = 0x0C61
        TextureGenT = 3169,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GEN_R = 0x0C62
        TextureGenR = 3170,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GEN_Q = 0x0C63
        TextureGenQ = 3171,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        PixelMapIToI = 3184,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        PixelMapSToS = 3185,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        PixelMapIToR = 3186,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        PixelMapIToG = 3187,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        PixelMapIToB = 3188,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        PixelMapIToA = 3189,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        PixelMapRToR = 3190,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        PixelMapGToG = 3191,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        PixelMapBToB = 3192,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        PixelMapAToA = 3193,
        //
        // Resumo:
        //     Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        UnpackSwapBytes = 3312,
        //
        // Resumo:
        //     Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        UnpackLsbFirst = 3313,
        //
        // Resumo:
        //     Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        UnpackRowLength = 3314,
        //
        // Resumo:
        //     Original was GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2
        UnpackRowLengthExt = 3314,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        UnpackSkipRows = 3315,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3
        UnpackSkipRowsExt = 3315,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        UnpackSkipPixels = 3316,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4
        UnpackSkipPixelsExt = 3316,
        //
        // Resumo:
        //     Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        UnpackAlignment = 3317,
        //
        // Resumo:
        //     Original was GL_PACK_SWAP_BYTES = 0x0D00
        PackSwapBytes = 3328,
        //
        // Resumo:
        //     Original was GL_PACK_LSB_FIRST = 0x0D01
        PackLsbFirst = 3329,
        //
        // Resumo:
        //     Original was GL_PACK_ROW_LENGTH = 0x0D02
        PackRowLength = 3330,
        //
        // Resumo:
        //     Original was GL_PACK_SKIP_ROWS = 0x0D03
        PackSkipRows = 3331,
        //
        // Resumo:
        //     Original was GL_PACK_SKIP_PIXELS = 0x0D04
        PackSkipPixels = 3332,
        //
        // Resumo:
        //     Original was GL_PACK_ALIGNMENT = 0x0D05
        PackAlignment = 3333,
        //
        // Resumo:
        //     Original was GL_MAP_COLOR = 0x0D10
        MapColor = 3344,
        //
        // Resumo:
        //     Original was GL_MAP_STENCIL = 0x0D11
        MapStencil = 3345,
        //
        // Resumo:
        //     Original was GL_INDEX_SHIFT = 0x0D12
        IndexShift = 3346,
        //
        // Resumo:
        //     Original was GL_INDEX_OFFSET = 0x0D13
        IndexOffset = 3347,
        //
        // Resumo:
        //     Original was GL_RED_SCALE = 0x0D14
        RedScale = 3348,
        //
        // Resumo:
        //     Original was GL_RED_BIAS = 0x0D15
        RedBias = 3349,
        //
        // Resumo:
        //     Original was GL_GREEN_SCALE = 0x0D18
        GreenScale = 3352,
        //
        // Resumo:
        //     Original was GL_GREEN_BIAS = 0x0D19
        GreenBias = 3353,
        //
        // Resumo:
        //     Original was GL_BLUE_SCALE = 0x0D1A
        BlueScale = 3354,
        //
        // Resumo:
        //     Original was GL_BLUE_BIAS = 0x0D1B
        BlueBias = 3355,
        //
        // Resumo:
        //     Original was GL_ALPHA_SCALE = 0x0D1C
        AlphaScale = 3356,
        //
        // Resumo:
        //     Original was GL_ALPHA_BIAS = 0x0D1D
        AlphaBias = 3357,
        //
        // Resumo:
        //     Original was GL_DEPTH_SCALE = 0x0D1E
        DepthScale = 3358,
        //
        // Resumo:
        //     Original was GL_DEPTH_BIAS = 0x0D1F
        DepthBias = 3359,
        //
        // Resumo:
        //     Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        MaxClipDistances = 3378,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        MaxTextureSize = 3379,
        //
        // Resumo:
        //     Original was GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36
        PathMaxModelviewStackDepthNv = 3382,
        //
        // Resumo:
        //     Original was GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38
        PathMaxProjectionStackDepthNv = 3384,
        //
        // Resumo:
        //     Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        MaxViewportDims = 3386,
        //
        // Resumo:
        //     Original was GL_SUBPIXEL_BITS = 0x0D50
        SubpixelBits = 3408,
        //
        // Resumo:
        //     Original was GL_AUTO_NORMAL = 0x0D80
        AutoNormal = 3456,
        //
        // Resumo:
        //     Original was GL_MAP1_COLOR_4 = 0x0D90
        Map1Color4 = 3472,
        //
        // Resumo:
        //     Original was GL_MAP1_INDEX = 0x0D91
        Map1Index = 3473,
        //
        // Resumo:
        //     Original was GL_MAP1_NORMAL = 0x0D92
        Map1Normal = 3474,
        //
        // Resumo:
        //     Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        Map1TextureCoord1 = 3475,
        //
        // Resumo:
        //     Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        Map1TextureCoord2 = 3476,
        //
        // Resumo:
        //     Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        Map1TextureCoord3 = 3477,
        //
        // Resumo:
        //     Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        Map1TextureCoord4 = 3478,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_3 = 0x0D97
        Map1Vertex3 = 3479,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_4 = 0x0D98
        Map1Vertex4 = 3480,
        //
        // Resumo:
        //     Original was GL_MAP2_COLOR_4 = 0x0DB0
        Map2Color4 = 3504,
        //
        // Resumo:
        //     Original was GL_MAP2_INDEX = 0x0DB1
        Map2Index = 3505,
        //
        // Resumo:
        //     Original was GL_MAP2_NORMAL = 0x0DB2
        Map2Normal = 3506,
        //
        // Resumo:
        //     Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        Map2TextureCoord1 = 3507,
        //
        // Resumo:
        //     Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        Map2TextureCoord2 = 3508,
        //
        // Resumo:
        //     Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        Map2TextureCoord3 = 3509,
        //
        // Resumo:
        //     Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        Map2TextureCoord4 = 3510,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_3 = 0x0DB7
        Map2Vertex3 = 3511,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_4 = 0x0DB8
        Map2Vertex4 = 3512,
        //
        // Resumo:
        //     Original was GL_TEXTURE_1D = 0x0DE0
        Texture1D = 3552,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D = 0x0DE1
        Texture2D = 3553,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000
        AtomicCounterBarrierBit = 4096,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000
        AtomicCounterBarrierBitExt = 4096,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT4_QCOM = 0x00001000
        DepthBufferBit4Qcom = 4096,
        //
        // Resumo:
        //     Original was GL_GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000
        GlAtomicCounterBarrierBit = 4096,
        //
        // Resumo:
        //     Original was GL_TEXTURE_WIDTH = 0x1000
        TextureWidth = 4096,
        //
        // Resumo:
        //     Original was GL_TEXTURE_HEIGHT = 0x1001
        TextureHeight = 4097,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPONENTS = 0x1003
        TextureComponents = 4099,
        //
        // Resumo:
        //     Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        TextureInternalFormat = 4099,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        TextureBorderColor = 4100,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BORDER_COLOR_NV = 0x1004
        TextureBorderColorNv = 4100,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BORDER = 0x1005
        TextureBorder = 4101,
        //
        // Resumo:
        //     Original was GL_TEXTURE_TARGET = 0x1006
        TextureTarget = 4102,
        //
        // Resumo:
        //     Original was GL_DONT_CARE = 0x1100
        DontCare = 4352,
        //
        // Resumo:
        //     Original was GL_FASTEST = 0x1101
        Fastest = 4353,
        //
        // Resumo:
        //     Original was GL_NICEST = 0x1102
        Nicest = 4354,
        //
        // Resumo:
        //     Original was GL_AMBIENT = 0x1200
        Ambient = 4608,
        //
        // Resumo:
        //     Original was GL_DIFFUSE = 0x1201
        Diffuse = 4609,
        //
        // Resumo:
        //     Original was GL_SPECULAR = 0x1202
        Specular = 4610,
        //
        // Resumo:
        //     Original was GL_BYTE = 0x1400
        Byte = 5120,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_BYTE = 0x1401
        UnsignedByte = 5121,
        //
        // Resumo:
        //     Original was GL_SHORT = 0x1402
        Short = 5122,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT = 0x1403
        UnsignedShort = 5123,
        //
        // Resumo:
        //     Original was GL_INT = 0x1404
        Int = 5124,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT = 0x1405
        UnsignedInt = 5125,
        //
        // Resumo:
        //     Original was GL_FLOAT = 0x1406
        Float = 5126,
        //
        // Resumo:
        //     Original was GL_2_BYTES_NV = 0x1407
        Gl2BytesNv = 5127,
        //
        // Resumo:
        //     Original was GL_3_BYTES_NV = 0x1408
        Gl3BytesNv = 5128,
        //
        // Resumo:
        //     Original was GL_4_BYTES_NV = 0x1409
        Gl4BytesNv = 5129,
        //
        // Resumo:
        //     Original was GL_DOUBLE = 0x140A
        Double = 5130,
        //
        // Resumo:
        //     Original was GL_HALF_FLOAT = 0x140B
        HalfFloat = 5131,
        //
        // Resumo:
        //     Original was GL_FIXED = 0x140C
        Fixed = 5132,
        //
        // Resumo:
        //     Original was GL_INT64_ARB = 0x140E
        Int64Arb = 5134,
        //
        // Resumo:
        //     Original was GL_INT64_NV = 0x140E
        Int64Nv = 5134,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_ARB = 0x140F
        UnsignedInt64Arb = 5135,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_NV = 0x140F
        UnsignedInt64Nv = 5135,
        //
        // Resumo:
        //     Original was GL_CLEAR = 0x1500
        Clear = 5376,
        //
        // Resumo:
        //     Original was GL_AND = 0x1501
        And = 5377,
        //
        // Resumo:
        //     Original was GL_AND_REVERSE = 0x1502
        AndReverse = 5378,
        //
        // Resumo:
        //     Original was GL_COPY = 0x1503
        Copy = 5379,
        //
        // Resumo:
        //     Original was GL_AND_INVERTED = 0x1504
        AndInverted = 5380,
        //
        // Resumo:
        //     Original was GL_NOOP = 0x1505
        Noop = 5381,
        //
        // Resumo:
        //     Original was GL_XOR = 0x1506
        Xor = 5382,
        //
        // Resumo:
        //     Original was GL_XOR_NV = 0x1506
        XorNv = 5382,
        //
        // Resumo:
        //     Original was GL_OR = 0x1507
        Or = 5383,
        //
        // Resumo:
        //     Original was GL_NOR = 0x1508
        Nor = 5384,
        //
        // Resumo:
        //     Original was GL_EQUIV = 0x1509
        Equiv = 5385,
        //
        // Resumo:
        //     Original was GL_INVERT = 0x150A
        Invert = 5386,
        //
        // Resumo:
        //     Original was GL_OR_REVERSE = 0x150B
        OrReverse = 5387,
        //
        // Resumo:
        //     Original was GL_COPY_INVERTED = 0x150C
        CopyInverted = 5388,
        //
        // Resumo:
        //     Original was GL_OR_INVERTED = 0x150D
        OrInverted = 5389,
        //
        // Resumo:
        //     Original was GL_NAND = 0x150E
        Nand = 5390,
        //
        // Resumo:
        //     Original was GL_SET = 0x150F
        Set = 5391,
        //
        // Resumo:
        //     Original was GL_EMISSION = 0x1600
        Emission = 5632,
        //
        // Resumo:
        //     Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        AmbientAndDiffuse = 5634,
        //
        // Resumo:
        //     Original was GL_MODELVIEW0_EXT = 0x1700
        Modelview0Ext = 5888,
        //
        // Resumo:
        //     Original was GL_PATH_MODELVIEW_NV = 0x1700
        PathModelviewNv = 5888,
        //
        // Resumo:
        //     Original was GL_PATH_PROJECTION_NV = 0x1701
        PathProjectionNv = 5889,
        //
        // Resumo:
        //     Original was GL_TEXTURE = 0x1702
        Texture = 5890,
        //
        // Resumo:
        //     Original was GL_COLOR = 0x1800
        Color = 6144,
        //
        // Resumo:
        //     Original was GL_COLOR_EXT = 0x1800
        ColorExt = 6144,
        //
        // Resumo:
        //     Original was GL_DEPTH = 0x1801
        Depth = 6145,
        //
        // Resumo:
        //     Original was GL_DEPTH_EXT = 0x1801
        DepthExt = 6145,
        //
        // Resumo:
        //     Original was GL_STENCIL = 0x1802
        Stencil = 6146,
        //
        // Resumo:
        //     Original was GL_STENCIL_EXT = 0x1802
        StencilExt = 6146,
        //
        // Resumo:
        //     Original was GL_COLOR_INDEX = 0x1900
        ColorIndex = 6400,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX = 0x1901
        StencilIndex = 6401,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT = 0x1902
        DepthComponent = 6402,
        //
        // Resumo:
        //     Original was GL_RED = 0x1903
        Red = 6403,
        //
        // Resumo:
        //     Original was GL_RED_EXT = 0x1903
        RedExt = 6403,
        //
        // Resumo:
        //     Original was GL_RED_NV = 0x1903
        RedNv = 6403,
        //
        // Resumo:
        //     Original was GL_GREEN = 0x1904
        Green = 6404,
        //
        // Resumo:
        //     Original was GL_GREEN_NV = 0x1904
        GreenNv = 6404,
        //
        // Resumo:
        //     Original was GL_BLUE = 0x1905
        Blue = 6405,
        //
        // Resumo:
        //     Original was GL_BLUE_NV = 0x1905
        BlueNv = 6405,
        //
        // Resumo:
        //     Original was GL_ALPHA = 0x1906
        Alpha = 6406,
        //
        // Resumo:
        //     Original was GL_RGB = 0x1907
        Rgb = 6407,
        //
        // Resumo:
        //     Original was GL_RGBA = 0x1908
        Rgba = 6408,
        //
        // Resumo:
        //     Original was GL_LUMINANCE = 0x1909
        Luminance = 6409,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA = 0x190A
        LuminanceAlpha = 6410,
        //
        // Resumo:
        //     Original was GL_POINT = 0x1B00
        Point = 6912,
        //
        // Resumo:
        //     Original was GL_LINE = 0x1B01
        Line = 6913,
        //
        // Resumo:
        //     Original was GL_FILL = 0x1B02
        Fill = 6914,
        //
        // Resumo:
        //     Original was GL_KEEP = 0x1E00
        Keep = 7680,
        //
        // Resumo:
        //     Original was GL_REPLACE = 0x1E01
        Replace = 7681,
        //
        // Resumo:
        //     Original was GL_INCR = 0x1E02
        Incr = 7682,
        //
        // Resumo:
        //     Original was GL_DECR = 0x1E03
        Decr = 7683,
        //
        // Resumo:
        //     Original was GL_VENDOR = 0x1F00
        Vendor = 7936,
        //
        // Resumo:
        //     Original was GL_RENDERER = 0x1F01
        Renderer = 7937,
        //
        // Resumo:
        //     Original was GL_VERSION = 0x1F02
        Version = 7938,
        //
        // Resumo:
        //     Original was GL_EXTENSIONS = 0x1F03
        Extensions = 7939,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT5_QCOM = 0x00002000
        DepthBufferBit5Qcom = 8192,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000
        ShaderStorageBarrierBit = 8192,
        //
        // Resumo:
        //     Original was GL_MODULATE = 0x2100
        Modulate = 8448,
        //
        // Resumo:
        //     Original was GL_EYE_LINEAR = 0x2400
        EyeLinear = 9216,
        //
        // Resumo:
        //     Original was GL_EYE_LINEAR_NV = 0x2400
        EyeLinearNv = 9216,
        //
        // Resumo:
        //     Original was GL_OBJECT_LINEAR = 0x2401
        ObjectLinear = 9217,
        //
        // Resumo:
        //     Original was GL_OBJECT_LINEAR_NV = 0x2401
        ObjectLinearNv = 9217,
        //
        // Resumo:
        //     Original was GL_NEAREST = 0x2600
        Nearest = 9728,
        //
        // Resumo:
        //     Original was GL_LINEAR = 0x2601
        Linear = 9729,
        //
        // Resumo:
        //     Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        NearestMipmapNearest = 9984,
        //
        // Resumo:
        //     Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        LinearMipmapNearest = 9985,
        //
        // Resumo:
        //     Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        NearestMipmapLinear = 9986,
        //
        // Resumo:
        //     Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        LinearMipmapLinear = 9987,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAG_FILTER = 0x2800
        TextureMagFilter = 10240,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MIN_FILTER = 0x2801
        TextureMinFilter = 10241,
        //
        // Resumo:
        //     Original was GL_TEXTURE_WRAP_S = 0x2802
        TextureWrapS = 10242,
        //
        // Resumo:
        //     Original was GL_TEXTURE_WRAP_T = 0x2803
        TextureWrapT = 10243,
        //
        // Resumo:
        //     Original was GL_REPEAT = 0x2901
        Repeat = 10497,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        PolygonOffsetUnits = 10752,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        PolygonOffsetPoint = 10753,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        PolygonOffsetLine = 10754,
        //
        // Resumo:
        //     Original was GL_R3_G3_B2 = 0x2A10
        R3G3B2 = 10768,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE0 = 0x3000
        ClipDistance0 = 12288,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE0 = 0x3000
        ClipPlane0 = 12288,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE1 = 0x3001
        ClipDistance1 = 12289,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE1 = 0x3001
        ClipPlane1 = 12289,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE2 = 0x3002
        ClipDistance2 = 12290,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE2 = 0x3002
        ClipPlane2 = 12290,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE3 = 0x3003
        ClipDistance3 = 12291,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE3 = 0x3003
        ClipPlane3 = 12291,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE4 = 0x3004
        ClipDistance4 = 12292,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE4 = 0x3004
        ClipPlane4 = 12292,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE5 = 0x3005
        ClipDistance5 = 12293,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE5 = 0x3005
        ClipPlane5 = 12293,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE6 = 0x3006
        ClipDistance6 = 12294,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE7 = 0x3007
        ClipDistance7 = 12295,
        //
        // Resumo:
        //     Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000
        ClientMappedBufferBarrierBit = 16384,
        //
        // Resumo:
        //     Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000
        ClientMappedBufferBarrierBitExt = 16384,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT = 0x00004000
        ColorBufferBit = 16384,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT6_QCOM = 0x00004000
        DepthBufferBit6Qcom = 16384,
        //
        // Resumo:
        //     Original was GL_LIGHT0 = 0x4000
        Light0 = 16384,
        //
        // Resumo:
        //     Original was GL_LIGHT1 = 0x4001
        Light1 = 16385,
        //
        // Resumo:
        //     Original was GL_LIGHT2 = 0x4002
        Light2 = 16386,
        //
        // Resumo:
        //     Original was GL_LIGHT3 = 0x4003
        Light3 = 16387,
        //
        // Resumo:
        //     Original was GL_LIGHT4 = 0x4004
        Light4 = 16388,
        //
        // Resumo:
        //     Original was GL_LIGHT5 = 0x4005
        Light5 = 16389,
        //
        // Resumo:
        //     Original was GL_LIGHT6 = 0x4006
        Light6 = 16390,
        //
        // Resumo:
        //     Original was GL_LIGHT7 = 0x4007
        Light7 = 16391,
        //
        // Resumo:
        //     Original was GL_COVERAGE_BUFFER_BIT_NV = 0x00008000
        CoverageBufferBitNv = 32768,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT7_QCOM = 0x00008000
        DepthBufferBit7Qcom = 32768,
        //
        // Resumo:
        //     Original was GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000
        QueryBufferBarrierBit = 32768,
        //
        // Resumo:
        //     Original was GL_ABGR_EXT = 0x8000
        AbgrExt = 32768,
        //
        // Resumo:
        //     Original was GL_CONSTANT_COLOR = 0x8001
        ConstantColor = 32769,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        OneMinusConstantColor = 32770,
        //
        // Resumo:
        //     Original was GL_CONSTANT_ALPHA = 0x8003
        ConstantAlpha = 32771,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        OneMinusConstantAlpha = 32772,
        //
        // Resumo:
        //     Original was GL_BLEND_COLOR = 0x8005
        BlendColor = 32773,
        //
        // Resumo:
        //     Original was GL_BLEND_COLOR_EXT = 0x8005
        BlendColorExt = 32773,
        //
        // Resumo:
        //     Original was GL_FUNC_ADD = 0x8006
        FuncAdd = 32774,
        //
        // Resumo:
        //     Original was GL_FUNC_ADD_EXT = 0x8006
        FuncAddExt = 32774,
        //
        // Resumo:
        //     Original was GL_MIN = 0x8007
        Min = 32775,
        //
        // Resumo:
        //     Original was GL_MIN_EXT = 0x8007
        MinExt = 32775,
        //
        // Resumo:
        //     Original was GL_MAX = 0x8008
        Max = 32776,
        //
        // Resumo:
        //     Original was GL_MAX_EXT = 0x8008
        MaxExt = 32776,
        //
        // Resumo:
        //     Original was GL_BLEND_EQUATION = 0x8009
        BlendEquation = 32777,
        //
        // Resumo:
        //     Original was GL_BLEND_EQUATION_EXT = 0x8009
        BlendEquationExt = 32777,
        //
        // Resumo:
        //     Original was GL_BLEND_EQUATION_RGB = 0x8009
        BlendEquationRgb = 32777,
        //
        // Resumo:
        //     Original was GL_FUNC_SUBTRACT = 0x800A
        FuncSubtract = 32778,
        //
        // Resumo:
        //     Original was GL_FUNC_SUBTRACT_EXT = 0x800A
        FuncSubtractExt = 32778,
        //
        // Resumo:
        //     Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        FuncReverseSubtract = 32779,
        //
        // Resumo:
        //     Original was GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B
        FuncReverseSubtractExt = 32779,
        //
        // Resumo:
        //     Original was GL_CMYK_EXT = 0x800C
        CmykExt = 32780,
        //
        // Resumo:
        //     Original was GL_CMYKA_EXT = 0x800D
        CmykaExt = 32781,
        //
        // Resumo:
        //     Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        PackCmykHintExt = 32782,
        //
        // Resumo:
        //     Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        UnpackCmykHintExt = 32783,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_1D = 0x8010
        Convolution1D = 32784,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_1D_EXT = 0x8010
        Convolution1DExt = 32784,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_2D = 0x8011
        Convolution2D = 32785,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_2D_EXT = 0x8011
        Convolution2DExt = 32785,
        //
        // Resumo:
        //     Original was GL_SEPARABLE_2D = 0x8012
        Separable2D = 32786,
        //
        // Resumo:
        //     Original was GL_SEPARABLE_2D_EXT = 0x8012
        Separable2DExt = 32786,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        ConvolutionBorderMode = 32787,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        ConvolutionBorderModeExt = 32787,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        ConvolutionFilterScale = 32788,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        ConvolutionFilterScaleExt = 32788,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        ConvolutionFilterBias = 32789,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        ConvolutionFilterBiasExt = 32789,
        //
        // Resumo:
        //     Original was GL_REDUCE = 0x8016
        Reduce = 32790,
        //
        // Resumo:
        //     Original was GL_REDUCE_EXT = 0x8016
        ReduceExt = 32790,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_FORMAT = 0x8017
        ConvolutionFormat = 32791,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_FORMAT_EXT = 0x8017
        ConvolutionFormatExt = 32791,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_WIDTH = 0x8018
        ConvolutionWidth = 32792,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_WIDTH_EXT = 0x8018
        ConvolutionWidthExt = 32792,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_HEIGHT = 0x8019
        ConvolutionHeight = 32793,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_HEIGHT_EXT = 0x8019
        ConvolutionHeightExt = 32793,
        //
        // Resumo:
        //     Original was GL_MAX_CONVOLUTION_WIDTH = 0x801A
        MaxConvolutionWidth = 32794,
        //
        // Resumo:
        //     Original was GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A
        MaxConvolutionWidthExt = 32794,
        //
        // Resumo:
        //     Original was GL_MAX_CONVOLUTION_HEIGHT = 0x801B
        MaxConvolutionHeight = 32795,
        //
        // Resumo:
        //     Original was GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B
        MaxConvolutionHeightExt = 32795,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_RED_SCALE = 0x801C
        PostConvolutionRedScale = 32796,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        PostConvolutionRedScaleExt = 32796,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D
        PostConvolutionGreenScale = 32797,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        PostConvolutionGreenScaleExt = 32797,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E
        PostConvolutionBlueScale = 32798,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        PostConvolutionBlueScaleExt = 32798,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F
        PostConvolutionAlphaScale = 32799,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        PostConvolutionAlphaScaleExt = 32799,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_RED_BIAS = 0x8020
        PostConvolutionRedBias = 32800,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        PostConvolutionRedBiasExt = 32800,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021
        PostConvolutionGreenBias = 32801,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        PostConvolutionGreenBiasExt = 32801,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022
        PostConvolutionBlueBias = 32802,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        PostConvolutionBlueBiasExt = 32802,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023
        PostConvolutionAlphaBias = 32803,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        PostConvolutionAlphaBiasExt = 32803,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM = 0x8024
        Histogram = 32804,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_EXT = 0x8024
        HistogramExt = 32804,
        //
        // Resumo:
        //     Original was GL_PROXY_HISTOGRAM = 0x8025
        ProxyHistogram = 32805,
        //
        // Resumo:
        //     Original was GL_PROXY_HISTOGRAM_EXT = 0x8025
        ProxyHistogramExt = 32805,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_WIDTH = 0x8026
        HistogramWidth = 32806,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_WIDTH_EXT = 0x8026
        HistogramWidthExt = 32806,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_FORMAT = 0x8027
        HistogramFormat = 32807,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_FORMAT_EXT = 0x8027
        HistogramFormatExt = 32807,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_RED_SIZE = 0x8028
        HistogramRedSize = 32808,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_RED_SIZE_EXT = 0x8028
        HistogramRedSizeExt = 32808,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_GREEN_SIZE = 0x8029
        HistogramGreenSize = 32809,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029
        HistogramGreenSizeExt = 32809,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_BLUE_SIZE = 0x802A
        HistogramBlueSize = 32810,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A
        HistogramBlueSizeExt = 32810,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_ALPHA_SIZE = 0x802B
        HistogramAlphaSize = 32811,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B
        HistogramAlphaSizeExt = 32811,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C
        HistogramLuminanceSize = 32812,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C
        HistogramLuminanceSizeExt = 32812,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_SINK = 0x802D
        HistogramSink = 32813,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_SINK_EXT = 0x802D
        HistogramSinkExt = 32813,
        //
        // Resumo:
        //     Original was GL_MINMAX = 0x802E
        Minmax = 32814,
        //
        // Resumo:
        //     Original was GL_MINMAX_EXT = 0x802E
        MinmaxExt = 32814,
        //
        // Resumo:
        //     Original was GL_MINMAX_FORMAT = 0x802F
        MinmaxFormat = 32815,
        //
        // Resumo:
        //     Original was GL_MINMAX_FORMAT_EXT = 0x802F
        MinmaxFormatExt = 32815,
        //
        // Resumo:
        //     Original was GL_MINMAX_SINK = 0x8030
        MinmaxSink = 32816,
        //
        // Resumo:
        //     Original was GL_MINMAX_SINK_EXT = 0x8030
        MinmaxSinkExt = 32816,
        //
        // Resumo:
        //     Original was GL_TABLE_TOO_LARGE = 0x8031
        TableTooLarge = 32817,
        //
        // Resumo:
        //     Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        TableTooLargeExt = 32817,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_BYTE_3_3_2 = 0x8032
        UnsignedByte332 = 32818,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
        UnsignedByte332Ext = 32818,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        UnsignedShort4444 = 32819,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
        UnsignedShort4444Ext = 32819,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        UnsignedShort5551 = 32820,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        UnsignedShort5551Ext = 32820,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_8_8_8_8 = 0x8035
        UnsignedInt8888 = 32821,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
        UnsignedInt8888Ext = 32821,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_10_10_10_2 = 0x8036
        UnsignedInt1010102 = 32822,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
        UnsignedInt1010102Ext = 32822,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_FILL = 0x8037
        PolygonOffsetFill = 32823,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        PolygonOffsetFactor = 32824,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_BIAS_EXT = 0x8039
        PolygonOffsetBiasExt = 32825,
        //
        // Resumo:
        //     Original was GL_RESCALE_NORMAL = 0x803A
        RescaleNormal = 32826,
        //
        // Resumo:
        //     Original was GL_RESCALE_NORMAL_EXT = 0x803A
        RescaleNormalExt = 32826,
        //
        // Resumo:
        //     Original was GL_RGB2_EXT = 0x804E
        Rgb2Ext = 32846,
        //
        // Resumo:
        //     Original was GL_RGB4 = 0x804F
        Rgb4 = 32847,
        //
        // Resumo:
        //     Original was GL_RGB4_EXT = 0x804F
        Rgb4Ext = 32847,
        //
        // Resumo:
        //     Original was GL_RGB5 = 0x8050
        Rgb5 = 32848,
        //
        // Resumo:
        //     Original was GL_RGB5_EXT = 0x8050
        Rgb5Ext = 32848,
        //
        // Resumo:
        //     Original was GL_RGB8 = 0x8051
        Rgb8 = 32849,
        //
        // Resumo:
        //     Original was GL_RGB8_EXT = 0x8051
        Rgb8Ext = 32849,
        //
        // Resumo:
        //     Original was GL_RGB8_OES = 0x8051
        Rgb8Oes = 32849,
        //
        // Resumo:
        //     Original was GL_RGB10 = 0x8052
        Rgb10 = 32850,
        //
        // Resumo:
        //     Original was GL_RGB10_EXT = 0x8052
        Rgb10Ext = 32850,
        //
        // Resumo:
        //     Original was GL_RGB12 = 0x8053
        Rgb12 = 32851,
        //
        // Resumo:
        //     Original was GL_RGB12_EXT = 0x8053
        Rgb12Ext = 32851,
        //
        // Resumo:
        //     Original was GL_RGB16 = 0x8054
        Rgb16 = 32852,
        //
        // Resumo:
        //     Original was GL_RGB16_EXT = 0x8054
        Rgb16Ext = 32852,
        //
        // Resumo:
        //     Original was GL_RGBA2 = 0x8055
        Rgba2 = 32853,
        //
        // Resumo:
        //     Original was GL_RGBA4 = 0x8056
        Rgba4 = 32854,
        //
        // Resumo:
        //     Original was GL_RGBA4_EXT = 0x8056
        Rgba4Ext = 32854,
        //
        // Resumo:
        //     Original was GL_RGBA4_OES = 0x8056
        Rgba4Oes = 32854,
        //
        // Resumo:
        //     Original was GL_RGB5_A1 = 0x8057
        Rgb5A1 = 32855,
        //
        // Resumo:
        //     Original was GL_RGB5_A1_EXT = 0x8057
        Rgb5A1Ext = 32855,
        //
        // Resumo:
        //     Original was GL_RGB5_A1_OES = 0x8057
        Rgb5A1Oes = 32855,
        //
        // Resumo:
        //     Original was GL_RGBA8 = 0x8058
        Rgba8 = 32856,
        //
        // Resumo:
        //     Original was GL_RGBA8_EXT = 0x8058
        Rgba8Ext = 32856,
        //
        // Resumo:
        //     Original was GL_RGBA8_OES = 0x8058
        Rgba8Oes = 32856,
        //
        // Resumo:
        //     Original was GL_RGB10_A2 = 0x8059
        Rgb10A2 = 32857,
        //
        // Resumo:
        //     Original was GL_RGB10_A2_EXT = 0x8059
        Rgb10A2Ext = 32857,
        //
        // Resumo:
        //     Original was GL_RGBA12 = 0x805A
        Rgba12 = 32858,
        //
        // Resumo:
        //     Original was GL_RGBA12_EXT = 0x805A
        Rgba12Ext = 32858,
        //
        // Resumo:
        //     Original was GL_RGBA16 = 0x805B
        Rgba16 = 32859,
        //
        // Resumo:
        //     Original was GL_RGBA16_EXT = 0x805B
        Rgba16Ext = 32859,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RED_SIZE = 0x805C
        TextureRedSize = 32860,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        TextureGreenSize = 32861,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        TextureBlueSize = 32862,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        TextureAlphaSize = 32863,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        TextureLuminanceSize = 32864,
        //
        // Resumo:
        //     Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        TextureIntensitySize = 32865,
        //
        // Resumo:
        //     Original was GL_REPLACE_EXT = 0x8062
        ReplaceExt = 32866,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_1D = 0x8063
        ProxyTexture1D = 32867,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_1D_EXT = 0x8063
        ProxyTexture1DExt = 32867,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_2D = 0x8064
        ProxyTexture2D = 32868,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_2D_EXT = 0x8064
        ProxyTexture2DExt = 32868,
        //
        // Resumo:
        //     Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        TextureTooLargeExt = 32869,
        //
        // Resumo:
        //     Original was GL_TEXTURE_PRIORITY = 0x8066
        TexturePriority = 32870,
        //
        // Resumo:
        //     Original was GL_TEXTURE_PRIORITY_EXT = 0x8066
        TexturePriorityExt = 32870,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RESIDENT = 0x8067
        TextureResident = 32871,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_1D = 0x8068
        TextureBinding1D = 32872,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_2D = 0x8069
        TextureBinding2D = 32873,
        //
        // Resumo:
        //     Original was GL_TEXTURE_3D_BINDING_EXT = 0x806A
        Texture3DBindingExt = 32874,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_3D = 0x806A
        TextureBinding3D = 32874,
        //
        // Resumo:
        //     Original was GL_PACK_SKIP_IMAGES = 0x806B
        PackSkipImages = 32875,
        //
        // Resumo:
        //     Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        PackSkipImagesExt = 32875,
        //
        // Resumo:
        //     Original was GL_PACK_IMAGE_HEIGHT = 0x806C
        PackImageHeight = 32876,
        //
        // Resumo:
        //     Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        PackImageHeightExt = 32876,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        UnpackSkipImages = 32877,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        UnpackSkipImagesExt = 32877,
        //
        // Resumo:
        //     Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        UnpackImageHeight = 32878,
        //
        // Resumo:
        //     Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        UnpackImageHeightExt = 32878,
        //
        // Resumo:
        //     Original was GL_TEXTURE_3D = 0x806F
        Texture3D = 32879,
        //
        // Resumo:
        //     Original was GL_TEXTURE_3D_EXT = 0x806F
        Texture3DExt = 32879,
        //
        // Resumo:
        //     Original was GL_TEXTURE_3D_OES = 0x806F
        Texture3DOes = 32879,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_3D = 0x8070
        ProxyTexture3D = 32880,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_3D_EXT = 0x8070
        ProxyTexture3DExt = 32880,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEPTH = 0x8071
        TextureDepth = 32881,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEPTH_EXT = 0x8071
        TextureDepthExt = 32881,
        //
        // Resumo:
        //     Original was GL_TEXTURE_WRAP_R = 0x8072
        TextureWrapR = 32882,
        //
        // Resumo:
        //     Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
        TextureWrapRExt = 32882,
        //
        // Resumo:
        //     Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        TextureWrapROes = 32882,
        //
        // Resumo:
        //     Original was GL_MAX_3D_TEXTURE_SIZE = 0x8073
        Max3DTextureSize = 32883,
        //
        // Resumo:
        //     Original was GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073
        Max3DTextureSizeExt = 32883,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY = 0x8074
        VertexArray = 32884,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_KHR = 0x8074
        VertexArrayKhr = 32884,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY = 0x8075
        NormalArray = 32885,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY = 0x8076
        ColorArray = 32886,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY = 0x8077
        IndexArray = 32887,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        TextureCoordArray = 32888,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY = 0x8079
        EdgeFlagArray = 32889,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
        VertexArrayCountExt = 32893,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
        NormalArrayCountExt = 32896,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_COUNT_EXT = 0x8084
        ColorArrayCountExt = 32900,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_COUNT_EXT = 0x8087
        IndexArrayCountExt = 32903,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
        TextureCoordArrayCountExt = 32907,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
        EdgeFlagArrayCountExt = 32909,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
        VertexArrayPointerExt = 32910,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
        NormalArrayPointerExt = 32911,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_POINTER_EXT = 0x8090
        ColorArrayPointerExt = 32912,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_POINTER_EXT = 0x8091
        IndexArrayPointerExt = 32913,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
        TextureCoordArrayPointerExt = 32914,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093
        EdgeFlagArrayPointerExt = 32915,
        //
        // Resumo:
        //     Original was GL_INTERLACE_SGIX = 0x8094
        InterlaceSgix = 32916,
        //
        // Resumo:
        //     Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
        DetailTexture2DSgis = 32917,
        //
        // Resumo:
        //     Original was GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096
        DetailTexture2DBindingSgis = 32918,
        //
        // Resumo:
        //     Original was GL_LINEAR_DETAIL_SGIS = 0x8097
        LinearDetailSgis = 32919,
        //
        // Resumo:
        //     Original was GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
        LinearDetailAlphaSgis = 32920,
        //
        // Resumo:
        //     Original was GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
        LinearDetailColorSgis = 32921,
        //
        // Resumo:
        //     Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
        DetailTextureLevelSgis = 32922,
        //
        // Resumo:
        //     Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
        DetailTextureModeSgis = 32923,
        //
        // Resumo:
        //     Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
        DetailTextureFuncPointsSgis = 32924,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE = 0x809D
        Multisample = 32925,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_SGIS = 0x809D
        MultisampleSgis = 32925,
        //
        // Resumo:
        //     Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        SampleAlphaToCoverage = 32926,
        //
        // Resumo:
        //     Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        SampleAlphaToMaskSgis = 32926,
        //
        // Resumo:
        //     Original was GL_SAMPLE_ALPHA_TO_ONE = 0x809F
        SampleAlphaToOne = 32927,
        //
        // Resumo:
        //     Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        SampleAlphaToOneSgis = 32927,
        //
        // Resumo:
        //     Original was GL_SAMPLE_COVERAGE = 0x80A0
        SampleCoverage = 32928,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        SampleMaskSgis = 32928,
        //
        // Resumo:
        //     Original was GL_1PASS_EXT = 0x80A1
        Gl1PassExt = 32929,
        //
        // Resumo:
        //     Original was GL_1PASS_SGIS = 0x80A1
        Gl1PassSgis = 32929,
        //
        // Resumo:
        //     Original was GL_2PASS_0_EXT = 0x80A2
        Gl2Pass0Ext = 32930,
        //
        // Resumo:
        //     Original was GL_2PASS_0_SGIS = 0x80A2
        Gl2Pass0Sgis = 32930,
        //
        // Resumo:
        //     Original was GL_2PASS_1_EXT = 0x80A3
        Gl2Pass1Ext = 32931,
        //
        // Resumo:
        //     Original was GL_2PASS_1_SGIS = 0x80A3
        Gl2Pass1Sgis = 32931,
        //
        // Resumo:
        //     Original was GL_4PASS_0_EXT = 0x80A4
        Gl4Pass0Ext = 32932,
        //
        // Resumo:
        //     Original was GL_4PASS_0_SGIS = 0x80A4
        Gl4Pass0Sgis = 32932,
        //
        // Resumo:
        //     Original was GL_4PASS_1_EXT = 0x80A5
        Gl4Pass1Ext = 32933,
        //
        // Resumo:
        //     Original was GL_4PASS_1_SGIS = 0x80A5
        Gl4Pass1Sgis = 32933,
        //
        // Resumo:
        //     Original was GL_4PASS_2_EXT = 0x80A6
        Gl4Pass2Ext = 32934,
        //
        // Resumo:
        //     Original was GL_4PASS_2_SGIS = 0x80A6
        Gl4Pass2Sgis = 32934,
        //
        // Resumo:
        //     Original was GL_4PASS_3_EXT = 0x80A7
        Gl4Pass3Ext = 32935,
        //
        // Resumo:
        //     Original was GL_4PASS_3_SGIS = 0x80A7
        Gl4Pass3Sgis = 32935,
        //
        // Resumo:
        //     Original was GL_SAMPLE_BUFFERS = 0x80A8
        SampleBuffers = 32936,
        //
        // Resumo:
        //     Original was GL_SAMPLE_BUFFERS_SGIS = 0x80A8
        SampleBuffersSgis = 32936,
        //
        // Resumo:
        //     Original was GL_SAMPLES = 0x80A9
        Samples = 32937,
        //
        // Resumo:
        //     Original was GL_SAMPLES_SGIS = 0x80A9
        SamplesSgis = 32937,
        //
        // Resumo:
        //     Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        SampleCoverageValue = 32938,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        SampleMaskValueSgis = 32938,
        //
        // Resumo:
        //     Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        SampleCoverageInvert = 32939,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        SampleMaskInvertSgis = 32939,
        //
        // Resumo:
        //     Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        SamplePatternSgis = 32940,
        //
        // Resumo:
        //     Original was GL_LINEAR_SHARPEN_SGIS = 0x80AD
        LinearSharpenSgis = 32941,
        //
        // Resumo:
        //     Original was GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
        LinearSharpenAlphaSgis = 32942,
        //
        // Resumo:
        //     Original was GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
        LinearSharpenColorSgis = 32943,
        //
        // Resumo:
        //     Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        SharpenTextureFuncPointsSgis = 32944,
        //
        // Resumo:
        //     Original was GL_COLOR_MATRIX = 0x80B1
        ColorMatrix = 32945,
        //
        // Resumo:
        //     Original was GL_COLOR_MATRIX_SGI = 0x80B1
        ColorMatrixSgi = 32945,
        //
        // Resumo:
        //     Original was GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2
        ColorMatrixStackDepth = 32946,
        //
        // Resumo:
        //     Original was GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
        ColorMatrixStackDepthSgi = 32946,
        //
        // Resumo:
        //     Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3
        MaxColorMatrixStackDepth = 32947,
        //
        // Resumo:
        //     Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
        MaxColorMatrixStackDepthSgi = 32947,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4
        PostColorMatrixRedScale = 32948,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        PostColorMatrixRedScaleSgi = 32948,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5
        PostColorMatrixGreenScale = 32949,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        PostColorMatrixGreenScaleSgi = 32949,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6
        PostColorMatrixBlueScale = 32950,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        PostColorMatrixBlueScaleSgi = 32950,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7
        PostColorMatrixAlphaScale = 32951,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        PostColorMatrixAlphaScaleSgi = 32951,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8
        PostColorMatrixRedBias = 32952,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        PostColorMatrixRedBiasSgi = 32952,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9
        PostColorMatrixGreenBias = 32953,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        PostColorMatrixGreenBiasSgi = 32953,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA
        PostColorMatrixBlueBias = 32954,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        PostColorMatrixBlueBiasSgi = 32954,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB
        PostColorMatrixAlphaBias = 32955,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        PostColorMatrixAlphaBiasSgi = 32955,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        TextureColorTableSgi = 32956,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD
        ProxyTextureColorTableSgi = 32957,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE
        TextureEnvBiasSgix = 32958,
        //
        // Resumo:
        //     Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        ShadowAmbientSgix = 32959,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_FAIL_VALUE = 0x80BF
        TextureCompareFailValue = 32959,
        //
        // Resumo:
        //     Original was GL_BLEND_DST_RGB = 0x80C8
        BlendDstRgb = 32968,
        //
        // Resumo:
        //     Original was GL_BLEND_SRC_RGB = 0x80C9
        BlendSrcRgb = 32969,
        //
        // Resumo:
        //     Original was GL_BLEND_DST_ALPHA = 0x80CA
        BlendDstAlpha = 32970,
        //
        // Resumo:
        //     Original was GL_BLEND_SRC_ALPHA = 0x80CB
        BlendSrcAlpha = 32971,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE = 0x80D0
        ColorTable = 32976,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_SGI = 0x80D0
        ColorTableSgi = 32976,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        PostConvolutionColorTable = 32977,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        PostConvolutionColorTableSgi = 32977,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        PostColorMatrixColorTable = 32978,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        PostColorMatrixColorTableSgi = 32978,
        //
        // Resumo:
        //     Original was GL_PROXY_COLOR_TABLE = 0x80D3
        ProxyColorTable = 32979,
        //
        // Resumo:
        //     Original was GL_PROXY_COLOR_TABLE_SGI = 0x80D3
        ProxyColorTableSgi = 32979,
        //
        // Resumo:
        //     Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4
        ProxyPostConvolutionColorTable = 32980,
        //
        // Resumo:
        //     Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4
        ProxyPostConvolutionColorTableSgi = 32980,
        //
        // Resumo:
        //     Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5
        ProxyPostColorMatrixColorTable = 32981,
        //
        // Resumo:
        //     Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5
        ProxyPostColorMatrixColorTableSgi = 32981,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_SCALE = 0x80D6
        ColorTableScale = 32982,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_SCALE_SGI = 0x80D6
        ColorTableScaleSgi = 32982,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_BIAS = 0x80D7
        ColorTableBias = 32983,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_BIAS_SGI = 0x80D7
        ColorTableBiasSgi = 32983,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_FORMAT = 0x80D8
        ColorTableFormat = 32984,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_FORMAT_SGI = 0x80D8
        ColorTableFormatSgi = 32984,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_WIDTH = 0x80D9
        ColorTableWidth = 32985,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_WIDTH_SGI = 0x80D9
        ColorTableWidthSgi = 32985,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_RED_SIZE = 0x80DA
        ColorTableRedSize = 32986,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA
        ColorTableRedSizeSgi = 32986,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_GREEN_SIZE = 0x80DB
        ColorTableGreenSize = 32987,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB
        ColorTableGreenSizeSgi = 32987,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_BLUE_SIZE = 0x80DC
        ColorTableBlueSize = 32988,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC
        ColorTableBlueSizeSgi = 32988,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD
        ColorTableAlphaSize = 32989,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD
        ColorTableAlphaSizeSgi = 32989,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE
        ColorTableLuminanceSize = 32990,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE
        ColorTableLuminanceSizeSgi = 32990,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF
        ColorTableIntensitySize = 32991,
        //
        // Resumo:
        //     Original was GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF
        ColorTableIntensitySizeSgi = 32991,
        //
        // Resumo:
        //     Original was GL_BGR = 0x80E0
        Bgr = 32992,
        //
        // Resumo:
        //     Original was GL_BGRA = 0x80E1
        Bgra = 32993,
        //
        // Resumo:
        //     Original was GL_MAX_ELEMENTS_VERTICES = 0x80E8
        MaxElementsVertices = 33000,
        //
        // Resumo:
        //     Original was GL_MAX_ELEMENTS_INDICES = 0x80E9
        MaxElementsIndices = 33001,
        //
        // Resumo:
        //     Original was GL_PHONG_HINT_WIN = 0x80EB
        PhongHintWin = 33003,
        //
        // Resumo:
        //     Original was GL_PARAMETER_BUFFER = 0x80EE
        ParameterBuffer = 33006,
        //
        // Resumo:
        //     Original was GL_PARAMETER_BUFFER_ARB = 0x80EE
        ParameterBufferArb = 33006,
        //
        // Resumo:
        //     Original was GL_PARAMETER_BUFFER_BINDING = 0x80EF
        ParameterBufferBinding = 33007,
        //
        // Resumo:
        //     Original was GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF
        ParameterBufferBindingArb = 33007,
        //
        // Resumo:
        //     Original was GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
        ClipVolumeClippingHintExt = 33008,
        //
        // Resumo:
        //     Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        DualAlpha4Sgis = 33040,
        //
        // Resumo:
        //     Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        DualAlpha8Sgis = 33041,
        //
        // Resumo:
        //     Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        DualAlpha12Sgis = 33042,
        //
        // Resumo:
        //     Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        DualAlpha16Sgis = 33043,
        //
        // Resumo:
        //     Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        DualLuminance4Sgis = 33044,
        //
        // Resumo:
        //     Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        DualLuminance8Sgis = 33045,
        //
        // Resumo:
        //     Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        DualLuminance12Sgis = 33046,
        //
        // Resumo:
        //     Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        DualLuminance16Sgis = 33047,
        //
        // Resumo:
        //     Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        DualIntensity4Sgis = 33048,
        //
        // Resumo:
        //     Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        DualIntensity8Sgis = 33049,
        //
        // Resumo:
        //     Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        DualIntensity12Sgis = 33050,
        //
        // Resumo:
        //     Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        DualIntensity16Sgis = 33051,
        //
        // Resumo:
        //     Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        DualLuminanceAlpha4Sgis = 33052,
        //
        // Resumo:
        //     Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        DualLuminanceAlpha8Sgis = 33053,
        //
        // Resumo:
        //     Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        QuadAlpha4Sgis = 33054,
        //
        // Resumo:
        //     Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        QuadAlpha8Sgis = 33055,
        //
        // Resumo:
        //     Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        QuadLuminance4Sgis = 33056,
        //
        // Resumo:
        //     Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        QuadLuminance8Sgis = 33057,
        //
        // Resumo:
        //     Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        QuadIntensity4Sgis = 33058,
        //
        // Resumo:
        //     Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        QuadIntensity8Sgis = 33059,
        //
        // Resumo:
        //     Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        DualTextureSelectSgis = 33060,
        //
        // Resumo:
        //     Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        QuadTextureSelectSgis = 33061,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_MIN = 0x8126
        PointSizeMin = 33062,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_MIN_ARB = 0x8126
        PointSizeMinArb = 33062,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_MIN_EXT = 0x8126
        PointSizeMinExt = 33062,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        PointSizeMinSgis = 33062,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_MAX = 0x8127
        PointSizeMax = 33063,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_MAX_ARB = 0x8127
        PointSizeMaxArb = 33063,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_MAX_EXT = 0x8127
        PointSizeMaxExt = 33063,
        //
        // Resumo:
        //     Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        PointSizeMaxSgis = 33063,
        //
        // Resumo:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        PointFadeThresholdSize = 33064,
        //
        // Resumo:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128
        PointFadeThresholdSizeArb = 33064,
        //
        // Resumo:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128
        PointFadeThresholdSizeExt = 33064,
        //
        // Resumo:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        PointFadeThresholdSizeSgis = 33064,
        //
        // Resumo:
        //     Original was GL_DISTANCE_ATTENUATION_EXT = 0x8129
        DistanceAttenuationExt = 33065,
        //
        // Resumo:
        //     Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        DistanceAttenuationSgis = 33065,
        //
        // Resumo:
        //     Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        PointDistanceAttenuation = 33065,
        //
        // Resumo:
        //     Original was GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129
        PointDistanceAttenuationArb = 33065,
        //
        // Resumo:
        //     Original was GL_FOG_FUNC_SGIS = 0x812A
        FogFuncSgis = 33066,
        //
        // Resumo:
        //     Original was GL_FOG_FUNC_POINTS_SGIS = 0x812B
        FogFuncPointsSgis = 33067,
        //
        // Resumo:
        //     Original was GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
        MaxFogFuncPointsSgis = 33068,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_BORDER = 0x812D
        ClampToBorder = 33069,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_BORDER_ARB = 0x812D
        ClampToBorderArb = 33069,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_BORDER_NV = 0x812D
        ClampToBorderNv = 33069,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_BORDER_SGIS = 0x812D
        ClampToBorderSgis = 33069,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
        TextureMultiBufferHintSgix = 33070,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_EDGE = 0x812F
        ClampToEdge = 33071,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_EDGE_SGIS = 0x812F
        ClampToEdgeSgis = 33071,
        //
        // Resumo:
        //     Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        PackSkipVolumesSgis = 33072,
        //
        // Resumo:
        //     Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        PackImageDepthSgis = 33073,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        UnpackSkipVolumesSgis = 33074,
        //
        // Resumo:
        //     Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        UnpackImageDepthSgis = 33075,
        //
        // Resumo:
        //     Original was GL_TEXTURE_4D_SGIS = 0x8134
        Texture4DSgis = 33076,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_4D_SGIS = 0x8135
        ProxyTexture4DSgis = 33077,
        //
        // Resumo:
        //     Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        Texture4DsizeSgis = 33078,
        //
        // Resumo:
        //     Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        TextureWrapQSgis = 33079,
        //
        // Resumo:
        //     Original was GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138
        Max4DTextureSizeSgis = 33080,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        PixelTexGenSgix = 33081,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MIN_LOD = 0x813A
        TextureMinLod = 33082,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
        TextureMinLodSgis = 33082,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_LOD = 0x813B
        TextureMaxLod = 33083,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
        TextureMaxLodSgis = 33083,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        TextureBaseLevel = 33084,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
        TextureBaseLevelSgis = 33084,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        TextureMaxLevel = 33085,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        TextureMaxLevelSgis = 33085,
        //
        // Resumo:
        //     Original was GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E
        PixelTileBestAlignmentSgix = 33086,
        //
        // Resumo:
        //     Original was GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F
        PixelTileCacheIncrementSgix = 33087,
        //
        // Resumo:
        //     Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        PixelTileWidthSgix = 33088,
        //
        // Resumo:
        //     Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        PixelTileHeightSgix = 33089,
        //
        // Resumo:
        //     Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        PixelTileGridWidthSgix = 33090,
        //
        // Resumo:
        //     Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        PixelTileGridHeightSgix = 33091,
        //
        // Resumo:
        //     Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        PixelTileGridDepthSgix = 33092,
        //
        // Resumo:
        //     Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        PixelTileCacheSizeSgix = 33093,
        //
        // Resumo:
        //     Original was GL_FILTER4_SGIS = 0x8146
        Filter4Sgis = 33094,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        TextureFilter4SizeSgis = 33095,
        //
        // Resumo:
        //     Original was GL_SPRITE_SGIX = 0x8148
        SpriteSgix = 33096,
        //
        // Resumo:
        //     Original was GL_SPRITE_MODE_SGIX = 0x8149
        SpriteModeSgix = 33097,
        //
        // Resumo:
        //     Original was GL_SPRITE_AXIS_SGIX = 0x814A
        SpriteAxisSgix = 33098,
        //
        // Resumo:
        //     Original was GL_SPRITE_TRANSLATION_SGIX = 0x814B
        SpriteTranslationSgix = 33099,
        //
        // Resumo:
        //     Original was GL_TEXTURE_4D_BINDING_SGIS = 0x814F
        Texture4DBindingSgis = 33103,
        //
        // Resumo:
        //     Original was GL_CONSTANT_BORDER = 0x8151
        ConstantBorder = 33105,
        //
        // Resumo:
        //     Original was GL_REPLICATE_BORDER = 0x8153
        ReplicateBorder = 33107,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_BORDER_COLOR = 0x8154
        ConvolutionBorderColor = 33108,
        //
        // Resumo:
        //     Original was GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
        LinearClipmapLinearSgix = 33136,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        TextureClipmapCenterSgix = 33137,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
        TextureClipmapFrameSgix = 33138,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
        TextureClipmapOffsetSgix = 33139,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
        TextureClipmapVirtualDepthSgix = 33140,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
        TextureClipmapLodOffsetSgix = 33141,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
        TextureClipmapDepthSgix = 33142,
        //
        // Resumo:
        //     Original was GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
        MaxClipmapDepthSgix = 33143,
        //
        // Resumo:
        //     Original was GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
        MaxClipmapVirtualDepthSgix = 33144,
        //
        // Resumo:
        //     Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        PostTextureFilterBiasSgix = 33145,
        //
        // Resumo:
        //     Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        PostTextureFilterScaleSgix = 33146,
        //
        // Resumo:
        //     Original was GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B
        PostTextureFilterBiasRangeSgix = 33147,
        //
        // Resumo:
        //     Original was GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C
        PostTextureFilterScaleRangeSgix = 33148,
        //
        // Resumo:
        //     Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        ReferencePlaneSgix = 33149,
        //
        // Resumo:
        //     Original was GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E
        ReferencePlaneEquationSgix = 33150,
        //
        // Resumo:
        //     Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        IrInstrument1Sgix = 33151,
        //
        // Resumo:
        //     Original was GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180
        InstrumentBufferPointerSgix = 33152,
        //
        // Resumo:
        //     Original was GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
        InstrumentMeasurementsSgix = 33153,
        //
        // Resumo:
        //     Original was GL_LIST_PRIORITY_SGIX = 0x8182
        ListPrioritySgix = 33154,
        //
        // Resumo:
        //     Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        CalligraphicFragmentSgix = 33155,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        PixelTexGenQCeilingSgix = 33156,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        PixelTexGenQRoundSgix = 33157,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        PixelTexGenQFloorSgix = 33158,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187
        PixelTexGenAlphaReplaceSgix = 33159,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188
        PixelTexGenAlphaNoReplaceSgix = 33160,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189
        PixelTexGenAlphaLsSgix = 33161,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A
        PixelTexGenAlphaMsSgix = 33162,
        //
        // Resumo:
        //     Original was GL_FRAMEZOOM_SGIX = 0x818B
        FramezoomSgix = 33163,
        //
        // Resumo:
        //     Original was GL_FRAMEZOOM_FACTOR_SGIX = 0x818C
        FramezoomFactorSgix = 33164,
        //
        // Resumo:
        //     Original was GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D
        MaxFramezoomFactorSgix = 33165,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
        TextureLodBiasSSgix = 33166,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
        TextureLodBiasTSgix = 33167,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
        TextureLodBiasRSgix = 33168,
        //
        // Resumo:
        //     Original was GL_GENERATE_MIPMAP = 0x8191
        GenerateMipmap = 33169,
        //
        // Resumo:
        //     Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
        GenerateMipmapSgis = 33169,
        //
        // Resumo:
        //     Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        GenerateMipmapHint = 33170,
        //
        // Resumo:
        //     Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        GenerateMipmapHintSgis = 33170,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        GeometryDeformationSgix = 33172,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        TextureDeformationSgix = 33173,
        //
        // Resumo:
        //     Original was GL_DEFORMATIONS_MASK_SGIX = 0x8196
        DeformationsMaskSgix = 33174,
        //
        // Resumo:
        //     Original was GL_FOG_OFFSET_SGIX = 0x8198
        FogOffsetSgix = 33176,
        //
        // Resumo:
        //     Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        FogOffsetValueSgix = 33177,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
        TextureCompareSgix = 33178,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
        TextureCompareOperatorSgix = 33179,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
        TextureLequalRSgix = 33180,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
        TextureGequalRSgix = 33181,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT16 = 0x81A5
        DepthComponent16 = 33189,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        DepthComponent16Arb = 33189,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        DepthComponent16Oes = 33189,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        DepthComponent16Sgix = 33189,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT24 = 0x81A6
        DepthComponent24 = 33190,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        DepthComponent24Arb = 33190,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        DepthComponent24Oes = 33190,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        DepthComponent24Sgix = 33190,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32 = 0x81A7
        DepthComponent32 = 33191,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        DepthComponent32Arb = 33191,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        DepthComponent32Oes = 33191,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        DepthComponent32Sgix = 33191,
        //
        // Resumo:
        //     Original was GL_YCRCB_422_SGIX = 0x81BB
        Ycrcb422Sgix = 33211,
        //
        // Resumo:
        //     Original was GL_YCRCB_444_SGIX = 0x81BC
        Ycrcb444Sgix = 33212,
        //
        // Resumo:
        //     Original was GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0
        EyeDistanceToPointSgis = 33264,
        //
        // Resumo:
        //     Original was GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1
        ObjectDistanceToPointSgis = 33265,
        //
        // Resumo:
        //     Original was GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2
        EyeDistanceToLineSgis = 33266,
        //
        // Resumo:
        //     Original was GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3
        ObjectDistanceToLineSgis = 33267,
        //
        // Resumo:
        //     Original was GL_EYE_POINT_SGIS = 0x81F4
        EyePointSgis = 33268,
        //
        // Resumo:
        //     Original was GL_OBJECT_POINT_SGIS = 0x81F5
        ObjectPointSgis = 33269,
        //
        // Resumo:
        //     Original was GL_EYE_LINE_SGIS = 0x81F6
        EyeLineSgis = 33270,
        //
        // Resumo:
        //     Original was GL_OBJECT_LINE_SGIS = 0x81F7
        ObjectLineSgis = 33271,
        //
        // Resumo:
        //     Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        LightModelColorControl = 33272,
        //
        // Resumo:
        //     Original was GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8
        LightModelColorControlExt = 33272,
        //
        // Resumo:
        //     Original was GL_SINGLE_COLOR = 0x81F9
        SingleColor = 33273,
        //
        // Resumo:
        //     Original was GL_SINGLE_COLOR_EXT = 0x81F9
        SingleColorExt = 33273,
        //
        // Resumo:
        //     Original was GL_SEPARATE_SPECULAR_COLOR = 0x81FA
        SeparateSpecularColor = 33274,
        //
        // Resumo:
        //     Original was GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA
        SeparateSpecularColorExt = 33274,
        //
        // Resumo:
        //     Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        SharedTexturePaletteExt = 33275,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        FramebufferAttachmentColorEncoding = 33296,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        FramebufferAttachmentComponentType = 33297,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        FramebufferAttachmentRedSize = 33298,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        FramebufferAttachmentGreenSize = 33299,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        FramebufferAttachmentBlueSize = 33300,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        FramebufferAttachmentAlphaSize = 33301,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        FramebufferAttachmentDepthSize = 33302,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        FramebufferAttachmentStencilSize = 33303,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_DEFAULT = 0x8218
        FramebufferDefault = 33304,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        FramebufferUndefined = 33305,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
        DepthStencilAttachment = 33306,
        //
        // Resumo:
        //     Original was GL_MAJOR_VERSION = 0x821B
        MajorVersion = 33307,
        //
        // Resumo:
        //     Original was GL_MINOR_VERSION = 0x821C
        MinorVersion = 33308,
        //
        // Resumo:
        //     Original was GL_NUM_EXTENSIONS = 0x821D
        NumExtensions = 33309,
        //
        // Resumo:
        //     Original was GL_CONTEXT_FLAGS = 0x821E
        ContextFlags = 33310,
        //
        // Resumo:
        //     Original was GL_BUFFER_IMMUTABLE_STORAGE = 0x821F
        BufferImmutableStorage = 33311,
        //
        // Resumo:
        //     Original was GL_BUFFER_STORAGE_FLAGS = 0x8220
        BufferStorageFlags = 33312,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221
        PrimitiveRestartForPatchesSupported = 33313,
        //
        // Resumo:
        //     Original was GL_INDEX = 0x8222
        Index = 33314,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RED = 0x8225
        CompressedRed = 33317,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RG = 0x8226
        CompressedRg = 33318,
        //
        // Resumo:
        //     Original was GL_RG = 0x8227
        Rg = 33319,
        //
        // Resumo:
        //     Original was GL_RG_INTEGER = 0x8228
        RgInteger = 33320,
        //
        // Resumo:
        //     Original was GL_R8 = 0x8229
        R8 = 33321,
        //
        // Resumo:
        //     Original was GL_R8_EXT = 0x8229
        R8Ext = 33321,
        //
        // Resumo:
        //     Original was GL_R16 = 0x822A
        R16 = 33322,
        //
        // Resumo:
        //     Original was GL_R16_EXT = 0x822A
        R16Ext = 33322,
        //
        // Resumo:
        //     Original was GL_RG8 = 0x822B
        Rg8 = 33323,
        //
        // Resumo:
        //     Original was GL_RG8_EXT = 0x822B
        Rg8Ext = 33323,
        //
        // Resumo:
        //     Original was GL_RG16 = 0x822C
        Rg16 = 33324,
        //
        // Resumo:
        //     Original was GL_RG16_EXT = 0x822C
        Rg16Ext = 33324,
        //
        // Resumo:
        //     Original was GL_R16F = 0x822D
        R16f = 33325,
        //
        // Resumo:
        //     Original was GL_R16F_EXT = 0x822D
        R16fExt = 33325,
        //
        // Resumo:
        //     Original was GL_R32F = 0x822E
        R32f = 33326,
        //
        // Resumo:
        //     Original was GL_R32F_EXT = 0x822E
        R32fExt = 33326,
        //
        // Resumo:
        //     Original was GL_RG16F = 0x822F
        Rg16f = 33327,
        //
        // Resumo:
        //     Original was GL_RG16F_EXT = 0x822F
        Rg16fExt = 33327,
        //
        // Resumo:
        //     Original was GL_RG32F = 0x8230
        Rg32f = 33328,
        //
        // Resumo:
        //     Original was GL_RG32F_EXT = 0x8230
        Rg32fExt = 33328,
        //
        // Resumo:
        //     Original was GL_R8I = 0x8231
        R8i = 33329,
        //
        // Resumo:
        //     Original was GL_R8UI = 0x8232
        R8ui = 33330,
        //
        // Resumo:
        //     Original was GL_R16I = 0x8233
        R16i = 33331,
        //
        // Resumo:
        //     Original was GL_R16UI = 0x8234
        R16ui = 33332,
        //
        // Resumo:
        //     Original was GL_R32I = 0x8235
        R32i = 33333,
        //
        // Resumo:
        //     Original was GL_R32UI = 0x8236
        R32ui = 33334,
        //
        // Resumo:
        //     Original was GL_RG8I = 0x8237
        Rg8i = 33335,
        //
        // Resumo:
        //     Original was GL_RG8UI = 0x8238
        Rg8ui = 33336,
        //
        // Resumo:
        //     Original was GL_RG16I = 0x8239
        Rg16i = 33337,
        //
        // Resumo:
        //     Original was GL_RG16UI = 0x823A
        Rg16ui = 33338,
        //
        // Resumo:
        //     Original was GL_RG32I = 0x823B
        Rg32i = 33339,
        //
        // Resumo:
        //     Original was GL_RG32UI = 0x823C
        Rg32ui = 33340,
        //
        // Resumo:
        //     Original was GL_SYNC_CL_EVENT_ARB = 0x8240
        SyncClEventArb = 33344,
        //
        // Resumo:
        //     Original was GL_SYNC_CL_EVENT_COMPLETE_ARB = 0x8241
        SyncClEventCompleteArb = 33345,
        //
        // Resumo:
        //     Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        DebugOutputSynchronous = 33346,
        //
        // Resumo:
        //     Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242
        DebugOutputSynchronousArb = 33346,
        //
        // Resumo:
        //     Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242
        DebugOutputSynchronousKhr = 33346,
        //
        // Resumo:
        //     Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
        DebugNextLoggedMessageLength = 33347,
        //
        // Resumo:
        //     Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243
        DebugNextLoggedMessageLengthArb = 33347,
        //
        // Resumo:
        //     Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243
        DebugNextLoggedMessageLengthKhr = 33347,
        //
        // Resumo:
        //     Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        DebugCallbackFunction = 33348,
        //
        // Resumo:
        //     Original was GL_DEBUG_CALLBACK_FUNCTION_ARB = 0x8244
        DebugCallbackFunctionArb = 33348,
        //
        // Resumo:
        //     Original was GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244
        DebugCallbackFunctionKhr = 33348,
        //
        // Resumo:
        //     Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        DebugCallbackUserParam = 33349,
        //
        // Resumo:
        //     Original was GL_DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245
        DebugCallbackUserParamArb = 33349,
        //
        // Resumo:
        //     Original was GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245
        DebugCallbackUserParamKhr = 33349,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_API = 0x8246
        DebugSourceApi = 33350,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_API_ARB = 0x8246
        DebugSourceApiArb = 33350,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_API_KHR = 0x8246
        DebugSourceApiKhr = 33350,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        DebugSourceWindowSystem = 33351,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247
        DebugSourceWindowSystemArb = 33351,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247
        DebugSourceWindowSystemKhr = 33351,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        DebugSourceShaderCompiler = 33352,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248
        DebugSourceShaderCompilerArb = 33352,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248
        DebugSourceShaderCompilerKhr = 33352,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        DebugSourceThirdParty = 33353,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249
        DebugSourceThirdPartyArb = 33353,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249
        DebugSourceThirdPartyKhr = 33353,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        DebugSourceApplication = 33354,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_APPLICATION_ARB = 0x824A
        DebugSourceApplicationArb = 33354,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A
        DebugSourceApplicationKhr = 33354,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        DebugSourceOther = 33355,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_OTHER_ARB = 0x824B
        DebugSourceOtherArb = 33355,
        //
        // Resumo:
        //     Original was GL_DEBUG_SOURCE_OTHER_KHR = 0x824B
        DebugSourceOtherKhr = 33355,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_ERROR = 0x824C
        DebugTypeError = 33356,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_ERROR_ARB = 0x824C
        DebugTypeErrorArb = 33356,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_ERROR_KHR = 0x824C
        DebugTypeErrorKhr = 33356,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        DebugTypeDeprecatedBehavior = 33357,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D
        DebugTypeDeprecatedBehaviorArb = 33357,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D
        DebugTypeDeprecatedBehaviorKhr = 33357,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        DebugTypeUndefinedBehavior = 33358,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E
        DebugTypeUndefinedBehaviorArb = 33358,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E
        DebugTypeUndefinedBehaviorKhr = 33358,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        DebugTypePortability = 33359,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_PORTABILITY_ARB = 0x824F
        DebugTypePortabilityArb = 33359,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F
        DebugTypePortabilityKhr = 33359,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        DebugTypePerformance = 33360,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_PERFORMANCE_ARB = 0x8250
        DebugTypePerformanceArb = 33360,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250
        DebugTypePerformanceKhr = 33360,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_OTHER = 0x8251
        DebugTypeOther = 33361,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_OTHER_ARB = 0x8251
        DebugTypeOtherArb = 33361,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_OTHER_KHR = 0x8251
        DebugTypeOtherKhr = 33361,
        //
        // Resumo:
        //     Original was GL_LOSE_CONTEXT_ON_RESET = 0x8252
        LoseContextOnReset = 33362,
        //
        // Resumo:
        //     Original was GL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252
        LoseContextOnResetArb = 33362,
        //
        // Resumo:
        //     Original was GL_LOSE_CONTEXT_ON_RESET_KHR = 0x8252
        LoseContextOnResetKhr = 33362,
        //
        // Resumo:
        //     Original was GL_GUILTY_CONTEXT_RESET = 0x8253
        GuiltyContextReset = 33363,
        //
        // Resumo:
        //     Original was GL_GUILTY_CONTEXT_RESET_ARB = 0x8253
        GuiltyContextResetArb = 33363,
        //
        // Resumo:
        //     Original was GL_GUILTY_CONTEXT_RESET_KHR = 0x8253
        GuiltyContextResetKhr = 33363,
        //
        // Resumo:
        //     Original was GL_INNOCENT_CONTEXT_RESET = 0x8254
        InnocentContextReset = 33364,
        //
        // Resumo:
        //     Original was GL_INNOCENT_CONTEXT_RESET_ARB = 0x8254
        InnocentContextResetArb = 33364,
        //
        // Resumo:
        //     Original was GL_INNOCENT_CONTEXT_RESET_KHR = 0x8254
        InnocentContextResetKhr = 33364,
        //
        // Resumo:
        //     Original was GL_UNKNOWN_CONTEXT_RESET = 0x8255
        UnknownContextReset = 33365,
        //
        // Resumo:
        //     Original was GL_UNKNOWN_CONTEXT_RESET_ARB = 0x8255
        UnknownContextResetArb = 33365,
        //
        // Resumo:
        //     Original was GL_UNKNOWN_CONTEXT_RESET_KHR = 0x8255
        UnknownContextResetKhr = 33365,
        //
        // Resumo:
        //     Original was GL_RESET_NOTIFICATION_STRATEGY = 0x8256
        ResetNotificationStrategy = 33366,
        //
        // Resumo:
        //     Original was GL_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256
        ResetNotificationStrategyArb = 33366,
        //
        // Resumo:
        //     Original was GL_RESET_NOTIFICATION_STRATEGY_KHR = 0x8256
        ResetNotificationStrategyKhr = 33366,
        //
        // Resumo:
        //     Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        ProgramBinaryRetrievableHint = 33367,
        //
        // Resumo:
        //     Original was GL_PROGRAM_SEPARABLE = 0x8258
        ProgramSeparable = 33368,
        //
        // Resumo:
        //     Original was GL_PROGRAM_SEPARABLE_EXT = 0x8258
        ProgramSeparableExt = 33368,
        //
        // Resumo:
        //     Original was GL_ACTIVE_PROGRAM = 0x8259
        ActiveProgram = 33369,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PIPELINE_BINDING = 0x825A
        ProgramPipelineBinding = 33370,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PIPELINE_BINDING_EXT = 0x825A
        ProgramPipelineBindingExt = 33370,
        //
        // Resumo:
        //     Original was GL_MAX_VIEWPORTS = 0x825B
        MaxViewports = 33371,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SUBPIXEL_BITS = 0x825C
        ViewportSubpixelBits = 33372,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_BOUNDS_RANGE = 0x825D
        ViewportBoundsRange = 33373,
        //
        // Resumo:
        //     Original was GL_LAYER_PROVOKING_VERTEX = 0x825E
        LayerProvokingVertex = 33374,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F
        ViewportIndexProvokingVertex = 33375,
        //
        // Resumo:
        //     Original was GL_UNDEFINED_VERTEX = 0x8260
        UndefinedVertex = 33376,
        //
        // Resumo:
        //     Original was GL_NO_RESET_NOTIFICATION = 0x8261
        NoResetNotification = 33377,
        //
        // Resumo:
        //     Original was GL_NO_RESET_NOTIFICATION_ARB = 0x8261
        NoResetNotificationArb = 33377,
        //
        // Resumo:
        //     Original was GL_NO_RESET_NOTIFICATION_KHR = 0x8261
        NoResetNotificationKhr = 33377,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262
        MaxComputeSharedMemorySize = 33378,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263
        MaxComputeUniformComponents = 33379,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264
        MaxComputeAtomicCounterBuffers = 33380,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265
        MaxComputeAtomicCounters = 33381,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266
        MaxCombinedComputeUniformComponents = 33382,
        //
        // Resumo:
        //     Original was GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
        ComputeWorkGroupSize = 33383,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_MARKER = 0x8268
        DebugTypeMarker = 33384,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_MARKER_KHR = 0x8268
        DebugTypeMarkerKhr = 33384,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        DebugTypePushGroup = 33385,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269
        DebugTypePushGroupKhr = 33385,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        DebugTypePopGroup = 33386,
        //
        // Resumo:
        //     Original was GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A
        DebugTypePopGroupKhr = 33386,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
        DebugSeverityNotification = 33387,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B
        DebugSeverityNotificationKhr = 33387,
        //
        // Resumo:
        //     Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
        MaxDebugGroupStackDepth = 33388,
        //
        // Resumo:
        //     Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C
        MaxDebugGroupStackDepthKhr = 33388,
        //
        // Resumo:
        //     Original was GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
        DebugGroupStackDepth = 33389,
        //
        // Resumo:
        //     Original was GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D
        DebugGroupStackDepthKhr = 33389,
        //
        // Resumo:
        //     Original was GL_MAX_UNIFORM_LOCATIONS = 0x826E
        MaxUniformLocations = 33390,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_SUPPORTED = 0x826F
        InternalformatSupported = 33391,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_PREFERRED = 0x8270
        InternalformatPreferred = 33392,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_RED_SIZE = 0x8271
        InternalformatRedSize = 33393,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_GREEN_SIZE = 0x8272
        InternalformatGreenSize = 33394,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_BLUE_SIZE = 0x8273
        InternalformatBlueSize = 33395,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274
        InternalformatAlphaSize = 33396,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275
        InternalformatDepthSize = 33397,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276
        InternalformatStencilSize = 33398,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_SHARED_SIZE = 0x8277
        InternalformatSharedSize = 33399,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_RED_TYPE = 0x8278
        InternalformatRedType = 33400,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_GREEN_TYPE = 0x8279
        InternalformatGreenType = 33401,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_BLUE_TYPE = 0x827A
        InternalformatBlueType = 33402,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
        InternalformatAlphaType = 33403,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
        InternalformatDepthType = 33404,
        //
        // Resumo:
        //     Original was GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
        InternalformatStencilType = 33405,
        //
        // Resumo:
        //     Original was GL_MAX_WIDTH = 0x827E
        MaxWidth = 33406,
        //
        // Resumo:
        //     Original was GL_MAX_HEIGHT = 0x827F
        MaxHeight = 33407,
        //
        // Resumo:
        //     Original was GL_MAX_DEPTH = 0x8280
        MaxDepth = 33408,
        //
        // Resumo:
        //     Original was GL_MAX_LAYERS = 0x8281
        MaxLayers = 33409,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_DIMENSIONS = 0x8282
        MaxCombinedDimensions = 33410,
        //
        // Resumo:
        //     Original was GL_COLOR_COMPONENTS = 0x8283
        ColorComponents = 33411,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENTS = 0x8284
        DepthComponents = 33412,
        //
        // Resumo:
        //     Original was GL_STENCIL_COMPONENTS = 0x8285
        StencilComponents = 33413,
        //
        // Resumo:
        //     Original was GL_COLOR_RENDERABLE = 0x8286
        ColorRenderable = 33414,
        //
        // Resumo:
        //     Original was GL_DEPTH_RENDERABLE = 0x8287
        DepthRenderable = 33415,
        //
        // Resumo:
        //     Original was GL_STENCIL_RENDERABLE = 0x8288
        StencilRenderable = 33416,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_RENDERABLE = 0x8289
        FramebufferRenderable = 33417,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A
        FramebufferRenderableLayered = 33418,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_BLEND = 0x828B
        FramebufferBlend = 33419,
        //
        // Resumo:
        //     Original was GL_READ_PIXELS = 0x828C
        ReadPixels = 33420,
        //
        // Resumo:
        //     Original was GL_READ_PIXELS_FORMAT = 0x828D
        ReadPixelsFormat = 33421,
        //
        // Resumo:
        //     Original was GL_READ_PIXELS_TYPE = 0x828E
        ReadPixelsType = 33422,
        //
        // Resumo:
        //     Original was GL_TEXTURE_IMAGE_FORMAT = 0x828F
        TextureImageFormat = 33423,
        //
        // Resumo:
        //     Original was GL_TEXTURE_IMAGE_TYPE = 0x8290
        TextureImageType = 33424,
        //
        // Resumo:
        //     Original was GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291
        GetTextureImageFormat = 33425,
        //
        // Resumo:
        //     Original was GL_GET_TEXTURE_IMAGE_TYPE = 0x8292
        GetTextureImageType = 33426,
        //
        // Resumo:
        //     Original was GL_MIPMAP = 0x8293
        Mipmap = 33427,
        //
        // Resumo:
        //     Original was GL_MANUAL_GENERATE_MIPMAP = 0x8294
        ManualGenerateMipmap = 33428,
        //
        // Resumo:
        //     Original was GL_AUTO_GENERATE_MIPMAP = 0x8295
        AutoGenerateMipmap = 33429,
        //
        // Resumo:
        //     Original was GL_COLOR_ENCODING = 0x8296
        ColorEncoding = 33430,
        //
        // Resumo:
        //     Original was GL_SRGB_READ = 0x8297
        SrgbRead = 33431,
        //
        // Resumo:
        //     Original was GL_SRGB_WRITE = 0x8298
        SrgbWrite = 33432,
        //
        // Resumo:
        //     Original was GL_SRGB_DECODE_ARB = 0x8299
        SrgbDecodeArb = 33433,
        //
        // Resumo:
        //     Original was GL_FILTER = 0x829A
        Filter = 33434,
        //
        // Resumo:
        //     Original was GL_VERTEX_TEXTURE = 0x829B
        VertexTexture = 33435,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_TEXTURE = 0x829C
        TessControlTexture = 33436,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_TEXTURE = 0x829D
        TessEvaluationTexture = 33437,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_TEXTURE = 0x829E
        GeometryTexture = 33438,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_TEXTURE = 0x829F
        FragmentTexture = 33439,
        //
        // Resumo:
        //     Original was GL_COMPUTE_TEXTURE = 0x82A0
        ComputeTexture = 33440,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SHADOW = 0x82A1
        TextureShadow = 33441,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GATHER = 0x82A2
        TextureGather = 33442,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GATHER_SHADOW = 0x82A3
        TextureGatherShadow = 33443,
        //
        // Resumo:
        //     Original was GL_SHADER_IMAGE_LOAD = 0x82A4
        ShaderImageLoad = 33444,
        //
        // Resumo:
        //     Original was GL_SHADER_IMAGE_STORE = 0x82A5
        ShaderImageStore = 33445,
        //
        // Resumo:
        //     Original was GL_SHADER_IMAGE_ATOMIC = 0x82A6
        ShaderImageAtomic = 33446,
        //
        // Resumo:
        //     Original was GL_IMAGE_TEXEL_SIZE = 0x82A7
        ImageTexelSize = 33447,
        //
        // Resumo:
        //     Original was GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
        ImageCompatibilityClass = 33448,
        //
        // Resumo:
        //     Original was GL_IMAGE_PIXEL_FORMAT = 0x82A9
        ImagePixelFormat = 33449,
        //
        // Resumo:
        //     Original was GL_IMAGE_PIXEL_TYPE = 0x82AA
        ImagePixelType = 33450,
        //
        // Resumo:
        //     Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
        SimultaneousTextureAndDepthTest = 33452,
        //
        // Resumo:
        //     Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
        SimultaneousTextureAndStencilTest = 33453,
        //
        // Resumo:
        //     Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
        SimultaneousTextureAndDepthWrite = 33454,
        //
        // Resumo:
        //     Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
        SimultaneousTextureAndStencilWrite = 33455,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
        TextureCompressedBlockWidth = 33457,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
        TextureCompressedBlockHeight = 33458,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
        TextureCompressedBlockSize = 33459,
        //
        // Resumo:
        //     Original was GL_CLEAR_BUFFER = 0x82B4
        ClearBuffer = 33460,
        //
        // Resumo:
        //     Original was GL_TEXTURE_VIEW = 0x82B5
        TextureView = 33461,
        //
        // Resumo:
        //     Original was GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
        ViewCompatibilityClass = 33462,
        //
        // Resumo:
        //     Original was GL_FULL_SUPPORT = 0x82B7
        FullSupport = 33463,
        //
        // Resumo:
        //     Original was GL_CAVEAT_SUPPORT = 0x82B8
        CaveatSupport = 33464,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_4_X_32 = 0x82B9
        ImageClass4X32 = 33465,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_2_X_32 = 0x82BA
        ImageClass2X32 = 33466,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_1_X_32 = 0x82BB
        ImageClass1X32 = 33467,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_4_X_16 = 0x82BC
        ImageClass4X16 = 33468,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_2_X_16 = 0x82BD
        ImageClass2X16 = 33469,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_1_X_16 = 0x82BE
        ImageClass1X16 = 33470,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_4_X_8 = 0x82BF
        ImageClass4X8 = 33471,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_2_X_8 = 0x82C0
        ImageClass2X8 = 33472,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_1_X_8 = 0x82C1
        ImageClass1X8 = 33473,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_11_11_10 = 0x82C2
        ImageClass111110 = 33474,
        //
        // Resumo:
        //     Original was GL_IMAGE_CLASS_10_10_10_2 = 0x82C3
        ImageClass1010102 = 33475,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_128_BITS = 0x82C4
        ViewClass128Bits = 33476,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_96_BITS = 0x82C5
        ViewClass96Bits = 33477,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_64_BITS = 0x82C6
        ViewClass64Bits = 33478,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_48_BITS = 0x82C7
        ViewClass48Bits = 33479,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_32_BITS = 0x82C8
        ViewClass32Bits = 33480,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_24_BITS = 0x82C9
        ViewClass24Bits = 33481,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_16_BITS = 0x82CA
        ViewClass16Bits = 33482,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_8_BITS = 0x82CB
        ViewClass8Bits = 33483,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC
        ViewClassS3tcDxt1Rgb = 33484,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD
        ViewClassS3tcDxt1Rgba = 33485,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE
        ViewClassS3tcDxt3Rgba = 33486,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF
        ViewClassS3tcDxt5Rgba = 33487,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_RGTC1_RED = 0x82D0
        ViewClassRgtc1Red = 33488,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_RGTC2_RG = 0x82D1
        ViewClassRgtc2Rg = 33489,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_BPTC_UNORM = 0x82D2
        ViewClassBptcUnorm = 33490,
        //
        // Resumo:
        //     Original was GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3
        ViewClassBptcFloat = 33491,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_BINDING = 0x82D4
        VertexAttribBinding = 33492,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        VertexAttribRelativeOffset = 33493,
        //
        // Resumo:
        //     Original was GL_VERTEX_BINDING_DIVISOR = 0x82D6
        VertexBindingDivisor = 33494,
        //
        // Resumo:
        //     Original was GL_VERTEX_BINDING_OFFSET = 0x82D7
        VertexBindingOffset = 33495,
        //
        // Resumo:
        //     Original was GL_VERTEX_BINDING_STRIDE = 0x82D8
        VertexBindingStride = 33496,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9
        MaxVertexAttribRelativeOffset = 33497,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA
        MaxVertexAttribBindings = 33498,
        //
        // Resumo:
        //     Original was GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB
        TextureViewMinLevel = 33499,
        //
        // Resumo:
        //     Original was GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC
        TextureViewNumLevels = 33500,
        //
        // Resumo:
        //     Original was GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD
        TextureViewMinLayer = 33501,
        //
        // Resumo:
        //     Original was GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE
        TextureViewNumLayers = 33502,
        //
        // Resumo:
        //     Original was GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF
        TextureImmutableLevels = 33503,
        //
        // Resumo:
        //     Original was GL_BUFFER = 0x82E0
        Buffer = 33504,
        //
        // Resumo:
        //     Original was GL_BUFFER_KHR = 0x82E0
        BufferKhr = 33504,
        //
        // Resumo:
        //     Original was GL_SHADER = 0x82E1
        Shader = 33505,
        //
        // Resumo:
        //     Original was GL_SHADER_KHR = 0x82E1
        ShaderKhr = 33505,
        //
        // Resumo:
        //     Original was GL_PROGRAM = 0x82E2
        Program = 33506,
        //
        // Resumo:
        //     Original was GL_PROGRAM_KHR = 0x82E2
        ProgramKhr = 33506,
        //
        // Resumo:
        //     Original was GL_QUERY = 0x82E3
        Query = 33507,
        //
        // Resumo:
        //     Original was GL_QUERY_KHR = 0x82E3
        QueryKhr = 33507,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PIPELINE = 0x82E4
        ProgramPipeline = 33508,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PIPELINE_KHR = 0x82E4
        ProgramPipelineKhr = 33508,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5
        MaxVertexAttribStride = 33509,
        //
        // Resumo:
        //     Original was GL_SAMPLER = 0x82E6
        Sampler = 33510,
        //
        // Resumo:
        //     Original was GL_SAMPLER_KHR = 0x82E6
        SamplerKhr = 33510,
        //
        // Resumo:
        //     Original was GL_DISPLAY_LIST = 0x82E7
        DisplayList = 33511,
        //
        // Resumo:
        //     Original was GL_MAX_LABEL_LENGTH = 0x82E8
        MaxLabelLength = 33512,
        //
        // Resumo:
        //     Original was GL_MAX_LABEL_LENGTH_KHR = 0x82E8
        MaxLabelLengthKhr = 33512,
        //
        // Resumo:
        //     Original was GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9
        NumShadingLanguageVersions = 33513,
        //
        // Resumo:
        //     Original was GL_QUERY_TARGET = 0x82EA
        QueryTarget = 33514,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC
        TransformFeedbackOverflow = 33516,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB = 0x82EC
        TransformFeedbackOverflowArb = 33516,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED
        TransformFeedbackStreamOverflow = 33517,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB = 0x82ED
        TransformFeedbackStreamOverflowArb = 33517,
        //
        // Resumo:
        //     Original was GL_VERTICES_SUBMITTED = 0x82EE
        VerticesSubmitted = 33518,
        //
        // Resumo:
        //     Original was GL_VERTICES_SUBMITTED_ARB = 0x82EE
        VerticesSubmittedArb = 33518,
        //
        // Resumo:
        //     Original was GL_PRIMITIVES_SUBMITTED = 0x82EF
        PrimitivesSubmitted = 33519,
        //
        // Resumo:
        //     Original was GL_PRIMITIVES_SUBMITTED_ARB = 0x82EF
        PrimitivesSubmittedArb = 33519,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_INVOCATIONS = 0x82F0
        VertexShaderInvocations = 33520,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0
        VertexShaderInvocationsArb = 33520,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_SHADER_PATCHES = 0x82F1
        TessControlShaderPatches = 33521,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1
        TessControlShaderPatchesArb = 33521,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2
        TessEvaluationShaderInvocations = 33522,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2
        TessEvaluationShaderInvocationsArb = 33522,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3
        GeometryShaderPrimitivesEmitted = 33523,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3
        GeometryShaderPrimitivesEmittedArb = 33523,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_INVOCATIONS = 0x82F4
        FragmentShaderInvocations = 33524,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4
        FragmentShaderInvocationsArb = 33524,
        //
        // Resumo:
        //     Original was GL_COMPUTE_SHADER_INVOCATIONS = 0x82F5
        ComputeShaderInvocations = 33525,
        //
        // Resumo:
        //     Original was GL_COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5
        ComputeShaderInvocationsArb = 33525,
        //
        // Resumo:
        //     Original was GL_CLIPPING_INPUT_PRIMITIVES = 0x82F6
        ClippingInputPrimitives = 33526,
        //
        // Resumo:
        //     Original was GL_CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6
        ClippingInputPrimitivesArb = 33526,
        //
        // Resumo:
        //     Original was GL_CLIPPING_OUTPUT_PRIMITIVES = 0x82F7
        ClippingOutputPrimitives = 33527,
        //
        // Resumo:
        //     Original was GL_CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7
        ClippingOutputPrimitivesArb = 33527,
        //
        // Resumo:
        //     Original was GL_SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8
        SparseBufferPageSizeArb = 33528,
        //
        // Resumo:
        //     Original was GL_MAX_CULL_DISTANCES = 0x82F9
        MaxCullDistances = 33529,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA
        MaxCombinedClipAndCullDistances = 33530,
        //
        // Resumo:
        //     Original was GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB
        ContextReleaseBehavior = 33531,
        //
        // Resumo:
        //     Original was GL_CONTEXT_RELEASE_BEHAVIOR_KHR = 0x82FB
        ContextReleaseBehaviorKhr = 33531,
        //
        // Resumo:
        //     Original was GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC
        ContextReleaseBehaviorFlush = 33532,
        //
        // Resumo:
        //     Original was GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR = 0x82FC
        ContextReleaseBehaviorFlushKhr = 33532,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        ConvolutionHintSgix = 33558,
        //
        // Resumo:
        //     Original was GL_ALPHA_MIN_SGIX = 0x8320
        AlphaMinSgix = 33568,
        //
        // Resumo:
        //     Original was GL_ALPHA_MAX_SGIX = 0x8321
        AlphaMaxSgix = 33569,
        //
        // Resumo:
        //     Original was GL_SCALEBIAS_HINT_SGIX = 0x8322
        ScalebiasHintSgix = 33570,
        //
        // Resumo:
        //     Original was GL_ASYNC_MARKER_SGIX = 0x8329
        AsyncMarkerSgix = 33577,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B
        PixelTexGenModeSgix = 33579,
        //
        // Resumo:
        //     Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        AsyncHistogramSgix = 33580,
        //
        // Resumo:
        //     Original was GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D
        MaxAsyncHistogramSgix = 33581,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        PixelTextureSgis = 33619,
        //
        // Resumo:
        //     Original was GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354
        PixelFragmentRgbSourceSgis = 33620,
        //
        // Resumo:
        //     Original was GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355
        PixelFragmentAlphaSourceSgis = 33621,
        //
        // Resumo:
        //     Original was GL_LINE_QUALITY_HINT_SGIX = 0x835B
        LineQualityHintSgix = 33627,
        //
        // Resumo:
        //     Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        AsyncTexImageSgix = 33628,
        //
        // Resumo:
        //     Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        AsyncDrawPixelsSgix = 33629,
        //
        // Resumo:
        //     Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        AsyncReadPixelsSgix = 33630,
        //
        // Resumo:
        //     Original was GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F
        MaxAsyncTexImageSgix = 33631,
        //
        // Resumo:
        //     Original was GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360
        MaxAsyncDrawPixelsSgix = 33632,
        //
        // Resumo:
        //     Original was GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361
        MaxAsyncReadPixelsSgix = 33633,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362
        UnsignedByte233Rev = 33634,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_BYTE_2_3_3_REVERSED = 0x8362
        UnsignedByte233Reversed = 33634,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        UnsignedShort565 = 33635,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364
        UnsignedShort565Rev = 33636,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_5_6_5_REVERSED = 0x8364
        UnsignedShort565Reversed = 33636,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365
        UnsignedShort4444Rev = 33637,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_4_4_4_4_REVERSED = 0x8365
        UnsignedShort4444Reversed = 33637,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366
        UnsignedShort1555Rev = 33638,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_1_5_5_5_REVERSED = 0x8366
        UnsignedShort1555Reversed = 33638,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367
        UnsignedInt8888Rev = 33639,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_8_8_8_8_REVERSED = 0x8367
        UnsignedInt8888Reversed = 33639,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        UnsignedInt2101010Rev = 33640,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_2_10_10_10_REVERSED = 0x8368
        UnsignedInt2101010Reversed = 33640,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
        TextureMaxClampSSgix = 33641,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
        TextureMaxClampTSgix = 33642,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
        TextureMaxClampRSgix = 33643,
        //
        // Resumo:
        //     Original was GL_MIRRORED_REPEAT = 0x8370
        MirroredRepeat = 33648,
        //
        // Resumo:
        //     Original was GL_MIRRORED_REPEAT_ARB = 0x8370
        MirroredRepeatArb = 33648,
        //
        // Resumo:
        //     Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        VertexPreclipSgix = 33774,
        //
        // Resumo:
        //     Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        VertexPreclipHintSgix = 33775,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        CompressedRgbS3tcDxt1Ext = 33776,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        CompressedRgbaS3tcDxt1Ext = 33777,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
        CompressedRgbaS3tcDxt3Ext = 33778,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
        CompressedRgbaS3tcDxt5Ext = 33779,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9
        PerfqueryDonotFlushIntel = 33785,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_FLUSH_INTEL = 0x83FA
        PerfqueryFlushIntel = 33786,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_WAIT_INTEL = 0x83FB
        PerfqueryWaitIntel = 33787,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTERIZATION_INTEL = 0x83FE
        ConservativeRasterizationIntel = 33790,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        FragmentLightingSgix = 33792,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        FragmentColorMaterialSgix = 33793,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402
        FragmentColorMaterialFaceSgix = 33794,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403
        FragmentColorMaterialParameterSgix = 33795,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404
        MaxFragmentLightsSgix = 33796,
        //
        // Resumo:
        //     Original was GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405
        MaxActiveLightsSgix = 33797,
        //
        // Resumo:
        //     Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        LightEnvModeSgix = 33799,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        FragmentLightModelLocalViewerSgix = 33800,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        FragmentLightModelTwoSideSgix = 33801,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        FragmentLightModelAmbientSgix = 33802,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        FragmentLightModelNormalInterpolationSgix = 33803,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        FragmentLight0Sgix = 33804,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        FragmentLight1Sgix = 33805,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        FragmentLight2Sgix = 33806,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        FragmentLight3Sgix = 33807,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        FragmentLight4Sgix = 33808,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        FragmentLight5Sgix = 33809,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        FragmentLight6Sgix = 33810,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        FragmentLight7Sgix = 33811,
        //
        // Resumo:
        //     Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        PackResampleSgix = 33838,
        //
        // Resumo:
        //     Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        UnpackResampleSgix = 33839,
        //
        // Resumo:
        //     Original was GL_RESAMPLE_DECIMATE_SGIX = 0x8430
        ResampleDecimateSgix = 33840,
        //
        // Resumo:
        //     Original was GL_RESAMPLE_REPLICATE_SGIX = 0x8433
        ResampleReplicateSgix = 33843,
        //
        // Resumo:
        //     Original was GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434
        ResampleZeroFillSgix = 33844,
        //
        // Resumo:
        //     Original was GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
        NearestClipmapNearestSgix = 33869,
        //
        // Resumo:
        //     Original was GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
        NearestClipmapLinearSgix = 33870,
        //
        // Resumo:
        //     Original was GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
        LinearClipmapNearestSgix = 33871,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_SRC = 0x8450
        FogCoordSrc = 33872,
        //
        // Resumo:
        //     Original was GL_FOG_COORD = 0x8451
        FogCoord = 33873,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_DEPTH = 0x8452
        FragmentDepth = 33874,
        //
        // Resumo:
        //     Original was GL_CURRENT_FOG_COORD = 0x8453
        CurrentFogCoord = 33875,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_TYPE = 0x8454
        FogCoordArrayType = 33876,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_STRIDE = 0x8455
        FogCoordArrayStride = 33877,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_POINTER = 0x8456
        FogCoordArrayPointer = 33878,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY = 0x8457
        FogCoordArray = 33879,
        //
        // Resumo:
        //     Original was GL_COLOR_SUM = 0x8458
        ColorSum = 33880,
        //
        // Resumo:
        //     Original was GL_CURRENT_SECONDARY_COLOR = 0x8459
        CurrentSecondaryColor = 33881,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A
        SecondaryColorArraySize = 33882,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B
        SecondaryColorArrayType = 33883,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C
        SecondaryColorArrayStride = 33884,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D
        SecondaryColorArrayPointer = 33885,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY = 0x845E
        SecondaryColorArray = 33886,
        //
        // Resumo:
        //     Original was GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F
        CurrentRasterSecondaryColor = 33887,
        //
        // Resumo:
        //     Original was GL_RGB_ICC_SGIX = 0x8460
        RgbIccSgix = 33888,
        //
        // Resumo:
        //     Original was GL_RGBA_ICC_SGIX = 0x8461
        RgbaIccSgix = 33889,
        //
        // Resumo:
        //     Original was GL_ALPHA_ICC_SGIX = 0x8462
        AlphaIccSgix = 33890,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ICC_SGIX = 0x8463
        LuminanceIccSgix = 33891,
        //
        // Resumo:
        //     Original was GL_INTENSITY_ICC_SGIX = 0x8464
        IntensityIccSgix = 33892,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA_ICC_SGIX = 0x8465
        LuminanceAlphaIccSgix = 33893,
        //
        // Resumo:
        //     Original was GL_R5_G6_B5_ICC_SGIX = 0x8466
        R5G6B5IccSgix = 33894,
        //
        // Resumo:
        //     Original was GL_R5_G6_B5_A8_ICC_SGIX = 0x8467
        R5G6B5A8IccSgix = 33895,
        //
        // Resumo:
        //     Original was GL_ALPHA16_ICC_SGIX = 0x8468
        Alpha16IccSgix = 33896,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16_ICC_SGIX = 0x8469
        Luminance16IccSgix = 33897,
        //
        // Resumo:
        //     Original was GL_INTENSITY16_ICC_SGIX = 0x846A
        Intensity16IccSgix = 33898,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B
        Luminance16Alpha8IccSgix = 33899,
        //
        // Resumo:
        //     Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        AliasedPointSizeRange = 33901,
        //
        // Resumo:
        //     Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        AliasedLineWidthRange = 33902,
        //
        // Resumo:
        //     Original was GL_TEXTURE0 = 0x84C0
        Texture0 = 33984,
        //
        // Resumo:
        //     Original was GL_TEXTURE1 = 0x84C1
        Texture1 = 33985,
        //
        // Resumo:
        //     Original was GL_TEXTURE2 = 0x84C2
        Texture2 = 33986,
        //
        // Resumo:
        //     Original was GL_TEXTURE3 = 0x84C3
        Texture3 = 33987,
        //
        // Resumo:
        //     Original was GL_TEXTURE4 = 0x84C4
        Texture4 = 33988,
        //
        // Resumo:
        //     Original was GL_TEXTURE5 = 0x84C5
        Texture5 = 33989,
        //
        // Resumo:
        //     Original was GL_TEXTURE6 = 0x84C6
        Texture6 = 33990,
        //
        // Resumo:
        //     Original was GL_TEXTURE7 = 0x84C7
        Texture7 = 33991,
        //
        // Resumo:
        //     Original was GL_TEXTURE8 = 0x84C8
        Texture8 = 33992,
        //
        // Resumo:
        //     Original was GL_TEXTURE9 = 0x84C9
        Texture9 = 33993,
        //
        // Resumo:
        //     Original was GL_TEXTURE10 = 0x84CA
        Texture10 = 33994,
        //
        // Resumo:
        //     Original was GL_TEXTURE11 = 0x84CB
        Texture11 = 33995,
        //
        // Resumo:
        //     Original was GL_TEXTURE12 = 0x84CC
        Texture12 = 33996,
        //
        // Resumo:
        //     Original was GL_TEXTURE13 = 0x84CD
        Texture13 = 33997,
        //
        // Resumo:
        //     Original was GL_TEXTURE14 = 0x84CE
        Texture14 = 33998,
        //
        // Resumo:
        //     Original was GL_TEXTURE15 = 0x84CF
        Texture15 = 33999,
        //
        // Resumo:
        //     Original was GL_TEXTURE16 = 0x84D0
        Texture16 = 34000,
        //
        // Resumo:
        //     Original was GL_TEXTURE17 = 0x84D1
        Texture17 = 34001,
        //
        // Resumo:
        //     Original was GL_TEXTURE18 = 0x84D2
        Texture18 = 34002,
        //
        // Resumo:
        //     Original was GL_TEXTURE19 = 0x84D3
        Texture19 = 34003,
        //
        // Resumo:
        //     Original was GL_TEXTURE20 = 0x84D4
        Texture20 = 34004,
        //
        // Resumo:
        //     Original was GL_TEXTURE21 = 0x84D5
        Texture21 = 34005,
        //
        // Resumo:
        //     Original was GL_TEXTURE22 = 0x84D6
        Texture22 = 34006,
        //
        // Resumo:
        //     Original was GL_TEXTURE23 = 0x84D7
        Texture23 = 34007,
        //
        // Resumo:
        //     Original was GL_TEXTURE24 = 0x84D8
        Texture24 = 34008,
        //
        // Resumo:
        //     Original was GL_TEXTURE25 = 0x84D9
        Texture25 = 34009,
        //
        // Resumo:
        //     Original was GL_TEXTURE26 = 0x84DA
        Texture26 = 34010,
        //
        // Resumo:
        //     Original was GL_TEXTURE27 = 0x84DB
        Texture27 = 34011,
        //
        // Resumo:
        //     Original was GL_TEXTURE28 = 0x84DC
        Texture28 = 34012,
        //
        // Resumo:
        //     Original was GL_TEXTURE29 = 0x84DD
        Texture29 = 34013,
        //
        // Resumo:
        //     Original was GL_TEXTURE30 = 0x84DE
        Texture30 = 34014,
        //
        // Resumo:
        //     Original was GL_TEXTURE31 = 0x84DF
        Texture31 = 34015,
        //
        // Resumo:
        //     Original was GL_ACTIVE_TEXTURE = 0x84E0
        ActiveTexture = 34016,
        //
        // Resumo:
        //     Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        ClientActiveTexture = 34017,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_UNITS = 0x84E2
        MaxTextureUnits = 34018,
        //
        // Resumo:
        //     Original was GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3
        PathTransposeModelviewMatrixNv = 34019,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3
        TransposeModelviewMatrix = 34019,
        //
        // Resumo:
        //     Original was GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4
        PathTransposeProjectionMatrixNv = 34020,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4
        TransposeProjectionMatrix = 34020,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5
        TransposeTextureMatrix = 34021,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_COLOR_MATRIX = 0x84E6
        TransposeColorMatrix = 34022,
        //
        // Resumo:
        //     Original was GL_SUBTRACT = 0x84E7
        Subtract = 34023,
        //
        // Resumo:
        //     Original was GL_MAX_RENDERBUFFER_SIZE = 0x84E8
        MaxRenderbufferSize = 34024,
        //
        // Resumo:
        //     Original was GL_MAX_RENDERBUFFER_SIZE_EXT = 0x84E8
        MaxRenderbufferSizeExt = 34024,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_ALPHA = 0x84E9
        CompressedAlpha = 34025,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_LUMINANCE = 0x84EA
        CompressedLuminance = 34026,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB
        CompressedLuminanceAlpha = 34027,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_INTENSITY = 0x84EC
        CompressedIntensity = 34028,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB = 0x84ED
        CompressedRgb = 34029,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA = 0x84EE
        CompressedRgba = 34030,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        TextureCompressionHint = 34031,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        TextureCompressionHintArb = 34031,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
        UniformBlockReferencedByTessControlShader = 34032,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
        UniformBlockReferencedByTessEvaluationShader = 34033,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RECTANGLE = 0x84F5
        TextureRectangle = 34037,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_RECTANGLE = 0x84F6
        TextureBindingRectangle = 34038,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
        ProxyTextureRectangle = 34039,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
        ProxyTextureRectangleArb = 34039,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
        ProxyTextureRectangleNv = 34039,
        //
        // Resumo:
        //     Original was GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8
        MaxRectangleTextureSize = 34040,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL = 0x84F9
        DepthStencil = 34041,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        DepthStencilExt = 34041,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_NV = 0x84F9
        DepthStencilNv = 34041,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_OES = 0x84F9
        DepthStencilOes = 34041,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_24_8 = 0x84FA
        UnsignedInt248 = 34042,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_LOD_BIAS = 0x84FD
        MaxTextureLodBias = 34045,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_ANISOTROPY = 0x84FE
        TextureMaxAnisotropy = 34046,
        //
        // Resumo:
        //     Original was GL_TextureMaxAnisotropyExt = 0x84FE
        TextureMaxAnisotropyExt = 34046,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF
        MaxTextureMaxAnisotropy = 34047,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FILTER_CONTROL = 0x8500
        TextureFilterControl = 34048,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LOD_BIAS = 0x8501
        TextureLodBias = 34049,
        //
        // Resumo:
        //     Original was GL_INCR_WRAP = 0x8507
        IncrWrap = 34055,
        //
        // Resumo:
        //     Original was GL_DECR_WRAP = 0x8508
        DecrWrap = 34056,
        //
        // Resumo:
        //     Original was GL_NORMAL_MAP = 0x8511
        NormalMap = 34065,
        //
        // Resumo:
        //     Original was GL_REFLECTION_MAP = 0x8512
        ReflectionMap = 34066,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP = 0x8513
        TextureCubeMap = 34067,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        TextureBindingCubeMap = 34068,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        TextureCubeMapPositiveX = 34069,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        TextureCubeMapNegativeX = 34070,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        TextureCubeMapPositiveY = 34071,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        TextureCubeMapNegativeY = 34072,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        TextureCubeMapPositiveZ = 34073,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        TextureCubeMapNegativeZ = 34074,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
        ProxyTextureCubeMap = 34075,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
        ProxyTextureCubeMapArb = 34075,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
        ProxyTextureCubeMapExt = 34075,
        //
        // Resumo:
        //     Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C
        MaxCubeMapTextureSize = 34076,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        VertexArrayStorageHintApple = 34079,
        //
        // Resumo:
        //     Original was GL_PRIMARY_COLOR_NV = 0x852C
        PrimaryColorNv = 34092,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_NV = 0x852D
        SecondaryColorNv = 34093,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        MultisampleFilterHintNv = 34100,
        //
        // Resumo:
        //     Original was GL_COMBINE = 0x8570
        Combine = 34160,
        //
        // Resumo:
        //     Original was GL_COMBINE_RGB = 0x8571
        CombineRgb = 34161,
        //
        // Resumo:
        //     Original was GL_COMBINE_ALPHA = 0x8572
        CombineAlpha = 34162,
        //
        // Resumo:
        //     Original was GL_RGB_SCALE = 0x8573
        RgbScale = 34163,
        //
        // Resumo:
        //     Original was GL_ADD_SIGNED = 0x8574
        AddSigned = 34164,
        //
        // Resumo:
        //     Original was GL_INTERPOLATE = 0x8575
        Interpolate = 34165,
        //
        // Resumo:
        //     Original was GL_CONSTANT = 0x8576
        Constant = 34166,
        //
        // Resumo:
        //     Original was GL_CONSTANT_NV = 0x8576
        ConstantNv = 34166,
        //
        // Resumo:
        //     Original was GL_PRIMARY_COLOR = 0x8577
        PrimaryColor = 34167,
        //
        // Resumo:
        //     Original was GL_PREVIOUS = 0x8578
        Previous = 34168,
        //
        // Resumo:
        //     Original was GL_SOURCE0_RGB = 0x8580
        Source0Rgb = 34176,
        //
        // Resumo:
        //     Original was GL_SRC1_RGB = 0x8581
        Src1Rgb = 34177,
        //
        // Resumo:
        //     Original was GL_SRC2_RGB = 0x8582
        Src2Rgb = 34178,
        //
        // Resumo:
        //     Original was GL_SRC0_ALPHA = 0x8588
        Src0Alpha = 34184,
        //
        // Resumo:
        //     Original was GL_SRC1_ALPHA = 0x8589
        Src1Alpha = 34185,
        //
        // Resumo:
        //     Original was GL_SRC2_ALPHA = 0x858A
        Src2Alpha = 34186,
        //
        // Resumo:
        //     Original was GL_OPERAND0_RGB = 0x8590
        Operand0Rgb = 34192,
        //
        // Resumo:
        //     Original was GL_OPERAND1_RGB = 0x8591
        Operand1Rgb = 34193,
        //
        // Resumo:
        //     Original was GL_OPERAND2_RGB = 0x8592
        Operand2Rgb = 34194,
        //
        // Resumo:
        //     Original was GL_OPERAND0_ALPHA = 0x8598
        Operand0Alpha = 34200,
        //
        // Resumo:
        //     Original was GL_OPERAND1_ALPHA = 0x8599
        Operand1Alpha = 34201,
        //
        // Resumo:
        //     Original was GL_OPERAND2_ALPHA = 0x859A
        Operand2Alpha = 34202,
        //
        // Resumo:
        //     Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        PackSubsampleRateSgix = 34208,
        //
        // Resumo:
        //     Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        UnpackSubsampleRateSgix = 34209,
        //
        // Resumo:
        //     Original was GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2
        PixelSubsample4444Sgix = 34210,
        //
        // Resumo:
        //     Original was GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3
        PixelSubsample2424Sgix = 34211,
        //
        // Resumo:
        //     Original was GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4
        PixelSubsample4242Sgix = 34212,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        TransformHintApple = 34225,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_BINDING = 0x85B5
        VertexArrayBinding = 34229,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA
        UnsignedShort88Apple = 34234,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB
        UnsignedShort88RevApple = 34235,
        //
        // Resumo:
        //     Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        TextureStorageHintApple = 34236,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM = 0x8620
        VertexProgram = 34336,
        //
        // Resumo:
        //     Original was GL_ARRAY_ENABLED = 0x8622
        ArrayEnabled = 34338,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
        VertexAttribArrayEnabled = 34338,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        VertexAttribArraySize = 34339,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        VertexAttribArrayStride = 34340,
        //
        // Resumo:
        //     Original was GL_ARRAY_TYPE = 0x8625
        ArrayType = 34341,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        VertexAttribArrayType = 34341,
        //
        // Resumo:
        //     Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        CurrentVertexAttrib = 34342,
        //
        // Resumo:
        //     Original was GL_PROGRAM_LENGTH = 0x8627
        ProgramLength = 34343,
        //
        // Resumo:
        //     Original was GL_PROGRAM_STRING = 0x8628
        ProgramString = 34344,
        //
        // Resumo:
        //     Original was GL_PROGRAM_POINT_SIZE = 0x8642
        ProgramPointSize = 34370,
        //
        // Resumo:
        //     Original was GL_PROGRAM_POINT_SIZE_ARB = 0x8642
        ProgramPointSizeArb = 34370,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642
        VertexProgramPointSize = 34370,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643
        VertexProgramTwoSide = 34371,
        //
        // Resumo:
        //     Original was GL_ARRAY_POINTER = 0x8645
        ArrayPointer = 34373,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645
        VertexAttribArrayPointer = 34373,
        //
        // Resumo:
        //     Original was GL_DEPTH_CLAMP = 0x864F
        DepthClamp = 34383,
        //
        // Resumo:
        //     Original was GL_PROGRAM_BINDING = 0x8677
        ProgramBinding = 34423,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0
        TextureCompressedImageSize = 34464,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED = 0x86A1
        TextureCompressed = 34465,
        //
        // Resumo:
        //     Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        NumCompressedTextureFormats = 34466,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        CompressedTextureFormats = 34467,
        //
        // Resumo:
        //     Original was GL_DOT3_RGB = 0x86AE
        Dot3Rgb = 34478,
        //
        // Resumo:
        //     Original was GL_DOT3_RGBA = 0x86AF
        Dot3Rgba = 34479,
        //
        // Resumo:
        //     Original was GL_PROGRAM_BINARY_LENGTH = 0x8741
        ProgramBinaryLength = 34625,
        //
        // Resumo:
        //     Original was GL_MIRROR_CLAMP_TO_EDGE = 0x8743
        MirrorClampToEdge = 34627,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
        VertexAttribArrayLong = 34638,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_MESA = 0x8750
        DepthStencilMesa = 34640,
        //
        // Resumo:
        //     Original was GL_BUFFER_SIZE = 0x8764
        BufferSize = 34660,
        //
        // Resumo:
        //     Original was GL_BUFFER_USAGE = 0x8765
        BufferUsage = 34661,
        //
        // Resumo:
        //     Original was GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE
        NumProgramBinaryFormats = 34814,
        //
        // Resumo:
        //     Original was GL_PROGRAM_BINARY_FORMATS = 0x87FF
        ProgramBinaryFormats = 34815,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_FUNC = 0x8800
        StencilBackFunc = 34816,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_FAIL = 0x8801
        StencilBackFail = 34817,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802
        StencilBackPassDepthFail = 34818,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803
        StencilBackPassDepthPass = 34819,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_PROGRAM = 0x8804
        FragmentProgram = 34820,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805
        ProgramAluInstructionsArb = 34821,
        //
        // Resumo:
        //     Original was GL_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806
        ProgramTexInstructionsArb = 34822,
        //
        // Resumo:
        //     Original was GL_PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807
        ProgramTexIndirectionsArb = 34823,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808
        ProgramNativeAluInstructionsArb = 34824,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809
        ProgramNativeTexInstructionsArb = 34825,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A
        ProgramNativeTexIndirectionsArb = 34826,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B
        MaxProgramAluInstructionsArb = 34827,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C
        MaxProgramTexInstructionsArb = 34828,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D
        MaxProgramTexIndirectionsArb = 34829,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E
        MaxProgramNativeAluInstructionsArb = 34830,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F
        MaxProgramNativeTexInstructionsArb = 34831,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810
        MaxProgramNativeTexIndirectionsArb = 34832,
        //
        // Resumo:
        //     Original was GL_RGBA32F = 0x8814
        Rgba32f = 34836,
        //
        // Resumo:
        //     Original was GL_RGBA32F_ARB = 0x8814
        Rgba32fArb = 34836,
        //
        // Resumo:
        //     Original was GL_RGBA32F_EXT = 0x8814
        Rgba32fExt = 34836,
        //
        // Resumo:
        //     Original was GL_RGB32F = 0x8815
        Rgb32f = 34837,
        //
        // Resumo:
        //     Original was GL_RGBA16F = 0x881A
        Rgba16f = 34842,
        //
        // Resumo:
        //     Original was GL_RGBA16F_ARB = 0x881A
        Rgba16fArb = 34842,
        //
        // Resumo:
        //     Original was GL_RGBA16F_EXT = 0x881A
        Rgba16fExt = 34842,
        //
        // Resumo:
        //     Original was GL_RGB16F = 0x881B
        Rgb16f = 34843,
        //
        // Resumo:
        //     Original was GL_RGB16F_ARB = 0x881B
        Rgb16fArb = 34843,
        //
        // Resumo:
        //     Original was GL_RGB16F_EXT = 0x881B
        Rgb16fExt = 34843,
        //
        // Resumo:
        //     Original was GL_RGBA_FLOAT_MODE = 0x8820
        RgbaFloatMode = 34848,
        //
        // Resumo:
        //     Original was GL_MAX_DRAW_BUFFERS = 0x8824
        MaxDrawBuffers = 34852,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER0 = 0x8825
        DrawBuffer0 = 34853,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER1 = 0x8826
        DrawBuffer1 = 34854,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER2 = 0x8827
        DrawBuffer2 = 34855,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER3 = 0x8828
        DrawBuffer3 = 34856,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER4 = 0x8829
        DrawBuffer4 = 34857,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER5 = 0x882A
        DrawBuffer5 = 34858,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER6 = 0x882B
        DrawBuffer6 = 34859,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER7 = 0x882C
        DrawBuffer7 = 34860,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER8 = 0x882D
        DrawBuffer8 = 34861,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER9 = 0x882E
        DrawBuffer9 = 34862,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER10 = 0x882F
        DrawBuffer10 = 34863,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER11 = 0x8830
        DrawBuffer11 = 34864,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER12 = 0x8831
        DrawBuffer12 = 34865,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER13 = 0x8832
        DrawBuffer13 = 34866,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER14 = 0x8833
        DrawBuffer14 = 34867,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER15 = 0x8834
        DrawBuffer15 = 34868,
        //
        // Resumo:
        //     Original was GL_BLEND_EQUATION_ALPHA = 0x883D
        BlendEquationAlpha = 34877,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEPTH_SIZE = 0x884A
        TextureDepthSize = 34890,
        //
        // Resumo:
        //     Original was GL_DEPTH_TEXTURE_MODE = 0x884B
        DepthTextureMode = 34891,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        TextureCompareMode = 34892,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        TextureCompareFunc = 34893,
        //
        // Resumo:
        //     Original was GL_COMPARE_REF_TO_TEXTURE = 0x884E
        CompareRefToTexture = 34894,
        //
        // Resumo:
        //     Original was GL_COMPARE_R_TO_TEXTURE = 0x884E
        CompareRToTexture = 34894,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F
        TextureCubeMapSeamless = 34895,
        //
        // Resumo:
        //     Original was GL_POINT_SPRITE = 0x8861
        PointSprite = 34913,
        //
        // Resumo:
        //     Original was GL_COORD_REPLACE = 0x8862
        CoordReplace = 34914,
        //
        // Resumo:
        //     Original was GL_QUERY_COUNTER_BITS = 0x8864
        QueryCounterBits = 34916,
        //
        // Resumo:
        //     Original was GL_CURRENT_QUERY = 0x8865
        CurrentQuery = 34917,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT = 0x8866
        QueryResult = 34918,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        QueryResultAvailable = 34919,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATTRIBS = 0x8869
        MaxVertexAttribs = 34921,
        //
        // Resumo:
        //     Original was GL_ARRAY_NORMALIZED = 0x886A
        ArrayNormalized = 34922,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        VertexAttribArrayNormalized = 34922,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C
        MaxTessControlInputComponents = 34924,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D
        MaxTessEvaluationInputComponents = 34925,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_COORDS = 0x8871
        MaxTextureCoords = 34929,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872
        MaxTextureImageUnits = 34930,
        //
        // Resumo:
        //     Original was GL_PROGRAM_FORMAT_ASCII_ARB = 0x8875
        ProgramFormatAsciiArb = 34933,
        //
        // Resumo:
        //     Original was GL_PROGRAM_FORMAT = 0x8876
        ProgramFormat = 34934,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        GeometryShaderInvocations = 34943,
        //
        // Resumo:
        //     Original was GL_ARRAY_BUFFER = 0x8892
        ArrayBuffer = 34962,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        ElementArrayBuffer = 34963,
        //
        // Resumo:
        //     Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        ArrayBufferBinding = 34964,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        ElementArrayBufferBinding = 34965,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        VertexArrayBufferBinding = 34966,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        NormalArrayBufferBinding = 34967,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        ColorArrayBufferBinding = 34968,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899
        IndexArrayBufferBinding = 34969,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        TextureCoordArrayBufferBinding = 34970,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B
        EdgeFlagArrayBufferBinding = 34971,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C
        SecondaryColorArrayBufferBinding = 34972,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D
        FogCoordArrayBufferBinding = 34973,
        //
        // Resumo:
        //     Original was GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E
        WeightArrayBufferBinding = 34974,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        VertexAttribArrayBufferBinding = 34975,
        //
        // Resumo:
        //     Original was GL_PROGRAM_INSTRUCTION = 0x88A0
        ProgramInstruction = 34976,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_INSTRUCTIONS = 0x88A1
        MaxProgramInstructions = 34977,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_INSTRUCTIONS = 0x88A2
        ProgramNativeInstructions = 34978,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS = 0x88A3
        MaxProgramNativeInstructions = 34979,
        //
        // Resumo:
        //     Original was GL_PROGRAM_TEMPORARIES = 0x88A4
        ProgramTemporaries = 34980,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEMPORARIES = 0x88A5
        MaxProgramTemporaries = 34981,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_TEMPORARIES = 0x88A6
        ProgramNativeTemporaries = 34982,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_TEMPORARIES = 0x88A7
        MaxProgramNativeTemporaries = 34983,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PARAMETERS = 0x88A8
        ProgramParameters = 34984,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_PARAMETERS = 0x88A9
        MaxProgramParameters = 34985,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_PARAMETERS = 0x88AA
        ProgramNativeParameters = 34986,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_PARAMETERS = 0x88AB
        MaxProgramNativeParameters = 34987,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ATTRIBS = 0x88AC
        ProgramAttribs = 34988,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ATTRIBS = 0x88AD
        MaxProgramAttribs = 34989,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_ATTRIBS = 0x88AE
        ProgramNativeAttribs = 34990,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_ATTRIBS = 0x88AF
        MaxProgramNativeAttribs = 34991,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ADDRESS_REGISTERS = 0x88B0
        ProgramAddressRegisters = 34992,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ADDRESS_REGISTERS = 0x88B1
        MaxProgramAddressRegisters = 34993,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_ADDRESS_REGISTERS = 0x88B2
        ProgramNativeAddressRegisters = 34994,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS = 0x88B3
        MaxProgramNativeAddressRegisters = 34995,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_LOCAL_PARAMETERS = 0x88B4
        MaxProgramLocalParameters = 34996,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ENV_PARAMETERS = 0x88B5
        MaxProgramEnvParameters = 34997,
        //
        // Resumo:
        //     Original was GL_PROGRAM_UNDER_NATIVE_LIMITS = 0x88B6
        ProgramUnderNativeLimits = 34998,
        //
        // Resumo:
        //     Original was GL_READ_ONLY = 0x88B8
        ReadOnly = 35000,
        //
        // Resumo:
        //     Original was GL_WRITE_ONLY = 0x88B9
        WriteOnly = 35001,
        //
        // Resumo:
        //     Original was GL_READ_WRITE = 0x88BA
        ReadWrite = 35002,
        //
        // Resumo:
        //     Original was GL_BUFFER_ACCESS = 0x88BB
        BufferAccess = 35003,
        //
        // Resumo:
        //     Original was GL_BUFFER_MAPPED = 0x88BC
        BufferMapped = 35004,
        //
        // Resumo:
        //     Original was GL_BUFFER_MAP_POINTER = 0x88BD
        BufferMapPointer = 35005,
        //
        // Resumo:
        //     Original was GL_TIME_ELAPSED = 0x88BF
        TimeElapsed = 35007,
        //
        // Resumo:
        //     Original was GL_MATRIX0 = 0x88C0
        Matrix0 = 35008,
        //
        // Resumo:
        //     Original was GL_MATRIX1 = 0x88C1
        Matrix1 = 35009,
        //
        // Resumo:
        //     Original was GL_MATRIX2 = 0x88C2
        Matrix2 = 35010,
        //
        // Resumo:
        //     Original was GL_MATRIX3 = 0x88C3
        Matrix3 = 35011,
        //
        // Resumo:
        //     Original was GL_MATRIX4 = 0x88C4
        Matrix4 = 35012,
        //
        // Resumo:
        //     Original was GL_MATRIX5 = 0x88C5
        Matrix5 = 35013,
        //
        // Resumo:
        //     Original was GL_MATRIX6 = 0x88C6
        Matrix6 = 35014,
        //
        // Resumo:
        //     Original was GL_MATRIX7 = 0x88C7
        Matrix7 = 35015,
        //
        // Resumo:
        //     Original was GL_MATRIX8 = 0x88C8
        Matrix8 = 35016,
        //
        // Resumo:
        //     Original was GL_MATRIX9 = 0x88C9
        Matrix9 = 35017,
        //
        // Resumo:
        //     Original was GL_MATRIX10 = 0x88CA
        Matrix10 = 35018,
        //
        // Resumo:
        //     Original was GL_MATRIX11 = 0x88CB
        Matrix11 = 35019,
        //
        // Resumo:
        //     Original was GL_MATRIX12 = 0x88CC
        Matrix12 = 35020,
        //
        // Resumo:
        //     Original was GL_MATRIX13 = 0x88CD
        Matrix13 = 35021,
        //
        // Resumo:
        //     Original was GL_MATRIX14 = 0x88CE
        Matrix14 = 35022,
        //
        // Resumo:
        //     Original was GL_MATRIX15 = 0x88CF
        Matrix15 = 35023,
        //
        // Resumo:
        //     Original was GL_MATRIX16 = 0x88D0
        Matrix16 = 35024,
        //
        // Resumo:
        //     Original was GL_MATRIX17 = 0x88D1
        Matrix17 = 35025,
        //
        // Resumo:
        //     Original was GL_MATRIX18 = 0x88D2
        Matrix18 = 35026,
        //
        // Resumo:
        //     Original was GL_MATRIX19 = 0x88D3
        Matrix19 = 35027,
        //
        // Resumo:
        //     Original was GL_MATRIX20 = 0x88D4
        Matrix20 = 35028,
        //
        // Resumo:
        //     Original was GL_MATRIX21 = 0x88D5
        Matrix21 = 35029,
        //
        // Resumo:
        //     Original was GL_MATRIX22 = 0x88D6
        Matrix22 = 35030,
        //
        // Resumo:
        //     Original was GL_MATRIX23 = 0x88D7
        Matrix23 = 35031,
        //
        // Resumo:
        //     Original was GL_MATRIX24 = 0x88D8
        Matrix24 = 35032,
        //
        // Resumo:
        //     Original was GL_MATRIX25 = 0x88D9
        Matrix25 = 35033,
        //
        // Resumo:
        //     Original was GL_MATRIX26 = 0x88DA
        Matrix26 = 35034,
        //
        // Resumo:
        //     Original was GL_MATRIX27 = 0x88DB
        Matrix27 = 35035,
        //
        // Resumo:
        //     Original was GL_MATRIX28 = 0x88DC
        Matrix28 = 35036,
        //
        // Resumo:
        //     Original was GL_MATRIX29 = 0x88DD
        Matrix29 = 35037,
        //
        // Resumo:
        //     Original was GL_MATRIX30 = 0x88DE
        Matrix30 = 35038,
        //
        // Resumo:
        //     Original was GL_MATRIX31 = 0x88DF
        Matrix31 = 35039,
        //
        // Resumo:
        //     Original was GL_STREAM_DRAW = 0x88E0
        StreamDraw = 35040,
        //
        // Resumo:
        //     Original was GL_STREAM_READ = 0x88E1
        StreamRead = 35041,
        //
        // Resumo:
        //     Original was GL_STREAM_COPY = 0x88E2
        StreamCopy = 35042,
        //
        // Resumo:
        //     Original was GL_STATIC_DRAW = 0x88E4
        StaticDraw = 35044,
        //
        // Resumo:
        //     Original was GL_STATIC_READ = 0x88E5
        StaticRead = 35045,
        //
        // Resumo:
        //     Original was GL_STATIC_COPY = 0x88E6
        StaticCopy = 35046,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_DRAW = 0x88E8
        DynamicDraw = 35048,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_READ = 0x88E9
        DynamicRead = 35049,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_COPY = 0x88EA
        DynamicCopy = 35050,
        //
        // Resumo:
        //     Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        PixelPackBuffer = 35051,
        //
        // Resumo:
        //     Original was GL_PIXEL_PACK_BUFFER_ARB = 0x88EB
        PixelPackBufferArb = 35051,
        //
        // Resumo:
        //     Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        PixelUnpackBuffer = 35052,
        //
        // Resumo:
        //     Original was GL_PIXEL_UNPACK_BUFFER_ARB = 0x88EC
        PixelUnpackBufferArb = 35052,
        //
        // Resumo:
        //     Original was GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED
        PixelPackBufferBinding = 35053,
        //
        // Resumo:
        //     Original was GL_PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED
        PixelPackBufferBindingArb = 35053,
        //
        // Resumo:
        //     Original was GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF
        PixelUnpackBufferBinding = 35055,
        //
        // Resumo:
        //     Original was GL_PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF
        PixelUnpackBufferBindingArb = 35055,
        //
        // Resumo:
        //     Original was GL_DEPTH24_STENCIL8 = 0x88F0
        Depth24Stencil8 = 35056,
        //
        // Resumo:
        //     Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        Depth24Stencil8Ext = 35056,
        //
        // Resumo:
        //     Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        Depth24Stencil8Oes = 35056,
        //
        // Resumo:
        //     Original was GL_TEXTURE_STENCIL_SIZE = 0x88F1
        TextureStencilSize = 35057,
        //
        // Resumo:
        //     Original was GL_SRC1_COLOR = 0x88F9
        Src1Color = 35065,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_SRC1_COLOR = 0x88FA
        OneMinusSrc1Color = 35066,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_SRC1_ALPHA = 0x88FB
        OneMinusSrc1Alpha = 35067,
        //
        // Resumo:
        //     Original was GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC
        MaxDualSourceDrawBuffers = 35068,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        VertexAttribArrayInteger = 35069,
        //
        // Resumo:
        //     Original was GL_ARRAY_DIVISOR = 0x88FE
        ArrayDivisor = 35070,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        VertexAttribArrayDivisor = 35070,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE
        VertexAttribArrayDivisorArb = 35070,
        //
        // Resumo:
        //     Original was GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF
        MaxArrayTextureLayers = 35071,
        //
        // Resumo:
        //     Original was GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904
        MinProgramTexelOffset = 35076,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905
        MaxProgramTexelOffset = 35077,
        //
        // Resumo:
        //     Original was GL_SAMPLES_PASSED = 0x8914
        SamplesPassed = 35092,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_VERTICES_OUT = 0x8916
        GeometryVerticesOut = 35094,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_INPUT_TYPE = 0x8917
        GeometryInputType = 35095,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        GeometryOutputType = 35096,
        //
        // Resumo:
        //     Original was GL_SAMPLER_BINDING = 0x8919
        SamplerBinding = 35097,
        //
        // Resumo:
        //     Original was GL_CLAMP_VERTEX_COLOR = 0x891A
        ClampVertexColor = 35098,
        //
        // Resumo:
        //     Original was GL_CLAMP_FRAGMENT_COLOR = 0x891B
        ClampFragmentColor = 35099,
        //
        // Resumo:
        //     Original was GL_CLAMP_READ_COLOR = 0x891C
        ClampReadColor = 35100,
        //
        // Resumo:
        //     Original was GL_FIXED_ONLY = 0x891D
        FixedOnly = 35101,
        //
        // Resumo:
        //     Original was GL_MOV_ATI = 0x8961
        MovAti = 35169,
        //
        // Resumo:
        //     Original was GL_ADD_ATI = 0x8963
        AddAti = 35171,
        //
        // Resumo:
        //     Original was GL_MUL_ATI = 0x8964
        MulAti = 35172,
        //
        // Resumo:
        //     Original was GL_SUB_ATI = 0x8965
        SubAti = 35173,
        //
        // Resumo:
        //     Original was GL_DOT3_ATI = 0x8966
        Dot3Ati = 35174,
        //
        // Resumo:
        //     Original was GL_DOT4_ATI = 0x8967
        Dot4Ati = 35175,
        //
        // Resumo:
        //     Original was GL_MAD_ATI = 0x8968
        MadAti = 35176,
        //
        // Resumo:
        //     Original was GL_LERP_ATI = 0x8969
        LerpAti = 35177,
        //
        // Resumo:
        //     Original was GL_CND_ATI = 0x896A
        CndAti = 35178,
        //
        // Resumo:
        //     Original was GL_CND0_ATI = 0x896B
        Cnd0Ati = 35179,
        //
        // Resumo:
        //     Original was GL_DOT2_ADD_ATI = 0x896C
        Dot2AddAti = 35180,
        //
        // Resumo:
        //     Original was GL_PACK_RESAMPLE_OML = 0x8984
        PackResampleOml = 35204,
        //
        // Resumo:
        //     Original was GL_UNPACK_RESAMPLE_OML = 0x8985
        UnpackResampleOml = 35205,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER = 0x8A11
        UniformBuffer = 35345,
        //
        // Resumo:
        //     Original was GL_RGB_422_APPLE = 0x8A1F
        Rgb422Apple = 35359,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_BINDING = 0x8A28
        UniformBufferBinding = 35368,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_START = 0x8A29
        UniformBufferStart = 35369,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_SIZE = 0x8A2A
        UniformBufferSize = 35370,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B
        MaxVertexUniformBlocks = 35371,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C
        MaxGeometryUniformBlocks = 35372,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D
        MaxFragmentUniformBlocks = 35373,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E
        MaxCombinedUniformBlocks = 35374,
        //
        // Resumo:
        //     Original was GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F
        MaxUniformBufferBindings = 35375,
        //
        // Resumo:
        //     Original was GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30
        MaxUniformBlockSize = 35376,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31
        MaxCombinedVertexUniformComponents = 35377,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32
        MaxCombinedGeometryUniformComponents = 35378,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33
        MaxCombinedFragmentUniformComponents = 35379,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34
        UniformBufferOffsetAlignment = 35380,
        //
        // Resumo:
        //     Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        ActiveUniformBlockMaxNameLength = 35381,
        //
        // Resumo:
        //     Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        ActiveUniformBlocks = 35382,
        //
        // Resumo:
        //     Original was GL_UNIFORM_TYPE = 0x8A37
        UniformType = 35383,
        //
        // Resumo:
        //     Original was GL_UNIFORM_SIZE = 0x8A38
        UniformSize = 35384,
        //
        // Resumo:
        //     Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        UniformNameLength = 35385,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        UniformBlockIndex = 35386,
        //
        // Resumo:
        //     Original was GL_UNIFORM_OFFSET = 0x8A3B
        UniformOffset = 35387,
        //
        // Resumo:
        //     Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        UniformArrayStride = 35388,
        //
        // Resumo:
        //     Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        UniformMatrixStride = 35389,
        //
        // Resumo:
        //     Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        UniformIsRowMajor = 35390,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_BINDING = 0x8A3F
        UniformBlockBinding = 35391,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
        UniformBlockDataSize = 35392,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
        UniformBlockNameLength = 35393,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
        UniformBlockActiveUniforms = 35394,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
        UniformBlockActiveUniformIndices = 35395,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
        UniformBlockReferencedByVertexShader = 35396,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45
        UniformBlockReferencedByGeometryShader = 35397,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
        UniformBlockReferencedByFragmentShader = 35398,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SRGB_DECODE_EXT = 0x8A48
        TextureSrgbDecodeExt = 35400,
        //
        // Resumo:
        //     Original was GL_DECODE_EXT = 0x8A49
        DecodeExt = 35401,
        //
        // Resumo:
        //     Original was GL_SKIP_DECODE_EXT = 0x8A4A
        SkipDecodeExt = 35402,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F
        ProgramPipelineObjectExt = 35407,
        //
        // Resumo:
        //     Original was GL_RGB_RAW_422_APPLE = 0x8A51
        RgbRaw422Apple = 35409,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER = 0x8B30
        FragmentShader = 35632,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_ARB = 0x8B30
        FragmentShaderArb = 35632,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER = 0x8B31
        VertexShader = 35633,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_ARB = 0x8B31
        VertexShaderArb = 35633,
        //
        // Resumo:
        //     Original was GL_PROGRAM_OBJECT_EXT = 0x8B40
        ProgramObjectExt = 35648,
        //
        // Resumo:
        //     Original was GL_SHADER_OBJECT_EXT = 0x8B48
        ShaderObjectExt = 35656,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49
        MaxFragmentUniformComponents = 35657,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A
        MaxVertexUniformComponents = 35658,
        //
        // Resumo:
        //     Original was GL_MAX_VARYING_COMPONENTS = 0x8B4B
        MaxVaryingComponents = 35659,
        //
        // Resumo:
        //     Original was GL_MAX_VARYING_FLOATS = 0x8B4B
        MaxVaryingFloats = 35659,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
        MaxVertexTextureImageUnits = 35660,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
        MaxCombinedTextureImageUnits = 35661,
        //
        // Resumo:
        //     Original was GL_SHADER_TYPE = 0x8B4F
        ShaderType = 35663,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC2 = 0x8B50
        FloatVec2 = 35664,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC2_ARB = 0x8B50
        FloatVec2Arb = 35664,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC3 = 0x8B51
        FloatVec3 = 35665,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC3_ARB = 0x8B51
        FloatVec3Arb = 35665,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC4 = 0x8B52
        FloatVec4 = 35666,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC4_ARB = 0x8B52
        FloatVec4Arb = 35666,
        //
        // Resumo:
        //     Original was GL_INT_VEC2 = 0x8B53
        IntVec2 = 35667,
        //
        // Resumo:
        //     Original was GL_INT_VEC2_ARB = 0x8B53
        IntVec2Arb = 35667,
        //
        // Resumo:
        //     Original was GL_INT_VEC3 = 0x8B54
        IntVec3 = 35668,
        //
        // Resumo:
        //     Original was GL_INT_VEC3_ARB = 0x8B54
        IntVec3Arb = 35668,
        //
        // Resumo:
        //     Original was GL_INT_VEC4 = 0x8B55
        IntVec4 = 35669,
        //
        // Resumo:
        //     Original was GL_INT_VEC4_ARB = 0x8B55
        IntVec4Arb = 35669,
        //
        // Resumo:
        //     Original was GL_BOOL = 0x8B56
        Bool = 35670,
        //
        // Resumo:
        //     Original was GL_BOOL_ARB = 0x8B56
        BoolArb = 35670,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC2 = 0x8B57
        BoolVec2 = 35671,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC2_ARB = 0x8B57
        BoolVec2Arb = 35671,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC3 = 0x8B58
        BoolVec3 = 35672,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC3_ARB = 0x8B58
        BoolVec3Arb = 35672,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC4 = 0x8B59
        BoolVec4 = 35673,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC4_ARB = 0x8B59
        BoolVec4Arb = 35673,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2 = 0x8B5A
        FloatMat2 = 35674,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2_ARB = 0x8B5A
        FloatMat2Arb = 35674,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3 = 0x8B5B
        FloatMat3 = 35675,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3_ARB = 0x8B5B
        FloatMat3Arb = 35675,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4 = 0x8B5C
        FloatMat4 = 35676,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4_ARB = 0x8B5C
        FloatMat4Arb = 35676,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D = 0x8B5D
        Sampler1D = 35677,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D_ARB = 0x8B5D
        Sampler1DArb = 35677,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D = 0x8B5E
        Sampler2D = 35678,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_ARB = 0x8B5E
        Sampler2DArb = 35678,
        //
        // Resumo:
        //     Original was GL_SAMPLER_3D = 0x8B5F
        Sampler3D = 35679,
        //
        // Resumo:
        //     Original was GL_SAMPLER_3D_ARB = 0x8B5F
        Sampler3DArb = 35679,
        //
        // Resumo:
        //     Original was GL_SAMPLER_3D_OES = 0x8B5F
        Sampler3DOes = 35679,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE = 0x8B60
        SamplerCube = 35680,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_ARB = 0x8B60
        SamplerCubeArb = 35680,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        Sampler1DShadow = 35681,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D_SHADOW_ARB = 0x8B61
        Sampler1DShadowArb = 35681,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        Sampler2DShadow = 35682,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_SHADOW_ARB = 0x8B62
        Sampler2DShadowArb = 35682,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_SHADOW_EXT = 0x8B62
        Sampler2DShadowExt = 35682,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_RECT = 0x8B63
        Sampler2DRect = 35683,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_RECT_ARB = 0x8B63
        Sampler2DRectArb = 35683,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
        Sampler2DRectShadow = 35684,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64
        Sampler2DRectShadowArb = 35684,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2x3 = 0x8B65
        FloatMat2x3 = 35685,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2x3_NV = 0x8B65
        FloatMat2x3Nv = 35685,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2x4 = 0x8B66
        FloatMat2x4 = 35686,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2x4_NV = 0x8B66
        FloatMat2x4Nv = 35686,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3x2 = 0x8B67
        FloatMat3x2 = 35687,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3x2_NV = 0x8B67
        FloatMat3x2Nv = 35687,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3x4 = 0x8B68
        FloatMat3x4 = 35688,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3x4_NV = 0x8B68
        FloatMat3x4Nv = 35688,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4x2 = 0x8B69
        FloatMat4x2 = 35689,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4x2_NV = 0x8B69
        FloatMat4x2Nv = 35689,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4x3 = 0x8B6A
        FloatMat4x3 = 35690,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4x3_NV = 0x8B6A
        FloatMat4x3Nv = 35690,
        //
        // Resumo:
        //     Original was GL_DELETE_STATUS = 0x8B80
        DeleteStatus = 35712,
        //
        // Resumo:
        //     Original was GL_COMPILE_STATUS = 0x8B81
        CompileStatus = 35713,
        //
        // Resumo:
        //     Original was GL_LINK_STATUS = 0x8B82
        LinkStatus = 35714,
        //
        // Resumo:
        //     Original was GL_VALIDATE_STATUS = 0x8B83
        ValidateStatus = 35715,
        //
        // Resumo:
        //     Original was GL_INFO_LOG_LENGTH = 0x8B84
        InfoLogLength = 35716,
        //
        // Resumo:
        //     Original was GL_ATTACHED_SHADERS = 0x8B85
        AttachedShaders = 35717,
        //
        // Resumo:
        //     Original was GL_ACTIVE_UNIFORMS = 0x8B86
        ActiveUniforms = 35718,
        //
        // Resumo:
        //     Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        ActiveUniformMaxLength = 35719,
        //
        // Resumo:
        //     Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        ShaderSourceLength = 35720,
        //
        // Resumo:
        //     Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        ActiveAttributes = 35721,
        //
        // Resumo:
        //     Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        ActiveAttributeMaxLength = 35722,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        FragmentShaderDerivativeHint = 35723,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B
        FragmentShaderDerivativeHintArb = 35723,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B
        FragmentShaderDerivativeHintOes = 35723,
        //
        // Resumo:
        //     Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        ShadingLanguageVersion = 35724,
        //
        // Resumo:
        //     Original was GL_CURRENT_PROGRAM = 0x8B8D
        CurrentProgram = 35725,
        //
        // Resumo:
        //     Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        ImplementationColorReadType = 35738,
        //
        // Resumo:
        //     Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        ImplementationColorReadFormat = 35739,
        //
        // Resumo:
        //     Original was GL_COUNTER_TYPE_AMD = 0x8BC0
        CounterTypeAmd = 35776,
        //
        // Resumo:
        //     Original was GL_COUNTER_RANGE_AMD = 0x8BC1
        CounterRangeAmd = 35777,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_AMD = 0x8BC2
        UnsignedInt64Amd = 35778,
        //
        // Resumo:
        //     Original was GL_PERCENTAGE_AMD = 0x8BC3
        PercentageAmd = 35779,
        //
        // Resumo:
        //     Original was GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4
        PerfmonResultAvailableAmd = 35780,
        //
        // Resumo:
        //     Original was GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5
        PerfmonResultSizeAmd = 35781,
        //
        // Resumo:
        //     Original was GL_PERFMON_RESULT_AMD = 0x8BC6
        PerfmonResultAmd = 35782,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RED_TYPE = 0x8C10
        TextureRedType = 35856,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GREEN_TYPE = 0x8C11
        TextureGreenType = 35857,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BLUE_TYPE = 0x8C12
        TextureBlueType = 35858,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ALPHA_TYPE = 0x8C13
        TextureAlphaType = 35859,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LUMINANCE_TYPE = 0x8C14
        TextureLuminanceType = 35860,
        //
        // Resumo:
        //     Original was GL_TEXTURE_INTENSITY_TYPE = 0x8C15
        TextureIntensityType = 35861,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEPTH_TYPE = 0x8C16
        TextureDepthType = 35862,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_NORMALIZED = 0x8C17
        UnsignedNormalized = 35863,
        //
        // Resumo:
        //     Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        Texture1DArray = 35864,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
        ProxyTexture1DArray = 35865,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
        ProxyTexture1DArrayExt = 35865,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        Texture2DArray = 35866,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
        ProxyTexture2DArray = 35867,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
        ProxyTexture2DArrayExt = 35867,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C
        TextureBinding1DArray = 35868,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
        TextureBinding2DArray = 35869,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29
        MaxGeometryTextureImageUnits = 35881,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29
        MaxGeometryTextureImageUnitsArb = 35881,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER = 0x8C2A
        TextureBuffer = 35882,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_ARB = 0x8C2A
        TextureBufferArb = 35882,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_BINDING = 0x8C2A
        TextureBufferBinding = 35882,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B
        MaxTextureBufferSize = 35883,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B
        MaxTextureBufferSizeArb = 35883,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_BUFFER = 0x8C2C
        TextureBindingBuffer = 35884,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_BUFFER_ARB = 0x8C2C
        TextureBindingBufferArb = 35884,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D
        TextureBufferDataStoreBinding = 35885,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D
        TextureBufferDataStoreBindingArb = 35885,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E
        TextureBufferFormatArb = 35886,
        //
        // Resumo:
        //     Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        AnySamplesPassed = 35887,
        //
        // Resumo:
        //     Original was GL_SAMPLE_SHADING = 0x8C36
        SampleShading = 35894,
        //
        // Resumo:
        //     Original was GL_SAMPLE_SHADING_ARB = 0x8C36
        SampleShadingArb = 35894,
        //
        // Resumo:
        //     Original was GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37
        MinSampleShadingValue = 35895,
        //
        // Resumo:
        //     Original was GL_MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37
        MinSampleShadingValueArb = 35895,
        //
        // Resumo:
        //     Original was GL_R11F_G11F_B10F = 0x8C3A
        R11fG11fB10f = 35898,
        //
        // Resumo:
        //     Original was GL_R11F_G11F_B10F_APPLE = 0x8C3A
        R11fG11fB10fApple = 35898,
        //
        // Resumo:
        //     Original was GL_R11F_G11F_B10F_EXT = 0x8C3A
        R11fG11fB10fExt = 35898,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        UnsignedInt10F11F11FRev = 35899,
        //
        // Resumo:
        //     Original was GL_RGB9_E5 = 0x8C3D
        Rgb9E5 = 35901,
        //
        // Resumo:
        //     Original was GL_RGB9_E5_APPLE = 0x8C3D
        Rgb9E5Apple = 35901,
        //
        // Resumo:
        //     Original was GL_RGB9_E5_EXT = 0x8C3D
        Rgb9E5Ext = 35901,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E
        UnsignedInt5999Rev = 35902,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SHARED_SIZE = 0x8C3F
        TextureSharedSize = 35903,
        //
        // Resumo:
        //     Original was GL_SRGB = 0x8C40
        Srgb = 35904,
        //
        // Resumo:
        //     Original was GL_SRGB_EXT = 0x8C40
        SrgbExt = 35904,
        //
        // Resumo:
        //     Original was GL_SRGB8 = 0x8C41
        Srgb8 = 35905,
        //
        // Resumo:
        //     Original was GL_SRGB8_EXT = 0x8C41
        Srgb8Ext = 35905,
        //
        // Resumo:
        //     Original was GL_SRGB8_NV = 0x8C41
        Srgb8Nv = 35905,
        //
        // Resumo:
        //     Original was GL_SRGB_ALPHA = 0x8C42
        SrgbAlpha = 35906,
        //
        // Resumo:
        //     Original was GL_SRGB_ALPHA_EXT = 0x8C42
        SrgbAlphaExt = 35906,
        //
        // Resumo:
        //     Original was GL_SRGB8_ALPHA8 = 0x8C43
        Srgb8Alpha8 = 35907,
        //
        // Resumo:
        //     Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        Srgb8Alpha8Ext = 35907,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE_ALPHA = 0x8C44
        SluminanceAlpha = 35908,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE8_ALPHA8 = 0x8C45
        Sluminance8Alpha8 = 35909,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE = 0x8C46
        Sluminance = 35910,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE8 = 0x8C47
        Sluminance8 = 35911,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB = 0x8C48
        CompressedSrgb = 35912,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        CompressedSrgbAlpha = 35913,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SLUMINANCE = 0x8C4A
        CompressedSluminance = 35914,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B
        CompressedSluminanceAlpha = 35915,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        CompressedSrgbS3tcDxt1Ext = 35916,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        CompressedSrgbAlphaS3tcDxt1Ext = 35917,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        CompressedSrgbAlphaS3tcDxt3Ext = 35918,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        CompressedSrgbAlphaS3tcDxt5Ext = 35919,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        TransformFeedbackVaryingMaxLength = 35958,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        TransformFeedbackBufferMode = 35967,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80
        MaxTransformFeedbackSeparateComponents = 35968,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        TransformFeedbackVaryings = 35971,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        TransformFeedbackBufferStart = 35972,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        TransformFeedbackBufferSize = 35973,
        //
        // Resumo:
        //     Original was GL_PRIMITIVES_GENERATED = 0x8C87
        PrimitivesGenerated = 35975,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        TransformFeedbackPrimitivesWritten = 35976,
        //
        // Resumo:
        //     Original was GL_RASTERIZER_DISCARD = 0x8C89
        RasterizerDiscard = 35977,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A
        MaxTransformFeedbackInterleavedComponents = 35978,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B
        MaxTransformFeedbackSeparateAttribs = 35979,
        //
        // Resumo:
        //     Original was GL_INTERLEAVED_ATTRIBS = 0x8C8C
        InterleavedAttribs = 35980,
        //
        // Resumo:
        //     Original was GL_SEPARATE_ATTRIBS = 0x8C8D
        SeparateAttribs = 35981,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        TransformFeedbackBuffer = 35982,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        TransformFeedbackBufferBinding = 35983,
        //
        // Resumo:
        //     Original was GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0
        PointSpriteCoordOrigin = 36000,
        //
        // Resumo:
        //     Original was GL_LOWER_LEFT = 0x8CA1
        LowerLeft = 36001,
        //
        // Resumo:
        //     Original was GL_UPPER_LEFT = 0x8CA2
        UpperLeft = 36002,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_REF = 0x8CA3
        StencilBackRef = 36003,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_VALUE_MASK = 0x8CA4
        StencilBackValueMask = 36004,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_WRITEMASK = 0x8CA5
        StencilBackWritemask = 36005,
        //
        // Resumo:
        //     Original was GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6
        DrawFramebufferBinding = 36006,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_BINDING = 0x8CA6
        FramebufferBinding = 36006,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_BINDING_EXT = 0x8CA6
        FramebufferBindingExt = 36006,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_BINDING = 0x8CA7
        RenderbufferBinding = 36007,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_BINDING_EXT = 0x8CA7
        RenderbufferBindingExt = 36007,
        //
        // Resumo:
        //     Original was GL_READ_FRAMEBUFFER = 0x8CA8
        ReadFramebuffer = 36008,
        //
        // Resumo:
        //     Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        DrawFramebuffer = 36009,
        //
        // Resumo:
        //     Original was GL_READ_FRAMEBUFFER_BINDING = 0x8CAA
        ReadFramebufferBinding = 36010,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB
        RenderbufferCoverageSamplesNv = 36011,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        RenderbufferSamples = 36011,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        DepthComponent32f = 36012,
        //
        // Resumo:
        //     Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        Depth32fStencil8 = 36013,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0
        FramebufferAttachmentObjectType = 36048,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0
        FramebufferAttachmentObjectTypeExt = 36048,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        FramebufferAttachmentObjectName = 36049,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1
        FramebufferAttachmentObjectNameExt = 36049,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        FramebufferAttachmentTextureLevel = 36050,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2
        FramebufferAttachmentTextureLevelExt = 36050,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        FramebufferAttachmentTextureCubeMapFace = 36051,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3
        FramebufferAttachmentTextureCubeMapFaceExt = 36051,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4
        FramebufferAttachmentTexture3DZoffsetExt = 36052,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        FramebufferAttachmentTextureLayer = 36052,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        FramebufferComplete = 36053,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_COMPLETE_EXT = 0x8CD5
        FramebufferCompleteExt = 36053,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        FramebufferIncompleteAttachment = 36054,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6
        FramebufferIncompleteAttachmentExt = 36054,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        FramebufferIncompleteMissingAttachment = 36055,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7
        FramebufferIncompleteMissingAttachmentExt = 36055,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9
        FramebufferIncompleteDimensionsExt = 36057,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA
        FramebufferIncompleteFormatsExt = 36058,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
        FramebufferIncompleteDrawBuffer = 36059,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB
        FramebufferIncompleteDrawBufferExt = 36059,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
        FramebufferIncompleteReadBuffer = 36060,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC
        FramebufferIncompleteReadBufferExt = 36060,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        FramebufferUnsupported = 36061,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD
        FramebufferUnsupportedExt = 36061,
        //
        // Resumo:
        //     Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        MaxColorAttachments = 36063,
        //
        // Resumo:
        //     Original was GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
        MaxColorAttachmentsExt = 36063,
        //
        // Resumo:
        //     Original was GL_MAX_COLOR_ATTACHMENTS_NV = 0x8CDF
        MaxColorAttachmentsNv = 36063,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        ColorAttachment0 = 36064,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
        ColorAttachment0Ext = 36064,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT0_NV = 0x8CE0
        ColorAttachment0Nv = 36064,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        ColorAttachment0Oes = 36064,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        ColorAttachment1 = 36065,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
        ColorAttachment1Ext = 36065,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT1_NV = 0x8CE1
        ColorAttachment1Nv = 36065,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        ColorAttachment2 = 36066,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
        ColorAttachment2Ext = 36066,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT2_NV = 0x8CE2
        ColorAttachment2Nv = 36066,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        ColorAttachment3 = 36067,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
        ColorAttachment3Ext = 36067,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT3_NV = 0x8CE3
        ColorAttachment3Nv = 36067,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        ColorAttachment4 = 36068,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
        ColorAttachment4Ext = 36068,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT4_NV = 0x8CE4
        ColorAttachment4Nv = 36068,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        ColorAttachment5 = 36069,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
        ColorAttachment5Ext = 36069,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT5_NV = 0x8CE5
        ColorAttachment5Nv = 36069,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        ColorAttachment6 = 36070,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
        ColorAttachment6Ext = 36070,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT6_NV = 0x8CE6
        ColorAttachment6Nv = 36070,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        ColorAttachment7 = 36071,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
        ColorAttachment7Ext = 36071,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT7_NV = 0x8CE7
        ColorAttachment7Nv = 36071,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        ColorAttachment8 = 36072,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
        ColorAttachment8Ext = 36072,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT8_NV = 0x8CE8
        ColorAttachment8Nv = 36072,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        ColorAttachment9 = 36073,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
        ColorAttachment9Ext = 36073,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT9_NV = 0x8CE9
        ColorAttachment9Nv = 36073,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        ColorAttachment10 = 36074,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
        ColorAttachment10Ext = 36074,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT10_NV = 0x8CEA
        ColorAttachment10Nv = 36074,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        ColorAttachment11 = 36075,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
        ColorAttachment11Ext = 36075,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT11_NV = 0x8CEB
        ColorAttachment11Nv = 36075,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        ColorAttachment12 = 36076,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
        ColorAttachment12Ext = 36076,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT12_NV = 0x8CEC
        ColorAttachment12Nv = 36076,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        ColorAttachment13 = 36077,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT13_EXT = 0x8CED
        ColorAttachment13Ext = 36077,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT13_NV = 0x8CED
        ColorAttachment13Nv = 36077,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        ColorAttachment14 = 36078,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
        ColorAttachment14Ext = 36078,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT14_NV = 0x8CEE
        ColorAttachment14Nv = 36078,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        ColorAttachment15 = 36079,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
        ColorAttachment15Ext = 36079,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT15_NV = 0x8CEF
        ColorAttachment15Nv = 36079,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        ColorAttachment16 = 36080,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        ColorAttachment17 = 36081,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        ColorAttachment18 = 36082,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        ColorAttachment19 = 36083,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        ColorAttachment20 = 36084,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        ColorAttachment21 = 36085,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        ColorAttachment22 = 36086,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        ColorAttachment23 = 36087,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        ColorAttachment24 = 36088,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        ColorAttachment25 = 36089,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        ColorAttachment26 = 36090,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        ColorAttachment27 = 36091,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        ColorAttachment28 = 36092,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        ColorAttachment29 = 36093,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        ColorAttachment30 = 36094,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        ColorAttachment31 = 36095,
        //
        // Resumo:
        //     Original was GL_DEPTH_ATTACHMENT = 0x8D00
        DepthAttachment = 36096,
        //
        // Resumo:
        //     Original was GL_DEPTH_ATTACHMENT_EXT = 0x8D00
        DepthAttachmentExt = 36096,
        //
        // Resumo:
        //     Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        DepthAttachmentOes = 36096,
        //
        // Resumo:
        //     Original was GL_STENCIL_ATTACHMENT = 0x8D20
        StencilAttachment = 36128,
        //
        // Resumo:
        //     Original was GL_STENCIL_ATTACHMENT_EXT = 0x8D20
        StencilAttachmentExt = 36128,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER = 0x8D40
        Framebuffer = 36160,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_EXT = 0x8D40
        FramebufferExt = 36160,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER = 0x8D41
        Renderbuffer = 36161,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_EXT = 0x8D41
        RenderbufferExt = 36161,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        RenderbufferWidth = 36162,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_WIDTH_EXT = 0x8D42
        RenderbufferWidthExt = 36162,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        RenderbufferHeight = 36163,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_HEIGHT_EXT = 0x8D43
        RenderbufferHeightExt = 36163,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        RenderbufferInternalFormat = 36164,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44
        RenderbufferInternalFormatExt = 36164,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX1 = 0x8D46
        StencilIndex1 = 36166,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX1_EXT = 0x8D46
        StencilIndex1Ext = 36166,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX4 = 0x8D47
        StencilIndex4 = 36167,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX4_EXT = 0x8D47
        StencilIndex4Ext = 36167,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX8 = 0x8D48
        StencilIndex8 = 36168,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX8_EXT = 0x8D48
        StencilIndex8Ext = 36168,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX16 = 0x8D49
        StencilIndex16 = 36169,
        //
        // Resumo:
        //     Original was GL_STENCIL_INDEX16_EXT = 0x8D49
        StencilIndex16Ext = 36169,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        RenderbufferRedSize = 36176,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_RED_SIZE_EXT = 0x8D50
        RenderbufferRedSizeExt = 36176,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        RenderbufferGreenSize = 36177,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51
        RenderbufferGreenSizeExt = 36177,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        RenderbufferBlueSize = 36178,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52
        RenderbufferBlueSizeExt = 36178,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        RenderbufferAlphaSize = 36179,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53
        RenderbufferAlphaSizeExt = 36179,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        RenderbufferDepthSize = 36180,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54
        RenderbufferDepthSizeExt = 36180,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        RenderbufferStencilSize = 36181,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55
        RenderbufferStencilSizeExt = 36181,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        FramebufferIncompleteMultisample = 36182,
        //
        // Resumo:
        //     Original was GL_MAX_SAMPLES = 0x8D57
        MaxSamples = 36183,
        //
        // Resumo:
        //     Original was GL_RGB565 = 0x8D62
        Rgb565 = 36194,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
        PrimitiveRestartFixedIndex = 36201,
        //
        // Resumo:
        //     Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        AnySamplesPassedConservative = 36202,
        //
        // Resumo:
        //     Original was GL_MAX_ELEMENT_INDEX = 0x8D6B
        MaxElementIndex = 36203,
        //
        // Resumo:
        //     Original was GL_RGBA32UI = 0x8D70
        Rgba32ui = 36208,
        //
        // Resumo:
        //     Original was GL_RGB32UI = 0x8D71
        Rgb32ui = 36209,
        //
        // Resumo:
        //     Original was GL_RGBA16UI = 0x8D76
        Rgba16ui = 36214,
        //
        // Resumo:
        //     Original was GL_RGB16UI = 0x8D77
        Rgb16ui = 36215,
        //
        // Resumo:
        //     Original was GL_RGBA8UI = 0x8D7C
        Rgba8ui = 36220,
        //
        // Resumo:
        //     Original was GL_RGB8UI = 0x8D7D
        Rgb8ui = 36221,
        //
        // Resumo:
        //     Original was GL_RGBA32I = 0x8D82
        Rgba32i = 36226,
        //
        // Resumo:
        //     Original was GL_RGB32I = 0x8D83
        Rgb32i = 36227,
        //
        // Resumo:
        //     Original was GL_RGBA16I = 0x8D88
        Rgba16i = 36232,
        //
        // Resumo:
        //     Original was GL_RGB16I = 0x8D89
        Rgb16i = 36233,
        //
        // Resumo:
        //     Original was GL_RGBA8I = 0x8D8E
        Rgba8i = 36238,
        //
        // Resumo:
        //     Original was GL_RGB8I = 0x8D8F
        Rgb8i = 36239,
        //
        // Resumo:
        //     Original was GL_RED_INTEGER = 0x8D94
        RedInteger = 36244,
        //
        // Resumo:
        //     Original was GL_GREEN_INTEGER = 0x8D95
        GreenInteger = 36245,
        //
        // Resumo:
        //     Original was GL_BLUE_INTEGER = 0x8D96
        BlueInteger = 36246,
        //
        // Resumo:
        //     Original was GL_ALPHA_INTEGER = 0x8D97
        AlphaInteger = 36247,
        //
        // Resumo:
        //     Original was GL_RGB_INTEGER = 0x8D98
        RgbInteger = 36248,
        //
        // Resumo:
        //     Original was GL_RGBA_INTEGER = 0x8D99
        RgbaInteger = 36249,
        //
        // Resumo:
        //     Original was GL_BGR_INTEGER = 0x8D9A
        BgrInteger = 36250,
        //
        // Resumo:
        //     Original was GL_BGRA_INTEGER = 0x8D9B
        BgraInteger = 36251,
        //
        // Resumo:
        //     Original was GL_INT_2_10_10_10_REV = 0x8D9F
        Int2101010Rev = 36255,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7
        FramebufferAttachmentLayered = 36263,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7
        FramebufferAttachmentLayeredArb = 36263,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        FramebufferIncompleteLayerTargets = 36264,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8
        FramebufferIncompleteLayerTargetsArb = 36264,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT = 0x8DA9
        FramebufferIncompleteLayerCount = 36265,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9
        FramebufferIncompleteLayerCountArb = 36265,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        DepthComponent32fNv = 36267,
        //
        // Resumo:
        //     Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        Depth32fStencil8Nv = 36268,
        //
        // Resumo:
        //     Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        Float32UnsignedInt248Rev = 36269,
        //
        // Resumo:
        //     Original was GL_SHADER_INCLUDE_ARB = 0x8DAE
        ShaderIncludeArb = 36270,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_SRGB = 0x8DB9
        FramebufferSrgb = 36281,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        CompressedRedRgtc1 = 36283,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB
        CompressedRedRgtc1Ext = 36283,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        CompressedSignedRedRgtc1 = 36284,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC
        CompressedSignedRedRgtc1Ext = 36284,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        CompressedRgRgtc2 = 36285,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        CompressedSignedRgRgtc2 = 36286,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D_ARRAY = 0x8DC0
        Sampler1DArray = 36288,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_ARRAY = 0x8DC1
        Sampler2DArray = 36289,
        //
        // Resumo:
        //     Original was GL_SAMPLER_BUFFER = 0x8DC2
        SamplerBuffer = 36290,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3
        Sampler1DArrayShadow = 36291,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4
        Sampler2DArrayShadow = 36292,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_SHADOW = 0x8DC5
        SamplerCubeShadow = 36293,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC2 = 0x8DC6
        UnsignedIntVec2 = 36294,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC3 = 0x8DC7
        UnsignedIntVec3 = 36295,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC4 = 0x8DC8
        UnsignedIntVec4 = 36296,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_1D = 0x8DC9
        IntSampler1D = 36297,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D = 0x8DCA
        IntSampler2D = 36298,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_3D = 0x8DCB
        IntSampler3D = 36299,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_CUBE = 0x8DCC
        IntSamplerCube = 36300,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_RECT = 0x8DCD
        IntSampler2DRect = 36301,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_1D_ARRAY = 0x8DCE
        IntSampler1DArray = 36302,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_ARRAY = 0x8DCF
        IntSampler2DArray = 36303,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_BUFFER = 0x8DD0
        IntSamplerBuffer = 36304,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1
        UnsignedIntSampler1D = 36305,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2
        UnsignedIntSampler2D = 36306,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3
        UnsignedIntSampler3D = 36307,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4
        UnsignedIntSamplerCube = 36308,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5
        UnsignedIntSampler2DRect = 36309,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6
        UnsignedIntSampler1DArray = 36310,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7
        UnsignedIntSampler2DArray = 36311,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8
        UnsignedIntSamplerBuffer = 36312,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER = 0x8DD9
        GeometryShader = 36313,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER_ARB = 0x8DD9
        GeometryShaderArb = 36313,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA
        GeometryVerticesOutArb = 36314,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB
        GeometryInputTypeArb = 36315,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC
        GeometryOutputTypeArb = 36316,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_VARYING_COMPONENTS = 0x8DDD
        MaxGeometryVaryingComponents = 36317,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD
        MaxGeometryVaryingComponentsArb = 36317,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_VARYING_COMPONENTS = 0x8DDE
        MaxVertexVaryingComponents = 36318,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE
        MaxVertexVaryingComponentsArb = 36318,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF
        MaxGeometryUniformComponents = 36319,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF
        MaxGeometryUniformComponentsArb = 36319,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0
        MaxGeometryOutputVertices = 36320,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0
        MaxGeometryOutputVerticesArb = 36320,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1
        MaxGeometryTotalOutputComponents = 36321,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1
        MaxGeometryTotalOutputComponentsArb = 36321,
        //
        // Resumo:
        //     Original was GL_ACTIVE_SUBROUTINES = 0x8DE5
        ActiveSubroutines = 36325,
        //
        // Resumo:
        //     Original was GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
        ActiveSubroutineUniforms = 36326,
        //
        // Resumo:
        //     Original was GL_MAX_SUBROUTINES = 0x8DE7
        MaxSubroutines = 36327,
        //
        // Resumo:
        //     Original was GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8
        MaxSubroutineUniformLocations = 36328,
        //
        // Resumo:
        //     Original was GL_NAMED_STRING_LENGTH_ARB = 0x8DE9
        NamedStringLengthArb = 36329,
        //
        // Resumo:
        //     Original was GL_NAMED_STRING_TYPE_ARB = 0x8DEA
        NamedStringTypeArb = 36330,
        //
        // Resumo:
        //     Original was GL_LOW_FLOAT = 0x8DF0
        LowFloat = 36336,
        //
        // Resumo:
        //     Original was GL_MEDIUM_FLOAT = 0x8DF1
        MediumFloat = 36337,
        //
        // Resumo:
        //     Original was GL_HIGH_FLOAT = 0x8DF2
        HighFloat = 36338,
        //
        // Resumo:
        //     Original was GL_LOW_INT = 0x8DF3
        LowInt = 36339,
        //
        // Resumo:
        //     Original was GL_MEDIUM_INT = 0x8DF4
        MediumInt = 36340,
        //
        // Resumo:
        //     Original was GL_HIGH_INT = 0x8DF5
        HighInt = 36341,
        //
        // Resumo:
        //     Original was GL_SHADER_BINARY_FORMATS = 0x8DF8
        ShaderBinaryFormats = 36344,
        //
        // Resumo:
        //     Original was GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9
        NumShaderBinaryFormats = 36345,
        //
        // Resumo:
        //     Original was GL_SHADER_COMPILER = 0x8DFA
        ShaderCompiler = 36346,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB
        MaxVertexUniformVectors = 36347,
        //
        // Resumo:
        //     Original was GL_MAX_VARYING_VECTORS = 0x8DFC
        MaxVaryingVectors = 36348,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD
        MaxFragmentUniformVectors = 36349,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10
        RenderbufferColorSamplesNv = 36368,
        //
        // Resumo:
        //     Original was GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11
        MaxMultisampleCoverageModesNv = 36369,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12
        MultisampleCoverageModesNv = 36370,
        //
        // Resumo:
        //     Original was GL_QUERY_WAIT = 0x8E13
        QueryWait = 36371,
        //
        // Resumo:
        //     Original was GL_QUERY_WAIT_NV = 0x8E13
        QueryWaitNv = 36371,
        //
        // Resumo:
        //     Original was GL_QUERY_NO_WAIT = 0x8E14
        QueryNoWait = 36372,
        //
        // Resumo:
        //     Original was GL_QUERY_NO_WAIT_NV = 0x8E14
        QueryNoWaitNv = 36372,
        //
        // Resumo:
        //     Original was GL_QUERY_BY_REGION_WAIT = 0x8E15
        QueryByRegionWait = 36373,
        //
        // Resumo:
        //     Original was GL_QUERY_BY_REGION_WAIT_NV = 0x8E15
        QueryByRegionWaitNv = 36373,
        //
        // Resumo:
        //     Original was GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
        QueryByRegionNoWait = 36374,
        //
        // Resumo:
        //     Original was GL_QUERY_BY_REGION_NO_WAIT_NV = 0x8E16
        QueryByRegionNoWaitNv = 36374,
        //
        // Resumo:
        //     Original was GL_QUERY_WAIT_INVERTED = 0x8E17
        QueryWaitInverted = 36375,
        //
        // Resumo:
        //     Original was GL_QUERY_NO_WAIT_INVERTED = 0x8E18
        QueryNoWaitInverted = 36376,
        //
        // Resumo:
        //     Original was GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19
        QueryByRegionWaitInverted = 36377,
        //
        // Resumo:
        //     Original was GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A
        QueryByRegionNoWaitInverted = 36378,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_CLAMP = 0x8E1B
        PolygonOffsetClamp = 36379,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_CLAMP_EXT = 0x8E1B
        PolygonOffsetClampExt = 36379,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E
        MaxCombinedTessControlUniformComponents = 36382,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F
        MaxCombinedTessEvaluationUniformComponents = 36383,
        //
        // Resumo:
        //     Original was GL_COLOR_SAMPLES_NV = 0x8E20
        ColorSamplesNv = 36384,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        TransformFeedback = 36386,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23
        TransformFeedbackBufferPaused = 36387,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        TransformFeedbackPaused = 36387,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        TransformFeedbackActive = 36388,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24
        TransformFeedbackBufferActive = 36388,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25
        TransformFeedbackBinding = 36389,
        //
        // Resumo:
        //     Original was GL_TIMESTAMP = 0x8E28
        Timestamp = 36392,
        //
        // Resumo:
        //     Original was GL_PROGRAM_MATRIX_EXT = 0x8E2D
        ProgramMatrixExt = 36397,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E
        TransposeProgramMatrixExt = 36398,
        //
        // Resumo:
        //     Original was GL_PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F
        ProgramMatrixStackDepthExt = 36399,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        TextureSwizzleR = 36418,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        TextureSwizzleG = 36419,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        TextureSwizzleB = 36420,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        TextureSwizzleA = 36421,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
        TextureSwizzleRgba = 36422,
        //
        // Resumo:
        //     Original was GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
        ActiveSubroutineUniformLocations = 36423,
        //
        // Resumo:
        //     Original was GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
        ActiveSubroutineMaxLength = 36424,
        //
        // Resumo:
        //     Original was GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
        ActiveSubroutineUniformMaxLength = 36425,
        //
        // Resumo:
        //     Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        NumCompatibleSubroutines = 36426,
        //
        // Resumo:
        //     Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        CompatibleSubroutines = 36427,
        //
        // Resumo:
        //     Original was GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C
        QuadsFollowProvokingVertexConvention = 36428,
        //
        // Resumo:
        //     Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        FirstVertexConvention = 36429,
        //
        // Resumo:
        //     Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        LastVertexConvention = 36430,
        //
        // Resumo:
        //     Original was GL_PROVOKING_VERTEX = 0x8E4F
        ProvokingVertex = 36431,
        //
        // Resumo:
        //     Original was GL_SAMPLE_LOCATION_ARB = 0x8E50
        SampleLocationArb = 36432,
        //
        // Resumo:
        //     Original was GL_SAMPLE_LOCATION_NV = 0x8E50
        SampleLocationNv = 36432,
        //
        // Resumo:
        //     Original was GL_SAMPLE_POSITION = 0x8E50
        SamplePosition = 36432,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK = 0x8E51
        SampleMask = 36433,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_VALUE = 0x8E52
        SampleMaskValue = 36434,
        //
        // Resumo:
        //     Original was GL_MAX_SAMPLE_MASK_WORDS = 0x8E59
        MaxSampleMaskWords = 36441,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A
        MaxGeometryShaderInvocations = 36442,
        //
        // Resumo:
        //     Original was GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B
        MinFragmentInterpolationOffset = 36443,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C
        MaxFragmentInterpolationOffset = 36444,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D
        FragmentInterpolationOffsetBits = 36445,
        //
        // Resumo:
        //     Original was GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E
        MinProgramTextureGatherOffset = 36446,
        //
        // Resumo:
        //     Original was GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5E
        MinProgramTextureGatherOffsetArb = 36446,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F
        MaxProgramTextureGatherOffset = 36447,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5F
        MaxProgramTextureGatherOffsetArb = 36447,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70
        MaxTransformFeedbackBuffers = 36464,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_STREAMS = 0x8E71
        MaxVertexStreams = 36465,
        //
        // Resumo:
        //     Original was GL_PATCH_VERTICES = 0x8E72
        PatchVertices = 36466,
        //
        // Resumo:
        //     Original was GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73
        PatchDefaultInnerLevel = 36467,
        //
        // Resumo:
        //     Original was GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74
        PatchDefaultOuterLevel = 36468,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75
        TessControlOutputVertices = 36469,
        //
        // Resumo:
        //     Original was GL_TESS_GEN_MODE = 0x8E76
        TessGenMode = 36470,
        //
        // Resumo:
        //     Original was GL_TESS_GEN_SPACING = 0x8E77
        TessGenSpacing = 36471,
        //
        // Resumo:
        //     Original was GL_TESS_GEN_VERTEX_ORDER = 0x8E78
        TessGenVertexOrder = 36472,
        //
        // Resumo:
        //     Original was GL_TESS_GEN_POINT_MODE = 0x8E79
        TessGenPointMode = 36473,
        //
        // Resumo:
        //     Original was GL_ISOLINES = 0x8E7A
        Isolines = 36474,
        //
        // Resumo:
        //     Original was GL_FRACTIONAL_ODD = 0x8E7B
        FractionalOdd = 36475,
        //
        // Resumo:
        //     Original was GL_FRACTIONAL_EVEN = 0x8E7C
        FractionalEven = 36476,
        //
        // Resumo:
        //     Original was GL_MAX_PATCH_VERTICES = 0x8E7D
        MaxPatchVertices = 36477,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_GEN_LEVEL = 0x8E7E
        MaxTessGenLevel = 36478,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F
        MaxTessControlUniformComponents = 36479,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80
        MaxTessEvaluationUniformComponents = 36480,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81
        MaxTessControlTextureImageUnits = 36481,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82
        MaxTessEvaluationTextureImageUnits = 36482,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83
        MaxTessControlOutputComponents = 36483,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84
        MaxTessPatchComponents = 36484,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85
        MaxTessControlTotalOutputComponents = 36485,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86
        MaxTessEvaluationOutputComponents = 36486,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        TessEvaluationShader = 36487,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_SHADER = 0x8E88
        TessControlShader = 36488,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89
        MaxTessControlUniformBlocks = 36489,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A
        MaxTessEvaluationUniformBlocks = 36490,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        CompressedRgbaBptcUnorm = 36492,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C
        CompressedRgbaBptcUnormArb = 36492,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        CompressedSrgbAlphaBptcUnorm = 36493,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D
        CompressedSrgbAlphaBptcUnormArb = 36493,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        CompressedRgbBptcSignedFloat = 36494,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E
        CompressedRgbBptcSignedFloatArb = 36494,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        CompressedRgbBptcUnsignedFloat = 36495,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F
        CompressedRgbBptcUnsignedFloatArb = 36495,
        //
        // Resumo:
        //     Original was GL_INCLUSIVE_EXT = 0x8F10
        InclusiveExt = 36624,
        //
        // Resumo:
        //     Original was GL_EXCLUSIVE_EXT = 0x8F11
        ExclusiveExt = 36625,
        //
        // Resumo:
        //     Original was GL_WINDOW_RECTANGLE_EXT = 0x8F12
        WindowRectangleExt = 36626,
        //
        // Resumo:
        //     Original was GL_WINDOW_RECTANGLE_MODE_EXT = 0x8F13
        WindowRectangleModeExt = 36627,
        //
        // Resumo:
        //     Original was GL_MAX_WINDOW_RECTANGLES_EXT = 0x8F14
        MaxWindowRectanglesExt = 36628,
        //
        // Resumo:
        //     Original was GL_NUM_WINDOW_RECTANGLES_EXT = 0x8F15
        NumWindowRectanglesExt = 36629,
        //
        // Resumo:
        //     Original was GL_BUFFER_GPU_ADDRESS_NV = 0x8F1D
        BufferGpuAddressNv = 36637,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E
        VertexAttribArrayUnifiedNv = 36638,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F
        ElementArrayUnifiedNv = 36639,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20
        VertexAttribArrayAddressNv = 36640,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_ADDRESS_NV = 0x8F21
        VertexArrayAddressNv = 36641,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_ADDRESS_NV = 0x8F22
        NormalArrayAddressNv = 36642,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_ADDRESS_NV = 0x8F23
        ColorArrayAddressNv = 36643,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_ADDRESS_NV = 0x8F24
        IndexArrayAddressNv = 36644,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25
        TextureCoordArrayAddressNv = 36645,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26
        EdgeFlagArrayAddressNv = 36646,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27
        SecondaryColorArrayAddressNv = 36647,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28
        FogCoordArrayAddressNv = 36648,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_ADDRESS_NV = 0x8F29
        ElementArrayAddressNv = 36649,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A
        VertexAttribArrayLengthNv = 36650,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_LENGTH_NV = 0x8F2B
        VertexArrayLengthNv = 36651,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_LENGTH_NV = 0x8F2C
        NormalArrayLengthNv = 36652,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_LENGTH_NV = 0x8F2D
        ColorArrayLengthNv = 36653,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_LENGTH_NV = 0x8F2E
        IndexArrayLengthNv = 36654,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F
        TextureCoordArrayLengthNv = 36655,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30
        EdgeFlagArrayLengthNv = 36656,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31
        SecondaryColorArrayLengthNv = 36657,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_LENGTH_NV = 0x8F32
        FogCoordArrayLengthNv = 36658,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_LENGTH_NV = 0x8F33
        ElementArrayLengthNv = 36659,
        //
        // Resumo:
        //     Original was GL_GPU_ADDRESS_NV = 0x8F34
        GpuAddressNv = 36660,
        //
        // Resumo:
        //     Original was GL_MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35
        MaxShaderBufferAddressNv = 36661,
        //
        // Resumo:
        //     Original was GL_COPY_READ_BUFFER = 0x8F36
        CopyReadBuffer = 36662,
        //
        // Resumo:
        //     Original was GL_COPY_READ_BUFFER_BINDING = 0x8F36
        CopyReadBufferBinding = 36662,
        //
        // Resumo:
        //     Original was GL_COPY_WRITE_BUFFER = 0x8F37
        CopyWriteBuffer = 36663,
        //
        // Resumo:
        //     Original was GL_COPY_WRITE_BUFFER_BINDING = 0x8F37
        CopyWriteBufferBinding = 36663,
        //
        // Resumo:
        //     Original was GL_MAX_IMAGE_UNITS = 0x8F38
        MaxImageUnits = 36664,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39
        MaxCombinedImageUnitsAndFragmentOutputs = 36665,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39
        MaxCombinedShaderOutputResources = 36665,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_NAME = 0x8F3A
        ImageBindingName = 36666,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LEVEL = 0x8F3B
        ImageBindingLevel = 36667,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LAYERED = 0x8F3C
        ImageBindingLayered = 36668,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LAYER = 0x8F3D
        ImageBindingLayer = 36669,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_ACCESS = 0x8F3E
        ImageBindingAccess = 36670,
        //
        // Resumo:
        //     Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        DrawIndirectBuffer = 36671,
        //
        // Resumo:
        //     Original was GL_DRAW_INDIRECT_UNIFIED_NV = 0x8F40
        DrawIndirectUnifiedNv = 36672,
        //
        // Resumo:
        //     Original was GL_DRAW_INDIRECT_ADDRESS_NV = 0x8F41
        DrawIndirectAddressNv = 36673,
        //
        // Resumo:
        //     Original was GL_DRAW_INDIRECT_LENGTH_NV = 0x8F42
        DrawIndirectLengthNv = 36674,
        //
        // Resumo:
        //     Original was GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43
        DrawIndirectBufferBinding = 36675,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2 = 0x8F46
        DoubleMat2 = 36678,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3 = 0x8F47
        DoubleMat3 = 36679,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4 = 0x8F48
        DoubleMat4 = 36680,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2x3 = 0x8F49
        DoubleMat2x3 = 36681,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2x4 = 0x8F4A
        DoubleMat2x4 = 36682,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3x2 = 0x8F4B
        DoubleMat3x2 = 36683,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3x4 = 0x8F4C
        DoubleMat3x4 = 36684,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4x2 = 0x8F4D
        DoubleMat4x2 = 36685,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4x3 = 0x8F4E
        DoubleMat4x3 = 36686,
        //
        // Resumo:
        //     Original was GL_VERTEX_BINDING_BUFFER = 0x8F4F
        VertexBindingBuffer = 36687,
        //
        // Resumo:
        //     Original was GL_R8_SNORM = 0x8F94
        R8Snorm = 36756,
        //
        // Resumo:
        //     Original was GL_RG8_SNORM = 0x8F95
        Rg8Snorm = 36757,
        //
        // Resumo:
        //     Original was GL_RGB8_SNORM = 0x8F96
        Rgb8Snorm = 36758,
        //
        // Resumo:
        //     Original was GL_RGBA8_SNORM = 0x8F97
        Rgba8Snorm = 36759,
        //
        // Resumo:
        //     Original was GL_R16_SNORM = 0x8F98
        R16Snorm = 36760,
        //
        // Resumo:
        //     Original was GL_R16_SNORM_EXT = 0x8F98
        R16SnormExt = 36760,
        //
        // Resumo:
        //     Original was GL_RG16_SNORM = 0x8F99
        Rg16Snorm = 36761,
        //
        // Resumo:
        //     Original was GL_RG16_SNORM_EXT = 0x8F99
        Rg16SnormExt = 36761,
        //
        // Resumo:
        //     Original was GL_RGB16_SNORM = 0x8F9A
        Rgb16Snorm = 36762,
        //
        // Resumo:
        //     Original was GL_RGB16_SNORM_EXT = 0x8F9A
        Rgb16SnormExt = 36762,
        //
        // Resumo:
        //     Original was GL_RGBA16_SNORM = 0x8F9B
        Rgba16Snorm = 36763,
        //
        // Resumo:
        //     Original was GL_SIGNED_NORMALIZED = 0x8F9C
        SignedNormalized = 36764,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_RESTART = 0x8F9D
        PrimitiveRestart = 36765,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_RESTART_INDEX = 0x8F9E
        PrimitiveRestartIndex = 36766,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB = 0x8F9F
        MaxProgramTextureGatherComponentsArb = 36767,
        //
        // Resumo:
        //     Original was GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0
        BinningControlHintQcom = 36784,
        //
        // Resumo:
        //     Original was GL_INT8_NV = 0x8FE0
        Int8Nv = 36832,
        //
        // Resumo:
        //     Original was GL_INT8_VEC2_NV = 0x8FE1
        Int8Vec2Nv = 36833,
        //
        // Resumo:
        //     Original was GL_INT8_VEC3_NV = 0x8FE2
        Int8Vec3Nv = 36834,
        //
        // Resumo:
        //     Original was GL_INT8_VEC4_NV = 0x8FE3
        Int8Vec4Nv = 36835,
        //
        // Resumo:
        //     Original was GL_INT16_NV = 0x8FE4
        Int16Nv = 36836,
        //
        // Resumo:
        //     Original was GL_INT16_VEC2_NV = 0x8FE5
        Int16Vec2Nv = 36837,
        //
        // Resumo:
        //     Original was GL_INT16_VEC3_NV = 0x8FE6
        Int16Vec3Nv = 36838,
        //
        // Resumo:
        //     Original was GL_INT16_VEC4_NV = 0x8FE7
        Int16Vec4Nv = 36839,
        //
        // Resumo:
        //     Original was GL_INT64_VEC2_ARB = 0x8FE9
        Int64Vec2Arb = 36841,
        //
        // Resumo:
        //     Original was GL_INT64_VEC2_NV = 0x8FE9
        Int64Vec2Nv = 36841,
        //
        // Resumo:
        //     Original was GL_INT64_VEC3_ARB = 0x8FEA
        Int64Vec3Arb = 36842,
        //
        // Resumo:
        //     Original was GL_INT64_VEC3_NV = 0x8FEA
        Int64Vec3Nv = 36842,
        //
        // Resumo:
        //     Original was GL_INT64_VEC4_ARB = 0x8FEB
        Int64Vec4Arb = 36843,
        //
        // Resumo:
        //     Original was GL_INT64_VEC4_NV = 0x8FEB
        Int64Vec4Nv = 36843,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT8_NV = 0x8FEC
        UnsignedInt8Nv = 36844,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT8_VEC2_NV = 0x8FED
        UnsignedInt8Vec2Nv = 36845,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT8_VEC3_NV = 0x8FEE
        UnsignedInt8Vec3Nv = 36846,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT8_VEC4_NV = 0x8FEF
        UnsignedInt8Vec4Nv = 36847,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT16_NV = 0x8FF0
        UnsignedInt16Nv = 36848,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT16_VEC2_NV = 0x8FF1
        UnsignedInt16Vec2Nv = 36849,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT16_VEC3_NV = 0x8FF2
        UnsignedInt16Vec3Nv = 36850,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT16_VEC4_NV = 0x8FF3
        UnsignedInt16Vec4Nv = 36851,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5
        UnsignedInt64Vec2Arb = 36853,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_VEC2_NV = 0x8FF5
        UnsignedInt64Vec2Nv = 36853,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6
        UnsignedInt64Vec3Arb = 36854,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_VEC3_NV = 0x8FF6
        UnsignedInt64Vec3Nv = 36854,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7
        UnsignedInt64Vec4Arb = 36855,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT64_VEC4_NV = 0x8FF7
        UnsignedInt64Vec4Nv = 36855,
        //
        // Resumo:
        //     Original was GL_FLOAT16_NV = 0x8FF8
        Float16Nv = 36856,
        //
        // Resumo:
        //     Original was GL_FLOAT16_VEC2_NV = 0x8FF9
        Float16Vec2Nv = 36857,
        //
        // Resumo:
        //     Original was GL_FLOAT16_VEC3_NV = 0x8FFA
        Float16Vec3Nv = 36858,
        //
        // Resumo:
        //     Original was GL_FLOAT16_VEC4_NV = 0x8FFB
        Float16Vec4Nv = 36859,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC2 = 0x8FFC
        DoubleVec2 = 36860,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC3 = 0x8FFD
        DoubleVec3 = 36861,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC4 = 0x8FFE
        DoubleVec4 = 36862,
        //
        // Resumo:
        //     Original was GL_SAMPLER_BUFFER_AMD = 0x9001
        SamplerBufferAmd = 36865,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_BUFFER_AMD = 0x9002
        IntSamplerBufferAmd = 36866,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003
        UnsignedIntSamplerBufferAmd = 36867,
        //
        // Resumo:
        //     Original was GL_TESSELLATION_MODE_AMD = 0x9004
        TessellationModeAmd = 36868,
        //
        // Resumo:
        //     Original was GL_TESSELLATION_FACTOR_AMD = 0x9005
        TessellationFactorAmd = 36869,
        //
        // Resumo:
        //     Original was GL_DISCRETE_AMD = 0x9006
        DiscreteAmd = 36870,
        //
        // Resumo:
        //     Original was GL_CONTINUOUS_AMD = 0x9007
        ContinuousAmd = 36871,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        TextureCubeMapArray = 36873,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
        TextureCubeMapArrayArb = 36873,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009
        TextureCubeMapArrayExt = 36873,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009
        TextureCubeMapArrayOes = 36873,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A
        TextureBindingCubeMapArray = 36874,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A
        TextureBindingCubeMapArrayArb = 36874,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        ProxyTextureCubeMapArray = 36875,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        ProxyTextureCubeMapArrayArb = 36875,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C
        SamplerCubeMapArray = 36876,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C
        SamplerCubeMapArrayArb = 36876,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D
        SamplerCubeMapArrayShadow = 36877,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D
        SamplerCubeMapArrayShadowArb = 36877,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E
        IntSamplerCubeMapArray = 36878,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E
        IntSamplerCubeMapArrayArb = 36878,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F
        UnsignedIntSamplerCubeMapArray = 36879,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F
        UnsignedIntSamplerCubeMapArrayArb = 36879,
        //
        // Resumo:
        //     Original was GL_FACTOR_MIN_AMD = 0x901C
        FactorMinAmd = 36892,
        //
        // Resumo:
        //     Original was GL_FACTOR_MAX_AMD = 0x901D
        FactorMaxAmd = 36893,
        //
        // Resumo:
        //     Original was GL_IMAGE_1D = 0x904C
        Image1D = 36940,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D = 0x904D
        Image2D = 36941,
        //
        // Resumo:
        //     Original was GL_IMAGE_3D = 0x904E
        Image3D = 36942,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_RECT = 0x904F
        Image2DRect = 36943,
        //
        // Resumo:
        //     Original was GL_IMAGE_CUBE = 0x9050
        ImageCube = 36944,
        //
        // Resumo:
        //     Original was GL_IMAGE_BUFFER = 0x9051
        ImageBuffer = 36945,
        //
        // Resumo:
        //     Original was GL_IMAGE_1D_ARRAY = 0x9052
        Image1DArray = 36946,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_ARRAY = 0x9053
        Image2DArray = 36947,
        //
        // Resumo:
        //     Original was GL_IMAGE_CUBE_MAP_ARRAY = 0x9054
        ImageCubeMapArray = 36948,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_MULTISAMPLE = 0x9055
        Image2DMultisample = 36949,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056
        Image2DMultisampleArray = 36950,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_1D = 0x9057
        IntImage1D = 36951,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D = 0x9058
        IntImage2D = 36952,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_3D = 0x9059
        IntImage3D = 36953,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_RECT = 0x905A
        IntImage2DRect = 36954,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_CUBE = 0x905B
        IntImageCube = 36955,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_BUFFER = 0x905C
        IntImageBuffer = 36956,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_1D_ARRAY = 0x905D
        IntImage1DArray = 36957,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_ARRAY = 0x905E
        IntImage2DArray = 36958,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F
        IntImageCubeMapArray = 36959,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060
        IntImage2DMultisample = 36960,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061
        IntImage2DMultisampleArray = 36961,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_1D = 0x9062
        UnsignedIntImage1D = 36962,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D = 0x9063
        UnsignedIntImage2D = 36963,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_3D = 0x9064
        UnsignedIntImage3D = 36964,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065
        UnsignedIntImage2DRect = 36965,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066
        UnsignedIntImageCube = 36966,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067
        UnsignedIntImageBuffer = 36967,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068
        UnsignedIntImage1DArray = 36968,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069
        UnsignedIntImage2DArray = 36969,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A
        UnsignedIntImageCubeMapArray = 36970,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B
        UnsignedIntImage2DMultisample = 36971,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C
        UnsignedIntImage2DMultisampleArray = 36972,
        //
        // Resumo:
        //     Original was GL_MAX_IMAGE_SAMPLES = 0x906D
        MaxImageSamples = 36973,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_FORMAT = 0x906E
        ImageBindingFormat = 36974,
        //
        // Resumo:
        //     Original was GL_RGB10_A2UI = 0x906F
        Rgb10A2ui = 36975,
        //
        // Resumo:
        //     Original was GL_PATH_FORMAT_SVG_NV = 0x9070
        PathFormatSvgNv = 36976,
        //
        // Resumo:
        //     Original was GL_PATH_FORMAT_PS_NV = 0x9071
        PathFormatPsNv = 36977,
        //
        // Resumo:
        //     Original was GL_STANDARD_FONT_NAME_NV = 0x9072
        StandardFontNameNv = 36978,
        //
        // Resumo:
        //     Original was GL_SYSTEM_FONT_NAME_NV = 0x9073
        SystemFontNameNv = 36979,
        //
        // Resumo:
        //     Original was GL_FILE_NAME_NV = 0x9074
        FileNameNv = 36980,
        //
        // Resumo:
        //     Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        PathStrokeWidthNv = 36981,
        //
        // Resumo:
        //     Original was GL_PATH_END_CAPS_NV = 0x9076
        PathEndCapsNv = 36982,
        //
        // Resumo:
        //     Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        PathInitialEndCapNv = 36983,
        //
        // Resumo:
        //     Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        PathTerminalEndCapNv = 36984,
        //
        // Resumo:
        //     Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        PathJoinStyleNv = 36985,
        //
        // Resumo:
        //     Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        PathMiterLimitNv = 36986,
        //
        // Resumo:
        //     Original was GL_PATH_DASH_CAPS_NV = 0x907B
        PathDashCapsNv = 36987,
        //
        // Resumo:
        //     Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        PathInitialDashCapNv = 36988,
        //
        // Resumo:
        //     Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        PathTerminalDashCapNv = 36989,
        //
        // Resumo:
        //     Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        PathDashOffsetNv = 36990,
        //
        // Resumo:
        //     Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        PathClientLengthNv = 36991,
        //
        // Resumo:
        //     Original was GL_PATH_FILL_MODE_NV = 0x9080
        PathFillModeNv = 36992,
        //
        // Resumo:
        //     Original was GL_PATH_FILL_MASK_NV = 0x9081
        PathFillMaskNv = 36993,
        //
        // Resumo:
        //     Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        PathFillCoverModeNv = 36994,
        //
        // Resumo:
        //     Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        PathStrokeCoverModeNv = 36995,
        //
        // Resumo:
        //     Original was GL_PATH_STROKE_MASK_NV = 0x9084
        PathStrokeMaskNv = 36996,
        //
        // Resumo:
        //     Original was GL_COUNT_UP_NV = 0x9088
        CountUpNv = 37000,
        //
        // Resumo:
        //     Original was GL_COUNT_DOWN_NV = 0x9089
        CountDownNv = 37001,
        //
        // Resumo:
        //     Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        PathObjectBoundingBoxNv = 37002,
        //
        // Resumo:
        //     Original was GL_CONVEX_HULL_NV = 0x908B
        ConvexHullNv = 37003,
        //
        // Resumo:
        //     Original was GL_BOUNDING_BOX_NV = 0x908D
        BoundingBoxNv = 37005,
        //
        // Resumo:
        //     Original was GL_TRANSLATE_X_NV = 0x908E
        TranslateXNv = 37006,
        //
        // Resumo:
        //     Original was GL_TRANSLATE_Y_NV = 0x908F
        TranslateYNv = 37007,
        //
        // Resumo:
        //     Original was GL_TRANSLATE_2D_NV = 0x9090
        Translate2DNv = 37008,
        //
        // Resumo:
        //     Original was GL_TRANSLATE_3D_NV = 0x9091
        Translate3DNv = 37009,
        //
        // Resumo:
        //     Original was GL_AFFINE_2D_NV = 0x9092
        Affine2DNv = 37010,
        //
        // Resumo:
        //     Original was GL_AFFINE_3D_NV = 0x9094
        Affine3DNv = 37012,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_AFFINE_2D_NV = 0x9096
        TransposeAffine2DNv = 37014,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
        TransposeAffine3DNv = 37016,
        //
        // Resumo:
        //     Original was GL_UTF8_NV = 0x909A
        Utf8Nv = 37018,
        //
        // Resumo:
        //     Original was GL_UTF16_NV = 0x909B
        Utf16Nv = 37019,
        //
        // Resumo:
        //     Original was GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C
        BoundingBoxOfBoundingBoxesNv = 37020,
        //
        // Resumo:
        //     Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        PathCommandCountNv = 37021,
        //
        // Resumo:
        //     Original was GL_PATH_COORD_COUNT_NV = 0x909E
        PathCoordCountNv = 37022,
        //
        // Resumo:
        //     Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        PathDashArrayCountNv = 37023,
        //
        // Resumo:
        //     Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        PathComputedLengthNv = 37024,
        //
        // Resumo:
        //     Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        PathFillBoundingBoxNv = 37025,
        //
        // Resumo:
        //     Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        PathStrokeBoundingBoxNv = 37026,
        //
        // Resumo:
        //     Original was GL_SQUARE_NV = 0x90A3
        SquareNv = 37027,
        //
        // Resumo:
        //     Original was GL_ROUND_NV = 0x90A4
        RoundNv = 37028,
        //
        // Resumo:
        //     Original was GL_TRIANGULAR_NV = 0x90A5
        TriangularNv = 37029,
        //
        // Resumo:
        //     Original was GL_BEVEL_NV = 0x90A6
        BevelNv = 37030,
        //
        // Resumo:
        //     Original was GL_MITER_REVERT_NV = 0x90A7
        MiterRevertNv = 37031,
        //
        // Resumo:
        //     Original was GL_MITER_TRUNCATE_NV = 0x90A8
        MiterTruncateNv = 37032,
        //
        // Resumo:
        //     Original was GL_SKIP_MISSING_GLYPH_NV = 0x90A9
        SkipMissingGlyphNv = 37033,
        //
        // Resumo:
        //     Original was GL_USE_MISSING_GLYPH_NV = 0x90AA
        UseMissingGlyphNv = 37034,
        //
        // Resumo:
        //     Original was GL_PATH_ERROR_POSITION_NV = 0x90AB
        PathErrorPositionNv = 37035,
        //
        // Resumo:
        //     Original was GL_PATH_FOG_GEN_MODE_NV = 0x90AC
        PathFogGenModeNv = 37036,
        //
        // Resumo:
        //     Original was GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
        AccumAdjacentPairsNv = 37037,
        //
        // Resumo:
        //     Original was GL_ADJACENT_PAIRS_NV = 0x90AE
        AdjacentPairsNv = 37038,
        //
        // Resumo:
        //     Original was GL_FIRST_TO_REST_NV = 0x90AF
        FirstToRestNv = 37039,
        //
        // Resumo:
        //     Original was GL_PATH_GEN_MODE_NV = 0x90B0
        PathGenModeNv = 37040,
        //
        // Resumo:
        //     Original was GL_PATH_GEN_COEFF_NV = 0x90B1
        PathGenCoeffNv = 37041,
        //
        // Resumo:
        //     Original was GL_PATH_GEN_COLOR_FORMAT_NV = 0x90B2
        PathGenColorFormatNv = 37042,
        //
        // Resumo:
        //     Original was GL_PATH_GEN_COMPONENTS_NV = 0x90B3
        PathGenComponentsNv = 37043,
        //
        // Resumo:
        //     Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        PathDashOffsetResetNv = 37044,
        //
        // Resumo:
        //     Original was GL_MOVE_TO_RESETS_NV = 0x90B5
        MoveToResetsNv = 37045,
        //
        // Resumo:
        //     Original was GL_MOVE_TO_CONTINUES_NV = 0x90B6
        MoveToContinuesNv = 37046,
        //
        // Resumo:
        //     Original was GL_PATH_STENCIL_FUNC_NV = 0x90B7
        PathStencilFuncNv = 37047,
        //
        // Resumo:
        //     Original was GL_PATH_STENCIL_REF_NV = 0x90B8
        PathStencilRefNv = 37048,
        //
        // Resumo:
        //     Original was GL_PATH_STENCIL_VALUE_MASK_NV = 0x90B9
        PathStencilValueMaskNv = 37049,
        //
        // Resumo:
        //     Original was GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC
        MinMapBufferAlignment = 37052,
        //
        // Resumo:
        //     Original was GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD
        PathStencilDepthOffsetFactorNv = 37053,
        //
        // Resumo:
        //     Original was GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE
        PathStencilDepthOffsetUnitsNv = 37054,
        //
        // Resumo:
        //     Original was GL_PATH_COVER_DEPTH_FUNC_NV = 0x90BF
        PathCoverDepthFuncNv = 37055,
        //
        // Resumo:
        //     Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        ImageFormatCompatibilityType = 37063,
        //
        // Resumo:
        //     Original was GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8
        ImageFormatCompatibilityBySize = 37064,
        //
        // Resumo:
        //     Original was GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9
        ImageFormatCompatibilityByClass = 37065,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA
        MaxVertexImageUniforms = 37066,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB
        MaxTessControlImageUniforms = 37067,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC
        MaxTessEvaluationImageUniforms = 37068,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD
        MaxGeometryImageUniforms = 37069,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE
        MaxFragmentImageUniforms = 37070,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF
        MaxCombinedImageUniforms = 37071,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        ShaderStorageBuffer = 37074,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3
        ShaderStorageBufferBinding = 37075,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BUFFER_START = 0x90D4
        ShaderStorageBufferStart = 37076,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5
        ShaderStorageBufferSize = 37077,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6
        MaxVertexShaderStorageBlocks = 37078,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7
        MaxGeometryShaderStorageBlocks = 37079,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8
        MaxTessControlShaderStorageBlocks = 37080,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9
        MaxTessEvaluationShaderStorageBlocks = 37081,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA
        MaxFragmentShaderStorageBlocks = 37082,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB
        MaxComputeShaderStorageBlocks = 37083,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC
        MaxCombinedShaderStorageBlocks = 37084,
        //
        // Resumo:
        //     Original was GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD
        MaxShaderStorageBufferBindings = 37085,
        //
        // Resumo:
        //     Original was GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE
        MaxShaderStorageBlockSize = 37086,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF
        ShaderStorageBufferOffsetAlignment = 37087,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        DepthStencilTextureMode = 37098,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB
        MaxComputeFixedGroupInvocationsArb = 37099,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB
        MaxComputeWorkGroupInvocations = 37099,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        UniformBlockReferencedByComputeShader = 37100,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
        AtomicCounterBufferReferencedByComputeShader = 37101,
        //
        // Resumo:
        //     Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        DispatchIndirectBuffer = 37102,
        //
        // Resumo:
        //     Original was GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF
        DispatchIndirectBufferBinding = 37103,
        //
        // Resumo:
        //     Original was GL_CONTEXT_ROBUST_ACCESS = 0x90F3
        ContextRobustAccess = 37107,
        //
        // Resumo:
        //     Original was GL_CONTEXT_ROBUST_ACCESS_KHR = 0x90F3
        ContextRobustAccessKhr = 37107,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        Texture2DMultisample = 37120,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101
        ProxyTexture2DMultisample = 37121,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        Texture2DMultisampleArray = 37122,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103
        ProxyTexture2DMultisampleArray = 37123,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104
        TextureBinding2DMultisample = 37124,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105
        TextureBinding2DMultisampleArray = 37125,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SAMPLES = 0x9106
        TextureSamples = 37126,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107
        TextureFixedSampleLocations = 37127,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_MULTISAMPLE = 0x9108
        Sampler2DMultisample = 37128,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109
        IntSampler2DMultisample = 37129,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A
        UnsignedIntSampler2DMultisample = 37130,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B
        Sampler2DMultisampleArray = 37131,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C
        IntSampler2DMultisampleArray = 37132,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D
        UnsignedIntSampler2DMultisampleArray = 37133,
        //
        // Resumo:
        //     Original was GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E
        MaxColorTextureSamples = 37134,
        //
        // Resumo:
        //     Original was GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F
        MaxDepthTextureSamples = 37135,
        //
        // Resumo:
        //     Original was GL_MAX_INTEGER_SAMPLES = 0x9110
        MaxIntegerSamples = 37136,
        //
        // Resumo:
        //     Original was GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111
        MaxServerWaitTimeout = 37137,
        //
        // Resumo:
        //     Original was GL_OBJECT_TYPE = 0x9112
        ObjectType = 37138,
        //
        // Resumo:
        //     Original was GL_SYNC_CONDITION = 0x9113
        SyncCondition = 37139,
        //
        // Resumo:
        //     Original was GL_SYNC_STATUS = 0x9114
        SyncStatus = 37140,
        //
        // Resumo:
        //     Original was GL_SYNC_FLAGS = 0x9115
        SyncFlags = 37141,
        //
        // Resumo:
        //     Original was GL_SYNC_FENCE = 0x9116
        SyncFence = 37142,
        //
        // Resumo:
        //     Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        SyncGpuCommandsComplete = 37143,
        //
        // Resumo:
        //     Original was GL_UNSIGNALED = 0x9118
        Unsignaled = 37144,
        //
        // Resumo:
        //     Original was GL_SIGNALED = 0x9119
        Signaled = 37145,
        //
        // Resumo:
        //     Original was GL_ALREADY_SIGNALED = 0x911A
        AlreadySignaled = 37146,
        //
        // Resumo:
        //     Original was GL_TIMEOUT_EXPIRED = 0x911B
        TimeoutExpired = 37147,
        //
        // Resumo:
        //     Original was GL_CONDITION_SATISFIED = 0x911C
        ConditionSatisfied = 37148,
        //
        // Resumo:
        //     Original was GL_WAIT_FAILED = 0x911D
        WaitFailed = 37149,
        //
        // Resumo:
        //     Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        BufferAccessFlags = 37151,
        //
        // Resumo:
        //     Original was GL_BUFFER_MAP_LENGTH = 0x9120
        BufferMapLength = 37152,
        //
        // Resumo:
        //     Original was GL_BUFFER_MAP_OFFSET = 0x9121
        BufferMapOffset = 37153,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122
        MaxVertexOutputComponents = 37154,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123
        MaxGeometryInputComponents = 37155,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124
        MaxGeometryOutputComponents = 37156,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125
        MaxFragmentInputComponents = 37157,
        //
        // Resumo:
        //     Original was GL_CONTEXT_PROFILE_MASK = 0x9126
        ContextProfileMask = 37158,
        //
        // Resumo:
        //     Original was GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127
        UnpackCompressedBlockWidth = 37159,
        //
        // Resumo:
        //     Original was GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128
        UnpackCompressedBlockHeight = 37160,
        //
        // Resumo:
        //     Original was GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129
        UnpackCompressedBlockDepth = 37161,
        //
        // Resumo:
        //     Original was GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A
        UnpackCompressedBlockSize = 37162,
        //
        // Resumo:
        //     Original was GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B
        PackCompressedBlockWidth = 37163,
        //
        // Resumo:
        //     Original was GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C
        PackCompressedBlockHeight = 37164,
        //
        // Resumo:
        //     Original was GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D
        PackCompressedBlockDepth = 37165,
        //
        // Resumo:
        //     Original was GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E
        PackCompressedBlockSize = 37166,
        //
        // Resumo:
        //     Original was GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F
        TextureImmutableFormat = 37167,
        //
        // Resumo:
        //     Original was GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
        MaxDebugMessageLength = 37187,
        //
        // Resumo:
        //     Original was GL_MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143
        MaxDebugMessageLengthArb = 37187,
        //
        // Resumo:
        //     Original was GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143
        MaxDebugMessageLengthKhr = 37187,
        //
        // Resumo:
        //     Original was GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
        MaxDebugLoggedMessages = 37188,
        //
        // Resumo:
        //     Original was GL_MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144
        MaxDebugLoggedMessagesArb = 37188,
        //
        // Resumo:
        //     Original was GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144
        MaxDebugLoggedMessagesKhr = 37188,
        //
        // Resumo:
        //     Original was GL_DEBUG_LOGGED_MESSAGES = 0x9145
        DebugLoggedMessages = 37189,
        //
        // Resumo:
        //     Original was GL_DEBUG_LOGGED_MESSAGES_ARB = 0x9145
        DebugLoggedMessagesArb = 37189,
        //
        // Resumo:
        //     Original was GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145
        DebugLoggedMessagesKhr = 37189,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        DebugSeverityHigh = 37190,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_HIGH_ARB = 0x9146
        DebugSeverityHighArb = 37190,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146
        DebugSeverityHighKhr = 37190,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        DebugSeverityMedium = 37191,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_MEDIUM_ARB = 0x9147
        DebugSeverityMediumArb = 37191,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147
        DebugSeverityMediumKhr = 37191,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        DebugSeverityLow = 37192,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_LOW_ARB = 0x9148
        DebugSeverityLowArb = 37192,
        //
        // Resumo:
        //     Original was GL_DEBUG_SEVERITY_LOW_KHR = 0x9148
        DebugSeverityLowKhr = 37192,
        //
        // Resumo:
        //     Original was GL_BUFFER_OBJECT_EXT = 0x9151
        BufferObjectExt = 37201,
        //
        // Resumo:
        //     Original was GL_QUERY_OBJECT_EXT = 0x9153
        QueryObjectExt = 37203,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154
        VertexArrayObjectExt = 37204,
        //
        // Resumo:
        //     Original was GL_QUERY_BUFFER = 0x9192
        QueryBuffer = 37266,
        //
        // Resumo:
        //     Original was GL_QUERY_BUFFER_BINDING = 0x9193
        QueryBufferBinding = 37267,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT_NO_WAIT = 0x9194
        QueryResultNoWait = 37268,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195
        VirtualPageSizeXArb = 37269,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196
        VirtualPageSizeYArb = 37270,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197
        VirtualPageSizeZArb = 37271,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198
        MaxSparseTextureSizeArb = 37272,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199
        MaxSparse3DTextureSizeArb = 37273,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A
        MaxSparseArrayTextureLayersArb = 37274,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_OFFSET = 0x919D
        TextureBufferOffset = 37277,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_SIZE = 0x919E
        TextureBufferSize = 37278,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F
        TextureBufferOffsetAlignment = 37279,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SPARSE_ARB = 0x91A6
        TextureSparseArb = 37286,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7
        VirtualPageSizeIndexArb = 37287,
        //
        // Resumo:
        //     Original was GL_NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8
        NumVirtualPageSizesArb = 37288,
        //
        // Resumo:
        //     Original was GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9
        SparseTextureFullArrayCubeMipmapsArb = 37289,
        //
        // Resumo:
        //     Original was GL_NUM_SPARSE_LEVELS_ARB = 0x91AA
        NumSparseLevelsArb = 37290,
        //
        // Resumo:
        //     Original was GL_MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0
        MaxShaderCompilerThreadsArb = 37296,
        //
        // Resumo:
        //     Original was GL_MAX_SHADER_COMPILER_THREADS_KHR = 0x91B0
        MaxShaderCompilerThreadsKhr = 37296,
        //
        // Resumo:
        //     Original was GL_COMPLETION_STATUS_ARB = 0x91B1
        CompletionStatusArb = 37297,
        //
        // Resumo:
        //     Original was GL_COMPLETION_STATUS_KHR = 0x91B1
        CompletionStatusKhr = 37297,
        //
        // Resumo:
        //     Original was GL_COMPUTE_SHADER = 0x91B9
        ComputeShader = 37305,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB
        MaxComputeUniformBlocks = 37307,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC
        MaxComputeTextureImageUnits = 37308,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD
        MaxComputeImageUniforms = 37309,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE
        MaxComputeWorkGroupCount = 37310,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF
        MaxComputeFixedGroupSizeArb = 37311,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF
        MaxComputeWorkGroupSize = 37311,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_R11_EAC = 0x9270
        CompressedR11Eac = 37488,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        CompressedSignedR11Eac = 37489,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RG11_EAC = 0x9272
        CompressedRg11Eac = 37490,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        CompressedSignedRg11Eac = 37491,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        CompressedRgb8Etc2 = 37492,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        CompressedSrgb8Etc2 = 37493,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        CompressedRgb8PunchthroughAlpha1Etc2 = 37494,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        CompressedSrgb8PunchthroughAlpha1Etc2 = 37495,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        CompressedRgba8Etc2Eac = 37496,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        CompressedSrgb8Alpha8Etc2Eac = 37497,
        //
        // Resumo:
        //     Original was GL_BLEND_PREMULTIPLIED_SRC_NV = 0x9280
        BlendPremultipliedSrcNv = 37504,
        //
        // Resumo:
        //     Original was GL_BLEND_OVERLAP_NV = 0x9281
        BlendOverlapNv = 37505,
        //
        // Resumo:
        //     Original was GL_UNCORRELATED_NV = 0x9282
        UncorrelatedNv = 37506,
        //
        // Resumo:
        //     Original was GL_DISJOINT_NV = 0x9283
        DisjointNv = 37507,
        //
        // Resumo:
        //     Original was GL_CONJOINT_NV = 0x9284
        ConjointNv = 37508,
        //
        // Resumo:
        //     Original was GL_BLEND_ADVANCED_COHERENT_KHR = 0x9285
        BlendAdvancedCoherentKhr = 37509,
        //
        // Resumo:
        //     Original was GL_BLEND_ADVANCED_COHERENT_NV = 0x9285
        BlendAdvancedCoherentNv = 37509,
        //
        // Resumo:
        //     Original was GL_SRC_NV = 0x9286
        SrcNv = 37510,
        //
        // Resumo:
        //     Original was GL_DST_NV = 0x9287
        DstNv = 37511,
        //
        // Resumo:
        //     Original was GL_SRC_OVER_NV = 0x9288
        SrcOverNv = 37512,
        //
        // Resumo:
        //     Original was GL_DST_OVER_NV = 0x9289
        DstOverNv = 37513,
        //
        // Resumo:
        //     Original was GL_SRC_IN_NV = 0x928A
        SrcInNv = 37514,
        //
        // Resumo:
        //     Original was GL_DST_IN_NV = 0x928B
        DstInNv = 37515,
        //
        // Resumo:
        //     Original was GL_SRC_OUT_NV = 0x928C
        SrcOutNv = 37516,
        //
        // Resumo:
        //     Original was GL_DST_OUT_NV = 0x928D
        DstOutNv = 37517,
        //
        // Resumo:
        //     Original was GL_SRC_ATOP_NV = 0x928E
        SrcAtopNv = 37518,
        //
        // Resumo:
        //     Original was GL_DST_ATOP_NV = 0x928F
        DstAtopNv = 37519,
        //
        // Resumo:
        //     Original was GL_PLUS_NV = 0x9291
        PlusNv = 37521,
        //
        // Resumo:
        //     Original was GL_PLUS_DARKER_NV = 0x9292
        PlusDarkerNv = 37522,
        //
        // Resumo:
        //     Original was GL_MULTIPLY_KHR = 0x9294
        MultiplyKhr = 37524,
        //
        // Resumo:
        //     Original was GL_MULTIPLY_NV = 0x9294
        MultiplyNv = 37524,
        //
        // Resumo:
        //     Original was GL_SCREEN_KHR = 0x9295
        ScreenKhr = 37525,
        //
        // Resumo:
        //     Original was GL_SCREEN_NV = 0x9295
        ScreenNv = 37525,
        //
        // Resumo:
        //     Original was GL_OVERLAY_KHR = 0x9296
        OverlayKhr = 37526,
        //
        // Resumo:
        //     Original was GL_OVERLAY_NV = 0x9296
        OverlayNv = 37526,
        //
        // Resumo:
        //     Original was GL_DARKEN_KHR = 0x9297
        DarkenKhr = 37527,
        //
        // Resumo:
        //     Original was GL_DARKEN_NV = 0x9297
        DarkenNv = 37527,
        //
        // Resumo:
        //     Original was GL_LIGHTEN_KHR = 0x9298
        LightenKhr = 37528,
        //
        // Resumo:
        //     Original was GL_LIGHTEN_NV = 0x9298
        LightenNv = 37528,
        //
        // Resumo:
        //     Original was GL_COLORDODGE_KHR = 0x9299
        ColordodgeKhr = 37529,
        //
        // Resumo:
        //     Original was GL_COLORDODGE_NV = 0x9299
        ColordodgeNv = 37529,
        //
        // Resumo:
        //     Original was GL_COLORBURN_KHR = 0x929A
        ColorburnKhr = 37530,
        //
        // Resumo:
        //     Original was GL_COLORBURN_NV = 0x929A
        ColorburnNv = 37530,
        //
        // Resumo:
        //     Original was GL_HARDLIGHT_KHR = 0x929B
        HardlightKhr = 37531,
        //
        // Resumo:
        //     Original was GL_HARDLIGHT_NV = 0x929B
        HardlightNv = 37531,
        //
        // Resumo:
        //     Original was GL_SOFTLIGHT_KHR = 0x929C
        SoftlightKhr = 37532,
        //
        // Resumo:
        //     Original was GL_SOFTLIGHT_NV = 0x929C
        SoftlightNv = 37532,
        //
        // Resumo:
        //     Original was GL_DIFFERENCE_KHR = 0x929E
        DifferenceKhr = 37534,
        //
        // Resumo:
        //     Original was GL_DIFFERENCE_NV = 0x929E
        DifferenceNv = 37534,
        //
        // Resumo:
        //     Original was GL_MINUS_NV = 0x929F
        MinusNv = 37535,
        //
        // Resumo:
        //     Original was GL_EXCLUSION_KHR = 0x92A0
        ExclusionKhr = 37536,
        //
        // Resumo:
        //     Original was GL_EXCLUSION_NV = 0x92A0
        ExclusionNv = 37536,
        //
        // Resumo:
        //     Original was GL_CONTRAST_NV = 0x92A1
        ContrastNv = 37537,
        //
        // Resumo:
        //     Original was GL_INVERT_RGB_NV = 0x92A3
        InvertRgbNv = 37539,
        //
        // Resumo:
        //     Original was GL_LINEARDODGE_NV = 0x92A4
        LineardodgeNv = 37540,
        //
        // Resumo:
        //     Original was GL_LINEARBURN_NV = 0x92A5
        LinearburnNv = 37541,
        //
        // Resumo:
        //     Original was GL_VIVIDLIGHT_NV = 0x92A6
        VividlightNv = 37542,
        //
        // Resumo:
        //     Original was GL_LINEARLIGHT_NV = 0x92A7
        LinearlightNv = 37543,
        //
        // Resumo:
        //     Original was GL_PINLIGHT_NV = 0x92A8
        PinlightNv = 37544,
        //
        // Resumo:
        //     Original was GL_HARDMIX_NV = 0x92A9
        HardmixNv = 37545,
        //
        // Resumo:
        //     Original was GL_HSL_HUE_KHR = 0x92AD
        HslHueKhr = 37549,
        //
        // Resumo:
        //     Original was GL_HSL_HUE_NV = 0x92AD
        HslHueNv = 37549,
        //
        // Resumo:
        //     Original was GL_HSL_SATURATION_KHR = 0x92AE
        HslSaturationKhr = 37550,
        //
        // Resumo:
        //     Original was GL_HSL_SATURATION_NV = 0x92AE
        HslSaturationNv = 37550,
        //
        // Resumo:
        //     Original was GL_HSL_COLOR_KHR = 0x92AF
        HslColorKhr = 37551,
        //
        // Resumo:
        //     Original was GL_HSL_COLOR_NV = 0x92AF
        HslColorNv = 37551,
        //
        // Resumo:
        //     Original was GL_HSL_LUMINOSITY_KHR = 0x92B0
        HslLuminosityKhr = 37552,
        //
        // Resumo:
        //     Original was GL_HSL_LUMINOSITY_NV = 0x92B0
        HslLuminosityNv = 37552,
        //
        // Resumo:
        //     Original was GL_PLUS_CLAMPED_NV = 0x92B1
        PlusClampedNv = 37553,
        //
        // Resumo:
        //     Original was GL_PLUS_CLAMPED_ALPHA_NV = 0x92B2
        PlusClampedAlphaNv = 37554,
        //
        // Resumo:
        //     Original was GL_MINUS_CLAMPED_NV = 0x92B3
        MinusClampedNv = 37555,
        //
        // Resumo:
        //     Original was GL_INVERT_OVG_NV = 0x92B4
        InvertOvgNv = 37556,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE
        PrimitiveBoundingBoxArb = 37566,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        AtomicCounterBuffer = 37568,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        AtomicCounterBufferBinding = 37569,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2
        AtomicCounterBufferStart = 37570,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3
        AtomicCounterBufferSize = 37571,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4
        AtomicCounterBufferDataSize = 37572,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5
        AtomicCounterBufferActiveAtomicCounters = 37573,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6
        AtomicCounterBufferActiveAtomicCounterIndices = 37574,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7
        AtomicCounterBufferReferencedByVertexShader = 37575,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8
        AtomicCounterBufferReferencedByTessControlShader = 37576,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER =
        //     0x92C9
        AtomicCounterBufferReferencedByTessEvaluationShader = 37577,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA
        AtomicCounterBufferReferencedByGeometryShader = 37578,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB
        AtomicCounterBufferReferencedByFragmentShader = 37579,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC
        MaxVertexAtomicCounterBuffers = 37580,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD
        MaxTessControlAtomicCounterBuffers = 37581,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE
        MaxTessEvaluationAtomicCounterBuffers = 37582,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF
        MaxGeometryAtomicCounterBuffers = 37583,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0
        MaxFragmentAtomicCounterBuffers = 37584,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1
        MaxCombinedAtomicCounterBuffers = 37585,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2
        MaxVertexAtomicCounters = 37586,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3
        MaxTessControlAtomicCounters = 37587,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4
        MaxTessEvaluationAtomicCounters = 37588,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5
        MaxGeometryAtomicCounters = 37589,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6
        MaxFragmentAtomicCounters = 37590,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7
        MaxCombinedAtomicCounters = 37591,
        //
        // Resumo:
        //     Original was GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8
        MaxAtomicCounterBufferSize = 37592,
        //
        // Resumo:
        //     Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        ActiveAtomicCounterBuffers = 37593,
        //
        // Resumo:
        //     Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        UniformAtomicCounterBufferIndex = 37594,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
        UnsignedIntAtomicCounter = 37595,
        //
        // Resumo:
        //     Original was GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC
        MaxAtomicCounterBufferBindings = 37596,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD
        FragmentCoverageToColorNv = 37597,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_COVERAGE_COLOR_NV = 0x92DE
        FragmentCoverageColorNv = 37598,
        //
        // Resumo:
        //     Original was GL_DEBUG_OUTPUT = 0x92E0
        DebugOutput = 37600,
        //
        // Resumo:
        //     Original was GL_DEBUG_OUTPUT_KHR = 0x92E0
        DebugOutputKhr = 37600,
        //
        // Resumo:
        //     Original was GL_UNIFORM = 0x92E1
        Uniform = 37601,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BLOCK = 0x92E2
        UniformBlock = 37602,
        //
        // Resumo:
        //     Original was GL_PROGRAM_INPUT = 0x92E3
        ProgramInput = 37603,
        //
        // Resumo:
        //     Original was GL_PROGRAM_OUTPUT = 0x92E4
        ProgramOutput = 37604,
        //
        // Resumo:
        //     Original was GL_BUFFER_VARIABLE = 0x92E5
        BufferVariable = 37605,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        ShaderStorageBlock = 37606,
        //
        // Resumo:
        //     Original was GL_IS_PER_PATCH = 0x92E7
        IsPerPatch = 37607,
        //
        // Resumo:
        //     Original was GL_VERTEX_SUBROUTINE = 0x92E8
        VertexSubroutine = 37608,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_SUBROUTINE = 0x92E9
        TessControlSubroutine = 37609,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
        TessEvaluationSubroutine = 37610,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SUBROUTINE = 0x92EB
        GeometrySubroutine = 37611,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SUBROUTINE = 0x92EC
        FragmentSubroutine = 37612,
        //
        // Resumo:
        //     Original was GL_COMPUTE_SUBROUTINE = 0x92ED
        ComputeSubroutine = 37613,
        //
        // Resumo:
        //     Original was GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
        VertexSubroutineUniform = 37614,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
        TessControlSubroutineUniform = 37615,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
        TessEvaluationSubroutineUniform = 37616,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
        GeometrySubroutineUniform = 37617,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
        FragmentSubroutineUniform = 37618,
        //
        // Resumo:
        //     Original was GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
        ComputeSubroutineUniform = 37619,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        TransformFeedbackVarying = 37620,
        //
        // Resumo:
        //     Original was GL_ACTIVE_RESOURCES = 0x92F5
        ActiveResources = 37621,
        //
        // Resumo:
        //     Original was GL_MAX_NAME_LENGTH = 0x92F6
        MaxNameLength = 37622,
        //
        // Resumo:
        //     Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        MaxNumActiveVariables = 37623,
        //
        // Resumo:
        //     Original was GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
        MaxNumCompatibleSubroutines = 37624,
        //
        // Resumo:
        //     Original was GL_NAME_LENGTH = 0x92F9
        NameLength = 37625,
        //
        // Resumo:
        //     Original was GL_TYPE = 0x92FA
        Type = 37626,
        //
        // Resumo:
        //     Original was GL_ARRAY_SIZE = 0x92FB
        ArraySize = 37627,
        //
        // Resumo:
        //     Original was GL_OFFSET = 0x92FC
        Offset = 37628,
        //
        // Resumo:
        //     Original was GL_BLOCK_INDEX = 0x92FD
        BlockIndex = 37629,
        //
        // Resumo:
        //     Original was GL_ARRAY_STRIDE = 0x92FE
        ArrayStride = 37630,
        //
        // Resumo:
        //     Original was GL_MATRIX_STRIDE = 0x92FF
        MatrixStride = 37631,
        //
        // Resumo:
        //     Original was GL_IS_ROW_MAJOR = 0x9300
        IsRowMajor = 37632,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301
        AtomicCounterBufferIndex = 37633,
        //
        // Resumo:
        //     Original was GL_BUFFER_BINDING = 0x9302
        BufferBinding = 37634,
        //
        // Resumo:
        //     Original was GL_BUFFER_DATA_SIZE = 0x9303
        BufferDataSize = 37635,
        //
        // Resumo:
        //     Original was GL_NUM_ACTIVE_VARIABLES = 0x9304
        NumActiveVariables = 37636,
        //
        // Resumo:
        //     Original was GL_ACTIVE_VARIABLES = 0x9305
        ActiveVariables = 37637,
        //
        // Resumo:
        //     Original was GL_REFERENCED_BY_VERTEX_SHADER = 0x9306
        ReferencedByVertexShader = 37638,
        //
        // Resumo:
        //     Original was GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307
        ReferencedByTessControlShader = 37639,
        //
        // Resumo:
        //     Original was GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308
        ReferencedByTessEvaluationShader = 37640,
        //
        // Resumo:
        //     Original was GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309
        ReferencedByGeometryShader = 37641,
        //
        // Resumo:
        //     Original was GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A
        ReferencedByFragmentShader = 37642,
        //
        // Resumo:
        //     Original was GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B
        ReferencedByComputeShader = 37643,
        //
        // Resumo:
        //     Original was GL_TOP_LEVEL_ARRAY_SIZE = 0x930C
        TopLevelArraySize = 37644,
        //
        // Resumo:
        //     Original was GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D
        TopLevelArrayStride = 37645,
        //
        // Resumo:
        //     Original was GL_LOCATION = 0x930E
        Location = 37646,
        //
        // Resumo:
        //     Original was GL_LOCATION_INDEX = 0x930F
        LocationIndex = 37647,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        FramebufferDefaultWidth = 37648,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        FramebufferDefaultHeight = 37649,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        FramebufferDefaultLayers = 37650,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        FramebufferDefaultSamples = 37651,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        FramebufferDefaultFixedSampleLocations = 37652,
        //
        // Resumo:
        //     Original was GL_MAX_FRAMEBUFFER_WIDTH = 0x9315
        MaxFramebufferWidth = 37653,
        //
        // Resumo:
        //     Original was GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316
        MaxFramebufferHeight = 37654,
        //
        // Resumo:
        //     Original was GL_MAX_FRAMEBUFFER_LAYERS = 0x9317
        MaxFramebufferLayers = 37655,
        //
        // Resumo:
        //     Original was GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318
        MaxFramebufferSamples = 37656,
        //
        // Resumo:
        //     Original was GL_RASTER_MULTISAMPLE_EXT = 0x9327
        RasterMultisampleExt = 37671,
        //
        // Resumo:
        //     Original was GL_RASTER_SAMPLES_EXT = 0x9328
        RasterSamplesExt = 37672,
        //
        // Resumo:
        //     Original was GL_MAX_RASTER_SAMPLES_EXT = 0x9329
        MaxRasterSamplesExt = 37673,
        //
        // Resumo:
        //     Original was GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A
        RasterFixedSampleLocationsExt = 37674,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B
        MultisampleRasterizationAllowedExt = 37675,
        //
        // Resumo:
        //     Original was GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C
        EffectiveRasterSamplesExt = 37676,
        //
        // Resumo:
        //     Original was GL_DEPTH_SAMPLES_NV = 0x932D
        DepthSamplesNv = 37677,
        //
        // Resumo:
        //     Original was GL_STENCIL_SAMPLES_NV = 0x932E
        StencilSamplesNv = 37678,
        //
        // Resumo:
        //     Original was GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F
        MixedDepthSamplesSupportedNv = 37679,
        //
        // Resumo:
        //     Original was GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330
        MixedStencilSamplesSupportedNv = 37680,
        //
        // Resumo:
        //     Original was GL_COVERAGE_MODULATION_TABLE_NV = 0x9331
        CoverageModulationTableNv = 37681,
        //
        // Resumo:
        //     Original was GL_COVERAGE_MODULATION_NV = 0x9332
        CoverageModulationNv = 37682,
        //
        // Resumo:
        //     Original was GL_COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333
        CoverageModulationTableSizeNv = 37683,
        //
        // Resumo:
        //     Original was GL_WARP_SIZE_NV = 0x9339
        WarpSizeNv = 37689,
        //
        // Resumo:
        //     Original was GL_WARPS_PER_SM_NV = 0x933A
        WarpsPerSmNv = 37690,
        //
        // Resumo:
        //     Original was GL_SM_COUNT_NV = 0x933B
        SmCountNv = 37691,
        //
        // Resumo:
        //     Original was GL_FILL_RECTANGLE_NV = 0x933C
        FillRectangleNv = 37692,
        //
        // Resumo:
        //     Original was GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D
        SampleLocationSubpixelBitsArb = 37693,
        //
        // Resumo:
        //     Original was GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D
        SampleLocationSubpixelBitsNv = 37693,
        //
        // Resumo:
        //     Original was GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E
        SampleLocationPixelGridWidthArb = 37694,
        //
        // Resumo:
        //     Original was GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E
        SampleLocationPixelGridWidthNv = 37694,
        //
        // Resumo:
        //     Original was GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F
        SampleLocationPixelGridHeightArb = 37695,
        //
        // Resumo:
        //     Original was GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F
        SampleLocationPixelGridHeightNv = 37695,
        //
        // Resumo:
        //     Original was GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340
        ProgrammableSampleLocationTableSizeArb = 37696,
        //
        // Resumo:
        //     Original was GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340
        ProgrammableSampleLocationTableSizeNv = 37696,
        //
        // Resumo:
        //     Original was GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341
        ProgrammableSampleLocationArb = 37697,
        //
        // Resumo:
        //     Original was GL_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341
        ProgrammableSampleLocationNv = 37697,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342
        FramebufferProgrammableSampleLocationsArb = 37698,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342
        FramebufferProgrammableSampleLocationsNv = 37698,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343
        FramebufferSampleLocationPixelGridArb = 37699,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343
        FramebufferSampleLocationPixelGridNv = 37699,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344
        MaxComputeVariableGroupInvocationsArb = 37700,
        //
        // Resumo:
        //     Original was GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345
        MaxComputeVariableGroupSizeArb = 37701,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTERIZATION_NV = 0x9346
        ConservativeRasterizationNv = 37702,
        //
        // Resumo:
        //     Original was GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347
        SubpixelPrecisionBiasXBitsNv = 37703,
        //
        // Resumo:
        //     Original was GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348
        SubpixelPrecisionBiasYBitsNv = 37704,
        //
        // Resumo:
        //     Original was GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349
        MaxSubpixelPrecisionBiasBitsNv = 37705,
        //
        // Resumo:
        //     Original was GL_LOCATION_COMPONENT = 0x934A
        LocationComponent = 37706,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B
        TransformFeedbackBufferIndex = 37707,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C
        TransformFeedbackBufferStride = 37708,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350
        ViewportSwizzlePositiveXNv = 37712,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351
        ViewportSwizzleNegativeXNv = 37713,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352
        ViewportSwizzlePositiveYNv = 37714,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353
        ViewportSwizzleNegativeYNv = 37715,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354
        ViewportSwizzlePositiveZNv = 37716,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355
        ViewportSwizzleNegativeZNv = 37717,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356
        ViewportSwizzlePositiveWNv = 37718,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357
        ViewportSwizzleNegativeWNv = 37719,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_X_NV = 0x9358
        ViewportSwizzleXNv = 37720,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_Y_NV = 0x9359
        ViewportSwizzleYNv = 37721,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_Z_NV = 0x935A
        ViewportSwizzleZNv = 37722,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_SWIZZLE_W_NV = 0x935B
        ViewportSwizzleWNv = 37723,
        //
        // Resumo:
        //     Original was GL_CLIP_ORIGIN = 0x935C
        ClipOrigin = 37724,
        //
        // Resumo:
        //     Original was GL_CLIP_DEPTH_MODE = 0x935D
        ClipDepthMode = 37725,
        //
        // Resumo:
        //     Original was GL_NEGATIVE_ONE_TO_ONE = 0x935E
        NegativeOneToOne = 37726,
        //
        // Resumo:
        //     Original was GL_ZERO_TO_ONE = 0x935F
        ZeroToOne = 37727,
        //
        // Resumo:
        //     Original was GL_CLEAR_TEXTURE = 0x9365
        ClearTexture = 37733,
        //
        // Resumo:
        //     Original was GL_TEXTURE_REDUCTION_MODE_ARB = 0x9366
        TextureReductionModeArb = 37734,
        //
        // Resumo:
        //     Original was GL_WEIGHTED_AVERAGE_ARB = 0x9367
        WeightedAverageArb = 37735,
        //
        // Resumo:
        //     Original was GL_FONT_GLYPHS_AVAILABLE_NV = 0x9368
        FontGlyphsAvailableNv = 37736,
        //
        // Resumo:
        //     Original was GL_FONT_TARGET_UNAVAILABLE_NV = 0x9369
        FontTargetUnavailableNv = 37737,
        //
        // Resumo:
        //     Original was GL_FONT_UNAVAILABLE_NV = 0x936A
        FontUnavailableNv = 37738,
        //
        // Resumo:
        //     Original was GL_FONT_UNINTELLIGIBLE_NV = 0x936B
        FontUnintelligibleNv = 37739,
        //
        // Resumo:
        //     Original was GL_STANDARD_FONT_FORMAT_NV = 0x936C
        StandardFontFormatNv = 37740,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_INPUT_NV = 0x936D
        FragmentInputNv = 37741,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_UNIFIED_NV = 0x936E
        UniformBufferUnifiedNv = 37742,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_ADDRESS_NV = 0x936F
        UniformBufferAddressNv = 37743,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_LENGTH_NV = 0x9370
        UniformBufferLengthNv = 37744,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLES_NV = 0x9371
        MultisamplesNv = 37745,
        //
        // Resumo:
        //     Original was GL_SUPERSAMPLE_SCALE_X_NV = 0x9372
        SupersampleScaleXNv = 37746,
        //
        // Resumo:
        //     Original was GL_SUPERSAMPLE_SCALE_Y_NV = 0x9373
        SupersampleScaleYNv = 37747,
        //
        // Resumo:
        //     Original was GL_CONFORMANT_NV = 0x9374
        ConformantNv = 37748,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTER_DILATE_NV = 0x9379
        ConservativeRasterDilateNv = 37753,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A
        ConservativeRasterDilateRangeNv = 37754,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B
        ConservativeRasterDilateGranularityNv = 37755,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_POSITION_W_SCALE_NV = 0x937C
        ViewportPositionWScaleNv = 37756,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV = 0x937D
        ViewportPositionWScaleXCoeffNv = 37757,
        //
        // Resumo:
        //     Original was GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV = 0x937E
        ViewportPositionWScaleYCoeffNv = 37758,
        //
        // Resumo:
        //     Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        NumSampleCounts = 37760,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381
        MultisampleLineWidthRangeArb = 37761,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382
        MultisampleLineWidthGranularityArb = 37762,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0
        CompressedRgbaAstc4X4Khr = 37808,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1
        CompressedRgbaAstc5X4Khr = 37809,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2
        CompressedRgbaAstc5X5Khr = 37810,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3
        CompressedRgbaAstc6X5Khr = 37811,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4
        CompressedRgbaAstc6X6Khr = 37812,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5
        CompressedRgbaAstc8X5Khr = 37813,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6
        CompressedRgbaAstc8X6Khr = 37814,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7
        CompressedRgbaAstc8X8Khr = 37815,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8
        CompressedRgbaAstc10X5Khr = 37816,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9
        CompressedRgbaAstc10X6Khr = 37817,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA
        CompressedRgbaAstc10X8Khr = 37818,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB
        CompressedRgbaAstc10X10Khr = 37819,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC
        CompressedRgbaAstc12X10Khr = 37820,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD
        CompressedRgbaAstc12X12Khr = 37821,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0
        CompressedSrgb8Alpha8Astc4X4Khr = 37840,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1
        CompressedSrgb8Alpha8Astc5X4Khr = 37841,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2
        CompressedSrgb8Alpha8Astc5X5Khr = 37842,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3
        CompressedSrgb8Alpha8Astc6X5Khr = 37843,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4
        CompressedSrgb8Alpha8Astc6X6Khr = 37844,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5
        CompressedSrgb8Alpha8Astc8X5Khr = 37845,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6
        CompressedSrgb8Alpha8Astc8X6Khr = 37846,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7
        CompressedSrgb8Alpha8Astc8X8Khr = 37847,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8
        CompressedSrgb8Alpha8Astc10X5Khr = 37848,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9
        CompressedSrgb8Alpha8Astc10X6Khr = 37849,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA
        CompressedSrgb8Alpha8Astc10X8Khr = 37850,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB
        CompressedSrgb8Alpha8Astc10X10Khr = 37851,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC
        CompressedSrgb8Alpha8Astc12X10Khr = 37852,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD
        CompressedSrgb8Alpha8Astc12X12Khr = 37853,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0
        PerfqueryCounterEventIntel = 38128,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1
        PerfqueryCounterDurationNormIntel = 38129,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2
        PerfqueryCounterDurationRawIntel = 38130,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3
        PerfqueryCounterThroughputIntel = 38131,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_RAW_INTEL = 0x94F4
        PerfqueryCounterRawIntel = 38132,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5
        PerfqueryCounterTimestampIntel = 38133,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8
        PerfqueryCounterDataUint32Intel = 38136,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9
        PerfqueryCounterDataUint64Intel = 38137,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA
        PerfqueryCounterDataFloatIntel = 38138,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB
        PerfqueryCounterDataDoubleIntel = 38139,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC
        PerfqueryCounterDataBool32Intel = 38140,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD
        PerfqueryQueryNameLengthMaxIntel = 38141,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE
        PerfqueryCounterNameLengthMaxIntel = 38142,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF
        PerfqueryCounterDescLengthMaxIntel = 38143,
        //
        // Resumo:
        //     Original was GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500
        PerfqueryGpaExtendedCountersIntel = 38144,
        //
        // Resumo:
        //     Original was GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530
        LayoutDepthReadOnlyStencilAttachmentExt = 38192,
        //
        // Resumo:
        //     Original was GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531
        LayoutDepthAttachmentStencilReadOnlyExt = 38193,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTER_MODE_NV = 0x954D
        ConservativeRasterModeNv = 38221,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV = 0x954E
        ConservativeRasterModePostSnapNv = 38222,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV = 0x954F
        ConservativeRasterModePreSnapTrianglesNv = 38223,
        //
        // Resumo:
        //     Original was GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV = 0x9550
        ConservativeRasterModePreSnapNv = 38224,
        //
        // Resumo:
        //     Original was GL_SHADER_BINARY_FORMAT_SPIR_V = 0x9551
        ShaderBinaryFormatSpirV = 38225,
        //
        // Resumo:
        //     Original was GL_SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551
        ShaderBinaryFormatSpirVArb = 38225,
        //
        // Resumo:
        //     Original was GL_SPIR_V_BINARY = 0x9552
        SpirVBinary = 38226,
        //
        // Resumo:
        //     Original was GL_SPIR_V_BINARY_ARB = 0x9552
        SpirVBinaryArb = 38226,
        //
        // Resumo:
        //     Original was GL_SPIR_V_EXTENSIONS = 0x9553
        SpirVExtensions = 38227,
        //
        // Resumo:
        //     Original was GL_NUM_SPIR_V_EXTENSIONS = 0x9554
        NumSpirVExtensions = 38228,
        //
        // Resumo:
        //     Original was GL_TEXTURE_TILING_EXT = 0x9580
        TextureTilingExt = 38272,
        //
        // Resumo:
        //     Original was GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581
        DedicatedMemoryObjectExt = 38273,
        //
        // Resumo:
        //     Original was GL_HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586
        HandleTypeOpaqueFdExt = 38278,
        //
        // Resumo:
        //     Original was GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587
        HandleTypeOpaqueWin32Ext = 38279,
        //
        // Resumo:
        //     Original was GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588
        HandleTypeOpaqueWin32KmtExt = 38280,
        //
        // Resumo:
        //     Original was GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589
        HandleTypeD3D12TilepoolExt = 38281,
        //
        // Resumo:
        //     Original was GL_HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A
        HandleTypeD3D12ResourceExt = 38282,
        //
        // Resumo:
        //     Original was GL_HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B
        HandleTypeD3D11ImageExt = 38283,
        //
        // Resumo:
        //     Original was GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C
        HandleTypeD3D11ImageKmtExt = 38284,
        //
        // Resumo:
        //     Original was GL_LAYOUT_GENERAL_EXT = 0x958D
        LayoutGeneralExt = 38285,
        //
        // Resumo:
        //     Original was GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E
        LayoutColorAttachmentExt = 38286,
        //
        // Resumo:
        //     Original was GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F
        LayoutDepthStencilAttachmentExt = 38287,
        //
        // Resumo:
        //     Original was GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590
        LayoutDepthStencilReadOnlyExt = 38288,
        //
        // Resumo:
        //     Original was GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591
        LayoutShaderReadOnlyExt = 38289,
        //
        // Resumo:
        //     Original was GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592
        LayoutTransferSrcExt = 38290,
        //
        // Resumo:
        //     Original was GL_LAYOUT_TRANSFER_DST_EXT = 0x9593
        LayoutTransferDstExt = 38291,
        //
        // Resumo:
        //     Original was GL_HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594
        HandleTypeD3D12FenceExt = 38292,
        //
        // Resumo:
        //     Original was GL_D3D12_FENCE_VALUE_EXT = 0x9595
        D3D12FenceValueExt = 38293,
        //
        // Resumo:
        //     Original was GL_DEVICE_UUID_EXT = 0x9597
        DeviceUuidExt = 38295,
        //
        // Resumo:
        //     Original was GL_DRIVER_UUID_EXT = 0x9598
        DriverUuidExt = 38296,
        //
        // Resumo:
        //     Original was GL_DEVICE_LUID_EXT = 0x9599
        DeviceLuidExt = 38297,
        //
        // Resumo:
        //     Original was GL_DEVICE_NODE_MASK_EXT = 0x959A
        DeviceNodeMaskExt = 38298,
        //
        // Resumo:
        //     Original was GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B
        ProtectedMemoryObjectExt = 38299,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630
        FramebufferAttachmentTextureNumViewsOvr = 38448,
        //
        // Resumo:
        //     Original was GL_MAX_VIEWS_OVR = 0x9631
        MaxViewsOvr = 38449,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632
        FramebufferAttachmentTextureBaseViewIndexOvr = 38450,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR = 0x9633
        FramebufferIncompleteViewTargetsOvr = 38451,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2
        FramebufferFetchNoncoherentQcom = 38562,
        //
        // Resumo:
        //     Original was GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000
        FontXMinBoundsBitNv = 65536,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT0_QCOM = 0x00010000
        StencilBufferBit0Qcom = 65536,
        //
        // Resumo:
        //     Original was GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8
        PreferDoublebufferHintPgi = 107000,
        //
        // Resumo:
        //     Original was GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD
        ConserveMemoryHintPgi = 107005,
        //
        // Resumo:
        //     Original was GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE
        ReclaimMemoryHintPgi = 107006,
        //
        // Resumo:
        //     Original was GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203
        NativeGraphicsBeginHintPgi = 107011,
        //
        // Resumo:
        //     Original was GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204
        NativeGraphicsEndHintPgi = 107012,
        //
        // Resumo:
        //     Original was GL_ALWAYS_FAST_HINT_PGI = 0x1A20C
        AlwaysFastHintPgi = 107020,
        //
        // Resumo:
        //     Original was GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D
        AlwaysSoftHintPgi = 107021,
        //
        // Resumo:
        //     Original was GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E
        AllowDrawObjHintPgi = 107022,
        //
        // Resumo:
        //     Original was GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F
        AllowDrawWinHintPgi = 107023,
        //
        // Resumo:
        //     Original was GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210
        AllowDrawFrgHintPgi = 107024,
        //
        // Resumo:
        //     Original was GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211
        AllowDrawMemHintPgi = 107025,
        //
        // Resumo:
        //     Original was GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216
        StrictDepthfuncHintPgi = 107030,
        //
        // Resumo:
        //     Original was GL_STRICT_LIGHTING_HINT_PGI = 0x1A217
        StrictLightingHintPgi = 107031,
        //
        // Resumo:
        //     Original was GL_STRICT_SCISSOR_HINT_PGI = 0x1A218
        StrictScissorHintPgi = 107032,
        //
        // Resumo:
        //     Original was GL_FULL_STIPPLE_HINT_PGI = 0x1A219
        FullStippleHintPgi = 107033,
        //
        // Resumo:
        //     Original was GL_CLIP_NEAR_HINT_PGI = 0x1A220
        ClipNearHintPgi = 107040,
        //
        // Resumo:
        //     Original was GL_CLIP_FAR_HINT_PGI = 0x1A221
        ClipFarHintPgi = 107041,
        //
        // Resumo:
        //     Original was GL_WIDE_LINE_HINT_PGI = 0x1A222
        WideLineHintPgi = 107042,
        //
        // Resumo:
        //     Original was GL_BACK_NORMALS_HINT_PGI = 0x1A223
        BackNormalsHintPgi = 107043,
        //
        // Resumo:
        //     Original was GL_VERTEX_DATA_HINT_PGI = 0x1A22A
        VertexDataHintPgi = 107050,
        //
        // Resumo:
        //     Original was GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
        VertexConsistentHintPgi = 107051,
        //
        // Resumo:
        //     Original was GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
        MaterialSideHintPgi = 107052,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_HINT_PGI = 0x1A22D
        MaxVertexHintPgi = 107053,
        //
        // Resumo:
        //     Original was GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000
        FontYMinBoundsBitNv = 131072,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000
        StencilBufferBit1Qcom = 131072,
        //
        // Resumo:
        //     Original was GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000
        FontXMaxBoundsBitNv = 262144,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT2_QCOM = 0x00040000
        StencilBufferBit2Qcom = 262144,
        //
        // Resumo:
        //     Original was GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000
        FontYMaxBoundsBitNv = 524288,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT3_QCOM = 0x00080000
        StencilBufferBit3Qcom = 524288,
        //
        // Resumo:
        //     Original was GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000
        FontUnitsPerEmBitNv = 1048576,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT4_QCOM = 0x00100000
        StencilBufferBit4Qcom = 1048576,
        //
        // Resumo:
        //     Original was GL_FONT_ASCENDER_BIT_NV = 0x00200000
        FontAscenderBitNv = 2097152,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT5_QCOM = 0x00200000
        StencilBufferBit5Qcom = 2097152,
        //
        // Resumo:
        //     Original was GL_FONT_DESCENDER_BIT_NV = 0x00400000
        FontDescenderBitNv = 4194304,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT6_QCOM = 0x00400000
        StencilBufferBit6Qcom = 4194304,
        //
        // Resumo:
        //     Original was GL_FONT_HEIGHT_BIT_NV = 0x00800000
        FontHeightBitNv = 8388608,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT7_QCOM = 0x00800000
        StencilBufferBit7Qcom = 8388608,
        //
        // Resumo:
        //     Original was GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000
        FontMaxAdvanceWidthBitNv = 16777216,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000
        MultisampleBufferBit0Qcom = 16777216,
        //
        // Resumo:
        //     Original was GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000
        FontMaxAdvanceHeightBitNv = 33554432,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000
        MultisampleBufferBit1Qcom = 33554432,
        //
        // Resumo:
        //     Original was GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000
        FontUnderlinePositionBitNv = 67108864,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000
        MultisampleBufferBit2Qcom = 67108864,
        //
        // Resumo:
        //     Original was GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000
        FontUnderlineThicknessBitNv = 134217728,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000
        MultisampleBufferBit3Qcom = 134217728,
        //
        // Resumo:
        //     Original was GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
        FontHasKerningBitNv = 268435456,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000
        MultisampleBufferBit4Qcom = 268435456,
        //
        // Resumo:
        //     Original was GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000
        FontNumGlyphIndicesBitNv = 536870912,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BIT = 0x20000000
        MultisampleBit = 536870912,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BIT_3DFX = 0x20000000
        MultisampleBit3Dfx = 536870912,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BIT_ARB = 0x20000000
        MultisampleBitArb = 536870912,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BIT_EXT = 0x20000000
        MultisampleBitExt = 536870912,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000
        MultisampleBufferBit5Qcom = 536870912,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000
        MultisampleBufferBit6Qcom = 1073741824
    }
}