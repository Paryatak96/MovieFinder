using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLib
{
    class Controls
    {
        public int CursorPositionLeft { get; set ; }
        public int CursorPositionTop { get; set; }

        public int Pointer => CursorPositionTop - 1;

        public int MoveDown(ConsoleKey button, Controls controls)
        {
            if (button == ConsoleKey.DownArrow)
            {
                controls.CursorPositionTop += 1;
                if (controls.CursorPositionTop >= 5)
                {
                    controls.CursorPositionTop = 1;
                }
            }
            return controls.CursorPositionTop; 
        }
        public int MoveUp(ConsoleKey button, Controls controls)
        {
            if (button == ConsoleKey.UpArrow)
            {
                controls.CursorPositionTop -= 1;
                if (controls.CursorPositionTop < 1)
                {
                    controls.CursorPositionTop = 4;
                }
            }
            return controls.CursorPositionTop;
        }
    }
}
