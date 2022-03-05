using UnityEngine;

public class RendererQuad : MonoBehaviour
{
    // Start is called before the first frame update
    public MeshFilter MeshFilter;
    public MeshRenderer MeshRenderer;


    public void SetData(SpriteCollection.TextureData textureData, int layer)
    {
        MeshRenderer.material = Sprites.GetTextureMaterial(textureData.texture, textureData.parent.renderingLayer,
            textureData.parent.renderingOrder);
    }
}