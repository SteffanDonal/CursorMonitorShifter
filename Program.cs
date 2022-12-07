using System.Numerics;

if (args.Length != 1) return;

var bias = Vector2.Zero;

switch (args[0])
{
    case "left":
        bias.X = -1;
        break;

    case "up":
        bias.Y = -1;
        break;

    case "right":
        bias.X = 1;
        break;

    case "down":
        bias.Y = 1;
        break;

    default: return;
}

var mouseScreen = Screen.FromPoint(Cursor.Position);
var mouseScreenCenter = mouseScreen.GetCenter();

var candidateScreens = Screen.AllScreens
    .Where(screen => screen.DeviceName != mouseScreen.DeviceName)
    .Select(screen => new { Offset = screen.GetCenter() - mouseScreenCenter, Screen = screen })

    // Ensure we only have screens that are in the direction we care about.
    .Where(candidate => bias.X == 0
        ? Math.Sign(candidate.Offset.Y) == Math.Sign(bias.Y)
        : Math.Sign(candidate.Offset.X) == Math.Sign(bias.X))
    .ToList();

// No candidates, do nothing.
if (!candidateScreens.Any()) return;

var targetScreen = candidateScreens
    .OrderBy(candidate => Math.Abs(candidate.Offset.X) + Math.Abs(candidate.Offset.Y))
    .First().Screen;

var normalCursorPosition =
    (new Vector2(Cursor.Position.X, Cursor.Position.Y) - new Vector2(mouseScreen.Bounds.X, mouseScreen.Bounds.Y))
    / new Vector2(mouseScreen.Bounds.Width, mouseScreen.Bounds.Height);

var newCursorPosition =
    new Vector2(targetScreen.Bounds.X, targetScreen.Bounds.Y)
    + normalCursorPosition * new Vector2(targetScreen.Bounds.Width, targetScreen.Bounds.Height);

var newCursorPoint = new Point((int)newCursorPosition.X, (int)newCursorPosition.Y);

// We have to set it twice because of Windows bullshit.
Cursor.Position = newCursorPoint;
Cursor.Position = newCursorPoint;
