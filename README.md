# MToon-Multishader
An add-on for the VRM MToon shader. Offers multiple texture and color channels for advanced material animation on 3d VSF format vtube models <br>
This is a modified version of Suvidriel's MToon Multitexture. Reduced the number of texture samplers due to GPU limitations and added additional channels for Shade and Emission. Additionally, new Decal textures section for things like tattoos/stickers/markings. <br>
 <br>
[MToon_Multishader.zip](https://github.com/KittFiev/MToon-Multishader/files/11852889/MToon_Multishader.zip) <br>
 <br>
# DEPENDENCIES
[Unity 2019.4.35](https://unity.com/releases/editor/archive) <br>
[UniVRM-0.61.0_68fb Unity Package](https://github.com/vrm-c/UniVRM/releases/tag/v0.61.0) <br>
[VSeeFace SDK Unity Package (optional. Only needed if you are using this on an exportable vtube model)](https://github.com/emilianavt/VSeeFaceSDK/releases) <br>
 <br>
# Version 1.0.0 release

Adds support for: <br>
•10 Main texture channels with Alpha and Color <br>
	-Main texture channels are default white <br>
     -Color channels are multiplied by the Main texture channel <br>
     -Texture 1 is always on. Each subsequent channel overwrites the channel prior <br>
 <br>
•10 Shade textures with Alpha <br>
     -Shade texture channels are default white <br>
     -Shade color channels are multiplied by Shade texture channel <br>
     -Shade channels are tied to the same sliders as the Main textures, pairing the Shade tex with Main tex <br>
 <br>
•10 Decal textures with Alpha <br>
     -Shares UV map with Main textures <br>
     -Color is provided by the texture itself <br>
     -Decals are fully blended together, with the higher level decals taking depth priority in case of overlapping pixels <br>
     -Not affected by shading <br>
 <br>
•10 Emission textures with color <br>
     -Emission texture channels are default white <br>
     -Color channels are multiplied by the Emission texture channel <br>
     -Emission 1 is always on. Each subsequent channel overwrites the channel prior <br>
     -All color channels are HDR enabled <br>
