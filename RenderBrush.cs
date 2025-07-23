using System.Text;

namespace ConsoleGameEngine
{
    /*
    Block Elements:
    \u2588 (Full Block), 
    \u2580 (Upper Half Block), 
    \u2584 (Lower Half Block), 
    \u258C (Left Half Block), 
    \u2590 (Right Half Block), 
    \u2591 (Light Shade), 
    \u2592 (Medium Shade), 
    \u2593 (Dark Shade) - Useful for creating shading, gradients, or filling areas.
    Geometric Shapes:
    \u25A0 (Black Square), 
    \u25B2 (Black Up-Pointing Triangle), 
    \u25BC (Black Down-Pointing Triangle), 
    \u25C6 (Black Diamond) - Can be used for representing game elements like tiles, 
    enemies, or player characters.
    Arrows:
    \u2190, 
    \u2191, 
    \u2192, 
    \u2193 (Left, Up, Right, Down arrows) - Can be used for navigation, direction indicators, 
    or as part of UI elements.
    Miscellaneous Symbols:
    \u2660, 
    \u2663, 
    \u2665, 
    \u2666 (Spades, Clubs, Hearts, Diamonds), 
    \u2713 (Check Mark), 
    \u2717 (Cross Mark) - Can be used for representing card suits, or other game-specific symbols.
    Specialized Characters:
    Characters like 
    \u263A (White Smiling Face), 
    \u2602 (Umbrella), 
    \u26C4 (Snowman) can add unique visual flair. 
    */

    public class RenderBrush
    {
        public static Rune Block = new Rune('\u2588');
        public static Rune UpperBlock = new Rune('\u2580');
        public static Rune LowerBlock = new Rune('\u2584');
        public static Rune LeftBlock = new Rune('\u258C');
        public static Rune RightBlock = new Rune('\u2590');
    }
}