using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba4;

namespace UnitTest
{
    [TestClass]
    public class ArrowTest
    {
        [TestMethod]
        public void CreateArrow()
        {
            Point position = new Point(0, 0);
            var arrow = new Arrow(position, "Жовтий", 10);
        }
        [TestMethod]
        public void Move_X()
        {
            Point position = new Point(0, 0);
            Arrow ar = new Arrow(position, "Червоний", 10);
            ar.Move(2, 0);
            Assert.AreEqual(2, ar.Position.X);
        }
        [TestMethod]
        public void Move_Y()
        {
            Point position = new Point(0, 0);
            Arrow ar = new Arrow(position, "Червоний", 10);
            ar.Move(0, 2);
            Assert.AreEqual(2, ar.Position.Y);
        }
        [TestMethod]
        public void Resize()
        {
            Point position = new Point(0, 0);
            Arrow ar = new Arrow(position, "Червоний", 10);
            ar.Resize(15);
            Assert.AreEqual(15, ar.Length);
        }
        [TestMethod]
        public void Change_Color()
        {
            Point position = new Point(0, 0);
            Arrow ar = new Arrow(position, "Червоний", 10);
            ar.Change_Color("Синій");
            Assert.AreEqual("Синій", ar.Color);
        }
    }
}