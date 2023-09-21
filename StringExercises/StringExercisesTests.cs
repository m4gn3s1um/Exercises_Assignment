using NUnit.Framework;

namespace StringExercises;

public class StringExercisesTests
{
    private String_Exercises exercise;
    
    [SetUp]
    public void SetUp()
    {
        exercise = new String_Exercises();
    }
    
    [Test]
    public void TestReverseString()
    {
        Assert.AreEqual("olleh", exercise.ReverseString("hello"));
    }
    
    [Test]
    public void TestIsPalindrome()
    {
        Assert.IsTrue(exercise.IsPalindrome("radar"));
        Assert.IsFalse(exercise.IsPalindrome("hello"));
    }
    
    [Test]
    public void TestConvertToUpper()
    {
        Assert.AreEqual("HELLO", exercise.ConvertToUpper("hello"));
    }
    
    [Test]
    public void TestCountVowels()
    {
        Assert.AreEqual(2, exercise.CountVowels("hello"));
    }

    [Test]
    public void TestRemoveWhitespaces()
    {
        Assert.AreEqual("helloworld", exercise.RemoveWhitespaces("hello world"));
    }
    
    [Test]
    public void TestFirstNonRepeatedCharacter()
    {
        Assert.AreEqual('w', exercise.FirstNonRepeatedCharacter("swiss"));
        Assert.AreEqual('h', exercise.FirstNonRepeatedCharacter("hello"));
    }
    
    [Test]
    public void TestAreAnagrams()
    {
        Assert.IsTrue(exercise.AreAnagrams("listen", "silent"));
        Assert.IsFalse(exercise.AreAnagrams("hello", "world"));
    }
    
    [Test]
    public void TestReplaceSpaces()
    {
        Assert.AreEqual("Mr%20John%20Smith", exercise.ReplaceSpaces("Mr John Smith"));
    }
    
    [Test]
    public void TestCountCharacterOccurrences()
    {
        Assert.AreEqual(2, exercise.CountCharacterOccurrences("hello", 'l'));
        Assert.AreEqual(0, exercise.CountCharacterOccurrences("hello", 'z'));
    }
    
    [Test]
    public void TestShortenStringWithCounts()
    {
        Assert.AreEqual("a3b2c1", exercise.ShortenStringWithCounts("aaabbc"));
        Assert.AreEqual("h1e1l2o1", exercise.ShortenStringWithCounts("hello"));
    }
}