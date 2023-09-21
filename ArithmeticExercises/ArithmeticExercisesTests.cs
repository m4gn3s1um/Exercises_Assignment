using NUnit.Framework;

namespace ArithmeticExercises;

public class ArithmeticExercisesTests
{
    private Arithmetic_Exercises exercise;
    
    [SetUp]
    public void SetUp()
    {
        exercise = new Arithmetic_Exercises();
    }
    
    [Test]
    public void TestAdd()
    {
        Assert.AreEqual(8, exercise.Add(5, 3));
    }
    
    [Test]
    public void TestSubtract()
    {
        Assert.AreEqual(2, exercise.Subtract(5, 3));
    }
    
    [Test]
    public void TestMultiply()
    {
        Assert.AreEqual(15, exercise.Multiply(5, 3));
    }

    [Test]
    public void TestDivide()
    {
        Assert.AreEqual(5, exercise.Divide(15, 3));
        Assert.AreEqual(0, exercise.Divide(15, 0));
    }

    [Test]
    public void TestModulus()
    {
        Assert.AreEqual(3, exercise.Modulus(15, 4));
    }
    
    [Test]
    public void TestPower()
    {
        Assert.AreEqual(8, exercise.Power(2, 3));
    }

    [Test]
    public void TestSquareRoot()
    {
        Assert.AreEqual(4, exercise.SquareRoot(16));
    }
    
    [Test]
    public void TestCircleArea()
    {
        Assert.AreEqual(78.54, exercise.CircleArea(5), 0.01);
    }

    [Test]
    public void TestFactorial()
    {
        Assert.AreEqual(120, exercise.Factorial(5));
    }

    [Test]
    public void TestFibonacci()
    {
        Assert.AreEqual(8, exercise.Fibonacci(6));
    }
}