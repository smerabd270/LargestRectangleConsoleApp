using System;
using System.Collections.Generic;
using System.Text;

namespace LargestRectangleConsoleApp
{
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }

        public override string ToString()
        {
            return $"Rectangle [Width: {Width}, Height: {Height}, Area: {Area}]";
        }
    }
}
