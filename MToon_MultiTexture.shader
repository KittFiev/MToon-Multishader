Shader "VRM/MToon_MultiTexture"
{
    Properties
    {

        [IntRange] _StencilID("Stencil ID", Range(0, 255)) = 1

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

        _EmissionAmount1("Emission Amount 1", Range(0, 1)) = 0.0
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

        //Begin MainTex Flipbook Settings
        _MainTexColumns1("Columns", Float) = 1.0
        _MainTexColumns2("Columns", Float) = 1.0
        _MainTexColumns3("Columns", Float) = 1.0
        _MainTexColumns4("Columns", Float) = 1.0
        _MainTexColumns5("Columns", Float) = 1.0
        _MainTexColumns6("Columns", Float) = 1.0
        _MainTexColumns7("Columns", Float) = 1.0
        _MainTexColumns8("Columns", Float) = 1.0
        _MainTexColumns9("Columns", Float) = 1.0
        _MainTexColumns10("Columns", Float) = 1.0

        _MainTexRows1("Rows", Float) = 1.0
        _MainTexRows2("Rows", Float) = 1.0
        _MainTexRows3("Rows", Float) = 1.0
        _MainTexRows4("Rows", Float) = 1.0
        _MainTexRows5("Rows", Float) = 1.0
        _MainTexRows6("Rows", Float) = 1.0
        _MainTexRows7("Rows", Float) = 1.0
        _MainTexRows8("Rows", Float) = 1.0
        _MainTexRows9("Rows", Float) = 1.0
        _MainTexRows10("Rows", Float) = 1.0

        _MainTexSpeed1("Speed", Float) = 0.0
        _MainTexSpeed2("Speed", Float) = 0.0
        _MainTexSpeed3("Speed", Float) = 0.0
        _MainTexSpeed4("Speed", Float) = 0.0
        _MainTexSpeed5("Speed", Float) = 0.0
        _MainTexSpeed6("Speed", Float) = 0.0
        _MainTexSpeed7("Speed", Float) = 0.0
        _MainTexSpeed8("Speed", Float) = 0.0
        _MainTexSpeed9("Speed", Float) = 0.0
        _MainTexSpeed10("Speed", Float) = 0.0

        _MainTexFrameIND1("Start Frame", Float) = 0.0
        _MainTexFrameIND2("Start Frame", Float) = 0.0
        _MainTexFrameIND3("Start Frame", Float) = 0.0
        _MainTexFrameIND4("Start Frame", Float) = 0.0
        _MainTexFrameIND5("Start Frame", Float) = 0.0
        _MainTexFrameIND6("Start Frame", Float) = 0.0
        _MainTexFrameIND7("Start Frame", Float) = 0.0
        _MainTexFrameIND8("Start Frame", Float) = 0.0
        _MainTexFrameIND9("Start Frame", Float) = 0.0
        _MainTexFrameIND10("Start Frame", Float) = 0.0

        _MainTexEndFrameIND1("End Frame", Float) = 0.0
        _MainTexEndFrameIND2("End Frame", Float) = 0.0
        _MainTexEndFrameIND3("End Frame", Float) = 0.0
        _MainTexEndFrameIND4("End Frame", Float) = 0.0
        _MainTexEndFrameIND5("End Frame", Float) = 0.0
        _MainTexEndFrameIND6("End Frame", Float) = 0.0
        _MainTexEndFrameIND7("End Frame", Float) = 0.0
        _MainTexEndFrameIND8("End Frame", Float) = 0.0
        _MainTexEndFrameIND9("End Frame", Float) = 0.0
        _MainTexEndFrameIND10("End Frame", Float) = 0.0

        [HideInInspector] _MainTexWrapMode1("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode2("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode3("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode4("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode5("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode6("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode7("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode8("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode9("Main Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _MainTexWrapMode10("Main Texture Wrap Mode", Float) = 0.0
        //End MainTex Flipbook Settings

        //Begin DecalTex Flipbook Settings
        _DecalTexColumns1("Columns", Float) = 1.0
        _DecalTexColumns2("Columns", Float) = 1.0
        _DecalTexColumns3("Columns", Float) = 1.0
        _DecalTexColumns4("Columns", Float) = 1.0
        _DecalTexColumns5("Columns", Float) = 1.0
        _DecalTexColumns6("Columns", Float) = 1.0
        _DecalTexColumns7("Columns", Float) = 1.0
        _DecalTexColumns8("Columns", Float) = 1.0
        _DecalTexColumns9("Columns", Float) = 1.0
        _DecalTexColumns10("Columns", Float) = 1.0

        _DecalTexRows1("Rows", Float) = 1.0
        _DecalTexRows2("Rows", Float) = 1.0
        _DecalTexRows3("Rows", Float) = 1.0
        _DecalTexRows4("Rows", Float) = 1.0
        _DecalTexRows5("Rows", Float) = 1.0
        _DecalTexRows6("Rows", Float) = 1.0
        _DecalTexRows7("Rows", Float) = 1.0
        _DecalTexRows8("Rows", Float) = 1.0
        _DecalTexRows9("Rows", Float) = 1.0
        _DecalTexRows10("Rows", Float) = 1.0

        _DecalTexSpeed1("Speed", Float) = 0.0
        _DecalTexSpeed2("Speed", Float) = 0.0
        _DecalTexSpeed3("Speed", Float) = 0.0
        _DecalTexSpeed4("Speed", Float) = 0.0
        _DecalTexSpeed5("Speed", Float) = 0.0
        _DecalTexSpeed6("Speed", Float) = 0.0
        _DecalTexSpeed7("Speed", Float) = 0.0
        _DecalTexSpeed8("Speed", Float) = 0.0
        _DecalTexSpeed9("Speed", Float) = 0.0
        _DecalTexSpeed10("Speed", Float) = 0.0

        _DecalTexFrameIND1("Start Frame", Float) = 0.0
        _DecalTexFrameIND2("Start Frame", Float) = 0.0
        _DecalTexFrameIND3("Start Frame", Float) = 0.0
        _DecalTexFrameIND4("Start Frame", Float) = 0.0
        _DecalTexFrameIND5("Start Frame", Float) = 0.0
        _DecalTexFrameIND6("Start Frame", Float) = 0.0
        _DecalTexFrameIND7("Start Frame", Float) = 0.0
        _DecalTexFrameIND8("Start Frame", Float) = 0.0
        _DecalTexFrameIND9("Start Frame", Float) = 0.0
        _DecalTexFrameIND10("Start Frame", Float) = 0.0

        _DecalTexEndFrameIND1("End Frame", Float) = 0.0
        _DecalTexEndFrameIND2("End Frame", Float) = 0.0
        _DecalTexEndFrameIND3("End Frame", Float) = 0.0
        _DecalTexEndFrameIND4("End Frame", Float) = 0.0
        _DecalTexEndFrameIND5("End Frame", Float) = 0.0
        _DecalTexEndFrameIND6("End Frame", Float) = 0.0
        _DecalTexEndFrameIND7("End Frame", Float) = 0.0
        _DecalTexEndFrameIND8("End Frame", Float) = 0.0
        _DecalTexEndFrameIND9("End Frame", Float) = 0.0
        _DecalTexEndFrameIND10("End Frame", Float) = 0.0

        [HideInInspector] _DecalTexWrapMode1("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode2("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode3("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode4("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode5("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode6("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode7("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode8("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode9("Decal Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _DecalTexWrapMode10("Decal Texture Wrap Mode", Float) = 0.0
        //End DecalTex Flipbook Settings

        //Begin EmissionTex Flipbook Settings
        _EmissionTexColumns1("Columns", Float) = 1.0
        _EmissionTexColumns2("Columns", Float) = 1.0
        _EmissionTexColumns3("Columns", Float) = 1.0
        _EmissionTexColumns4("Columns", Float) = 1.0
        _EmissionTexColumns5("Columns", Float) = 1.0
        _EmissionTexColumns6("Columns", Float) = 1.0
        _EmissionTexColumns7("Columns", Float) = 1.0
        _EmissionTexColumns8("Columns", Float) = 1.0
        _EmissionTexColumns9("Columns", Float) = 1.0
        _EmissionTexColumns10("Columns", Float) = 1.0

        _EmissionTexRows1("Rows", Float) = 1.0
        _EmissionTexRows2("Rows", Float) = 1.0
        _EmissionTexRows3("Rows", Float) = 1.0
        _EmissionTexRows4("Rows", Float) = 1.0
        _EmissionTexRows5("Rows", Float) = 1.0
        _EmissionTexRows6("Rows", Float) = 1.0
        _EmissionTexRows7("Rows", Float) = 1.0
        _EmissionTexRows8("Rows", Float) = 1.0
        _EmissionTexRows9("Rows", Float) = 1.0
        _EmissionTexRows10("Rows", Float) = 1.0

        _EmissionTexSpeed1("Speed", Float) = 0.0
        _EmissionTexSpeed2("Speed", Float) = 0.0
        _EmissionTexSpeed3("Speed", Float) = 0.0
        _EmissionTexSpeed4("Speed", Float) = 0.0
        _EmissionTexSpeed5("Speed", Float) = 0.0
        _EmissionTexSpeed6("Speed", Float) = 0.0
        _EmissionTexSpeed7("Speed", Float) = 0.0
        _EmissionTexSpeed8("Speed", Float) = 0.0
        _EmissionTexSpeed9("Speed", Float) = 0.0
        _EmissionTexSpeed10("Speed", Float) = 0.0

        _EmissionTexFrameIND1("Start Frame", Float) = 0.0
        _EmissionTexFrameIND2("Start Frame", Float) = 0.0
        _EmissionTexFrameIND3("Start Frame", Float) = 0.0
        _EmissionTexFrameIND4("Start Frame", Float) = 0.0
        _EmissionTexFrameIND5("Start Frame", Float) = 0.0
        _EmissionTexFrameIND6("Start Frame", Float) = 0.0
        _EmissionTexFrameIND7("Start Frame", Float) = 0.0
        _EmissionTexFrameIND8("Start Frame", Float) = 0.0
        _EmissionTexFrameIND9("Start Frame", Float) = 0.0
        _EmissionTexFrameIND10("Start Frame", Float) = 0.0

        _EmissionTexFrameIND1("End Frame", Float) = 0.0
        _EmissionTexFrameIND2("End Frame", Float) = 0.0
        _EmissionTexFrameIND3("End Frame", Float) = 0.0
        _EmissionTexFrameIND4("End Frame", Float) = 0.0
        _EmissionTexFrameIND5("End Frame", Float) = 0.0
        _EmissionTexFrameIND6("End Frame", Float) = 0.0
        _EmissionTexFrameIND7("End Frame", Float) = 0.0
        _EmissionTexFrameIND8("End Frame", Float) = 0.0
        _EmissionTexFrameIND9("End Frame", Float) = 0.0
        _EmissionTexFrameIND10("End Frame", Float) = 0.0

        [HideInInspector] _EmissionTexWrapMode1("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode2("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode3("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode4("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode5("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode6("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode7("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode8("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode9("Emission Texture Wrap Mode", Float) = 0.0
        [HideInInspector] _EmissionTexWrapMode10("Emission Texture Wrap Mode", Float) = 0.0
        //End EmissionTex Flipbook Settings

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


        [NoScaleOffset] _ShadeTexture("Shade Texture", 2D) = "white" {}
        _BumpScale("Normal Scale", Float) = 1.0
        [Normal] _BumpMap("Normal Texture", 2D) = "bump" {}
        _ReceiveShadowRate("Receive Shadow", Range(0, 1)) = 1
        [NoScaleOffset] _ReceiveShadowTexture("Receive Shadow Texture", 2D) = "white" {}
        _ShadingGradeRate("Shading Grade", Range(0, 1)) = 1
        [NoScaleOffset] _ShadingGradeTexture("Shading Grade Texture", 2D) = "white" {}
        _ShadeShift("Shade Shift", Range(-1, 1)) = 0
        _ShadeToony("Shade Toony", Range(0, 1)) = 0.9
        _LightColorAttenuation("Light Color Attenuation", Range(0, 1)) = 0
        _IndirectLightIntensity("Indirect Light Intensity", Range(0, 1)) = 0.1
        [HDR] _RimColor("Rim Color", Color) = (0,0,0)
        [NoScaleOffset] _RimTexture("Rim Texture", 2D) = "white" {}
        _RimLightingMix("Rim Lighting Mix", Range(0, 1)) = 0
        [PowerSlider(4.0)] _RimFresnelPower("Rim Fresnel Power", Range(0, 100)) = 1
        _RimLift("Rim Lift", Range(0, 1)) = 0
        [NoScaleOffset] _SphereAdd("Sphere Texture(Add)", 2D) = "black" {}
        [HDR] _EmissionColor("Color", Color) = (0,0,0)
        [NoScaleOffset] _EmissionMap("Emission", 2D) = "white" {}
        [NoScaleOffset] _OutlineWidthTexture("Outline Width Tex", 2D) = "white" {}
        _OutlineWidth("Outline Width", Range(0.01, 1)) = 0.5
        _OutlineScaledMaxDistance("Outline Scaled Max Distance", Range(1, 10)) = 1
        _OutlineColor("Outline Color", Color) = (0,0,0,1)
        _OutlineLightingMix("Outline Lighting Mix", Range(0, 1)) = 1
        [NoScaleOffset] _UvAnimMaskTexture("UV Animation Mask", 2D) = "white" {}
        _UvAnimScrollX("UV Animation Scroll X", Float) = 0
        _UvAnimScrollY("UV Animation Scroll Y", Float) = 0
        _UvAnimRotation("UV Animation Rotation", Float) = 0

        [HideInInspector] _MToonVersion("_MToonVersion", Float) = 35
        [HideInInspector] _DebugMode("_DebugMode", Float) = 0.0
        [HideInInspector] _BlendMode("_BlendMode", Float) = 0.0
        [HideInInspector] _OutlineWidthMode("_OutlineWidthMode", Float) = 0.0
        [HideInInspector] _OutlineColorMode("_OutlineColorMode", Float) = 0.0
        [HideInInspector] _CullMode("_CullMode", Float) = 2.0
        [HideInInspector] _OutlineCullMode("_OutlineCullMode", Float) = 1.0
        [HideInInspector] _SrcBlend("_SrcBlend", Float) = 1.0
        [HideInInspector] _DstBlend("_DstBlend", Float) = 0.0
        [HideInInspector] _ZWrite("_ZWrite", Float) = 1.0
        [HideInInspector] _AlphaToMask("_AlphaToMask", Float) = 0.0
    }


        // for SM 3.0
            SubShader
        {
            Tags { "RenderType" = "Opaque"  "Queue" = "Geometry+2" }

            Cull Back
            ZTest Always
            Stencil {
                Ref[_StencilID]
                Comp notequal
            }

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

                Cull[_OutlineCullMode]
                Blend[_SrcBlend][_DstBlend]
                ZWrite[_ZWrite]
                ZTest LEqual
                Offset 1, 1
                BlendOp Add, Max
                AlphaToMask[_AlphaToMask]

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

                Cull[_CullMode]
                Blend[_SrcBlend] One
                ZWrite Off
                ZTest LEqual
                BlendOp Add, Max
                AlphaToMask[_AlphaToMask]

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

                Cull[_CullMode]
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
