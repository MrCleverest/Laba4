using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba4;

namespace UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CreateTriangle()
        {
            Point position = new Point(0, 0);
            var triangle = new Triangle(position, "Жовтий", 5);
        }
        [TestMethod]
        public void Move_X()
        {
            Point position = new Point(0, 0);
            Triangle tr = new Triangle(position, "Червоний", 5);
            tr.Move(3, 0);
            Assert.AreEqual(3, tr.Position.X);
        }
        [TestMethod]
        public void Move_Y()
        {
            Point position = new Point(0, 0);
            Triangle tr = new Triangle(position, "Червоний", 5);
            tr.Move(0, 4);
            Assert.AreEqual(4, tr.Position.Y);
        }
        [TestMethod]
        public void Resize()
        {
            Point position = new Point(0, 0);
            Triangle tr = new Triangle(position, "Червоний", 5);
            tr.Resize(10);
            Assert.AreEqual(10, tr.Side);
        }
        [TestMethod]
        public void Change_Color()
        {
            Point position = new Point(0, 0);
            Triangle tr = new Triangle(position, "Червоний", 5);
            tr.Change_Color("Синій");
            Assert.AreEqual("Синій", tr.Color);
        }
    }
}