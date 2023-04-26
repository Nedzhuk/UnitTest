using calc;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace TestCalculator
{
    public class Tests
    {
        [Test]
        public void Contains()
        {
            double x = 10, y = 5;
            double collection = x + y;
            List<double> action = new ();
            action.Add (Calculator.Sum(x,y));
            Assert.Contains(collection, action);
        }

        [Test]
        public void DoesNotContain()
        {
            double x = 5, y = 0;
            string collection = (x + y).ToString();
            string action = Calculator.Mul(x, y).ToString();
            StringAssert.DoesNotContain(collection,action); //��������� �������� �������� �� ������ ����������� � ���������� ������ ������ ��������� �� 0
        }
        [Test]
        public void DoesNotMatch()
        {
            double x = 5, y = 2;
            string expectedRegexPattern = (x * y).ToString();
            string actualString = Calculator.Div(x, y).ToString();
            StringAssert.DoesNotMatch(expectedRegexPattern, actualString); //��������� ��������� �� ������ ��������� � �������� ���� �����
        }
        [Test]
        public void Matches()
        {
            double x = 5, y = 1;
            Regex expectedRegexPattern = new Regex(@"\d");
            string actualString = Calculator.Div(x, y).ToString();
            expectedRegexPattern.Matches(actualString); //��������� ������ ������ ���� ��������
        }
        [Test]
        public void Equal()
        {
            double x = 10, y = 5;
            double expected = x + y;
            double result = Calculator.Sum(x, y);
            Assert.AreEqual(expected, result); //��������� � ����������� ��������� ������ ��������
        }
        [Test]
        public void NotEqual()
        {
            double x = 10, y = 5;
            double expected = x / y;
            double result = Calculator.Mul(x, y);
            Assert.AreNotEqual(expected, result);//��������� � ����������� ��������� ������ ����������
        }
        [Test]
        public void True()
        {
            double x = -5, y = 5;
            bool result = Calculator.Sum(x, y) == 0;
            Assert.True(result);
        }
        [Test]
        public void False()
        {
            double y = 5;
            bool result = Calculator.Sub(y, y) != 0;
            Assert.False(result);
        }
        [Test]
        public void IsInstanceOfType()
        {
            int x = 10, y = 5;
            Type expected = typeof(double);
            Assert.IsInstanceOf(expected, Calculator.Div(x, y));//���������� ��������� ������ ���� double
        }
        [Test]
        public void IsNotInstanceOfType()
        {
            int x = 10, y = 20;
            Type expected = typeof(int);
            Assert.IsNotInstanceOf(expected, Calculator.Mul(x, y));//���������� ��������� ������ ���� �� int
        }
        [Test]
        public void IsNull()
        {
            double x = 10, y = 0;
            double result = Calculator.Div(x,y);
            Assert.IsNull(result);
        }
        [Test]
        public void IsNotNull()
        {
            double x = 5, y = -10;
            double result = Calculator.Div(x, y);
            Assert.IsNotNull(result);
        }
        [Test]
        public void Same()
        {
            double x = 10, y = 5;
            List<int> collection = new();
            List<int> actual = new();
            Assert.AreSame(collection, actual); //������ ������ ��������� �� ���� � �� ��
        }
        [Test]
        public void NotSame()
        {
            double x = 10, y = 5;
            List<int> collection = new();
            List<int> actual = new();
            Assert.AreNotSame(collection, actual); //������ ������ ��������� �� ������ �������
        }
        //    [Test]
        //    public void ThrowsException()
        //    {
        //        string actual= null;
        //        Assert.Throws(() => Calculator.Result());
        //    }
    }
}