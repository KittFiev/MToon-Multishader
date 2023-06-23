# MToon-Multishader
An add-on for the VRM MToon shader. Offers multiple texture and color channels for advanced material animation on 3d VSF format vtube models

[MToon_Multishader.zip](https://github.com/KittFiev/MToon-Multishader/files/11852889/MToon_Multishader.zip)

# DEPENDENCIES
[Unity 2019.4.35](https://unity.com/releases/editor/archive)
[UniVRM-0.61.0_68fb Unity Package](https://github.com/vrm-c/UniVRM/releases/tag/v0.61.0)
[VSeeFace SDK Unity Package](https://github.com/emilianavt/VSeeFaceSDK/releases)

# Version 1.0.0 release

Adds support for:
•10 Main texture channels with Alpha and Color
     -Main texture channels are default white
     -Color channels are multiplied by the Main texture channel
     -Texture 1 is always on. Each subsequent channel overwrites the channel prior

•10 Shade textures with Alpha
     -Shade texture channels are default white
     -Shade color channels are multiplied by Shade texture channel
     -Shade channels are tied to the same sliders as the Main textures, pairing the Shade tex with Main tex

•10 Decal textures with Alpha
     -Shares UV map with Main textures
     -Color is provided by the texture itself
     -Decals are fully blended together, with the higher level decals taking depth priority in case of overlapping pixels
     -Not affected by shading

•10 Emission textures with color
     -Emission texture channels are default white
     -Color channels are multiplied by the Emission texture channel
     -Emission 1 is always on. Each subsequent channel overwrites the channel prior
     -All color channels are HDR enabled
