using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Rectangle : Shape
    {
        int width, height;
        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }

        public Rectangle(Point position, string color, int width, int height)
            : base(position, color)
        {
            this.width = width;
            this.height = height;
        }
        public override void Move(int deltaX, int deltaY)
        {
            Position.X += deltaX;
            Position.Y += deltaY;
        }
        public override void Resize(int side)
        {
            this.height = side;
        }
        public override void Change_Color(string newColor)
        {
            Color = newColor;
        }
    }
}
