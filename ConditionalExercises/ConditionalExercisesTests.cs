using NUnit.Framework;

namespace ConditionalExercises;

public class ConditionalExercisesTests
{
    private Conditional_Exercises exercise;
    
    [SetUp]
    public void SetUp()
    {
        exercise = new Conditional_Exercises();
    }
    
    [Test]
    public void TestEvenOrOdd()
    {
        Assert.AreEqual("Odd", exercise.EvenOrOdd(5));
        Assert.AreEqual("Even", exercise.EvenOrOdd(4));
    }
    
    [Test]
    public void TestCheckNumber()
    {
        Assert.AreEqual("Negative", exercise.CheckNumber(-5));
        Assert.AreEqual("Positive", exercise.CheckNumber(5));
        Assert.AreEqual("Zero", exercise.CheckNumber(0));
    }
    
    [Test]
    public void TestIsLeapYear()
    {
        Assert.IsTrue(exercise.IsLeapYear(2020));
        Assert.IsFalse(exercise.IsLeapYear(2019));
    }
    
    [Test]
    public void TestGetGrade()
    {
        Assert.AreEqual("B", exercise.GetGrade(85));
        Assert.AreEqual("A", exercise.GetGrade(95));
        Assert.AreEqual("F", exercise.GetGrade(50));
    }
    
    [Test]
    public void TestCanVote()
    {
        Assert.IsFalse(exercise.CanVote(17));
        Assert.IsTrue(exercise.CanVote(18));
    }

    [Test]
    public void TestLargestOfThree()
    {
        Assert.AreEqual(10, exercise.LargestOfThree(5, 10, 8));
    }
    
    [Test]
    public void TestIsDivisible()
    {
        Assert.IsTrue(exercise.IsDivisible(10, 5));
        Assert.IsFalse(exercise.IsDivisible(10, 3));
    }

    [Test]
    public void TestIsPrime()
    {
        Assert.IsTrue(exercise.IsPrime(7));
        Assert.IsFalse(exercise.IsPrime(9));
    }
    
    [Test]
    public void TestIsVowel()
    {
        Assert.IsTrue(exercise.IsVowel('a'));
        Assert.IsFalse(exercise.IsVowel('b'));
    }
    
    [Test]
    public void TestStartsWithCapital()
    {
        Assert.IsTrue(exercise.StartsWithCapital("Hello"));
        Assert.IsFalse(exercise.StartsWithCapital("hello"));
    }








}