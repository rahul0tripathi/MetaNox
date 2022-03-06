public class CommonHandler
{
    public enum Direction
    {
        BOTTOM,
        BOTTOM_RIGHT,
        RIGHT,
        TOP_RIGHT,
        TOP,
        TOP_LEFT,
        LEFT,
        BOTTOM_LEFT
    }

    public enum GameMode
    {
        NORMAL,
        ATTACK
    }

    public enum RenderingLayer
    {
        GROUND = 0,
        SHADOW = 1,
        SPRITE = 2
    }

    public enum State
    {
        IDLE,
        WALK,
        ATTACK,
        DESTROYED
    }
}