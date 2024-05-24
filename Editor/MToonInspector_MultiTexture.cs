using System;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace MToon
{
    public class MToonInspector_MultiTexture : ShaderGUI
    {
        private const float RoundsToDegree = 360f;
        private const float RoundsToRadian = (float) Math.PI * 2f;

        private static bool isAdvancedLightingPanelFoldout = false;
        private static EditorRotationUnit editorRotationUnit = EditorRotationUnit.Rounds;

        private MaterialProperty _version;
        private MaterialProperty _blendMode;
        private MaterialProperty _bumpMap;
        private MaterialProperty _bumpScale;
        private MaterialProperty _color;
        private MaterialProperty _cullMode;
        private MaterialProperty _StencilID;
        //        private MaterialProperty _outlineCullMode;
        private MaterialProperty _cutoff;

        //Begin MainTex Flipbook Settings
        private static bool ColorFlipbookFoldout1 = false;
        private static bool ColorFlipbookFoldout2 = false;
        private static bool ColorFlipbookFoldout3 = false;
        private static bool ColorFlipbookFoldout4 = false;
        private static bool ColorFlipbookFoldout5 = false;
        private static bool ColorFlipbookFoldout6 = false;
        private static bool ColorFlipbookFoldout7 = false;
        private static bool ColorFlipbookFoldout8 = false;
        private static bool ColorFlipbookFoldout9 = false;
        private static bool ColorFlipbookFoldout10 = false;

        private MaterialProperty _mainTexColumns1;
        private MaterialProperty _mainTexColumns2;
        private MaterialProperty _mainTexColumns3;
        private MaterialProperty _mainTexColumns4;
        private MaterialProperty _mainTexColumns5;
        private MaterialProperty _mainTexColumns6;
        private MaterialProperty _mainTexColumns7;
        private MaterialProperty _mainTexColumns8;
        private MaterialProperty _mainTexColumns9;
        private MaterialProperty _mainTexColumns10;

        private MaterialProperty _mainTexRows1;
        private MaterialProperty _mainTexRows2;
        private MaterialProperty _mainTexRows3;
        private MaterialProperty _mainTexRows4;
        private MaterialProperty _mainTexRows5;
        private MaterialProperty _mainTexRows6;
        private MaterialProperty _mainTexRows7;
        private MaterialProperty _mainTexRows8;
        private MaterialProperty _mainTexRows9;
        private MaterialProperty _mainTexRows10;

        private MaterialProperty _mainTexSpeed1;
        private MaterialProperty _mainTexSpeed2;
        private MaterialProperty _mainTexSpeed3;
        private MaterialProperty _mainTexSpeed4;
        private MaterialProperty _mainTexSpeed5;
        private MaterialProperty _mainTexSpeed6;
        private MaterialProperty _mainTexSpeed7;
        private MaterialProperty _mainTexSpeed8;
        private MaterialProperty _mainTexSpeed9;
        private MaterialProperty _mainTexSpeed10;

        private MaterialProperty _mainTexFrameIND1;
        private MaterialProperty _mainTexFrameIND2;
        private MaterialProperty _mainTexFrameIND3;
        private MaterialProperty _mainTexFrameIND4;
        private MaterialProperty _mainTexFrameIND5;
        private MaterialProperty _mainTexFrameIND6;
        private MaterialProperty _mainTexFrameIND7;
        private MaterialProperty _mainTexFrameIND8;
        private MaterialProperty _mainTexFrameIND9;
        private MaterialProperty _mainTexFrameIND10;

        private MaterialProperty _mainTexEndFrameIND1;
        private MaterialProperty _mainTexEndFrameIND2;
        private MaterialProperty _mainTexEndFrameIND3;
        private MaterialProperty _mainTexEndFrameIND4;
        private MaterialProperty _mainTexEndFrameIND5;
        private MaterialProperty _mainTexEndFrameIND6;
        private MaterialProperty _mainTexEndFrameIND7;
        private MaterialProperty _mainTexEndFrameIND8;
        private MaterialProperty _mainTexEndFrameIND9;
        private MaterialProperty _mainTexEndFrameIND10;

        private static EditorWrapMode MainTexWrapMode1;
        private static EditorWrapMode MainTexWrapMode2;
        private static EditorWrapMode MainTexWrapMode3;
        private static EditorWrapMode MainTexWrapMode4;
        private static EditorWrapMode MainTexWrapMode5;
        private static EditorWrapMode MainTexWrapMode6;
        private static EditorWrapMode MainTexWrapMode7;
        private static EditorWrapMode MainTexWrapMode8;
        private static EditorWrapMode MainTexWrapMode9;
        private static EditorWrapMode MainTexWrapMode10;

        private MaterialProperty _mainTexWrapMode1;
        private MaterialProperty _mainTexWrapMode2;
        private MaterialProperty _mainTexWrapMode3;
        private MaterialProperty _mainTexWrapMode4;
        private MaterialProperty _mainTexWrapMode5;
        private MaterialProperty _mainTexWrapMode6;
        private MaterialProperty _mainTexWrapMode7;
        private MaterialProperty _mainTexWrapMode8;
        private MaterialProperty _mainTexWrapMode9;
        private MaterialProperty _mainTexWrapMode10;

        //private static EditorWrapMode _mainTexWrapMode1 = EditorWrapMode.Repeat;

        //End MainTex Flipbook Settings

        //Begin Decal Flipbook Settings
        private static bool DecalFlipBookFoldout1 = false;
        private static bool DecalFlipBookFoldout2 = false;
        private static bool DecalFlipBookFoldout3 = false;
        private static bool DecalFlipBookFoldout4 = false;
        private static bool DecalFlipBookFoldout5 = false;
        private static bool DecalFlipBookFoldout6 = false;
        private static bool DecalFlipBookFoldout7 = false;
        private static bool DecalFlipBookFoldout8 = false;
        private static bool DecalFlipBookFoldout9 = false;
        private static bool DecalFlipBookFoldout10 = false;

        private MaterialProperty _decalTexColumns1;
        private MaterialProperty _decalTexColumns2;
        private MaterialProperty _decalTexColumns3;
        private MaterialProperty _decalTexColumns4;
        private MaterialProperty _decalTexColumns5;
        private MaterialProperty _decalTexColumns6;
        private MaterialProperty _decalTexColumns7;
        private MaterialProperty _decalTexColumns8;
        private MaterialProperty _decalTexColumns9;
        private MaterialProperty _decalTexColumns10;

        private MaterialProperty _decalTexRows1;
        private MaterialProperty _decalTexRows2;
        private MaterialProperty _decalTexRows3;
        private MaterialProperty _decalTexRows4;
        private MaterialProperty _decalTexRows5;
        private MaterialProperty _decalTexRows6;
        private MaterialProperty _decalTexRows7;
        private MaterialProperty _decalTexRows8;
        private MaterialProperty _decalTexRows9;
        private MaterialProperty _decalTexRows10;

        private MaterialProperty _decalTexSpeed1;
        private MaterialProperty _decalTexSpeed2;
        private MaterialProperty _decalTexSpeed3;
        private MaterialProperty _decalTexSpeed4;
        private MaterialProperty _decalTexSpeed5;
        private MaterialProperty _decalTexSpeed6;
        private MaterialProperty _decalTexSpeed7;
        private MaterialProperty _decalTexSpeed8;
        private MaterialProperty _decalTexSpeed9;
        private MaterialProperty _decalTexSpeed10;

        private MaterialProperty _decalTexFrameIND1;
        private MaterialProperty _decalTexFrameIND2;
        private MaterialProperty _decalTexFrameIND3;
        private MaterialProperty _decalTexFrameIND4;
        private MaterialProperty _decalTexFrameIND5;
        private MaterialProperty _decalTexFrameIND6;
        private MaterialProperty _decalTexFrameIND7;
        private MaterialProperty _decalTexFrameIND8;
        private MaterialProperty _decalTexFrameIND9;
        private MaterialProperty _decalTexFrameIND10;

        private MaterialProperty _decalTexEndFrameIND1;
        private MaterialProperty _decalTexEndFrameIND2;
        private MaterialProperty _decalTexEndFrameIND3;
        private MaterialProperty _decalTexEndFrameIND4;
        private MaterialProperty _decalTexEndFrameIND5;
        private MaterialProperty _decalTexEndFrameIND6;
        private MaterialProperty _decalTexEndFrameIND7;
        private MaterialProperty _decalTexEndFrameIND8;
        private MaterialProperty _decalTexEndFrameIND9;
        private MaterialProperty _decalTexEndFrameIND10;

        private static EditorWrapMode DecalTexWrapMode1;
        private static EditorWrapMode DecalTexWrapMode2;
        private static EditorWrapMode DecalTexWrapMode3;
        private static EditorWrapMode DecalTexWrapMode4;
        private static EditorWrapMode DecalTexWrapMode5;
        private static EditorWrapMode DecalTexWrapMode6;
        private static EditorWrapMode DecalTexWrapMode7;
        private static EditorWrapMode DecalTexWrapMode8;
        private static EditorWrapMode DecalTexWrapMode9;
        private static EditorWrapMode DecalTexWrapMode10;

        private MaterialProperty _decalTexWrapMode1;
        private MaterialProperty _decalTexWrapMode2;
        private MaterialProperty _decalTexWrapMode3;
        private MaterialProperty _decalTexWrapMode4;
        private MaterialProperty _decalTexWrapMode5;
        private MaterialProperty _decalTexWrapMode6;
        private MaterialProperty _decalTexWrapMode7;
        private MaterialProperty _decalTexWrapMode8;
        private MaterialProperty _decalTexWrapMode9;
        private MaterialProperty _decalTexWrapMode10;
        //End DecalTex Flipbook Settings

        //Begin Decal Flipbook Settings
        private static bool EmissionFlipBookFoldout1 = false;
        private static bool EmissionFlipBookFoldout2 = false;
        private static bool EmissionFlipBookFoldout3 = false;
        private static bool EmissionFlipBookFoldout4 = false;
        private static bool EmissionFlipBookFoldout5 = false;
        private static bool EmissionFlipBookFoldout6 = false;
        private static bool EmissionFlipBookFoldout7 = false;
        private static bool EmissionFlipBookFoldout8 = false;
        private static bool EmissionFlipBookFoldout9 = false;
        private static bool EmissionFlipBookFoldout10 = false;

        private MaterialProperty _emissionTexColumns1;
        private MaterialProperty _emissionTexColumns2;
        private MaterialProperty _emissionTexColumns3;
        private MaterialProperty _emissionTexColumns4;
        private MaterialProperty _emissionTexColumns5;
        private MaterialProperty _emissionTexColumns6;
        private MaterialProperty _emissionTexColumns7;
        private MaterialProperty _emissionTexColumns8;
        private MaterialProperty _emissionTexColumns9;
        private MaterialProperty _emissionTexColumns10;

        private MaterialProperty _emissionTexRows1;
        private MaterialProperty _emissionTexRows2;
        private MaterialProperty _emissionTexRows3;
        private MaterialProperty _emissionTexRows4;
        private MaterialProperty _emissionTexRows5;
        private MaterialProperty _emissionTexRows6;
        private MaterialProperty _emissionTexRows7;
        private MaterialProperty _emissionTexRows8;
        private MaterialProperty _emissionTexRows9;
        private MaterialProperty _emissionTexRows10;

        private MaterialProperty _emissionTexSpeed1;
        private MaterialProperty _emissionTexSpeed2;
        private MaterialProperty _emissionTexSpeed3;
        private MaterialProperty _emissionTexSpeed4;
        private MaterialProperty _emissionTexSpeed5;
        private MaterialProperty _emissionTexSpeed6;
        private MaterialProperty _emissionTexSpeed7;
        private MaterialProperty _emissionTexSpeed8;
        private MaterialProperty _emissionTexSpeed9;
        private MaterialProperty _emissionTexSpeed10;

        private MaterialProperty _emissionTexFrameIND1;
        private MaterialProperty _emissionTexFrameIND2;
        private MaterialProperty _emissionTexFrameIND3;
        private MaterialProperty _emissionTexFrameIND4;
        private MaterialProperty _emissionTexFrameIND5;
        private MaterialProperty _emissionTexFrameIND6;
        private MaterialProperty _emissionTexFrameIND7;
        private MaterialProperty _emissionTexFrameIND8;
        private MaterialProperty _emissionTexFrameIND9;
        private MaterialProperty _emissionTexFrameIND10;

        private MaterialProperty _emissionTexEndFrameIND1;
        private MaterialProperty _emissionTexEndFrameIND2;
        private MaterialProperty _emissionTexEndFrameIND3;
        private MaterialProperty _emissionTexEndFrameIND4;
        private MaterialProperty _emissionTexEndFrameIND5;
        private MaterialProperty _emissionTexEndFrameIND6;
        private MaterialProperty _emissionTexEndFrameIND7;
        private MaterialProperty _emissionTexEndFrameIND8;
        private MaterialProperty _emissionTexEndFrameIND9;
        private MaterialProperty _emissionTexEndFrameIND10;

        private static EditorWrapMode EmissionTexWrapMode1;
        private static EditorWrapMode EmissionTexWrapMode2;
        private static EditorWrapMode EmissionTexWrapMode3;
        private static EditorWrapMode EmissionTexWrapMode4;
        private static EditorWrapMode EmissionTexWrapMode5;
        private static EditorWrapMode EmissionTexWrapMode6;
        private static EditorWrapMode EmissionTexWrapMode7;
        private static EditorWrapMode EmissionTexWrapMode8;
        private static EditorWrapMode EmissionTexWrapMode9;
        private static EditorWrapMode EmissionTexWrapMode10;

        private MaterialProperty _emissionTexWrapMode1;
        private MaterialProperty _emissionTexWrapMode2;
        private MaterialProperty _emissionTexWrapMode3;
        private MaterialProperty _emissionTexWrapMode4;
        private MaterialProperty _emissionTexWrapMode5;
        private MaterialProperty _emissionTexWrapMode6;
        private MaterialProperty _emissionTexWrapMode7;
        private MaterialProperty _emissionTexWrapMode8;
        private MaterialProperty _emissionTexWrapMode9;
        private MaterialProperty _emissionTexWrapMode10;
        //End DecalTex Flipbook Settings

        private MaterialProperty _mainColor2;
        private MaterialProperty _mainColor3;
        private MaterialProperty _mainColor4;
        private MaterialProperty _mainColor5;
        private MaterialProperty _mainColor6;
        private MaterialProperty _mainColor7;
        private MaterialProperty _mainColor8;
        private MaterialProperty _mainColor9;
        private MaterialProperty _mainColor10;

        private MaterialProperty _debugMode;
        private MaterialProperty _emissionColor;
        private MaterialProperty _emissionMap;
        private MaterialProperty _lightColorAttenuation;
        private MaterialProperty _indirectLightIntensity;
        private MaterialProperty _mainTex;
        private MaterialProperty _mainTex2;
        private MaterialProperty _mainTex3;
        private MaterialProperty _mainTex4;
        private MaterialProperty _mainTex5;
        private MaterialProperty _mainTex6;
        private MaterialProperty _mainTex7;
        private MaterialProperty _mainTex8;
        private MaterialProperty _mainTex9;
        private MaterialProperty _mainTex10;

        //Begin Kitts Shade Tex vars
        private MaterialProperty _shadeColor2;
        private MaterialProperty _shadeColor3;
        private MaterialProperty _shadeColor4;
        private MaterialProperty _shadeColor5;
        private MaterialProperty _shadeColor6;
        private MaterialProperty _shadeColor7;
        private MaterialProperty _shadeColor8;
        private MaterialProperty _shadeColor9;
        private MaterialProperty _shadeColor10;

        private MaterialProperty _shadeTex2;
        private MaterialProperty _shadeTex3;
        private MaterialProperty _shadeTex4;
        private MaterialProperty _shadeTex5;
        private MaterialProperty _shadeTex6;
        private MaterialProperty _shadeTex7;
        private MaterialProperty _shadeTex8;
        private MaterialProperty _shadeTex9;
        private MaterialProperty _shadeTex10;
        //End Kitts Shade Tex vars

        //Begin Kitts Decal Tex vars
        private MaterialProperty _decalTex1;
        private MaterialProperty _decalTex2;
        private MaterialProperty _decalTex3;
        private MaterialProperty _decalTex4;
        private MaterialProperty _decalTex5;
        private MaterialProperty _decalTex6;
        private MaterialProperty _decalTex7;
        private MaterialProperty _decalTex8;
        private MaterialProperty _decalTex9;
        private MaterialProperty _decalTex10;
        //End Kitts Shade Tex vars

        private MaterialProperty _amountTex2;
        private MaterialProperty _amountTex3;
        private MaterialProperty _amountTex4;
        private MaterialProperty _amountTex5;
        private MaterialProperty _amountTex6;
        private MaterialProperty _amountTex7;
        private MaterialProperty _amountTex8;
        private MaterialProperty _amountTex9;
        private MaterialProperty _amountTex10;

        //Beging Kitts Decal Amounts
        private MaterialProperty _amountDecal1;
        private MaterialProperty _amountDecal2;
        private MaterialProperty _amountDecal3;
        private MaterialProperty _amountDecal4;
        private MaterialProperty _amountDecal5;
        private MaterialProperty _amountDecal6;
        private MaterialProperty _amountDecal7;
        private MaterialProperty _amountDecal8;
        private MaterialProperty _amountDecal9;
        private MaterialProperty _amountDecal10;
        //End Kitts Decal Amounts

        private MaterialProperty _emissionMap1;
        private MaterialProperty _emissionMap2;
        private MaterialProperty _emissionMap3;
        private MaterialProperty _emissionMap4;
        private MaterialProperty _emissionMap5;
        private MaterialProperty _emissionMap6;
        private MaterialProperty _emissionMap7;
        private MaterialProperty _emissionMap8;
        private MaterialProperty _emissionMap9;
        private MaterialProperty _emissionMap10;

        private MaterialProperty _emissionColor1;
        private MaterialProperty _emissionColor2;
        private MaterialProperty _emissionColor3;
        private MaterialProperty _emissionColor4;
        private MaterialProperty _emissionColor5;
        private MaterialProperty _emissionColor6;
        private MaterialProperty _emissionColor7;
        private MaterialProperty _emissionColor8;
        private MaterialProperty _emissionColor9;
        private MaterialProperty _emissionColor10;

        private MaterialProperty _emissionAmount1;
        private MaterialProperty _emissionAmount2;
        private MaterialProperty _emissionAmount3;
        private MaterialProperty _emissionAmount4;
        private MaterialProperty _emissionAmount5;
        private MaterialProperty _emissionAmount6;
        private MaterialProperty _emissionAmount7;
        private MaterialProperty _emissionAmount8;
        private MaterialProperty _emissionAmount9;
        private MaterialProperty _emissionAmount10;



        private MaterialProperty _outlineColor;
        private MaterialProperty _outlineColorMode;
        private MaterialProperty _outlineLightingMix;
        private MaterialProperty _outlineWidth;
        private MaterialProperty _outlineScaledMaxDistance;
        private MaterialProperty _outlineWidthMode;
        private MaterialProperty _outlineWidthTexture;
        private MaterialProperty _receiveShadowRate;
        private MaterialProperty _receiveShadowTexture;
        private MaterialProperty _shadingGradeRate;
        private MaterialProperty _shadingGradeTexture;
        private MaterialProperty _shadeColor;
        private MaterialProperty _shadeShift;
        private MaterialProperty _shadeTexture;
        private MaterialProperty _shadeToony;
        private MaterialProperty _sphereAdd;
        private MaterialProperty _rimColor;
        private MaterialProperty _rimTexture;
        private MaterialProperty _rimLightingMix;
        private MaterialProperty _rimFresnelPower;
        private MaterialProperty _rimLift;
        private MaterialProperty _uvAnimMaskTexture;
        private MaterialProperty _uvAnimScrollX;
        private MaterialProperty _uvAnimScrollY;
        private MaterialProperty _uvAnimRotation;

        private enum EditorWrapMode
        {

            Repeat = 0,
            Clamp = 2

        }
        public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties)
        {
            _version = FindProperty(Utils.PropVersion, properties);
            _debugMode = FindProperty(Utils.PropDebugMode, properties);
            _outlineWidthMode = FindProperty(Utils.PropOutlineWidthMode, properties);
            _outlineColorMode = FindProperty(Utils.PropOutlineColorMode, properties);
            _blendMode = FindProperty(Utils.PropBlendMode, properties);
            _cullMode = FindProperty(Utils.PropCullMode, properties);
//            _outlineCullMode = FindProperty(Utils.PropOutlineCullMode, properties);
            _cutoff = FindProperty(Utils.PropCutoff, properties);
            _StencilID = FindProperty("_StencilID", properties);

            //Begin MainTex Flipbook Settings
            _mainTexColumns1 = FindProperty("_MainTexColumns1", properties);
            _mainTexColumns2 = FindProperty("_MainTexColumns2", properties);
            _mainTexColumns3 = FindProperty("_MainTexColumns3", properties);
            _mainTexColumns4 = FindProperty("_MainTexColumns4", properties);
            _mainTexColumns5 = FindProperty("_MainTexColumns5", properties);
            _mainTexColumns6 = FindProperty("_MainTexColumns6", properties);
            _mainTexColumns7 = FindProperty("_MainTexColumns7", properties);
            _mainTexColumns8 = FindProperty("_MainTexColumns8", properties);
            _mainTexColumns9 = FindProperty("_MainTexColumns9", properties);
            _mainTexColumns10 = FindProperty("_MainTexColumns10", properties);

            _mainTexRows1 = FindProperty("_MainTexRows1", properties);
            _mainTexRows2 = FindProperty("_MainTexRows2", properties);
            _mainTexRows3 = FindProperty("_MainTexRows3", properties);
            _mainTexRows4 = FindProperty("_MainTexRows4", properties);
            _mainTexRows5 = FindProperty("_MainTexRows5", properties);
            _mainTexRows6 = FindProperty("_MainTexRows6", properties);
            _mainTexRows7 = FindProperty("_MainTexRows7", properties);
            _mainTexRows8 = FindProperty("_MainTexRows8", properties);
            _mainTexRows9 = FindProperty("_MainTexRows9", properties);
            _mainTexRows10 = FindProperty("_MainTexRows10", properties);

            _mainTexSpeed1 = FindProperty("_MainTexSpeed1", properties);
            _mainTexSpeed2 = FindProperty("_MainTexSpeed2", properties);
            _mainTexSpeed3 = FindProperty("_MainTexSpeed3", properties);
            _mainTexSpeed4 = FindProperty("_MainTexSpeed4", properties);
            _mainTexSpeed5 = FindProperty("_MainTexSpeed5", properties);
            _mainTexSpeed6 = FindProperty("_MainTexSpeed6", properties);
            _mainTexSpeed7 = FindProperty("_MainTexSpeed7", properties);
            _mainTexSpeed8 = FindProperty("_MainTexSpeed8", properties);
            _mainTexSpeed9 = FindProperty("_MainTexSpeed9", properties);
            _mainTexSpeed10 = FindProperty("_MainTexSpeed10", properties);

            _mainTexFrameIND1 = FindProperty("_MainTexFrameIND1", properties);
            _mainTexFrameIND2 = FindProperty("_MainTexFrameIND2", properties);
            _mainTexFrameIND3 = FindProperty("_MainTexFrameIND3", properties);
            _mainTexFrameIND4 = FindProperty("_MainTexFrameIND4", properties);
            _mainTexFrameIND5 = FindProperty("_MainTexFrameIND5", properties);
            _mainTexFrameIND6 = FindProperty("_MainTexFrameIND6", properties);
            _mainTexFrameIND7 = FindProperty("_MainTexFrameIND7", properties);
            _mainTexFrameIND8 = FindProperty("_MainTexFrameIND8", properties);
            _mainTexFrameIND9 = FindProperty("_MainTexFrameIND9", properties);
            _mainTexFrameIND10 = FindProperty("_MainTexFrameIND10", properties);

            _mainTexEndFrameIND1 = FindProperty("_MainTexEndFrameIND1", properties);
            _mainTexEndFrameIND2 = FindProperty("_MainTexEndFrameIND2", properties);
            _mainTexEndFrameIND3 = FindProperty("_MainTexEndFrameIND3", properties);
            _mainTexEndFrameIND4 = FindProperty("_MainTexEndFrameIND4", properties);
            _mainTexEndFrameIND5 = FindProperty("_MainTexEndFrameIND5", properties);
            _mainTexEndFrameIND6 = FindProperty("_MainTexEndFrameIND6", properties);
            _mainTexEndFrameIND7 = FindProperty("_MainTexEndFrameIND7", properties);
            _mainTexEndFrameIND8 = FindProperty("_MainTexEndFrameIND8", properties);
            _mainTexEndFrameIND9 = FindProperty("_MainTexEndFrameIND9", properties);
            _mainTexEndFrameIND10 = FindProperty("_MainTexEndFrameIND10", properties);

            _mainTexWrapMode1 = FindProperty("_MainTexWrapMode1", properties);
            _mainTexWrapMode2 = FindProperty("_MainTexWrapMode2", properties);
            _mainTexWrapMode3 = FindProperty("_MainTexWrapMode3", properties);
            _mainTexWrapMode4 = FindProperty("_MainTexWrapMode4", properties);
            _mainTexWrapMode5 = FindProperty("_MainTexWrapMode5", properties);
            _mainTexWrapMode6 = FindProperty("_MainTexWrapMode6", properties);
            _mainTexWrapMode7 = FindProperty("_MainTexWrapMode7", properties);
            _mainTexWrapMode8 = FindProperty("_MainTexWrapMode8", properties);
            _mainTexWrapMode9 = FindProperty("_MainTexWrapMode9", properties);
            _mainTexWrapMode10 = FindProperty("_MainTexWrapMode10", properties);
            //End MainTex Flipbook Settings

            //Begin Decal Flipbook Settings
            _decalTexColumns1 = FindProperty("_DecalTexColumns1", properties);
            _decalTexColumns2 = FindProperty("_DecalTexColumns2", properties);
            _decalTexColumns3 = FindProperty("_DecalTexColumns3", properties);
            _decalTexColumns4 = FindProperty("_DecalTexColumns4", properties);
            _decalTexColumns5 = FindProperty("_DecalTexColumns5", properties);
            _decalTexColumns6 = FindProperty("_DecalTexColumns6", properties);
            _decalTexColumns7 = FindProperty("_DecalTexColumns7", properties);
            _decalTexColumns8 = FindProperty("_DecalTexColumns8", properties);
            _decalTexColumns9 = FindProperty("_DecalTexColumns9", properties);
            _decalTexColumns10 = FindProperty("_DecalTexColumns10", properties);

            _decalTexRows1 = FindProperty("_DecalTexRows1", properties);
            _decalTexRows2 = FindProperty("_DecalTexRows2", properties);
            _decalTexRows3 = FindProperty("_DecalTexRows3", properties);
            _decalTexRows4 = FindProperty("_DecalTexRows4", properties);
            _decalTexRows5 = FindProperty("_DecalTexRows5", properties);
            _decalTexRows6 = FindProperty("_DecalTexRows6", properties);
            _decalTexRows7 = FindProperty("_DecalTexRows7", properties);
            _decalTexRows8 = FindProperty("_DecalTexRows8", properties);
            _decalTexRows9 = FindProperty("_DecalTexRows9", properties);
            _decalTexRows10 = FindProperty("_DecalTexRows10", properties);

            _decalTexSpeed1 = FindProperty("_DecalTexSpeed1", properties);
            _decalTexSpeed2 = FindProperty("_DecalTexSpeed2", properties);
            _decalTexSpeed3 = FindProperty("_DecalTexSpeed3", properties);
            _decalTexSpeed4 = FindProperty("_DecalTexSpeed4", properties);
            _decalTexSpeed5 = FindProperty("_DecalTexSpeed5", properties);
            _decalTexSpeed6 = FindProperty("_DecalTexSpeed6", properties);
            _decalTexSpeed7 = FindProperty("_DecalTexSpeed7", properties);
            _decalTexSpeed8 = FindProperty("_DecalTexSpeed8", properties);
            _decalTexSpeed9 = FindProperty("_DecalTexSpeed9", properties);
            _decalTexSpeed10 = FindProperty("_DecalTexSpeed10", properties);

            _decalTexFrameIND1 = FindProperty("_DecalTexFrameIND1", properties);
            _decalTexFrameIND2 = FindProperty("_DecalTexFrameIND2", properties);
            _decalTexFrameIND3 = FindProperty("_DecalTexFrameIND3", properties);
            _decalTexFrameIND4 = FindProperty("_DecalTexFrameIND4", properties);
            _decalTexFrameIND5 = FindProperty("_DecalTexFrameIND5", properties);
            _decalTexFrameIND6 = FindProperty("_DecalTexFrameIND6", properties);
            _decalTexFrameIND7 = FindProperty("_DecalTexFrameIND7", properties);
            _decalTexFrameIND8 = FindProperty("_DecalTexFrameIND8", properties);
            _decalTexFrameIND9 = FindProperty("_DecalTexFrameIND9", properties);
            _decalTexFrameIND10 = FindProperty("_DecalTexFrameIND10", properties);

            _decalTexEndFrameIND1 = FindProperty("_DecalTexEndFrameIND1", properties);
            _decalTexEndFrameIND2 = FindProperty("_DecalTexEndFrameIND2", properties);
            _decalTexEndFrameIND3 = FindProperty("_DecalTexEndFrameIND3", properties);
            _decalTexEndFrameIND4 = FindProperty("_DecalTexEndFrameIND4", properties);
            _decalTexEndFrameIND5 = FindProperty("_DecalTexEndFrameIND5", properties);
            _decalTexEndFrameIND6 = FindProperty("_DecalTexEndFrameIND6", properties);
            _decalTexEndFrameIND7 = FindProperty("_DecalTexEndFrameIND7", properties);
            _decalTexEndFrameIND8 = FindProperty("_DecalTexEndFrameIND8", properties);
            _decalTexEndFrameIND9 = FindProperty("_DecalTexEndFrameIND9", properties);
            _decalTexEndFrameIND10 = FindProperty("_DecalTexEndFrameIND10", properties);

            _decalTexWrapMode1 = FindProperty("_DecalTexWrapMode1", properties);
            _decalTexWrapMode2 = FindProperty("_DecalTexWrapMode2", properties);
            _decalTexWrapMode3 = FindProperty("_DecalTexWrapMode3", properties);
            _decalTexWrapMode4 = FindProperty("_DecalTexWrapMode4", properties);
            _decalTexWrapMode5 = FindProperty("_DecalTexWrapMode5", properties);
            _decalTexWrapMode6 = FindProperty("_DecalTexWrapMode6", properties);
            _decalTexWrapMode7 = FindProperty("_DecalTexWrapMode7", properties);
            _decalTexWrapMode8 = FindProperty("_DecalTexWrapMode8", properties);
            _decalTexWrapMode9 = FindProperty("_DecalTexWrapMode9", properties);
            _decalTexWrapMode10 = FindProperty("_DecalTexWrapMode10", properties);
            //End Decal Flipbook Settings

            //Begin Emission Flipbook Settings
            _emissionTexColumns1 = FindProperty("_EmissionTexColumns1", properties);
            _emissionTexColumns2 = FindProperty("_EmissionTexColumns2", properties);
            _emissionTexColumns3 = FindProperty("_EmissionTexColumns3", properties);
            _emissionTexColumns4 = FindProperty("_EmissionTexColumns4", properties);
            _emissionTexColumns5 = FindProperty("_EmissionTexColumns5", properties);
            _emissionTexColumns6 = FindProperty("_EmissionTexColumns6", properties);
            _emissionTexColumns7 = FindProperty("_EmissionTexColumns7", properties);
            _emissionTexColumns8 = FindProperty("_EmissionTexColumns8", properties);
            _emissionTexColumns9 = FindProperty("_EmissionTexColumns9", properties);
            _emissionTexColumns10 = FindProperty("_EmissionTexColumns10", properties);

            _emissionTexRows1 = FindProperty("_EmissionTexRows1", properties);
            _emissionTexRows2 = FindProperty("_EmissionTexRows2", properties);
            _emissionTexRows3 = FindProperty("_EmissionTexRows3", properties);
            _emissionTexRows4 = FindProperty("_EmissionTexRows4", properties);
            _emissionTexRows5 = FindProperty("_EmissionTexRows5", properties);
            _emissionTexRows6 = FindProperty("_EmissionTexRows6", properties);
            _emissionTexRows7 = FindProperty("_EmissionTexRows7", properties);
            _emissionTexRows8 = FindProperty("_EmissionTexRows8", properties);
            _emissionTexRows9 = FindProperty("_EmissionTexRows9", properties);
            _emissionTexRows10 = FindProperty("_EmissionTexRows10", properties);

            _emissionTexSpeed1 = FindProperty("_EmissionTexSpeed1", properties);
            _emissionTexSpeed2 = FindProperty("_EmissionTexSpeed2", properties);
            _emissionTexSpeed3 = FindProperty("_EmissionTexSpeed3", properties);
            _emissionTexSpeed4 = FindProperty("_EmissionTexSpeed4", properties);
            _emissionTexSpeed5 = FindProperty("_EmissionTexSpeed5", properties);
            _emissionTexSpeed6 = FindProperty("_EmissionTexSpeed6", properties);
            _emissionTexSpeed7 = FindProperty("_EmissionTexSpeed7", properties);
            _emissionTexSpeed8 = FindProperty("_EmissionTexSpeed8", properties);
            _emissionTexSpeed9 = FindProperty("_EmissionTexSpeed9", properties);
            _emissionTexSpeed10 = FindProperty("_EmissionTexSpeed10", properties);

            _emissionTexFrameIND1 = FindProperty("_EmissionTexFrameIND1", properties);
            _emissionTexFrameIND2 = FindProperty("_EmissionTexFrameIND2", properties);
            _emissionTexFrameIND3 = FindProperty("_EmissionTexFrameIND3", properties);
            _emissionTexFrameIND4 = FindProperty("_EmissionTexFrameIND4", properties);
            _emissionTexFrameIND5 = FindProperty("_EmissionTexFrameIND5", properties);
            _emissionTexFrameIND6 = FindProperty("_EmissionTexFrameIND6", properties);
            _emissionTexFrameIND7 = FindProperty("_EmissionTexFrameIND7", properties);
            _emissionTexFrameIND8 = FindProperty("_EmissionTexFrameIND8", properties);
            _emissionTexFrameIND9 = FindProperty("_EmissionTexFrameIND9", properties);
            _emissionTexFrameIND10 = FindProperty("_EmissionTexFrameIND10", properties);

            _emissionTexEndFrameIND1 = FindProperty("_EmissionTexFrameIND1", properties);
            _emissionTexEndFrameIND2 = FindProperty("_EmissionTexFrameIND2", properties);
            _emissionTexEndFrameIND3 = FindProperty("_EmissionTexFrameIND3", properties);
            _emissionTexEndFrameIND4 = FindProperty("_EmissionTexFrameIND4", properties);
            _emissionTexEndFrameIND5 = FindProperty("_EmissionTexFrameIND5", properties);
            _emissionTexEndFrameIND6 = FindProperty("_EmissionTexFrameIND6", properties);
            _emissionTexEndFrameIND7 = FindProperty("_EmissionTexFrameIND7", properties);
            _emissionTexEndFrameIND8 = FindProperty("_EmissionTexFrameIND8", properties);
            _emissionTexEndFrameIND9 = FindProperty("_EmissionTexFrameIND9", properties);
            _emissionTexEndFrameIND10 = FindProperty("_EmissionTexFrameIND10", properties);

            _emissionTexWrapMode1 = FindProperty("_EmissionTexWrapMode1", properties);
            _emissionTexWrapMode2 = FindProperty("_EmissionTexWrapMode2", properties);
            _emissionTexWrapMode3 = FindProperty("_EmissionTexWrapMode3", properties);
            _emissionTexWrapMode4 = FindProperty("_EmissionTexWrapMode4", properties);
            _emissionTexWrapMode5 = FindProperty("_EmissionTexWrapMode5", properties);
            _emissionTexWrapMode6 = FindProperty("_EmissionTexWrapMode6", properties);
            _emissionTexWrapMode7 = FindProperty("_EmissionTexWrapMode7", properties);
            _emissionTexWrapMode8 = FindProperty("_EmissionTexWrapMode8", properties);
            _emissionTexWrapMode9 = FindProperty("_EmissionTexWrapMode9", properties);
            _emissionTexWrapMode10 = FindProperty("_EmissionTexWrapMode10", properties);
            //End Emission Flipbook Settings

            _amountTex2 = FindProperty("_AmountTex2", properties);
            _amountTex3 = FindProperty("_AmountTex3", properties);
            _amountTex4 = FindProperty("_AmountTex4", properties);
            _amountTex5 = FindProperty("_AmountTex5", properties);
            _amountTex6 = FindProperty("_AmountTex6", properties);
            _amountTex7 = FindProperty("_AmountTex7", properties);
            _amountTex8 = FindProperty("_AmountTex8", properties);
            _amountTex9 = FindProperty("_AmountTex9", properties);
            _amountTex10 = FindProperty("_AmountTex10", properties);

            _amountDecal1 = FindProperty("_AmountDecal1", properties);
            _amountDecal2 = FindProperty("_AmountDecal2", properties);
            _amountDecal3 = FindProperty("_AmountDecal3", properties);
            _amountDecal4 = FindProperty("_AmountDecal4", properties);
            _amountDecal5 = FindProperty("_AmountDecal5", properties);
            _amountDecal6 = FindProperty("_AmountDecal6", properties);
            _amountDecal7 = FindProperty("_AmountDecal7", properties);
            _amountDecal8 = FindProperty("_AmountDecal8", properties);
            _amountDecal9 = FindProperty("_AmountDecal9", properties);
            _amountDecal10 = FindProperty("_AmountDecal10", properties);


            _color = FindProperty(Utils.PropColor, properties);
            _shadeColor = FindProperty(Utils.PropShadeColor, properties);
            _mainTex = FindProperty(Utils.PropMainTex, properties);
            _mainTex2 = FindProperty("_MainTex2", properties);
            _mainTex3 = FindProperty("_MainTex3", properties);
            _mainTex4 = FindProperty("_MainTex4", properties);
            _mainTex5 = FindProperty("_MainTex5", properties);
            _mainTex6 = FindProperty("_MainTex6", properties);
            _mainTex7 = FindProperty("_MainTex7", properties);
            _mainTex8 = FindProperty("_MainTex8", properties);
            _mainTex9 = FindProperty("_MainTex9", properties);
            _mainTex10 = FindProperty("_MainTex10", properties);

            _mainColor2 = FindProperty("_MainColor2", properties);
            _mainColor3 = FindProperty("_MainColor3", properties);
            _mainColor4 = FindProperty("_MainColor4", properties);
            _mainColor5 = FindProperty("_MainColor5", properties);
            _mainColor6 = FindProperty("_MainColor6", properties);
            _mainColor7 = FindProperty("_MainColor7", properties);
            _mainColor8 = FindProperty("_MainColor8", properties);
            _mainColor9 = FindProperty("_MainColor9", properties);
            _mainColor10 = FindProperty("_MainColor10", properties);

            _shadeTex2 = FindProperty("_ShadeTex2", properties);
            _shadeTex3 = FindProperty("_ShadeTex3", properties);
            _shadeTex4 = FindProperty("_ShadeTex4", properties);
            _shadeTex5 = FindProperty("_ShadeTex5", properties);
            _shadeTex6 = FindProperty("_ShadeTex6", properties);
            _shadeTex7 = FindProperty("_ShadeTex7", properties);
            _shadeTex8 = FindProperty("_ShadeTex8", properties);
            _shadeTex9 = FindProperty("_ShadeTex9", properties);
            _shadeTex10 = FindProperty("_ShadeTex10", properties);

            _shadeColor2 = FindProperty("_ShadeColor2", properties);
            _shadeColor3 = FindProperty("_ShadeColor3", properties);
            _shadeColor4 = FindProperty("_ShadeColor4", properties);
            _shadeColor5 = FindProperty("_ShadeColor5", properties);
            _shadeColor6 = FindProperty("_ShadeColor6", properties);
            _shadeColor7 = FindProperty("_ShadeColor7", properties);
            _shadeColor8 = FindProperty("_ShadeColor8", properties);
            _shadeColor9 = FindProperty("_ShadeColor9", properties);
            _shadeColor10 = FindProperty("_ShadeColor10", properties);

            _decalTex1 = FindProperty("_DecalTex1", properties);
            _decalTex2 = FindProperty("_DecalTex2", properties);
            _decalTex3 = FindProperty("_DecalTex3", properties);
            _decalTex4 = FindProperty("_DecalTex4", properties);
            _decalTex5 = FindProperty("_DecalTex5", properties);
            _decalTex6 = FindProperty("_DecalTex6", properties);
            _decalTex7 = FindProperty("_DecalTex7", properties);
            _decalTex8 = FindProperty("_DecalTex8", properties);
            _decalTex9 = FindProperty("_DecalTex9", properties);
            _decalTex10 = FindProperty("_DecalTex10", properties);

            _emissionMap1 = FindProperty("_EmissionMap1", properties);
            _emissionMap2 = FindProperty("_EmissionMap2", properties);
            _emissionMap3 = FindProperty("_EmissionMap3", properties);
            _emissionMap4 = FindProperty("_EmissionMap4", properties);
            _emissionMap5 = FindProperty("_EmissionMap5", properties);
            _emissionMap6 = FindProperty("_EmissionMap6", properties);
            _emissionMap7 = FindProperty("_EmissionMap7", properties);
            _emissionMap8 = FindProperty("_EmissionMap8", properties);
            _emissionMap9 = FindProperty("_EmissionMap9", properties);
            _emissionMap10 = FindProperty("_EmissionMap10", properties);

            _emissionColor1 = FindProperty("_EmissionColor1", properties);
            _emissionColor2 = FindProperty("_EmissionColor2", properties);
            _emissionColor3 = FindProperty("_EmissionColor3", properties);
            _emissionColor4 = FindProperty("_EmissionColor4", properties);
            _emissionColor5 = FindProperty("_EmissionColor5", properties);
            _emissionColor6 = FindProperty("_EmissionColor6", properties);
            _emissionColor7 = FindProperty("_EmissionColor7", properties);
            _emissionColor8 = FindProperty("_EmissionColor8", properties);
            _emissionColor9 = FindProperty("_EmissionColor9", properties);
            _emissionColor10 = FindProperty("_EmissionColor10", properties);

            _emissionAmount1 = FindProperty("_EmissionAmount1", properties);
            _emissionAmount2 = FindProperty("_EmissionAmount2", properties);
            _emissionAmount3 = FindProperty("_EmissionAmount3", properties);
            _emissionAmount4 = FindProperty("_EmissionAmount4", properties);
            _emissionAmount5 = FindProperty("_EmissionAmount5", properties);
            _emissionAmount6 = FindProperty("_EmissionAmount6", properties);
            _emissionAmount7 = FindProperty("_EmissionAmount7", properties);
            _emissionAmount8 = FindProperty("_EmissionAmount8", properties);
            _emissionAmount9 = FindProperty("_EmissionAmount9", properties);
            _emissionAmount10 = FindProperty("_EmissionAmount10", properties);



            _shadeTexture = FindProperty(Utils.PropShadeTexture, properties);
            _bumpScale = FindProperty(Utils.PropBumpScale, properties);
            _bumpMap = FindProperty(Utils.PropBumpMap, properties);
            _receiveShadowRate = FindProperty(Utils.PropReceiveShadowRate, properties);
            _receiveShadowTexture = FindProperty(Utils.PropReceiveShadowTexture, properties);
            _shadingGradeRate = FindProperty(Utils.PropShadingGradeRate, properties);
            _shadingGradeTexture = FindProperty(Utils.PropShadingGradeTexture, properties);
            _shadeShift = FindProperty(Utils.PropShadeShift, properties);
            _shadeToony = FindProperty(Utils.PropShadeToony, properties);
            _lightColorAttenuation = FindProperty(Utils.PropLightColorAttenuation, properties);
            _indirectLightIntensity = FindProperty(Utils.PropIndirectLightIntensity, properties);
            _rimColor = FindProperty(Utils.PropRimColor, properties);
            _rimTexture = FindProperty(Utils.PropRimTexture, properties);
            _rimLightingMix = FindProperty(Utils.PropRimLightingMix, properties);
            _rimFresnelPower = FindProperty(Utils.PropRimFresnelPower, properties);
            _rimLift = FindProperty(Utils.PropRimLift, properties);
            _sphereAdd = FindProperty(Utils.PropSphereAdd, properties);
            _emissionColor = FindProperty(Utils.PropEmissionColor, properties);
            _emissionMap = FindProperty(Utils.PropEmissionMap, properties);
            _outlineWidthTexture = FindProperty(Utils.PropOutlineWidthTexture, properties);
            _outlineWidth = FindProperty(Utils.PropOutlineWidth, properties);
            _outlineScaledMaxDistance = FindProperty(Utils.PropOutlineScaledMaxDistance, properties);
            _outlineColor = FindProperty(Utils.PropOutlineColor, properties);
            _outlineLightingMix = FindProperty(Utils.PropOutlineLightingMix, properties);
            _uvAnimMaskTexture = FindProperty(Utils.PropUvAnimMaskTexture, properties);
            _uvAnimScrollX = FindProperty(Utils.PropUvAnimScrollX, properties);
            _uvAnimScrollY = FindProperty(Utils.PropUvAnimScrollY, properties);
            _uvAnimRotation = FindProperty(Utils.PropUvAnimRotation, properties);
            var materials = materialEditor.targets.Select(x => x as Material).ToArray();
            Draw(materialEditor, materials);
        }

        private void Draw(MaterialEditor materialEditor, Material[] materials)
        {
            EditorGUI.BeginChangeCheck();
            {
                _version.floatValue = Utils.VersionNumber;

                EditorGUILayout.LabelField("WARNING", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Not supported by VRM format! Must use VSF format!", EditorStyles.boldLabel);
                    {

                    }

                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();

                EditorGUILayout.LabelField("MToon Multitexture by Virtual Assisant Kitt", EditorStyles.boldLabel);
                EditorGUILayout.LabelField("Started by Suvidriel", EditorStyles.boldLabel);
                EditorGUILayout.Space();

                EditorGUILayout.LabelField("Rendering", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Mode", EditorStyles.boldLabel);

                    materialEditor.ShaderProperty(_StencilID, "Stencil ID");

                    if (PopupEnum<RenderMode>("Rendering Type", _blendMode, materialEditor))
                    {
                        ModeChanged(materials, isBlendModeChangedByUser: true);
                    }

                    if ((RenderMode) _blendMode.floatValue == RenderMode.TransparentWithZWrite)
                    {
                        EditorGUILayout.HelpBox("TransparentWithZWrite mode can cause problems with rendering.", MessageType.Warning);
                    }

                    if (PopupEnum<CullMode>("Cull Mode", _cullMode, materialEditor))
                    {
                        ModeChanged(materials);
                    }
                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();


                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Lit Color, Alpha", EditorStyles.boldLabel);
                    {
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 1", "Lit (RGB), Alpha (A)"),
                            _mainTex, _color);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout1 = EditorGUILayout.Foldout(ColorFlipbookFoldout1, "Color & Shade Flipbook Settings 1", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout1)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns1, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows1, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed1, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND1, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND1, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode1, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 2", "Lit (RGB), Alpha (A)"),
                            _mainTex2, _mainColor2, _amountTex2);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout2 = EditorGUILayout.Foldout(ColorFlipbookFoldout2, "Color & Shade Flipbook Settings 2", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout2)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns2, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows2, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed2, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND2, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND2, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode2, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 3", "Lit (RGB), Alpha (A)"),
                            _mainTex3, _mainColor3, _amountTex3);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout3 = EditorGUILayout.Foldout(ColorFlipbookFoldout3, "Color & Shade Flipbook Settings 3", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout3)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns3, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows3, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed3, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND3, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND3, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode3, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 4", "Lit (RGB), Alpha (A)"),
                            _mainTex4, _mainColor4, _amountTex4);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout4 = EditorGUILayout.Foldout(ColorFlipbookFoldout4, "Color & Shade Flipbook Settings 4", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout4)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns4, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows4, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed4, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND4, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND4, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode4, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 5", "Lit (RGB), Alpha (A)"),
                            _mainTex5, _mainColor5, _amountTex5);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout5 = EditorGUILayout.Foldout(ColorFlipbookFoldout5, "Color & Shade Flipbook Settings 5", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout5)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns5, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows5, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed5, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND5, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND5, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode5, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 6", "Lit (RGB), Alpha (A)"),
                            _mainTex6, _mainColor6, _amountTex6);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout6 = EditorGUILayout.Foldout(ColorFlipbookFoldout6, "Color & Shade Flipbook Settings 6", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout6)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns6, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows6, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed6, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND6, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND6, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode6, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 7", "Lit (RGB), Alpha (A)"),
                            _mainTex7, _mainColor7, _amountTex7);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout7 = EditorGUILayout.Foldout(ColorFlipbookFoldout7, "Color & Shade Flipbook Settings 7", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout7)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns7, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows7, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed7, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND7, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND7, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode7, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 8", "Lit (RGB), Alpha (A)"),
                            _mainTex8, _mainColor8, _amountTex8);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout8 = EditorGUILayout.Foldout(ColorFlipbookFoldout8, "Color & Shade Flipbook Settings 8", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout8)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns8, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows8, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed8, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND8, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND8, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode8, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 9", "Lit (RGB), Alpha (A)"),
                            _mainTex9, _mainColor9, _amountTex9);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout9 = EditorGUILayout.Foldout(ColorFlipbookFoldout9, "Color & Shade Flipbook Settings 9", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout9)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns9, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows9, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed9, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND9, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND9, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode9, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 10", "Lit (RGB), Alpha (A)"),
                            _mainTex10, _mainColor10, _amountTex10);

                        EditorGUI.indentLevel++;
                        ColorFlipbookFoldout10 = EditorGUILayout.Foldout(ColorFlipbookFoldout10, "Color & Shade Flipbook Settings 10", EditorStyles.boldFont);
                        if (ColorFlipbookFoldout10)
                        {

                            materialEditor.ShaderProperty(_mainTexColumns10, "Columns");
                            materialEditor.ShaderProperty(_mainTexRows10, "Rows");
                            materialEditor.ShaderProperty(_mainTexSpeed10, "Speed");
                            materialEditor.ShaderProperty(_mainTexFrameIND10, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_mainTexEndFrameIND10, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _mainTexWrapMode10, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;


                    }

                    var bm = (RenderMode)_blendMode.floatValue;
                    if (bm == RenderMode.Cutout)
                    {
                        EditorGUILayout.Space();
                        EditorGUILayout.LabelField("Alpha", EditorStyles.boldLabel);
                        {
                            materialEditor.ShaderProperty(_cutoff, "Cutoff");
                        }
                    }
                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();


                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Shade", EditorStyles.boldLabel);
                    {
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 1", "Shade (RGB)"), _shadeTexture,
                            _shadeColor);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 2", "Shade (RGB)"),
                            _shadeTex2, _shadeColor2);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 3", "Shade (RGB)"),
                            _shadeTex3, _shadeColor3);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 4", "Shade (RGB)"),
                            _shadeTex4, _shadeColor4);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 5", "Shade (RGB)"),
                            _shadeTex5, _shadeColor5);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 6", "Shade (RGB)"),
                            _shadeTex6, _shadeColor6);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 7", "Shade (RGB)"),
                            _shadeTex7, _shadeColor7);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 8", "Shade (RGB)"),
                            _shadeTex8, _shadeColor8);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 9", "Shade (RGB)"),
                            _shadeTex9, _shadeColor9);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Shade Texture 10", "Shade (RGB)"),
                            _shadeTex10, _shadeColor10);

                    }
                }

                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();

                
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Decal", EditorStyles.boldLabel);
                    {
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 1", "Lit (RGB), Alpha (A)"),
                            _decalTex1, _amountDecal1);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout1 = EditorGUILayout.Foldout(DecalFlipBookFoldout1, "Decal Flipbook Settings 1", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout1)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns1, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows1, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed1, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND1, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND1, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode1, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 2", "Lit (RGB), Alpha (A)"),
                            _decalTex2, _amountDecal2);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout2 = EditorGUILayout.Foldout(DecalFlipBookFoldout2, "Decal Flipbook Settings 2", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout2)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns2, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows2, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed2, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND2, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND2, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode2, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 3", "Lit (RGB), Alpha (A)"),
                            _decalTex3, _amountDecal3);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout3 = EditorGUILayout.Foldout(DecalFlipBookFoldout3, "Decal Flipbook Settings 3", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout3)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns3, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows3, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed3, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND3, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND3, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode3, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 4", "Lit (RGB), Alpha (A)"),
                            _decalTex4, _amountDecal4);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout4 = EditorGUILayout.Foldout(DecalFlipBookFoldout4, "Decal Flipbook Settings 4", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout4)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns4, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows4, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed4, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND4, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND4, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode4, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 5", "Lit (RGB), Alpha (A)"),
                            _decalTex5, _amountDecal5);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout5 = EditorGUILayout.Foldout(DecalFlipBookFoldout5, "Decal Flipbook Settings 5", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout5)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns5, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows5, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed5, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND5, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND5, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode5, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 6", "Lit (RGB), Alpha (A)"),
                            _decalTex6, _amountDecal6);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout6 = EditorGUILayout.Foldout(DecalFlipBookFoldout6, "Decal Flipbook Settings 6", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout6)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns6, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows6, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed6, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND6, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND6, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode6, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 7", "Lit (RGB), Alpha (A)"),
                            _decalTex7, _amountDecal7);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout7 = EditorGUILayout.Foldout(DecalFlipBookFoldout7, "Decal Flipbook Settings 7", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout7)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns7, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows7, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed7, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND7, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND7, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode7, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 8", "Lit (RGB), Alpha (A)"),
                            _decalTex8, _amountDecal8);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout8 = EditorGUILayout.Foldout(DecalFlipBookFoldout8, "Decal Flipbook Settings 8", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout8)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns8, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows8, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed8, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND8, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND8, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode8, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 9", "Lit (RGB), Alpha (A)"),
                            _decalTex9, _amountDecal9);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout9 = EditorGUILayout.Foldout(DecalFlipBookFoldout9, "Decal Flipbook Settings 9", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout9)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns9, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows9, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed9, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND9, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND9, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode9, materialEditor);
                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 10", "Lit (RGB), Alpha (A)"),
                            _decalTex10, _amountDecal10);

                        EditorGUI.indentLevel++;
                        DecalFlipBookFoldout10 = EditorGUILayout.Foldout(DecalFlipBookFoldout10, "Decal Flipbook Settings 10", EditorStyles.boldFont);
                        if (DecalFlipBookFoldout10)
                        {

                            materialEditor.ShaderProperty(_decalTexColumns10, "Columns");
                            materialEditor.ShaderProperty(_decalTexRows10, "Rows");
                            materialEditor.ShaderProperty(_decalTexSpeed10, "Speed");
                            materialEditor.ShaderProperty(_decalTexFrameIND10, "Start/Selected Frame");
                            materialEditor.ShaderProperty(_decalTexEndFrameIND10, "End Frame");

                            PopupEnum<EditorWrapMode>("Texture Wrap Mode", _decalTexWrapMode10, materialEditor);

                            EditorGUILayout.Space();

                        }
                        EditorGUI.indentLevel--;

                    }
                }

                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();


                EditorGUILayout.LabelField("Lighting", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    {
                        materialEditor.ShaderProperty(_shadeToony,
                            new GUIContent("Shading Toony",
                                "0.0 is Lambert. Higher value get toony shading."));

                        // Normal
                        EditorGUI.BeginChangeCheck();
                        materialEditor.TexturePropertySingleLine(new GUIContent("Normal Map [Normal]", "Normal Map (RGB)"),
                            _bumpMap,
                            _bumpScale);
                        if (EditorGUI.EndChangeCheck())
                        {
                            materialEditor.RegisterPropertyChangeUndo("BumpEnabledDisabled");
                            ModeChanged(materials);
                        }
                    }
                    EditorGUILayout.Space();

                    EditorGUI.indentLevel++;
                    {
                        isAdvancedLightingPanelFoldout = EditorGUILayout.Foldout(isAdvancedLightingPanelFoldout, "Advanced Settings", EditorStyles.boldFont);

                        if (isAdvancedLightingPanelFoldout)
                        {
                            EditorGUILayout.BeginHorizontal();
                            EditorGUILayout.HelpBox(
                                "The default settings are suitable for Advanced Settings if you want to toony result.",
                                MessageType.Info);
                            if (GUILayout.Button("Use Default"))
                            {
                                _shadeShift.floatValue = 0;
                                _receiveShadowTexture.textureValue = null;
                                _receiveShadowRate.floatValue = 1;
                                _shadingGradeTexture.textureValue = null;
                                _shadingGradeRate.floatValue = 1;
                                _lightColorAttenuation.floatValue = 0;
                                _indirectLightIntensity.floatValue = 0.1f;
                            }
                            EditorGUILayout.EndHorizontal();
                            
                            materialEditor.ShaderProperty(_shadeShift,
                                new GUIContent("Shading Shift",
                                    "Zero is Default. Negative value increase lit area. Positive value increase shade area."));
                            materialEditor.TexturePropertySingleLine(
                                new GUIContent("Shadow Receive Multiplier",
                                    "Texture (R) * Rate. White is Default. Black attenuates shadows."),
                                _receiveShadowTexture,
                                _receiveShadowRate);
                            materialEditor.TexturePropertySingleLine(
                                new GUIContent("Lit & Shade Mixing Multiplier",
                                    "Texture (R) * Rate. Compatible with UTS2 ShadingGradeMap. White is Default. Black amplifies shade."),
                                _shadingGradeTexture,
                                _shadingGradeRate);
                            materialEditor.ShaderProperty(_lightColorAttenuation, "LightColor Attenuation");
                            materialEditor.ShaderProperty(_indirectLightIntensity, "GI Intensity");
                        }
                    }
                    EditorGUI.indentLevel--;
                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();
                
                EditorGUILayout.LabelField("Emission", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    /*TextureWithHdrColor(materialEditor, "Emission1", "Emission (RGB)",
                        _emissionMap, _emissionColor);*/

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 1", "Lit (RGB), Alpha (A)"),
                            _emissionMap1, _emissionColor1, _emissionAmount1);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout1 = EditorGUILayout.Foldout(EmissionFlipBookFoldout1, "Emission Flipbook Settings 2", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout1)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns1, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows1, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed1, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND1, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND1, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode1, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 2", "Lit (RGB), Alpha (A)"),
                            _emissionMap2, _emissionColor2, _emissionAmount2);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout2 = EditorGUILayout.Foldout(EmissionFlipBookFoldout2, "Emission Flipbook Settings 2", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout2)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns2, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows2, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed2, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND2, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND2, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode2, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 3", "Lit (RGB), Alpha (A)"),
                            _emissionMap3, _emissionColor3, _emissionAmount3);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout3 = EditorGUILayout.Foldout(EmissionFlipBookFoldout3, "Emission Flipbook Settings 3", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout3)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns3, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows3, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed3, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND3, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND3, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode3, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 4", "Lit (RGB), Alpha (A)"),
                            _emissionMap4, _emissionColor4, _emissionAmount4);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout4 = EditorGUILayout.Foldout(EmissionFlipBookFoldout4, "Emission Flipbook Settings 4", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout4)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns4, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows4, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed4, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND4, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND4, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode4, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 5", "Lit (RGB), Alpha (A)"),
                            _emissionMap5, _emissionColor5, _emissionAmount5);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout5 = EditorGUILayout.Foldout(EmissionFlipBookFoldout5, "Emission Flipbook Settings 5", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout5)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns5, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows5, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed5, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND5, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND5, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode5, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 6", "Lit (RGB), Alpha (A)"),
                            _emissionMap6, _emissionColor6, _emissionAmount6);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout6 = EditorGUILayout.Foldout(EmissionFlipBookFoldout6, "Emission Flipbook Settings 6", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout6)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns6, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows6, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed6, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND6, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND6, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode6, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 7", "Lit (RGB), Alpha (A)"),
                            _emissionMap7, _emissionColor7, _emissionAmount7);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout7 = EditorGUILayout.Foldout(EmissionFlipBookFoldout7, "Emission Flipbook Settings 7", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout7)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns7, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows7, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed7, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND7, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND7, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode7, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 8", "Lit (RGB), Alpha (A)"),
                            _emissionMap8, _emissionColor8, _emissionAmount8);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout8 = EditorGUILayout.Foldout(EmissionFlipBookFoldout8, "Emission Flipbook Settings 8", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout8)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns8, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows8, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed8, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND8, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND8, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode8, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 9", "Lit (RGB), Alpha (A)"),
                            _emissionMap9, _emissionColor9, _emissionAmount9);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout9 = EditorGUILayout.Foldout(EmissionFlipBookFoldout9, "Emission Flipbook Settings 9", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout9)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns9, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows9, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed9, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND9, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND9, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode9, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;

                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 10", "Lit (RGB), Alpha (A)"),
                            _emissionMap10, _emissionColor10, _emissionAmount10);

                    EditorGUI.indentLevel++;
                    EmissionFlipBookFoldout10 = EditorGUILayout.Foldout(EmissionFlipBookFoldout10, "Emission Flipbook Settings 10", EditorStyles.boldFont);
                    if (EmissionFlipBookFoldout10)
                    {

                        materialEditor.ShaderProperty(_emissionTexColumns10, "Columns");
                        materialEditor.ShaderProperty(_emissionTexRows10, "Rows");
                        materialEditor.ShaderProperty(_emissionTexSpeed10, "Speed");
                        materialEditor.ShaderProperty(_emissionTexFrameIND10, "Start/Selected Frame");
                        materialEditor.ShaderProperty(_emissionTexEndFrameIND10, "End Frame");

                        PopupEnum<EditorWrapMode>("Texture Wrap Mode", _emissionTexWrapMode10, materialEditor);

                        EditorGUILayout.Space();

                    }
                    EditorGUI.indentLevel--;


                    materialEditor.TexturePropertySingleLine(new GUIContent("MatCap", "MatCap Texture (RGB)"),
                        _sphereAdd);
                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();
                    
                EditorGUILayout.LabelField("Rim", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    TextureWithHdrColor(materialEditor, "Color", "Rim Color (RGB)",
                        _rimTexture, _rimColor);
                    
                    materialEditor.DefaultShaderProperty(_rimLightingMix, "Lighting Mix");

                    materialEditor.ShaderProperty(_rimFresnelPower,
                        new GUIContent("Fresnel Power",
                            "If you increase this value, you get sharpness rim light."));

                    materialEditor.ShaderProperty(_rimLift,
                        new GUIContent("Lift",
                            "If you increase this value, you can lift rim light."));
                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();


                EditorGUILayout.LabelField("Outline", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    // Outline
                    EditorGUILayout.LabelField("Width", EditorStyles.boldLabel);
                    {
                        if (PopupEnum<OutlineWidthMode>("Mode", _outlineWidthMode, materialEditor))
                        {
                            ModeChanged(materials);
                        }
                        
                        if ((RenderMode) _blendMode.floatValue == RenderMode.Transparent &&
                            (OutlineWidthMode) _outlineWidthMode.floatValue != OutlineWidthMode.None)
                        {
                            EditorGUILayout.HelpBox("Outline with Transparent material cause problem with rendering.", MessageType.Warning);
                        }

                        var widthMode = (OutlineWidthMode) _outlineWidthMode.floatValue;
                        if (widthMode != OutlineWidthMode.None)
                        {
                            materialEditor.TexturePropertySingleLine(
                                new GUIContent("Width", "Outline Width Texture (RGB)"),
                                _outlineWidthTexture, _outlineWidth);
                        }

                        if (widthMode == OutlineWidthMode.ScreenCoordinates)
                        {
                            materialEditor.ShaderProperty(_outlineScaledMaxDistance, "Width Scaled Max Distance");
                        }
                    }
                    EditorGUILayout.Space();

                    EditorGUILayout.LabelField("Color", EditorStyles.boldLabel);
                    {
                        var widthMode = (OutlineWidthMode) _outlineWidthMode.floatValue;
                        if (widthMode != OutlineWidthMode.None)
                        {
                            EditorGUI.BeginChangeCheck();

                            if (PopupEnum<OutlineColorMode>("Mode", _outlineColorMode, materialEditor))
                            {
                                ModeChanged(materials);
                            }

                            var colorMode = (OutlineColorMode) _outlineColorMode.floatValue;

                            materialEditor.ShaderProperty(_outlineColor, "Color");
                            if (colorMode == OutlineColorMode.MixedLighting)
                                materialEditor.DefaultShaderProperty(_outlineLightingMix, "Lighting Mix");
                        }
                    }
                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();

                
                EditorGUILayout.LabelField("UV Coordinates", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    // UV
                    EditorGUILayout.LabelField("Scale & Offset", EditorStyles.boldLabel);
                    {
                        materialEditor.TextureScaleOffsetProperty(_mainTex);
                    }
                    EditorGUILayout.Space();

                    EditorGUILayout.LabelField("Auto Animation", EditorStyles.boldLabel);
                    {
                        materialEditor.TexturePropertySingleLine(new GUIContent("Mask", "Auto Animation Mask Texture (R)"), _uvAnimMaskTexture);
                        materialEditor.ShaderProperty(_uvAnimScrollX, "Scroll X (per second)");
                        materialEditor.ShaderProperty(_uvAnimScrollY, "Scroll Y (per second)");

                        {
                            var control = EditorGUILayout.GetControlRect(hasLabel: true);
                            const int popupMargin = 5;
                            const int popupWidth = 80;

                            var floatControl = new Rect(control);
                            floatControl.width -= popupMargin + popupWidth;
                            var popupControl = new Rect(control);
                            popupControl.x = floatControl.x + floatControl.width + popupMargin;
                            popupControl.width = popupWidth;
                            
                            EditorGUI.BeginChangeCheck();
                            var inspectorRotationValue = GetInspectorRotationValue(editorRotationUnit, _uvAnimRotation.floatValue);
                            inspectorRotationValue = EditorGUI.FloatField(floatControl, "Rotation value (per second)", inspectorRotationValue);
                            if (EditorGUI.EndChangeCheck())
                            {
                                materialEditor.RegisterPropertyChangeUndo("UvAnimRotationValueChanged");
                                _uvAnimRotation.floatValue = GetRawRotationValue(editorRotationUnit, inspectorRotationValue);
                            }
                            editorRotationUnit = (EditorRotationUnit) EditorGUI.EnumPopup(popupControl, editorRotationUnit);
                        }
                    }
                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();
                
                
                EditorGUILayout.LabelField("Options", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Debugging Options", EditorStyles.boldLabel);
                    {
                        if (PopupEnum<DebugMode>("Visualize", _debugMode, materialEditor))
                        {
                            ModeChanged(materials);
                        }
                    }
                    EditorGUILayout.Space();

                    EditorGUILayout.LabelField("Advanced Options", EditorStyles.boldLabel);
                    {
#if UNITY_5_6_OR_NEWER
//                    materialEditor.EnableInstancingField();
                        materialEditor.DoubleSidedGIField();
#endif
                        EditorGUI.BeginChangeCheck();
                        materialEditor.RenderQueueField();
                        if (EditorGUI.EndChangeCheck())
                        {
                            ModeChanged(materials);
                        }
                    }
                }
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();
            }
            EditorGUI.EndChangeCheck();
        }

        public override void AssignNewShaderToMaterial(Material material, Shader oldShader, Shader newShader)
        {
            base.AssignNewShaderToMaterial(material, oldShader, newShader);

            Utils.ValidateProperties(material, isBlendModeChangedByUser: true);
        }

        private static void ModeChanged(Material[] materials, bool isBlendModeChangedByUser = false)
        {
            foreach (var material in materials)
            {
                Utils.ValidateProperties(material, isBlendModeChangedByUser);
            }
        }

        private static bool PopupEnum<T>(string name, MaterialProperty property, MaterialEditor editor) where T : struct
        {
            EditorGUI.showMixedValue = property.hasMixedValue;
            EditorGUI.BeginChangeCheck();
            var ret = EditorGUILayout.Popup(name, (int) property.floatValue, Enum.GetNames(typeof(T)));
            var changed = EditorGUI.EndChangeCheck();
            if (changed)
            {
                editor.RegisterPropertyChangeUndo("EnumPopUp");
                property.floatValue = ret;
            }

            EditorGUI.showMixedValue = false;
            return changed;
        }

        private static void TextureWithHdrColor(MaterialEditor materialEditor, string label, string description,
            MaterialProperty texProp, MaterialProperty colorProp)
        {
            materialEditor.TexturePropertyWithHDRColor(new GUIContent(label, description),
                texProp,
                colorProp,
#if UNITY_2018_1_OR_NEWER
#else
                new ColorPickerHDRConfig(minBrightness: 0, maxBrightness: 10, minExposureValue: -10,
                    maxExposureValue: 10),
#endif
                showAlpha: false);
            
        }

        private static float GetRawRotationValue(EditorRotationUnit unit, float inspectorValue)
        {
            switch (unit)
            {
                case EditorRotationUnit.Rounds:
                    return inspectorValue;
                case EditorRotationUnit.Degrees:
                    return inspectorValue / RoundsToDegree;
                case EditorRotationUnit.Radians:
                    return inspectorValue / RoundsToRadian;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static float GetInspectorRotationValue(EditorRotationUnit unit, float rawValue)
        {
            switch (unit)
            {
                case EditorRotationUnit.Rounds:
                    return rawValue;
                case EditorRotationUnit.Degrees:
                    return rawValue * RoundsToDegree;
                case EditorRotationUnit.Radians:
                    return rawValue * RoundsToRadian;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}