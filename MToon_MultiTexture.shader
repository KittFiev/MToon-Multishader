Shader "VRM/MToon_MultiTexture"
{
    Properties
    {

        _Cutoff("Alpha Cutoff", Range(0, 1)) = 0.5
        _AmountTex2("Amount Texture 2", Range(0, 1)) = 0.0
        _AmountTex3("Amount Texture 3", Range(0, 1)) = 0.0
        _AmountTex4("Amount Texture 4", Range(0, 1)) = 0.0
        _AmountTex5("Amount Texture 5", Range(0, 1)) = 0.0
        _AmountTex6("Amount Texture 6", Range(0, 1)) = 0.0
        _AmountTex7("Amount Texture 7", Range(0, 1)) = 0.0
        _AmountTex8("Amount Texture 8", Range(0, 1)) = 0.0
        _AmountTex9("Amount Texture 9", Range(0, 1)) = 0.0
        _AmountTex10("Amount Texture 10", Range(0, 1)) = 0.0

        _AmountDecal1("Amount Decal 1", Range(0, 1)) = 0.0
        _AmountDecal2("Amount Decal 2", Range(0, 1)) = 0.0
        _AmountDecal3("Amount Decal 3", Range(0, 1)) = 0.0
        _AmountDecal4("Amount Decal 4", Range(0, 1)) = 0.0
        _AmountDecal5("Amount Decal 5", Range(0, 1)) = 0.0
        _AmountDecal6("Amount Decal 6", Range(0, 1)) = 0.0
        _AmountDecal7("Amount Decal 7", Range(0, 1)) = 0.0
        _AmountDecal8("Amount Decal 8", Range(0, 1)) = 0.0
        _AmountDecal9("Amount Decal 9", Range(0, 1)) = 0.0
        _AmountDecal10("Amount Decal 10", Range(0, 1)) = 0.0
        
        _EmissionAmount2("Emission Amount 2", Range(0, 1)) = 0.0
        _EmissionAmount3("Emission Amount 3", Range(0, 1)) = 0.0
        _EmissionAmount4("Emission Amount 4", Range(0, 1)) = 0.0
        _EmissionAmount5("Emission Amount 5", Range(0, 1)) = 0.0
        _EmissionAmount6("Emission Amount 6", Range(0, 1)) = 0.0
        _EmissionAmount7("Emission Amount 7", Range(0, 1)) = 0.0
        _EmissionAmount8("Emission Amount 8", Range(0, 1)) = 0.0
        _EmissionAmount9("Emission Amount 9", Range(0, 1)) = 0.0
        _EmissionAmount10("Emission Amount 10", Range(0, 1)) = 0.0

        _Color("Lit Color + Alpha", Color) = (1,1,1,1)
        _ShadeColor("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        [NoScaleOffset] _MainTex("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex2("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex3("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex4("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex5("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex6("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex7("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex8("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex9("Lit Texture + Alpha", 2D) = "white" {}
        [NoScaleOffset] _MainTex10("Lit Texture + Alpha", 2D) = "white" {}

        _MainColor2("Lit Color + Alpha", Color) = (1, 1, 1, 1)
        _MainColor3("Lit Color + Alpha", Color) = (1,1,1,1)
        _MainColor4("Lit Color + Alpha", Color) = (1,1,1,1)
        _MainColor5("Lit Color + Alpha", Color) = (1,1,1,1)
        _MainColor6("Lit Color + Alpha", Color) = (1,1,1,1)
        _MainColor7("Lit Color + Alpha", Color) = (1,1,1,1)
        _MainColor8("Lit Color + Alpha", Color) = (1,1,1,1)
        _MainColor9("Lit Color + Alpha", Color) = (1,1,1,1)
        _MainColor10("Lit Color + Alpha", Color) = (1,1,1,1)

        [NoScaleOffset] _ShadeTex2("Shade Texture", 2D) = "white" {}
        [NoScaleOffset] _ShadeTex3("Shade Texture", 2D) = "white" {}
        [NoScaleOffset] _ShadeTex4("Shade Texture", 2D) = "white" {}
        [NoScaleOffset] _ShadeTex5("Shade Texture", 2D) = "white" {}
        [NoScaleOffset] _ShadeTex6("Shade Texture", 2D) = "white" {}
        [NoScaleOffset] _ShadeTex7("Shade Texture", 2D) = "white" {}
        [NoScaleOffset] _ShadeTex8("Shade Texture", 2D) = "white" {}
        [NoScaleOffset] _ShadeTex9("Shade Texture", 2D) = "white" {}
        [NoScaleOffset] _ShadeTex10("Shade Texture", 2D) = "white" {}

        _ShadeColor2("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        _ShadeColor3("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        _ShadeColor4("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        _ShadeColor5("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        _ShadeColor6("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        _ShadeColor7("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        _ShadeColor8("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        _ShadeColor9("Shade Color", Color) = (0.97, 0.81, 0.86, 1)
        _ShadeColor10("Shade Color", Color) = (0.97, 0.81, 0.86, 1)

        [NoScaleOffset] _DecalTex1("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex2("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex3("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex4("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex5("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex6("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex7("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex8("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex9("Decal Texture", 2D) = "black" {}
        [NoScaleOffset] _DecalTex10("Decal Texture", 2D) = "black" {}

        [NoScaleOffset] _EmissionMap1("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap2("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap3("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap4("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap5("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap6("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap7("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap8("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap9("Emission Map", 2D) = "white" {}
        [NoScaleOffset] _EmissionMap10("Emission Map", 2D) = "white" {}

        [HDR]_EmissionColor1("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor2("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor3("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor4("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor5("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor6("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor7("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor8("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor9("Emissive Color", Color) = (0, 0, 0, 0)
        [HDR]_EmissionColor10("Emissive Color", Color) = (0, 0, 0, 0)


        [NoScaleOffset] _ShadeTexture ("Shade Texture", 2D) = "white" {}
        _BumpScale ("Normal Scale", Float) = 1.0
        [Normal] _BumpMap ("Normal Texture", 2D) = "bump" {}
        _ReceiveShadowRate ("Receive Shadow", Range(0, 1)) = 1
        [NoScaleOffset] _ReceiveShadowTexture ("Receive Shadow Texture", 2D) = "white" {}
        _ShadingGradeRate ("Shading Grade", Range(0, 1)) = 1
        [NoScaleOffset] _ShadingGradeTexture ("Shading Grade Texture", 2D) = "white" {}
        _ShadeShift ("Shade Shift", Range(-1, 1)) = 0
        _ShadeToony ("Shade Toony", Range(0, 1)) = 0.9
        _LightColorAttenuation ("Light Color Attenuation", Range(0, 1)) = 0
        _IndirectLightIntensity ("Indirect Light Intensity", Range(0, 1)) = 0.1
        [HDR] _RimColor ("Rim Color", Color) = (0,0,0)
        [NoScaleOffset] _RimTexture ("Rim Texture", 2D) = "white" {}
        _RimLightingMix ("Rim Lighting Mix", Range(0, 1)) = 0
        [PowerSlider(4.0)] _RimFresnelPower ("Rim Fresnel Power", Range(0, 100)) = 1
        _RimLift ("Rim Lift", Range(0, 1)) = 0
        [NoScaleOffset] _SphereAdd ("Sphere Texture(Add)", 2D) = "black" {}
        [HDR] _EmissionColor ("Color", Color) = (0,0,0)
        [NoScaleOffset] _EmissionMap ("Emission", 2D) = "white" {}
        [NoScaleOffset] _OutlineWidthTexture ("Outline Width Tex", 2D) = "white" {}
        _OutlineWidth ("Outline Width", Range(0.01, 1)) = 0.5
        _OutlineScaledMaxDistance ("Outline Scaled Max Distance", Range(1, 10)) = 1
        _OutlineColor ("Outline Color", Color) = (0,0,0,1)
        _OutlineLightingMix ("Outline Lighting Mix", Range(0, 1)) = 1
        [NoScaleOffset] _UvAnimMaskTexture ("UV Animation Mask", 2D) = "white" {}
        _UvAnimScrollX ("UV Animation Scroll X", Float) = 0
        _UvAnimScrollY ("UV Animation Scroll Y", Float) = 0
        _UvAnimRotation ("UV Animation Rotation", Float) = 0

        [HideInInspector] _MToonVersion ("_MToonVersion", Float) = 35
        [HideInInspector] _DebugMode ("_DebugMode", Float) = 0.0
        [HideInInspector] _BlendMode ("_BlendMode", Float) = 0.0
        [HideInInspector] _OutlineWidthMode ("_OutlineWidthMode", Float) = 0.0
        [HideInInspector] _OutlineColorMode ("_OutlineColorMode", Float) = 0.0
        [HideInInspector] _CullMode ("_CullMode", Float) = 2.0
        [HideInInspector] _OutlineCullMode ("_OutlineCullMode", Float) = 1.0
        [HideInInspector] _SrcBlend ("_SrcBlend", Float) = 1.0
        [HideInInspector] _DstBlend ("_DstBlend", Float) = 0.0
        [HideInInspector] _ZWrite ("_ZWrite", Float) = 1.0
        [HideInInspector] _AlphaToMask ("_AlphaToMask", Float) = 0.0
    }

    
    // for SM 3.0
    SubShader
    {
        Tags { "RenderType" = "Opaque"  "Queue" = "Geometry" }

        // Forward Base
        Pass
        {
            Name "FORWARD_BASE"
            Tags { "LightMode" = "ForwardBase" }

            Cull[_CullMode]
            Blend[_SrcBlend][_DstBlend]
            ZWrite[_ZWrite]
            ZTest LEqual
            BlendOp Add, Max
            AlphaToMask[_AlphaToMask]

            CGPROGRAM
            #pragma target 3.0
            #pragma shader_feature _ MTOON_DEBUG_NORMAL MTOON_DEBUG_LITSHADERATE
            #pragma multi_compile _ _NORMALMAP
            #pragma multi_compile _ _ALPHATEST_ON _ALPHABLEND_ON
            #include "./MToonSM3_MultiTexture.cginc"
            #pragma vertex vert_forward_base
            #pragma fragment frag_forward
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
//            #pragma multi_compile_instancing

            ENDCG
        }
        
        
        // Forward Base Outline Pass
        Pass 
        {
            Name "FORWARD_BASE_ONLY_OUTLINE"
            Tags { "LightMode" = "ForwardBase" }

            Cull [_OutlineCullMode]
            Blend [_SrcBlend] [_DstBlend]
            ZWrite [_ZWrite]
            ZTest LEqual
            Offset 1, 1
            BlendOp Add, Max
            AlphaToMask [_AlphaToMask]

            CGPROGRAM
            #pragma target 3.0
            #pragma shader_feature _ MTOON_DEBUG_NORMAL MTOON_DEBUG_LITSHADERATE
            #pragma multi_compile _ MTOON_OUTLINE_WIDTH_WORLD MTOON_OUTLINE_WIDTH_SCREEN
            #pragma multi_compile _ MTOON_OUTLINE_COLOR_FIXED MTOON_OUTLINE_COLOR_MIXED
            #pragma multi_compile _ _NORMALMAP
            #pragma multi_compile _ _ALPHATEST_ON _ALPHABLEND_ON
            #define MTOON_CLIP_IF_OUTLINE_IS_NONE
            #include "./MToonSM3_MultiTexture.cginc"
            #pragma vertex vert_forward_base_outline
            #pragma fragment frag_forward
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
//            #pragma multi_compile_instancing
            ENDCG
        }

        
        // Forward Add
        Pass 
        {
            Name "FORWARD_ADD"
            Tags { "LightMode" = "ForwardAdd" }

            Cull [_CullMode]
            Blend [_SrcBlend] One
            ZWrite Off
            ZTest LEqual
            BlendOp Add, Max
            AlphaToMask [_AlphaToMask]

            CGPROGRAM
            #pragma target 3.0
            #pragma shader_feature _ MTOON_DEBUG_NORMAL MTOON_DEBUG_LITSHADERATE
            #pragma multi_compile _ _NORMALMAP
            #pragma multi_compile _ _ALPHATEST_ON _ALPHABLEND_ON
            #define MTOON_FORWARD_ADD
            #include "./MToonSM3_MultiTexture.cginc"
            #pragma vertex vert_forward_add
            #pragma fragment frag_forward
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            ENDCG
        }
        
        //  Shadow rendering pass
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }

            Cull [_CullMode]
            ZWrite On
            ZTest LEqual

            CGPROGRAM
            #pragma target 3.0
            #pragma multi_compile _ _ALPHATEST_ON _ALPHABLEND_ON
            #pragma multi_compile_shadowcaster
            #pragma vertex vertShadowCaster
            #pragma fragment fragShadowCaster
            #include "UnityStandardShadow.cginc"
            ENDCG
        }
    }
    
    Fallback "Unlit/Texture"
    CustomEditor "MToon.MToonInspector_MultiTexture"
}
