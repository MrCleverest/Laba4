using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public abstract class Shape
    {
        protected Point position;
        string color;
        public Point Position { get { return position; } set { position = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Shape(Point position, string color)
        {
            this.position = position;
            this.color = color;
        }
        public abstract void Move(int deltaX, int deltaY);
        public abstract void Resize(int length);
        public abstract void Change_Color(string newColor);
    }
}
