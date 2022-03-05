using UnityEngine;

[RequireComponent(typeof(RendererQuad))]
public class TextureSheetAnimationScript : MonoBehaviour
{
    /* object refs */
    public RendererQuad RenderQuad;

    private float _currentFrame = -1;
    private float _fps;
    private int _framesCount;

    private float _playStartTime;

    /* private vars */
    private int _tilesX;
    private int _tilesY;

    private void Awake()
    {
        _playStartTime = Time.time;
    }

    private void Update()
    {
        if (RenderQuad == null) return;

        if (_framesCount > 1)
        {
            var frame = (int)((Time.time - _playStartTime) * _fps);
            frame = frame % _framesCount;
            SetFrame(frame);
        }
        //		else {
        //			this.SetFrame (0);
        //		}
    }

    /// <summary>
    ///     Sets the texture sheet data.
    /// </summary>
    /// <param name="tilesX">Tiles x.</param>
    /// <param name="tilesY">Tiles y.</param>
    /// <param name="frames">Frames.</param>
    /// <param name="fps">Fps.</param>
    public void SetTextureSheetData(int tilesX, int tilesY, int frames, float fps)
    {
        _tilesX = tilesX;
        _tilesY = tilesY;
        _framesCount = frames;
        _fps = fps;
        SetFrame(0);
    }

    /// <summary>
    ///     Sets the frame.
    /// </summary>
    /// <param name="frame">Frame.</param>
    public void SetFrame(int frame)
    {
        if (frame == _currentFrame)
            //no change
            return;

        //		if (frame > this._framesCount - 1 || frame < 0) {
        //			return;
        //		}

        var xUnitSize = 1.0f / _tilesX;
        var yUnitSize = 1.0f / _tilesY;

        var xIndex = frame % _tilesX;
        var yIndex = frame / _tilesX;
        yIndex = _tilesY - yIndex - 1;


        Vector2[] uv =
        {
            new Vector2(xIndex * xUnitSize, yIndex * yUnitSize),
            new Vector2(xIndex * xUnitSize, yIndex * yUnitSize) + new Vector2(xUnitSize, 0),
            new Vector2(xIndex * xUnitSize, yIndex * yUnitSize) + new Vector2(0, yUnitSize),
            new Vector2(xIndex * xUnitSize, yIndex * yUnitSize) + new Vector2(xUnitSize, yUnitSize)
        };

        RenderQuad.MeshFilter.mesh.uv = uv;

        _currentFrame = frame;
    }
}