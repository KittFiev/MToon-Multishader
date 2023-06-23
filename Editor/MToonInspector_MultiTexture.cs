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
//        private MaterialProperty _outlineCullMode;
        private MaterialProperty _cutoff;

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

                EditorGUILayout.LabelField("Rendering", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Mode", EditorStyles.boldLabel);
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



                EditorGUILayout.LabelField("Additional Materials added by Suvi", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Lit Color, Alpha", EditorStyles.boldLabel);
                    {
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 1", "Lit (RGB), Alpha (A)"),
                            _mainTex, _color);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 2", "Lit (RGB), Alpha (A)"),
                            _mainTex2, _mainColor2, _amountTex2);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 3", "Lit (RGB), Alpha (A)"),
                            _mainTex3, _mainColor3, _amountTex3);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 4", "Lit (RGB), Alpha (A)"),
                            _mainTex4, _mainColor4, _amountTex4);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 5", "Lit (RGB), Alpha (A)"),
                            _mainTex5, _mainColor5, _amountTex5);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 6", "Lit (RGB), Alpha (A)"),
                            _mainTex6, _mainColor6, _amountTex6);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 7", "Lit (RGB), Alpha (A)"),
                            _mainTex7, _mainColor7, _amountTex7);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 8", "Lit (RGB), Alpha (A)"),
                            _mainTex8, _mainColor8, _amountTex8);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 9", "Lit (RGB), Alpha (A)"),
                            _mainTex9, _mainColor9, _amountTex9);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Texture 10", "Lit (RGB), Alpha (A)"),
                            _mainTex10, _mainColor10, _amountTex10);

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


                EditorGUILayout.LabelField("Additional Shade Tex added by Virtual Assistant Kitt", EditorStyles.boldLabel);
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

                EditorGUILayout.LabelField("Decal Tex added by Virtual Assistant Kitt", EditorStyles.boldLabel);
                EditorGUILayout.BeginVertical(GUI.skin.box);
                {
                    EditorGUILayout.LabelField("Decal", EditorStyles.boldLabel);
                    {
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 1", "Lit (RGB), Alpha (A)"),
                            _decalTex1, _amountDecal1);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 2", "Lit (RGB), Alpha (A)"),
                            _decalTex2, _amountDecal2);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 3", "Lit (RGB), Alpha (A)"),
                            _decalTex3, _amountDecal3);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 4", "Lit (RGB), Alpha (A)"),
                            _decalTex4, _amountDecal4);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 5", "Lit (RGB), Alpha (A)"),
                            _decalTex5, _amountDecal5);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 6", "Lit (RGB), Alpha (A)"),
                            _decalTex6, _amountDecal6);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 7", "Lit (RGB), Alpha (A)"),
                            _decalTex7, _amountDecal7);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 8", "Lit (RGB), Alpha (A)"),
                            _decalTex8, _amountDecal8);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 9", "Lit (RGB), Alpha (A)"),
                            _decalTex9, _amountDecal9);
                        materialEditor.TexturePropertySingleLine(new GUIContent("Decal Texture 10", "Lit (RGB), Alpha (A)"),
                            _decalTex10, _amountDecal10);

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
                            _emissionMap1, _emissionColor1);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 2", "Lit (RGB), Alpha (A)"),
                            _emissionMap2, _emissionColor2, _emissionAmount2);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 3", "Lit (RGB), Alpha (A)"),
                            _emissionMap3, _emissionColor3, _emissionAmount3);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 4", "Lit (RGB), Alpha (A)"),
                            _emissionMap4, _emissionColor4, _emissionAmount4);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 5", "Lit (RGB), Alpha (A)"),
                            _emissionMap5, _emissionColor5, _emissionAmount5);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 6", "Lit (RGB), Alpha (A)"),
                            _emissionMap6, _emissionColor6, _emissionAmount6);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 7", "Lit (RGB), Alpha (A)"),
                            _emissionMap7, _emissionColor7, _emissionAmount7);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 8", "Lit (RGB), Alpha (A)"),
                            _emissionMap8, _emissionColor8, _emissionAmount8);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 9", "Lit (RGB), Alpha (A)"),
                            _emissionMap9, _emissionColor9, _emissionAmount9);
                    materialEditor.TexturePropertySingleLine(new GUIContent("Emission Map 10", "Lit (RGB), Alpha (A)"),
                            _emissionMap10, _emissionColor10, _emissionAmount10);

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