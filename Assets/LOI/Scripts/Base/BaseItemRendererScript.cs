using System.Collections.Generic;
using UnityEngine;

public class BaseItemRendererScript : MonoBehaviour
{
    /* object refs */
    public BaseItemScript BaseItem;
    public GameObject RenderQuadsContainer;

    private RendererQuad _groundPatch;
    private Common.Direction _oldDirection = Common.Direction.BOTTOM;
    private Common.State _oldState = Common.State.IDLE;

    /* private vars */
    private List<RendererQuad> _renderQuads;

    public void Init()
    {
        Clear();
        this.UpdateRenderQuads();
    }



    public void Refresh()
    {
        if (BaseItem.direction != _oldDirection || BaseItem.state != _oldState)
        {
            Clear();
            this.UpdateRenderQuads();

            _oldDirection = BaseItem.direction;
            _oldState = BaseItem.state;
        }
    }

    public void Clear()
    {
        if (_renderQuads != null)
            foreach (var renderQuad in _renderQuads)
                Destroy(renderQuad.gameObject);

        _renderQuads = new List<RendererQuad>();
    }

    public void UpdateRenderQuads()
    {
        var textureDataList = _GetCurrentImageLayers();
        if (textureDataList != null)
            for (var index = 0; index < textureDataList.Length; index++)
                AddRenderQuad(textureDataList[index], index);

        //flip renderer for topleft, bottomleft, left
        if (BaseItem.itemData.configuration.isCharacter)
        {
            if (BaseItem.direction == Common.Direction.BOTTOM_LEFT || BaseItem.direction == Common.Direction.LEFT ||
                BaseItem.direction == Common.Direction.TOP_LEFT)
                _FlipRenderers(true);
            else
                _FlipRenderers(false);
        }
    }

    private void _FlipRenderers(bool isTrue)
    {
        if (isTrue)
            RenderQuadsContainer.transform.localScale = new Vector3(-1, 1, 1);
        else
            RenderQuadsContainer.transform.localScale = new Vector3(1, 1, 1);
    }

    public void AddRenderQuad(SpriteCollection.TextureData textureData, int layer)

    {

        if (textureData == null) return;
        Debug.Log(textureData.texture);
        if (textureData.texture == null) return;

        RendererQuad renderQuadInstance = Utilities.CreateRenderQuad();
        renderQuadInstance.transform.SetParent(this.RenderQuadsContainer.transform);

        Vector3 defaultImgSize = new Vector3();
        if (textureData.parent.id == 140)
        {
            defaultImgSize = new Vector3(2.8142f, 0.6142f, 2.8142f) * 4 * textureData.scale / 100.0f / textureData.parent.gridSize;
        }
        else
        {
            defaultImgSize = new Vector3(1.4142f, 1.4142f, 1.4142f) * 4 * textureData.scale / 100.0f / textureData.parent.gridSize;
        }

        float heightFactor = ((float)textureData.texture.height / (float)textureData.texture.width) * ((float)textureData.numberOfColumns / textureData.numberOfRows);

        float offsetX = (1.414f / 256.0f) * textureData.offsetX * 4 / textureData.parent.gridSize;
        float offsetY = (1.414f / 256.0f) * textureData.offsetY * 4 / textureData.parent.gridSize;
        renderQuadInstance.transform.localPosition = new Vector3(offsetX, offsetY, 0);
        renderQuadInstance.transform.localRotation = Quaternion.Euler(Vector3.zero);
        renderQuadInstance.transform.localScale = new Vector3(defaultImgSize.x, defaultImgSize.x * heightFactor, 1);

        renderQuadInstance.SetData(textureData, layer);
        renderQuadInstance.GetComponent<TextureSheetAnimationScript>()
            .SetTextureSheetData(textureData.numberOfColumns, textureData.numberOfRows, textureData.framesCount, textureData.fps);

        this._renderQuads.Add(renderQuadInstance);

        if (layer == 0)
        {
            //ground patch layer
            this._groundPatch = renderQuadInstance;
        }
        Debug.Log("created Renderer");
    }

    public void ShowGroundPatch(bool isTrue)
    {
        if (_groundPatch == null) return;

        _groundPatch.gameObject.SetActive(isTrue);
    }

    private SpriteCollection.TextureData[] _GetCurrentImageLayers()
    {
        var layers = new List<SpriteCollection.TextureData>();

        var state = BaseItem.state;
        var direction = BaseItem.direction;

        var spriteIds = BaseItem.itemData.GetSprites(state);

        if (spriteIds == null || spriteIds.Count == 0) return null;

        for (var index = 0; index < spriteIds.Count; index++)
        {
            var sprite = Sprites.GetSprite(spriteIds[index]);
            layers.Add(sprite.GetTextureData(direction));
        }

        return layers.ToArray();
    }

    public List<RendererQuad> GetRenderQuads()
    {
        return _renderQuads;
    }
}