using System;
using Microsoft.VisualBasic;
using Unit05.Game.Casting;

namespace Unit05.Game
{
    /// <summary>
    /// <para>A cycle game where two cycles try to crash the other into their tail.</para>
    /// <para>
    /// 
    /// </para>
    /// </summary>
    public class Constants
    {
        public static int COLUMNS = 40;
        public static int ROWS = 20;
        public static int CELL_SIZE = 15;
        public static int MAX_X = 900;
        public static int MAX_Y = 600;

        public static int FRAME_RATE = 15;
        public static int FONT_SIZE = 15;
        public static string CAPTION = "Cycle";
        public static int CYCLE_LENGTH = 1;

        public static Color RED = new Color(255, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color YELLOW = new Color(255, 255, 0);
        public static Color GREEN = new Color(0, 255, 0);

    }
}

