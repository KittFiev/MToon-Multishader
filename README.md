# MToon-Multishader
An add-on for the VRM MToon shader. Offers multiple texture and color channels for advanced material animation on 3d VSF format vtube models <br>
This is a modified version of Suvidriel's MToon Multitexture. Reduced the number of texture samplers due to GPU limitations and added additional channels for Shade and Emission. Additionally, new Decal textures section for things like tattoos/stickers/markings. <br>
 <br>
# DEPENDENCIES
<b>(these are minimum requirements. Should be compatible with later versions of unity and UniVRM)</b> <br>
[Unity 2019.4.35](https://unity.com/releases/editor/archive) <br>
[UniVRM-0.61.1_7c03 Unity Package](https://github.com/vrm-c/UniVRM/releases/tag/v0.61.1) <br>
[VSeeFace SDK Unity Package](https://github.com/emilianavt/VSeeFaceSDK/releases) (Only needed if you are exporting as a vtube model. If it's only for unity, you can ignore) <br>
 <br>
 <b>!Important Note! Install this AFTER UniVRM. If errors pop up, place the .shader and both .cginc files in the root folder into "VRMShaders/MToon/Mtoon/Resources/Shaders", then place the .cs file in the Editor folder into "VRMShaders/MToon/MToon/Editor"! New releases will be in unity package files, so download from the release pages instead of from the main branch here.</b> <br>
# Current Features

Adds support for: <br>
* 10 Main texture channels with Alpha and Color <br>
	- Main texture channels are default white <br>
	- Color channels are multiplied by the Main texture channel <br>
	- Texture 1 is always on. Each subsequent channel overwrites the channel prior <br><br>
 
* 10 Shade textures with Alpha <br>
	- Shade texture channels are default white <br>
	- Shade color channels are multiplied by Shade texture channel <br>
	- Shade channels are tied to the same sliders as the Main textures, pairing the Shade tex with Main tex <br><br>
 
* 10 Decal textures with Alpha <br>
	- Shares UV map with Main textures <br>
	- Color is provided by the texture itself <br>
	- Decals are fully blended together, with the higher level decals taking depth priority in case of overlapping pixels <br>
	- Not affected by shading <br><br>
 
* 10 Emission textures with color <br>
	- Emission texture channels are default white <br>
	- Color channels are multiplied by the Emission texture channel <br>
	- Each subsequent channel overwrites the channel prior <br>
	- All color channels are HDR enabled <br><br>
 
* Stencil ID<br><br>

* UV Set selector for each texture slot. This will allow models that have different UV Sets baked in during modelling; i.e. a model can have a UV Set for standard Albedo texture map, and an optimized UV Set for details. Due to unity limitations, only 4 UV Sets can be baked into a model and accessed by this shader.
  	- Though under-utilized, models can be made with multiple uv sets with <b>different</b> layouts, meaning something like detail and emission maps, can be hyper optimized and increase quality as compared to the more common method of using the albedo uv map for everything, which may not make the best use of space. Defaulted to UV1 (it's actually uv0, this is just for readability) which is the standard uv map location. If a mesh doesn't have multiple uv sets, this setting will not change anything as non-existant uv sets are just duplicates of the first uv set<br><br>

* Flipbook Textures on Color/Shade, Decal, and Emission Channels<br>
	- Shade Texture Channels are animated as well and synced to Color Texture Channels<br>
 	- The <b>End Frame</b> float determines the final frame of the animation. This is counted from top left to bottom right. Animation will restart from beginning after this frame<br>
  	- Can be used with <b>Amount Behavior</b> mode set to <b>Binary</b> for 2d lip syncing by setting the same mouth texture atlas in different slots, using the <b>Start/Selected Frame</b> index to select which mouth shape that slot will hold and activating them with the texture slots <b>amount slider</b>. <b>Binary</b> mode returns 1 if the amount slider is greater than 0, while <b>Float</b> allows the slider to act normal
	- <b>!IMPORTANT NOTE!</b> If you are modifying the tile & offset of the materials UV, make sure that <b>Generate Mipmaps"</b> on the texture is turned <b>OFF</b> to avoid lines around the UV!<br>
 	- <b>!IMPORTANT NOTE!</b> Make sure the textures wrap mode is set to <b>Repeat</b>! Otherwise the animation may not play correctly! Instead, you need to use the Texture Wrap Mode found in the Flipbook Settings of each texture slot<br>
