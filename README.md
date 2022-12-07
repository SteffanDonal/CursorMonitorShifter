# Cursor Monitor Shifter

Teleports your mouse cursor between your connected displays. It's meant to be used in conjunction with either keyboard shortcuts or mouse gestures, and so allows for left, up, down or right commands to control which screen the cursor will move to.

https://user-images.githubusercontent.com/1431570/206311611-315775c9-f98e-4e1f-b5fb-a1274174a6ba.mp4

CursorMonitorShifter makes a "best guess" as to whatever display is considered "the most left/up/right/down" and moves your cursor there. If there are no displays in the direction you wish to move, nothing happens. The cursor's position on the current display is scaled to match the destination display's resolution.

## Usage

```
.\CursorMonitorShifter.exe left
.\CursorMonitorShifter.exe up
.\CursorMonitorShifter.exe right
.\CursorMonitorShifter.exe down
```

1. [Download the latest release](https://github.com/SteffanDonal/CursorMonitorShifter/releases/latest), save it somewhere you won't lose it!
2. Setup macros in your favourite tool of choice to run CursorMonitorShifter, and pass a direction as an argument.
3. Enjoy!

### Logitech Options & Logi Options+

This dumb piece of software doesn't let you pass arguments to applications when using the "Open application" action. Here's a workaround for that problem:

1. Create a number of shortcuts to CursorMonitorShifter, however many directions you care about moving.
2. Rename them too!
3. Edit each shortcut's properties, and add the direction name at the end of the `Target` field.
IE.
```
D:\Applications\Tools\CursorMonitorShifter\CursorMonitorShifter.exe up
```
4. Go into Logitech and set your "Open application" action.
5. Enter in the full path to the shortcut for the direction you're binding, **without quotes**, and **without browsing**. W11 users may use the "Copy as path" context menu option, just so long as you **remove the quotes**.
6. Repeat steps 4-5 until everything's setup as you like.
7. Enjoy!
