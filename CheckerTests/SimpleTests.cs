using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckerTests
{
    //Тесты на острый угол
    [TestClass]
    public class AcuteTests
    {
        
        [TestMethod]
        public void AcuteTest_1()
        {
            Assert.AreEqual("Остроугольный", TriangleChecker.Checker.Check(3,3,4));
        }
        [TestMethod]
        public void AcuteTest_2()
        {
            Assert.AreEqual("Остроугольный", TriangleChecker.Checker.Check(6.1, 2.3, 6));
        }
        [TestMethod]
        public void AcuteTest_3()
        {
            Assert.AreEqual("Остроугольный", TriangleChecker.Checker.Check(3.1, 1.9, 2.6));
        }
       
    }
    //Тесты на тупой угол
    [TestClass]
    public class ObtuseTests
    {
        [TestMethod]
        public void ObtuseTest_1()
        {
            Assert.AreEqual("Тупоугольный", TriangleChecker.Checker.Check(6, 11.3, 7.7));
        }
        [TestMethod]
        public void ObtuseTest_2()
        {
            Assert.AreEqual("Тупоугольный", TriangleChecker.Checker.Check(5, 3.4, 2.6));
        }
        [TestMethod]
        public void ObtuseTest_3()
        {
            Assert.AreEqual("Тупоугольный", TriangleChecker.Checker.Check(8, 21, 16));
        }
    }
    //Тесты на прямой угол
    [TestClass]
    public class RightTests
    {
        [TestMethod]
        public void RightTest_1()
        {
            Assert.AreEqual("Прямоугольный", TriangleChecker.Checker.Check(12, 9, 15));
        }
        [TestMethod]
        public void RightTest_2()
        {
            Assert.AreEqual("Прямоугольный", TriangleChecker.Checker.Check(5, 4, 3));
        }
        [TestMethod]
        public void RightTest_3()
        {
            Assert.AreEqual("Прямоугольный", TriangleChecker.Checker.Check(45, 27, 36));
        }
    }
    //Тесты на ошибки
    [TestClass]
    public class ErrorTests
    {
        [TestMethod]
        public void ZeroInArguments()
        {
            Assert.AreEqual("Это не треугольник", TriangleChecker.Checker.Check(6,4,0));
        }
        [TestMethod]
        public void NegativeArguments()
        {
            Assert.AreEqual("Это не треугольник", TriangleChecker.Checker.Check(3, -4, 5));
        }
        [TestMethod]
        public void NotATriangle()
        {
            Assert.AreEqual("Это не треугольник", TriangleChecker.Checker.Check(3, 4, 45));
        }
    }
}
