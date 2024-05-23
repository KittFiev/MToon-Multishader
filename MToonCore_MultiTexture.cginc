#ifndef MTOON_CORE_INCLUDED
#define MTOON_CORE_INCLUDED

#include "Lighting.cginc"
#include "AutoLight.cginc"

half _Cutoff;

//Begin MainTex Flipbook Settings
half _MainTexColumns1;
half _MainTexColumns2;
half _MainTexColumns3;
half _MainTexColumns4;
half _MainTexColumns5;
half _MainTexColumns6;
half _MainTexColumns7;
half _MainTexColumns8;
half _MainTexColumns9;
half _MainTexColumns10;

half _MainTexRows1;
half _MainTexRows2;
half _MainTexRows3;
half _MainTexRows4;
half _MainTexRows5;
half _MainTexRows6;
half _MainTexRows7;
half _MainTexRows8;
half _MainTexRows9;
half _MainTexRows10;

half _MainTexSpeed1;
half _MainTexSpeed2;
half _MainTexSpeed3;
half _MainTexSpeed4;
half _MainTexSpeed5;
half _MainTexSpeed6;
half _MainTexSpeed7;
half _MainTexSpeed8;
half _MainTexSpeed9;
half _MainTexSpeed10;

half _MainTexFrameIND1;
half _MainTexFrameIND2;
half _MainTexFrameIND3;
half _MainTexFrameIND4;
half _MainTexFrameIND5;
half _MainTexFrameIND6;
half _MainTexFrameIND7;
half _MainTexFrameIND8;
half _MainTexFrameIND9;
half _MainTexFrameIND10;

half _MainTexEndFrameIND1;
half _MainTexEndFrameIND2;
half _MainTexEndFrameIND3;
half _MainTexEndFrameIND4;
half _MainTexEndFrameIND5;
half _MainTexEndFrameIND6;
half _MainTexEndFrameIND7;
half _MainTexEndFrameIND8;
half _MainTexEndFrameIND9;
half _MainTexEndFrameIND10;
//End MainTex Flipbook Settings

//Begin DecalTex Flipbook Settings
half _DecalTexColumns1;
half _DecalTexColumns2;
half _DecalTexColumns3;
half _DecalTexColumns4;
half _DecalTexColumns5;
half _DecalTexColumns6;
half _DecalTexColumns7;
half _DecalTexColumns8;
half _DecalTexColumns9;
half _DecalTexColumns10;

half _DecalTexRows1;
half _DecalTexRows2;
half _DecalTexRows3;
half _DecalTexRows4;
half _DecalTexRows5;
half _DecalTexRows6;
half _DecalTexRows7;
half _DecalTexRows8;
half _DecalTexRows9;
half _DecalTexRows10;

half _DecalTexSpeed1;
half _DecalTexSpeed2;
half _DecalTexSpeed3;
half _DecalTexSpeed4;
half _DecalTexSpeed5;
half _DecalTexSpeed6;
half _DecalTexSpeed7;
half _DecalTexSpeed8;
half _DecalTexSpeed9;
half _DecalTexSpeed10;

half _DecalTexFrameIND1;
half _DecalTexFrameIND2;
half _DecalTexFrameIND3;
half _DecalTexFrameIND4;
half _DecalTexFrameIND5;
half _DecalTexFrameIND6;
half _DecalTexFrameIND7;
half _DecalTexFrameIND8;
half _DecalTexFrameIND9;
half _DecalTexFrameIND10;

half _DecalTexEndFrameIND1;
half _DecalTexEndFrameIND2;
half _DecalTexEndFrameIND3;
half _DecalTexEndFrameIND4;
half _DecalTexEndFrameIND5;
half _DecalTexEndFrameIND6;
half _DecalTexEndFrameIND7;
half _DecalTexEndFrameIND8;
half _DecalTexEndFrameIND9;
half _DecalTexEndFrameIND10;
//End DecalTex Flipbook Settings

//Begin EmissionTex Flipbook Settings
half _EmissionTexColumns1;
half _EmissionTexColumns2;
half _EmissionTexColumns3;
half _EmissionTexColumns4;
half _EmissionTexColumns5;
half _EmissionTexColumns6;
half _EmissionTexColumns7;
half _EmissionTexColumns8;
half _EmissionTexColumns9;
half _EmissionTexColumns10;

half _EmissionTexRows1;
half _EmissionTexRows2;
half _EmissionTexRows3;
half _EmissionTexRows4;
half _EmissionTexRows5;
half _EmissionTexRows6;
half _EmissionTexRows7;
half _EmissionTexRows8;
half _EmissionTexRows9;
half _EmissionTexRows10;

half _EmissionTexSpeed1;
half _EmissionTexSpeed2;
half _EmissionTexSpeed3;
half _EmissionTexSpeed4;
half _EmissionTexSpeed5;
half _EmissionTexSpeed6;
half _EmissionTexSpeed7;
half _EmissionTexSpeed8;
half _EmissionTexSpeed9;
half _EmissionTexSpeed10;

half _EmissionTexFrameIND1;
half _EmissionTexFrameIND2;
half _EmissionTexFrameIND3;
half _EmissionTexFrameIND4;
half _EmissionTexFrameIND5;
half _EmissionTexFrameIND6;
half _EmissionTexFrameIND7;
half _EmissionTexFrameIND8;
half _EmissionTexFrameIND9;
half _EmissionTexFrameIND10;

half _EmissionTexEndFrameIND1;
half _EmissionTexEndFrameIND2;
half _EmissionTexEndFrameIND3;
half _EmissionTexEndFrameIND4;
half _EmissionTexEndFrameIND5;
half _EmissionTexEndFrameIND6;
half _EmissionTexEndFrameIND7;
half _EmissionTexEndFrameIND8;
half _EmissionTexEndFrameIND9;
half _EmissionTexEndFrameIND10;
//End EmissionTex Flipbook Settings


half _AmountTex2;
half _AmountTex3;
half _AmountTex4;
half _AmountTex5;
half _AmountTex6;
half _AmountTex7;
half _AmountTex8;
half _AmountTex9;
half _AmountTex10;

half _AmountDecal1;
half _AmountDecal2;
half _AmountDecal3;
half _AmountDecal4;
half _AmountDecal5;
half _AmountDecal6;
half _AmountDecal7;
half _AmountDecal8;
half _AmountDecal9;
half _AmountDecal10;

half _EmissionAmount1;
half _EmissionAmount2;
half _EmissionAmount3;
half _EmissionAmount4;
half _EmissionAmount5;
half _EmissionAmount6;
half _EmissionAmount7;
half _EmissionAmount8;
half _EmissionAmount9;
half _EmissionAmount10;





/*sampler2D _MainTex;
sampler2D _MainTex2; 
sampler2D _MainTex3; 

UNITY_DECLARE_TEX2D(_MainTex4);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex5);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex6);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex7);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex8);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex9);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex10);*/

Texture2D _MainTex;

SamplerState sampler_MainTex;

UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex2);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex3);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex4);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex5);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex6);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex7);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex8);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex9);
UNITY_DECLARE_TEX2D_NOSAMPLER(_MainTex10);

fixed4 _Color;
fixed4 _MainColor2;
fixed4 _MainColor3;
fixed4 _MainColor4;
fixed4 _MainColor5;
fixed4 _MainColor6;
fixed4 _MainColor7;
fixed4 _MainColor8;
fixed4 _MainColor9;
fixed4 _MainColor10;

Texture2D _ShadeTexture;

SamplerState sampler_ShadeTexture;

UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex2);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex3);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex4);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex5);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex6);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex7);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex8);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex9);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex10);

/*sampler _ShadeTexture;

sampler2D _ShadeTex2;
sampler2D _ShadeTex3;

UNITY_DECLARE_TEX2D(_ShadeTex4);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex5);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex6);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex7);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex8);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex9);
UNITY_DECLARE_TEX2D_NOSAMPLER(_ShadeTex10);*/

fixed4 _ShadeColor;
fixed4 _ShadeColor2;
fixed4 _ShadeColor3;
fixed4 _ShadeColor4;
fixed4 _ShadeColor5;
fixed4 _ShadeColor6;
fixed4 _ShadeColor7;
fixed4 _ShadeColor8;
fixed4 _ShadeColor9;
fixed4 _ShadeColor10;

Texture2D _DecalTex1;

SamplerState sampler_DecalTex1;

UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex2);
UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex3);
UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex4);
UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex5);
UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex6);
UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex7);
UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex8);
UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex9);
UNITY_DECLARE_TEX2D_NOSAMPLER(_DecalTex10);

Texture2D _EmissionMap1;

SamplerState sampler_EmissionMap1;

UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap2);
UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap3);
UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap4);
UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap5);
UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap6);
UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap7);
UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap8);
UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap9);
UNITY_DECLARE_TEX2D_NOSAMPLER(_EmissionMap10);

fixed4 _EmissionColor1;
fixed4 _EmissionColor2;
fixed4 _EmissionColor3;
fixed4 _EmissionColor4;
fixed4 _EmissionColor5;
fixed4 _EmissionColor6;
fixed4 _EmissionColor7;
fixed4 _EmissionColor8;
fixed4 _EmissionColor9;
fixed4 _EmissionColor10;



float4 _MainTex_ST;

half _BumpScale;
sampler2D _BumpMap;
sampler2D _ReceiveShadowTexture; 
half _ReceiveShadowRate;
sampler2D _ShadingGradeTexture;
half _ShadingGradeRate;
half _ShadeShift;
half _ShadeToony;
half _LightColorAttenuation;
half _IndirectLightIntensity;
sampler2D _RimTexture;
half4 _RimColor;
half _RimLightingMix;
half _RimFresnelPower;
half _RimLift;
sampler2D _SphereAdd;
half4 _EmissionColor;
sampler2D _EmissionMap;
sampler2D _OutlineWidthTexture;
half _OutlineWidth;
half _OutlineScaledMaxDistance;
fixed4 _OutlineColor;
half _OutlineLightingMix;
sampler2D _UvAnimMaskTexture;
float _UvAnimScrollX;
float _UvAnimScrollY;
float _UvAnimRotation;

//UNITY_INSTANCING_BUFFER_START(Props)
//UNITY_INSTANCING_BUFFER_END(Props)

struct v2f
{
    float4 pos : SV_POSITION;
    float4 posWorld : TEXCOORD0;
    half3 tspace0 : TEXCOORD1;
    half3 tspace1 : TEXCOORD2;
    half3 tspace2 : TEXCOORD3;
    float2 uv0 : TEXCOORD4;
    float isOutline : TEXCOORD5;
    fixed4 color : TEXCOORD6;
    UNITY_FOG_COORDS(7)
    UNITY_SHADOW_COORDS(8)
    //UNITY_VERTEX_INPUT_INSTANCE_ID // necessary only if any instanced properties are going to be accessed in the fragment Shader.
};

inline v2f InitializeV2F(appdata_full v, float4 projectedVertex, float isOutline)
{
    v2f o;
    UNITY_INITIALIZE_OUTPUT(v2f, o);
    UNITY_SETUP_INSTANCE_ID(v);
    //UNITY_TRANSFER_INSTANCE_ID(v, o);
    
    o.pos = projectedVertex;
    o.posWorld = mul(unity_ObjectToWorld, v.vertex);
    o.uv0 = v.texcoord;
    half3 worldNormal = UnityObjectToWorldNormal(v.normal);
    half3 worldTangent = UnityObjectToWorldDir(v.tangent);
    half tangentSign = v.tangent.w * unity_WorldTransformParams.w;
    half3 worldBitangent = cross(worldNormal, worldTangent) * tangentSign;
    o.tspace0 = half3(worldTangent.x, worldBitangent.x, worldNormal.x);
    o.tspace1 = half3(worldTangent.y, worldBitangent.y, worldNormal.y);
    o.tspace2 = half3(worldTangent.z, worldBitangent.z, worldNormal.z);
    o.isOutline = isOutline;
    o.color = v.color;
    UNITY_TRANSFER_SHADOW(o, o._ShadowCoord);
    UNITY_TRANSFER_FOG(o, o.pos);
    return o;
}

inline float2 FlipbookCalculation(float2 UV, float Columns, float Rows, float Speed, float IND, float End) 
{
    
    float ArraySize = Columns * Rows;
    float2 uvcoords = (float2(frac(clamp(UV.x, 0, 1)), frac(clamp(UV.y, 0, 1))));
    float Temp1 = (fmod( _Time.y, (End >= 0.5 ? End : ArraySize)) * Speed);
    float Temp2 = clamp(IND, 1E-05, (ArraySize - 1.0));
    float Temp3 = frac(((Temp1 + (Temp2 + 1E-05)) / ArraySize));
    float2 Append = (float2(Temp3, (1.0 - Temp3)));
    float2 Final = ((uvcoords / float2(Columns, Rows)) + (floor((float2(ArraySize, Rows) * Append)) / float2(Columns, Rows)));
    

    return Final;

}

inline float4 CalculateOutlineVertexClipPosition(appdata_full v)
{
    float outlineTex = tex2Dlod(_OutlineWidthTexture, float4(TRANSFORM_TEX(v.texcoord, _MainTex), 0, 0)).r;
    
 #if defined(MTOON_OUTLINE_WIDTH_WORLD)
    float3 worldNormalLength = length(mul((float3x3)transpose(unity_WorldToObject), v.normal));
    float3 outlineOffset = 0.01 * _OutlineWidth * outlineTex * worldNormalLength * v.normal;
    float4 vertex = UnityObjectToClipPos(v.vertex + outlineOffset);
 #elif defined(MTOON_OUTLINE_WIDTH_SCREEN)
    float4 nearUpperRight = mul(unity_CameraInvProjection, float4(1, 1, UNITY_NEAR_CLIP_VALUE, _ProjectionParams.y));
    float aspect = abs(nearUpperRight.y / nearUpperRight.x);
    float4 vertex = UnityObjectToClipPos(v.vertex);
    float3 viewNormal = mul((float3x3)UNITY_MATRIX_IT_MV, v.normal.xyz);
    float3 clipNormal = TransformViewToProjection(viewNormal.xyz);
    float2 projectedNormal = normalize(clipNormal.xy);
    projectedNormal *= min(vertex.w, _OutlineScaledMaxDistance);
    projectedNormal.x *= aspect;
    vertex.xy += 0.01 * _OutlineWidth * outlineTex * projectedNormal.xy * saturate(1 - abs(normalize(viewNormal).z)); // ignore offset when normal toward camera
 #else
    float4 vertex = UnityObjectToClipPos(v.vertex);
 #endif
    return vertex;
}

float4 frag_forward(v2f i) : SV_TARGET
{
#ifdef MTOON_CLIP_IF_OUTLINE_IS_NONE
    #ifdef MTOON_OUTLINE_WIDTH_WORLD
    #elif MTOON_OUTLINE_WIDTH_SCREEN
    #else
        clip(-1);
    #endif
#endif

    //UNITY_TRANSFER_INSTANCE_ID(v, o);
    
    // const
    const float PI_2 = 6.28318530718;
    const float EPS_COL = 0.00001;
    
    // uv
    float2 mainUv = TRANSFORM_TEX(i.uv0, _MainTex);
    
    // uv anim
    float uvAnim = tex2D(_UvAnimMaskTexture, mainUv).r * _Time.y;
    // translate uv in bottom-left origin coordinates.
    mainUv += float2(_UvAnimScrollX, _UvAnimScrollY) * uvAnim;
    // rotate uv counter-clockwise around (0.5, 0.5) in bottom-left origin coordinates.
    float rotateRad = _UvAnimRotation * PI_2 * uvAnim;
    const float2 rotatePivot = float2(0.5, 0.5);
    mainUv = mul(float2x2(cos(rotateRad), -sin(rotateRad), sin(rotateRad), cos(rotateRad)), mainUv - rotatePivot) + rotatePivot;
    
    // main tex
    /*half4 mainTex = tex2D(_MainTex, mainUv);

	mainTex = lerp(mainTex, tex2D(_MainTex2, mainUv), _AmountTex2);
	mainTex = lerp(mainTex, tex2D(_MainTex3, mainUv), _AmountTex3);


	mainTex = lerp(mainTex, UNITY_SAMPLE_TEX2D(_MainTex4, mainUv), _AmountTex4);

	mainTex = lerp(mainTex, UNITY_SAMPLE_TEX2D_SAMPLER(_MainTex5, _MainTex4, mainUv), _AmountTex5);
	mainTex = lerp(mainTex, UNITY_SAMPLE_TEX2D_SAMPLER(_MainTex6, _MainTex4, mainUv), _AmountTex6);
	mainTex = lerp(mainTex, UNITY_SAMPLE_TEX2D_SAMPLER(_MainTex7, _MainTex4, mainUv), _AmountTex7);
	mainTex = lerp(mainTex, UNITY_SAMPLE_TEX2D_SAMPLER(_MainTex8, _MainTex4, mainUv), _AmountTex8);
	mainTex = lerp(mainTex, UNITY_SAMPLE_TEX2D_SAMPLER(_MainTex9, _MainTex4, mainUv), _AmountTex9);
	mainTex = lerp(mainTex, UNITY_SAMPLE_TEX2D_SAMPLER(_MainTex10, _MainTex4, mainUv), _AmountTex10);*/

    float2 mainUV1 = FlipbookCalculation(mainUv, _MainTexColumns1, _MainTexRows1, _MainTexSpeed1, _MainTexFrameIND1, _MainTexEndFrameIND1);
    float2 mainUV2 = FlipbookCalculation(mainUv, _MainTexColumns2, _MainTexRows2, _MainTexSpeed2, _MainTexFrameIND2, _MainTexEndFrameIND2);
    float2 mainUV3 = FlipbookCalculation(mainUv, _MainTexColumns3, _MainTexRows3, _MainTexSpeed3, _MainTexFrameIND3, _MainTexEndFrameIND3);
    float2 mainUV4 = FlipbookCalculation(mainUv, _MainTexColumns4, _MainTexRows4, _MainTexSpeed4, _MainTexFrameIND4, _MainTexEndFrameIND4);
    float2 mainUV5 = FlipbookCalculation(mainUv, _MainTexColumns5, _MainTexRows5, _MainTexSpeed5, _MainTexFrameIND5, _MainTexEndFrameIND5);
    float2 mainUV6 = FlipbookCalculation(mainUv, _MainTexColumns6, _MainTexRows6, _MainTexSpeed6, _MainTexFrameIND6, _MainTexEndFrameIND6);
    float2 mainUV7 = FlipbookCalculation(mainUv, _MainTexColumns7, _MainTexRows7, _MainTexSpeed7, _MainTexFrameIND7, _MainTexEndFrameIND7);
    float2 mainUV8 = FlipbookCalculation(mainUv, _MainTexColumns8, _MainTexRows8, _MainTexSpeed8, _MainTexFrameIND8, _MainTexEndFrameIND8);
    float2 mainUV9 = FlipbookCalculation(mainUv, _MainTexColumns9, _MainTexRows9, _MainTexSpeed9, _MainTexFrameIND9, _MainTexEndFrameIND9);
    float2 mainUV10 = FlipbookCalculation(mainUv, _MainTexColumns10, _MainTexRows10, _MainTexSpeed10, _MainTexFrameIND10, _MainTexEndFrameIND10);

    half4 mainTex = _MainTex.Sample(sampler_MainTex, mainUV1);
    mainTex = lerp(mainTex, _MainTex2.Sample(sampler_MainTex, mainUV2), _AmountTex2);
    mainTex = lerp(mainTex, _MainTex3.Sample(sampler_MainTex, mainUV3), _AmountTex3);
    mainTex = lerp(mainTex, _MainTex4.Sample(sampler_MainTex, mainUV4), _AmountTex4);
    mainTex = lerp(mainTex, _MainTex5.Sample(sampler_MainTex, mainUV5), _AmountTex5);
    mainTex = lerp(mainTex, _MainTex6.Sample(sampler_MainTex, mainUV6), _AmountTex6);
    mainTex = lerp(mainTex, _MainTex7.Sample(sampler_MainTex, mainUV7), _AmountTex7);
    mainTex = lerp(mainTex, _MainTex8.Sample(sampler_MainTex, mainUV8), _AmountTex8);
    mainTex = lerp(mainTex, _MainTex9.Sample(sampler_MainTex, mainUV9), _AmountTex9);
    mainTex = lerp(mainTex, _MainTex10.Sample(sampler_MainTex, mainUV10), _AmountTex10);

    half4 mainColor = _Color;
    mainColor = lerp(mainColor, _MainColor2, _AmountTex2);
    mainColor = lerp(mainColor, _MainColor3, _AmountTex3);
    mainColor = lerp(mainColor, _MainColor4, _AmountTex4);
    mainColor = lerp(mainColor, _MainColor5, _AmountTex5);
    mainColor = lerp(mainColor, _MainColor6, _AmountTex6);
    mainColor = lerp(mainColor, _MainColor7, _AmountTex7);
    mainColor = lerp(mainColor, _MainColor8, _AmountTex8);
    mainColor = lerp(mainColor, _MainColor9, _AmountTex9);
    mainColor = lerp(mainColor, _MainColor10, _AmountTex10);

    // main tex decal
    float2 DecalUV1 = FlipbookCalculation(mainUv, _DecalTexColumns1, _DecalTexRows1, _DecalTexSpeed1, _DecalTexFrameIND1, _DecalTexEndFrameIND1);
    float2 DecalUV2 = FlipbookCalculation(mainUv, _DecalTexColumns2, _DecalTexRows2, _DecalTexSpeed2, _DecalTexFrameIND2, _DecalTexEndFrameIND2);
    float2 DecalUV3 = FlipbookCalculation(mainUv, _DecalTexColumns3, _DecalTexRows3, _DecalTexSpeed3, _DecalTexFrameIND3, _DecalTexEndFrameIND3);
    float2 DecalUV4 = FlipbookCalculation(mainUv, _DecalTexColumns4, _DecalTexRows4, _DecalTexSpeed4, _DecalTexFrameIND4, _DecalTexEndFrameIND4);
    float2 DecalUV5 = FlipbookCalculation(mainUv, _DecalTexColumns5, _DecalTexRows5, _DecalTexSpeed5, _DecalTexFrameIND5, _DecalTexEndFrameIND5);
    float2 DecalUV6 = FlipbookCalculation(mainUv, _DecalTexColumns6, _DecalTexRows6, _DecalTexSpeed6, _DecalTexFrameIND6, _DecalTexEndFrameIND6);
    float2 DecalUV7 = FlipbookCalculation(mainUv, _DecalTexColumns7, _DecalTexRows7, _DecalTexSpeed7, _DecalTexFrameIND7, _DecalTexEndFrameIND7);
    float2 DecalUV8 = FlipbookCalculation(mainUv, _DecalTexColumns8, _DecalTexRows8, _DecalTexSpeed8, _DecalTexFrameIND8, _DecalTexEndFrameIND8);
    float2 DecalUV9 = FlipbookCalculation(mainUv, _DecalTexColumns9, _DecalTexRows9, _DecalTexSpeed9, _DecalTexFrameIND9, _DecalTexEndFrameIND9);
    float2 DecalUV10 = FlipbookCalculation(mainUv, _DecalTexColumns10, _DecalTexRows10, _DecalTexSpeed10, _DecalTexFrameIND10, _DecalTexEndFrameIND10);

    half4 decalTex = _DecalTex1.Sample(sampler_DecalTex1, DecalUV1) * _AmountDecal1;
    decalTex = lerp(decalTex, _DecalTex2.Sample(sampler_DecalTex1, DecalUV2), _DecalTex2.Sample(sampler_DecalTex1, DecalUV2).a * _AmountDecal2);
    decalTex = lerp(decalTex, _DecalTex3.Sample(sampler_DecalTex1, DecalUV3), _DecalTex3.Sample(sampler_DecalTex1, DecalUV3).a * _AmountDecal3);
    decalTex = lerp(decalTex, _DecalTex4.Sample(sampler_DecalTex1, DecalUV4), _DecalTex4.Sample(sampler_DecalTex1, DecalUV4).a * _AmountDecal4);
    decalTex = lerp(decalTex, _DecalTex5.Sample(sampler_DecalTex1, DecalUV5), _DecalTex5.Sample(sampler_DecalTex1, DecalUV5).a * _AmountDecal5);
    decalTex = lerp(decalTex, _DecalTex6.Sample(sampler_DecalTex1, DecalUV6), _DecalTex6.Sample(sampler_DecalTex1, DecalUV6).a * _AmountDecal6);
    decalTex = lerp(decalTex, _DecalTex7.Sample(sampler_DecalTex1, DecalUV7), _DecalTex7.Sample(sampler_DecalTex1, DecalUV7).a * _AmountDecal7);
    decalTex = lerp(decalTex, _DecalTex8.Sample(sampler_DecalTex1, DecalUV8), _DecalTex8.Sample(sampler_DecalTex1, DecalUV8).a * _AmountDecal8);
    decalTex = lerp(decalTex, _DecalTex9.Sample(sampler_DecalTex1, DecalUV9), _DecalTex9.Sample(sampler_DecalTex1, DecalUV9).a * _AmountDecal9);
    decalTex = lerp(decalTex, _DecalTex10.Sample(sampler_DecalTex1, DecalUV10), _DecalTex10.Sample(sampler_DecalTex1, DecalUV10).a * _AmountDecal10);

    mainTex = lerp(mainTex, decalTex, decalTex.a);

    //mainTex = mainTex + decalTex;

    // shade color
    /*half4 shadeTex = tex2D(_ShadeTexture, mainUv);

    shadeTex = lerp(mainTex, tex2D(_ShadeTex2, mainUv), _AmountTex2);
    shadeTex = lerp(mainTex, tex2D(_ShadeTex3, mainUv), _AmountTex3);

    shadeTex = lerp(mainTex, UNITY_SAMPLE_TEX2D(_ShadeTex4, mainUv), _AmountTex4);

    shadeTex = lerp(shadeTex, UNITY_SAMPLE_TEX2D_SAMPLER(_ShadeTex5, _ShadeTex4, mainUv), _AmountTex5);
    shadeTex = lerp(shadeTex, UNITY_SAMPLE_TEX2D_SAMPLER(_ShadeTex6, _ShadeTex4, mainUv), _AmountTex6);
    shadeTex = lerp(shadeTex, UNITY_SAMPLE_TEX2D_SAMPLER(_ShadeTex7, _ShadeTex4, mainUv), _AmountTex7);
    shadeTex = lerp(shadeTex, UNITY_SAMPLE_TEX2D_SAMPLER(_ShadeTex8, _ShadeTex4, mainUv), _AmountTex8);
    shadeTex = lerp(shadeTex, UNITY_SAMPLE_TEX2D_SAMPLER(_ShadeTex9, _ShadeTex4, mainUv), _AmountTex9);
    shadeTex = lerp(shadeTex, UNITY_SAMPLE_TEX2D_SAMPLER(_ShadeTex10, _ShadeTex4, mainUv), _AmountTex10);*/

    half4 shadeTex = _ShadeTexture.Sample(sampler_ShadeTexture, mainUV1);
    shadeTex = lerp(shadeTex, _ShadeTex2.Sample(sampler_ShadeTexture, mainUV2), _AmountTex2);
    shadeTex = lerp(shadeTex, _ShadeTex3.Sample(sampler_ShadeTexture, mainUV3), _AmountTex3);
    shadeTex = lerp(shadeTex, _ShadeTex4.Sample(sampler_ShadeTexture, mainUV4), _AmountTex4);
    shadeTex = lerp(shadeTex, _ShadeTex5.Sample(sampler_ShadeTexture, mainUV5), _AmountTex5);
    shadeTex = lerp(shadeTex, _ShadeTex6.Sample(sampler_ShadeTexture, mainUV6), _AmountTex6);
    shadeTex = lerp(shadeTex, _ShadeTex7.Sample(sampler_ShadeTexture, mainUV7), _AmountTex7);
    shadeTex = lerp(shadeTex, _ShadeTex8.Sample(sampler_ShadeTexture, mainUV8), _AmountTex8);
    shadeTex = lerp(shadeTex, _ShadeTex9.Sample(sampler_ShadeTexture, mainUV9), _AmountTex9);
    shadeTex = lerp(shadeTex, _ShadeTex10.Sample(sampler_ShadeTexture, mainUV10), _AmountTex10);

    //shadeTex = shadeTex + decalTex;
    shadeTex = lerp(shadeTex, decalTex, decalTex.a);

    half4 shadeColor = _ShadeColor;
    shadeColor = lerp(shadeColor, _ShadeColor2, _AmountTex2);
    shadeColor = lerp(shadeColor, _ShadeColor3, _AmountTex3);
    shadeColor = lerp(shadeColor, _ShadeColor4, _AmountTex4);
    shadeColor = lerp(shadeColor, _ShadeColor5, _AmountTex5);
    shadeColor = lerp(shadeColor, _ShadeColor6, _AmountTex6);
    shadeColor = lerp(shadeColor, _ShadeColor7, _AmountTex7);
    shadeColor = lerp(shadeColor, _ShadeColor8, _AmountTex8);
    shadeColor = lerp(shadeColor, _ShadeColor9, _AmountTex9);
    shadeColor = lerp(shadeColor, _ShadeColor10, _AmountTex10);
    
    // alpha
    half alpha = 1;
#ifdef _ALPHATEST_ON
    alpha = mainColor.a * mainTex.a;
    alpha = (alpha - _Cutoff) / max(fwidth(alpha), EPS_COL) + 0.5; // Alpha to Coverage
    clip(alpha - _Cutoff);
    alpha = 1.0; // Discarded, otherwise it should be assumed to have full opacity
#endif
#ifdef _ALPHABLEND_ON
    alpha = mainColor.a * mainTex.a;
#if !_ALPHATEST_ON && SHADER_API_D3D11 // Only enable this on D3D11, where I tested it
    clip(alpha - 0.0001);              // Slightly improves rendering with layered transparency
#endif
#endif
    
    // normal
#ifdef _NORMALMAP
    half3 tangentNormal = UnpackScaleNormal(tex2D(_BumpMap, mainUv), _BumpScale);
    half3 worldNormal;
    worldNormal.x = dot(i.tspace0, tangentNormal);
    worldNormal.y = dot(i.tspace1, tangentNormal);
    worldNormal.z = dot(i.tspace2, tangentNormal);
#else
    half3 worldNormal = half3(i.tspace0.z, i.tspace1.z, i.tspace2.z);
#endif
    float3 worldView = normalize(lerp(_WorldSpaceCameraPos.xyz - i.posWorld.xyz, UNITY_MATRIX_V[2].xyz, unity_OrthoParams.w));
    worldNormal *= step(0, dot(worldView, worldNormal)) * 2 - 1; // flip if projection matrix is flipped
    worldNormal *= lerp(+1.0, -1.0, i.isOutline);
    worldNormal = normalize(worldNormal);

    // Unity lighting
    UNITY_LIGHT_ATTENUATION(shadowAttenuation, i, i.posWorld.xyz);
    half3 lightDir = lerp(_WorldSpaceLightPos0.xyz, normalize(_WorldSpaceLightPos0.xyz - i.posWorld.xyz), _WorldSpaceLightPos0.w);
    half3 lightColor = _LightColor0.rgb * step(0.5, length(lightDir)); // length(lightDir) is zero if directional light is disabled.
    half dotNL = dot(lightDir, worldNormal);
#ifdef MTOON_FORWARD_ADD
    half lightAttenuation = 1;
#else
    half lightAttenuation = shadowAttenuation * lerp(1, shadowAttenuation, _ReceiveShadowRate * tex2D(_ReceiveShadowTexture, mainUv).r);
#endif
    
    // Decide albedo color rate from Direct Light
    half shadingGrade = 1.0 - _ShadingGradeRate * (1.0 - tex2D(_ShadingGradeTexture, mainUv).r);
    half lightIntensity = dotNL; // [-1, +1]
    lightIntensity = lightIntensity * 0.5 + 0.5; // from [-1, +1] to [0, 1]
    lightIntensity = lightIntensity * lightAttenuation; // receive shadow
    lightIntensity = lightIntensity * shadingGrade; // darker
    lightIntensity = lightIntensity * 2.0 - 1; // from [0, 1] to [-1, +1]
    // tooned. mapping from [minIntensityThreshold, maxIntensityThreshold] to [0, 1]
    half maxIntensityThreshold = lerp(1, _ShadeShift, _ShadeToony);
    half minIntensityThreshold = _ShadeShift;
    lightIntensity = saturate((lightIntensity - minIntensityThreshold) / max(EPS_COL, (maxIntensityThreshold - minIntensityThreshold)));
    
    // Albedo color
    half4 shade = shadeColor * shadeTex;
    half4 lit = mainColor * mainTex;
    half3 col = lerp(shade.rgb, lit.rgb, lightIntensity);

    // Direct Light
    half3 lighting = lightColor;
    lighting = lerp(lighting, max(EPS_COL, max(lighting.x, max(lighting.y, lighting.z))), _LightColorAttenuation); // color atten
#ifdef MTOON_FORWARD_ADD
#ifdef _ALPHABLEND_ON
    lighting *= step(0, dotNL); // darken if transparent. Because Unity's transparent material can't receive shadowAttenuation.
#endif
    lighting *= 0.5; // darken if additional light.
    lighting *= min(0, dotNL) + 1; // darken dotNL < 0 area by using half lambert
    lighting *= shadowAttenuation; // darken if receiving shadow
#else
    // base light does not darken.
#endif
    col *= lighting;

    // Indirect Light
#ifdef MTOON_FORWARD_ADD
#else
    half3 toonedGI = 0.5 * (ShadeSH9(half4(0, 1, 0, 1)) + ShadeSH9(half4(0, -1, 0, 1)));
    half3 indirectLighting = lerp(toonedGI, ShadeSH9(half4(worldNormal, 1)), _IndirectLightIntensity);
    indirectLighting = lerp(indirectLighting, max(EPS_COL, max(indirectLighting.x, max(indirectLighting.y, indirectLighting.z))), _LightColorAttenuation); // color atten
    col += indirectLighting * lit;
    
    col = min(col, lit); // comment out if you want to PBR absolutely.
#endif

    // parametric rim lighting
#ifdef MTOON_FORWARD_ADD
    half3 staticRimLighting = 0;
    half3 mixedRimLighting = lighting;
#else
    half3 staticRimLighting = 1;
    half3 mixedRimLighting = lighting + indirectLighting;
#endif
    half3 rimLighting = lerp(staticRimLighting, mixedRimLighting, _RimLightingMix);
    half3 rim = pow(saturate(1.0 - dot(worldNormal, worldView) + _RimLift), _RimFresnelPower) * _RimColor.rgb * tex2D(_RimTexture, mainUv).rgb;
    col += lerp(rim * rimLighting, half3(0, 0, 0), i.isOutline);

    // additive matcap
#ifdef MTOON_FORWARD_ADD
#else
    half3 worldCameraUp = normalize(UNITY_MATRIX_V[1].xyz);
    half3 worldViewUp = normalize(worldCameraUp - worldView * dot(worldView, worldCameraUp));
    half3 worldViewRight = normalize(cross(worldView, worldViewUp));
    half2 matcapUv = half2(dot(worldViewRight, worldNormal), dot(worldViewUp, worldNormal)) * 0.5 + 0.5;
    half3 matcapLighting = tex2D(_SphereAdd, matcapUv);
    col += lerp(matcapLighting, half3(0, 0, 0), i.isOutline);
#endif

    // Emission
#ifdef MTOON_FORWARD_ADD
#else
    //half3 emission = tex2D(_EmissionMap, mainUv).rgb * _EmissionColor.rgb;
    half3 emission = _EmissionMap1.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns1, _EmissionTexRows1, _EmissionTexSpeed1, _EmissionTexFrameIND1, _EmissionTexEndFrameIND1)).rgb * _EmissionColor1.rgb * _EmissionAmount1;
    emission = lerp(emission, _EmissionMap2.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns2, _EmissionTexRows2, _EmissionTexSpeed2, _EmissionTexFrameIND2, _EmissionTexEndFrameIND2)) * _EmissionColor2.rgb, _EmissionAmount2);
    emission = lerp(emission, _EmissionMap3.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns3, _EmissionTexRows3, _EmissionTexSpeed3, _EmissionTexFrameIND3, _EmissionTexEndFrameIND3)) * _EmissionColor3.rgb, _EmissionAmount3);
    emission = lerp(emission, _EmissionMap4.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns4, _EmissionTexRows4, _EmissionTexSpeed4, _EmissionTexFrameIND4, _EmissionTexEndFrameIND4)) * _EmissionColor4.rgb, _EmissionAmount4);
    emission = lerp(emission, _EmissionMap5.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns5, _EmissionTexRows5, _EmissionTexSpeed5, _EmissionTexFrameIND5, _EmissionTexEndFrameIND5)) * _EmissionColor5.rgb, _EmissionAmount5);
    emission = lerp(emission, _EmissionMap6.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns6, _EmissionTexRows6, _EmissionTexSpeed6, _EmissionTexFrameIND6, _EmissionTexEndFrameIND6)) * _EmissionColor6.rgb, _EmissionAmount6);
    emission = lerp(emission, _EmissionMap7.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns7, _EmissionTexRows7, _EmissionTexSpeed7, _EmissionTexFrameIND7, _EmissionTexEndFrameIND7)) * _EmissionColor7.rgb, _EmissionAmount7);
    emission = lerp(emission, _EmissionMap8.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns8, _EmissionTexRows8, _EmissionTexSpeed8, _EmissionTexFrameIND8, _EmissionTexEndFrameIND8)) * _EmissionColor8.rgb, _EmissionAmount8);
    emission = lerp(emission, _EmissionMap9.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns9, _EmissionTexRows9, _EmissionTexSpeed9, _EmissionTexFrameIND9, _EmissionTexEndFrameIND9)) * _EmissionColor9.rgb, _EmissionAmount9);
    emission = lerp(emission, _EmissionMap10.Sample(sampler_EmissionMap1, FlipbookCalculation(mainUv, _EmissionTexColumns10, _EmissionTexRows10, _EmissionTexSpeed10, _EmissionTexFrameIND10, _EmissionTexEndFrameIND10)) * _EmissionColor10.rgb, _EmissionAmount10);
    col += lerp(emission, half3(0, 0, 0), i.isOutline);
#endif

    // outline
#ifdef MTOON_OUTLINE_COLOR_FIXED
    col = lerp(col, _OutlineColor, i.isOutline);
#elif MTOON_OUTLINE_COLOR_MIXED
    col = lerp(col, _OutlineColor * lerp(half3(1, 1, 1), col, _OutlineLightingMix), i.isOutline);
#else
#endif

    // debug
#ifdef MTOON_DEBUG_NORMAL
    #ifdef MTOON_FORWARD_ADD
        return float4(0, 0, 0, 0);
    #else
        return float4(worldNormal * 0.5 + 0.5, alpha);
    #endif
#elif MTOON_DEBUG_LITSHADERATE
    #ifdef MTOON_FORWARD_ADD
        return float4(0, 0, 0, 0);
    #else
        return float4(lightIntensity * lighting, alpha);
    #endif
#endif


    half4 result = half4(col, alpha);
    UNITY_APPLY_FOG(i.fogCoord, result);
    return result;
}

#endif // MTOON_CORE_INCLUDED
