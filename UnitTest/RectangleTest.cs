using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba4;

namespace UnitTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void CreateRectangle()
        {
            Point position = new Point(0, 0);
            var rectangle = new Rectangle(position, "Жовтий", 5, 10);
        }
        [TestMethod]
        public void Move_X()
        {
            Point position = new Point(0, 0);
            Rectangle rec = new Rectangle(position, "Червоний", 5, 5);
            rec.Move(5, 0);
            Assert.AreEqual(5, rec.Position.X);
        }
        [TestMethod]
        public void Move_Y()
        {
            Point position = new Point(0, 0);
            Rectangle rec = new Rectangle(position, "Червоний", 5, 5);
            rec.Move(0, 1);
            Assert.AreEqual(1, rec.Position.Y);
        }
        [TestMethod]
        public void Resize()
        {
            Point position = new Point(0, 0);
            Rectangle rec = new Rectangle(position, "Червоний", 5, 10);
            rec.Resize(10);
            Assert.AreEqual(10, rec.Height);
        }
        [TestMethod]
        public void Change_Color()
        {
            Point position = new Point(0, 0);
            Rectangle rec = new Rectangle(position, "Червоний", 5, 10);
            rec.Change_Color("Синій");
            Assert.AreEqual("Синій", rec.Color);
        }
    }
}