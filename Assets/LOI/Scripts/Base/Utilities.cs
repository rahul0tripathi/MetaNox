using System.Text.RegularExpressions;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public static GameObject CreateInstance(GameObject original, GameObject parent, bool isActive)
    {
        var instance = Instantiate(original, parent.transform, false);
        instance.SetActive(isActive);
        return instance;
    }

    public static RendererQuad CreateRenderQuad()
    {
        return CreateInstance(Main.instance.RenderQuad, Main.instance.ItemsContainer, true)
            .GetComponent<RendererQuad>();
    }

    public static float ClockwiseAngleOf3Points(Vector2 A, Vector2 B, Vector2 C)
    {
        var v1 = A - B;
        var v2 = C - B;

        var sign = Mathf.Sign(v1.x * v2.y - v1.y * v2.x) * -1;
        var angle = Vector2.Angle(v1, v2) * sign;

        if (angle < 0) angle = 360 + angle;

        return angle;
    }

    public static string CleanStringForFloat(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        if (Regex.Match(input, @"^-?[0-9]*(?:\.[0-9]*)?$").Success)
            return input;
        return "0";
    }

    public static string CleanStringForInt(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        if (Regex.Match(input, "([-+]?[0-9]+)").Success)
            return input;
        return "0";
    }
}