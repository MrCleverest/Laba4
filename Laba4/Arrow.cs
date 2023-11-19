using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Laba4
{
    public class Arrow : Shape
    {
        int length;
        public int Length { get { return length; } set { length = value; } }
        public Arrow(Point position, string color, int length)
            : base(position, color)
        {
            this.length = length;
        }
        public override void Move(int deltaX, int deltaY)
        {
            Position.X += deltaX;
            Position.Y += deltaY;
        }
        public override void Resize(int side)
        {
            this.length = side;
        }
        public override void Change_Color(string newColor)
        {
            Color = newColor;
        }
    }
}
