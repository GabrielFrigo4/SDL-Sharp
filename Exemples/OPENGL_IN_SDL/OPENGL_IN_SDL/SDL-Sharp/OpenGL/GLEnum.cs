using System;

namespace SDL_Sharp.OpenGL
{
    #region GLenum
    [Flags]
    public enum ClearBufferMask
    {
        //
        // Resumo:
        //     Original was GL_NONE = 0
        None = 0,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        DepthBufferBit = 256,
        //
        // Resumo:
        //     Original was GL_ACCUM_BUFFER_BIT = 0x00000200
        AccumBufferBit = 512,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        StencilBufferBit = 1024,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT = 0x00004000
        ColorBufferBit = 16384,
        //
        // Resumo:
        //     Original was GL_COVERAGE_BUFFER_BIT_NV = 0x00008000
        CoverageBufferBitNv = 32768
    }

    public enum GetProgramParameterName
    {
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
        //     Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        GeometryShaderInvocations = 34943,
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
        //     Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        ActiveUniformBlockMaxNameLength = 35381,
        //
        // Resumo:
        //     Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        ActiveUniformBlocks = 35382,
        //
        // Resumo:
        //     Original was GL_DELETE_STATUS = 0x8B80
        DeleteStatus = 35712,
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
        //     Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        ActiveAttributes = 35721,
        //
        // Resumo:
        //     Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        ActiveAttributeMaxLength = 35722,
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
        //     Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        TransformFeedbackVaryings = 35971,
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
        //     Original was GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF
        MaxComputeWorkGroupSize = 37311,
        //
        // Resumo:
        //     Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        ActiveAtomicCounterBuffers = 37593
    }

    public enum ActiveAttribType
    {
        //
        // Resumo:
        //     Original was GL_NONE = 0
        None = 0,
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
        //     Original was GL_DOUBLE = 0x140A
        Double = 5130,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC2 = 0x8B50
        FloatVec2 = 35664,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC3 = 0x8B51
        FloatVec3 = 35665,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC4 = 0x8B52
        FloatVec4 = 35666,
        //
        // Resumo:
        //     Original was GL_INT_VEC2 = 0x8B53
        IntVec2 = 35667,
        //
        // Resumo:
        //     Original was GL_INT_VEC3 = 0x8B54
        IntVec3 = 35668,
        //
        // Resumo:
        //     Original was GL_INT_VEC4 = 0x8B55
        IntVec4 = 35669,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2 = 0x8B5A
        FloatMat2 = 35674,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3 = 0x8B5B
        FloatMat3 = 35675,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4 = 0x8B5C
        FloatMat4 = 35676,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2x3 = 0x8B65
        FloatMat2x3 = 35685,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2x4 = 0x8B66
        FloatMat2x4 = 35686,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3x2 = 0x8B67
        FloatMat3x2 = 35687,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3x4 = 0x8B68
        FloatMat3x4 = 35688,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4x2 = 0x8B69
        FloatMat4x2 = 35689,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4x3 = 0x8B6A
        FloatMat4x3 = 35690,
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
        //     Original was GL_DOUBLE_VEC2 = 0x8FFC
        DoubleVec2 = 36860,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC3 = 0x8FFD
        DoubleVec3 = 36861,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC4 = 0x8FFE
        DoubleVec4 = 36862
    }

    public enum ActiveUniformType
    {
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
        //     Original was GL_DOUBLE = 0x140A
        Double = 5130,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC2 = 0x8B50
        FloatVec2 = 35664,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC3 = 0x8B51
        FloatVec3 = 35665,
        //
        // Resumo:
        //     Original was GL_FLOAT_VEC4 = 0x8B52
        FloatVec4 = 35666,
        //
        // Resumo:
        //     Original was GL_INT_VEC2 = 0x8B53
        IntVec2 = 35667,
        //
        // Resumo:
        //     Original was GL_INT_VEC3 = 0x8B54
        IntVec3 = 35668,
        //
        // Resumo:
        //     Original was GL_INT_VEC4 = 0x8B55
        IntVec4 = 35669,
        //
        // Resumo:
        //     Original was GL_BOOL = 0x8B56
        Bool = 35670,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC2 = 0x8B57
        BoolVec2 = 35671,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC3 = 0x8B58
        BoolVec3 = 35672,
        //
        // Resumo:
        //     Original was GL_BOOL_VEC4 = 0x8B59
        BoolVec4 = 35673,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2 = 0x8B5A
        FloatMat2 = 35674,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3 = 0x8B5B
        FloatMat3 = 35675,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4 = 0x8B5C
        FloatMat4 = 35676,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D = 0x8B5D
        Sampler1D = 35677,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D = 0x8B5E
        Sampler2D = 35678,
        //
        // Resumo:
        //     Original was GL_SAMPLER_3D = 0x8B5F
        Sampler3D = 35679,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE = 0x8B60
        SamplerCube = 35680,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        Sampler1DShadow = 35681,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        Sampler2DShadow = 35682,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_RECT = 0x8B63
        Sampler2DRect = 35683,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
        Sampler2DRectShadow = 35684,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2x3 = 0x8B65
        FloatMat2x3 = 35685,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT2x4 = 0x8B66
        FloatMat2x4 = 35686,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3x2 = 0x8B67
        FloatMat3x2 = 35687,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT3x4 = 0x8B68
        FloatMat3x4 = 35688,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4x2 = 0x8B69
        FloatMat4x2 = 35689,
        //
        // Resumo:
        //     Original was GL_FLOAT_MAT4x3 = 0x8B6A
        FloatMat4x3 = 35690,
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
        //     Original was GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C
        SamplerCubeMapArray = 36876,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D
        SamplerCubeMapArrayShadow = 36877,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E
        IntSamplerCubeMapArray = 36878,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F
        UnsignedIntSamplerCubeMapArray = 36879,
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
        //     Original was GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
        UnsignedIntAtomicCounter = 37595
    }

    public enum ShaderParameter
    {
        //
        // Resumo:
        //     Original was GL_SHADER_TYPE = 0x8B4F
        ShaderType = 35663,
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
        //     Original was GL_INFO_LOG_LENGTH = 0x8B84
        InfoLogLength = 35716,
        //
        // Resumo:
        //     Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        ShaderSourceLength = 35720
    }

    public enum VertexAttribPointerType
    {
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
        //     Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        UnsignedInt2101010Rev = 33640,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        UnsignedInt10F11F11FRev = 35899,
        //
        // Resumo:
        //     Original was GL_INT_2_10_10_10_REV = 0x8D9F
        Int2101010Rev = 36255
    }

    public enum BeginMode
    {
        //
        // Resumo:
        //     Original was GL_POINTS = 0x0000
        Points = 0,
        //
        // Resumo:
        //     Original was GL_LINES = 0x0001
        Lines = 1,
        //
        // Resumo:
        //     Original was GL_LINE_LOOP = 0x0002
        LineLoop = 2,
        //
        // Resumo:
        //     Original was GL_LINE_STRIP = 0x0003
        LineStrip = 3,
        //
        // Resumo:
        //     Original was GL_TRIANGLES = 0x0004
        Triangles = 4,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_STRIP = 0x0005
        TriangleStrip = 5,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_FAN = 0x0006
        TriangleFan = 6,
        //
        // Resumo:
        //     Original was GL_QUADS = 0x0007
        Quads = 7,
        //
        // Resumo:
        //     Original was GL_QUAD_STRIP = 0x0008
        QuadStrip = 8,
        //
        // Resumo:
        //     Original was GL_POLYGON = 0x0009
        Polygon = 9,
        //
        // Resumo:
        //     Original was GL_LINES_ADJACENCY = 0xA
        LinesAdjacency = 10,
        //
        // Resumo:
        //     Original was GL_LINE_STRIP_ADJACENCY = 0xB
        LineStripAdjacency = 11,
        //
        // Resumo:
        //     Original was GL_TRIANGLES_ADJACENCY = 0xC
        TrianglesAdjacency = 12,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_STRIP_ADJACENCY = 0xD
        TriangleStripAdjacency = 13,
        //
        // Resumo:
        //     Original was GL_PATCHES = 0x000E
        Patches = 14
    }

    public enum DrawElementsType
    {
        //
        // Resumo:
        //     Original was GL_UNSIGNED_BYTE = 0x1401
        UnsignedByte = 5121,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT = 0x1403
        UnsignedShort = 5123,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT = 0x1405
        UnsignedInt = 5125
    }

    public enum PrimitiveType
    {
        //
        // Resumo:
        //     Original was GL_POINTS = 0x0000
        Points = 0,
        //
        // Resumo:
        //     Original was GL_LINES = 0x0001
        Lines = 1,
        //
        // Resumo:
        //     Original was GL_LINE_LOOP = 0x0002
        LineLoop = 2,
        //
        // Resumo:
        //     Original was GL_LINE_STRIP = 0x0003
        LineStrip = 3,
        //
        // Resumo:
        //     Original was GL_TRIANGLES = 0x0004
        Triangles = 4,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_STRIP = 0x0005
        TriangleStrip = 5,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_FAN = 0x0006
        TriangleFan = 6,
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
        //     Original was GL_PATCHES = 0x000E
        Patches = 14,
        //
        // Resumo:
        //     Original was GL_PATCHES_EXT = 0x000E
        PatchesExt = 14
    }

    public enum GetPName
    {
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
        //     Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        Modelview0MatrixExt = 2982,
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
        //     Original was GL_LINE_SMOOTH_HINT = 0x0C52
        LineSmoothHint = 3154,
        //
        // Resumo:
        //     Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        PolygonSmoothHint = 3155,
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
        //     Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        UnpackSkipRows = 3315,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        UnpackSkipPixels = 3316,
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
        //     Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        MaxClipDistances = 3378,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        MaxTextureSize = 3379,
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
        //     Original was GL_CLIP_PLANE0 = 0x3000
        ClipPlane0 = 12288,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE1 = 0x3001
        ClipPlane1 = 12289,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE2 = 0x3002
        ClipPlane2 = 12290,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE3 = 0x3003
        ClipPlane3 = 12291,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE4 = 0x3004
        ClipPlane4 = 12292,
        //
        // Resumo:
        //     Original was GL_CLIP_PLANE5 = 0x3005
        ClipPlane5 = 12293,
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
        //     Original was GL_BLEND_COLOR_EXT = 0x8005
        BlendColorExt = 32773,
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
        //     Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        PackCmykHintExt = 32782,
        //
        // Resumo:
        //     Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        UnpackCmykHintExt = 32783,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_1D_EXT = 0x8010
        Convolution1DExt = 32784,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_2D_EXT = 0x8011
        Convolution2DExt = 32785,
        //
        // Resumo:
        //     Original was GL_SEPARABLE_2D_EXT = 0x8012
        Separable2DExt = 32786,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        PostConvolutionRedScaleExt = 32796,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        PostConvolutionGreenScaleExt = 32797,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        PostConvolutionBlueScaleExt = 32798,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        PostConvolutionAlphaScaleExt = 32799,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        PostConvolutionRedBiasExt = 32800,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        PostConvolutionGreenBiasExt = 32801,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        PostConvolutionBlueBiasExt = 32802,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        PostConvolutionAlphaBiasExt = 32803,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_EXT = 0x8024
        HistogramExt = 32804,
        //
        // Resumo:
        //     Original was GL_MINMAX_EXT = 0x802E
        MinmaxExt = 32814,
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
        //     Original was GL_RESCALE_NORMAL_EXT = 0x803A
        RescaleNormalExt = 32826,
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
        //     Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        PackSkipImagesExt = 32875,
        //
        // Resumo:
        //     Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        PackImageHeightExt = 32876,
        //
        // Resumo:
        //     Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        UnpackSkipImagesExt = 32877,
        //
        // Resumo:
        //     Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        UnpackImageHeightExt = 32878,
        //
        // Resumo:
        //     Original was GL_TEXTURE_3D_EXT = 0x806F
        Texture3DExt = 32879,
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
        //     Original was GL_INTERLACE_SGIX = 0x8094
        InterlaceSgix = 32916,
        //
        // Resumo:
        //     Original was GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096
        DetailTexture2DBindingSgis = 32918,
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
        //     Original was GL_COLOR_MATRIX_SGI = 0x80B1
        ColorMatrixSgi = 32945,
        //
        // Resumo:
        //     Original was GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
        ColorMatrixStackDepthSgi = 32946,
        //
        // Resumo:
        //     Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
        MaxColorMatrixStackDepthSgi = 32947,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        PostColorMatrixRedScaleSgi = 32948,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        PostColorMatrixGreenScaleSgi = 32949,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        PostColorMatrixBlueScaleSgi = 32950,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        PostColorMatrixAlphaScaleSgi = 32951,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        PostColorMatrixRedBiasSgi = 32952,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        PostColorMatrixGreenBiasSgi = 32953,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        PostColorMatrixBlueBiasSgi = 32954,
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
        //     Original was GL_COLOR_TABLE_SGI = 0x80D0
        ColorTableSgi = 32976,
        //
        // Resumo:
        //     Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        PostConvolutionColorTableSgi = 32977,
        //
        // Resumo:
        //     Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        PostColorMatrixColorTableSgi = 32978,
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
        //     Original was GL_POINT_SIZE_MIN = 0x8126
        PointSizeMin = 33062,
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
        //     Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        PointSizeMaxSgis = 33063,
        //
        // Resumo:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        PointFadeThresholdSize = 33064,
        //
        // Resumo:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        PointFadeThresholdSizeSgis = 33064,
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
        //     Original was GL_FOG_FUNC_POINTS_SGIS = 0x812B
        FogFuncPointsSgis = 33067,
        //
        // Resumo:
        //     Original was GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
        MaxFogFuncPointsSgis = 33068,
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
        //     Original was GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138
        Max4DTextureSizeSgis = 33080,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        PixelTexGenSgix = 33081,
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
        //     Original was GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
        MaxClipmapDepthSgix = 33143,
        //
        // Resumo:
        //     Original was GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
        MaxClipmapVirtualDepthSgix = 33144,
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
        //     Original was GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
        InstrumentMeasurementsSgix = 33153,
        //
        // Resumo:
        //     Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        CalligraphicFragmentSgix = 33155,
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
        //     Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        GenerateMipmapHint = 33170,
        //
        // Resumo:
        //     Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        GenerateMipmapHintSgis = 33170,
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
        //     Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        LightModelColorControl = 33272,
        //
        // Resumo:
        //     Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        SharedTexturePaletteExt = 33275,
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
        //     Original was GL_RESET_NOTIFICATION_STRATEGY = 0x8256
        ResetNotificationStrategy = 33366,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PIPELINE_BINDING = 0x825A
        ProgramPipelineBinding = 33370,
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
        //     Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        ConvolutionHintSgix = 33558,
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
        //     Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        VertexPreclipSgix = 33774,
        //
        // Resumo:
        //     Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        VertexPreclipHintSgix = 33775,
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
        //     Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        PackResampleSgix = 33838,
        //
        // Resumo:
        //     Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        UnpackResampleSgix = 33839,
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
        //     Original was GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F
        CurrentRasterSecondaryColor = 33887,
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
        //     Original was GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3
        TransposeModelviewMatrix = 34019,
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
        //     Original was GL_MAX_RENDERBUFFER_SIZE = 0x84E8
        MaxRenderbufferSize = 34024,
        //
        // Resumo:
        //     Original was GL_MAX_RENDERBUFFER_SIZE_EXT = 0x84E8
        MaxRenderbufferSizeExt = 34024,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        TextureCompressionHint = 34031,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_RECTANGLE = 0x84F6
        TextureBindingRectangle = 34038,
        //
        // Resumo:
        //     Original was GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8
        MaxRectangleTextureSize = 34040,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_LOD_BIAS = 0x84FD
        MaxTextureLodBias = 34045,
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
        //     Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C
        MaxCubeMapTextureSize = 34076,
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
        //     Original was GL_VERTEX_ARRAY_BINDING = 0x85B5
        VertexArrayBinding = 34229,
        //
        // Resumo:
        //     Original was GL_PROGRAM_POINT_SIZE = 0x8642
        ProgramPointSize = 34370,
        //
        // Resumo:
        //     Original was GL_DEPTH_CLAMP = 0x864F
        DepthClamp = 34383,
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
        //     Original was GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F
        TextureCubeMapSeamless = 34895,
        //
        // Resumo:
        //     Original was GL_POINT_SPRITE = 0x8861
        PointSprite = 34913,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATTRIBS = 0x8869
        MaxVertexAttribs = 34921,
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
        //     Original was GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED
        PixelPackBufferBinding = 35053,
        //
        // Resumo:
        //     Original was GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF
        PixelUnpackBufferBinding = 35055,
        //
        // Resumo:
        //     Original was GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC
        MaxDualSourceDrawBuffers = 35068,
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
        //     Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        FragmentShaderDerivativeHint = 35723,
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
        //     Original was GL_TEXTURE_BUFFER = 0x8C2A
        TextureBuffer = 35882,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B
        MaxTextureBufferSize = 35883,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_BUFFER = 0x8C2C
        TextureBindingBuffer = 35884,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D
        TextureBufferDataStoreBinding = 35885,
        //
        // Resumo:
        //     Original was GL_SAMPLE_SHADING = 0x8C36
        SampleShading = 35894,
        //
        // Resumo:
        //     Original was GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37
        MinSampleShadingValue = 35895,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80
        MaxTransformFeedbackSeparateComponents = 35968,
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
        //     Original was GL_READ_FRAMEBUFFER_BINDING = 0x8CAA
        ReadFramebufferBinding = 36010,
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
        //     Original was GL_MAX_SAMPLES = 0x8D57
        MaxSamples = 36183,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_SRGB = 0x8DB9
        FramebufferSrgb = 36281,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_VARYING_COMPONENTS = 0x8DDD
        MaxGeometryVaryingComponents = 36317,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_VARYING_COMPONENTS = 0x8DDE
        MaxVertexVaryingComponents = 36318,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF
        MaxGeometryUniformComponents = 36319,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0
        MaxGeometryOutputVertices = 36320,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1
        MaxGeometryTotalOutputComponents = 36321,
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
        //     Original was GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E
        MaxCombinedTessControlUniformComponents = 36382,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F
        MaxCombinedTessEvaluationUniformComponents = 36383,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23
        TransformFeedbackBufferPaused = 36387,
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
        //     Original was GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C
        QuadsFollowProvokingVertexConvention = 36428,
        //
        // Resumo:
        //     Original was GL_PROVOKING_VERTEX = 0x8E4F
        ProvokingVertex = 36431,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK = 0x8E51
        SampleMask = 36433,
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
        //     Original was GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F
        MaxProgramTextureGatherOffset = 36447,
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
        //     Original was GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89
        MaxTessControlUniformBlocks = 36489,
        //
        // Resumo:
        //     Original was GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A
        MaxTessEvaluationUniformBlocks = 36490,
        //
        // Resumo:
        //     Original was GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43
        DrawIndirectBufferBinding = 36675,
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
        //     Original was GL_CONTEXT_ROBUST_ACCESS = 0x90F3
        ContextRobustAccess = 37107,
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
        //     Original was GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD
        MaxComputeImageUniforms = 37309,
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
        DeviceNodeMaskExt = 38298
    }

    public enum BufferTarget
    {
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
        //     Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        PixelPackBuffer = 35051,
        //
        // Resumo:
        //     Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        PixelUnpackBuffer = 35052,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER = 0x8A11
        UniformBuffer = 35345,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER = 0x8C2A
        TextureBuffer = 35882,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        TransformFeedbackBuffer = 35982,
        //
        // Resumo:
        //     Original was GL_COPY_READ_BUFFER = 0x8F36
        CopyReadBuffer = 36662,
        //
        // Resumo:
        //     Original was GL_COPY_WRITE_BUFFER = 0x8F37
        CopyWriteBuffer = 36663,
        //
        // Resumo:
        //     Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        DrawIndirectBuffer = 36671,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        ShaderStorageBuffer = 37074,
        //
        // Resumo:
        //     Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        DispatchIndirectBuffer = 37102,
        //
        // Resumo:
        //     Original was GL_QUERY_BUFFER = 0x9192
        QueryBuffer = 37266,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        AtomicCounterBuffer = 37568
    }

    public enum BufferUsageHint
    {
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
        DynamicCopy = 35050
    }

    public enum ShaderType
    {
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
        //     Original was GL_GEOMETRY_SHADER = 0x8DD9
        GeometryShader = 36313,
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
        //     Original was GL_COMPUTE_SHADER = 0x91B9
        ComputeShader = 37305
    }

    public enum TextureUnit
    {
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
        Texture31 = 34015
    }

    public enum TextureTarget
    {
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
        //     Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
        DetailTexture2DSgis = 32917,
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
        //     Original was GL_TEXTURE_RECTANGLE = 0x84F5
        TextureRectangle = 34037,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RECTANGLE_ARB = 0x84F5
        TextureRectangleArb = 34037,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RECTANGLE_NV = 0x84F5
        TextureRectangleNv = 34037,
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
        //     Original was GL_TEXTURE_BUFFER = 0x8C2A
        TextureBuffer = 35882,
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
        //     Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        ProxyTextureCubeMapArray = 36875,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        ProxyTextureCubeMapArrayArb = 36875,
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
        ProxyTexture2DMultisampleArray = 37123
    }

    public enum PixelInternalFormat
    {
        //
        // Resumo:
        //     Original was GL_ONE = 1
        One = 1,
        //
        // Resumo:
        //     Original was GL_TWO = 2
        Two = 2,
        //
        // Resumo:
        //     Original was GL_THREE = 3
        Three = 3,
        //
        // Resumo:
        //     Original was GL_FOUR = 4
        Four = 4,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT = 0x1902
        DepthComponent = 6402,
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
        //     Original was GL_R3_G3_B2 = 0x2A10
        R3G3B2 = 10768,
        //
        // Resumo:
        //     Original was GL_ALPHA4 = 0x803B
        Alpha4 = 32827,
        //
        // Resumo:
        //     Original was GL_ALPHA8 = 0x803C
        Alpha8 = 32828,
        //
        // Resumo:
        //     Original was GL_ALPHA12 = 0x803D
        Alpha12 = 32829,
        //
        // Resumo:
        //     Original was GL_ALPHA16 = 0x803E
        Alpha16 = 32830,
        //
        // Resumo:
        //     Original was GL_LUMINANCE4 = 0x803F
        Luminance4 = 32831,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8 = 0x8040
        Luminance8 = 32832,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12 = 0x8041
        Luminance12 = 32833,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16 = 0x8042
        Luminance16 = 32834,
        //
        // Resumo:
        //     Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        Luminance4Alpha4 = 32835,
        //
        // Resumo:
        //     Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        Luminance6Alpha2 = 32836,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        Luminance8Alpha8 = 32837,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        Luminance12Alpha4 = 32838,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        Luminance12Alpha12 = 32839,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        Luminance16Alpha16 = 32840,
        //
        // Resumo:
        //     Original was GL_INTENSITY = 0x8049
        Intensity = 32841,
        //
        // Resumo:
        //     Original was GL_INTENSITY4 = 0x804A
        Intensity4 = 32842,
        //
        // Resumo:
        //     Original was GL_INTENSITY8 = 0x804B
        Intensity8 = 32843,
        //
        // Resumo:
        //     Original was GL_INTENSITY12 = 0x804C
        Intensity12 = 32844,
        //
        // Resumo:
        //     Original was GL_INTENSITY16 = 0x804D
        Intensity16 = 32845,
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
        //     Original was GL_RGB5 = 0x8050
        Rgb5 = 32848,
        //
        // Resumo:
        //     Original was GL_RGB8 = 0x8051
        Rgb8 = 32849,
        //
        // Resumo:
        //     Original was GL_RGB10 = 0x8052
        Rgb10 = 32850,
        //
        // Resumo:
        //     Original was GL_RGB12 = 0x8053
        Rgb12 = 32851,
        //
        // Resumo:
        //     Original was GL_RGB16 = 0x8054
        Rgb16 = 32852,
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
        //     Original was GL_RGB5_A1 = 0x8057
        Rgb5A1 = 32855,
        //
        // Resumo:
        //     Original was GL_RGBA8 = 0x8058
        Rgba8 = 32856,
        //
        // Resumo:
        //     Original was GL_RGB10_A2 = 0x8059
        Rgb10A2 = 32857,
        //
        // Resumo:
        //     Original was GL_RGBA12 = 0x805A
        Rgba12 = 32858,
        //
        // Resumo:
        //     Original was GL_RGBA16 = 0x805B
        Rgba16 = 32859,
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
        //     Original was GL_DEPTH_COMPONENT16 = 0x81a5
        DepthComponent16 = 33189,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        DepthComponent16Sgix = 33189,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT24 = 0x81a6
        DepthComponent24 = 33190,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        DepthComponent24Sgix = 33190,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32 = 0x81a7
        DepthComponent32 = 33191,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        DepthComponent32Sgix = 33191,
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
        //     Original was GL_R8 = 0x8229
        R8 = 33321,
        //
        // Resumo:
        //     Original was GL_R16 = 0x822A
        R16 = 33322,
        //
        // Resumo:
        //     Original was GL_RG8 = 0x822B
        Rg8 = 33323,
        //
        // Resumo:
        //     Original was GL_RG16 = 0x822C
        Rg16 = 33324,
        //
        // Resumo:
        //     Original was GL_R16F = 0x822D
        R16f = 33325,
        //
        // Resumo:
        //     Original was GL_R32F = 0x822E
        R32f = 33326,
        //
        // Resumo:
        //     Original was GL_RG16F = 0x822F
        Rg16f = 33327,
        //
        // Resumo:
        //     Original was GL_RG32F = 0x8230
        Rg32f = 33328,
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
        //     Original was GL_DEPTH_STENCIL = 0x84F9
        DepthStencil = 34041,
        //
        // Resumo:
        //     Original was GL_RGBA32F = 0x8814
        Rgba32f = 34836,
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
        //     Original was GL_RGB16F = 0x881B
        Rgb16f = 34843,
        //
        // Resumo:
        //     Original was GL_DEPTH24_STENCIL8 = 0x88F0
        Depth24Stencil8 = 35056,
        //
        // Resumo:
        //     Original was GL_R11F_G11F_B10F = 0x8C3A
        R11fG11fB10f = 35898,
        //
        // Resumo:
        //     Original was GL_RGB9_E5 = 0x8C3D
        Rgb9E5 = 35901,
        //
        // Resumo:
        //     Original was GL_SRGB = 0x8C40
        Srgb = 35904,
        //
        // Resumo:
        //     Original was GL_SRGB8 = 0x8C41
        Srgb8 = 35905,
        //
        // Resumo:
        //     Original was GL_SRGB_ALPHA = 0x8C42
        SrgbAlpha = 35906,
        //
        // Resumo:
        //     Original was GL_SRGB8_ALPHA8 = 0x8C43
        Srgb8Alpha8 = 35907,
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
        //     Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        DepthComponent32f = 36012,
        //
        // Resumo:
        //     Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        Depth32fStencil8 = 36013,
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
        //     Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        Float32UnsignedInt248Rev = 36269,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        CompressedRedRgtc1 = 36283,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        CompressedSignedRedRgtc1 = 36284,
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
        //     Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        CompressedRgbaBptcUnorm = 36492,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        CompressedSrgbAlphaBptcUnorm = 36493,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        CompressedRgbBptcSignedFloat = 36494,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        CompressedRgbBptcUnsignedFloat = 36495,
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
        //     Original was GL_RG16_SNORM = 0x8F99
        Rg16Snorm = 36761,
        //
        // Resumo:
        //     Original was GL_RGB16_SNORM = 0x8F9A
        Rgb16Snorm = 36762,
        //
        // Resumo:
        //     Original was GL_RGBA16_SNORM = 0x8F9B
        Rgba16Snorm = 36763,
        //
        // Resumo:
        //     Original was GL_RGB10_A2UI = 0x906F
        Rgb10A2ui = 36975
    }

    public enum PixelFormat
    {
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT = 0x1403
        UnsignedShort = 5123,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT = 0x1405
        UnsignedInt = 5125,
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
        //     Original was GL_GREEN = 0x1904
        Green = 6404,
        //
        // Resumo:
        //     Original was GL_BLUE = 0x1905
        Blue = 6405,
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
        //     Original was GL_ABGR_EXT = 0x8000
        AbgrExt = 32768,
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
        //     Original was GL_BGR = 0x80E0
        Bgr = 32992,
        //
        // Resumo:
        //     Original was GL_BGRA = 0x80E1
        Bgra = 32993,
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
        //     Original was GL_RG = 0x8227
        Rg = 33319,
        //
        // Resumo:
        //     Original was GL_RG_INTEGER = 0x8228
        RgInteger = 33320,
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
        //     Original was GL_LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B
        Luminance16Alpha8IccSgix = 33899,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL = 0x84F9
        DepthStencil = 34041,
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
        BgraInteger = 36251
    }

    public enum TextureParameterName
    {
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
        //     Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        SharpenTextureFuncPointsSgis = 32944,
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
        //     Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        DualTextureSelectSgis = 33060,
        //
        // Resumo:
        //     Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        QuadTextureSelectSgis = 33061,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_BORDER = 0x812D
        ClampToBorder = 33069,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_EDGE = 0x812F
        ClampToEdge = 33071,
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
        //     Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        TextureFilter4SizeSgis = 33095,
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
        //     Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        PostTextureFilterBiasSgix = 33145,
        //
        // Resumo:
        //     Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        PostTextureFilterScaleSgix = 33146,
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
        //     Original was GL_TEXTURE_LOD_BIAS = 0x8501
        TextureLodBias = 34049,
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
        //     Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        DepthStencilTextureMode = 37098,
        //
        // Resumo:
        //     Original was GL_TEXTURE_TILING_EXT = 0x9580
        TextureTilingExt = 38272
    }

    public enum TextureMinFilter
    {
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
        //     Original was GL_FILTER4_SGIS = 0x8146
        Filter4Sgis = 33094,
        //
        // Resumo:
        //     Original was GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
        LinearClipmapLinearSgix = 33136,
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
        //     Original was GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
        NearestClipmapNearestSgix = 33869,
        //
        // Resumo:
        //     Original was GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
        NearestClipmapLinearSgix = 33870,
        //
        // Resumo:
        //     Original was GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
        LinearClipmapNearestSgix = 33871
    }

    public enum TextureWrapMode
    {
        //
        // Resumo:
        //     Original was GL_CLAMP = 0x2900
        Clamp = 10496,
        //
        // Resumo:
        //     Original was GL_REPEAT = 0x2901
        Repeat = 10497,
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
        //     Original was GL_CLAMP_TO_EDGE = 0x812F
        ClampToEdge = 33071,
        //
        // Resumo:
        //     Original was GL_CLAMP_TO_EDGE_SGIS = 0x812F
        ClampToEdgeSgis = 33071,
        //
        // Resumo:
        //     Original was GL_MIRRORED_REPEAT = 0x8370
        MirroredRepeat = 33648
    }

    public enum PixelType
    {
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
        //     Original was GL_HALF_FLOAT = 0x140B
        HalfFloat = 5131,
        //
        // Resumo:
        //     Original was GL_BITMAP = 0x1A00
        Bitmap = 6656,
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
        //     Original was GL_UNSIGNED_BYTE_2_3_3_REVERSED = 0x8362
        UnsignedByte233Reversed = 33634,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        UnsignedShort565 = 33635,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_5_6_5_REVERSED = 0x8364
        UnsignedShort565Reversed = 33636,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_4_4_4_4_REVERSED = 0x8365
        UnsignedShort4444Reversed = 33637,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_1_5_5_5_REVERSED = 0x8366
        UnsignedShort1555Reversed = 33638,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_8_8_8_8_REVERSED = 0x8367
        UnsignedInt8888Reversed = 33639,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_2_10_10_10_REVERSED = 0x8368
        UnsignedInt2101010Reversed = 33640,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_24_8 = 0x84FA
        UnsignedInt248 = 34042,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        UnsignedInt10F11F11FRev = 35899,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E
        UnsignedInt5999Rev = 35902,
        //
        // Resumo:
        //     Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        Float32UnsignedInt248Rev = 36269
    }

    public enum GenerateMipmapTarget
    {
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
        //     Original was GL_TEXTURE_3D = 0x806F
        Texture3D = 32879,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP = 0x8513
        TextureCubeMap = 34067,
        //
        // Resumo:
        //     Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        Texture1DArray = 35864,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        Texture2DArray = 35866,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        TextureCubeMapArray = 36873,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        Texture2DMultisample = 37120,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        Texture2DMultisampleArray = 37122
    }

    public enum PixelStoreParameter
    {
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
        //     Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        PackResampleSgix = 33838,
        //
        // Resumo:
        //     Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        UnpackResampleSgix = 33839,
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
        //     Original was GL_PACK_RESAMPLE_OML = 0x8984
        PackResampleOml = 35204,
        //
        // Resumo:
        //     Original was GL_UNPACK_RESAMPLE_OML = 0x8985
        UnpackResampleOml = 35205,
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
        PackCompressedBlockSize = 37166
    }

    public enum EnableCap
    {
        //
        // Resumo:
        //     Original was GL_POINT_SMOOTH = 0x0B10
        PointSmooth = 2832,
        //
        // Resumo:
        //     Original was GL_LINE_SMOOTH = 0x0B20
        LineSmooth = 2848,
        //
        // Resumo:
        //     Original was GL_LINE_STIPPLE = 0x0B24
        LineStipple = 2852,
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
        //     Original was GL_LIGHTING = 0x0B50
        Lighting = 2896,
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
        //     Original was GL_DEPTH_TEST = 0x0B71
        DepthTest = 2929,
        //
        // Resumo:
        //     Original was GL_STENCIL_TEST = 0x0B90
        StencilTest = 2960,
        //
        // Resumo:
        //     Original was GL_NORMALIZE = 0x0BA1
        Normalize = 2977,
        //
        // Resumo:
        //     Original was GL_ALPHA_TEST = 0x0BC0
        AlphaTest = 3008,
        //
        // Resumo:
        //     Original was GL_DITHER = 0x0BD0
        Dither = 3024,
        //
        // Resumo:
        //     Original was GL_BLEND = 0x0BE2
        Blend = 3042,
        //
        // Resumo:
        //     Original was GL_INDEX_LOGIC_OP = 0x0BF1
        IndexLogicOp = 3057,
        //
        // Resumo:
        //     Original was GL_COLOR_LOGIC_OP = 0x0BF2
        ColorLogicOp = 3058,
        //
        // Resumo:
        //     Original was GL_SCISSOR_TEST = 0x0C11
        ScissorTest = 3089,
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
        //     Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        PolygonOffsetPoint = 10753,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        PolygonOffsetLine = 10754,
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
        //     Original was GL_HISTOGRAM = 0x8024
        Histogram = 32804,
        //
        // Resumo:
        //     Original was GL_HISTOGRAM_EXT = 0x8024
        HistogramExt = 32804,
        //
        // Resumo:
        //     Original was GL_MINMAX_EXT = 0x802E
        MinmaxExt = 32814,
        //
        // Resumo:
        //     Original was GL_POLYGON_OFFSET_FILL = 0x8037
        PolygonOffsetFill = 32823,
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
        //     Original was GL_TEXTURE_3D_EXT = 0x806F
        Texture3DExt = 32879,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY = 0x8074
        VertexArray = 32884,
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
        //     Original was GL_INTERLACE_SGIX = 0x8094
        InterlaceSgix = 32916,
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
        //     Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        TextureColorTableSgi = 32956,
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
        //     Original was GL_TEXTURE_4D_SGIS = 0x8134
        Texture4DSgis = 33076,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        PixelTexGenSgix = 33081,
        //
        // Resumo:
        //     Original was GL_SPRITE_SGIX = 0x8148
        SpriteSgix = 33096,
        //
        // Resumo:
        //     Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        ReferencePlaneSgix = 33149,
        //
        // Resumo:
        //     Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        IrInstrument1Sgix = 33151,
        //
        // Resumo:
        //     Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        CalligraphicFragmentSgix = 33155,
        //
        // Resumo:
        //     Original was GL_FRAMEZOOM_SGIX = 0x818B
        FramezoomSgix = 33163,
        //
        // Resumo:
        //     Original was GL_FOG_OFFSET_SGIX = 0x8198
        FogOffsetSgix = 33176,
        //
        // Resumo:
        //     Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        SharedTexturePaletteExt = 33275,
        //
        // Resumo:
        //     Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        DebugOutputSynchronous = 33346,
        //
        // Resumo:
        //     Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        AsyncHistogramSgix = 33580,
        //
        // Resumo:
        //     Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        PixelTextureSgis = 33619,
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
        //     Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        FragmentLightingSgix = 33792,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        FragmentColorMaterialSgix = 33793,
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
        //     Original was GL_FOG_COORD_ARRAY = 0x8457
        FogCoordArray = 33879,
        //
        // Resumo:
        //     Original was GL_COLOR_SUM = 0x8458
        ColorSum = 33880,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY = 0x845E
        SecondaryColorArray = 33886,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RECTANGLE = 0x84F5
        TextureRectangle = 34037,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP = 0x8513
        TextureCubeMap = 34067,
        //
        // Resumo:
        //     Original was GL_PROGRAM_POINT_SIZE = 0x8642
        ProgramPointSize = 34370,
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
        //     Original was GL_DEPTH_CLAMP = 0x864F
        DepthClamp = 34383,
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
        //     Original was GL_SAMPLE_SHADING = 0x8C36
        SampleShading = 35894,
        //
        // Resumo:
        //     Original was GL_RASTERIZER_DISCARD = 0x8C89
        RasterizerDiscard = 35977,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
        PrimitiveRestartFixedIndex = 36201,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_SRGB = 0x8DB9
        FramebufferSrgb = 36281,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK = 0x8E51
        SampleMask = 36433,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_RESTART = 0x8F9D
        PrimitiveRestart = 36765,
        //
        // Resumo:
        //     Original was GL_DEBUG_OUTPUT = 0x92E0
        DebugOutput = 37600
    }

    public enum BlendingFactor
    {
        //
        // Resumo:
        //     Original was GL_ZERO = 0
        Zero = 0,
        //
        // Resumo:
        //     Original was GL_ONE = 1
        One = 1,
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
        //     Original was GL_SRC1_ALPHA = 0x8589
        Src1Alpha = 34185,
        //
        // Resumo:
        //     Original was GL_SRC1_COLOR = 0x88F9
        Src1Color = 35065
    }

    public enum DepthFunction
    {
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
        Always = 519
    }

    public enum All
    {
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000
        MultisampleBufferBit7Qcom = int.MinValue,
        //
        // Resumo:
        //     Original was GL_TEXCOORD4_BIT_PGI = 0x80000000
        Texcoord4BitPgi = int.MinValue,
        //
        // Resumo:
        //     Original was GL_SKIP_COMPONENTS1_NV = -6
        SkipComponents1Nv = -6,
        //
        // Resumo:
        //     Original was GL_SKIP_COMPONENTS2_NV = -5
        SkipComponents2Nv = -5,
        //
        // Resumo:
        //     Original was GL_SKIP_COMPONENTS3_NV = -4
        SkipComponents3Nv = -4,
        //
        // Resumo:
        //     Original was GL_SKIP_COMPONENTS4_NV = -3
        SkipComponents4Nv = -3,
        //
        // Resumo:
        //     Original was GL_NEXT_BUFFER_NV = -2
        NextBufferNv = -2,
        //
        // Resumo:
        //     Original was GL_ALL_ATTRIB_BITS = 0xFFFFFFFF
        AllAttribBits = -1,
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
        //     Original was GL_ALL_PIXELS_AMD = 0xFFFFFFFF
        AllPixelsAmd = -1,
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
        //     Original was GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF
        ClientAllAttribBits = -1,
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
        //     Original was GL_CLIENT_PIXEL_STORE_BIT = 0x00000001
        ClientPixelStoreBit = 1,
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
        //     Original was GL_CURRENT_BIT = 0x00000001
        CurrentBit = 1,
        //
        // Resumo:
        //     Original was GL_2X_BIT_ATI = 0x00000001
        Gl2XBitAti = 1,
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
        //     Original was GL_RED_BIT_ATI = 0x00000001
        RedBitAti = 1,
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
        //     Original was GL_TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001
        TextureDeformationBitSgix = 1,
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
        //     Original was GL_RESTART_SUN = 0x0001
        RestartSun = 1,
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
        //     Original was GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002
        ClientVertexArrayBit = 2,
        //
        // Resumo:
        //     Original was GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002
        ColorBufferBit1Qcom = 2,
        //
        // Resumo:
        //     Original was GL_COMP_BIT_ATI = 0x00000002
        CompBitAti = 2,
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
        //     Original was GL_GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002
        GeometryDeformationBitSgix = 2,
        //
        // Resumo:
        //     Original was GL_4X_BIT_ATI = 0x00000002
        Gl4XBitAti = 2,
        //
        // Resumo:
        //     Original was GL_GREEN_BIT_ATI = 0x00000002
        GreenBitAti = 2,
        //
        // Resumo:
        //     Original was GL_POINT_BIT = 0x00000002
        PointBit = 2,
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
        //     Original was GL_REPLACE_MIDDLE_SUN = 0x0002
        ReplaceMiddleSun = 2,
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
        //     Original was GL_REPLACE_OLDEST_SUN = 0x0003
        ReplaceOldestSun = 3,
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
        //     Original was GL_BLUE_BIT_ATI = 0x00000004
        BlueBitAti = 4,
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
        //     Original was GL_8X_BIT_ATI = 0x00000004
        Gl8XBitAti = 4,
        //
        // Resumo:
        //     Original was GL_GL_UNIFORM_BARRIER_BIT = 0x00000004
        GlUniformBarrierBit = 4,
        //
        // Resumo:
        //     Original was GL_LINE_BIT = 0x00000004
        LineBit = 4,
        //
        // Resumo:
        //     Original was GL_NEGATE_BIT_ATI = 0x00000004
        NegateBitAti = 4,
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
        //     Original was GL_VERTEX23_BIT_PGI = 0x00000004
        Vertex23BitPgi = 4,
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
        //     Original was GL_BIAS_BIT_ATI = 0x00000008
        BiasBitAti = 8,
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
        //     Original was GL_HALF_BIT_ATI = 0x00000008
        HalfBitAti = 8,
        //
        // Resumo:
        //     Original was GL_POLYGON_BIT = 0x00000008
        PolygonBit = 8,
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
        //     Original was GL_VERTEX4_BIT_PGI = 0x00000008
        Vertex4BitPgi = 8,
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
        //     Original was GL_LUID_SIZE_EXT = 8
        LuidSizeExt = 8,
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
        //     Original was GL_POLYGON_STIPPLE_BIT = 0x00000010
        PolygonStippleBit = 16,
        //
        // Resumo:
        //     Original was GL_QUARTER_BIT_ATI = 0x00000010
        QuarterBitAti = 16,
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
        //     Original was GL_UUID_SIZE_EXT = 16
        UuidSizeExt = 16,
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
        //     Original was GL_EIGHTH_BIT_ATI = 0x00000020
        EighthBitAti = 32,
        //
        // Resumo:
        //     Original was GL_GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020
        GlShaderImageAccessBarrierBit = 32,
        //
        // Resumo:
        //     Original was GL_PIXEL_MODE_BIT = 0x00000020
        PixelModeBit = 32,
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
        //     Original was GL_LIGHTING_BIT = 0x00000040
        LightingBit = 64,
        //
        // Resumo:
        //     Original was GL_SATURATE_BIT_ATI = 0x00000040
        SaturateBitAti = 64,
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
        //     Original was GL_FOG_BIT = 0x00000080
        FogBit = 128,
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
        //     Original was GL_ACCUM = 0x0100
        Accum = 256,
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
        //     Original was GL_LOAD = 0x0101
        Load = 257,
        //
        // Resumo:
        //     Original was GL_RETURN = 0x0102
        Return = 258,
        //
        // Resumo:
        //     Original was GL_MULT = 0x0103
        Mult = 259,
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
        //     Original was GL_2D = 0x0600
        Gl2D = 1536,
        //
        // Resumo:
        //     Original was GL_3D = 0x0601
        Gl3D = 1537,
        //
        // Resumo:
        //     Original was GL_3D_COLOR = 0x0602
        Gl3DColor = 1538,
        //
        // Resumo:
        //     Original was GL_3D_COLOR_TEXTURE = 0x0603
        Gl3DColorTexture = 1539,
        //
        // Resumo:
        //     Original was GL_4D_COLOR_TEXTURE = 0x0604
        Gl4DColorTexture = 1540,
        //
        // Resumo:
        //     Original was GL_PASS_THROUGH_TOKEN = 0x0700
        PassThroughToken = 1792,
        //
        // Resumo:
        //     Original was GL_POINT_TOKEN = 0x0701
        PointToken = 1793,
        //
        // Resumo:
        //     Original was GL_LINE_TOKEN = 0x0702
        LineToken = 1794,
        //
        // Resumo:
        //     Original was GL_POLYGON_TOKEN = 0x0703
        PolygonToken = 1795,
        //
        // Resumo:
        //     Original was GL_BITMAP_TOKEN = 0x0704
        BitmapToken = 1796,
        //
        // Resumo:
        //     Original was GL_DRAW_PIXEL_TOKEN = 0x0705
        DrawPixelToken = 1797,
        //
        // Resumo:
        //     Original was GL_COPY_PIXEL_TOKEN = 0x0706
        CopyPixelToken = 1798,
        //
        // Resumo:
        //     Original was GL_LINE_RESET_TOKEN = 0x0707
        LineResetToken = 1799,
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
        //     Original was GL_VIEWPORT_BIT = 0x00000800
        ViewportBit = 2048,
        //
        // Resumo:
        //     Original was GL_EXP = 0x0800
        Exp = 2048,
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
        //     Original was GL_EXP2 = 0x0801
        Exp2 = 2049,
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
        //     Original was GL_CURRENT_COLOR = 0x0B00
        CurrentColor = 2816,
        //
        // Resumo:
        //     Original was GL_CURRENT_INDEX = 0x0B01
        CurrentIndex = 2817,
        //
        // Resumo:
        //     Original was GL_CURRENT_NORMAL = 0x0B02
        CurrentNormal = 2818,
        //
        // Resumo:
        //     Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        CurrentTextureCoords = 2819,
        //
        // Resumo:
        //     Original was GL_CURRENT_RASTER_COLOR = 0x0B04
        CurrentRasterColor = 2820,
        //
        // Resumo:
        //     Original was GL_CURRENT_RASTER_INDEX = 0x0B05
        CurrentRasterIndex = 2821,
        //
        // Resumo:
        //     Original was GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06
        CurrentRasterTextureCoords = 2822,
        //
        // Resumo:
        //     Original was GL_CURRENT_RASTER_POSITION = 0x0B07
        CurrentRasterPosition = 2823,
        //
        // Resumo:
        //     Original was GL_CURRENT_RASTER_POSITION_VALID = 0x0B08
        CurrentRasterPositionValid = 2824,
        //
        // Resumo:
        //     Original was GL_CURRENT_RASTER_DISTANCE = 0x0B09
        CurrentRasterDistance = 2825,
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
        //     Original was GL_LINE_STIPPLE_PATTERN = 0x0B25
        LineStipplePattern = 2853,
        //
        // Resumo:
        //     Original was GL_LINE_STIPPLE_REPEAT = 0x0B26
        LineStippleRepeat = 2854,
        //
        // Resumo:
        //     Original was GL_LIST_MODE = 0x0B30
        ListMode = 2864,
        //
        // Resumo:
        //     Original was GL_MAX_LIST_NESTING = 0x0B31
        MaxListNesting = 2865,
        //
        // Resumo:
        //     Original was GL_LIST_BASE = 0x0B32
        ListBase = 2866,
        //
        // Resumo:
        //     Original was GL_LIST_INDEX = 0x0B33
        ListIndex = 2867,
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
        //     Original was GL_EDGE_FLAG = 0x0B43
        EdgeFlag = 2883,
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
        //     Original was GL_SHADE_MODEL = 0x0B54
        ShadeModel = 2900,
        //
        // Resumo:
        //     Original was GL_COLOR_MATERIAL_FACE = 0x0B55
        ColorMaterialFace = 2901,
        //
        // Resumo:
        //     Original was GL_COLOR_MATERIAL_PARAMETER = 0x0B56
        ColorMaterialParameter = 2902,
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
        //     Original was GL_ACCUM_CLEAR_VALUE = 0x0B80
        AccumClearValue = 2944,
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
        //     Original was GL_MATRIX_MODE = 0x0BA0
        MatrixMode = 2976,
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
        //     Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        ModelviewStackDepth = 2979,
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
        //     Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        ProjectionStackDepth = 2980,
        //
        // Resumo:
        //     Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        TextureStackDepth = 2981,
        //
        // Resumo:
        //     Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        Modelview0MatrixExt = 2982,
        //
        // Resumo:
        //     Original was GL_MODELVIEW_MATRIX = 0x0BA6
        ModelviewMatrix = 2982,
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
        //     Original was GL_PROJECTION_MATRIX = 0x0BA7
        ProjectionMatrix = 2983,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MATRIX = 0x0BA8
        TextureMatrix = 2984,
        //
        // Resumo:
        //     Original was GL_ATTRIB_STACK_DEPTH = 0x0BB0
        AttribStackDepth = 2992,
        //
        // Resumo:
        //     Original was GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1
        ClientAttribStackDepth = 2993,
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
        //     Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        AlphaTestFunc = 3009,
        //
        // Resumo:
        //     Original was GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1
        AlphaTestFuncQcom = 3009,
        //
        // Resumo:
        //     Original was GL_ALPHA_TEST_REF = 0x0BC2
        AlphaTestRef = 3010,
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
        //     Original was GL_AUX_BUFFERS = 0x0C00
        AuxBuffers = 3072,
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
        //     Original was GL_INDEX_CLEAR_VALUE = 0x0C20
        IndexClearValue = 3104,
        //
        // Resumo:
        //     Original was GL_INDEX_WRITEMASK = 0x0C21
        IndexWritemask = 3105,
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
        //     Original was GL_INDEX_MODE = 0x0C30
        IndexMode = 3120,
        //
        // Resumo:
        //     Original was GL_RGBA_MODE = 0x0C31
        RgbaMode = 3121,
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
        //     Original was GL_RENDER_MODE = 0x0C40
        RenderMode = 3136,
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
        //     Original was GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0
        PixelMapIToISize = 3248,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1
        PixelMapSToSSize = 3249,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2
        PixelMapIToRSize = 3250,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3
        PixelMapIToGSize = 3251,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4
        PixelMapIToBSize = 3252,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5
        PixelMapIToASize = 3253,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6
        PixelMapRToRSize = 3254,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7
        PixelMapGToGSize = 3255,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8
        PixelMapBToBSize = 3256,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9
        PixelMapAToASize = 3257,
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
        //     Original was GL_ZOOM_X = 0x0D16
        ZoomX = 3350,
        //
        // Resumo:
        //     Original was GL_ZOOM_Y = 0x0D17
        ZoomY = 3351,
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
        //     Original was GL_MAX_EVAL_ORDER = 0x0D30
        MaxEvalOrder = 3376,
        //
        // Resumo:
        //     Original was GL_MAX_LIGHTS = 0x0D31
        MaxLights = 3377,
        //
        // Resumo:
        //     Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        MaxClipDistances = 3378,
        //
        // Resumo:
        //     Original was GL_MAX_CLIP_PLANES = 0x0D32
        MaxClipPlanes = 3378,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        MaxTextureSize = 3379,
        //
        // Resumo:
        //     Original was GL_MAX_PIXEL_MAP_TABLE = 0x0D34
        MaxPixelMapTable = 3380,
        //
        // Resumo:
        //     Original was GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35
        MaxAttribStackDepth = 3381,
        //
        // Resumo:
        //     Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        MaxModelviewStackDepth = 3382,
        //
        // Resumo:
        //     Original was GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36
        PathMaxModelviewStackDepthNv = 3382,
        //
        // Resumo:
        //     Original was GL_MAX_NAME_STACK_DEPTH = 0x0D37
        MaxNameStackDepth = 3383,
        //
        // Resumo:
        //     Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        MaxProjectionStackDepth = 3384,
        //
        // Resumo:
        //     Original was GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38
        PathMaxProjectionStackDepthNv = 3384,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        MaxTextureStackDepth = 3385,
        //
        // Resumo:
        //     Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        MaxViewportDims = 3386,
        //
        // Resumo:
        //     Original was GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B
        MaxClientAttribStackDepth = 3387,
        //
        // Resumo:
        //     Original was GL_SUBPIXEL_BITS = 0x0D50
        SubpixelBits = 3408,
        //
        // Resumo:
        //     Original was GL_INDEX_BITS = 0x0D51
        IndexBits = 3409,
        //
        // Resumo:
        //     Original was GL_RED_BITS = 0x0D52
        RedBits = 3410,
        //
        // Resumo:
        //     Original was GL_GREEN_BITS = 0x0D53
        GreenBits = 3411,
        //
        // Resumo:
        //     Original was GL_BLUE_BITS = 0x0D54
        BlueBits = 3412,
        //
        // Resumo:
        //     Original was GL_ALPHA_BITS = 0x0D55
        AlphaBits = 3413,
        //
        // Resumo:
        //     Original was GL_DEPTH_BITS = 0x0D56
        DepthBits = 3414,
        //
        // Resumo:
        //     Original was GL_STENCIL_BITS = 0x0D57
        StencilBits = 3415,
        //
        // Resumo:
        //     Original was GL_ACCUM_RED_BITS = 0x0D58
        AccumRedBits = 3416,
        //
        // Resumo:
        //     Original was GL_ACCUM_GREEN_BITS = 0x0D59
        AccumGreenBits = 3417,
        //
        // Resumo:
        //     Original was GL_ACCUM_BLUE_BITS = 0x0D5A
        AccumBlueBits = 3418,
        //
        // Resumo:
        //     Original was GL_ACCUM_ALPHA_BITS = 0x0D5B
        AccumAlphaBits = 3419,
        //
        // Resumo:
        //     Original was GL_NAME_STACK_DEPTH = 0x0D70
        NameStackDepth = 3440,
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
        //     Original was GL_MAP1_GRID_DOMAIN = 0x0DD0
        Map1GridDomain = 3536,
        //
        // Resumo:
        //     Original was GL_MAP1_GRID_SEGMENTS = 0x0DD1
        Map1GridSegments = 3537,
        //
        // Resumo:
        //     Original was GL_MAP2_GRID_DOMAIN = 0x0DD2
        Map2GridDomain = 3538,
        //
        // Resumo:
        //     Original was GL_MAP2_GRID_SEGMENTS = 0x0DD3
        Map2GridSegments = 3539,
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
        //     Original was GL_FEEDBACK_BUFFER_POINTER = 0x0DF0
        FeedbackBufferPointer = 3568,
        //
        // Resumo:
        //     Original was GL_FEEDBACK_BUFFER_SIZE = 0x0DF1
        FeedbackBufferSize = 3569,
        //
        // Resumo:
        //     Original was GL_FEEDBACK_BUFFER_TYPE = 0x0DF2
        FeedbackBufferType = 3570,
        //
        // Resumo:
        //     Original was GL_SELECTION_BUFFER_POINTER = 0x0DF3
        SelectionBufferPointer = 3571,
        //
        // Resumo:
        //     Original was GL_SELECTION_BUFFER_SIZE = 0x0DF4
        SelectionBufferSize = 3572,
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
        //     Original was GL_TRANSFORM_BIT = 0x00001000
        TransformBit = 4096,
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
        //     Original was GL_POSITION = 0x1203
        Position = 4611,
        //
        // Resumo:
        //     Original was GL_SPOT_DIRECTION = 0x1204
        SpotDirection = 4612,
        //
        // Resumo:
        //     Original was GL_SPOT_EXPONENT = 0x1205
        SpotExponent = 4613,
        //
        // Resumo:
        //     Original was GL_SPOT_CUTOFF = 0x1206
        SpotCutoff = 4614,
        //
        // Resumo:
        //     Original was GL_CONSTANT_ATTENUATION = 0x1207
        ConstantAttenuation = 4615,
        //
        // Resumo:
        //     Original was GL_LINEAR_ATTENUATION = 0x1208
        LinearAttenuation = 4616,
        //
        // Resumo:
        //     Original was GL_QUADRATIC_ATTENUATION = 0x1209
        QuadraticAttenuation = 4617,
        //
        // Resumo:
        //     Original was GL_COMPILE = 0x1300
        Compile = 4864,
        //
        // Resumo:
        //     Original was GL_COMPILE_AND_EXECUTE = 0x1301
        CompileAndExecute = 4865,
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
        //     Original was GL_2_BYTES = 0x1407
        Gl2Bytes = 5127,
        //
        // Resumo:
        //     Original was GL_2_BYTES_NV = 0x1407
        Gl2BytesNv = 5127,
        //
        // Resumo:
        //     Original was GL_3_BYTES = 0x1408
        Gl3Bytes = 5128,
        //
        // Resumo:
        //     Original was GL_3_BYTES_NV = 0x1408
        Gl3BytesNv = 5128,
        //
        // Resumo:
        //     Original was GL_4_BYTES = 0x1409
        Gl4Bytes = 5129,
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
        //     Original was GL_HALF_APPLE = 0x140B
        HalfApple = 5131,
        //
        // Resumo:
        //     Original was GL_HALF_FLOAT = 0x140B
        HalfFloat = 5131,
        //
        // Resumo:
        //     Original was GL_HALF_FLOAT_ARB = 0x140B
        HalfFloatArb = 5131,
        //
        // Resumo:
        //     Original was GL_HALF_FLOAT_NV = 0x140B
        HalfFloatNv = 5131,
        //
        // Resumo:
        //     Original was GL_FIXED = 0x140C
        Fixed = 5132,
        //
        // Resumo:
        //     Original was GL_FIXED_OES = 0x140C
        FixedOes = 5132,
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
        //     Original was GL_SHININESS = 0x1601
        Shininess = 5633,
        //
        // Resumo:
        //     Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        AmbientAndDiffuse = 5634,
        //
        // Resumo:
        //     Original was GL_COLOR_INDEXES = 0x1603
        ColorIndexes = 5635,
        //
        // Resumo:
        //     Original was GL_MODELVIEW = 0x1700
        Modelview = 5888,
        //
        // Resumo:
        //     Original was GL_MODELVIEW0_ARB = 0x1700
        Modelview0Arb = 5888,
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
        //     Original was GL_PROJECTION = 0x1701
        Projection = 5889,
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
        //     Original was GL_BITMAP = 0x1A00
        Bitmap = 6656,
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
        //     Original was GL_RENDER = 0x1C00
        Render = 7168,
        //
        // Resumo:
        //     Original was GL_FEEDBACK = 0x1C01
        Feedback = 7169,
        //
        // Resumo:
        //     Original was GL_SELECT = 0x1C02
        Select = 7170,
        //
        // Resumo:
        //     Original was GL_FLAT = 0x1D00
        Flat = 7424,
        //
        // Resumo:
        //     Original was GL_SMOOTH = 0x1D01
        Smooth = 7425,
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
        //     Original was GL_ENABLE_BIT = 0x00002000
        EnableBit = 8192,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000
        ShaderStorageBarrierBit = 8192,
        //
        // Resumo:
        //     Original was GL_S = 0x2000
        S = 8192,
        //
        // Resumo:
        //     Original was GL_T = 0x2001
        T = 8193,
        //
        // Resumo:
        //     Original was GL_R = 0x2002
        R = 8194,
        //
        // Resumo:
        //     Original was GL_Q = 0x2003
        Q = 8195,
        //
        // Resumo:
        //     Original was GL_MODULATE = 0x2100
        Modulate = 8448,
        //
        // Resumo:
        //     Original was GL_DECAL = 0x2101
        Decal = 8449,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ENV_MODE = 0x2200
        TextureEnvMode = 8704,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ENV_COLOR = 0x2201
        TextureEnvColor = 8705,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ENV = 0x2300
        TextureEnv = 8960,
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
        //     Original was GL_SPHERE_MAP = 0x2402
        SphereMap = 9218,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GEN_MODE = 0x2500
        TextureGenMode = 9472,
        //
        // Resumo:
        //     Original was GL_OBJECT_PLANE = 0x2501
        ObjectPlane = 9473,
        //
        // Resumo:
        //     Original was GL_EYE_PLANE = 0x2502
        EyePlane = 9474,
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
        //     Original was GL_CLAMP = 0x2900
        Clamp = 10496,
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
        //     Original was GL_V2F = 0x2A20
        V2f = 10784,
        //
        // Resumo:
        //     Original was GL_V3F = 0x2A21
        V3f = 10785,
        //
        // Resumo:
        //     Original was GL_C4UB_V2F = 0x2A22
        C4ubV2f = 10786,
        //
        // Resumo:
        //     Original was GL_C4UB_V3F = 0x2A23
        C4ubV3f = 10787,
        //
        // Resumo:
        //     Original was GL_C3F_V3F = 0x2A24
        C3fV3f = 10788,
        //
        // Resumo:
        //     Original was GL_N3F_V3F = 0x2A25
        N3fV3f = 10789,
        //
        // Resumo:
        //     Original was GL_C4F_N3F_V3F = 0x2A26
        C4fN3fV3f = 10790,
        //
        // Resumo:
        //     Original was GL_T2F_V3F = 0x2A27
        T2fV3f = 10791,
        //
        // Resumo:
        //     Original was GL_T4F_V4F = 0x2A28
        T4fV4f = 10792,
        //
        // Resumo:
        //     Original was GL_T2F_C4UB_V3F = 0x2A29
        T2fC4ubV3f = 10793,
        //
        // Resumo:
        //     Original was GL_T2F_C3F_V3F = 0x2A2A
        T2fC3fV3f = 10794,
        //
        // Resumo:
        //     Original was GL_T2F_N3F_V3F = 0x2A2B
        T2fN3fV3f = 10795,
        //
        // Resumo:
        //     Original was GL_T2F_C4F_N3F_V3F = 0x2A2C
        T2fC4fN3fV3f = 10796,
        //
        // Resumo:
        //     Original was GL_T4F_C4F_N3F_V4F = 0x2A2D
        T4fC4fN3fV4f = 10797,
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
        //     Original was GL_HINT_BIT = 0x00008000
        HintBit = 32768,
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
        //     Original was GL_CONSTANT_COLOR_EXT = 0x8001
        ConstantColorExt = 32769,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        OneMinusConstantColor = 32770,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002
        OneMinusConstantColorExt = 32770,
        //
        // Resumo:
        //     Original was GL_CONSTANT_ALPHA = 0x8003
        ConstantAlpha = 32771,
        //
        // Resumo:
        //     Original was GL_CONSTANT_ALPHA_EXT = 0x8003
        ConstantAlphaExt = 32771,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        OneMinusConstantAlpha = 32772,
        //
        // Resumo:
        //     Original was GL_ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004
        OneMinusConstantAlphaExt = 32772,
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
        //     Original was GL_BLEND_EQUATION_RGB_EXT = 0x8009
        BlendEquationRgbExt = 32777,
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
        //     Original was GL_POLYGON_OFFSET_EXT = 0x8037
        PolygonOffsetExt = 32823,
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
        //     Original was GL_POLYGON_OFFSET_FACTOR_EXT = 0x8038
        PolygonOffsetFactorExt = 32824,
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
        //     Original was GL_ALPHA4 = 0x803B
        Alpha4 = 32827,
        //
        // Resumo:
        //     Original was GL_ALPHA4_EXT = 0x803B
        Alpha4Ext = 32827,
        //
        // Resumo:
        //     Original was GL_ALPHA8 = 0x803C
        Alpha8 = 32828,
        //
        // Resumo:
        //     Original was GL_ALPHA8_EXT = 0x803C
        Alpha8Ext = 32828,
        //
        // Resumo:
        //     Original was GL_ALPHA12 = 0x803D
        Alpha12 = 32829,
        //
        // Resumo:
        //     Original was GL_ALPHA12_EXT = 0x803D
        Alpha12Ext = 32829,
        //
        // Resumo:
        //     Original was GL_ALPHA16 = 0x803E
        Alpha16 = 32830,
        //
        // Resumo:
        //     Original was GL_ALPHA16_EXT = 0x803E
        Alpha16Ext = 32830,
        //
        // Resumo:
        //     Original was GL_LUMINANCE4 = 0x803F
        Luminance4 = 32831,
        //
        // Resumo:
        //     Original was GL_LUMINANCE4_EXT = 0x803F
        Luminance4Ext = 32831,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8 = 0x8040
        Luminance8 = 32832,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8_EXT = 0x8040
        Luminance8Ext = 32832,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12 = 0x8041
        Luminance12 = 32833,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12_EXT = 0x8041
        Luminance12Ext = 32833,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16 = 0x8042
        Luminance16 = 32834,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16_EXT = 0x8042
        Luminance16Ext = 32834,
        //
        // Resumo:
        //     Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        Luminance4Alpha4 = 32835,
        //
        // Resumo:
        //     Original was GL_LUMINANCE4_ALPHA4_EXT = 0x8043
        Luminance4Alpha4Ext = 32835,
        //
        // Resumo:
        //     Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        Luminance6Alpha2 = 32836,
        //
        // Resumo:
        //     Original was GL_LUMINANCE6_ALPHA2_EXT = 0x8044
        Luminance6Alpha2Ext = 32836,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        Luminance8Alpha8 = 32837,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        Luminance8Alpha8Ext = 32837,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        Luminance12Alpha4 = 32838,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12_ALPHA4_EXT = 0x8046
        Luminance12Alpha4Ext = 32838,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        Luminance12Alpha12 = 32839,
        //
        // Resumo:
        //     Original was GL_LUMINANCE12_ALPHA12_EXT = 0x8047
        Luminance12Alpha12Ext = 32839,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        Luminance16Alpha16 = 32840,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16_ALPHA16_EXT = 0x8048
        Luminance16Alpha16Ext = 32840,
        //
        // Resumo:
        //     Original was GL_INTENSITY = 0x8049
        Intensity = 32841,
        //
        // Resumo:
        //     Original was GL_INTENSITY_EXT = 0x8049
        IntensityExt = 32841,
        //
        // Resumo:
        //     Original was GL_INTENSITY4 = 0x804A
        Intensity4 = 32842,
        //
        // Resumo:
        //     Original was GL_INTENSITY4_EXT = 0x804A
        Intensity4Ext = 32842,
        //
        // Resumo:
        //     Original was GL_INTENSITY8 = 0x804B
        Intensity8 = 32843,
        //
        // Resumo:
        //     Original was GL_INTENSITY8_EXT = 0x804B
        Intensity8Ext = 32843,
        //
        // Resumo:
        //     Original was GL_INTENSITY12 = 0x804C
        Intensity12 = 32844,
        //
        // Resumo:
        //     Original was GL_INTENSITY12_EXT = 0x804C
        Intensity12Ext = 32844,
        //
        // Resumo:
        //     Original was GL_INTENSITY16 = 0x804D
        Intensity16 = 32845,
        //
        // Resumo:
        //     Original was GL_INTENSITY16_EXT = 0x804D
        Intensity16Ext = 32845,
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
        //     Original was GL_RGBA2_EXT = 0x8055
        Rgba2Ext = 32853,
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
        //     Original was GL_TEXTURE_RED_SIZE_EXT = 0x805C
        TextureRedSizeExt = 32860,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        TextureGreenSize = 32861,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GREEN_SIZE_EXT = 0x805D
        TextureGreenSizeExt = 32861,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        TextureBlueSize = 32862,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BLUE_SIZE_EXT = 0x805E
        TextureBlueSizeExt = 32862,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        TextureAlphaSize = 32863,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ALPHA_SIZE_EXT = 0x805F
        TextureAlphaSizeExt = 32863,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        TextureLuminanceSize = 32864,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LUMINANCE_SIZE_EXT = 0x8060
        TextureLuminanceSizeExt = 32864,
        //
        // Resumo:
        //     Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        TextureIntensitySize = 32865,
        //
        // Resumo:
        //     Original was GL_TEXTURE_INTENSITY_SIZE_EXT = 0x8061
        TextureIntensitySizeExt = 32865,
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
        //     Original was GL_TEXTURE_RESIDENT_EXT = 0x8067
        TextureResidentExt = 32871,
        //
        // Resumo:
        //     Original was GL_TEXTURE_1D_BINDING_EXT = 0x8068
        Texture1DBindingExt = 32872,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_1D = 0x8068
        TextureBinding1D = 32872,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_BINDING_EXT = 0x8069
        Texture2DBindingExt = 32873,
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
        //     Original was GL_VERTEX_ARRAY_EXT = 0x8074
        VertexArrayExt = 32884,
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
        //     Original was GL_NORMAL_ARRAY_EXT = 0x8075
        NormalArrayExt = 32885,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY = 0x8076
        ColorArray = 32886,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_EXT = 0x8076
        ColorArrayExt = 32886,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY = 0x8077
        IndexArray = 32887,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_EXT = 0x8077
        IndexArrayExt = 32887,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        TextureCoordArray = 32888,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_EXT = 0x8078
        TextureCoordArrayExt = 32888,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY = 0x8079
        EdgeFlagArray = 32889,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_EXT = 0x8079
        EdgeFlagArrayExt = 32889,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_SIZE = 0x807A
        VertexArraySize = 32890,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_SIZE_EXT = 0x807A
        VertexArraySizeExt = 32890,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_TYPE = 0x807B
        VertexArrayType = 32891,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_TYPE_EXT = 0x807B
        VertexArrayTypeExt = 32891,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_STRIDE = 0x807C
        VertexArrayStride = 32892,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_STRIDE_EXT = 0x807C
        VertexArrayStrideExt = 32892,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
        VertexArrayCountExt = 32893,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_TYPE = 0x807E
        NormalArrayType = 32894,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_TYPE_EXT = 0x807E
        NormalArrayTypeExt = 32894,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_STRIDE = 0x807F
        NormalArrayStride = 32895,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_STRIDE_EXT = 0x807F
        NormalArrayStrideExt = 32895,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
        NormalArrayCountExt = 32896,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_SIZE = 0x8081
        ColorArraySize = 32897,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_SIZE_EXT = 0x8081
        ColorArraySizeExt = 32897,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_TYPE = 0x8082
        ColorArrayType = 32898,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_TYPE_EXT = 0x8082
        ColorArrayTypeExt = 32898,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_STRIDE = 0x8083
        ColorArrayStride = 32899,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_STRIDE_EXT = 0x8083
        ColorArrayStrideExt = 32899,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_COUNT_EXT = 0x8084
        ColorArrayCountExt = 32900,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_TYPE = 0x8085
        IndexArrayType = 32901,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_TYPE_EXT = 0x8085
        IndexArrayTypeExt = 32901,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_STRIDE = 0x8086
        IndexArrayStride = 32902,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_STRIDE_EXT = 0x8086
        IndexArrayStrideExt = 32902,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_COUNT_EXT = 0x8087
        IndexArrayCountExt = 32903,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088
        TextureCoordArraySize = 32904,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088
        TextureCoordArraySizeExt = 32904,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089
        TextureCoordArrayType = 32905,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089
        TextureCoordArrayTypeExt = 32905,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A
        TextureCoordArrayStride = 32906,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A
        TextureCoordArrayStrideExt = 32906,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
        TextureCoordArrayCountExt = 32907,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C
        EdgeFlagArrayStride = 32908,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C
        EdgeFlagArrayStrideExt = 32908,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
        EdgeFlagArrayCountExt = 32909,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        VertexArrayPointer = 32910,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
        VertexArrayPointerExt = 32910,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        NormalArrayPointer = 32911,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
        NormalArrayPointerExt = 32911,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_POINTER = 0x8090
        ColorArrayPointer = 32912,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_POINTER_EXT = 0x8090
        ColorArrayPointerExt = 32912,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_POINTER = 0x8091
        IndexArrayPointer = 32913,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_POINTER_EXT = 0x8091
        IndexArrayPointerExt = 32913,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        TextureCoordArrayPointer = 32914,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
        TextureCoordArrayPointerExt = 32914,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_POINTER = 0x8093
        EdgeFlagArrayPointer = 32915,
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
        //     Original was GL_MULTISAMPLE_ARB = 0x809D
        MultisampleArb = 32925,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_EXT = 0x809D
        MultisampleExt = 32925,
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
        //     Original was GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E
        SampleAlphaToCoverageArb = 32926,
        //
        // Resumo:
        //     Original was GL_SAMPLE_ALPHA_TO_MASK_EXT = 0x809E
        SampleAlphaToMaskExt = 32926,
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
        //     Original was GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F
        SampleAlphaToOneArb = 32927,
        //
        // Resumo:
        //     Original was GL_SAMPLE_ALPHA_TO_ONE_EXT = 0x809F
        SampleAlphaToOneExt = 32927,
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
        //     Original was GL_SAMPLE_COVERAGE_ARB = 0x80A0
        SampleCoverageArb = 32928,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_EXT = 0x80A0
        SampleMaskExt = 32928,
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
        //     Original was GL_SAMPLE_BUFFERS_ARB = 0x80A8
        SampleBuffersArb = 32936,
        //
        // Resumo:
        //     Original was GL_SAMPLE_BUFFERS_EXT = 0x80A8
        SampleBuffersExt = 32936,
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
        //     Original was GL_SAMPLES_ARB = 0x80A9
        SamplesArb = 32937,
        //
        // Resumo:
        //     Original was GL_SAMPLES_EXT = 0x80A9
        SamplesExt = 32937,
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
        //     Original was GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA
        SampleCoverageValueArb = 32938,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_VALUE_EXT = 0x80AA
        SampleMaskValueExt = 32938,
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
        //     Original was GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB
        SampleCoverageInvertArb = 32939,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_INVERT_EXT = 0x80AB
        SampleMaskInvertExt = 32939,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        SampleMaskInvertSgis = 32939,
        //
        // Resumo:
        //     Original was GL_SAMPLE_PATTERN_EXT = 0x80AC
        SamplePatternExt = 32940,
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
        //     Original was GL_TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF
        TextureCompareFailValueArb = 32959,
        //
        // Resumo:
        //     Original was GL_BLEND_DST_RGB = 0x80C8
        BlendDstRgb = 32968,
        //
        // Resumo:
        //     Original was GL_BLEND_DST_RGB_EXT = 0x80C8
        BlendDstRgbExt = 32968,
        //
        // Resumo:
        //     Original was GL_BLEND_SRC_RGB = 0x80C9
        BlendSrcRgb = 32969,
        //
        // Resumo:
        //     Original was GL_BLEND_SRC_RGB_EXT = 0x80C9
        BlendSrcRgbExt = 32969,
        //
        // Resumo:
        //     Original was GL_BLEND_DST_ALPHA = 0x80CA
        BlendDstAlpha = 32970,
        //
        // Resumo:
        //     Original was GL_BLEND_DST_ALPHA_EXT = 0x80CA
        BlendDstAlphaExt = 32970,
        //
        // Resumo:
        //     Original was GL_BLEND_SRC_ALPHA = 0x80CB
        BlendSrcAlpha = 32971,
        //
        // Resumo:
        //     Original was GL_BLEND_SRC_ALPHA_EXT = 0x80CB
        BlendSrcAlphaExt = 32971,
        //
        // Resumo:
        //     Original was GL_422_EXT = 0x80CC
        Gl422Ext = 32972,
        //
        // Resumo:
        //     Original was GL_422_REV_EXT = 0x80CD
        Gl422RevExt = 32973,
        //
        // Resumo:
        //     Original was GL_422_AVERAGE_EXT = 0x80CE
        Gl422AverageExt = 32974,
        //
        // Resumo:
        //     Original was GL_422_REV_AVERAGE_EXT = 0x80CF
        Gl422RevAverageExt = 32975,
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
        //     Original was GL_BGR_EXT = 0x80E0
        BgrExt = 32992,
        //
        // Resumo:
        //     Original was GL_BGRA = 0x80E1
        Bgra = 32993,
        //
        // Resumo:
        //     Original was GL_BGRA_EXT = 0x80E1
        BgraExt = 32993,
        //
        // Resumo:
        //     Original was GL_COLOR_INDEX1_EXT = 0x80E2
        ColorIndex1Ext = 32994,
        //
        // Resumo:
        //     Original was GL_COLOR_INDEX2_EXT = 0x80E3
        ColorIndex2Ext = 32995,
        //
        // Resumo:
        //     Original was GL_COLOR_INDEX4_EXT = 0x80E4
        ColorIndex4Ext = 32996,
        //
        // Resumo:
        //     Original was GL_COLOR_INDEX8_EXT = 0x80E5
        ColorIndex8Ext = 32997,
        //
        // Resumo:
        //     Original was GL_COLOR_INDEX12_EXT = 0x80E6
        ColorIndex12Ext = 32998,
        //
        // Resumo:
        //     Original was GL_COLOR_INDEX16_EXT = 0x80E7
        ColorIndex16Ext = 32999,
        //
        // Resumo:
        //     Original was GL_MAX_ELEMENTS_VERTICES = 0x80E8
        MaxElementsVertices = 33000,
        //
        // Resumo:
        //     Original was GL_MAX_ELEMENTS_VERTICES_EXT = 0x80E8
        MaxElementsVerticesExt = 33000,
        //
        // Resumo:
        //     Original was GL_MAX_ELEMENTS_INDICES = 0x80E9
        MaxElementsIndices = 33001,
        //
        // Resumo:
        //     Original was GL_MAX_ELEMENTS_INDICES_EXT = 0x80E9
        MaxElementsIndicesExt = 33001,
        //
        // Resumo:
        //     Original was GL_PHONG_WIN = 0x80EA
        PhongWin = 33002,
        //
        // Resumo:
        //     Original was GL_PHONG_HINT_WIN = 0x80EB
        PhongHintWin = 33003,
        //
        // Resumo:
        //     Original was GL_FOG_SPECULAR_TEXTURE_WIN = 0x80EC
        FogSpecularTextureWin = 33004,
        //
        // Resumo:
        //     Original was GL_TEXTURE_INDEX_SIZE_EXT = 0x80ED
        TextureIndexSizeExt = 33005,
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
        //     Original was GL_SPRITE_AXIAL_SGIX = 0x814C
        SpriteAxialSgix = 33100,
        //
        // Resumo:
        //     Original was GL_SPRITE_OBJECT_ALIGNED_SGIX = 0x814D
        SpriteObjectAlignedSgix = 33101,
        //
        // Resumo:
        //     Original was GL_SPRITE_EYE_ALIGNED_SGIX = 0x814E
        SpriteEyeAlignedSgix = 33102,
        //
        // Resumo:
        //     Original was GL_TEXTURE_4D_BINDING_SGIS = 0x814F
        Texture4DBindingSgis = 33103,
        //
        // Resumo:
        //     Original was GL_IGNORE_BORDER_HP = 0x8150
        IgnoreBorderHp = 33104,
        //
        // Resumo:
        //     Original was GL_CONSTANT_BORDER = 0x8151
        ConstantBorder = 33105,
        //
        // Resumo:
        //     Original was GL_CONSTANT_BORDER_HP = 0x8151
        ConstantBorderHp = 33105,
        //
        // Resumo:
        //     Original was GL_REPLICATE_BORDER = 0x8153
        ReplicateBorder = 33107,
        //
        // Resumo:
        //     Original was GL_REPLICATE_BORDER_HP = 0x8153
        ReplicateBorderHp = 33107,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_BORDER_COLOR = 0x8154
        ConvolutionBorderColor = 33108,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_BORDER_COLOR_HP = 0x8154
        ConvolutionBorderColorHp = 33108,
        //
        // Resumo:
        //     Original was GL_IMAGE_SCALE_X_HP = 0x8155
        ImageScaleXHp = 33109,
        //
        // Resumo:
        //     Original was GL_IMAGE_SCALE_Y_HP = 0x8156
        ImageScaleYHp = 33110,
        //
        // Resumo:
        //     Original was GL_IMAGE_TRANSLATE_X_HP = 0x8157
        ImageTranslateXHp = 33111,
        //
        // Resumo:
        //     Original was GL_IMAGE_TRANSLATE_Y_HP = 0x8158
        ImageTranslateYHp = 33112,
        //
        // Resumo:
        //     Original was GL_IMAGE_ROTATE_ANGLE_HP = 0x8159
        ImageRotateAngleHp = 33113,
        //
        // Resumo:
        //     Original was GL_IMAGE_ROTATE_ORIGIN_X_HP = 0x815A
        ImageRotateOriginXHp = 33114,
        //
        // Resumo:
        //     Original was GL_IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B
        ImageRotateOriginYHp = 33115,
        //
        // Resumo:
        //     Original was GL_IMAGE_MAG_FILTER_HP = 0x815C
        ImageMagFilterHp = 33116,
        //
        // Resumo:
        //     Original was GL_IMAGE_MIN_FILTER_HP = 0x815D
        ImageMinFilterHp = 33117,
        //
        // Resumo:
        //     Original was GL_IMAGE_CUBIC_WEIGHT_HP = 0x815E
        ImageCubicWeightHp = 33118,
        //
        // Resumo:
        //     Original was GL_CUBIC_HP = 0x815F
        CubicHp = 33119,
        //
        // Resumo:
        //     Original was GL_AVERAGE_HP = 0x8160
        AverageHp = 33120,
        //
        // Resumo:
        //     Original was GL_IMAGE_TRANSFORM_2D_HP = 0x8161
        ImageTransform2DHp = 33121,
        //
        // Resumo:
        //     Original was GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162
        PostImageTransformColorTableHp = 33122,
        //
        // Resumo:
        //     Original was GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163
        ProxyPostImageTransformColorTableHp = 33123,
        //
        // Resumo:
        //     Original was GL_OCCLUSION_TEST_HP = 0x8165
        OcclusionTestHp = 33125,
        //
        // Resumo:
        //     Original was GL_OCCLUSION_TEST_RESULT_HP = 0x8166
        OcclusionTestResultHp = 33126,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LIGHTING_MODE_HP = 0x8167
        TextureLightingModeHp = 33127,
        //
        // Resumo:
        //     Original was GL_TEXTURE_POST_SPECULAR_HP = 0x8168
        TexturePostSpecularHp = 33128,
        //
        // Resumo:
        //     Original was GL_TEXTURE_PRE_SPECULAR_HP = 0x8169
        TexturePreSpecularHp = 33129,
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
        //     Original was GL_MAX_DEFORMATION_ORDER_SGIX = 0x8197
        MaxDeformationOrderSgix = 33175,
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
        //     Original was GL_ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8
        ArrayElementLockFirstExt = 33192,
        //
        // Resumo:
        //     Original was GL_ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9
        ArrayElementLockCountExt = 33193,
        //
        // Resumo:
        //     Original was GL_CULL_VERTEX_EXT = 0x81AA
        CullVertexExt = 33194,
        //
        // Resumo:
        //     Original was GL_CULL_VERTEX_EYE_POSITION_EXT = 0x81AB
        CullVertexEyePositionExt = 33195,
        //
        // Resumo:
        //     Original was GL_CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC
        CullVertexObjectPositionExt = 33196,
        //
        // Resumo:
        //     Original was GL_IUI_V2F_EXT = 0x81AD
        IuiV2fExt = 33197,
        //
        // Resumo:
        //     Original was GL_IUI_V3F_EXT = 0x81AE
        IuiV3fExt = 33198,
        //
        // Resumo:
        //     Original was GL_IUI_N3F_V2F_EXT = 0x81AF
        IuiN3fV2fExt = 33199,
        //
        // Resumo:
        //     Original was GL_IUI_N3F_V3F_EXT = 0x81B0
        IuiN3fV3fExt = 33200,
        //
        // Resumo:
        //     Original was GL_T2F_IUI_V2F_EXT = 0x81B1
        T2fIuiV2fExt = 33201,
        //
        // Resumo:
        //     Original was GL_T2F_IUI_V3F_EXT = 0x81B2
        T2fIuiV3fExt = 33202,
        //
        // Resumo:
        //     Original was GL_T2F_IUI_N3F_V2F_EXT = 0x81B3
        T2fIuiN3fV2fExt = 33203,
        //
        // Resumo:
        //     Original was GL_T2F_IUI_N3F_V3F_EXT = 0x81B4
        T2fIuiN3fV3fExt = 33204,
        //
        // Resumo:
        //     Original was GL_INDEX_TEST_EXT = 0x81B5
        IndexTestExt = 33205,
        //
        // Resumo:
        //     Original was GL_INDEX_TEST_FUNC_EXT = 0x81B6
        IndexTestFuncExt = 33206,
        //
        // Resumo:
        //     Original was GL_INDEX_TEST_REF_EXT = 0x81B7
        IndexTestRefExt = 33207,
        //
        // Resumo:
        //     Original was GL_INDEX_MATERIAL_EXT = 0x81B8
        IndexMaterialExt = 33208,
        //
        // Resumo:
        //     Original was GL_INDEX_MATERIAL_PARAMETER_EXT = 0x81B9
        IndexMaterialParameterExt = 33209,
        //
        // Resumo:
        //     Original was GL_INDEX_MATERIAL_FACE_EXT = 0x81BA
        IndexMaterialFaceExt = 33210,
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
        //     Original was GL_WRAP_BORDER_SUN = 0x81D4
        WrapBorderSun = 33236,
        //
        // Resumo:
        //     Original was GL_UNPACK_CONSTANT_DATA_SUNX = 0x81D5
        UnpackConstantDataSunx = 33237,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CONSTANT_DATA_SUNX = 0x81D6
        TextureConstantDataSunx = 33238,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_LIST_SUN = 0x81D7
        TriangleListSun = 33239,
        //
        // Resumo:
        //     Original was GL_REPLACEMENT_CODE_SUN = 0x81D8
        ReplacementCodeSun = 33240,
        //
        // Resumo:
        //     Original was GL_GLOBAL_ALPHA_SUN = 0x81D9
        GlobalAlphaSun = 33241,
        //
        // Resumo:
        //     Original was GL_GLOBAL_ALPHA_FACTOR_SUN = 0x81DA
        GlobalAlphaFactorSun = 33242,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF
        TextureColorWritemaskSgis = 33263,
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
        //     Original was GL_TEXT_FRAGMENT_SHADER_ATI = 0x8200
        TextFragmentShaderAti = 33280,
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
        //     Original was GL_YCRCB_SGIX = 0x8318
        YcrcbSgix = 33560,
        //
        // Resumo:
        //     Original was GL_YCRCBA_SGIX = 0x8319
        YcrcbaSgix = 33561,
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
        //     Original was GL_PIXEL_TRANSFORM_2D_EXT = 0x8330
        PixelTransform2DExt = 33584,
        //
        // Resumo:
        //     Original was GL_PIXEL_MAG_FILTER_EXT = 0x8331
        PixelMagFilterExt = 33585,
        //
        // Resumo:
        //     Original was GL_PIXEL_MIN_FILTER_EXT = 0x8332
        PixelMinFilterExt = 33586,
        //
        // Resumo:
        //     Original was GL_PIXEL_CUBIC_WEIGHT_EXT = 0x8333
        PixelCubicWeightExt = 33587,
        //
        // Resumo:
        //     Original was GL_CUBIC_EXT = 0x8334
        CubicExt = 33588,
        //
        // Resumo:
        //     Original was GL_AVERAGE_EXT = 0x8335
        AverageExt = 33589,
        //
        // Resumo:
        //     Original was GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336
        PixelTransform2DStackDepthExt = 33590,
        //
        // Resumo:
        //     Original was GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337
        MaxPixelTransform2DStackDepthExt = 33591,
        //
        // Resumo:
        //     Original was GL_PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338
        PixelTransform2DMatrixExt = 33592,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_MATERIAL_EXT = 0x8349
        FragmentMaterialExt = 33609,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_NORMAL_EXT = 0x834A
        FragmentNormalExt = 33610,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_COLOR_EXT = 0x834C
        FragmentColorExt = 33612,
        //
        // Resumo:
        //     Original was GL_ATTENUATION_EXT = 0x834D
        AttenuationExt = 33613,
        //
        // Resumo:
        //     Original was GL_SHADOW_ATTENUATION_EXT = 0x834E
        ShadowAttenuationExt = 33614,
        //
        // Resumo:
        //     Original was GL_TEXTURE_APPLICATION_MODE_EXT = 0x834F
        TextureApplicationModeExt = 33615,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LIGHT_EXT = 0x8350
        TextureLightExt = 33616,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MATERIAL_FACE_EXT = 0x8351
        TextureMaterialFaceExt = 33617,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352
        TextureMaterialParameterExt = 33618,
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
        //     Original was GL_PIXEL_GROUP_COLOR_SGIS = 0x8356
        PixelGroupColorSgis = 33622,
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
        //     Original was GL_MIRRORED_REPEAT_IBM = 0x8370
        MirroredRepeatIbm = 33648,
        //
        // Resumo:
        //     Original was GL_RGB_S3TC = 0x83A0
        RgbS3tc = 33696,
        //
        // Resumo:
        //     Original was GL_RGB4_S3TC = 0x83A1
        Rgb4S3tc = 33697,
        //
        // Resumo:
        //     Original was GL_RGBA_S3TC = 0x83A2
        RgbaS3tc = 33698,
        //
        // Resumo:
        //     Original was GL_RGBA4_S3TC = 0x83A3
        Rgba4S3tc = 33699,
        //
        // Resumo:
        //     Original was GL_RGBA_DXT5_S3TC = 0x83A4
        RgbaDxt5S3tc = 33700,
        //
        // Resumo:
        //     Original was GL_RGBA4_DXT5_S3TC = 0x83A5
        Rgba4Dxt5S3tc = 33701,
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
        //     Original was GL_PARALLEL_ARRAYS_INTEL = 0x83F4
        ParallelArraysIntel = 33780,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5
        VertexArrayParallelPointersIntel = 33781,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6
        NormalArrayParallelPointersIntel = 33782,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7
        ColorArrayParallelPointersIntel = 33783,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8
        TextureCoordArrayParallelPointersIntel = 33784,
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
        //     Original was GL_TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF
        TextureMemoryLayoutIntel = 33791,
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
        //     Original was GL_CURRENT_RASTER_NORMAL_SGIX = 0x8406
        CurrentRasterNormalSgix = 33798,
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
        //     Original was GL_TANGENT_ARRAY_EXT = 0x8439
        TangentArrayExt = 33849,
        //
        // Resumo:
        //     Original was GL_BINORMAL_ARRAY_EXT = 0x843A
        BinormalArrayExt = 33850,
        //
        // Resumo:
        //     Original was GL_CURRENT_TANGENT_EXT = 0x843B
        CurrentTangentExt = 33851,
        //
        // Resumo:
        //     Original was GL_CURRENT_BINORMAL_EXT = 0x843C
        CurrentBinormalExt = 33852,
        //
        // Resumo:
        //     Original was GL_TANGENT_ARRAY_TYPE_EXT = 0x843E
        TangentArrayTypeExt = 33854,
        //
        // Resumo:
        //     Original was GL_TANGENT_ARRAY_STRIDE_EXT = 0x843F
        TangentArrayStrideExt = 33855,
        //
        // Resumo:
        //     Original was GL_BINORMAL_ARRAY_TYPE_EXT = 0x8440
        BinormalArrayTypeExt = 33856,
        //
        // Resumo:
        //     Original was GL_BINORMAL_ARRAY_STRIDE_EXT = 0x8441
        BinormalArrayStrideExt = 33857,
        //
        // Resumo:
        //     Original was GL_TANGENT_ARRAY_POINTER_EXT = 0x8442
        TangentArrayPointerExt = 33858,
        //
        // Resumo:
        //     Original was GL_BINORMAL_ARRAY_POINTER_EXT = 0x8443
        BinormalArrayPointerExt = 33859,
        //
        // Resumo:
        //     Original was GL_MAP1_TANGENT_EXT = 0x8444
        Map1TangentExt = 33860,
        //
        // Resumo:
        //     Original was GL_MAP2_TANGENT_EXT = 0x8445
        Map2TangentExt = 33861,
        //
        // Resumo:
        //     Original was GL_MAP1_BINORMAL_EXT = 0x8446
        Map1BinormalExt = 33862,
        //
        // Resumo:
        //     Original was GL_MAP2_BINORMAL_EXT = 0x8447
        Map2BinormalExt = 33863,
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
        //     Original was GL_FOG_COORDINATE_SOURCE = 0x8450
        FogCoordinateSource = 33872,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_SOURCE_EXT = 0x8450
        FogCoordinateSourceExt = 33872,
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
        //     Original was GL_FOG_COORDINATE = 0x8451
        FogCoordinate = 33873,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_EXT = 0x8451
        FogCoordinateExt = 33873,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_DEPTH = 0x8452
        FragmentDepth = 33874,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_DEPTH_EXT = 0x8452
        FragmentDepthExt = 33874,
        //
        // Resumo:
        //     Original was GL_CURRENT_FOG_COORD = 0x8453
        CurrentFogCoord = 33875,
        //
        // Resumo:
        //     Original was GL_CURRENT_FOG_COORDINATE = 0x8453
        CurrentFogCoordinate = 33875,
        //
        // Resumo:
        //     Original was GL_CURRENT_FOG_COORDINATE_EXT = 0x8453
        CurrentFogCoordinateExt = 33875,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_TYPE = 0x8454
        FogCoordArrayType = 33876,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454
        FogCoordinateArrayType = 33876,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454
        FogCoordinateArrayTypeExt = 33876,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_STRIDE = 0x8455
        FogCoordArrayStride = 33877,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455
        FogCoordinateArrayStride = 33877,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455
        FogCoordinateArrayStrideExt = 33877,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_POINTER = 0x8456
        FogCoordArrayPointer = 33878,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456
        FogCoordinateArrayPointer = 33878,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456
        FogCoordinateArrayPointerExt = 33878,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY = 0x8457
        FogCoordArray = 33879,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY = 0x8457
        FogCoordinateArray = 33879,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_EXT = 0x8457
        FogCoordinateArrayExt = 33879,
        //
        // Resumo:
        //     Original was GL_COLOR_SUM = 0x8458
        ColorSum = 33880,
        //
        // Resumo:
        //     Original was GL_COLOR_SUM_ARB = 0x8458
        ColorSumArb = 33880,
        //
        // Resumo:
        //     Original was GL_COLOR_SUM_EXT = 0x8458
        ColorSumExt = 33880,
        //
        // Resumo:
        //     Original was GL_CURRENT_SECONDARY_COLOR = 0x8459
        CurrentSecondaryColor = 33881,
        //
        // Resumo:
        //     Original was GL_CURRENT_SECONDARY_COLOR_EXT = 0x8459
        CurrentSecondaryColorExt = 33881,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A
        SecondaryColorArraySize = 33882,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A
        SecondaryColorArraySizeExt = 33882,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B
        SecondaryColorArrayType = 33883,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B
        SecondaryColorArrayTypeExt = 33883,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C
        SecondaryColorArrayStride = 33884,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C
        SecondaryColorArrayStrideExt = 33884,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D
        SecondaryColorArrayPointer = 33885,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D
        SecondaryColorArrayPointerExt = 33885,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY = 0x845E
        SecondaryColorArray = 33886,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_EXT = 0x845E
        SecondaryColorArrayExt = 33886,
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
        //     Original was GL_SCREEN_COORDINATES_REND = 0x8490
        ScreenCoordinatesRend = 33936,
        //
        // Resumo:
        //     Original was GL_INVERTED_SCREEN_W_REND = 0x8491
        InvertedScreenWRend = 33937,
        //
        // Resumo:
        //     Original was GL_TEXTURE0 = 0x84C0
        Texture0 = 33984,
        //
        // Resumo:
        //     Original was GL_TEXTURE0_ARB = 0x84C0
        Texture0Arb = 33984,
        //
        // Resumo:
        //     Original was GL_TEXTURE1 = 0x84C1
        Texture1 = 33985,
        //
        // Resumo:
        //     Original was GL_TEXTURE1_ARB = 0x84C1
        Texture1Arb = 33985,
        //
        // Resumo:
        //     Original was GL_TEXTURE2 = 0x84C2
        Texture2 = 33986,
        //
        // Resumo:
        //     Original was GL_TEXTURE2_ARB = 0x84C2
        Texture2Arb = 33986,
        //
        // Resumo:
        //     Original was GL_TEXTURE3 = 0x84C3
        Texture3 = 33987,
        //
        // Resumo:
        //     Original was GL_TEXTURE3_ARB = 0x84C3
        Texture3Arb = 33987,
        //
        // Resumo:
        //     Original was GL_TEXTURE4 = 0x84C4
        Texture4 = 33988,
        //
        // Resumo:
        //     Original was GL_TEXTURE4_ARB = 0x84C4
        Texture4Arb = 33988,
        //
        // Resumo:
        //     Original was GL_TEXTURE5 = 0x84C5
        Texture5 = 33989,
        //
        // Resumo:
        //     Original was GL_TEXTURE5_ARB = 0x84C5
        Texture5Arb = 33989,
        //
        // Resumo:
        //     Original was GL_TEXTURE6 = 0x84C6
        Texture6 = 33990,
        //
        // Resumo:
        //     Original was GL_TEXTURE6_ARB = 0x84C6
        Texture6Arb = 33990,
        //
        // Resumo:
        //     Original was GL_TEXTURE7 = 0x84C7
        Texture7 = 33991,
        //
        // Resumo:
        //     Original was GL_TEXTURE7_ARB = 0x84C7
        Texture7Arb = 33991,
        //
        // Resumo:
        //     Original was GL_TEXTURE8 = 0x84C8
        Texture8 = 33992,
        //
        // Resumo:
        //     Original was GL_TEXTURE8_ARB = 0x84C8
        Texture8Arb = 33992,
        //
        // Resumo:
        //     Original was GL_TEXTURE9 = 0x84C9
        Texture9 = 33993,
        //
        // Resumo:
        //     Original was GL_TEXTURE9_ARB = 0x84C9
        Texture9Arb = 33993,
        //
        // Resumo:
        //     Original was GL_TEXTURE10 = 0x84CA
        Texture10 = 33994,
        //
        // Resumo:
        //     Original was GL_TEXTURE10_ARB = 0x84CA
        Texture10Arb = 33994,
        //
        // Resumo:
        //     Original was GL_TEXTURE11 = 0x84CB
        Texture11 = 33995,
        //
        // Resumo:
        //     Original was GL_TEXTURE11_ARB = 0x84CB
        Texture11Arb = 33995,
        //
        // Resumo:
        //     Original was GL_TEXTURE12 = 0x84CC
        Texture12 = 33996,
        //
        // Resumo:
        //     Original was GL_TEXTURE12_ARB = 0x84CC
        Texture12Arb = 33996,
        //
        // Resumo:
        //     Original was GL_TEXTURE13 = 0x84CD
        Texture13 = 33997,
        //
        // Resumo:
        //     Original was GL_TEXTURE13_ARB = 0x84CD
        Texture13Arb = 33997,
        //
        // Resumo:
        //     Original was GL_TEXTURE14 = 0x84CE
        Texture14 = 33998,
        //
        // Resumo:
        //     Original was GL_TEXTURE14_ARB = 0x84CE
        Texture14Arb = 33998,
        //
        // Resumo:
        //     Original was GL_TEXTURE15 = 0x84CF
        Texture15 = 33999,
        //
        // Resumo:
        //     Original was GL_TEXTURE15_ARB = 0x84CF
        Texture15Arb = 33999,
        //
        // Resumo:
        //     Original was GL_TEXTURE16 = 0x84D0
        Texture16 = 34000,
        //
        // Resumo:
        //     Original was GL_TEXTURE16_ARB = 0x84D0
        Texture16Arb = 34000,
        //
        // Resumo:
        //     Original was GL_TEXTURE17 = 0x84D1
        Texture17 = 34001,
        //
        // Resumo:
        //     Original was GL_TEXTURE17_ARB = 0x84D1
        Texture17Arb = 34001,
        //
        // Resumo:
        //     Original was GL_TEXTURE18 = 0x84D2
        Texture18 = 34002,
        //
        // Resumo:
        //     Original was GL_TEXTURE18_ARB = 0x84D2
        Texture18Arb = 34002,
        //
        // Resumo:
        //     Original was GL_TEXTURE19 = 0x84D3
        Texture19 = 34003,
        //
        // Resumo:
        //     Original was GL_TEXTURE19_ARB = 0x84D3
        Texture19Arb = 34003,
        //
        // Resumo:
        //     Original was GL_TEXTURE20 = 0x84D4
        Texture20 = 34004,
        //
        // Resumo:
        //     Original was GL_TEXTURE20_ARB = 0x84D4
        Texture20Arb = 34004,
        //
        // Resumo:
        //     Original was GL_TEXTURE21 = 0x84D5
        Texture21 = 34005,
        //
        // Resumo:
        //     Original was GL_TEXTURE21_ARB = 0x84D5
        Texture21Arb = 34005,
        //
        // Resumo:
        //     Original was GL_TEXTURE22 = 0x84D6
        Texture22 = 34006,
        //
        // Resumo:
        //     Original was GL_TEXTURE22_ARB = 0x84D6
        Texture22Arb = 34006,
        //
        // Resumo:
        //     Original was GL_TEXTURE23 = 0x84D7
        Texture23 = 34007,
        //
        // Resumo:
        //     Original was GL_TEXTURE23_ARB = 0x84D7
        Texture23Arb = 34007,
        //
        // Resumo:
        //     Original was GL_TEXTURE24 = 0x84D8
        Texture24 = 34008,
        //
        // Resumo:
        //     Original was GL_TEXTURE24_ARB = 0x84D8
        Texture24Arb = 34008,
        //
        // Resumo:
        //     Original was GL_TEXTURE25 = 0x84D9
        Texture25 = 34009,
        //
        // Resumo:
        //     Original was GL_TEXTURE25_ARB = 0x84D9
        Texture25Arb = 34009,
        //
        // Resumo:
        //     Original was GL_TEXTURE26 = 0x84DA
        Texture26 = 34010,
        //
        // Resumo:
        //     Original was GL_TEXTURE26_ARB = 0x84DA
        Texture26Arb = 34010,
        //
        // Resumo:
        //     Original was GL_TEXTURE27 = 0x84DB
        Texture27 = 34011,
        //
        // Resumo:
        //     Original was GL_TEXTURE27_ARB = 0x84DB
        Texture27Arb = 34011,
        //
        // Resumo:
        //     Original was GL_TEXTURE28 = 0x84DC
        Texture28 = 34012,
        //
        // Resumo:
        //     Original was GL_TEXTURE28_ARB = 0x84DC
        Texture28Arb = 34012,
        //
        // Resumo:
        //     Original was GL_TEXTURE29 = 0x84DD
        Texture29 = 34013,
        //
        // Resumo:
        //     Original was GL_TEXTURE29_ARB = 0x84DD
        Texture29Arb = 34013,
        //
        // Resumo:
        //     Original was GL_TEXTURE30 = 0x84DE
        Texture30 = 34014,
        //
        // Resumo:
        //     Original was GL_TEXTURE30_ARB = 0x84DE
        Texture30Arb = 34014,
        //
        // Resumo:
        //     Original was GL_TEXTURE31 = 0x84DF
        Texture31 = 34015,
        //
        // Resumo:
        //     Original was GL_TEXTURE31_ARB = 0x84DF
        Texture31Arb = 34015,
        //
        // Resumo:
        //     Original was GL_ACTIVE_TEXTURE = 0x84E0
        ActiveTexture = 34016,
        //
        // Resumo:
        //     Original was GL_ACTIVE_TEXTURE_ARB = 0x84E0
        ActiveTextureArb = 34016,
        //
        // Resumo:
        //     Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        ClientActiveTexture = 34017,
        //
        // Resumo:
        //     Original was GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1
        ClientActiveTextureArb = 34017,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_UNITS = 0x84E2
        MaxTextureUnits = 34018,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_UNITS_ARB = 0x84E2
        MaxTextureUnitsArb = 34018,
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
        //     Original was GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3
        TransposeModelviewMatrixArb = 34019,
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
        //     Original was GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4
        TransposeProjectionMatrixArb = 34020,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5
        TransposeTextureMatrix = 34021,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5
        TransposeTextureMatrixArb = 34021,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_COLOR_MATRIX = 0x84E6
        TransposeColorMatrix = 34022,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6
        TransposeColorMatrixArb = 34022,
        //
        // Resumo:
        //     Original was GL_SUBTRACT = 0x84E7
        Subtract = 34023,
        //
        // Resumo:
        //     Original was GL_SUBTRACT_ARB = 0x84E7
        SubtractArb = 34023,
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
        //     Original was GL_COMPRESSED_ALPHA_ARB = 0x84E9
        CompressedAlphaArb = 34025,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_LUMINANCE = 0x84EA
        CompressedLuminance = 34026,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_LUMINANCE_ARB = 0x84EA
        CompressedLuminanceArb = 34026,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB
        CompressedLuminanceAlpha = 34027,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB
        CompressedLuminanceAlphaArb = 34027,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_INTENSITY = 0x84EC
        CompressedIntensity = 34028,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_INTENSITY_ARB = 0x84EC
        CompressedIntensityArb = 34028,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB = 0x84ED
        CompressedRgb = 34029,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_ARB = 0x84ED
        CompressedRgbArb = 34029,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA = 0x84EE
        CompressedRgba = 34030,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_ARB = 0x84EE
        CompressedRgbaArb = 34030,
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
        //     Original was GL_ALL_COMPLETED_NV = 0x84F2
        AllCompletedNv = 34034,
        //
        // Resumo:
        //     Original was GL_FENCE_STATUS_NV = 0x84F3
        FenceStatusNv = 34035,
        //
        // Resumo:
        //     Original was GL_FENCE_CONDITION_NV = 0x84F4
        FenceConditionNv = 34036,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RECTANGLE = 0x84F5
        TextureRectangle = 34037,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RECTANGLE_ARB = 0x84F5
        TextureRectangleArb = 34037,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RECTANGLE_NV = 0x84F5
        TextureRectangleNv = 34037,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_RECTANGLE = 0x84F6
        TextureBindingRectangle = 34038,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6
        TextureBindingRectangleArb = 34038,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_RECTANGLE_NV = 0x84F6
        TextureBindingRectangleNv = 34038,
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
        //     Original was GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8
        MaxRectangleTextureSizeArb = 34040,
        //
        // Resumo:
        //     Original was GL_MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8
        MaxRectangleTextureSizeNv = 34040,
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
        //     Original was GL_UNSIGNED_INT_24_8_EXT = 0x84FA
        UnsignedInt248Ext = 34042,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_24_8_NV = 0x84FA
        UnsignedInt248Nv = 34042,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_LOD_BIAS = 0x84FD
        MaxTextureLodBias = 34045,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD
        MaxTextureLodBiasExt = 34045,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_ANISOTROPY = 0x84FE
        TextureMaxAnisotropy = 34046,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        TextureMaxAnisotropyExt = 34046,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF
        MaxTextureMaxAnisotropy = 34047,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        MaxTextureMaxAnisotropyExt = 34047,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FILTER_CONTROL = 0x8500
        TextureFilterControl = 34048,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500
        TextureFilterControlExt = 34048,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LOD_BIAS = 0x8501
        TextureLodBias = 34049,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LOD_BIAS_EXT = 0x8501
        TextureLodBiasExt = 34049,
        //
        // Resumo:
        //     Original was GL_MODELVIEW1_STACK_DEPTH_EXT = 0x8502
        Modelview1StackDepthExt = 34050,
        //
        // Resumo:
        //     Original was GL_COMBINE4_NV = 0x8503
        Combine4Nv = 34051,
        //
        // Resumo:
        //     Original was GL_MAX_SHININESS_NV = 0x8504
        MaxShininessNv = 34052,
        //
        // Resumo:
        //     Original was GL_MAX_SPOT_EXPONENT_NV = 0x8505
        MaxSpotExponentNv = 34053,
        //
        // Resumo:
        //     Original was GL_MODELVIEW1_MATRIX_EXT = 0x8506
        Modelview1MatrixExt = 34054,
        //
        // Resumo:
        //     Original was GL_INCR_WRAP = 0x8507
        IncrWrap = 34055,
        //
        // Resumo:
        //     Original was GL_INCR_WRAP_EXT = 0x8507
        IncrWrapExt = 34055,
        //
        // Resumo:
        //     Original was GL_DECR_WRAP = 0x8508
        DecrWrap = 34056,
        //
        // Resumo:
        //     Original was GL_DECR_WRAP_EXT = 0x8508
        DecrWrapExt = 34056,
        //
        // Resumo:
        //     Original was GL_VERTEX_WEIGHTING_EXT = 0x8509
        VertexWeightingExt = 34057,
        //
        // Resumo:
        //     Original was GL_MODELVIEW1_ARB = 0x850A
        Modelview1Arb = 34058,
        //
        // Resumo:
        //     Original was GL_MODELVIEW1_EXT = 0x850A
        Modelview1Ext = 34058,
        //
        // Resumo:
        //     Original was GL_CURRENT_VERTEX_WEIGHT_EXT = 0x850B
        CurrentVertexWeightExt = 34059,
        //
        // Resumo:
        //     Original was GL_VERTEX_WEIGHT_ARRAY_EXT = 0x850C
        VertexWeightArrayExt = 34060,
        //
        // Resumo:
        //     Original was GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D
        VertexWeightArraySizeExt = 34061,
        //
        // Resumo:
        //     Original was GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E
        VertexWeightArrayTypeExt = 34062,
        //
        // Resumo:
        //     Original was GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F
        VertexWeightArrayStrideExt = 34063,
        //
        // Resumo:
        //     Original was GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510
        VertexWeightArrayPointerExt = 34064,
        //
        // Resumo:
        //     Original was GL_NORMAL_MAP = 0x8511
        NormalMap = 34065,
        //
        // Resumo:
        //     Original was GL_NORMAL_MAP_ARB = 0x8511
        NormalMapArb = 34065,
        //
        // Resumo:
        //     Original was GL_NORMAL_MAP_EXT = 0x8511
        NormalMapExt = 34065,
        //
        // Resumo:
        //     Original was GL_NORMAL_MAP_NV = 0x8511
        NormalMapNv = 34065,
        //
        // Resumo:
        //     Original was GL_REFLECTION_MAP = 0x8512
        ReflectionMap = 34066,
        //
        // Resumo:
        //     Original was GL_REFLECTION_MAP_ARB = 0x8512
        ReflectionMapArb = 34066,
        //
        // Resumo:
        //     Original was GL_REFLECTION_MAP_EXT = 0x8512
        ReflectionMapExt = 34066,
        //
        // Resumo:
        //     Original was GL_REFLECTION_MAP_NV = 0x8512
        ReflectionMapNv = 34066,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP = 0x8513
        TextureCubeMap = 34067,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_ARB = 0x8513
        TextureCubeMapArb = 34067,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_EXT = 0x8513
        TextureCubeMapExt = 34067,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        TextureBindingCubeMap = 34068,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514
        TextureBindingCubeMapArb = 34068,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514
        TextureBindingCubeMapExt = 34068,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        TextureCubeMapPositiveX = 34069,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515
        TextureCubeMapPositiveXArb = 34069,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515
        TextureCubeMapPositiveXExt = 34069,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        TextureCubeMapNegativeX = 34070,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516
        TextureCubeMapNegativeXArb = 34070,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516
        TextureCubeMapNegativeXExt = 34070,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        TextureCubeMapPositiveY = 34071,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517
        TextureCubeMapPositiveYArb = 34071,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517
        TextureCubeMapPositiveYExt = 34071,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        TextureCubeMapNegativeY = 34072,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518
        TextureCubeMapNegativeYArb = 34072,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518
        TextureCubeMapNegativeYExt = 34072,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        TextureCubeMapPositiveZ = 34073,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519
        TextureCubeMapPositiveZArb = 34073,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519
        TextureCubeMapPositiveZExt = 34073,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        TextureCubeMapNegativeZ = 34074,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A
        TextureCubeMapNegativeZArb = 34074,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A
        TextureCubeMapNegativeZExt = 34074,
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
        //     Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C
        MaxCubeMapTextureSizeArb = 34076,
        //
        // Resumo:
        //     Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C
        MaxCubeMapTextureSizeExt = 34076,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_RANGE_APPLE = 0x851D
        VertexArrayRangeApple = 34077,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_RANGE_NV = 0x851D
        VertexArrayRangeNv = 34077,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E
        VertexArrayRangeLengthApple = 34078,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E
        VertexArrayRangeLengthNv = 34078,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_RANGE_VALID_NV = 0x851F
        VertexArrayRangeValidNv = 34079,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        VertexArrayStorageHintApple = 34079,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520
        MaxVertexArrayRangeElementNv = 34080,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521
        VertexArrayRangePointerApple = 34081,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521
        VertexArrayRangePointerNv = 34081,
        //
        // Resumo:
        //     Original was GL_REGISTER_COMBINERS_NV = 0x8522
        RegisterCombinersNv = 34082,
        //
        // Resumo:
        //     Original was GL_VARIABLE_A_NV = 0x8523
        VariableANv = 34083,
        //
        // Resumo:
        //     Original was GL_VARIABLE_B_NV = 0x8524
        VariableBNv = 34084,
        //
        // Resumo:
        //     Original was GL_VARIABLE_C_NV = 0x8525
        VariableCNv = 34085,
        //
        // Resumo:
        //     Original was GL_VARIABLE_D_NV = 0x8526
        VariableDNv = 34086,
        //
        // Resumo:
        //     Original was GL_VARIABLE_E_NV = 0x8527
        VariableENv = 34087,
        //
        // Resumo:
        //     Original was GL_VARIABLE_F_NV = 0x8528
        VariableFNv = 34088,
        //
        // Resumo:
        //     Original was GL_VARIABLE_G_NV = 0x8529
        VariableGNv = 34089,
        //
        // Resumo:
        //     Original was GL_CONSTANT_COLOR0_NV = 0x852A
        ConstantColor0Nv = 34090,
        //
        // Resumo:
        //     Original was GL_CONSTANT_COLOR1_NV = 0x852B
        ConstantColor1Nv = 34091,
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
        //     Original was GL_SPARE0_NV = 0x852E
        Spare0Nv = 34094,
        //
        // Resumo:
        //     Original was GL_SPARE1_NV = 0x852F
        Spare1Nv = 34095,
        //
        // Resumo:
        //     Original was GL_DISCARD_NV = 0x8530
        DiscardNv = 34096,
        //
        // Resumo:
        //     Original was GL_E_TIMES_F_NV = 0x8531
        ETimesFNv = 34097,
        //
        // Resumo:
        //     Original was GL_SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532
        Spare0PlusSecondaryColorNv = 34098,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533
        VertexArrayRangeWithoutFlushNv = 34099,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        MultisampleFilterHintNv = 34100,
        //
        // Resumo:
        //     Original was GL_PER_STAGE_CONSTANTS_NV = 0x8535
        PerStageConstantsNv = 34101,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_IDENTITY_NV = 0x8536
        UnsignedIdentityNv = 34102,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INVERT_NV = 0x8537
        UnsignedInvertNv = 34103,
        //
        // Resumo:
        //     Original was GL_EXPAND_NORMAL_NV = 0x8538
        ExpandNormalNv = 34104,
        //
        // Resumo:
        //     Original was GL_EXPAND_NEGATE_NV = 0x8539
        ExpandNegateNv = 34105,
        //
        // Resumo:
        //     Original was GL_HALF_BIAS_NORMAL_NV = 0x853A
        HalfBiasNormalNv = 34106,
        //
        // Resumo:
        //     Original was GL_HALF_BIAS_NEGATE_NV = 0x853B
        HalfBiasNegateNv = 34107,
        //
        // Resumo:
        //     Original was GL_SIGNED_IDENTITY_NV = 0x853C
        SignedIdentityNv = 34108,
        //
        // Resumo:
        //     Original was GL_SIGNED_NEGATE_NV = 0x853D
        SignedNegateNv = 34109,
        //
        // Resumo:
        //     Original was GL_SCALE_BY_TWO_NV = 0x853E
        ScaleByTwoNv = 34110,
        //
        // Resumo:
        //     Original was GL_SCALE_BY_FOUR_NV = 0x853F
        ScaleByFourNv = 34111,
        //
        // Resumo:
        //     Original was GL_SCALE_BY_ONE_HALF_NV = 0x8540
        ScaleByOneHalfNv = 34112,
        //
        // Resumo:
        //     Original was GL_BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541
        BiasByNegativeOneHalfNv = 34113,
        //
        // Resumo:
        //     Original was GL_COMBINER_INPUT_NV = 0x8542
        CombinerInputNv = 34114,
        //
        // Resumo:
        //     Original was GL_COMBINER_MAPPING_NV = 0x8543
        CombinerMappingNv = 34115,
        //
        // Resumo:
        //     Original was GL_COMBINER_COMPONENT_USAGE_NV = 0x8544
        CombinerComponentUsageNv = 34116,
        //
        // Resumo:
        //     Original was GL_COMBINER_AB_DOT_PRODUCT_NV = 0x8545
        CombinerAbDotProductNv = 34117,
        //
        // Resumo:
        //     Original was GL_COMBINER_CD_DOT_PRODUCT_NV = 0x8546
        CombinerCdDotProductNv = 34118,
        //
        // Resumo:
        //     Original was GL_COMBINER_MUX_SUM_NV = 0x8547
        CombinerMuxSumNv = 34119,
        //
        // Resumo:
        //     Original was GL_COMBINER_SCALE_NV = 0x8548
        CombinerScaleNv = 34120,
        //
        // Resumo:
        //     Original was GL_COMBINER_BIAS_NV = 0x8549
        CombinerBiasNv = 34121,
        //
        // Resumo:
        //     Original was GL_COMBINER_AB_OUTPUT_NV = 0x854A
        CombinerAbOutputNv = 34122,
        //
        // Resumo:
        //     Original was GL_COMBINER_CD_OUTPUT_NV = 0x854B
        CombinerCdOutputNv = 34123,
        //
        // Resumo:
        //     Original was GL_COMBINER_SUM_OUTPUT_NV = 0x854C
        CombinerSumOutputNv = 34124,
        //
        // Resumo:
        //     Original was GL_MAX_GENERAL_COMBINERS_NV = 0x854D
        MaxGeneralCombinersNv = 34125,
        //
        // Resumo:
        //     Original was GL_NUM_GENERAL_COMBINERS_NV = 0x854E
        NumGeneralCombinersNv = 34126,
        //
        // Resumo:
        //     Original was GL_COLOR_SUM_CLAMP_NV = 0x854F
        ColorSumClampNv = 34127,
        //
        // Resumo:
        //     Original was GL_COMBINER0_NV = 0x8550
        Combiner0Nv = 34128,
        //
        // Resumo:
        //     Original was GL_COMBINER1_NV = 0x8551
        Combiner1Nv = 34129,
        //
        // Resumo:
        //     Original was GL_COMBINER2_NV = 0x8552
        Combiner2Nv = 34130,
        //
        // Resumo:
        //     Original was GL_COMBINER3_NV = 0x8553
        Combiner3Nv = 34131,
        //
        // Resumo:
        //     Original was GL_COMBINER4_NV = 0x8554
        Combiner4Nv = 34132,
        //
        // Resumo:
        //     Original was GL_COMBINER5_NV = 0x8555
        Combiner5Nv = 34133,
        //
        // Resumo:
        //     Original was GL_COMBINER6_NV = 0x8556
        Combiner6Nv = 34134,
        //
        // Resumo:
        //     Original was GL_COMBINER7_NV = 0x8557
        Combiner7Nv = 34135,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_RESTART_NV = 0x8558
        PrimitiveRestartNv = 34136,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_RESTART_INDEX_NV = 0x8559
        PrimitiveRestartIndexNv = 34137,
        //
        // Resumo:
        //     Original was GL_FOG_DISTANCE_MODE_NV = 0x855A
        FogDistanceModeNv = 34138,
        //
        // Resumo:
        //     Original was GL_EYE_RADIAL_NV = 0x855B
        EyeRadialNv = 34139,
        //
        // Resumo:
        //     Original was GL_EYE_PLANE_ABSOLUTE_NV = 0x855C
        EyePlaneAbsoluteNv = 34140,
        //
        // Resumo:
        //     Original was GL_EMBOSS_LIGHT_NV = 0x855D
        EmbossLightNv = 34141,
        //
        // Resumo:
        //     Original was GL_EMBOSS_CONSTANT_NV = 0x855E
        EmbossConstantNv = 34142,
        //
        // Resumo:
        //     Original was GL_EMBOSS_MAP_NV = 0x855F
        EmbossMapNv = 34143,
        //
        // Resumo:
        //     Original was GL_RED_MIN_CLAMP_INGR = 0x8560
        RedMinClampIngr = 34144,
        //
        // Resumo:
        //     Original was GL_GREEN_MIN_CLAMP_INGR = 0x8561
        GreenMinClampIngr = 34145,
        //
        // Resumo:
        //     Original was GL_BLUE_MIN_CLAMP_INGR = 0x8562
        BlueMinClampIngr = 34146,
        //
        // Resumo:
        //     Original was GL_ALPHA_MIN_CLAMP_INGR = 0x8563
        AlphaMinClampIngr = 34147,
        //
        // Resumo:
        //     Original was GL_RED_MAX_CLAMP_INGR = 0x8564
        RedMaxClampIngr = 34148,
        //
        // Resumo:
        //     Original was GL_GREEN_MAX_CLAMP_INGR = 0x8565
        GreenMaxClampIngr = 34149,
        //
        // Resumo:
        //     Original was GL_BLUE_MAX_CLAMP_INGR = 0x8566
        BlueMaxClampIngr = 34150,
        //
        // Resumo:
        //     Original was GL_ALPHA_MAX_CLAMP_INGR = 0x8567
        AlphaMaxClampIngr = 34151,
        //
        // Resumo:
        //     Original was GL_INTERLACE_READ_INGR = 0x8568
        InterlaceReadIngr = 34152,
        //
        // Resumo:
        //     Original was GL_COMBINE = 0x8570
        Combine = 34160,
        //
        // Resumo:
        //     Original was GL_COMBINE_ARB = 0x8570
        CombineArb = 34160,
        //
        // Resumo:
        //     Original was GL_COMBINE_EXT = 0x8570
        CombineExt = 34160,
        //
        // Resumo:
        //     Original was GL_COMBINE_RGB = 0x8571
        CombineRgb = 34161,
        //
        // Resumo:
        //     Original was GL_COMBINE_RGB_ARB = 0x8571
        CombineRgbArb = 34161,
        //
        // Resumo:
        //     Original was GL_COMBINE_RGB_EXT = 0x8571
        CombineRgbExt = 34161,
        //
        // Resumo:
        //     Original was GL_COMBINE_ALPHA = 0x8572
        CombineAlpha = 34162,
        //
        // Resumo:
        //     Original was GL_COMBINE_ALPHA_ARB = 0x8572
        CombineAlphaArb = 34162,
        //
        // Resumo:
        //     Original was GL_COMBINE_ALPHA_EXT = 0x8572
        CombineAlphaExt = 34162,
        //
        // Resumo:
        //     Original was GL_RGB_SCALE = 0x8573
        RgbScale = 34163,
        //
        // Resumo:
        //     Original was GL_RGB_SCALE_ARB = 0x8573
        RgbScaleArb = 34163,
        //
        // Resumo:
        //     Original was GL_RGB_SCALE_EXT = 0x8573
        RgbScaleExt = 34163,
        //
        // Resumo:
        //     Original was GL_ADD_SIGNED = 0x8574
        AddSigned = 34164,
        //
        // Resumo:
        //     Original was GL_ADD_SIGNED_ARB = 0x8574
        AddSignedArb = 34164,
        //
        // Resumo:
        //     Original was GL_ADD_SIGNED_EXT = 0x8574
        AddSignedExt = 34164,
        //
        // Resumo:
        //     Original was GL_INTERPOLATE = 0x8575
        Interpolate = 34165,
        //
        // Resumo:
        //     Original was GL_INTERPOLATE_ARB = 0x8575
        InterpolateArb = 34165,
        //
        // Resumo:
        //     Original was GL_INTERPOLATE_EXT = 0x8575
        InterpolateExt = 34165,
        //
        // Resumo:
        //     Original was GL_CONSTANT = 0x8576
        Constant = 34166,
        //
        // Resumo:
        //     Original was GL_CONSTANT_ARB = 0x8576
        ConstantArb = 34166,
        //
        // Resumo:
        //     Original was GL_CONSTANT_EXT = 0x8576
        ConstantExt = 34166,
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
        //     Original was GL_PRIMARY_COLOR_ARB = 0x8577
        PrimaryColorArb = 34167,
        //
        // Resumo:
        //     Original was GL_PRIMARY_COLOR_EXT = 0x8577
        PrimaryColorExt = 34167,
        //
        // Resumo:
        //     Original was GL_PREVIOUS = 0x8578
        Previous = 34168,
        //
        // Resumo:
        //     Original was GL_PREVIOUS_ARB = 0x8578
        PreviousArb = 34168,
        //
        // Resumo:
        //     Original was GL_PREVIOUS_EXT = 0x8578
        PreviousExt = 34168,
        //
        // Resumo:
        //     Original was GL_SOURCE0_RGB = 0x8580
        Source0Rgb = 34176,
        //
        // Resumo:
        //     Original was GL_SOURCE0_RGB_ARB = 0x8580
        Source0RgbArb = 34176,
        //
        // Resumo:
        //     Original was GL_SOURCE0_RGB_EXT = 0x8580
        Source0RgbExt = 34176,
        //
        // Resumo:
        //     Original was GL_SRC0_RGB = 0x8580
        Src0Rgb = 34176,
        //
        // Resumo:
        //     Original was GL_SOURCE1_RGB = 0x8581
        Source1Rgb = 34177,
        //
        // Resumo:
        //     Original was GL_SOURCE1_RGB_ARB = 0x8581
        Source1RgbArb = 34177,
        //
        // Resumo:
        //     Original was GL_SOURCE1_RGB_EXT = 0x8581
        Source1RgbExt = 34177,
        //
        // Resumo:
        //     Original was GL_SRC1_RGB = 0x8581
        Src1Rgb = 34177,
        //
        // Resumo:
        //     Original was GL_SOURCE2_RGB = 0x8582
        Source2Rgb = 34178,
        //
        // Resumo:
        //     Original was GL_SOURCE2_RGB_ARB = 0x8582
        Source2RgbArb = 34178,
        //
        // Resumo:
        //     Original was GL_SOURCE2_RGB_EXT = 0x8582
        Source2RgbExt = 34178,
        //
        // Resumo:
        //     Original was GL_SRC2_RGB = 0x8582
        Src2Rgb = 34178,
        //
        // Resumo:
        //     Original was GL_SOURCE3_RGB_NV = 0x8583
        Source3RgbNv = 34179,
        //
        // Resumo:
        //     Original was GL_SOURCE0_ALPHA = 0x8588
        Source0Alpha = 34184,
        //
        // Resumo:
        //     Original was GL_SOURCE0_ALPHA_ARB = 0x8588
        Source0AlphaArb = 34184,
        //
        // Resumo:
        //     Original was GL_SOURCE0_ALPHA_EXT = 0x8588
        Source0AlphaExt = 34184,
        //
        // Resumo:
        //     Original was GL_SRC0_ALPHA = 0x8588
        Src0Alpha = 34184,
        //
        // Resumo:
        //     Original was GL_SOURCE1_ALPHA = 0x8589
        Source1Alpha = 34185,
        //
        // Resumo:
        //     Original was GL_SOURCE1_ALPHA_ARB = 0x8589
        Source1AlphaArb = 34185,
        //
        // Resumo:
        //     Original was GL_SOURCE1_ALPHA_EXT = 0x8589
        Source1AlphaExt = 34185,
        //
        // Resumo:
        //     Original was GL_SRC1_ALPHA = 0x8589
        Src1Alpha = 34185,
        //
        // Resumo:
        //     Original was GL_SOURCE2_ALPHA = 0x858A
        Source2Alpha = 34186,
        //
        // Resumo:
        //     Original was GL_SOURCE2_ALPHA_ARB = 0x858A
        Source2AlphaArb = 34186,
        //
        // Resumo:
        //     Original was GL_SOURCE2_ALPHA_EXT = 0x858A
        Source2AlphaExt = 34186,
        //
        // Resumo:
        //     Original was GL_SRC2_ALPHA = 0x858A
        Src2Alpha = 34186,
        //
        // Resumo:
        //     Original was GL_SOURCE3_ALPHA_NV = 0x858B
        Source3AlphaNv = 34187,
        //
        // Resumo:
        //     Original was GL_OPERAND0_RGB = 0x8590
        Operand0Rgb = 34192,
        //
        // Resumo:
        //     Original was GL_OPERAND0_RGB_ARB = 0x8590
        Operand0RgbArb = 34192,
        //
        // Resumo:
        //     Original was GL_OPERAND0_RGB_EXT = 0x8590
        Operand0RgbExt = 34192,
        //
        // Resumo:
        //     Original was GL_OPERAND1_RGB = 0x8591
        Operand1Rgb = 34193,
        //
        // Resumo:
        //     Original was GL_OPERAND1_RGB_ARB = 0x8591
        Operand1RgbArb = 34193,
        //
        // Resumo:
        //     Original was GL_OPERAND1_RGB_EXT = 0x8591
        Operand1RgbExt = 34193,
        //
        // Resumo:
        //     Original was GL_OPERAND2_RGB = 0x8592
        Operand2Rgb = 34194,
        //
        // Resumo:
        //     Original was GL_OPERAND2_RGB_ARB = 0x8592
        Operand2RgbArb = 34194,
        //
        // Resumo:
        //     Original was GL_OPERAND2_RGB_EXT = 0x8592
        Operand2RgbExt = 34194,
        //
        // Resumo:
        //     Original was GL_OPERAND3_RGB_NV = 0x8593
        Operand3RgbNv = 34195,
        //
        // Resumo:
        //     Original was GL_OPERAND0_ALPHA = 0x8598
        Operand0Alpha = 34200,
        //
        // Resumo:
        //     Original was GL_OPERAND0_ALPHA_ARB = 0x8598
        Operand0AlphaArb = 34200,
        //
        // Resumo:
        //     Original was GL_OPERAND0_ALPHA_EXT = 0x8598
        Operand0AlphaExt = 34200,
        //
        // Resumo:
        //     Original was GL_OPERAND1_ALPHA = 0x8599
        Operand1Alpha = 34201,
        //
        // Resumo:
        //     Original was GL_OPERAND1_ALPHA_ARB = 0x8599
        Operand1AlphaArb = 34201,
        //
        // Resumo:
        //     Original was GL_OPERAND1_ALPHA_EXT = 0x8599
        Operand1AlphaExt = 34201,
        //
        // Resumo:
        //     Original was GL_OPERAND2_ALPHA = 0x859A
        Operand2Alpha = 34202,
        //
        // Resumo:
        //     Original was GL_OPERAND2_ALPHA_ARB = 0x859A
        Operand2AlphaArb = 34202,
        //
        // Resumo:
        //     Original was GL_OPERAND2_ALPHA_EXT = 0x859A
        Operand2AlphaExt = 34202,
        //
        // Resumo:
        //     Original was GL_OPERAND3_ALPHA_NV = 0x859B
        Operand3AlphaNv = 34203,
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
        //     Original was GL_PERTURB_EXT = 0x85AE
        PerturbExt = 34222,
        //
        // Resumo:
        //     Original was GL_TEXTURE_NORMAL_EXT = 0x85AF
        TextureNormalExt = 34223,
        //
        // Resumo:
        //     Original was GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0
        LightModelSpecularVectorApple = 34224,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        TransformHintApple = 34225,
        //
        // Resumo:
        //     Original was GL_UNPACK_CLIENT_STORAGE_APPLE = 0x85B2
        UnpackClientStorageApple = 34226,
        //
        // Resumo:
        //     Original was GL_BUFFER_OBJECT_APPLE = 0x85B3
        BufferObjectApple = 34227,
        //
        // Resumo:
        //     Original was GL_STORAGE_CLIENT_APPLE = 0x85B4
        StorageClientApple = 34228,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_BINDING = 0x85B5
        VertexArrayBinding = 34229,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_BINDING_APPLE = 0x85B5
        VertexArrayBindingApple = 34229,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RANGE_LENGTH_APPLE = 0x85B7
        TextureRangeLengthApple = 34231,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RANGE_POINTER_APPLE = 0x85B8
        TextureRangePointerApple = 34232,
        //
        // Resumo:
        //     Original was GL_YCBCR_422_APPLE = 0x85B9
        Ycbcr422Apple = 34233,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA
        UnsignedShort88Apple = 34234,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_8_8_MESA = 0x85BA
        UnsignedShort88Mesa = 34234,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB
        UnsignedShort88RevApple = 34235,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB
        UnsignedShort88RevMesa = 34235,
        //
        // Resumo:
        //     Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        TextureStorageHintApple = 34236,
        //
        // Resumo:
        //     Original was GL_STORAGE_PRIVATE_APPLE = 0x85BD
        StoragePrivateApple = 34237,
        //
        // Resumo:
        //     Original was GL_STORAGE_CACHED_APPLE = 0x85BE
        StorageCachedApple = 34238,
        //
        // Resumo:
        //     Original was GL_STORAGE_SHARED_APPLE = 0x85BF
        StorageSharedApple = 34239,
        //
        // Resumo:
        //     Original was GL_REPLACEMENT_CODE_ARRAY_SUN = 0x85C0
        ReplacementCodeArraySun = 34240,
        //
        // Resumo:
        //     Original was GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1
        ReplacementCodeArrayTypeSun = 34241,
        //
        // Resumo:
        //     Original was GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2
        ReplacementCodeArrayStrideSun = 34242,
        //
        // Resumo:
        //     Original was GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3
        ReplacementCodeArrayPointerSun = 34243,
        //
        // Resumo:
        //     Original was GL_R1UI_V3F_SUN = 0x85C4
        R1uiV3fSun = 34244,
        //
        // Resumo:
        //     Original was GL_R1UI_C4UB_V3F_SUN = 0x85C5
        R1uiC4ubV3fSun = 34245,
        //
        // Resumo:
        //     Original was GL_R1UI_C3F_V3F_SUN = 0x85C6
        R1uiC3fV3fSun = 34246,
        //
        // Resumo:
        //     Original was GL_R1UI_N3F_V3F_SUN = 0x85C7
        R1uiN3fV3fSun = 34247,
        //
        // Resumo:
        //     Original was GL_R1UI_C4F_N3F_V3F_SUN = 0x85C8
        R1uiC4fN3fV3fSun = 34248,
        //
        // Resumo:
        //     Original was GL_R1UI_T2F_V3F_SUN = 0x85C9
        R1uiT2fV3fSun = 34249,
        //
        // Resumo:
        //     Original was GL_R1UI_T2F_N3F_V3F_SUN = 0x85CA
        R1uiT2fN3fV3fSun = 34250,
        //
        // Resumo:
        //     Original was GL_R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB
        R1uiT2fC4fN3fV3fSun = 34251,
        //
        // Resumo:
        //     Original was GL_SLICE_ACCUM_SUN = 0x85CC
        SliceAccumSun = 34252,
        //
        // Resumo:
        //     Original was GL_QUAD_MESH_SUN = 0x8614
        QuadMeshSun = 34324,
        //
        // Resumo:
        //     Original was GL_TRIANGLE_MESH_SUN = 0x8615
        TriangleMeshSun = 34325,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM = 0x8620
        VertexProgram = 34336,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_ARB = 0x8620
        VertexProgramArb = 34336,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_NV = 0x8620
        VertexProgramNv = 34336,
        //
        // Resumo:
        //     Original was GL_VERTEX_STATE_PROGRAM_NV = 0x8621
        VertexStateProgramNv = 34337,
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
        //     Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622
        VertexAttribArrayEnabledArb = 34338,
        //
        // Resumo:
        //     Original was GL_ATTRIB_ARRAY_SIZE_NV = 0x8623
        AttribArraySizeNv = 34339,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        VertexAttribArraySize = 34339,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623
        VertexAttribArraySizeArb = 34339,
        //
        // Resumo:
        //     Original was GL_ATTRIB_ARRAY_STRIDE_NV = 0x8624
        AttribArrayStrideNv = 34340,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        VertexAttribArrayStride = 34340,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624
        VertexAttribArrayStrideArb = 34340,
        //
        // Resumo:
        //     Original was GL_ARRAY_TYPE = 0x8625
        ArrayType = 34341,
        //
        // Resumo:
        //     Original was GL_ATTRIB_ARRAY_TYPE_NV = 0x8625
        AttribArrayTypeNv = 34341,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        VertexAttribArrayType = 34341,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625
        VertexAttribArrayTypeArb = 34341,
        //
        // Resumo:
        //     Original was GL_CURRENT_ATTRIB_NV = 0x8626
        CurrentAttribNv = 34342,
        //
        // Resumo:
        //     Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        CurrentVertexAttrib = 34342,
        //
        // Resumo:
        //     Original was GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626
        CurrentVertexAttribArb = 34342,
        //
        // Resumo:
        //     Original was GL_PROGRAM_LENGTH = 0x8627
        ProgramLength = 34343,
        //
        // Resumo:
        //     Original was GL_PROGRAM_LENGTH_ARB = 0x8627
        ProgramLengthArb = 34343,
        //
        // Resumo:
        //     Original was GL_PROGRAM_LENGTH_NV = 0x8627
        ProgramLengthNv = 34343,
        //
        // Resumo:
        //     Original was GL_PROGRAM_STRING = 0x8628
        ProgramString = 34344,
        //
        // Resumo:
        //     Original was GL_PROGRAM_STRING_ARB = 0x8628
        ProgramStringArb = 34344,
        //
        // Resumo:
        //     Original was GL_PROGRAM_STRING_NV = 0x8628
        ProgramStringNv = 34344,
        //
        // Resumo:
        //     Original was GL_MODELVIEW_PROJECTION_NV = 0x8629
        ModelviewProjectionNv = 34345,
        //
        // Resumo:
        //     Original was GL_IDENTITY_NV = 0x862A
        IdentityNv = 34346,
        //
        // Resumo:
        //     Original was GL_INVERSE_NV = 0x862B
        InverseNv = 34347,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_NV = 0x862C
        TransposeNv = 34348,
        //
        // Resumo:
        //     Original was GL_INVERSE_TRANSPOSE_NV = 0x862D
        InverseTransposeNv = 34349,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E
        MaxProgramMatrixStackDepthArb = 34350,
        //
        // Resumo:
        //     Original was GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E
        MaxTrackMatrixStackDepthNv = 34350,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_MATRICES_ARB = 0x862F
        MaxProgramMatricesArb = 34351,
        //
        // Resumo:
        //     Original was GL_MAX_TRACK_MATRICES_NV = 0x862F
        MaxTrackMatricesNv = 34351,
        //
        // Resumo:
        //     Original was GL_MATRIX0_NV = 0x8630
        Matrix0Nv = 34352,
        //
        // Resumo:
        //     Original was GL_MATRIX1_NV = 0x8631
        Matrix1Nv = 34353,
        //
        // Resumo:
        //     Original was GL_MATRIX2_NV = 0x8632
        Matrix2Nv = 34354,
        //
        // Resumo:
        //     Original was GL_MATRIX3_NV = 0x8633
        Matrix3Nv = 34355,
        //
        // Resumo:
        //     Original was GL_MATRIX4_NV = 0x8634
        Matrix4Nv = 34356,
        //
        // Resumo:
        //     Original was GL_MATRIX5_NV = 0x8635
        Matrix5Nv = 34357,
        //
        // Resumo:
        //     Original was GL_MATRIX6_NV = 0x8636
        Matrix6Nv = 34358,
        //
        // Resumo:
        //     Original was GL_MATRIX7_NV = 0x8637
        Matrix7Nv = 34359,
        //
        // Resumo:
        //     Original was GL_CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640
        CurrentMatrixStackDepthArb = 34368,
        //
        // Resumo:
        //     Original was GL_CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640
        CurrentMatrixStackDepthNv = 34368,
        //
        // Resumo:
        //     Original was GL_CURRENT_MATRIX_ARB = 0x8641
        CurrentMatrixArb = 34369,
        //
        // Resumo:
        //     Original was GL_CURRENT_MATRIX_NV = 0x8641
        CurrentMatrixNv = 34369,
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
        //     Original was GL_PROGRAM_POINT_SIZE_EXT = 0x8642
        ProgramPointSizeExt = 34370,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642
        VertexProgramPointSize = 34370,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642
        VertexProgramPointSizeArb = 34370,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642
        VertexProgramPointSizeNv = 34370,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643
        VertexProgramTwoSide = 34371,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643
        VertexProgramTwoSideArb = 34371,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643
        VertexProgramTwoSideNv = 34371,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PARAMETER_NV = 0x8644
        ProgramParameterNv = 34372,
        //
        // Resumo:
        //     Original was GL_ARRAY_POINTER = 0x8645
        ArrayPointer = 34373,
        //
        // Resumo:
        //     Original was GL_ATTRIB_ARRAY_POINTER_NV = 0x8645
        AttribArrayPointerNv = 34373,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645
        VertexAttribArrayPointer = 34373,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645
        VertexAttribArrayPointerArb = 34373,
        //
        // Resumo:
        //     Original was GL_PROGRAM_TARGET_NV = 0x8646
        ProgramTargetNv = 34374,
        //
        // Resumo:
        //     Original was GL_PROGRAM_RESIDENT_NV = 0x8647
        ProgramResidentNv = 34375,
        //
        // Resumo:
        //     Original was GL_TRACK_MATRIX_NV = 0x8648
        TrackMatrixNv = 34376,
        //
        // Resumo:
        //     Original was GL_TRACK_MATRIX_TRANSFORM_NV = 0x8649
        TrackMatrixTransformNv = 34377,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_BINDING_NV = 0x864A
        VertexProgramBindingNv = 34378,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ERROR_POSITION_ARB = 0x864B
        ProgramErrorPositionArb = 34379,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ERROR_POSITION_NV = 0x864B
        ProgramErrorPositionNv = 34379,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_RECTANGLE_NV = 0x864C
        OffsetTextureRectangleNv = 34380,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D
        OffsetTextureRectangleScaleNv = 34381,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E
        DotProductTextureRectangleNv = 34382,
        //
        // Resumo:
        //     Original was GL_DEPTH_CLAMP = 0x864F
        DepthClamp = 34383,
        //
        // Resumo:
        //     Original was GL_DEPTH_CLAMP_NV = 0x864F
        DepthClampNv = 34383,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY0_NV = 0x8650
        VertexAttribArray0Nv = 34384,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY1_NV = 0x8651
        VertexAttribArray1Nv = 34385,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY2_NV = 0x8652
        VertexAttribArray2Nv = 34386,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY3_NV = 0x8653
        VertexAttribArray3Nv = 34387,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY4_NV = 0x8654
        VertexAttribArray4Nv = 34388,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY5_NV = 0x8655
        VertexAttribArray5Nv = 34389,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY6_NV = 0x8656
        VertexAttribArray6Nv = 34390,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY7_NV = 0x8657
        VertexAttribArray7Nv = 34391,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY8_NV = 0x8658
        VertexAttribArray8Nv = 34392,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY9_NV = 0x8659
        VertexAttribArray9Nv = 34393,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY10_NV = 0x865A
        VertexAttribArray10Nv = 34394,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY11_NV = 0x865B
        VertexAttribArray11Nv = 34395,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY12_NV = 0x865C
        VertexAttribArray12Nv = 34396,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY13_NV = 0x865D
        VertexAttribArray13Nv = 34397,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY14_NV = 0x865E
        VertexAttribArray14Nv = 34398,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY15_NV = 0x865F
        VertexAttribArray15Nv = 34399,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB0_4_NV = 0x8660
        Map1VertexAttrib04Nv = 34400,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB1_4_NV = 0x8661
        Map1VertexAttrib14Nv = 34401,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB2_4_NV = 0x8662
        Map1VertexAttrib24Nv = 34402,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB3_4_NV = 0x8663
        Map1VertexAttrib34Nv = 34403,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB4_4_NV = 0x8664
        Map1VertexAttrib44Nv = 34404,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB5_4_NV = 0x8665
        Map1VertexAttrib54Nv = 34405,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB6_4_NV = 0x8666
        Map1VertexAttrib64Nv = 34406,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB7_4_NV = 0x8667
        Map1VertexAttrib74Nv = 34407,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB8_4_NV = 0x8668
        Map1VertexAttrib84Nv = 34408,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB9_4_NV = 0x8669
        Map1VertexAttrib94Nv = 34409,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB10_4_NV = 0x866A
        Map1VertexAttrib104Nv = 34410,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB11_4_NV = 0x866B
        Map1VertexAttrib114Nv = 34411,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB12_4_NV = 0x866C
        Map1VertexAttrib124Nv = 34412,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB13_4_NV = 0x866D
        Map1VertexAttrib134Nv = 34413,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB14_4_NV = 0x866E
        Map1VertexAttrib144Nv = 34414,
        //
        // Resumo:
        //     Original was GL_MAP1_VERTEX_ATTRIB15_4_NV = 0x866F
        Map1VertexAttrib154Nv = 34415,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB0_4_NV = 0x8670
        Map2VertexAttrib04Nv = 34416,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB1_4_NV = 0x8671
        Map2VertexAttrib14Nv = 34417,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB2_4_NV = 0x8672
        Map2VertexAttrib24Nv = 34418,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB3_4_NV = 0x8673
        Map2VertexAttrib34Nv = 34419,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB4_4_NV = 0x8674
        Map2VertexAttrib44Nv = 34420,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB5_4_NV = 0x8675
        Map2VertexAttrib54Nv = 34421,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB6_4_NV = 0x8676
        Map2VertexAttrib64Nv = 34422,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB7_4_NV = 0x8677
        Map2VertexAttrib74Nv = 34423,
        //
        // Resumo:
        //     Original was GL_PROGRAM_BINDING = 0x8677
        ProgramBinding = 34423,
        //
        // Resumo:
        //     Original was GL_PROGRAM_BINDING_ARB = 0x8677
        ProgramBindingArb = 34423,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB8_4_NV = 0x8678
        Map2VertexAttrib84Nv = 34424,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB9_4_NV = 0x8679
        Map2VertexAttrib94Nv = 34425,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB10_4_NV = 0x867A
        Map2VertexAttrib104Nv = 34426,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB11_4_NV = 0x867B
        Map2VertexAttrib114Nv = 34427,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB12_4_NV = 0x867C
        Map2VertexAttrib124Nv = 34428,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB13_4_NV = 0x867D
        Map2VertexAttrib134Nv = 34429,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB14_4_NV = 0x867E
        Map2VertexAttrib144Nv = 34430,
        //
        // Resumo:
        //     Original was GL_MAP2_VERTEX_ATTRIB15_4_NV = 0x867F
        Map2VertexAttrib154Nv = 34431,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0
        TextureCompressedImageSize = 34464,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0
        TextureCompressedImageSizeArb = 34464,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED = 0x86A1
        TextureCompressed = 34465,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED_ARB = 0x86A1
        TextureCompressedArb = 34465,
        //
        // Resumo:
        //     Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        NumCompressedTextureFormats = 34466,
        //
        // Resumo:
        //     Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2
        NumCompressedTextureFormatsArb = 34466,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        CompressedTextureFormats = 34467,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3
        CompressedTextureFormatsArb = 34467,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_UNITS_ARB = 0x86A4
        MaxVertexUnitsArb = 34468,
        //
        // Resumo:
        //     Original was GL_ACTIVE_VERTEX_UNITS_ARB = 0x86A5
        ActiveVertexUnitsArb = 34469,
        //
        // Resumo:
        //     Original was GL_WEIGHT_SUM_UNITY_ARB = 0x86A6
        WeightSumUnityArb = 34470,
        //
        // Resumo:
        //     Original was GL_VERTEX_BLEND_ARB = 0x86A7
        VertexBlendArb = 34471,
        //
        // Resumo:
        //     Original was GL_CURRENT_WEIGHT_ARB = 0x86A8
        CurrentWeightArb = 34472,
        //
        // Resumo:
        //     Original was GL_WEIGHT_ARRAY_TYPE_ARB = 0x86A9
        WeightArrayTypeArb = 34473,
        //
        // Resumo:
        //     Original was GL_WEIGHT_ARRAY_STRIDE_ARB = 0x86AA
        WeightArrayStrideArb = 34474,
        //
        // Resumo:
        //     Original was GL_WEIGHT_ARRAY_SIZE_ARB = 0x86AB
        WeightArraySizeArb = 34475,
        //
        // Resumo:
        //     Original was GL_WEIGHT_ARRAY_POINTER_ARB = 0x86AC
        WeightArrayPointerArb = 34476,
        //
        // Resumo:
        //     Original was GL_WEIGHT_ARRAY_ARB = 0x86AD
        WeightArrayArb = 34477,
        //
        // Resumo:
        //     Original was GL_DOT3_RGB = 0x86AE
        Dot3Rgb = 34478,
        //
        // Resumo:
        //     Original was GL_DOT3_RGB_ARB = 0x86AE
        Dot3RgbArb = 34478,
        //
        // Resumo:
        //     Original was GL_DOT3_RGBA = 0x86AF
        Dot3Rgba = 34479,
        //
        // Resumo:
        //     Original was GL_DOT3_RGBA_ARB = 0x86AF
        Dot3RgbaArb = 34479,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_FXT1_3DFX = 0x86B0
        CompressedRgbFxt13Dfx = 34480,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA_FXT1_3DFX = 0x86B1
        CompressedRgbaFxt13Dfx = 34481,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_3DFX = 0x86B2
        Multisample3Dfx = 34482,
        //
        // Resumo:
        //     Original was GL_SAMPLE_BUFFERS_3DFX = 0x86B3
        SampleBuffers3Dfx = 34483,
        //
        // Resumo:
        //     Original was GL_SAMPLES_3DFX = 0x86B4
        Samples3Dfx = 34484,
        //
        // Resumo:
        //     Original was GL_EVAL_2D_NV = 0x86C0
        Eval2DNv = 34496,
        //
        // Resumo:
        //     Original was GL_EVAL_TRIANGULAR_2D_NV = 0x86C1
        EvalTriangular2DNv = 34497,
        //
        // Resumo:
        //     Original was GL_MAP_TESSELLATION_NV = 0x86C2
        MapTessellationNv = 34498,
        //
        // Resumo:
        //     Original was GL_MAP_ATTRIB_U_ORDER_NV = 0x86C3
        MapAttribUOrderNv = 34499,
        //
        // Resumo:
        //     Original was GL_MAP_ATTRIB_V_ORDER_NV = 0x86C4
        MapAttribVOrderNv = 34500,
        //
        // Resumo:
        //     Original was GL_EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5
        EvalFractionalTessellationNv = 34501,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB0_NV = 0x86C6
        EvalVertexAttrib0Nv = 34502,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB1_NV = 0x86C7
        EvalVertexAttrib1Nv = 34503,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB2_NV = 0x86C8
        EvalVertexAttrib2Nv = 34504,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB3_NV = 0x86C9
        EvalVertexAttrib3Nv = 34505,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB4_NV = 0x86CA
        EvalVertexAttrib4Nv = 34506,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB5_NV = 0x86CB
        EvalVertexAttrib5Nv = 34507,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB6_NV = 0x86CC
        EvalVertexAttrib6Nv = 34508,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB7_NV = 0x86CD
        EvalVertexAttrib7Nv = 34509,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB8_NV = 0x86CE
        EvalVertexAttrib8Nv = 34510,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB9_NV = 0x86CF
        EvalVertexAttrib9Nv = 34511,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB10_NV = 0x86D0
        EvalVertexAttrib10Nv = 34512,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB11_NV = 0x86D1
        EvalVertexAttrib11Nv = 34513,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB12_NV = 0x86D2
        EvalVertexAttrib12Nv = 34514,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB13_NV = 0x86D3
        EvalVertexAttrib13Nv = 34515,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB14_NV = 0x86D4
        EvalVertexAttrib14Nv = 34516,
        //
        // Resumo:
        //     Original was GL_EVAL_VERTEX_ATTRIB15_NV = 0x86D5
        EvalVertexAttrib15Nv = 34517,
        //
        // Resumo:
        //     Original was GL_MAX_MAP_TESSELLATION_NV = 0x86D6
        MaxMapTessellationNv = 34518,
        //
        // Resumo:
        //     Original was GL_MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7
        MaxRationalEvalOrderNv = 34519,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8
        MaxProgramPatchAttribsNv = 34520,
        //
        // Resumo:
        //     Original was GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9
        RgbaUnsignedDotProductMappingNv = 34521,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA
        UnsignedIntS8S888Nv = 34522,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB
        UnsignedInt88S8S8RevNv = 34523,
        //
        // Resumo:
        //     Original was GL_DSDT_MAG_INTENSITY_NV = 0x86DC
        DsdtMagIntensityNv = 34524,
        //
        // Resumo:
        //     Original was GL_SHADER_CONSISTENT_NV = 0x86DD
        ShaderConsistentNv = 34525,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SHADER_NV = 0x86DE
        TextureShaderNv = 34526,
        //
        // Resumo:
        //     Original was GL_SHADER_OPERATION_NV = 0x86DF
        ShaderOperationNv = 34527,
        //
        // Resumo:
        //     Original was GL_CULL_MODES_NV = 0x86E0
        CullModesNv = 34528,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_2D_MATRIX_NV = 0x86E1
        OffsetTexture2DMatrixNv = 34529,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1
        OffsetTextureMatrixNv = 34529,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_2D_SCALE_NV = 0x86E2
        OffsetTexture2DScaleNv = 34530,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2
        OffsetTextureScaleNv = 34530,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_2D_BIAS_NV = 0x86E3
        OffsetTexture2DBiasNv = 34531,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3
        OffsetTextureBiasNv = 34531,
        //
        // Resumo:
        //     Original was GL_PREVIOUS_TEXTURE_INPUT_NV = 0x86E4
        PreviousTextureInputNv = 34532,
        //
        // Resumo:
        //     Original was GL_CONST_EYE_NV = 0x86E5
        ConstEyeNv = 34533,
        //
        // Resumo:
        //     Original was GL_PASS_THROUGH_NV = 0x86E6
        PassThroughNv = 34534,
        //
        // Resumo:
        //     Original was GL_CULL_FRAGMENT_NV = 0x86E7
        CullFragmentNv = 34535,
        //
        // Resumo:
        //     Original was GL_OFFSET_TEXTURE_2D_NV = 0x86E8
        OffsetTexture2DNv = 34536,
        //
        // Resumo:
        //     Original was GL_DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9
        DependentArTexture2DNv = 34537,
        //
        // Resumo:
        //     Original was GL_DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA
        DependentGbTexture2DNv = 34538,
        //
        // Resumo:
        //     Original was GL_SURFACE_STATE_NV = 0x86EB
        SurfaceStateNv = 34539,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_NV = 0x86EC
        DotProductNv = 34540,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED
        DotProductDepthReplaceNv = 34541,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE
        DotProductTexture2DNv = 34542,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF
        DotProductTexture3DNv = 34543,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0
        DotProductTextureCubeMapNv = 34544,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1
        DotProductDiffuseCubeMapNv = 34545,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2
        DotProductReflectCubeMapNv = 34546,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3
        DotProductConstEyeReflectCubeMapNv = 34547,
        //
        // Resumo:
        //     Original was GL_HILO_NV = 0x86F4
        HiloNv = 34548,
        //
        // Resumo:
        //     Original was GL_DSDT_NV = 0x86F5
        DsdtNv = 34549,
        //
        // Resumo:
        //     Original was GL_DSDT_MAG_NV = 0x86F6
        DsdtMagNv = 34550,
        //
        // Resumo:
        //     Original was GL_DSDT_MAG_VIB_NV = 0x86F7
        DsdtMagVibNv = 34551,
        //
        // Resumo:
        //     Original was GL_HILO16_NV = 0x86F8
        Hilo16Nv = 34552,
        //
        // Resumo:
        //     Original was GL_SIGNED_HILO_NV = 0x86F9
        SignedHiloNv = 34553,
        //
        // Resumo:
        //     Original was GL_SIGNED_HILO16_NV = 0x86FA
        SignedHilo16Nv = 34554,
        //
        // Resumo:
        //     Original was GL_SIGNED_RGBA_NV = 0x86FB
        SignedRgbaNv = 34555,
        //
        // Resumo:
        //     Original was GL_SIGNED_RGBA8_NV = 0x86FC
        SignedRgba8Nv = 34556,
        //
        // Resumo:
        //     Original was GL_SURFACE_REGISTERED_NV = 0x86FD
        SurfaceRegisteredNv = 34557,
        //
        // Resumo:
        //     Original was GL_SIGNED_RGB_NV = 0x86FE
        SignedRgbNv = 34558,
        //
        // Resumo:
        //     Original was GL_SIGNED_RGB8_NV = 0x86FF
        SignedRgb8Nv = 34559,
        //
        // Resumo:
        //     Original was GL_SURFACE_MAPPED_NV = 0x8700
        SurfaceMappedNv = 34560,
        //
        // Resumo:
        //     Original was GL_SIGNED_LUMINANCE_NV = 0x8701
        SignedLuminanceNv = 34561,
        //
        // Resumo:
        //     Original was GL_SIGNED_LUMINANCE8_NV = 0x8702
        SignedLuminance8Nv = 34562,
        //
        // Resumo:
        //     Original was GL_SIGNED_LUMINANCE_ALPHA_NV = 0x8703
        SignedLuminanceAlphaNv = 34563,
        //
        // Resumo:
        //     Original was GL_SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704
        SignedLuminance8Alpha8Nv = 34564,
        //
        // Resumo:
        //     Original was GL_SIGNED_ALPHA_NV = 0x8705
        SignedAlphaNv = 34565,
        //
        // Resumo:
        //     Original was GL_SIGNED_ALPHA8_NV = 0x8706
        SignedAlpha8Nv = 34566,
        //
        // Resumo:
        //     Original was GL_SIGNED_INTENSITY_NV = 0x8707
        SignedIntensityNv = 34567,
        //
        // Resumo:
        //     Original was GL_SIGNED_INTENSITY8_NV = 0x8708
        SignedIntensity8Nv = 34568,
        //
        // Resumo:
        //     Original was GL_DSDT8_NV = 0x8709
        Dsdt8Nv = 34569,
        //
        // Resumo:
        //     Original was GL_DSDT8_MAG8_NV = 0x870A
        Dsdt8Mag8Nv = 34570,
        //
        // Resumo:
        //     Original was GL_DSDT8_MAG8_INTENSITY8_NV = 0x870B
        Dsdt8Mag8Intensity8Nv = 34571,
        //
        // Resumo:
        //     Original was GL_SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C
        SignedRgbUnsignedAlphaNv = 34572,
        //
        // Resumo:
        //     Original was GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D
        SignedRgb8UnsignedAlpha8Nv = 34573,
        //
        // Resumo:
        //     Original was GL_HI_SCALE_NV = 0x870E
        HiScaleNv = 34574,
        //
        // Resumo:
        //     Original was GL_LO_SCALE_NV = 0x870F
        LoScaleNv = 34575,
        //
        // Resumo:
        //     Original was GL_DS_SCALE_NV = 0x8710
        DsScaleNv = 34576,
        //
        // Resumo:
        //     Original was GL_DT_SCALE_NV = 0x8711
        DtScaleNv = 34577,
        //
        // Resumo:
        //     Original was GL_MAGNITUDE_SCALE_NV = 0x8712
        MagnitudeScaleNv = 34578,
        //
        // Resumo:
        //     Original was GL_VIBRANCE_SCALE_NV = 0x8713
        VibranceScaleNv = 34579,
        //
        // Resumo:
        //     Original was GL_HI_BIAS_NV = 0x8714
        HiBiasNv = 34580,
        //
        // Resumo:
        //     Original was GL_LO_BIAS_NV = 0x8715
        LoBiasNv = 34581,
        //
        // Resumo:
        //     Original was GL_DS_BIAS_NV = 0x8716
        DsBiasNv = 34582,
        //
        // Resumo:
        //     Original was GL_DT_BIAS_NV = 0x8717
        DtBiasNv = 34583,
        //
        // Resumo:
        //     Original was GL_MAGNITUDE_BIAS_NV = 0x8718
        MagnitudeBiasNv = 34584,
        //
        // Resumo:
        //     Original was GL_VIBRANCE_BIAS_NV = 0x8719
        VibranceBiasNv = 34585,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BORDER_VALUES_NV = 0x871A
        TextureBorderValuesNv = 34586,
        //
        // Resumo:
        //     Original was GL_TEXTURE_HI_SIZE_NV = 0x871B
        TextureHiSizeNv = 34587,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LO_SIZE_NV = 0x871C
        TextureLoSizeNv = 34588,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DS_SIZE_NV = 0x871D
        TextureDsSizeNv = 34589,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DT_SIZE_NV = 0x871E
        TextureDtSizeNv = 34590,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MAG_SIZE_NV = 0x871F
        TextureMagSizeNv = 34591,
        //
        // Resumo:
        //     Original was GL_MODELVIEW2_ARB = 0x8722
        Modelview2Arb = 34594,
        //
        // Resumo:
        //     Original was GL_MODELVIEW3_ARB = 0x8723
        Modelview3Arb = 34595,
        //
        // Resumo:
        //     Original was GL_MODELVIEW4_ARB = 0x8724
        Modelview4Arb = 34596,
        //
        // Resumo:
        //     Original was GL_MODELVIEW5_ARB = 0x8725
        Modelview5Arb = 34597,
        //
        // Resumo:
        //     Original was GL_MODELVIEW6_ARB = 0x8726
        Modelview6Arb = 34598,
        //
        // Resumo:
        //     Original was GL_MODELVIEW7_ARB = 0x8727
        Modelview7Arb = 34599,
        //
        // Resumo:
        //     Original was GL_MODELVIEW8_ARB = 0x8728
        Modelview8Arb = 34600,
        //
        // Resumo:
        //     Original was GL_MODELVIEW9_ARB = 0x8729
        Modelview9Arb = 34601,
        //
        // Resumo:
        //     Original was GL_MODELVIEW10_ARB = 0x872A
        Modelview10Arb = 34602,
        //
        // Resumo:
        //     Original was GL_MODELVIEW11_ARB = 0x872B
        Modelview11Arb = 34603,
        //
        // Resumo:
        //     Original was GL_MODELVIEW12_ARB = 0x872C
        Modelview12Arb = 34604,
        //
        // Resumo:
        //     Original was GL_MODELVIEW13_ARB = 0x872D
        Modelview13Arb = 34605,
        //
        // Resumo:
        //     Original was GL_MODELVIEW14_ARB = 0x872E
        Modelview14Arb = 34606,
        //
        // Resumo:
        //     Original was GL_MODELVIEW15_ARB = 0x872F
        Modelview15Arb = 34607,
        //
        // Resumo:
        //     Original was GL_MODELVIEW16_ARB = 0x8730
        Modelview16Arb = 34608,
        //
        // Resumo:
        //     Original was GL_MODELVIEW17_ARB = 0x8731
        Modelview17Arb = 34609,
        //
        // Resumo:
        //     Original was GL_MODELVIEW18_ARB = 0x8732
        Modelview18Arb = 34610,
        //
        // Resumo:
        //     Original was GL_MODELVIEW19_ARB = 0x8733
        Modelview19Arb = 34611,
        //
        // Resumo:
        //     Original was GL_MODELVIEW20_ARB = 0x8734
        Modelview20Arb = 34612,
        //
        // Resumo:
        //     Original was GL_MODELVIEW21_ARB = 0x8735
        Modelview21Arb = 34613,
        //
        // Resumo:
        //     Original was GL_MODELVIEW22_ARB = 0x8736
        Modelview22Arb = 34614,
        //
        // Resumo:
        //     Original was GL_MODELVIEW23_ARB = 0x8737
        Modelview23Arb = 34615,
        //
        // Resumo:
        //     Original was GL_MODELVIEW24_ARB = 0x8738
        Modelview24Arb = 34616,
        //
        // Resumo:
        //     Original was GL_MODELVIEW25_ARB = 0x8739
        Modelview25Arb = 34617,
        //
        // Resumo:
        //     Original was GL_MODELVIEW26_ARB = 0x873A
        Modelview26Arb = 34618,
        //
        // Resumo:
        //     Original was GL_MODELVIEW27_ARB = 0x873B
        Modelview27Arb = 34619,
        //
        // Resumo:
        //     Original was GL_MODELVIEW28_ARB = 0x873C
        Modelview28Arb = 34620,
        //
        // Resumo:
        //     Original was GL_MODELVIEW29_ARB = 0x873D
        Modelview29Arb = 34621,
        //
        // Resumo:
        //     Original was GL_MODELVIEW30_ARB = 0x873E
        Modelview30Arb = 34622,
        //
        // Resumo:
        //     Original was GL_MODELVIEW31_ARB = 0x873F
        Modelview31Arb = 34623,
        //
        // Resumo:
        //     Original was GL_DOT3_RGB_EXT = 0x8740
        Dot3RgbExt = 34624,
        //
        // Resumo:
        //     Original was GL_DOT3_RGBA_EXT = 0x8741
        Dot3RgbaExt = 34625,
        //
        // Resumo:
        //     Original was GL_PROGRAM_BINARY_LENGTH = 0x8741
        ProgramBinaryLength = 34625,
        //
        // Resumo:
        //     Original was GL_MIRROR_CLAMP_ATI = 0x8742
        MirrorClampAti = 34626,
        //
        // Resumo:
        //     Original was GL_MIRROR_CLAMP_EXT = 0x8742
        MirrorClampExt = 34626,
        //
        // Resumo:
        //     Original was GL_MIRROR_CLAMP_TO_EDGE = 0x8743
        MirrorClampToEdge = 34627,
        //
        // Resumo:
        //     Original was GL_MIRROR_CLAMP_TO_EDGE_ATI = 0x8743
        MirrorClampToEdgeAti = 34627,
        //
        // Resumo:
        //     Original was GL_MIRROR_CLAMP_TO_EDGE_EXT = 0x8743
        MirrorClampToEdgeExt = 34627,
        //
        // Resumo:
        //     Original was GL_MODULATE_ADD_ATI = 0x8744
        ModulateAddAti = 34628,
        //
        // Resumo:
        //     Original was GL_MODULATE_SIGNED_ADD_ATI = 0x8745
        ModulateSignedAddAti = 34629,
        //
        // Resumo:
        //     Original was GL_MODULATE_SUBTRACT_ATI = 0x8746
        ModulateSubtractAti = 34630,
        //
        // Resumo:
        //     Original was GL_SET_AMD = 0x874A
        SetAmd = 34634,
        //
        // Resumo:
        //     Original was GL_REPLACE_VALUE_AMD = 0x874B
        ReplaceValueAmd = 34635,
        //
        // Resumo:
        //     Original was GL_STENCIL_OP_VALUE_AMD = 0x874C
        StencilOpValueAmd = 34636,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_OP_VALUE_AMD = 0x874D
        StencilBackOpValueAmd = 34637,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
        VertexAttribArrayLong = 34638,
        //
        // Resumo:
        //     Original was GL_OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F
        OcclusionQueryEventMaskAmd = 34639,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_MESA = 0x8750
        DepthStencilMesa = 34640,
        //
        // Resumo:
        //     Original was GL_YCBCR_MESA = 0x8757
        YcbcrMesa = 34647,
        //
        // Resumo:
        //     Original was GL_PACK_INVERT_MESA = 0x8758
        PackInvertMesa = 34648,
        //
        // Resumo:
        //     Original was GL_TEXTURE_1D_STACK_MESAX = 0x8759
        Texture1DStackMesax = 34649,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_STACK_MESAX = 0x875A
        Texture2DStackMesax = 34650,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_1D_STACK_MESAX = 0x875B
        ProxyTexture1DStackMesax = 34651,
        //
        // Resumo:
        //     Original was GL_PROXY_TEXTURE_2D_STACK_MESAX = 0x875C
        ProxyTexture2DStackMesax = 34652,
        //
        // Resumo:
        //     Original was GL_TEXTURE_1D_STACK_BINDING_MESAX = 0x875D
        Texture1DStackBindingMesax = 34653,
        //
        // Resumo:
        //     Original was GL_TEXTURE_2D_STACK_BINDING_MESAX = 0x875E
        Texture2DStackBindingMesax = 34654,
        //
        // Resumo:
        //     Original was GL_PROGRAM_BINARY_FORMAT_MESA = 0x875F
        ProgramBinaryFormatMesa = 34655,
        //
        // Resumo:
        //     Original was GL_STATIC_ATI = 0x8760
        StaticAti = 34656,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_ATI = 0x8761
        DynamicAti = 34657,
        //
        // Resumo:
        //     Original was GL_PRESERVE_ATI = 0x8762
        PreserveAti = 34658,
        //
        // Resumo:
        //     Original was GL_DISCARD_ATI = 0x8763
        DiscardAti = 34659,
        //
        // Resumo:
        //     Original was GL_BUFFER_SIZE = 0x8764
        BufferSize = 34660,
        //
        // Resumo:
        //     Original was GL_BUFFER_SIZE_ARB = 0x8764
        BufferSizeArb = 34660,
        //
        // Resumo:
        //     Original was GL_OBJECT_BUFFER_SIZE_ATI = 0x8764
        ObjectBufferSizeAti = 34660,
        //
        // Resumo:
        //     Original was GL_BUFFER_USAGE = 0x8765
        BufferUsage = 34661,
        //
        // Resumo:
        //     Original was GL_BUFFER_USAGE_ARB = 0x8765
        BufferUsageArb = 34661,
        //
        // Resumo:
        //     Original was GL_OBJECT_BUFFER_USAGE_ATI = 0x8765
        ObjectBufferUsageAti = 34661,
        //
        // Resumo:
        //     Original was GL_ARRAY_OBJECT_BUFFER_ATI = 0x8766
        ArrayObjectBufferAti = 34662,
        //
        // Resumo:
        //     Original was GL_ARRAY_OBJECT_OFFSET_ATI = 0x8767
        ArrayObjectOffsetAti = 34663,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_ATI = 0x8768
        ElementArrayAti = 34664,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_TYPE_ATI = 0x8769
        ElementArrayTypeAti = 34665,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_POINTER_ATI = 0x876A
        ElementArrayPointerAti = 34666,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_STREAMS_ATI = 0x876B
        MaxVertexStreamsAti = 34667,
        //
        // Resumo:
        //     Original was GL_VERTEX_STREAM0_ATI = 0x876C
        VertexStream0Ati = 34668,
        //
        // Resumo:
        //     Original was GL_VERTEX_STREAM1_ATI = 0x876D
        VertexStream1Ati = 34669,
        //
        // Resumo:
        //     Original was GL_VERTEX_STREAM2_ATI = 0x876E
        VertexStream2Ati = 34670,
        //
        // Resumo:
        //     Original was GL_VERTEX_STREAM3_ATI = 0x876F
        VertexStream3Ati = 34671,
        //
        // Resumo:
        //     Original was GL_VERTEX_STREAM4_ATI = 0x8770
        VertexStream4Ati = 34672,
        //
        // Resumo:
        //     Original was GL_VERTEX_STREAM5_ATI = 0x8771
        VertexStream5Ati = 34673,
        //
        // Resumo:
        //     Original was GL_VERTEX_STREAM6_ATI = 0x8772
        VertexStream6Ati = 34674,
        //
        // Resumo:
        //     Original was GL_VERTEX_STREAM7_ATI = 0x8773
        VertexStream7Ati = 34675,
        //
        // Resumo:
        //     Original was GL_VERTEX_SOURCE_ATI = 0x8774
        VertexSourceAti = 34676,
        //
        // Resumo:
        //     Original was GL_BUMP_ROT_MATRIX_ATI = 0x8775
        BumpRotMatrixAti = 34677,
        //
        // Resumo:
        //     Original was GL_BUMP_ROT_MATRIX_SIZE_ATI = 0x8776
        BumpRotMatrixSizeAti = 34678,
        //
        // Resumo:
        //     Original was GL_BUMP_NUM_TEX_UNITS_ATI = 0x8777
        BumpNumTexUnitsAti = 34679,
        //
        // Resumo:
        //     Original was GL_BUMP_TEX_UNITS_ATI = 0x8778
        BumpTexUnitsAti = 34680,
        //
        // Resumo:
        //     Original was GL_DUDV_ATI = 0x8779
        DudvAti = 34681,
        //
        // Resumo:
        //     Original was GL_DU8DV8_ATI = 0x877A
        Du8Dv8Ati = 34682,
        //
        // Resumo:
        //     Original was GL_BUMP_ENVMAP_ATI = 0x877B
        BumpEnvmapAti = 34683,
        //
        // Resumo:
        //     Original was GL_BUMP_TARGET_ATI = 0x877C
        BumpTargetAti = 34684,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_EXT = 0x8780
        VertexShaderExt = 34688,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_BINDING_EXT = 0x8781
        VertexShaderBindingExt = 34689,
        //
        // Resumo:
        //     Original was GL_OP_INDEX_EXT = 0x8782
        OpIndexExt = 34690,
        //
        // Resumo:
        //     Original was GL_OP_NEGATE_EXT = 0x8783
        OpNegateExt = 34691,
        //
        // Resumo:
        //     Original was GL_OP_DOT3_EXT = 0x8784
        OpDot3Ext = 34692,
        //
        // Resumo:
        //     Original was GL_OP_DOT4_EXT = 0x8785
        OpDot4Ext = 34693,
        //
        // Resumo:
        //     Original was GL_OP_MUL_EXT = 0x8786
        OpMulExt = 34694,
        //
        // Resumo:
        //     Original was GL_OP_ADD_EXT = 0x8787
        OpAddExt = 34695,
        //
        // Resumo:
        //     Original was GL_OP_MADD_EXT = 0x8788
        OpMaddExt = 34696,
        //
        // Resumo:
        //     Original was GL_OP_FRAC_EXT = 0x8789
        OpFracExt = 34697,
        //
        // Resumo:
        //     Original was GL_OP_MAX_EXT = 0x878A
        OpMaxExt = 34698,
        //
        // Resumo:
        //     Original was GL_OP_MIN_EXT = 0x878B
        OpMinExt = 34699,
        //
        // Resumo:
        //     Original was GL_OP_SET_GE_EXT = 0x878C
        OpSetGeExt = 34700,
        //
        // Resumo:
        //     Original was GL_OP_SET_LT_EXT = 0x878D
        OpSetLtExt = 34701,
        //
        // Resumo:
        //     Original was GL_OP_CLAMP_EXT = 0x878E
        OpClampExt = 34702,
        //
        // Resumo:
        //     Original was GL_OP_FLOOR_EXT = 0x878F
        OpFloorExt = 34703,
        //
        // Resumo:
        //     Original was GL_OP_ROUND_EXT = 0x8790
        OpRoundExt = 34704,
        //
        // Resumo:
        //     Original was GL_OP_EXP_BASE_2_EXT = 0x8791
        OpExpBase2Ext = 34705,
        //
        // Resumo:
        //     Original was GL_OP_LOG_BASE_2_EXT = 0x8792
        OpLogBase2Ext = 34706,
        //
        // Resumo:
        //     Original was GL_OP_POWER_EXT = 0x8793
        OpPowerExt = 34707,
        //
        // Resumo:
        //     Original was GL_OP_RECIP_EXT = 0x8794
        OpRecipExt = 34708,
        //
        // Resumo:
        //     Original was GL_OP_RECIP_SQRT_EXT = 0x8795
        OpRecipSqrtExt = 34709,
        //
        // Resumo:
        //     Original was GL_OP_SUB_EXT = 0x8796
        OpSubExt = 34710,
        //
        // Resumo:
        //     Original was GL_OP_CROSS_PRODUCT_EXT = 0x8797
        OpCrossProductExt = 34711,
        //
        // Resumo:
        //     Original was GL_OP_MULTIPLY_MATRIX_EXT = 0x8798
        OpMultiplyMatrixExt = 34712,
        //
        // Resumo:
        //     Original was GL_OP_MOV_EXT = 0x8799
        OpMovExt = 34713,
        //
        // Resumo:
        //     Original was GL_OUTPUT_VERTEX_EXT = 0x879A
        OutputVertexExt = 34714,
        //
        // Resumo:
        //     Original was GL_OUTPUT_COLOR0_EXT = 0x879B
        OutputColor0Ext = 34715,
        //
        // Resumo:
        //     Original was GL_OUTPUT_COLOR1_EXT = 0x879C
        OutputColor1Ext = 34716,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD0_EXT = 0x879D
        OutputTextureCoord0Ext = 34717,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD1_EXT = 0x879E
        OutputTextureCoord1Ext = 34718,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD2_EXT = 0x879F
        OutputTextureCoord2Ext = 34719,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD3_EXT = 0x87A0
        OutputTextureCoord3Ext = 34720,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD4_EXT = 0x87A1
        OutputTextureCoord4Ext = 34721,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD5_EXT = 0x87A2
        OutputTextureCoord5Ext = 34722,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD6_EXT = 0x87A3
        OutputTextureCoord6Ext = 34723,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD7_EXT = 0x87A4
        OutputTextureCoord7Ext = 34724,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD8_EXT = 0x87A5
        OutputTextureCoord8Ext = 34725,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD9_EXT = 0x87A6
        OutputTextureCoord9Ext = 34726,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD10_EXT = 0x87A7
        OutputTextureCoord10Ext = 34727,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD11_EXT = 0x87A8
        OutputTextureCoord11Ext = 34728,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD12_EXT = 0x87A9
        OutputTextureCoord12Ext = 34729,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD13_EXT = 0x87AA
        OutputTextureCoord13Ext = 34730,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD14_EXT = 0x87AB
        OutputTextureCoord14Ext = 34731,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD15_EXT = 0x87AC
        OutputTextureCoord15Ext = 34732,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD16_EXT = 0x87AD
        OutputTextureCoord16Ext = 34733,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD17_EXT = 0x87AE
        OutputTextureCoord17Ext = 34734,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD18_EXT = 0x87AF
        OutputTextureCoord18Ext = 34735,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD19_EXT = 0x87B0
        OutputTextureCoord19Ext = 34736,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD20_EXT = 0x87B1
        OutputTextureCoord20Ext = 34737,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD21_EXT = 0x87B2
        OutputTextureCoord21Ext = 34738,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD22_EXT = 0x87B3
        OutputTextureCoord22Ext = 34739,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD23_EXT = 0x87B4
        OutputTextureCoord23Ext = 34740,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD24_EXT = 0x87B5
        OutputTextureCoord24Ext = 34741,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD25_EXT = 0x87B6
        OutputTextureCoord25Ext = 34742,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD26_EXT = 0x87B7
        OutputTextureCoord26Ext = 34743,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD27_EXT = 0x87B8
        OutputTextureCoord27Ext = 34744,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD28_EXT = 0x87B9
        OutputTextureCoord28Ext = 34745,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD29_EXT = 0x87BA
        OutputTextureCoord29Ext = 34746,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD30_EXT = 0x87BB
        OutputTextureCoord30Ext = 34747,
        //
        // Resumo:
        //     Original was GL_OUTPUT_TEXTURE_COORD31_EXT = 0x87BC
        OutputTextureCoord31Ext = 34748,
        //
        // Resumo:
        //     Original was GL_OUTPUT_FOG_EXT = 0x87BD
        OutputFogExt = 34749,
        //
        // Resumo:
        //     Original was GL_SCALAR_EXT = 0x87BE
        ScalarExt = 34750,
        //
        // Resumo:
        //     Original was GL_VECTOR_EXT = 0x87BF
        VectorExt = 34751,
        //
        // Resumo:
        //     Original was GL_MATRIX_EXT = 0x87C0
        MatrixExt = 34752,
        //
        // Resumo:
        //     Original was GL_VARIANT_EXT = 0x87C1
        VariantExt = 34753,
        //
        // Resumo:
        //     Original was GL_INVARIANT_EXT = 0x87C2
        InvariantExt = 34754,
        //
        // Resumo:
        //     Original was GL_LOCAL_CONSTANT_EXT = 0x87C3
        LocalConstantExt = 34755,
        //
        // Resumo:
        //     Original was GL_LOCAL_EXT = 0x87C4
        LocalExt = 34756,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5
        MaxVertexShaderInstructionsExt = 34757,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6
        MaxVertexShaderVariantsExt = 34758,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7
        MaxVertexShaderInvariantsExt = 34759,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8
        MaxVertexShaderLocalConstantsExt = 34760,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9
        MaxVertexShaderLocalsExt = 34761,
        //
        // Resumo:
        //     Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA
        MaxOptimizedVertexShaderInstructionsExt = 34762,
        //
        // Resumo:
        //     Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB
        MaxOptimizedVertexShaderVariantsExt = 34763,
        //
        // Resumo:
        //     Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC
        MaxOptimizedVertexShaderLocalConstantsExt = 34764,
        //
        // Resumo:
        //     Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD
        MaxOptimizedVertexShaderInvariantsExt = 34765,
        //
        // Resumo:
        //     Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE
        MaxOptimizedVertexShaderLocalsExt = 34766,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF
        VertexShaderInstructionsExt = 34767,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_VARIANTS_EXT = 0x87D0
        VertexShaderVariantsExt = 34768,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_INVARIANTS_EXT = 0x87D1
        VertexShaderInvariantsExt = 34769,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2
        VertexShaderLocalConstantsExt = 34770,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_LOCALS_EXT = 0x87D3
        VertexShaderLocalsExt = 34771,
        //
        // Resumo:
        //     Original was GL_VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4
        VertexShaderOptimizedExt = 34772,
        //
        // Resumo:
        //     Original was GL_X_EXT = 0x87D5
        XExt = 34773,
        //
        // Resumo:
        //     Original was GL_Y_EXT = 0x87D6
        YExt = 34774,
        //
        // Resumo:
        //     Original was GL_Z_EXT = 0x87D7
        ZExt = 34775,
        //
        // Resumo:
        //     Original was GL_W_EXT = 0x87D8
        WExt = 34776,
        //
        // Resumo:
        //     Original was GL_NEGATIVE_X_EXT = 0x87D9
        NegativeXExt = 34777,
        //
        // Resumo:
        //     Original was GL_NEGATIVE_Y_EXT = 0x87DA
        NegativeYExt = 34778,
        //
        // Resumo:
        //     Original was GL_NEGATIVE_Z_EXT = 0x87DB
        NegativeZExt = 34779,
        //
        // Resumo:
        //     Original was GL_NEGATIVE_W_EXT = 0x87DC
        NegativeWExt = 34780,
        //
        // Resumo:
        //     Original was GL_ZERO_EXT = 0x87DD
        ZeroExt = 34781,
        //
        // Resumo:
        //     Original was GL_ONE_EXT = 0x87DE
        OneExt = 34782,
        //
        // Resumo:
        //     Original was GL_NEGATIVE_ONE_EXT = 0x87DF
        NegativeOneExt = 34783,
        //
        // Resumo:
        //     Original was GL_NORMALIZED_RANGE_EXT = 0x87E0
        NormalizedRangeExt = 34784,
        //
        // Resumo:
        //     Original was GL_FULL_RANGE_EXT = 0x87E1
        FullRangeExt = 34785,
        //
        // Resumo:
        //     Original was GL_CURRENT_VERTEX_EXT = 0x87E2
        CurrentVertexExt = 34786,
        //
        // Resumo:
        //     Original was GL_MVP_MATRIX_EXT = 0x87E3
        MvpMatrixExt = 34787,
        //
        // Resumo:
        //     Original was GL_VARIANT_VALUE_EXT = 0x87E4
        VariantValueExt = 34788,
        //
        // Resumo:
        //     Original was GL_VARIANT_DATATYPE_EXT = 0x87E5
        VariantDatatypeExt = 34789,
        //
        // Resumo:
        //     Original was GL_VARIANT_ARRAY_STRIDE_EXT = 0x87E6
        VariantArrayStrideExt = 34790,
        //
        // Resumo:
        //     Original was GL_VARIANT_ARRAY_TYPE_EXT = 0x87E7
        VariantArrayTypeExt = 34791,
        //
        // Resumo:
        //     Original was GL_VARIANT_ARRAY_EXT = 0x87E8
        VariantArrayExt = 34792,
        //
        // Resumo:
        //     Original was GL_VARIANT_ARRAY_POINTER_EXT = 0x87E9
        VariantArrayPointerExt = 34793,
        //
        // Resumo:
        //     Original was GL_INVARIANT_VALUE_EXT = 0x87EA
        InvariantValueExt = 34794,
        //
        // Resumo:
        //     Original was GL_INVARIANT_DATATYPE_EXT = 0x87EB
        InvariantDatatypeExt = 34795,
        //
        // Resumo:
        //     Original was GL_LOCAL_CONSTANT_VALUE_EXT = 0x87EC
        LocalConstantValueExt = 34796,
        //
        // Resumo:
        //     Original was GL_LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED
        LocalConstantDatatypeExt = 34797,
        //
        // Resumo:
        //     Original was GL_PN_TRIANGLES_ATI = 0x87F0
        PnTrianglesAti = 34800,
        //
        // Resumo:
        //     Original was GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1
        MaxPnTrianglesTesselationLevelAti = 34801,
        //
        // Resumo:
        //     Original was GL_PN_TRIANGLES_POINT_MODE_ATI = 0x87F2
        PnTrianglesPointModeAti = 34802,
        //
        // Resumo:
        //     Original was GL_PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3
        PnTrianglesNormalModeAti = 34803,
        //
        // Resumo:
        //     Original was GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4
        PnTrianglesTesselationLevelAti = 34804,
        //
        // Resumo:
        //     Original was GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5
        PnTrianglesPointModeLinearAti = 34805,
        //
        // Resumo:
        //     Original was GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6
        PnTrianglesPointModeCubicAti = 34806,
        //
        // Resumo:
        //     Original was GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7
        PnTrianglesNormalModeLinearAti = 34807,
        //
        // Resumo:
        //     Original was GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8
        PnTrianglesNormalModeQuadraticAti = 34808,
        //
        // Resumo:
        //     Original was GL_VBO_FREE_MEMORY_ATI = 0x87FB
        VboFreeMemoryAti = 34811,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FREE_MEMORY_ATI = 0x87FC
        TextureFreeMemoryAti = 34812,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD
        RenderbufferFreeMemoryAti = 34813,
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
        //     Original was GL_STENCIL_BACK_FUNC_ATI = 0x8800
        StencilBackFuncAti = 34816,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_FAIL = 0x8801
        StencilBackFail = 34817,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_FAIL_ATI = 0x8801
        StencilBackFailAti = 34817,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802
        StencilBackPassDepthFail = 34818,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802
        StencilBackPassDepthFailAti = 34818,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803
        StencilBackPassDepthPass = 34819,
        //
        // Resumo:
        //     Original was GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803
        StencilBackPassDepthPassAti = 34819,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_PROGRAM = 0x8804
        FragmentProgram = 34820,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_PROGRAM_ARB = 0x8804
        FragmentProgramArb = 34820,
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
        //     Original was GL_RGBA_FLOAT32_APPLE = 0x8814
        RgbaFloat32Apple = 34836,
        //
        // Resumo:
        //     Original was GL_RGBA_FLOAT32_ATI = 0x8814
        RgbaFloat32Ati = 34836,
        //
        // Resumo:
        //     Original was GL_RGB32F = 0x8815
        Rgb32f = 34837,
        //
        // Resumo:
        //     Original was GL_RGB32F_ARB = 0x8815
        Rgb32fArb = 34837,
        //
        // Resumo:
        //     Original was GL_RGB_FLOAT32_APPLE = 0x8815
        RgbFloat32Apple = 34837,
        //
        // Resumo:
        //     Original was GL_RGB_FLOAT32_ATI = 0x8815
        RgbFloat32Ati = 34837,
        //
        // Resumo:
        //     Original was GL_ALPHA32F_ARB = 0x8816
        Alpha32fArb = 34838,
        //
        // Resumo:
        //     Original was GL_ALPHA_FLOAT32_APPLE = 0x8816
        AlphaFloat32Apple = 34838,
        //
        // Resumo:
        //     Original was GL_ALPHA_FLOAT32_ATI = 0x8816
        AlphaFloat32Ati = 34838,
        //
        // Resumo:
        //     Original was GL_INTENSITY32F_ARB = 0x8817
        Intensity32fArb = 34839,
        //
        // Resumo:
        //     Original was GL_INTENSITY_FLOAT32_APPLE = 0x8817
        IntensityFloat32Apple = 34839,
        //
        // Resumo:
        //     Original was GL_INTENSITY_FLOAT32_ATI = 0x8817
        IntensityFloat32Ati = 34839,
        //
        // Resumo:
        //     Original was GL_LUMINANCE32F_ARB = 0x8818
        Luminance32fArb = 34840,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_FLOAT32_APPLE = 0x8818
        LuminanceFloat32Apple = 34840,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_FLOAT32_ATI = 0x8818
        LuminanceFloat32Ati = 34840,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA32F_ARB = 0x8819
        LuminanceAlpha32fArb = 34841,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA_FLOAT32_APPLE = 0x8819
        LuminanceAlphaFloat32Apple = 34841,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819
        LuminanceAlphaFloat32Ati = 34841,
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
        //     Original was GL_RGBA_FLOAT16_APPLE = 0x881A
        RgbaFloat16Apple = 34842,
        //
        // Resumo:
        //     Original was GL_RGBA_FLOAT16_ATI = 0x881A
        RgbaFloat16Ati = 34842,
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
        //     Original was GL_RGB_FLOAT16_APPLE = 0x881B
        RgbFloat16Apple = 34843,
        //
        // Resumo:
        //     Original was GL_RGB_FLOAT16_ATI = 0x881B
        RgbFloat16Ati = 34843,
        //
        // Resumo:
        //     Original was GL_ALPHA16F_ARB = 0x881C
        Alpha16fArb = 34844,
        //
        // Resumo:
        //     Original was GL_ALPHA_FLOAT16_APPLE = 0x881C
        AlphaFloat16Apple = 34844,
        //
        // Resumo:
        //     Original was GL_ALPHA_FLOAT16_ATI = 0x881C
        AlphaFloat16Ati = 34844,
        //
        // Resumo:
        //     Original was GL_INTENSITY16F_ARB = 0x881D
        Intensity16fArb = 34845,
        //
        // Resumo:
        //     Original was GL_INTENSITY_FLOAT16_APPLE = 0x881D
        IntensityFloat16Apple = 34845,
        //
        // Resumo:
        //     Original was GL_INTENSITY_FLOAT16_ATI = 0x881D
        IntensityFloat16Ati = 34845,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16F_ARB = 0x881E
        Luminance16fArb = 34846,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_FLOAT16_APPLE = 0x881E
        LuminanceFloat16Apple = 34846,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_FLOAT16_ATI = 0x881E
        LuminanceFloat16Ati = 34846,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA16F_ARB = 0x881F
        LuminanceAlpha16fArb = 34847,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA_FLOAT16_APPLE = 0x881F
        LuminanceAlphaFloat16Apple = 34847,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F
        LuminanceAlphaFloat16Ati = 34847,
        //
        // Resumo:
        //     Original was GL_RGBA_FLOAT_MODE = 0x8820
        RgbaFloatMode = 34848,
        //
        // Resumo:
        //     Original was GL_RGBA_FLOAT_MODE_ARB = 0x8820
        RgbaFloatModeArb = 34848,
        //
        // Resumo:
        //     Original was GL_RGBA_FLOAT_MODE_ATI = 0x8820
        RgbaFloatModeAti = 34848,
        //
        // Resumo:
        //     Original was GL_MAX_DRAW_BUFFERS = 0x8824
        MaxDrawBuffers = 34852,
        //
        // Resumo:
        //     Original was GL_MAX_DRAW_BUFFERS_ARB = 0x8824
        MaxDrawBuffersArb = 34852,
        //
        // Resumo:
        //     Original was GL_MAX_DRAW_BUFFERS_ATI = 0x8824
        MaxDrawBuffersAti = 34852,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER0 = 0x8825
        DrawBuffer0 = 34853,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER0_ARB = 0x8825
        DrawBuffer0Arb = 34853,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER0_ATI = 0x8825
        DrawBuffer0Ati = 34853,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER1 = 0x8826
        DrawBuffer1 = 34854,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER1_ARB = 0x8826
        DrawBuffer1Arb = 34854,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER1_ATI = 0x8826
        DrawBuffer1Ati = 34854,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER2 = 0x8827
        DrawBuffer2 = 34855,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER2_ARB = 0x8827
        DrawBuffer2Arb = 34855,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER2_ATI = 0x8827
        DrawBuffer2Ati = 34855,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER3 = 0x8828
        DrawBuffer3 = 34856,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER3_ARB = 0x8828
        DrawBuffer3Arb = 34856,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER3_ATI = 0x8828
        DrawBuffer3Ati = 34856,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER4 = 0x8829
        DrawBuffer4 = 34857,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER4_ARB = 0x8829
        DrawBuffer4Arb = 34857,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER4_ATI = 0x8829
        DrawBuffer4Ati = 34857,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER5 = 0x882A
        DrawBuffer5 = 34858,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER5_ARB = 0x882A
        DrawBuffer5Arb = 34858,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER5_ATI = 0x882A
        DrawBuffer5Ati = 34858,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER6 = 0x882B
        DrawBuffer6 = 34859,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER6_ARB = 0x882B
        DrawBuffer6Arb = 34859,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER6_ATI = 0x882B
        DrawBuffer6Ati = 34859,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER7 = 0x882C
        DrawBuffer7 = 34860,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER7_ARB = 0x882C
        DrawBuffer7Arb = 34860,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER7_ATI = 0x882C
        DrawBuffer7Ati = 34860,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER8 = 0x882D
        DrawBuffer8 = 34861,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER8_ARB = 0x882D
        DrawBuffer8Arb = 34861,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER8_ATI = 0x882D
        DrawBuffer8Ati = 34861,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER9 = 0x882E
        DrawBuffer9 = 34862,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER9_ARB = 0x882E
        DrawBuffer9Arb = 34862,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER9_ATI = 0x882E
        DrawBuffer9Ati = 34862,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER10 = 0x882F
        DrawBuffer10 = 34863,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER10_ARB = 0x882F
        DrawBuffer10Arb = 34863,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER10_ATI = 0x882F
        DrawBuffer10Ati = 34863,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER11 = 0x8830
        DrawBuffer11 = 34864,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER11_ARB = 0x8830
        DrawBuffer11Arb = 34864,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER11_ATI = 0x8830
        DrawBuffer11Ati = 34864,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER12 = 0x8831
        DrawBuffer12 = 34865,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER12_ARB = 0x8831
        DrawBuffer12Arb = 34865,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER12_ATI = 0x8831
        DrawBuffer12Ati = 34865,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER13 = 0x8832
        DrawBuffer13 = 34866,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER13_ARB = 0x8832
        DrawBuffer13Arb = 34866,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER13_ATI = 0x8832
        DrawBuffer13Ati = 34866,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER14 = 0x8833
        DrawBuffer14 = 34867,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER14_ARB = 0x8833
        DrawBuffer14Arb = 34867,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER14_ATI = 0x8833
        DrawBuffer14Ati = 34867,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER15 = 0x8834
        DrawBuffer15 = 34868,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER15_ARB = 0x8834
        DrawBuffer15Arb = 34868,
        //
        // Resumo:
        //     Original was GL_DRAW_BUFFER15_ATI = 0x8834
        DrawBuffer15Ati = 34868,
        //
        // Resumo:
        //     Original was GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI = 0x8835
        ColorClearUnclampedValueAti = 34869,
        //
        // Resumo:
        //     Original was GL_BLEND_EQUATION_ALPHA = 0x883D
        BlendEquationAlpha = 34877,
        //
        // Resumo:
        //     Original was GL_BLEND_EQUATION_ALPHA_EXT = 0x883D
        BlendEquationAlphaExt = 34877,
        //
        // Resumo:
        //     Original was GL_SUBSAMPLE_DISTANCE_AMD = 0x883F
        SubsampleDistanceAmd = 34879,
        //
        // Resumo:
        //     Original was GL_MATRIX_PALETTE_ARB = 0x8840
        MatrixPaletteArb = 34880,
        //
        // Resumo:
        //     Original was GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841
        MaxMatrixPaletteStackDepthArb = 34881,
        //
        // Resumo:
        //     Original was GL_MAX_PALETTE_MATRICES_ARB = 0x8842
        MaxPaletteMatricesArb = 34882,
        //
        // Resumo:
        //     Original was GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843
        CurrentPaletteMatrixArb = 34883,
        //
        // Resumo:
        //     Original was GL_MATRIX_INDEX_ARRAY_ARB = 0x8844
        MatrixIndexArrayArb = 34884,
        //
        // Resumo:
        //     Original was GL_CURRENT_MATRIX_INDEX_ARB = 0x8845
        CurrentMatrixIndexArb = 34885,
        //
        // Resumo:
        //     Original was GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846
        MatrixIndexArraySizeArb = 34886,
        //
        // Resumo:
        //     Original was GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847
        MatrixIndexArrayTypeArb = 34887,
        //
        // Resumo:
        //     Original was GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848
        MatrixIndexArrayStrideArb = 34888,
        //
        // Resumo:
        //     Original was GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849
        MatrixIndexArrayPointerArb = 34889,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEPTH_SIZE = 0x884A
        TextureDepthSize = 34890,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEPTH_SIZE_ARB = 0x884A
        TextureDepthSizeArb = 34890,
        //
        // Resumo:
        //     Original was GL_DEPTH_TEXTURE_MODE = 0x884B
        DepthTextureMode = 34891,
        //
        // Resumo:
        //     Original was GL_DEPTH_TEXTURE_MODE_ARB = 0x884B
        DepthTextureModeArb = 34891,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        TextureCompareMode = 34892,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_MODE_ARB = 0x884C
        TextureCompareModeArb = 34892,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        TextureCompareFunc = 34893,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPARE_FUNC_ARB = 0x884D
        TextureCompareFuncArb = 34893,
        //
        // Resumo:
        //     Original was GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E
        CompareRefDepthToTextureExt = 34894,
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
        //     Original was GL_COMPARE_R_TO_TEXTURE_ARB = 0x884E
        CompareRToTextureArb = 34894,
        //
        // Resumo:
        //     Original was GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F
        TextureCubeMapSeamless = 34895,
        //
        // Resumo:
        //     Original was GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850
        OffsetProjectiveTexture2DNv = 34896,
        //
        // Resumo:
        //     Original was GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851
        OffsetProjectiveTexture2DScaleNv = 34897,
        //
        // Resumo:
        //     Original was GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852
        OffsetProjectiveTextureRectangleNv = 34898,
        //
        // Resumo:
        //     Original was GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853
        OffsetProjectiveTextureRectangleScaleNv = 34899,
        //
        // Resumo:
        //     Original was GL_OFFSET_HILO_TEXTURE_2D_NV = 0x8854
        OffsetHiloTexture2DNv = 34900,
        //
        // Resumo:
        //     Original was GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855
        OffsetHiloTextureRectangleNv = 34901,
        //
        // Resumo:
        //     Original was GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856
        OffsetHiloProjectiveTexture2DNv = 34902,
        //
        // Resumo:
        //     Original was GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857
        OffsetHiloProjectiveTextureRectangleNv = 34903,
        //
        // Resumo:
        //     Original was GL_DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858
        DependentHiloTexture2DNv = 34904,
        //
        // Resumo:
        //     Original was GL_DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859
        DependentRgbTexture3DNv = 34905,
        //
        // Resumo:
        //     Original was GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A
        DependentRgbTextureCubeMapNv = 34906,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_PASS_THROUGH_NV = 0x885B
        DotProductPassThroughNv = 34907,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_TEXTURE_1D_NV = 0x885C
        DotProductTexture1DNv = 34908,
        //
        // Resumo:
        //     Original was GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D
        DotProductAffineDepthReplaceNv = 34909,
        //
        // Resumo:
        //     Original was GL_HILO8_NV = 0x885E
        Hilo8Nv = 34910,
        //
        // Resumo:
        //     Original was GL_SIGNED_HILO8_NV = 0x885F
        SignedHilo8Nv = 34911,
        //
        // Resumo:
        //     Original was GL_FORCE_BLUE_TO_ONE_NV = 0x8860
        ForceBlueToOneNv = 34912,
        //
        // Resumo:
        //     Original was GL_POINT_SPRITE = 0x8861
        PointSprite = 34913,
        //
        // Resumo:
        //     Original was GL_POINT_SPRITE_ARB = 0x8861
        PointSpriteArb = 34913,
        //
        // Resumo:
        //     Original was GL_POINT_SPRITE_NV = 0x8861
        PointSpriteNv = 34913,
        //
        // Resumo:
        //     Original was GL_COORD_REPLACE = 0x8862
        CoordReplace = 34914,
        //
        // Resumo:
        //     Original was GL_COORD_REPLACE_ARB = 0x8862
        CoordReplaceArb = 34914,
        //
        // Resumo:
        //     Original was GL_COORD_REPLACE_NV = 0x8862
        CoordReplaceNv = 34914,
        //
        // Resumo:
        //     Original was GL_POINT_SPRITE_R_MODE_NV = 0x8863
        PointSpriteRModeNv = 34915,
        //
        // Resumo:
        //     Original was GL_PIXEL_COUNTER_BITS_NV = 0x8864
        PixelCounterBitsNv = 34916,
        //
        // Resumo:
        //     Original was GL_QUERY_COUNTER_BITS = 0x8864
        QueryCounterBits = 34916,
        //
        // Resumo:
        //     Original was GL_QUERY_COUNTER_BITS_ARB = 0x8864
        QueryCounterBitsArb = 34916,
        //
        // Resumo:
        //     Original was GL_CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865
        CurrentOcclusionQueryIdNv = 34917,
        //
        // Resumo:
        //     Original was GL_CURRENT_QUERY = 0x8865
        CurrentQuery = 34917,
        //
        // Resumo:
        //     Original was GL_CURRENT_QUERY_ARB = 0x8865
        CurrentQueryArb = 34917,
        //
        // Resumo:
        //     Original was GL_PIXEL_COUNT_NV = 0x8866
        PixelCountNv = 34918,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT = 0x8866
        QueryResult = 34918,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT_ARB = 0x8866
        QueryResultArb = 34918,
        //
        // Resumo:
        //     Original was GL_PIXEL_COUNT_AVAILABLE_NV = 0x8867
        PixelCountAvailableNv = 34919,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        QueryResultAvailable = 34919,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867
        QueryResultAvailableArb = 34919,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868
        MaxFragmentProgramLocalParametersNv = 34920,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATTRIBS = 0x8869
        MaxVertexAttribs = 34921,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869
        MaxVertexAttribsArb = 34921,
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
        //     Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A
        VertexAttribArrayNormalizedArb = 34922,
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
        //     Original was GL_DEPTH_STENCIL_TO_RGBA_NV = 0x886E
        DepthStencilToRgbaNv = 34926,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_TO_BGRA_NV = 0x886F
        DepthStencilToBgraNv = 34927,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_PROGRAM_NV = 0x8870
        FragmentProgramNv = 34928,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_COORDS = 0x8871
        MaxTextureCoords = 34929,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_COORDS_ARB = 0x8871
        MaxTextureCoordsArb = 34929,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_COORDS_NV = 0x8871
        MaxTextureCoordsNv = 34929,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872
        MaxTextureImageUnits = 34930,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872
        MaxTextureImageUnitsArb = 34930,
        //
        // Resumo:
        //     Original was GL_MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872
        MaxTextureImageUnitsNv = 34930,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_PROGRAM_BINDING_NV = 0x8873
        FragmentProgramBindingNv = 34931,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ERROR_STRING_ARB = 0x8874
        ProgramErrorStringArb = 34932,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ERROR_STRING_NV = 0x8874
        ProgramErrorStringNv = 34932,
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
        //     Original was GL_PROGRAM_FORMAT_ARB = 0x8876
        ProgramFormatArb = 34934,
        //
        // Resumo:
        //     Original was GL_WRITE_PIXEL_DATA_RANGE_NV = 0x8878
        WritePixelDataRangeNv = 34936,
        //
        // Resumo:
        //     Original was GL_READ_PIXEL_DATA_RANGE_NV = 0x8879
        ReadPixelDataRangeNv = 34937,
        //
        // Resumo:
        //     Original was GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A
        WritePixelDataRangeLengthNv = 34938,
        //
        // Resumo:
        //     Original was GL_READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B
        ReadPixelDataRangeLengthNv = 34939,
        //
        // Resumo:
        //     Original was GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C
        WritePixelDataRangePointerNv = 34940,
        //
        // Resumo:
        //     Original was GL_READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D
        ReadPixelDataRangePointerNv = 34941,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        GeometryShaderInvocations = 34943,
        //
        // Resumo:
        //     Original was GL_FLOAT_R_NV = 0x8880
        FloatRNv = 34944,
        //
        // Resumo:
        //     Original was GL_FLOAT_RG_NV = 0x8881
        FloatRgNv = 34945,
        //
        // Resumo:
        //     Original was GL_FLOAT_RGB_NV = 0x8882
        FloatRgbNv = 34946,
        //
        // Resumo:
        //     Original was GL_FLOAT_RGBA_NV = 0x8883
        FloatRgbaNv = 34947,
        //
        // Resumo:
        //     Original was GL_FLOAT_R16_NV = 0x8884
        FloatR16Nv = 34948,
        //
        // Resumo:
        //     Original was GL_FLOAT_R32_NV = 0x8885
        FloatR32Nv = 34949,
        //
        // Resumo:
        //     Original was GL_FLOAT_RG16_NV = 0x8886
        FloatRg16Nv = 34950,
        //
        // Resumo:
        //     Original was GL_FLOAT_RG32_NV = 0x8887
        FloatRg32Nv = 34951,
        //
        // Resumo:
        //     Original was GL_FLOAT_RGB16_NV = 0x8888
        FloatRgb16Nv = 34952,
        //
        // Resumo:
        //     Original was GL_FLOAT_RGB32_NV = 0x8889
        FloatRgb32Nv = 34953,
        //
        // Resumo:
        //     Original was GL_FLOAT_RGBA16_NV = 0x888A
        FloatRgba16Nv = 34954,
        //
        // Resumo:
        //     Original was GL_FLOAT_RGBA32_NV = 0x888B
        FloatRgba32Nv = 34955,
        //
        // Resumo:
        //     Original was GL_TEXTURE_FLOAT_COMPONENTS_NV = 0x888C
        TextureFloatComponentsNv = 34956,
        //
        // Resumo:
        //     Original was GL_FLOAT_CLEAR_COLOR_VALUE_NV = 0x888D
        FloatClearColorValueNv = 34957,
        //
        // Resumo:
        //     Original was GL_FLOAT_RGBA_MODE_NV = 0x888E
        FloatRgbaModeNv = 34958,
        //
        // Resumo:
        //     Original was GL_TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F
        TextureUnsignedRemapModeNv = 34959,
        //
        // Resumo:
        //     Original was GL_DEPTH_BOUNDS_TEST_EXT = 0x8890
        DepthBoundsTestExt = 34960,
        //
        // Resumo:
        //     Original was GL_DEPTH_BOUNDS_EXT = 0x8891
        DepthBoundsExt = 34961,
        //
        // Resumo:
        //     Original was GL_ARRAY_BUFFER = 0x8892
        ArrayBuffer = 34962,
        //
        // Resumo:
        //     Original was GL_ARRAY_BUFFER_ARB = 0x8892
        ArrayBufferArb = 34962,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        ElementArrayBuffer = 34963,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_BUFFER_ARB = 0x8893
        ElementArrayBufferArb = 34963,
        //
        // Resumo:
        //     Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        ArrayBufferBinding = 34964,
        //
        // Resumo:
        //     Original was GL_ARRAY_BUFFER_BINDING_ARB = 0x8894
        ArrayBufferBindingArb = 34964,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        ElementArrayBufferBinding = 34965,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895
        ElementArrayBufferBindingArb = 34965,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        VertexArrayBufferBinding = 34966,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896
        VertexArrayBufferBindingArb = 34966,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        NormalArrayBufferBinding = 34967,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897
        NormalArrayBufferBindingArb = 34967,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        ColorArrayBufferBinding = 34968,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898
        ColorArrayBufferBindingArb = 34968,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899
        IndexArrayBufferBinding = 34969,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899
        IndexArrayBufferBindingArb = 34969,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        TextureCoordArrayBufferBinding = 34970,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A
        TextureCoordArrayBufferBindingArb = 34970,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B
        EdgeFlagArrayBufferBinding = 34971,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B
        EdgeFlagArrayBufferBindingArb = 34971,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C
        SecondaryColorArrayBufferBinding = 34972,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C
        SecondaryColorArrayBufferBindingArb = 34972,
        //
        // Resumo:
        //     Original was GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D
        FogCoordArrayBufferBinding = 34973,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D
        FogCoordinateArrayBufferBinding = 34973,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D
        FogCoordinateArrayBufferBindingArb = 34973,
        //
        // Resumo:
        //     Original was GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E
        WeightArrayBufferBinding = 34974,
        //
        // Resumo:
        //     Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E
        WeightArrayBufferBindingArb = 34974,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        VertexAttribArrayBufferBinding = 34975,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F
        VertexAttribArrayBufferBindingArb = 34975,
        //
        // Resumo:
        //     Original was GL_PROGRAM_INSTRUCTION = 0x88A0
        ProgramInstruction = 34976,
        //
        // Resumo:
        //     Original was GL_PROGRAM_INSTRUCTIONS_ARB = 0x88A0
        ProgramInstructionsArb = 34976,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_INSTRUCTIONS = 0x88A1
        MaxProgramInstructions = 34977,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1
        MaxProgramInstructionsArb = 34977,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_INSTRUCTIONS = 0x88A2
        ProgramNativeInstructions = 34978,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2
        ProgramNativeInstructionsArb = 34978,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS = 0x88A3
        MaxProgramNativeInstructions = 34979,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3
        MaxProgramNativeInstructionsArb = 34979,
        //
        // Resumo:
        //     Original was GL_PROGRAM_TEMPORARIES = 0x88A4
        ProgramTemporaries = 34980,
        //
        // Resumo:
        //     Original was GL_PROGRAM_TEMPORARIES_ARB = 0x88A4
        ProgramTemporariesArb = 34980,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEMPORARIES = 0x88A5
        MaxProgramTemporaries = 34981,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5
        MaxProgramTemporariesArb = 34981,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_TEMPORARIES = 0x88A6
        ProgramNativeTemporaries = 34982,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6
        ProgramNativeTemporariesArb = 34982,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_TEMPORARIES = 0x88A7
        MaxProgramNativeTemporaries = 34983,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7
        MaxProgramNativeTemporariesArb = 34983,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PARAMETERS = 0x88A8
        ProgramParameters = 34984,
        //
        // Resumo:
        //     Original was GL_PROGRAM_PARAMETERS_ARB = 0x88A8
        ProgramParametersArb = 34984,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_PARAMETERS = 0x88A9
        MaxProgramParameters = 34985,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_PARAMETERS_ARB = 0x88A9
        MaxProgramParametersArb = 34985,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_PARAMETERS = 0x88AA
        ProgramNativeParameters = 34986,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA
        ProgramNativeParametersArb = 34986,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_PARAMETERS = 0x88AB
        MaxProgramNativeParameters = 34987,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB
        MaxProgramNativeParametersArb = 34987,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ATTRIBS = 0x88AC
        ProgramAttribs = 34988,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ATTRIBS_ARB = 0x88AC
        ProgramAttribsArb = 34988,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ATTRIBS = 0x88AD
        MaxProgramAttribs = 34989,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ATTRIBS_ARB = 0x88AD
        MaxProgramAttribsArb = 34989,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_ATTRIBS = 0x88AE
        ProgramNativeAttribs = 34990,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE
        ProgramNativeAttribsArb = 34990,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_ATTRIBS = 0x88AF
        MaxProgramNativeAttribs = 34991,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF
        MaxProgramNativeAttribsArb = 34991,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ADDRESS_REGISTERS = 0x88B0
        ProgramAddressRegisters = 34992,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0
        ProgramAddressRegistersArb = 34992,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ADDRESS_REGISTERS = 0x88B1
        MaxProgramAddressRegisters = 34993,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1
        MaxProgramAddressRegistersArb = 34993,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_ADDRESS_REGISTERS = 0x88B2
        ProgramNativeAddressRegisters = 34994,
        //
        // Resumo:
        //     Original was GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2
        ProgramNativeAddressRegistersArb = 34994,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS = 0x88B3
        MaxProgramNativeAddressRegisters = 34995,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3
        MaxProgramNativeAddressRegistersArb = 34995,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_LOCAL_PARAMETERS = 0x88B4
        MaxProgramLocalParameters = 34996,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4
        MaxProgramLocalParametersArb = 34996,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ENV_PARAMETERS = 0x88B5
        MaxProgramEnvParameters = 34997,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5
        MaxProgramEnvParametersArb = 34997,
        //
        // Resumo:
        //     Original was GL_PROGRAM_UNDER_NATIVE_LIMITS = 0x88B6
        ProgramUnderNativeLimits = 34998,
        //
        // Resumo:
        //     Original was GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6
        ProgramUnderNativeLimitsArb = 34998,
        //
        // Resumo:
        //     Original was GL_TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7
        TransposeCurrentMatrixArb = 34999,
        //
        // Resumo:
        //     Original was GL_READ_ONLY = 0x88B8
        ReadOnly = 35000,
        //
        // Resumo:
        //     Original was GL_READ_ONLY_ARB = 0x88B8
        ReadOnlyArb = 35000,
        //
        // Resumo:
        //     Original was GL_WRITE_ONLY = 0x88B9
        WriteOnly = 35001,
        //
        // Resumo:
        //     Original was GL_WRITE_ONLY_ARB = 0x88B9
        WriteOnlyArb = 35001,
        //
        // Resumo:
        //     Original was GL_READ_WRITE = 0x88BA
        ReadWrite = 35002,
        //
        // Resumo:
        //     Original was GL_READ_WRITE_ARB = 0x88BA
        ReadWriteArb = 35002,
        //
        // Resumo:
        //     Original was GL_BUFFER_ACCESS = 0x88BB
        BufferAccess = 35003,
        //
        // Resumo:
        //     Original was GL_BUFFER_ACCESS_ARB = 0x88BB
        BufferAccessArb = 35003,
        //
        // Resumo:
        //     Original was GL_BUFFER_MAPPED = 0x88BC
        BufferMapped = 35004,
        //
        // Resumo:
        //     Original was GL_BUFFER_MAPPED_ARB = 0x88BC
        BufferMappedArb = 35004,
        //
        // Resumo:
        //     Original was GL_BUFFER_MAP_POINTER = 0x88BD
        BufferMapPointer = 35005,
        //
        // Resumo:
        //     Original was GL_BUFFER_MAP_POINTER_ARB = 0x88BD
        BufferMapPointerArb = 35005,
        //
        // Resumo:
        //     Original was GL_WRITE_DISCARD_NV = 0x88BE
        WriteDiscardNv = 35006,
        //
        // Resumo:
        //     Original was GL_TIME_ELAPSED = 0x88BF
        TimeElapsed = 35007,
        //
        // Resumo:
        //     Original was GL_TIME_ELAPSED_EXT = 0x88BF
        TimeElapsedExt = 35007,
        //
        // Resumo:
        //     Original was GL_MATRIX0 = 0x88C0
        Matrix0 = 35008,
        //
        // Resumo:
        //     Original was GL_MATRIX0_ARB = 0x88C0
        Matrix0Arb = 35008,
        //
        // Resumo:
        //     Original was GL_MATRIX1 = 0x88C1
        Matrix1 = 35009,
        //
        // Resumo:
        //     Original was GL_MATRIX1_ARB = 0x88C1
        Matrix1Arb = 35009,
        //
        // Resumo:
        //     Original was GL_MATRIX2 = 0x88C2
        Matrix2 = 35010,
        //
        // Resumo:
        //     Original was GL_MATRIX2_ARB = 0x88C2
        Matrix2Arb = 35010,
        //
        // Resumo:
        //     Original was GL_MATRIX3 = 0x88C3
        Matrix3 = 35011,
        //
        // Resumo:
        //     Original was GL_MATRIX3_ARB = 0x88C3
        Matrix3Arb = 35011,
        //
        // Resumo:
        //     Original was GL_MATRIX4 = 0x88C4
        Matrix4 = 35012,
        //
        // Resumo:
        //     Original was GL_MATRIX4_ARB = 0x88C4
        Matrix4Arb = 35012,
        //
        // Resumo:
        //     Original was GL_MATRIX5 = 0x88C5
        Matrix5 = 35013,
        //
        // Resumo:
        //     Original was GL_MATRIX5_ARB = 0x88C5
        Matrix5Arb = 35013,
        //
        // Resumo:
        //     Original was GL_MATRIX6 = 0x88C6
        Matrix6 = 35014,
        //
        // Resumo:
        //     Original was GL_MATRIX6_ARB = 0x88C6
        Matrix6Arb = 35014,
        //
        // Resumo:
        //     Original was GL_MATRIX7 = 0x88C7
        Matrix7 = 35015,
        //
        // Resumo:
        //     Original was GL_MATRIX7_ARB = 0x88C7
        Matrix7Arb = 35015,
        //
        // Resumo:
        //     Original was GL_MATRIX8 = 0x88C8
        Matrix8 = 35016,
        //
        // Resumo:
        //     Original was GL_MATRIX8_ARB = 0x88C8
        Matrix8Arb = 35016,
        //
        // Resumo:
        //     Original was GL_MATRIX9 = 0x88C9
        Matrix9 = 35017,
        //
        // Resumo:
        //     Original was GL_MATRIX9_ARB = 0x88C9
        Matrix9Arb = 35017,
        //
        // Resumo:
        //     Original was GL_MATRIX10 = 0x88CA
        Matrix10 = 35018,
        //
        // Resumo:
        //     Original was GL_MATRIX10_ARB = 0x88CA
        Matrix10Arb = 35018,
        //
        // Resumo:
        //     Original was GL_MATRIX11 = 0x88CB
        Matrix11 = 35019,
        //
        // Resumo:
        //     Original was GL_MATRIX11_ARB = 0x88CB
        Matrix11Arb = 35019,
        //
        // Resumo:
        //     Original was GL_MATRIX12 = 0x88CC
        Matrix12 = 35020,
        //
        // Resumo:
        //     Original was GL_MATRIX12_ARB = 0x88CC
        Matrix12Arb = 35020,
        //
        // Resumo:
        //     Original was GL_MATRIX13 = 0x88CD
        Matrix13 = 35021,
        //
        // Resumo:
        //     Original was GL_MATRIX13_ARB = 0x88CD
        Matrix13Arb = 35021,
        //
        // Resumo:
        //     Original was GL_MATRIX14 = 0x88CE
        Matrix14 = 35022,
        //
        // Resumo:
        //     Original was GL_MATRIX14_ARB = 0x88CE
        Matrix14Arb = 35022,
        //
        // Resumo:
        //     Original was GL_MATRIX15 = 0x88CF
        Matrix15 = 35023,
        //
        // Resumo:
        //     Original was GL_MATRIX15_ARB = 0x88CF
        Matrix15Arb = 35023,
        //
        // Resumo:
        //     Original was GL_MATRIX16 = 0x88D0
        Matrix16 = 35024,
        //
        // Resumo:
        //     Original was GL_MATRIX16_ARB = 0x88D0
        Matrix16Arb = 35024,
        //
        // Resumo:
        //     Original was GL_MATRIX17 = 0x88D1
        Matrix17 = 35025,
        //
        // Resumo:
        //     Original was GL_MATRIX17_ARB = 0x88D1
        Matrix17Arb = 35025,
        //
        // Resumo:
        //     Original was GL_MATRIX18 = 0x88D2
        Matrix18 = 35026,
        //
        // Resumo:
        //     Original was GL_MATRIX18_ARB = 0x88D2
        Matrix18Arb = 35026,
        //
        // Resumo:
        //     Original was GL_MATRIX19 = 0x88D3
        Matrix19 = 35027,
        //
        // Resumo:
        //     Original was GL_MATRIX19_ARB = 0x88D3
        Matrix19Arb = 35027,
        //
        // Resumo:
        //     Original was GL_MATRIX20 = 0x88D4
        Matrix20 = 35028,
        //
        // Resumo:
        //     Original was GL_MATRIX20_ARB = 0x88D4
        Matrix20Arb = 35028,
        //
        // Resumo:
        //     Original was GL_MATRIX21 = 0x88D5
        Matrix21 = 35029,
        //
        // Resumo:
        //     Original was GL_MATRIX21_ARB = 0x88D5
        Matrix21Arb = 35029,
        //
        // Resumo:
        //     Original was GL_MATRIX22 = 0x88D6
        Matrix22 = 35030,
        //
        // Resumo:
        //     Original was GL_MATRIX22_ARB = 0x88D6
        Matrix22Arb = 35030,
        //
        // Resumo:
        //     Original was GL_MATRIX23 = 0x88D7
        Matrix23 = 35031,
        //
        // Resumo:
        //     Original was GL_MATRIX23_ARB = 0x88D7
        Matrix23Arb = 35031,
        //
        // Resumo:
        //     Original was GL_MATRIX24 = 0x88D8
        Matrix24 = 35032,
        //
        // Resumo:
        //     Original was GL_MATRIX24_ARB = 0x88D8
        Matrix24Arb = 35032,
        //
        // Resumo:
        //     Original was GL_MATRIX25 = 0x88D9
        Matrix25 = 35033,
        //
        // Resumo:
        //     Original was GL_MATRIX25_ARB = 0x88D9
        Matrix25Arb = 35033,
        //
        // Resumo:
        //     Original was GL_MATRIX26 = 0x88DA
        Matrix26 = 35034,
        //
        // Resumo:
        //     Original was GL_MATRIX26_ARB = 0x88DA
        Matrix26Arb = 35034,
        //
        // Resumo:
        //     Original was GL_MATRIX27 = 0x88DB
        Matrix27 = 35035,
        //
        // Resumo:
        //     Original was GL_MATRIX27_ARB = 0x88DB
        Matrix27Arb = 35035,
        //
        // Resumo:
        //     Original was GL_MATRIX28 = 0x88DC
        Matrix28 = 35036,
        //
        // Resumo:
        //     Original was GL_MATRIX28_ARB = 0x88DC
        Matrix28Arb = 35036,
        //
        // Resumo:
        //     Original was GL_MATRIX29 = 0x88DD
        Matrix29 = 35037,
        //
        // Resumo:
        //     Original was GL_MATRIX29_ARB = 0x88DD
        Matrix29Arb = 35037,
        //
        // Resumo:
        //     Original was GL_MATRIX30 = 0x88DE
        Matrix30 = 35038,
        //
        // Resumo:
        //     Original was GL_MATRIX30_ARB = 0x88DE
        Matrix30Arb = 35038,
        //
        // Resumo:
        //     Original was GL_MATRIX31 = 0x88DF
        Matrix31 = 35039,
        //
        // Resumo:
        //     Original was GL_MATRIX31_ARB = 0x88DF
        Matrix31Arb = 35039,
        //
        // Resumo:
        //     Original was GL_STREAM_DRAW = 0x88E0
        StreamDraw = 35040,
        //
        // Resumo:
        //     Original was GL_STREAM_DRAW_ARB = 0x88E0
        StreamDrawArb = 35040,
        //
        // Resumo:
        //     Original was GL_STREAM_READ = 0x88E1
        StreamRead = 35041,
        //
        // Resumo:
        //     Original was GL_STREAM_READ_ARB = 0x88E1
        StreamReadArb = 35041,
        //
        // Resumo:
        //     Original was GL_STREAM_COPY = 0x88E2
        StreamCopy = 35042,
        //
        // Resumo:
        //     Original was GL_STREAM_COPY_ARB = 0x88E2
        StreamCopyArb = 35042,
        //
        // Resumo:
        //     Original was GL_STATIC_DRAW = 0x88E4
        StaticDraw = 35044,
        //
        // Resumo:
        //     Original was GL_STATIC_DRAW_ARB = 0x88E4
        StaticDrawArb = 35044,
        //
        // Resumo:
        //     Original was GL_STATIC_READ = 0x88E5
        StaticRead = 35045,
        //
        // Resumo:
        //     Original was GL_STATIC_READ_ARB = 0x88E5
        StaticReadArb = 35045,
        //
        // Resumo:
        //     Original was GL_STATIC_COPY = 0x88E6
        StaticCopy = 35046,
        //
        // Resumo:
        //     Original was GL_STATIC_COPY_ARB = 0x88E6
        StaticCopyArb = 35046,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_DRAW = 0x88E8
        DynamicDraw = 35048,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_DRAW_ARB = 0x88E8
        DynamicDrawArb = 35048,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_READ = 0x88E9
        DynamicRead = 35049,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_READ_ARB = 0x88E9
        DynamicReadArb = 35049,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_COPY = 0x88EA
        DynamicCopy = 35050,
        //
        // Resumo:
        //     Original was GL_DYNAMIC_COPY_ARB = 0x88EA
        DynamicCopyArb = 35050,
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
        //     Original was GL_PIXEL_PACK_BUFFER_EXT = 0x88EB
        PixelPackBufferExt = 35051,
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
        //     Original was GL_PIXEL_UNPACK_BUFFER_EXT = 0x88EC
        PixelUnpackBufferExt = 35052,
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
        //     Original was GL_PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED
        PixelPackBufferBindingExt = 35053,
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
        //     Original was GL_PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF
        PixelUnpackBufferBindingExt = 35055,
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
        //     Original was GL_TEXTURE_STENCIL_SIZE_EXT = 0x88F1
        TextureStencilSizeExt = 35057,
        //
        // Resumo:
        //     Original was GL_STENCIL_TAG_BITS_EXT = 0x88F2
        StencilTagBitsExt = 35058,
        //
        // Resumo:
        //     Original was GL_STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3
        StencilClearTagValueExt = 35059,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4
        MaxProgramExecInstructionsNv = 35060,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5
        MaxProgramCallDepthNv = 35061,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_IF_DEPTH_NV = 0x88F6
        MaxProgramIfDepthNv = 35062,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7
        MaxProgramLoopDepthNv = 35063,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8
        MaxProgramLoopCountNv = 35064,
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
        //     Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT = 0x88FD
        VertexAttribArrayIntegerExt = 35069,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV = 0x88FD
        VertexAttribArrayIntegerNv = 35069,
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
        //     Original was GL_MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF
        MaxArrayTextureLayersExt = 35071,
        //
        // Resumo:
        //     Original was GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904
        MinProgramTexelOffset = 35076,
        //
        // Resumo:
        //     Original was GL_MIN_PROGRAM_TEXEL_OFFSET_EXT = 0x8904
        MinProgramTexelOffsetExt = 35076,
        //
        // Resumo:
        //     Original was GL_MIN_PROGRAM_TEXEL_OFFSET_NV = 0x8904
        MinProgramTexelOffsetNv = 35076,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905
        MaxProgramTexelOffset = 35077,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEXEL_OFFSET_EXT = 0x8905
        MaxProgramTexelOffsetExt = 35077,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TEXEL_OFFSET_NV = 0x8905
        MaxProgramTexelOffsetNv = 35077,
        //
        // Resumo:
        //     Original was GL_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906
        ProgramAttribComponentsNv = 35078,
        //
        // Resumo:
        //     Original was GL_PROGRAM_RESULT_COMPONENTS_NV = 0x8907
        ProgramResultComponentsNv = 35079,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908
        MaxProgramAttribComponentsNv = 35080,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909
        MaxProgramResultComponentsNv = 35081,
        //
        // Resumo:
        //     Original was GL_STENCIL_TEST_TWO_SIDE_EXT = 0x8910
        StencilTestTwoSideExt = 35088,
        //
        // Resumo:
        //     Original was GL_ACTIVE_STENCIL_FACE_EXT = 0x8911
        ActiveStencilFaceExt = 35089,
        //
        // Resumo:
        //     Original was GL_MIRROR_CLAMP_TO_BORDER_EXT = 0x8912
        MirrorClampToBorderExt = 35090,
        //
        // Resumo:
        //     Original was GL_SAMPLES_PASSED = 0x8914
        SamplesPassed = 35092,
        //
        // Resumo:
        //     Original was GL_SAMPLES_PASSED_ARB = 0x8914
        SamplesPassedArb = 35092,
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
        //     Original was GL_CLAMP_VERTEX_COLOR_ARB = 0x891A
        ClampVertexColorArb = 35098,
        //
        // Resumo:
        //     Original was GL_CLAMP_FRAGMENT_COLOR = 0x891B
        ClampFragmentColor = 35099,
        //
        // Resumo:
        //     Original was GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B
        ClampFragmentColorArb = 35099,
        //
        // Resumo:
        //     Original was GL_CLAMP_READ_COLOR = 0x891C
        ClampReadColor = 35100,
        //
        // Resumo:
        //     Original was GL_CLAMP_READ_COLOR_ARB = 0x891C
        ClampReadColorArb = 35100,
        //
        // Resumo:
        //     Original was GL_FIXED_ONLY = 0x891D
        FixedOnly = 35101,
        //
        // Resumo:
        //     Original was GL_FIXED_ONLY_ARB = 0x891D
        FixedOnlyArb = 35101,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_PROGRAM_NV = 0x891E
        TessControlProgramNv = 35102,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_PROGRAM_NV = 0x891F
        TessEvaluationProgramNv = 35103,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_SHADER_ATI = 0x8920
        FragmentShaderAti = 35104,
        //
        // Resumo:
        //     Original was GL_REG_0_ATI = 0x8921
        Reg0Ati = 35105,
        //
        // Resumo:
        //     Original was GL_REG_1_ATI = 0x8922
        Reg1Ati = 35106,
        //
        // Resumo:
        //     Original was GL_REG_2_ATI = 0x8923
        Reg2Ati = 35107,
        //
        // Resumo:
        //     Original was GL_REG_3_ATI = 0x8924
        Reg3Ati = 35108,
        //
        // Resumo:
        //     Original was GL_REG_4_ATI = 0x8925
        Reg4Ati = 35109,
        //
        // Resumo:
        //     Original was GL_REG_5_ATI = 0x8926
        Reg5Ati = 35110,
        //
        // Resumo:
        //     Original was GL_REG_6_ATI = 0x8927
        Reg6Ati = 35111,
        //
        // Resumo:
        //     Original was GL_REG_7_ATI = 0x8928
        Reg7Ati = 35112,
        //
        // Resumo:
        //     Original was GL_REG_8_ATI = 0x8929
        Reg8Ati = 35113,
        //
        // Resumo:
        //     Original was GL_REG_9_ATI = 0x892A
        Reg9Ati = 35114,
        //
        // Resumo:
        //     Original was GL_REG_10_ATI = 0x892B
        Reg10Ati = 35115,
        //
        // Resumo:
        //     Original was GL_REG_11_ATI = 0x892C
        Reg11Ati = 35116,
        //
        // Resumo:
        //     Original was GL_REG_12_ATI = 0x892D
        Reg12Ati = 35117,
        //
        // Resumo:
        //     Original was GL_REG_13_ATI = 0x892E
        Reg13Ati = 35118,
        //
        // Resumo:
        //     Original was GL_REG_14_ATI = 0x892F
        Reg14Ati = 35119,
        //
        // Resumo:
        //     Original was GL_REG_15_ATI = 0x8930
        Reg15Ati = 35120,
        //
        // Resumo:
        //     Original was GL_REG_16_ATI = 0x8931
        Reg16Ati = 35121,
        //
        // Resumo:
        //     Original was GL_REG_17_ATI = 0x8932
        Reg17Ati = 35122,
        //
        // Resumo:
        //     Original was GL_REG_18_ATI = 0x8933
        Reg18Ati = 35123,
        //
        // Resumo:
        //     Original was GL_REG_19_ATI = 0x8934
        Reg19Ati = 35124,
        //
        // Resumo:
        //     Original was GL_REG_20_ATI = 0x8935
        Reg20Ati = 35125,
        //
        // Resumo:
        //     Original was GL_REG_21_ATI = 0x8936
        Reg21Ati = 35126,
        //
        // Resumo:
        //     Original was GL_REG_22_ATI = 0x8937
        Reg22Ati = 35127,
        //
        // Resumo:
        //     Original was GL_REG_23_ATI = 0x8938
        Reg23Ati = 35128,
        //
        // Resumo:
        //     Original was GL_REG_24_ATI = 0x8939
        Reg24Ati = 35129,
        //
        // Resumo:
        //     Original was GL_REG_25_ATI = 0x893A
        Reg25Ati = 35130,
        //
        // Resumo:
        //     Original was GL_REG_26_ATI = 0x893B
        Reg26Ati = 35131,
        //
        // Resumo:
        //     Original was GL_REG_27_ATI = 0x893C
        Reg27Ati = 35132,
        //
        // Resumo:
        //     Original was GL_REG_28_ATI = 0x893D
        Reg28Ati = 35133,
        //
        // Resumo:
        //     Original was GL_REG_29_ATI = 0x893E
        Reg29Ati = 35134,
        //
        // Resumo:
        //     Original was GL_REG_30_ATI = 0x893F
        Reg30Ati = 35135,
        //
        // Resumo:
        //     Original was GL_REG_31_ATI = 0x8940
        Reg31Ati = 35136,
        //
        // Resumo:
        //     Original was GL_CON_0_ATI = 0x8941
        Con0Ati = 35137,
        //
        // Resumo:
        //     Original was GL_CON_1_ATI = 0x8942
        Con1Ati = 35138,
        //
        // Resumo:
        //     Original was GL_CON_2_ATI = 0x8943
        Con2Ati = 35139,
        //
        // Resumo:
        //     Original was GL_CON_3_ATI = 0x8944
        Con3Ati = 35140,
        //
        // Resumo:
        //     Original was GL_CON_4_ATI = 0x8945
        Con4Ati = 35141,
        //
        // Resumo:
        //     Original was GL_CON_5_ATI = 0x8946
        Con5Ati = 35142,
        //
        // Resumo:
        //     Original was GL_CON_6_ATI = 0x8947
        Con6Ati = 35143,
        //
        // Resumo:
        //     Original was GL_CON_7_ATI = 0x8948
        Con7Ati = 35144,
        //
        // Resumo:
        //     Original was GL_CON_8_ATI = 0x8949
        Con8Ati = 35145,
        //
        // Resumo:
        //     Original was GL_CON_9_ATI = 0x894A
        Con9Ati = 35146,
        //
        // Resumo:
        //     Original was GL_CON_10_ATI = 0x894B
        Con10Ati = 35147,
        //
        // Resumo:
        //     Original was GL_CON_11_ATI = 0x894C
        Con11Ati = 35148,
        //
        // Resumo:
        //     Original was GL_CON_12_ATI = 0x894D
        Con12Ati = 35149,
        //
        // Resumo:
        //     Original was GL_CON_13_ATI = 0x894E
        Con13Ati = 35150,
        //
        // Resumo:
        //     Original was GL_CON_14_ATI = 0x894F
        Con14Ati = 35151,
        //
        // Resumo:
        //     Original was GL_CON_15_ATI = 0x8950
        Con15Ati = 35152,
        //
        // Resumo:
        //     Original was GL_CON_16_ATI = 0x8951
        Con16Ati = 35153,
        //
        // Resumo:
        //     Original was GL_CON_17_ATI = 0x8952
        Con17Ati = 35154,
        //
        // Resumo:
        //     Original was GL_CON_18_ATI = 0x8953
        Con18Ati = 35155,
        //
        // Resumo:
        //     Original was GL_CON_19_ATI = 0x8954
        Con19Ati = 35156,
        //
        // Resumo:
        //     Original was GL_CON_20_ATI = 0x8955
        Con20Ati = 35157,
        //
        // Resumo:
        //     Original was GL_CON_21_ATI = 0x8956
        Con21Ati = 35158,
        //
        // Resumo:
        //     Original was GL_CON_22_ATI = 0x8957
        Con22Ati = 35159,
        //
        // Resumo:
        //     Original was GL_CON_23_ATI = 0x8958
        Con23Ati = 35160,
        //
        // Resumo:
        //     Original was GL_CON_24_ATI = 0x8959
        Con24Ati = 35161,
        //
        // Resumo:
        //     Original was GL_CON_25_ATI = 0x895A
        Con25Ati = 35162,
        //
        // Resumo:
        //     Original was GL_CON_26_ATI = 0x895B
        Con26Ati = 35163,
        //
        // Resumo:
        //     Original was GL_CON_27_ATI = 0x895C
        Con27Ati = 35164,
        //
        // Resumo:
        //     Original was GL_CON_28_ATI = 0x895D
        Con28Ati = 35165,
        //
        // Resumo:
        //     Original was GL_CON_29_ATI = 0x895E
        Con29Ati = 35166,
        //
        // Resumo:
        //     Original was GL_CON_30_ATI = 0x895F
        Con30Ati = 35167,
        //
        // Resumo:
        //     Original was GL_CON_31_ATI = 0x8960
        Con31Ati = 35168,
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
        //     Original was GL_SECONDARY_INTERPOLATOR_ATI = 0x896D
        SecondaryInterpolatorAti = 35181,
        //
        // Resumo:
        //     Original was GL_NUM_FRAGMENT_REGISTERS_ATI = 0x896E
        NumFragmentRegistersAti = 35182,
        //
        // Resumo:
        //     Original was GL_NUM_FRAGMENT_CONSTANTS_ATI = 0x896F
        NumFragmentConstantsAti = 35183,
        //
        // Resumo:
        //     Original was GL_NUM_PASSES_ATI = 0x8970
        NumPassesAti = 35184,
        //
        // Resumo:
        //     Original was GL_NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971
        NumInstructionsPerPassAti = 35185,
        //
        // Resumo:
        //     Original was GL_NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972
        NumInstructionsTotalAti = 35186,
        //
        // Resumo:
        //     Original was GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973
        NumInputInterpolatorComponentsAti = 35187,
        //
        // Resumo:
        //     Original was GL_NUM_LOOPBACK_COMPONENTS_ATI = 0x8974
        NumLoopbackComponentsAti = 35188,
        //
        // Resumo:
        //     Original was GL_COLOR_ALPHA_PAIRING_ATI = 0x8975
        ColorAlphaPairingAti = 35189,
        //
        // Resumo:
        //     Original was GL_SWIZZLE_STR_ATI = 0x8976
        SwizzleStrAti = 35190,
        //
        // Resumo:
        //     Original was GL_SWIZZLE_STQ_ATI = 0x8977
        SwizzleStqAti = 35191,
        //
        // Resumo:
        //     Original was GL_SWIZZLE_STR_DR_ATI = 0x8978
        SwizzleStrDrAti = 35192,
        //
        // Resumo:
        //     Original was GL_SWIZZLE_STQ_DQ_ATI = 0x8979
        SwizzleStqDqAti = 35193,
        //
        // Resumo:
        //     Original was GL_SWIZZLE_STRQ_ATI = 0x897A
        SwizzleStrqAti = 35194,
        //
        // Resumo:
        //     Original was GL_SWIZZLE_STRQ_DQ_ATI = 0x897B
        SwizzleStrqDqAti = 35195,
        //
        // Resumo:
        //     Original was GL_INTERLACE_OML = 0x8980
        InterlaceOml = 35200,
        //
        // Resumo:
        //     Original was GL_INTERLACE_READ_OML = 0x8981
        InterlaceReadOml = 35201,
        //
        // Resumo:
        //     Original was GL_FORMAT_SUBSAMPLE_24_24_OML = 0x8982
        FormatSubsample2424Oml = 35202,
        //
        // Resumo:
        //     Original was GL_FORMAT_SUBSAMPLE_244_244_OML = 0x8983
        FormatSubsample244244Oml = 35203,
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
        //     Original was GL_RESAMPLE_REPLICATE_OML = 0x8986
        ResampleReplicateOml = 35206,
        //
        // Resumo:
        //     Original was GL_RESAMPLE_ZERO_FILL_OML = 0x8987
        ResampleZeroFillOml = 35207,
        //
        // Resumo:
        //     Original was GL_RESAMPLE_AVERAGE_OML = 0x8988
        ResampleAverageOml = 35208,
        //
        // Resumo:
        //     Original was GL_RESAMPLE_DECIMATE_OML = 0x8989
        ResampleDecimateOml = 35209,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP1_APPLE = 0x8A00
        VertexAttribMap1Apple = 35328,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP2_APPLE = 0x8A01
        VertexAttribMap2Apple = 35329,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE = 0x8A02
        VertexAttribMap1SizeApple = 35330,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE = 0x8A03
        VertexAttribMap1CoeffApple = 35331,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE = 0x8A04
        VertexAttribMap1OrderApple = 35332,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE = 0x8A05
        VertexAttribMap1DomainApple = 35333,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE = 0x8A06
        VertexAttribMap2SizeApple = 35334,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE = 0x8A07
        VertexAttribMap2CoeffApple = 35335,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE = 0x8A08
        VertexAttribMap2OrderApple = 35336,
        //
        // Resumo:
        //     Original was GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE = 0x8A09
        VertexAttribMap2DomainApple = 35337,
        //
        // Resumo:
        //     Original was GL_DRAW_PIXELS_APPLE = 0x8A0A
        DrawPixelsApple = 35338,
        //
        // Resumo:
        //     Original was GL_FENCE_APPLE = 0x8A0B
        FenceApple = 35339,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_APPLE = 0x8A0C
        ElementArrayApple = 35340,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D
        ElementArrayTypeApple = 35341,
        //
        // Resumo:
        //     Original was GL_ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E
        ElementArrayPointerApple = 35342,
        //
        // Resumo:
        //     Original was GL_COLOR_FLOAT_APPLE = 0x8A0F
        ColorFloatApple = 35343,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER = 0x8A11
        UniformBuffer = 35345,
        //
        // Resumo:
        //     Original was GL_BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12
        BufferSerializedModifyApple = 35346,
        //
        // Resumo:
        //     Original was GL_BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13
        BufferFlushingUnmapApple = 35347,
        //
        // Resumo:
        //     Original was GL_AUX_DEPTH_STENCIL_APPLE = 0x8A14
        AuxDepthStencilApple = 35348,
        //
        // Resumo:
        //     Original was GL_PACK_ROW_BYTES_APPLE = 0x8A15
        PackRowBytesApple = 35349,
        //
        // Resumo:
        //     Original was GL_UNPACK_ROW_BYTES_APPLE = 0x8A16
        UnpackRowBytesApple = 35350,
        //
        // Resumo:
        //     Original was GL_RELEASED_APPLE = 0x8A19
        ReleasedApple = 35353,
        //
        // Resumo:
        //     Original was GL_VOLATILE_APPLE = 0x8A1A
        VolatileApple = 35354,
        //
        // Resumo:
        //     Original was GL_RETAINED_APPLE = 0x8A1B
        RetainedApple = 35355,
        //
        // Resumo:
        //     Original was GL_UNDEFINED_APPLE = 0x8A1C
        UndefinedApple = 35356,
        //
        // Resumo:
        //     Original was GL_PURGEABLE_APPLE = 0x8A1D
        PurgeableApple = 35357,
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
        //     Original was GL_PROGRAM_OBJECT_ARB = 0x8B40
        ProgramObjectArb = 35648,
        //
        // Resumo:
        //     Original was GL_PROGRAM_OBJECT_EXT = 0x8B40
        ProgramObjectExt = 35648,
        //
        // Resumo:
        //     Original was GL_SHADER_OBJECT_ARB = 0x8B48
        ShaderObjectArb = 35656,
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
        //     Original was GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49
        MaxFragmentUniformComponentsArb = 35657,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A
        MaxVertexUniformComponents = 35658,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A
        MaxVertexUniformComponentsArb = 35658,
        //
        // Resumo:
        //     Original was GL_MAX_VARYING_COMPONENTS = 0x8B4B
        MaxVaryingComponents = 35659,
        //
        // Resumo:
        //     Original was GL_MAX_VARYING_COMPONENTS_EXT = 0x8B4B
        MaxVaryingComponentsExt = 35659,
        //
        // Resumo:
        //     Original was GL_MAX_VARYING_FLOATS = 0x8B4B
        MaxVaryingFloats = 35659,
        //
        // Resumo:
        //     Original was GL_MAX_VARYING_FLOATS_ARB = 0x8B4B
        MaxVaryingFloatsArb = 35659,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
        MaxVertexTextureImageUnits = 35660,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C
        MaxVertexTextureImageUnitsArb = 35660,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
        MaxCombinedTextureImageUnits = 35661,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D
        MaxCombinedTextureImageUnitsArb = 35661,
        //
        // Resumo:
        //     Original was GL_OBJECT_TYPE_ARB = 0x8B4E
        ObjectTypeArb = 35662,
        //
        // Resumo:
        //     Original was GL_OBJECT_SUBTYPE_ARB = 0x8B4F
        ObjectSubtypeArb = 35663,
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
        //     Original was GL_OBJECT_DELETE_STATUS_ARB = 0x8B80
        ObjectDeleteStatusArb = 35712,
        //
        // Resumo:
        //     Original was GL_COMPILE_STATUS = 0x8B81
        CompileStatus = 35713,
        //
        // Resumo:
        //     Original was GL_OBJECT_COMPILE_STATUS_ARB = 0x8B81
        ObjectCompileStatusArb = 35713,
        //
        // Resumo:
        //     Original was GL_LINK_STATUS = 0x8B82
        LinkStatus = 35714,
        //
        // Resumo:
        //     Original was GL_OBJECT_LINK_STATUS_ARB = 0x8B82
        ObjectLinkStatusArb = 35714,
        //
        // Resumo:
        //     Original was GL_OBJECT_VALIDATE_STATUS_ARB = 0x8B83
        ObjectValidateStatusArb = 35715,
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
        //     Original was GL_OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84
        ObjectInfoLogLengthArb = 35716,
        //
        // Resumo:
        //     Original was GL_ATTACHED_SHADERS = 0x8B85
        AttachedShaders = 35717,
        //
        // Resumo:
        //     Original was GL_OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85
        ObjectAttachedObjectsArb = 35717,
        //
        // Resumo:
        //     Original was GL_ACTIVE_UNIFORMS = 0x8B86
        ActiveUniforms = 35718,
        //
        // Resumo:
        //     Original was GL_OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86
        ObjectActiveUniformsArb = 35718,
        //
        // Resumo:
        //     Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        ActiveUniformMaxLength = 35719,
        //
        // Resumo:
        //     Original was GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87
        ObjectActiveUniformMaxLengthArb = 35719,
        //
        // Resumo:
        //     Original was GL_OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88
        ObjectShaderSourceLengthArb = 35720,
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
        //     Original was GL_OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89
        ObjectActiveAttributesArb = 35721,
        //
        // Resumo:
        //     Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        ActiveAttributeMaxLength = 35722,
        //
        // Resumo:
        //     Original was GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A
        ObjectActiveAttributeMaxLengthArb = 35722,
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
        //     Original was GL_SHADING_LANGUAGE_VERSION_ARB = 0x8B8C
        ShadingLanguageVersionArb = 35724,
        //
        // Resumo:
        //     Original was GL_ACTIVE_PROGRAM_EXT = 0x8B8D
        ActiveProgramExt = 35725,
        //
        // Resumo:
        //     Original was GL_CURRENT_PROGRAM = 0x8B8D
        CurrentProgram = 35725,
        //
        // Resumo:
        //     Original was GL_PALETTE4_RGB8_OES = 0x8B90
        Palette4Rgb8Oes = 35728,
        //
        // Resumo:
        //     Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        Palette4Rgba8Oes = 35729,
        //
        // Resumo:
        //     Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        Palette4R5G6B5Oes = 35730,
        //
        // Resumo:
        //     Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        Palette4Rgba4Oes = 35731,
        //
        // Resumo:
        //     Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        Palette4Rgb5A1Oes = 35732,
        //
        // Resumo:
        //     Original was GL_PALETTE8_RGB8_OES = 0x8B95
        Palette8Rgb8Oes = 35733,
        //
        // Resumo:
        //     Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        Palette8Rgba8Oes = 35734,
        //
        // Resumo:
        //     Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        Palette8R5G6B5Oes = 35735,
        //
        // Resumo:
        //     Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        Palette8Rgba4Oes = 35736,
        //
        // Resumo:
        //     Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        Palette8Rgb5A1Oes = 35737,
        //
        // Resumo:
        //     Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        ImplementationColorReadType = 35738,
        //
        // Resumo:
        //     Original was GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
        ImplementationColorReadTypeOes = 35738,
        //
        // Resumo:
        //     Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        ImplementationColorReadFormat = 35739,
        //
        // Resumo:
        //     Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
        ImplementationColorReadFormatOes = 35739,
        //
        // Resumo:
        //     Original was GL_TILE_RASTER_ORDER_FIXED_MESA = 0x8BB8
        TileRasterOrderFixedMesa = 35768,
        //
        // Resumo:
        //     Original was GL_TILE_RASTER_ORDER_INCREASING_X_MESA = 0x8BB9
        TileRasterOrderIncreasingXMesa = 35769,
        //
        // Resumo:
        //     Original was GL_TILE_RASTER_ORDER_INCREASING_Y_MESA = 0x8BBA
        TileRasterOrderIncreasingYMesa = 35770,
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
        //     Original was GL_TEXTURE_RED_TYPE_ARB = 0x8C10
        TextureRedTypeArb = 35856,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GREEN_TYPE = 0x8C11
        TextureGreenType = 35857,
        //
        // Resumo:
        //     Original was GL_TEXTURE_GREEN_TYPE_ARB = 0x8C11
        TextureGreenTypeArb = 35857,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BLUE_TYPE = 0x8C12
        TextureBlueType = 35858,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BLUE_TYPE_ARB = 0x8C12
        TextureBlueTypeArb = 35858,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ALPHA_TYPE = 0x8C13
        TextureAlphaType = 35859,
        //
        // Resumo:
        //     Original was GL_TEXTURE_ALPHA_TYPE_ARB = 0x8C13
        TextureAlphaTypeArb = 35859,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LUMINANCE_TYPE = 0x8C14
        TextureLuminanceType = 35860,
        //
        // Resumo:
        //     Original was GL_TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14
        TextureLuminanceTypeArb = 35860,
        //
        // Resumo:
        //     Original was GL_TEXTURE_INTENSITY_TYPE = 0x8C15
        TextureIntensityType = 35861,
        //
        // Resumo:
        //     Original was GL_TEXTURE_INTENSITY_TYPE_ARB = 0x8C15
        TextureIntensityTypeArb = 35861,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEPTH_TYPE = 0x8C16
        TextureDepthType = 35862,
        //
        // Resumo:
        //     Original was GL_TEXTURE_DEPTH_TYPE_ARB = 0x8C16
        TextureDepthTypeArb = 35862,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_NORMALIZED = 0x8C17
        UnsignedNormalized = 35863,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_NORMALIZED_ARB = 0x8C17
        UnsignedNormalizedArb = 35863,
        //
        // Resumo:
        //     Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        Texture1DArray = 35864,
        //
        // Resumo:
        //     Original was GL_TEXTURE_1D_ARRAY_EXT = 0x8C18
        Texture1DArrayExt = 35864,
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
        //     Original was GL_TEXTURE_2D_ARRAY_EXT = 0x8C1A
        Texture2DArrayExt = 35866,
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
        //     Original was GL_TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C
        TextureBinding1DArrayExt = 35868,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
        TextureBinding2DArray = 35869,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D
        TextureBinding2DArrayExt = 35869,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_PROGRAM_NV = 0x8C26
        GeometryProgramNv = 35878,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27
        MaxProgramOutputVerticesNv = 35879,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28
        MaxProgramTotalOutputComponentsNv = 35880,
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
        //     Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29
        MaxGeometryTextureImageUnitsExt = 35881,
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
        //     Original was GL_TEXTURE_BUFFER_EXT = 0x8C2A
        TextureBufferExt = 35882,
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
        //     Original was GL_MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B
        MaxTextureBufferSizeExt = 35883,
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
        //     Original was GL_TEXTURE_BINDING_BUFFER_EXT = 0x8C2C
        TextureBindingBufferExt = 35884,
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
        //     Original was GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D
        TextureBufferDataStoreBindingExt = 35885,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E
        TextureBufferFormatArb = 35886,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E
        TextureBufferFormatExt = 35886,
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
        //     Original was GL_UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B
        UnsignedInt10F11F11FRevExt = 35899,
        //
        // Resumo:
        //     Original was GL_RGBA_SIGNED_COMPONENTS_EXT = 0x8C3C
        RgbaSignedComponentsExt = 35900,
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
        //     Original was GL_UNSIGNED_INT_5_9_9_9_REV_EXT = 0x8C3E
        UnsignedInt5999RevExt = 35902,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SHARED_SIZE = 0x8C3F
        TextureSharedSize = 35903,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SHARED_SIZE_EXT = 0x8C3F
        TextureSharedSizeExt = 35903,
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
        //     Original was GL_SLUMINANCE_ALPHA_EXT = 0x8C44
        SluminanceAlphaExt = 35908,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE8_ALPHA8 = 0x8C45
        Sluminance8Alpha8 = 35909,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE8_ALPHA8_EXT = 0x8C45
        Sluminance8Alpha8Ext = 35909,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE = 0x8C46
        Sluminance = 35910,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE_EXT = 0x8C46
        SluminanceExt = 35910,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE8 = 0x8C47
        Sluminance8 = 35911,
        //
        // Resumo:
        //     Original was GL_SLUMINANCE8_EXT = 0x8C47
        Sluminance8Ext = 35911,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB = 0x8C48
        CompressedSrgb = 35912,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_EXT = 0x8C48
        CompressedSrgbExt = 35912,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        CompressedSrgbAlpha = 35913,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_EXT = 0x8C49
        CompressedSrgbAlphaExt = 35913,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SLUMINANCE = 0x8C4A
        CompressedSluminance = 35914,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SLUMINANCE_EXT = 0x8C4A
        CompressedSluminanceExt = 35914,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B
        CompressedSluminanceAlpha = 35915,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B
        CompressedSluminanceAlphaExt = 35915,
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
        //     Original was GL_COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70
        CompressedLuminanceLatc1Ext = 35952,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71
        CompressedSignedLuminanceLatc1Ext = 35953,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72
        CompressedLuminanceAlphaLatc2Ext = 35954,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73
        CompressedSignedLuminanceAlphaLatc2Ext = 35955,
        //
        // Resumo:
        //     Original was GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74
        TessControlProgramParameterBufferNv = 35956,
        //
        // Resumo:
        //     Original was GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75
        TessEvaluationProgramParameterBufferNv = 35957,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        TransformFeedbackVaryingMaxLength = 35958,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76
        TransformFeedbackVaryingMaxLengthExt = 35958,
        //
        // Resumo:
        //     Original was GL_BACK_PRIMARY_COLOR_NV = 0x8C77
        BackPrimaryColorNv = 35959,
        //
        // Resumo:
        //     Original was GL_BACK_SECONDARY_COLOR_NV = 0x8C78
        BackSecondaryColorNv = 35960,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_NV = 0x8C79
        TextureCoordNv = 35961,
        //
        // Resumo:
        //     Original was GL_CLIP_DISTANCE_NV = 0x8C7A
        ClipDistanceNv = 35962,
        //
        // Resumo:
        //     Original was GL_VERTEX_ID_NV = 0x8C7B
        VertexIdNv = 35963,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_ID_NV = 0x8C7C
        PrimitiveIdNv = 35964,
        //
        // Resumo:
        //     Original was GL_GENERIC_ATTRIB_NV = 0x8C7D
        GenericAttribNv = 35965,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E
        TransformFeedbackAttribsNv = 35966,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        TransformFeedbackBufferMode = 35967,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F
        TransformFeedbackBufferModeExt = 35967,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F
        TransformFeedbackBufferModeNv = 35967,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80
        MaxTransformFeedbackSeparateComponents = 35968,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80
        MaxTransformFeedbackSeparateComponentsExt = 35968,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80
        MaxTransformFeedbackSeparateComponentsNv = 35968,
        //
        // Resumo:
        //     Original was GL_ACTIVE_VARYINGS_NV = 0x8C81
        ActiveVaryingsNv = 35969,
        //
        // Resumo:
        //     Original was GL_ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82
        ActiveVaryingMaxLengthNv = 35970,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        TransformFeedbackVaryings = 35971,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83
        TransformFeedbackVaryingsExt = 35971,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83
        TransformFeedbackVaryingsNv = 35971,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        TransformFeedbackBufferStart = 35972,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84
        TransformFeedbackBufferStartExt = 35972,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84
        TransformFeedbackBufferStartNv = 35972,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        TransformFeedbackBufferSize = 35973,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85
        TransformFeedbackBufferSizeExt = 35973,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85
        TransformFeedbackBufferSizeNv = 35973,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86
        TransformFeedbackRecordNv = 35974,
        //
        // Resumo:
        //     Original was GL_PRIMITIVES_GENERATED = 0x8C87
        PrimitivesGenerated = 35975,
        //
        // Resumo:
        //     Original was GL_PRIMITIVES_GENERATED_EXT = 0x8C87
        PrimitivesGeneratedExt = 35975,
        //
        // Resumo:
        //     Original was GL_PRIMITIVES_GENERATED_NV = 0x8C87
        PrimitivesGeneratedNv = 35975,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        TransformFeedbackPrimitivesWritten = 35976,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88
        TransformFeedbackPrimitivesWrittenExt = 35976,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88
        TransformFeedbackPrimitivesWrittenNv = 35976,
        //
        // Resumo:
        //     Original was GL_RASTERIZER_DISCARD = 0x8C89
        RasterizerDiscard = 35977,
        //
        // Resumo:
        //     Original was GL_RASTERIZER_DISCARD_EXT = 0x8C89
        RasterizerDiscardExt = 35977,
        //
        // Resumo:
        //     Original was GL_RASTERIZER_DISCARD_NV = 0x8C89
        RasterizerDiscardNv = 35977,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A
        MaxTransformFeedbackInterleavedComponents = 35978,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A
        MaxTransformFeedbackInterleavedComponentsExt = 35978,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV = 0x8C8A
        MaxTransformFeedbackInterleavedComponentsNv = 35978,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B
        MaxTransformFeedbackSeparateAttribs = 35979,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B
        MaxTransformFeedbackSeparateAttribsExt = 35979,
        //
        // Resumo:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B
        MaxTransformFeedbackSeparateAttribsNv = 35979,
        //
        // Resumo:
        //     Original was GL_INTERLEAVED_ATTRIBS = 0x8C8C
        InterleavedAttribs = 35980,
        //
        // Resumo:
        //     Original was GL_INTERLEAVED_ATTRIBS_EXT = 0x8C8C
        InterleavedAttribsExt = 35980,
        //
        // Resumo:
        //     Original was GL_INTERLEAVED_ATTRIBS_NV = 0x8C8C
        InterleavedAttribsNv = 35980,
        //
        // Resumo:
        //     Original was GL_SEPARATE_ATTRIBS = 0x8C8D
        SeparateAttribs = 35981,
        //
        // Resumo:
        //     Original was GL_SEPARATE_ATTRIBS_EXT = 0x8C8D
        SeparateAttribsExt = 35981,
        //
        // Resumo:
        //     Original was GL_SEPARATE_ATTRIBS_NV = 0x8C8D
        SeparateAttribsNv = 35981,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        TransformFeedbackBuffer = 35982,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E
        TransformFeedbackBufferExt = 35982,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_NV = 0x8C8E
        TransformFeedbackBufferNv = 35982,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        TransformFeedbackBufferBinding = 35983,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F
        TransformFeedbackBufferBindingExt = 35983,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F
        TransformFeedbackBufferBindingNv = 35983,
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
        //     Original was GL_DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6
        DrawFramebufferBindingExt = 36006,
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
        //     Original was GL_READ_FRAMEBUFFER_EXT = 0x8CA8
        ReadFramebufferExt = 36008,
        //
        // Resumo:
        //     Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        DrawFramebuffer = 36009,
        //
        // Resumo:
        //     Original was GL_DRAW_FRAMEBUFFER_EXT = 0x8CA9
        DrawFramebufferExt = 36009,
        //
        // Resumo:
        //     Original was GL_READ_FRAMEBUFFER_BINDING = 0x8CAA
        ReadFramebufferBinding = 36010,
        //
        // Resumo:
        //     Original was GL_READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA
        ReadFramebufferBindingExt = 36010,
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
        //     Original was GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB
        RenderbufferSamplesExt = 36011,
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
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4
        FramebufferAttachmentTextureLayerExt = 36052,
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
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56
        FramebufferIncompleteMultisampleExt = 36182,
        //
        // Resumo:
        //     Original was GL_MAX_SAMPLES = 0x8D57
        MaxSamples = 36183,
        //
        // Resumo:
        //     Original was GL_MAX_SAMPLES_EXT = 0x8D57
        MaxSamplesExt = 36183,
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
        //     Original was GL_RGBA32UI_EXT = 0x8D70
        Rgba32uiExt = 36208,
        //
        // Resumo:
        //     Original was GL_RGB32UI = 0x8D71
        Rgb32ui = 36209,
        //
        // Resumo:
        //     Original was GL_RGB32UI_EXT = 0x8D71
        Rgb32uiExt = 36209,
        //
        // Resumo:
        //     Original was GL_ALPHA32UI_EXT = 0x8D72
        Alpha32uiExt = 36210,
        //
        // Resumo:
        //     Original was GL_INTENSITY32UI_EXT = 0x8D73
        Intensity32uiExt = 36211,
        //
        // Resumo:
        //     Original was GL_LUMINANCE32UI_EXT = 0x8D74
        Luminance32uiExt = 36212,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA32UI_EXT = 0x8D75
        LuminanceAlpha32uiExt = 36213,
        //
        // Resumo:
        //     Original was GL_RGBA16UI = 0x8D76
        Rgba16ui = 36214,
        //
        // Resumo:
        //     Original was GL_RGBA16UI_EXT = 0x8D76
        Rgba16uiExt = 36214,
        //
        // Resumo:
        //     Original was GL_RGB16UI = 0x8D77
        Rgb16ui = 36215,
        //
        // Resumo:
        //     Original was GL_RGB16UI_EXT = 0x8D77
        Rgb16uiExt = 36215,
        //
        // Resumo:
        //     Original was GL_ALPHA16UI_EXT = 0x8D78
        Alpha16uiExt = 36216,
        //
        // Resumo:
        //     Original was GL_INTENSITY16UI_EXT = 0x8D79
        Intensity16uiExt = 36217,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16UI_EXT = 0x8D7A
        Luminance16uiExt = 36218,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA16UI_EXT = 0x8D7B
        LuminanceAlpha16uiExt = 36219,
        //
        // Resumo:
        //     Original was GL_RGBA8UI = 0x8D7C
        Rgba8ui = 36220,
        //
        // Resumo:
        //     Original was GL_RGBA8UI_EXT = 0x8D7C
        Rgba8uiExt = 36220,
        //
        // Resumo:
        //     Original was GL_RGB8UI = 0x8D7D
        Rgb8ui = 36221,
        //
        // Resumo:
        //     Original was GL_RGB8UI_EXT = 0x8D7D
        Rgb8uiExt = 36221,
        //
        // Resumo:
        //     Original was GL_ALPHA8UI_EXT = 0x8D7E
        Alpha8uiExt = 36222,
        //
        // Resumo:
        //     Original was GL_INTENSITY8UI_EXT = 0x8D7F
        Intensity8uiExt = 36223,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8UI_EXT = 0x8D80
        Luminance8uiExt = 36224,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA8UI_EXT = 0x8D81
        LuminanceAlpha8uiExt = 36225,
        //
        // Resumo:
        //     Original was GL_RGBA32I = 0x8D82
        Rgba32i = 36226,
        //
        // Resumo:
        //     Original was GL_RGBA32I_EXT = 0x8D82
        Rgba32iExt = 36226,
        //
        // Resumo:
        //     Original was GL_RGB32I = 0x8D83
        Rgb32i = 36227,
        //
        // Resumo:
        //     Original was GL_RGB32I_EXT = 0x8D83
        Rgb32iExt = 36227,
        //
        // Resumo:
        //     Original was GL_ALPHA32I_EXT = 0x8D84
        Alpha32iExt = 36228,
        //
        // Resumo:
        //     Original was GL_INTENSITY32I_EXT = 0x8D85
        Intensity32iExt = 36229,
        //
        // Resumo:
        //     Original was GL_LUMINANCE32I_EXT = 0x8D86
        Luminance32iExt = 36230,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA32I_EXT = 0x8D87
        LuminanceAlpha32iExt = 36231,
        //
        // Resumo:
        //     Original was GL_RGBA16I = 0x8D88
        Rgba16i = 36232,
        //
        // Resumo:
        //     Original was GL_RGBA16I_EXT = 0x8D88
        Rgba16iExt = 36232,
        //
        // Resumo:
        //     Original was GL_RGB16I = 0x8D89
        Rgb16i = 36233,
        //
        // Resumo:
        //     Original was GL_RGB16I_EXT = 0x8D89
        Rgb16iExt = 36233,
        //
        // Resumo:
        //     Original was GL_ALPHA16I_EXT = 0x8D8A
        Alpha16iExt = 36234,
        //
        // Resumo:
        //     Original was GL_INTENSITY16I_EXT = 0x8D8B
        Intensity16iExt = 36235,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16I_EXT = 0x8D8C
        Luminance16iExt = 36236,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA16I_EXT = 0x8D8D
        LuminanceAlpha16iExt = 36237,
        //
        // Resumo:
        //     Original was GL_RGBA8I = 0x8D8E
        Rgba8i = 36238,
        //
        // Resumo:
        //     Original was GL_RGBA8I_EXT = 0x8D8E
        Rgba8iExt = 36238,
        //
        // Resumo:
        //     Original was GL_RGB8I = 0x8D8F
        Rgb8i = 36239,
        //
        // Resumo:
        //     Original was GL_RGB8I_EXT = 0x8D8F
        Rgb8iExt = 36239,
        //
        // Resumo:
        //     Original was GL_ALPHA8I_EXT = 0x8D90
        Alpha8iExt = 36240,
        //
        // Resumo:
        //     Original was GL_INTENSITY8I_EXT = 0x8D91
        Intensity8iExt = 36241,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8I_EXT = 0x8D92
        Luminance8iExt = 36242,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA8I_EXT = 0x8D93
        LuminanceAlpha8iExt = 36243,
        //
        // Resumo:
        //     Original was GL_RED_INTEGER = 0x8D94
        RedInteger = 36244,
        //
        // Resumo:
        //     Original was GL_RED_INTEGER_EXT = 0x8D94
        RedIntegerExt = 36244,
        //
        // Resumo:
        //     Original was GL_GREEN_INTEGER = 0x8D95
        GreenInteger = 36245,
        //
        // Resumo:
        //     Original was GL_GREEN_INTEGER_EXT = 0x8D95
        GreenIntegerExt = 36245,
        //
        // Resumo:
        //     Original was GL_BLUE_INTEGER = 0x8D96
        BlueInteger = 36246,
        //
        // Resumo:
        //     Original was GL_BLUE_INTEGER_EXT = 0x8D96
        BlueIntegerExt = 36246,
        //
        // Resumo:
        //     Original was GL_ALPHA_INTEGER = 0x8D97
        AlphaInteger = 36247,
        //
        // Resumo:
        //     Original was GL_ALPHA_INTEGER_EXT = 0x8D97
        AlphaIntegerExt = 36247,
        //
        // Resumo:
        //     Original was GL_RGB_INTEGER = 0x8D98
        RgbInteger = 36248,
        //
        // Resumo:
        //     Original was GL_RGB_INTEGER_EXT = 0x8D98
        RgbIntegerExt = 36248,
        //
        // Resumo:
        //     Original was GL_RGBA_INTEGER = 0x8D99
        RgbaInteger = 36249,
        //
        // Resumo:
        //     Original was GL_RGBA_INTEGER_EXT = 0x8D99
        RgbaIntegerExt = 36249,
        //
        // Resumo:
        //     Original was GL_BGR_INTEGER = 0x8D9A
        BgrInteger = 36250,
        //
        // Resumo:
        //     Original was GL_BGR_INTEGER_EXT = 0x8D9A
        BgrIntegerExt = 36250,
        //
        // Resumo:
        //     Original was GL_BGRA_INTEGER = 0x8D9B
        BgraInteger = 36251,
        //
        // Resumo:
        //     Original was GL_BGRA_INTEGER_EXT = 0x8D9B
        BgraIntegerExt = 36251,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_INTEGER_EXT = 0x8D9C
        LuminanceIntegerExt = 36252,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D
        LuminanceAlphaIntegerExt = 36253,
        //
        // Resumo:
        //     Original was GL_RGBA_INTEGER_MODE_EXT = 0x8D9E
        RgbaIntegerModeExt = 36254,
        //
        // Resumo:
        //     Original was GL_INT_2_10_10_10_REV = 0x8D9F
        Int2101010Rev = 36255,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0
        MaxProgramParameterBufferBindingsNv = 36256,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1
        MaxProgramParameterBufferSizeNv = 36257,
        //
        // Resumo:
        //     Original was GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2
        VertexProgramParameterBufferNv = 36258,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3
        GeometryProgramParameterBufferNv = 36259,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4
        FragmentProgramParameterBufferNv = 36260,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5
        MaxProgramGenericAttribsNv = 36261,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6
        MaxProgramGenericResultsNv = 36262,
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
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7
        FramebufferAttachmentLayeredExt = 36263,
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
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8
        FramebufferIncompleteLayerTargetsExt = 36264,
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
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9
        FramebufferIncompleteLayerCountExt = 36265,
        //
        // Resumo:
        //     Original was GL_LAYER_NV = 0x8DAA
        LayerNv = 36266,
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
        //     Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD
        Float32UnsignedInt248RevNv = 36269,
        //
        // Resumo:
        //     Original was GL_SHADER_INCLUDE_ARB = 0x8DAE
        ShaderIncludeArb = 36270,
        //
        // Resumo:
        //     Original was GL_DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF
        DepthBufferFloatModeNv = 36271,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_SRGB = 0x8DB9
        FramebufferSrgb = 36281,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_SRGB_EXT = 0x8DB9
        FramebufferSrgbExt = 36281,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_SRGB_CAPABLE_EXT = 0x8DBA
        FramebufferSrgbCapableExt = 36282,
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
        //     Original was GL_COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD
        CompressedRedGreenRgtc2Ext = 36285,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        CompressedRgRgtc2 = 36285,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE
        CompressedSignedRedGreenRgtc2Ext = 36286,
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
        //     Original was GL_SAMPLER_1D_ARRAY_EXT = 0x8DC0
        Sampler1DArrayExt = 36288,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_ARRAY = 0x8DC1
        Sampler2DArray = 36289,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_ARRAY_EXT = 0x8DC1
        Sampler2DArrayExt = 36289,
        //
        // Resumo:
        //     Original was GL_SAMPLER_BUFFER = 0x8DC2
        SamplerBuffer = 36290,
        //
        // Resumo:
        //     Original was GL_SAMPLER_BUFFER_EXT = 0x8DC2
        SamplerBufferExt = 36290,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3
        Sampler1DArrayShadow = 36291,
        //
        // Resumo:
        //     Original was GL_SAMPLER_1D_ARRAY_SHADOW_EXT = 0x8DC3
        Sampler1DArrayShadowExt = 36291,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4
        Sampler2DArrayShadow = 36292,
        //
        // Resumo:
        //     Original was GL_SAMPLER_2D_ARRAY_SHADOW_EXT = 0x8DC4
        Sampler2DArrayShadowExt = 36292,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_SHADOW = 0x8DC5
        SamplerCubeShadow = 36293,
        //
        // Resumo:
        //     Original was GL_SAMPLER_CUBE_SHADOW_EXT = 0x8DC5
        SamplerCubeShadowExt = 36293,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC2 = 0x8DC6
        UnsignedIntVec2 = 36294,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC2_EXT = 0x8DC6
        UnsignedIntVec2Ext = 36294,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC3 = 0x8DC7
        UnsignedIntVec3 = 36295,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC3_EXT = 0x8DC7
        UnsignedIntVec3Ext = 36295,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC4 = 0x8DC8
        UnsignedIntVec4 = 36296,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_VEC4_EXT = 0x8DC8
        UnsignedIntVec4Ext = 36296,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_1D = 0x8DC9
        IntSampler1D = 36297,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_1D_EXT = 0x8DC9
        IntSampler1DExt = 36297,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D = 0x8DCA
        IntSampler2D = 36298,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_EXT = 0x8DCA
        IntSampler2DExt = 36298,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_3D = 0x8DCB
        IntSampler3D = 36299,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_3D_EXT = 0x8DCB
        IntSampler3DExt = 36299,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_CUBE = 0x8DCC
        IntSamplerCube = 36300,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_CUBE_EXT = 0x8DCC
        IntSamplerCubeExt = 36300,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_RECT = 0x8DCD
        IntSampler2DRect = 36301,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_RECT_EXT = 0x8DCD
        IntSampler2DRectExt = 36301,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_1D_ARRAY = 0x8DCE
        IntSampler1DArray = 36302,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_1D_ARRAY_EXT = 0x8DCE
        IntSampler1DArrayExt = 36302,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_ARRAY = 0x8DCF
        IntSampler2DArray = 36303,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_2D_ARRAY_EXT = 0x8DCF
        IntSampler2DArrayExt = 36303,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_BUFFER = 0x8DD0
        IntSamplerBuffer = 36304,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_BUFFER_EXT = 0x8DD0
        IntSamplerBufferExt = 36304,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1
        UnsignedIntSampler1D = 36305,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_1D_EXT = 0x8DD1
        UnsignedIntSampler1DExt = 36305,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2
        UnsignedIntSampler2D = 36306,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_EXT = 0x8DD2
        UnsignedIntSampler2DExt = 36306,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3
        UnsignedIntSampler3D = 36307,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_3D_EXT = 0x8DD3
        UnsignedIntSampler3DExt = 36307,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4
        UnsignedIntSamplerCube = 36308,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_CUBE_EXT = 0x8DD4
        UnsignedIntSamplerCubeExt = 36308,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5
        UnsignedIntSampler2DRect = 36309,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5
        UnsignedIntSampler2DRectExt = 36309,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6
        UnsignedIntSampler1DArray = 36310,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6
        UnsignedIntSampler1DArrayExt = 36310,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7
        UnsignedIntSampler2DArray = 36311,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7
        UnsignedIntSampler2DArrayExt = 36311,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8
        UnsignedIntSamplerBuffer = 36312,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8
        UnsignedIntSamplerBufferExt = 36312,
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
        //     Original was GL_GEOMETRY_SHADER_EXT = 0x8DD9
        GeometryShaderExt = 36313,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA
        GeometryVerticesOutArb = 36314,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_VERTICES_OUT_EXT = 0x8DDA
        GeometryVerticesOutExt = 36314,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB
        GeometryInputTypeArb = 36315,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_INPUT_TYPE_EXT = 0x8DDB
        GeometryInputTypeExt = 36315,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC
        GeometryOutputTypeArb = 36316,
        //
        // Resumo:
        //     Original was GL_GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC
        GeometryOutputTypeExt = 36316,
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
        //     Original was GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD
        MaxGeometryVaryingComponentsExt = 36317,
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
        //     Original was GL_MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE
        MaxVertexVaryingComponentsExt = 36318,
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
        //     Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF
        MaxGeometryUniformComponentsExt = 36319,
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
        //     Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0
        MaxGeometryOutputVerticesExt = 36320,
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
        //     Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1
        MaxGeometryTotalOutputComponentsExt = 36321,
        //
        // Resumo:
        //     Original was GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2
        MaxVertexBindableUniformsExt = 36322,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3
        MaxFragmentBindableUniformsExt = 36323,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4
        MaxGeometryBindableUniformsExt = 36324,
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
        //     Original was GL_MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED
        MaxBindableUniformSizeExt = 36333,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_EXT = 0x8DEE
        UniformBufferExt = 36334,
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER_BINDING_EXT = 0x8DEF
        UniformBufferBindingExt = 36335,
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
        //     Original was GL_TRANSFORM_FEEDBACK_NV = 0x8E22
        TransformFeedbackNv = 36386,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23
        TransformFeedbackBufferPaused = 36387,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23
        TransformFeedbackBufferPausedNv = 36387,
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
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24
        TransformFeedbackBufferActiveNv = 36388,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25
        TransformFeedbackBinding = 36389,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25
        TransformFeedbackBindingNv = 36389,
        //
        // Resumo:
        //     Original was GL_FRAME_NV = 0x8E26
        FrameNv = 36390,
        //
        // Resumo:
        //     Original was GL_FIELDS_NV = 0x8E27
        FieldsNv = 36391,
        //
        // Resumo:
        //     Original was GL_CURRENT_TIME_NV = 0x8E28
        CurrentTimeNv = 36392,
        //
        // Resumo:
        //     Original was GL_TIMESTAMP = 0x8E28
        Timestamp = 36392,
        //
        // Resumo:
        //     Original was GL_NUM_FILL_STREAMS_NV = 0x8E29
        NumFillStreamsNv = 36393,
        //
        // Resumo:
        //     Original was GL_PRESENT_TIME_NV = 0x8E2A
        PresentTimeNv = 36394,
        //
        // Resumo:
        //     Original was GL_PRESENT_DURATION_NV = 0x8E2B
        PresentDurationNv = 36395,
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
        //     Original was GL_TEXTURE_SWIZZLE_R_EXT = 0x8E42
        TextureSwizzleRExt = 36418,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        TextureSwizzleG = 36419,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_G_EXT = 0x8E43
        TextureSwizzleGExt = 36419,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        TextureSwizzleB = 36420,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_B_EXT = 0x8E44
        TextureSwizzleBExt = 36420,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        TextureSwizzleA = 36421,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_A_EXT = 0x8E45
        TextureSwizzleAExt = 36421,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
        TextureSwizzleRgba = 36422,
        //
        // Resumo:
        //     Original was GL_TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46
        TextureSwizzleRgbaExt = 36422,
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
        //     Original was GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C
        QuadsFollowProvokingVertexConventionExt = 36428,
        //
        // Resumo:
        //     Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        FirstVertexConvention = 36429,
        //
        // Resumo:
        //     Original was GL_FIRST_VERTEX_CONVENTION_EXT = 0x8E4D
        FirstVertexConventionExt = 36429,
        //
        // Resumo:
        //     Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        LastVertexConvention = 36430,
        //
        // Resumo:
        //     Original was GL_LAST_VERTEX_CONVENTION_EXT = 0x8E4E
        LastVertexConventionExt = 36430,
        //
        // Resumo:
        //     Original was GL_PROVOKING_VERTEX = 0x8E4F
        ProvokingVertex = 36431,
        //
        // Resumo:
        //     Original was GL_PROVOKING_VERTEX_EXT = 0x8E4F
        ProvokingVertexExt = 36431,
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
        //     Original was GL_SAMPLE_POSITION_NV = 0x8E50
        SamplePositionNv = 36432,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK = 0x8E51
        SampleMask = 36433,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_NV = 0x8E51
        SampleMaskNv = 36433,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_VALUE = 0x8E52
        SampleMaskValue = 36434,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_VALUE_NV = 0x8E52
        SampleMaskValueNv = 36434,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53
        TextureBindingRenderbufferNv = 36435,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54
        TextureRenderbufferDataStoreBindingNv = 36436,
        //
        // Resumo:
        //     Original was GL_TEXTURE_RENDERBUFFER_NV = 0x8E55
        TextureRenderbufferNv = 36437,
        //
        // Resumo:
        //     Original was GL_SAMPLER_RENDERBUFFER_NV = 0x8E56
        SamplerRenderbufferNv = 36438,
        //
        // Resumo:
        //     Original was GL_INT_SAMPLER_RENDERBUFFER_NV = 0x8E57
        IntSamplerRenderbufferNv = 36439,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58
        UnsignedIntSamplerRenderbufferNv = 36440,
        //
        // Resumo:
        //     Original was GL_MAX_SAMPLE_MASK_WORDS = 0x8E59
        MaxSampleMaskWords = 36441,
        //
        // Resumo:
        //     Original was GL_MAX_SAMPLE_MASK_WORDS_NV = 0x8E59
        MaxSampleMaskWordsNv = 36441,
        //
        // Resumo:
        //     Original was GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A
        MaxGeometryProgramInvocationsNv = 36442,
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
        //     Original was GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B
        MinFragmentInterpolationOffsetNv = 36443,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C
        MaxFragmentInterpolationOffset = 36444,
        //
        // Resumo:
        //     Original was GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C
        MaxFragmentInterpolationOffsetNv = 36444,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D
        FragmentInterpolationOffsetBits = 36445,
        //
        // Resumo:
        //     Original was GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D
        FragmentProgramInterpolationOffsetBitsNv = 36445,
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
        //     Original was GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E
        MinProgramTextureGatherOffsetNv = 36446,
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
        //     Original was GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F
        MaxProgramTextureGatherOffsetNv = 36447,
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
        //     Original was GL_MAX_IMAGE_UNITS_EXT = 0x8F38
        MaxImageUnitsExt = 36664,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39
        MaxCombinedImageUnitsAndFragmentOutputs = 36665,
        //
        // Resumo:
        //     Original was GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39
        MaxCombinedImageUnitsAndFragmentOutputsExt = 36665,
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
        //     Original was GL_IMAGE_BINDING_NAME_EXT = 0x8F3A
        ImageBindingNameExt = 36666,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LEVEL = 0x8F3B
        ImageBindingLevel = 36667,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LEVEL_EXT = 0x8F3B
        ImageBindingLevelExt = 36667,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LAYERED = 0x8F3C
        ImageBindingLayered = 36668,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LAYERED_EXT = 0x8F3C
        ImageBindingLayeredExt = 36668,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LAYER = 0x8F3D
        ImageBindingLayer = 36669,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_LAYER_EXT = 0x8F3D
        ImageBindingLayerExt = 36669,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_ACCESS = 0x8F3E
        ImageBindingAccess = 36670,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_ACCESS_EXT = 0x8F3E
        ImageBindingAccessExt = 36670,
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
        //     Original was GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44
        MaxProgramSubroutineParametersNv = 36676,
        //
        // Resumo:
        //     Original was GL_MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45
        MaxProgramSubroutineNumNv = 36677,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2 = 0x8F46
        DoubleMat2 = 36678,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2_EXT = 0x8F46
        DoubleMat2Ext = 36678,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3 = 0x8F47
        DoubleMat3 = 36679,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3_EXT = 0x8F47
        DoubleMat3Ext = 36679,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4 = 0x8F48
        DoubleMat4 = 36680,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4_EXT = 0x8F48
        DoubleMat4Ext = 36680,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2x3 = 0x8F49
        DoubleMat2x3 = 36681,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2x3_EXT = 0x8F49
        DoubleMat2x3Ext = 36681,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2x4 = 0x8F4A
        DoubleMat2x4 = 36682,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT2x4_EXT = 0x8F4A
        DoubleMat2x4Ext = 36682,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3x2 = 0x8F4B
        DoubleMat3x2 = 36683,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3x2_EXT = 0x8F4B
        DoubleMat3x2Ext = 36683,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3x4 = 0x8F4C
        DoubleMat3x4 = 36684,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT3x4_EXT = 0x8F4C
        DoubleMat3x4Ext = 36684,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4x2 = 0x8F4D
        DoubleMat4x2 = 36685,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4x2_EXT = 0x8F4D
        DoubleMat4x2Ext = 36685,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4x3 = 0x8F4E
        DoubleMat4x3 = 36686,
        //
        // Resumo:
        //     Original was GL_DOUBLE_MAT4x3_EXT = 0x8F4E
        DoubleMat4x3Ext = 36686,
        //
        // Resumo:
        //     Original was GL_VERTEX_BINDING_BUFFER = 0x8F4F
        VertexBindingBuffer = 36687,
        //
        // Resumo:
        //     Original was GL_RED_SNORM = 0x8F90
        RedSnorm = 36752,
        //
        // Resumo:
        //     Original was GL_RG_SNORM = 0x8F91
        RgSnorm = 36753,
        //
        // Resumo:
        //     Original was GL_RGB_SNORM = 0x8F92
        RgbSnorm = 36754,
        //
        // Resumo:
        //     Original was GL_RGBA_SNORM = 0x8F93
        RgbaSnorm = 36755,
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
        //     Original was GL_DOUBLE_VEC2_EXT = 0x8FFC
        DoubleVec2Ext = 36860,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC3 = 0x8FFD
        DoubleVec3 = 36861,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC3_EXT = 0x8FFD
        DoubleVec3Ext = 36861,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC4 = 0x8FFE
        DoubleVec4 = 36862,
        //
        // Resumo:
        //     Original was GL_DOUBLE_VEC4_EXT = 0x8FFE
        DoubleVec4Ext = 36862,
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
        //     Original was GL_ALPHA_SNORM = 0x9010
        AlphaSnorm = 36880,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_SNORM = 0x9011
        LuminanceSnorm = 36881,
        //
        // Resumo:
        //     Original was GL_LUMINANCE_ALPHA_SNORM = 0x9012
        LuminanceAlphaSnorm = 36882,
        //
        // Resumo:
        //     Original was GL_INTENSITY_SNORM = 0x9013
        IntensitySnorm = 36883,
        //
        // Resumo:
        //     Original was GL_ALPHA8_SNORM = 0x9014
        Alpha8Snorm = 36884,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8_SNORM = 0x9015
        Luminance8Snorm = 36885,
        //
        // Resumo:
        //     Original was GL_LUMINANCE8_ALPHA8_SNORM = 0x9016
        Luminance8Alpha8Snorm = 36886,
        //
        // Resumo:
        //     Original was GL_INTENSITY8_SNORM = 0x9017
        Intensity8Snorm = 36887,
        //
        // Resumo:
        //     Original was GL_ALPHA16_SNORM = 0x9018
        Alpha16Snorm = 36888,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16_SNORM = 0x9019
        Luminance16Snorm = 36889,
        //
        // Resumo:
        //     Original was GL_LUMINANCE16_ALPHA16_SNORM = 0x901A
        Luminance16Alpha16Snorm = 36890,
        //
        // Resumo:
        //     Original was GL_INTENSITY16_SNORM = 0x901B
        Intensity16Snorm = 36891,
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
        //     Original was GL_DEPTH_CLAMP_NEAR_AMD = 0x901E
        DepthClampNearAmd = 36894,
        //
        // Resumo:
        //     Original was GL_DEPTH_CLAMP_FAR_AMD = 0x901F
        DepthClampFarAmd = 36895,
        //
        // Resumo:
        //     Original was GL_VIDEO_BUFFER_NV = 0x9020
        VideoBufferNv = 36896,
        //
        // Resumo:
        //     Original was GL_VIDEO_BUFFER_BINDING_NV = 0x9021
        VideoBufferBindingNv = 36897,
        //
        // Resumo:
        //     Original was GL_FIELD_UPPER_NV = 0x9022
        FieldUpperNv = 36898,
        //
        // Resumo:
        //     Original was GL_FIELD_LOWER_NV = 0x9023
        FieldLowerNv = 36899,
        //
        // Resumo:
        //     Original was GL_NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024
        NumVideoCaptureStreamsNv = 36900,
        //
        // Resumo:
        //     Original was GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025
        NextVideoCaptureBufferStatusNv = 36901,
        //
        // Resumo:
        //     Original was GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026
        VideoCaptureTo422SupportedNv = 36902,
        //
        // Resumo:
        //     Original was GL_LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027
        LastVideoCaptureStatusNv = 36903,
        //
        // Resumo:
        //     Original was GL_VIDEO_BUFFER_PITCH_NV = 0x9028
        VideoBufferPitchNv = 36904,
        //
        // Resumo:
        //     Original was GL_VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029
        VideoColorConversionMatrixNv = 36905,
        //
        // Resumo:
        //     Original was GL_VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A
        VideoColorConversionMaxNv = 36906,
        //
        // Resumo:
        //     Original was GL_VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B
        VideoColorConversionMinNv = 36907,
        //
        // Resumo:
        //     Original was GL_VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C
        VideoColorConversionOffsetNv = 36908,
        //
        // Resumo:
        //     Original was GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D
        VideoBufferInternalFormatNv = 36909,
        //
        // Resumo:
        //     Original was GL_PARTIAL_SUCCESS_NV = 0x902E
        PartialSuccessNv = 36910,
        //
        // Resumo:
        //     Original was GL_SUCCESS_NV = 0x902F
        SuccessNv = 36911,
        //
        // Resumo:
        //     Original was GL_FAILURE_NV = 0x9030
        FailureNv = 36912,
        //
        // Resumo:
        //     Original was GL_YCBYCR8_422_NV = 0x9031
        Ycbycr8422Nv = 36913,
        //
        // Resumo:
        //     Original was GL_YCBAYCR8A_4224_NV = 0x9032
        Ycbaycr8A4224Nv = 36914,
        //
        // Resumo:
        //     Original was GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033
        Z6y10z6cb10z6y10z6cr10422Nv = 36915,
        //
        // Resumo:
        //     Original was GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034
        Z6y10z6cb10z6A10z6y10z6cr10z6A104224Nv = 36916,
        //
        // Resumo:
        //     Original was GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035
        Z4y12z4cb12z4y12z4cr12422Nv = 36917,
        //
        // Resumo:
        //     Original was GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036
        Z4y12z4cb12z4A12z4y12z4cr12z4A124224Nv = 36918,
        //
        // Resumo:
        //     Original was GL_Z4Y12Z4CB12Z4CR12_444_NV = 0x9037
        Z4y12z4cb12z4cr12444Nv = 36919,
        //
        // Resumo:
        //     Original was GL_VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038
        VideoCaptureFrameWidthNv = 36920,
        //
        // Resumo:
        //     Original was GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039
        VideoCaptureFrameHeightNv = 36921,
        //
        // Resumo:
        //     Original was GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A
        VideoCaptureFieldUpperHeightNv = 36922,
        //
        // Resumo:
        //     Original was GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B
        VideoCaptureFieldLowerHeightNv = 36923,
        //
        // Resumo:
        //     Original was GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C
        VideoCaptureSurfaceOriginNv = 36924,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COVERAGE_SAMPLES_NV = 0x9045
        TextureCoverageSamplesNv = 36933,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COLOR_SAMPLES_NV = 0x9046
        TextureColorSamplesNv = 36934,
        //
        // Resumo:
        //     Original was GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX = 0x9047
        GpuMemoryInfoDedicatedVidmemNvx = 36935,
        //
        // Resumo:
        //     Original was GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX = 0x9048
        GpuMemoryInfoTotalAvailableMemoryNvx = 36936,
        //
        // Resumo:
        //     Original was GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX = 0x9049
        GpuMemoryInfoCurrentAvailableVidmemNvx = 36937,
        //
        // Resumo:
        //     Original was GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX = 0x904A
        GpuMemoryInfoEvictionCountNvx = 36938,
        //
        // Resumo:
        //     Original was GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX = 0x904B
        GpuMemoryInfoEvictedMemoryNvx = 36939,
        //
        // Resumo:
        //     Original was GL_IMAGE_1D = 0x904C
        Image1D = 36940,
        //
        // Resumo:
        //     Original was GL_IMAGE_1D_EXT = 0x904C
        Image1DExt = 36940,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D = 0x904D
        Image2D = 36941,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_EXT = 0x904D
        Image2DExt = 36941,
        //
        // Resumo:
        //     Original was GL_IMAGE_3D = 0x904E
        Image3D = 36942,
        //
        // Resumo:
        //     Original was GL_IMAGE_3D_EXT = 0x904E
        Image3DExt = 36942,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_RECT = 0x904F
        Image2DRect = 36943,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_RECT_EXT = 0x904F
        Image2DRectExt = 36943,
        //
        // Resumo:
        //     Original was GL_IMAGE_CUBE = 0x9050
        ImageCube = 36944,
        //
        // Resumo:
        //     Original was GL_IMAGE_CUBE_EXT = 0x9050
        ImageCubeExt = 36944,
        //
        // Resumo:
        //     Original was GL_IMAGE_BUFFER = 0x9051
        ImageBuffer = 36945,
        //
        // Resumo:
        //     Original was GL_IMAGE_BUFFER_EXT = 0x9051
        ImageBufferExt = 36945,
        //
        // Resumo:
        //     Original was GL_IMAGE_1D_ARRAY = 0x9052
        Image1DArray = 36946,
        //
        // Resumo:
        //     Original was GL_IMAGE_1D_ARRAY_EXT = 0x9052
        Image1DArrayExt = 36946,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_ARRAY = 0x9053
        Image2DArray = 36947,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_ARRAY_EXT = 0x9053
        Image2DArrayExt = 36947,
        //
        // Resumo:
        //     Original was GL_IMAGE_CUBE_MAP_ARRAY = 0x9054
        ImageCubeMapArray = 36948,
        //
        // Resumo:
        //     Original was GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054
        ImageCubeMapArrayExt = 36948,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_MULTISAMPLE = 0x9055
        Image2DMultisample = 36949,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_MULTISAMPLE_EXT = 0x9055
        Image2DMultisampleExt = 36949,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056
        Image2DMultisampleArray = 36950,
        //
        // Resumo:
        //     Original was GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056
        Image2DMultisampleArrayExt = 36950,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_1D = 0x9057
        IntImage1D = 36951,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_1D_EXT = 0x9057
        IntImage1DExt = 36951,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D = 0x9058
        IntImage2D = 36952,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_EXT = 0x9058
        IntImage2DExt = 36952,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_3D = 0x9059
        IntImage3D = 36953,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_3D_EXT = 0x9059
        IntImage3DExt = 36953,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_RECT = 0x905A
        IntImage2DRect = 36954,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_RECT_EXT = 0x905A
        IntImage2DRectExt = 36954,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_CUBE = 0x905B
        IntImageCube = 36955,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_CUBE_EXT = 0x905B
        IntImageCubeExt = 36955,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_BUFFER = 0x905C
        IntImageBuffer = 36956,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_BUFFER_EXT = 0x905C
        IntImageBufferExt = 36956,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_1D_ARRAY = 0x905D
        IntImage1DArray = 36957,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_1D_ARRAY_EXT = 0x905D
        IntImage1DArrayExt = 36957,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_ARRAY = 0x905E
        IntImage2DArray = 36958,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_ARRAY_EXT = 0x905E
        IntImage2DArrayExt = 36958,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F
        IntImageCubeMapArray = 36959,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F
        IntImageCubeMapArrayExt = 36959,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060
        IntImage2DMultisample = 36960,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060
        IntImage2DMultisampleExt = 36960,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061
        IntImage2DMultisampleArray = 36961,
        //
        // Resumo:
        //     Original was GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061
        IntImage2DMultisampleArrayExt = 36961,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_1D = 0x9062
        UnsignedIntImage1D = 36962,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_1D_EXT = 0x9062
        UnsignedIntImage1DExt = 36962,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D = 0x9063
        UnsignedIntImage2D = 36963,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_EXT = 0x9063
        UnsignedIntImage2DExt = 36963,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_3D = 0x9064
        UnsignedIntImage3D = 36964,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_3D_EXT = 0x9064
        UnsignedIntImage3DExt = 36964,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065
        UnsignedIntImage2DRect = 36965,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065
        UnsignedIntImage2DRectExt = 36965,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066
        UnsignedIntImageCube = 36966,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066
        UnsignedIntImageCubeExt = 36966,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067
        UnsignedIntImageBuffer = 36967,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067
        UnsignedIntImageBufferExt = 36967,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068
        UnsignedIntImage1DArray = 36968,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068
        UnsignedIntImage1DArrayExt = 36968,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069
        UnsignedIntImage2DArray = 36969,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069
        UnsignedIntImage2DArrayExt = 36969,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A
        UnsignedIntImageCubeMapArray = 36970,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A
        UnsignedIntImageCubeMapArrayExt = 36970,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B
        UnsignedIntImage2DMultisample = 36971,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B
        UnsignedIntImage2DMultisampleExt = 36971,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C
        UnsignedIntImage2DMultisampleArray = 36972,
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C
        UnsignedIntImage2DMultisampleArrayExt = 36972,
        //
        // Resumo:
        //     Original was GL_MAX_IMAGE_SAMPLES = 0x906D
        MaxImageSamples = 36973,
        //
        // Resumo:
        //     Original was GL_MAX_IMAGE_SAMPLES_EXT = 0x906D
        MaxImageSamplesExt = 36973,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_FORMAT = 0x906E
        ImageBindingFormat = 36974,
        //
        // Resumo:
        //     Original was GL_IMAGE_BINDING_FORMAT_EXT = 0x906E
        ImageBindingFormatExt = 36974,
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
        //     Original was GL_SCALED_RESOLVE_FASTEST_EXT = 0x90BA
        ScaledResolveFastestExt = 37050,
        //
        // Resumo:
        //     Original was GL_SCALED_RESOLVE_NICEST_EXT = 0x90BB
        ScaledResolveNicestExt = 37051,
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
        //     Original was GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV = 0x90D0
        MaxDeep3DTextureWidthHeightNv = 37072,
        //
        // Resumo:
        //     Original was GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV = 0x90D1
        MaxDeep3DTextureDepthNv = 37073,
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
        //     Original was GL_SYNC_X11_FENCE_EXT = 0x90E1
        SyncX11FenceExt = 37089,
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
        //     Original was GL_COMPUTE_PROGRAM_NV = 0x90FB
        ComputeProgramNv = 37115,
        //
        // Resumo:
        //     Original was GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV = 0x90FC
        ComputeProgramParameterBufferNv = 37116,
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
        //     Original was GL_MAX_DEBUG_MESSAGE_LENGTH_AMD = 0x9143
        MaxDebugMessageLengthAmd = 37187,
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
        //     Original was GL_MAX_DEBUG_LOGGED_MESSAGES_AMD = 0x9144
        MaxDebugLoggedMessagesAmd = 37188,
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
        //     Original was GL_DEBUG_LOGGED_MESSAGES_AMD = 0x9145
        DebugLoggedMessagesAmd = 37189,
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
        //     Original was GL_DEBUG_SEVERITY_HIGH_AMD = 0x9146
        DebugSeverityHighAmd = 37190,
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
        //     Original was GL_DEBUG_SEVERITY_MEDIUM_AMD = 0x9147
        DebugSeverityMediumAmd = 37191,
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
        //     Original was GL_DEBUG_SEVERITY_LOW_AMD = 0x9148
        DebugSeverityLowAmd = 37192,
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
        //     Original was GL_DEBUG_CATEGORY_API_ERROR_AMD = 0x9149
        DebugCategoryApiErrorAmd = 37193,
        //
        // Resumo:
        //     Original was GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD = 0x914A
        DebugCategoryWindowSystemAmd = 37194,
        //
        // Resumo:
        //     Original was GL_DEBUG_CATEGORY_DEPRECATION_AMD = 0x914B
        DebugCategoryDeprecationAmd = 37195,
        //
        // Resumo:
        //     Original was GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD = 0x914C
        DebugCategoryUndefinedBehaviorAmd = 37196,
        //
        // Resumo:
        //     Original was GL_DEBUG_CATEGORY_PERFORMANCE_AMD = 0x914D
        DebugCategoryPerformanceAmd = 37197,
        //
        // Resumo:
        //     Original was GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD = 0x914E
        DebugCategoryShaderCompilerAmd = 37198,
        //
        // Resumo:
        //     Original was GL_DEBUG_CATEGORY_APPLICATION_AMD = 0x914F
        DebugCategoryApplicationAmd = 37199,
        //
        // Resumo:
        //     Original was GL_DEBUG_CATEGORY_OTHER_AMD = 0x9150
        DebugCategoryOtherAmd = 37200,
        //
        // Resumo:
        //     Original was GL_BUFFER_OBJECT_EXT = 0x9151
        BufferObjectExt = 37201,
        //
        // Resumo:
        //     Original was GL_DATA_BUFFER_AMD = 0x9151
        DataBufferAmd = 37201,
        //
        // Resumo:
        //     Original was GL_PERFORMANCE_MONITOR_AMD = 0x9152
        PerformanceMonitorAmd = 37202,
        //
        // Resumo:
        //     Original was GL_QUERY_OBJECT_AMD = 0x9153
        QueryObjectAmd = 37203,
        //
        // Resumo:
        //     Original was GL_QUERY_OBJECT_EXT = 0x9153
        QueryObjectExt = 37203,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_OBJECT_AMD = 0x9154
        VertexArrayObjectAmd = 37204,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154
        VertexArrayObjectExt = 37204,
        //
        // Resumo:
        //     Original was GL_SAMPLER_OBJECT_AMD = 0x9155
        SamplerObjectAmd = 37205,
        //
        // Resumo:
        //     Original was GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160
        ExternalVirtualMemoryBufferAmd = 37216,
        //
        // Resumo:
        //     Original was GL_QUERY_BUFFER = 0x9192
        QueryBuffer = 37266,
        //
        // Resumo:
        //     Original was GL_QUERY_BUFFER_AMD = 0x9192
        QueryBufferAmd = 37266,
        //
        // Resumo:
        //     Original was GL_QUERY_BUFFER_BINDING = 0x9193
        QueryBufferBinding = 37267,
        //
        // Resumo:
        //     Original was GL_QUERY_BUFFER_BINDING_AMD = 0x9193
        QueryBufferBindingAmd = 37267,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT_NO_WAIT = 0x9194
        QueryResultNoWait = 37268,
        //
        // Resumo:
        //     Original was GL_QUERY_RESULT_NO_WAIT_AMD = 0x9194
        QueryResultNoWaitAmd = 37268,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_X_AMD = 0x9195
        VirtualPageSizeXAmd = 37269,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195
        VirtualPageSizeXArb = 37269,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_Y_AMD = 0x9196
        VirtualPageSizeYAmd = 37270,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196
        VirtualPageSizeYArb = 37270,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_Z_AMD = 0x9197
        VirtualPageSizeZAmd = 37271,
        //
        // Resumo:
        //     Original was GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197
        VirtualPageSizeZArb = 37271,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_TEXTURE_SIZE_AMD = 0x9198
        MaxSparseTextureSizeAmd = 37272,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198
        MaxSparseTextureSizeArb = 37272,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD = 0x9199
        MaxSparse3DTextureSizeAmd = 37273,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199
        MaxSparse3DTextureSizeArb = 37273,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A
        MaxSparseArrayTextureLayers = 37274,
        //
        // Resumo:
        //     Original was GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A
        MaxSparseArrayTextureLayersArb = 37274,
        //
        // Resumo:
        //     Original was GL_MIN_SPARSE_LEVEL_AMD = 0x919B
        MinSparseLevelAmd = 37275,
        //
        // Resumo:
        //     Original was GL_MIN_LOD_WARNING_AMD = 0x919C
        MinLodWarningAmd = 37276,
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
        //     Original was GL_STREAM_RASTERIZATION_AMD = 0x91A0
        StreamRasterizationAmd = 37280,
        //
        // Resumo:
        //     Original was GL_VERTEX_ELEMENT_SWIZZLE_AMD = 0x91A4
        VertexElementSwizzleAmd = 37284,
        //
        // Resumo:
        //     Original was GL_VERTEX_ID_SWIZZLE_AMD = 0x91A5
        VertexIdSwizzleAmd = 37285,
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
        //     Original was GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD = 0x91AE
        PixelsPerSamplePatternXAmd = 37294,
        //
        // Resumo:
        //     Original was GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD = 0x91AF
        PixelsPerSamplePatternYAmd = 37295,
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
        //     Original was GL_FLOAT16_MAT2_AMD = 0x91C5
        Float16Mat2Amd = 37317,
        //
        // Resumo:
        //     Original was GL_FLOAT16_MAT3_AMD = 0x91C6
        Float16Mat3Amd = 37318,
        //
        // Resumo:
        //     Original was GL_FLOAT16_MAT4_AMD = 0x91C7
        Float16Mat4Amd = 37319,
        //
        // Resumo:
        //     Original was GL_FLOAT16_MAT2x3_AMD = 0x91C8
        Float16Mat2x3Amd = 37320,
        //
        // Resumo:
        //     Original was GL_FLOAT16_MAT2x4_AMD = 0x91C9
        Float16Mat2x4Amd = 37321,
        //
        // Resumo:
        //     Original was GL_FLOAT16_MAT3x2_AMD = 0x91CA
        Float16Mat3x2Amd = 37322,
        //
        // Resumo:
        //     Original was GL_FLOAT16_MAT3x4_AMD = 0x91CB
        Float16Mat3x4Amd = 37323,
        //
        // Resumo:
        //     Original was GL_FLOAT16_MAT4x2_AMD = 0x91CC
        Float16Mat4x2Amd = 37324,
        //
        // Resumo:
        //     Original was GL_FLOAT16_MAT4x3_AMD = 0x91CD
        Float16Mat4x3Amd = 37325,
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
        //     Original was GL_MAX_LGPU_GPUS_NVX = 0x92BA
        MaxLgpuGpusNvx = 37562,
        //
        // Resumo:
        //     Original was GL_MULTICAST_GPUS_NV = 0x92BA
        MulticastGpusNv = 37562,
        //
        // Resumo:
        //     Original was GL_PURGED_CONTEXT_RESET_NV = 0x92BB
        PurgedContextResetNv = 37563,
        //
        // Resumo:
        //     Original was GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE
        PrimitiveBoundingBoxArb = 37566,
        //
        // Resumo:
        //     Original was GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV = 0x92BF
        AlphaToCoverageDitherModeNv = 37567,
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
        //     Original was GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV = 0x934D
        AlphaToCoverageDitherDefaultNv = 37709,
        //
        // Resumo:
        //     Original was GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV = 0x934E
        AlphaToCoverageDitherEnableNv = 37710,
        //
        // Resumo:
        //     Original was GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV = 0x934F
        AlphaToCoverageDitherDisableNv = 37711,
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
        //     Original was GL_QUERY_RESOURCE_TYPE_VIDMEM_ALLOC_NV = 0x9540
        QueryResourceTypeVidmemAllocNv = 38208,
        //
        // Resumo:
        //     Original was GL_QUERY_RESOURCE_MEMTYPE_VIDMEM_NV = 0x9542
        QueryResourceMemtypeVidmemNv = 38210,
        //
        // Resumo:
        //     Original was GL_QUERY_RESOURCE_SYS_RESERVED_NV = 0x9544
        QueryResourceSysReservedNv = 38212,
        //
        // Resumo:
        //     Original was GL_QUERY_RESOURCE_TEXTURE_NV = 0x9545
        QueryResourceTextureNv = 38213,
        //
        // Resumo:
        //     Original was GL_QUERY_RESOURCE_RENDERBUFFER_NV = 0x9546
        QueryResourceRenderbufferNv = 38214,
        //
        // Resumo:
        //     Original was GL_QUERY_RESOURCE_BUFFEROBJECT_NV = 0x9547
        QueryResourceBufferobjectNv = 38215,
        //
        // Resumo:
        //     Original was GL_PER_GPU_STORAGE_NV = 0x9548
        PerGpuStorageNv = 38216,
        //
        // Resumo:
        //     Original was GL_MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9549
        MulticastProgrammableSampleLocationNv = 38217,
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
        //     Original was GL_RENDER_GPU_MASK_NV = 0x9558
        RenderGpuMaskNv = 38232,
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
        //     Original was GL_NUM_TILING_TYPES_EXT = 0x9582
        NumTilingTypesExt = 38274,
        //
        // Resumo:
        //     Original was GL_TILING_TYPES_EXT = 0x9583
        TilingTypesExt = 38275,
        //
        // Resumo:
        //     Original was GL_OPTIMAL_TILING_EXT = 0x9584
        OptimalTilingExt = 38276,
        //
        // Resumo:
        //     Original was GL_LINEAR_TILING_EXT = 0x9585
        LinearTilingExt = 38277,
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
        //     Original was GL_NUM_DEVICE_UUIDS_EXT = 0x9596
        NumDeviceUuidsExt = 38294,
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
        //     Original was GL_COLOR3_BIT_PGI = 0x00010000
        Color3BitPgi = 65536,
        //
        // Resumo:
        //     Original was GL_EVAL_BIT = 0x00010000
        EvalBit = 65536,
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
        //     Original was GL_RASTER_POSITION_UNCLIPPED_IBM = 0x19262
        RasterPositionUnclippedIbm = 103010,
        //
        // Resumo:
        //     Original was GL_CULL_VERTEX_IBM = 103050
        CullVertexIbm = 103050,
        //
        // Resumo:
        //     Original was GL_ALL_STATIC_DATA_IBM = 103060
        AllStaticDataIbm = 103060,
        //
        // Resumo:
        //     Original was GL_STATIC_VERTEX_ARRAY_IBM = 103061
        StaticVertexArrayIbm = 103061,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_LIST_IBM = 103070
        VertexArrayListIbm = 103070,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_LIST_IBM = 103071
        NormalArrayListIbm = 103071,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_LIST_IBM = 103072
        ColorArrayListIbm = 103072,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_LIST_IBM = 103073
        IndexArrayListIbm = 103073,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_LIST_IBM = 103074
        TextureCoordArrayListIbm = 103074,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_LIST_IBM = 103075
        EdgeFlagArrayListIbm = 103075,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_LIST_IBM = 103076
        FogCoordinateArrayListIbm = 103076,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_LIST_IBM = 103077
        SecondaryColorArrayListIbm = 103077,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_LIST_STRIDE_IBM = 103080
        VertexArrayListStrideIbm = 103080,
        //
        // Resumo:
        //     Original was GL_NORMAL_ARRAY_LIST_STRIDE_IBM = 103081
        NormalArrayListStrideIbm = 103081,
        //
        // Resumo:
        //     Original was GL_COLOR_ARRAY_LIST_STRIDE_IBM = 103082
        ColorArrayListStrideIbm = 103082,
        //
        // Resumo:
        //     Original was GL_INDEX_ARRAY_LIST_STRIDE_IBM = 103083
        IndexArrayListStrideIbm = 103083,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084
        TextureCoordArrayListStrideIbm = 103084,
        //
        // Resumo:
        //     Original was GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085
        EdgeFlagArrayListStrideIbm = 103085,
        //
        // Resumo:
        //     Original was GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086
        FogCoordinateArrayListStrideIbm = 103086,
        //
        // Resumo:
        //     Original was GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087
        SecondaryColorArrayListStrideIbm = 103087,
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
        //     Original was GL_NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202
        NativeGraphicsHandlePgi = 107010,
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
        //     Original was GL_COLOR4_BIT_PGI = 0x00020000
        Color4BitPgi = 131072,
        //
        // Resumo:
        //     Original was GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000
        FontYMinBoundsBitNv = 131072,
        //
        // Resumo:
        //     Original was GL_LIST_BIT = 0x00020000
        ListBit = 131072,
        //
        // Resumo:
        //     Original was GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000
        StencilBufferBit1Qcom = 131072,
        //
        // Resumo:
        //     Original was GL_EDGEFLAG_BIT_PGI = 0x00040000
        EdgeflagBitPgi = 262144,
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
        //     Original was GL_TEXTURE_BIT = 0x00040000
        TextureBit = 262144,
        //
        // Resumo:
        //     Original was GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000
        FontYMaxBoundsBitNv = 524288,
        //
        // Resumo:
        //     Original was GL_INDEX_BIT_PGI = 0x00080000
        IndexBitPgi = 524288,
        //
        // Resumo:
        //     Original was GL_SCISSOR_BIT = 0x00080000
        ScissorBit = 524288,
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
        //     Original was GL_MAT_AMBIENT_BIT_PGI = 0x00100000
        MatAmbientBitPgi = 1048576,
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
        //     Original was GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000
        MatAmbientAndDiffuseBitPgi = 2097152,
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
        //     Original was GL_MAT_DIFFUSE_BIT_PGI = 0x00400000
        MatDiffuseBitPgi = 4194304,
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
        //     Original was GL_MAT_EMISSION_BIT_PGI = 0x00800000
        MatEmissionBitPgi = 8388608,
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
        //     Original was GL_MAT_COLOR_INDEXES_BIT_PGI = 0x01000000
        MatColorIndexesBitPgi = 16777216,
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
        //     Original was GL_MAT_SHININESS_BIT_PGI = 0x02000000
        MatShininessBitPgi = 33554432,
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
        //     Original was GL_MAT_SPECULAR_BIT_PGI = 0x04000000
        MatSpecularBitPgi = 67108864,
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
        //     Original was GL_NORMAL_BIT_PGI = 0x08000000
        NormalBitPgi = 134217728,
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
        //     Original was GL_TEXCOORD1_BIT_PGI = 0x10000000
        Texcoord1BitPgi = 268435456,
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
        //     Original was GL_TEXCOORD2_BIT_PGI = 0x20000000
        Texcoord2BitPgi = 536870912,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000
        MultisampleBufferBit6Qcom = 1073741824,
        //
        // Resumo:
        //     Original was GL_TEXCOORD3_BIT_PGI = 0x40000000
        Texcoord3BitPgi = 1073741824
    }

    public enum ProgramParameter
    {
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
        //     Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        GeometryShaderInvocations = 34943,
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
        //     Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        ActiveUniformBlockMaxNameLength = 35381,
        //
        // Resumo:
        //     Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        ActiveUniformBlocks = 35382,
        //
        // Resumo:
        //     Original was GL_DELETE_STATUS = 0x8B80
        DeleteStatus = 35712,
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
        //     Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        ActiveAttributes = 35721,
        //
        // Resumo:
        //     Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        ActiveAttributeMaxLength = 35722,
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
        //     Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        TransformFeedbackVaryings = 35971,
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
        //     Original was GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF
        MaxComputeWorkGroupSize = 37311,
        //
        // Resumo:
        //     Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        ActiveAtomicCounterBuffers = 37593
    }

    public enum CullFaceMode
    {
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
        //     Original was GL_FRONT_AND_BACK = 0x0408
        FrontAndBack = 1032
    }

    public enum FrontFaceDirection
    {
        //
        // Resumo:
        //     Original was GL_CW = 0x0900
        Cw = 2304,
        //
        // Resumo:
        //     Original was GL_CCW = 0x0901
        Ccw = 2305
    }

    public enum HintTarget
    {
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
        //     Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        PackCmykHintExt = 32782,
        //
        // Resumo:
        //     Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        UnpackCmykHintExt = 32783,
        //
        // Resumo:
        //     Original was GL_PHONG_HINT_WIN = 0x80EB
        PhongHintWin = 33003,
        //
        // Resumo:
        //     Original was GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
        ClipVolumeClippingHintExt = 33008,
        //
        // Resumo:
        //     Original was GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
        TextureMultiBufferHintSgix = 33070,
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
        //     Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        ProgramBinaryRetrievableHint = 33367,
        //
        // Resumo:
        //     Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        ConvolutionHintSgix = 33558,
        //
        // Resumo:
        //     Original was GL_SCALEBIAS_HINT_SGIX = 0x8322
        ScalebiasHintSgix = 33570,
        //
        // Resumo:
        //     Original was GL_LINE_QUALITY_HINT_SGIX = 0x835B
        LineQualityHintSgix = 33627,
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
        //     Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        TextureCompressionHint = 34031,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        TextureCompressionHintArb = 34031,
        //
        // Resumo:
        //     Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        VertexArrayStorageHintApple = 34079,
        //
        // Resumo:
        //     Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        MultisampleFilterHintNv = 34100,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        TransformHintApple = 34225,
        //
        // Resumo:
        //     Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        TextureStorageHintApple = 34236,
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
        //     Original was GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0
        BinningControlHintQcom = 36784,
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
        MaxVertexHintPgi = 107053
    }

    public enum HintMode
    {
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
        Nicest = 4354
    }

    public enum MaterialFace
    {
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
        //     Original was GL_FRONT_AND_BACK = 0x0408
        FrontAndBack = 1032
    }

    public enum PolygonMode
    {
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
        Fill = 6914
    }

    public enum DrawBufferMode
    {
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
        //     Original was GL_FRONT_LEFT = 0x0400
        FrontLeft = 1024,
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
        //     Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        ColorAttachment0 = 36064,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        ColorAttachment1 = 36065,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        ColorAttachment2 = 36066,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        ColorAttachment3 = 36067,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        ColorAttachment4 = 36068,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        ColorAttachment5 = 36069,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        ColorAttachment6 = 36070,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        ColorAttachment7 = 36071,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        ColorAttachment8 = 36072,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        ColorAttachment9 = 36073,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        ColorAttachment10 = 36074,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        ColorAttachment11 = 36075,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        ColorAttachment12 = 36076,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        ColorAttachment13 = 36077,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        ColorAttachment14 = 36078,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        ColorAttachment15 = 36079
    }

    public enum BlendEquationMode
    {
        //
        // Resumo:
        //     Original was GL_FUNC_ADD = 0x8006
        FuncAdd = 32774,
        //
        // Resumo:
        //     Original was GL_MIN = 0x8007
        Min = 32775,
        //
        // Resumo:
        //     Original was GL_MAX = 0x8008
        Max = 32776,
        //
        // Resumo:
        //     Original was GL_FUNC_SUBTRACT = 0x800A
        FuncSubtract = 32778,
        //
        // Resumo:
        //     Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        FuncReverseSubtract = 32779
    }

    public enum ReadBufferMode
    {
        //
        // Resumo:
        //     Original was GL_NONE = 0
        None = 0,
        //
        // Resumo:
        //     Original was GL_FRONT_LEFT = 0x0400
        FrontLeft = 1024,
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
        //     Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        ColorAttachment0 = 36064,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        ColorAttachment1 = 36065,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        ColorAttachment2 = 36066,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        ColorAttachment3 = 36067,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        ColorAttachment4 = 36068,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        ColorAttachment5 = 36069,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        ColorAttachment6 = 36070,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        ColorAttachment7 = 36071,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        ColorAttachment8 = 36072,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        ColorAttachment9 = 36073,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        ColorAttachment10 = 36074,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        ColorAttachment11 = 36075,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        ColorAttachment12 = 36076,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        ColorAttachment13 = 36077,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        ColorAttachment14 = 36078,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        ColorAttachment15 = 36079
    }

    public enum LogicOp
    {
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
        Set = 5391
    }

    public enum StencilFunction
    {
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
        Always = 519
    }

    public enum StencilOp
    {
        //
        // Resumo:
        //     Original was GL_ZERO = 0
        Zero = 0,
        //
        // Resumo:
        //     Original was GL_INVERT = 0x150A
        Invert = 5386,
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
        //     Original was GL_INCR_WRAP = 0x8507
        IncrWrap = 34055,
        //
        // Resumo:
        //     Original was GL_DECR_WRAP = 0x8508
        DecrWrap = 34056
    }

    public enum ConditionalRenderType
    {
        //
        // Resumo:
        //     Original was GL_QUERY_WAIT = 0x8E13
        QueryWait = 36371,
        //
        // Resumo:
        //     Original was GL_QUERY_NO_WAIT = 0x8E14
        QueryNoWait = 36372,
        //
        // Resumo:
        //     Original was GL_QUERY_BY_REGION_WAIT = 0x8E15
        QueryByRegionWait = 36373,
        //
        // Resumo:
        //     Original was GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
        QueryByRegionNoWait = 36374,
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
        QueryByRegionNoWaitInverted = 36378
    }

    public enum ClampColorTarget
    {
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
        ClampReadColor = 35100
    }

    public enum ClampColorMode
    {
        //
        // Resumo:
        //     Original was GL_FALSE = 0
        False = 0,
        //
        // Resumo:
        //     Original was GL_TRUE = 1
        True = 1,
        //
        // Resumo:
        //     Original was GL_FIXED_ONLY = 0x891D
        FixedOnly = 35101
    }

    public enum StringName
    {
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
        //     Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        ShadingLanguageVersion = 35724
    }

    public enum StringNameIndexed
    {
        //
        // Resumo:
        //     Original was GL_EXTENSIONS = 0x1F03
        Extensions = 7939,
        //
        // Resumo:
        //     Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        ShadingLanguageVersion = 35724
    }

    public enum DrawBuffersEnum
    {
        //
        // Resumo:
        //     Original was GL_NONE = 0
        None = 0,
        //
        // Resumo:
        //     Original was GL_FRONT_LEFT = 0x0400
        FrontLeft = 1024,
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
        //     Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        ColorAttachment0 = 36064,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        ColorAttachment1 = 36065,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        ColorAttachment2 = 36066,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        ColorAttachment3 = 36067,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        ColorAttachment4 = 36068,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        ColorAttachment5 = 36069,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        ColorAttachment6 = 36070,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        ColorAttachment7 = 36071,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        ColorAttachment8 = 36072,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        ColorAttachment9 = 36073,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        ColorAttachment10 = 36074,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        ColorAttachment11 = 36075,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        ColorAttachment12 = 36076,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        ColorAttachment13 = 36077,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        ColorAttachment14 = 36078,
        //
        // Resumo:
        //     Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        ColorAttachment15 = 36079
    }

    public enum ProvokingVertexMode
    {
        //
        // Resumo:
        //     Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        FirstVertexConvention = 36429,
        //
        // Resumo:
        //     Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        LastVertexConvention = 36430
    }

    public enum QueryTarget
    {
        //
        // Resumo:
        //     Original was GL_TIME_ELAPSED = 0x88BF
        TimeElapsed = 35007,
        //
        // Resumo:
        //     Original was GL_SAMPLES_PASSED = 0x8914
        SamplesPassed = 35092,
        //
        // Resumo:
        //     Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        AnySamplesPassed = 35887,
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
        //     Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        AnySamplesPassedConservative = 36202,
        //
        // Resumo:
        //     Original was GL_TIMESTAMP = 0x8E28
        Timestamp = 36392
    }

    public enum StencilFace
    {
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
        //     Original was GL_FRONT_AND_BACK = 0x0408
        FrontAndBack = 1032
    }

    public enum WaitSyncFlags
    {
        //
        // Resumo:
        //     Original was GL_NONE = 0
        None = 0
    }

    public enum SyncCondition
    {
        //
        // Resumo:
        //     Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        SyncGpuCommandsComplete = 37143
    }

    public enum ClientWaitSyncFlags
    {
        //
        // Resumo:
        //     Original was GL_NONE = 0
        None = 0,
        //
        // Resumo:
        //     Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        SyncFlushCommandsBit = 1
    }

    public enum GetIndexedPName
    {
        //
        // Resumo:
        //     Original was GL_DEPTH_RANGE = 0x0B70
        DepthRange = 2928,
        //
        // Resumo:
        //     Original was GL_VIEWPORT = 0x0BA2
        Viewport = 2978,
        //
        // Resumo:
        //     Original was GL_SCISSOR_BOX = 0x0C10
        ScissorBox = 3088,
        //
        // Resumo:
        //     Original was GL_COLOR_WRITEMASK = 0x0C23
        ColorWritemask = 3107,
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
        //     Original was GL_TEXTURE_BINDING_3D = 0x806A
        TextureBinding3D = 32874,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_RECTANGLE = 0x84F6
        TextureBindingRectangle = 34038,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        TextureBindingCubeMap = 34068,
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
        //     Original was GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C
        TextureBinding1DArray = 35868,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
        TextureBinding2DArray = 35869,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_BUFFER = 0x8C2C
        TextureBindingBuffer = 35884,
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
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        TransformFeedbackBufferBinding = 35983,
        //
        // Resumo:
        //     Original was GL_SAMPLE_MASK_VALUE = 0x8E52
        SampleMaskValue = 36434,
        //
        // Resumo:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A
        TextureBindingCubeMapArray = 36874
    }

    public enum GetTextureParameter
    {
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
        //     Original was GL_TEXTURE_TARGET = 0x1006
        TextureTarget = 4102,
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
        //     Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        SharpenTextureFuncPointsSgis = 32944,
        //
        // Resumo:
        //     Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        ShadowAmbientSgix = 32959,
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
        //     Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        Texture4DsizeSgis = 33078,
        //
        // Resumo:
        //     Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        TextureWrapQSgis = 33079,
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
        //     Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        TextureFilter4SizeSgis = 33095,
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
        //     Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        PostTextureFilterBiasSgix = 33145,
        //
        // Resumo:
        //     Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        PostTextureFilterScaleSgix = 33146,
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
        //     Original was GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0
        TextureCompressedImageSize = 34464,
        //
        // Resumo:
        //     Original was GL_TEXTURE_COMPRESSED = 0x86A1
        TextureCompressed = 34465,
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
        //     Original was GL_TEXTURE_STENCIL_SIZE = 0x88F1
        TextureStencilSize = 35057,
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
        //     Original was GL_TEXTURE_SHARED_SIZE = 0x8C3F
        TextureSharedSize = 35903,
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
        //     Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        ImageFormatCompatibilityType = 37063,
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
        //     Original was GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F
        TextureImmutableFormat = 37167
    }

    public enum FramebufferTarget
    {
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
        //     Original was GL_FRAMEBUFFER = 0x8D40
        Framebuffer = 36160,
        //
        // Resumo:
        //     Original was GL_FRAMEBUFFER_EXT = 0x8D40
        FramebufferExt = 36160
    }

    public enum RenderbufferTarget
    {
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER = 0x8D41
        Renderbuffer = 36161,
        //
        // Resumo:
        //     Original was GL_RENDERBUFFER_EXT = 0x8D41
        RenderbufferExt = 36161
    }

    public enum FramebufferAttachment
    {
        //
        // Resumo:
        //     Original was GL_FRONT_LEFT = 0x0400
        FrontLeft = 1024,
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
        //     Original was GL_COLOR = 0x1800
        Color = 6144,
        //
        // Resumo:
        //     Original was GL_DEPTH = 0x1801
        Depth = 6145,
        //
        // Resumo:
        //     Original was GL_STENCIL = 0x1802
        Stencil = 6146,
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
        DepthStencilAttachment = 33306,
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
        StencilAttachmentExt = 36128
    }

    public enum InternalFormat
    {
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
        //     Original was GL_RGB = 0x1907
        Rgb = 6407,
        //
        // Resumo:
        //     Original was GL_RGBA = 0x1908
        Rgba = 6408,
        //
        // Resumo:
        //     Original was GL_R3_G3_B2 = 0x2A10
        R3G3B2 = 10768,
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
        //     Original was GL_COMPRESSED_RGB = 0x84ED
        CompressedRgb = 34029,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGBA = 0x84EE
        CompressedRgba = 34030,
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
        //     Original was GL_DEPTH_STENCIL_MESA = 0x8750
        DepthStencilMesa = 34640,
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
        //     Original was GL_COMPRESSED_SRGB = 0x8C48
        CompressedSrgb = 35912,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        CompressedSrgbAlpha = 35913,
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
        //     Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        DepthComponent32f = 36012,
        //
        // Resumo:
        //     Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        Depth32fStencil8 = 36013,
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
        //     Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        DepthComponent32fNv = 36267,
        //
        // Resumo:
        //     Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        Depth32fStencil8Nv = 36268,
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
        //     Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        CompressedRgbaBptcUnorm = 36492,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        CompressedSrgbAlphaBptcUnorm = 36493,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        CompressedRgbBptcSignedFloat = 36494,
        //
        // Resumo:
        //     Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        CompressedRgbBptcUnsignedFloat = 36495,
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
        //     Original was GL_RGB10_A2UI = 0x906F
        Rgb10A2ui = 36975,
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
        CompressedSrgb8Alpha8Etc2Eac = 37497
    }

    public enum BufferAccess
    {
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
        ReadWrite = 35002
    }

    public enum BlendingFactorSrc
    {
        //
        // Resumo:
        //     Original was GL_ZERO = 0
        Zero = 0,
        //
        // Resumo:
        //     Original was GL_ONE = 1
        One = 1,
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
        //     Original was GL_SRC1_ALPHA = 0x8589
        Src1Alpha = 34185,
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
        OneMinusSrc1Alpha = 35067
    }

    public enum BlendingFactorDest
    {
        //
        // Resumo:
        //     Original was GL_ZERO = 0
        Zero = 0,
        //
        // Resumo:
        //     Original was GL_ONE = 1
        One = 1,
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
        //     Original was GL_SRC1_ALPHA = 0x8589
        Src1Alpha = 34185,
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
        OneMinusSrc1Alpha = 35067
    }

    public enum ClearBufferCombined
    {
        //
        // Resumo:
        //     Original was GL_DEPTH_STENCIL = 0x84F9
        DepthStencil = 34041
    }

    public enum BufferRangeTarget
    {
        //
        // Resumo:
        //     Original was GL_UNIFORM_BUFFER = 0x8A11
        UniformBuffer = 35345,
        //
        // Resumo:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        TransformFeedbackBuffer = 35982,
        //
        // Resumo:
        //     Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        ShaderStorageBuffer = 37074,
        //
        // Resumo:
        //     Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        AtomicCounterBuffer = 37568
    }

    public enum QueryCounterTarget
    {
        //
        // Resumo:
        //     Original was GL_TIMESTAMP = 0x8E28
        Timestamp = 36392
    }

    public enum TransformFeedbackPrimitiveType
    {
        //
        // Resumo:
        //     Original was GL_POINTS = 0x0000
        Points = 0,
        //
        // Resumo:
        //     Original was GL_LINES = 0x0001
        Lines = 1,
        //
        // Resumo:
        //     Original was GL_TRIANGLES = 0x0004
        Triangles = 4
    }

    public enum IndexedEnableCap
    {
        //
        // Resumo:
        //     Original was GL_BLEND = 0x0BE2
        Blend = 3042,
        //
        // Resumo:
        //     Original was GL_SCISSOR_TEST = 0x0C11
        ScissorTest = 3089
    }

    public enum BufferAccessMask
    {
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
        //     Original was GL_MAP_WRITE_BIT = 0x0002
        MapWriteBit = 2,
        //
        // Resumo:
        //     Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        MapWriteBitExt = 2,
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
        //     Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        MapInvalidateBufferBit = 8,
        //
        // Resumo:
        //     Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008
        MapInvalidateBufferBitExt = 8,
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
        //     Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        MapUnsynchronizedBit = 32,
        //
        // Resumo:
        //     Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020
        MapUnsynchronizedBitExt = 32,
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
        //     Original was GL_MAP_COHERENT_BIT = 0x0080
        MapCoherentBit = 128,
        //
        // Resumo:
        //     Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        MapCoherentBitExt = 128
    }

    public enum BlitFramebufferFilter
    {
        //
        // Resumo:
        //     Original was GL_NEAREST = 0x2600
        Nearest = 9728,
        //
        // Resumo:
        //     Original was GL_LINEAR = 0x2601
        Linear = 9729
    }

    public enum RenderbufferStorage
    {
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT = 0x1902
        DepthComponent = 6402,
        //
        // Resumo:
        //     Original was GL_R3_G3_B2 = 0x2A10
        R3G3B2 = 10768,
        //
        // Resumo:
        //     Original was GL_RGB4 = 0x804F
        Rgb4 = 32847,
        //
        // Resumo:
        //     Original was GL_RGB5 = 0x8050
        Rgb5 = 32848,
        //
        // Resumo:
        //     Original was GL_RGB8 = 0x8051
        Rgb8 = 32849,
        //
        // Resumo:
        //     Original was GL_RGB10 = 0x8052
        Rgb10 = 32850,
        //
        // Resumo:
        //     Original was GL_RGB12 = 0x8053
        Rgb12 = 32851,
        //
        // Resumo:
        //     Original was GL_RGB16 = 0x8054
        Rgb16 = 32852,
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
        //     Original was GL_RGBA8 = 0x8058
        Rgba8 = 32856,
        //
        // Resumo:
        //     Original was GL_RGB10_A2 = 0x8059
        Rgb10A2 = 32857,
        //
        // Resumo:
        //     Original was GL_RGBA12 = 0x805A
        Rgba12 = 32858,
        //
        // Resumo:
        //     Original was GL_RGBA16 = 0x805B
        Rgba16 = 32859,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT16 = 0x81a5
        DepthComponent16 = 33189,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT24 = 0x81a6
        DepthComponent24 = 33190,
        //
        // Resumo:
        //     Original was GL_DEPTH_COMPONENT32 = 0x81a7
        DepthComponent32 = 33191,
        //
        // Resumo:
        //     Original was GL_R8 = 0x8229
        R8 = 33321,
        //
        // Resumo:
        //     Original was GL_R16 = 0x822A
        R16 = 33322,
        //
        // Resumo:
        //     Original was GL_RG8 = 0x822B
        Rg8 = 33323,
        //
        // Resumo:
        //     Original was GL_RG16 = 0x822C
        Rg16 = 33324,
        //
        // Resumo:
        //     Original was GL_R16F = 0x822D
        R16f = 33325,
        //
        // Resumo:
        //     Original was GL_R32F = 0x822E
        R32f = 33326,
        //
        // Resumo:
        //     Original was GL_RG16F = 0x822F
        Rg16f = 33327,
        //
        // Resumo:
        //     Original was GL_RG32F = 0x8230
        Rg32f = 33328,
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
        //     Original was GL_DEPTH_STENCIL = 0x84F9
        DepthStencil = 34041,
        //
        // Resumo:
        //     Original was GL_RGBA32F = 0x8814
        Rgba32f = 34836,
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
        //     Original was GL_RGB16F = 0x881B
        Rgb16f = 34843,
        //
        // Resumo:
        //     Original was GL_DEPTH24_STENCIL8 = 0x88F0
        Depth24Stencil8 = 35056,
        //
        // Resumo:
        //     Original was GL_R11F_G11F_B10F = 0x8C3A
        R11fG11fB10f = 35898,
        //
        // Resumo:
        //     Original was GL_RGB9_E5 = 0x8C3D
        Rgb9E5 = 35901,
        //
        // Resumo:
        //     Original was GL_SRGB8 = 0x8C41
        Srgb8 = 35905,
        //
        // Resumo:
        //     Original was GL_SRGB8_ALPHA8 = 0x8C43
        Srgb8Alpha8 = 35907,
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
        //     Original was GL_RGB10_A2UI = 0x906F
        Rgb10A2ui = 36975
    }

    public enum PackedPointerType
    {
        //
        // Resumo:
        //     Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        UnsignedInt2101010Rev = 33640,
        //
        // Resumo:
        //     Original was GL_INT_2_10_10_10_REV = 0x8D9F
        Int2101010Rev = 36255
    }
    #endregion
}
