using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Triangle : Shape
    {
        int side;
        public int Side { get { return side; } set { side = value; } }

        public Triangle(Point position, string color, int side)
            : base(position, color)
        {
            this.side = side;
        }
        public override void Move(int deltaX, int deltaY)
        {
            Position.X += deltaX;
            Position.Y += deltaY;
        }
        public override void Resize(int side)
        {
            this.side = side;
        }
        public override void Change_Color(string newColor)
        {
            Color = newColor;
        }
    }
}