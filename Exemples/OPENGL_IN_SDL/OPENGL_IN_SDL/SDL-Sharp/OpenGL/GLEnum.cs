using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDL_Sharp.OpenGL
{
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
}
