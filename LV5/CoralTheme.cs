using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class CoralTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public string GetHeader(int width)
        {
            return new string('_', width);
        }

        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
