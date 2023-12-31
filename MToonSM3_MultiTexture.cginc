#include "./MToonCore_MultiTexture.cginc"

v2f vert_forward_base(appdata_full v)
{
    v.normal = normalize(v.normal);
    return InitializeV2F(v, UnityObjectToClipPos(v.vertex), 0);
}

v2f vert_forward_base_outline(appdata_full v)
{
    v.normal = normalize(v.normal);
    return InitializeV2F(v, CalculateOutlineVertexClipPosition(v), 1);
}

v2f vert_forward_add(appdata_full v)
{
    v.normal = normalize(v.normal);
    return InitializeV2F(v, UnityObjectToClipPos(v.vertex), 0);
}
