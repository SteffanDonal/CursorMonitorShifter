using System.Numerics;

internal static class ScreenExtensions
{
    public static Vector2 GetCenter(this Screen screen) =>
        new Vector2(screen.Bounds.Location.X, screen.Bounds.Location.Y) +
        new Vector2(screen.Bounds.Size.Width, screen.Bounds.Height) / 2f;
}
