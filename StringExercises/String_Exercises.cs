using NUnit.Framework;

namespace StringExercises;

public class String_Exercises
{
    // Description: Write a method that takes a string as input
    // and returns the string reversed.
    // Example Input: "hello"
    // Example Output: "olleh"
    public string ReverseString(string input)
    {
        return string.Concat(input.Reverse());
    }
    
    // Description: Write a method that checks if a string
    // is a palindrome.
    // Example Input: "radar"
    // Example Output: true
    public bool IsPalindrome(string input)
    {
        var reversed = ReverseString(input);
        if (input.Equals(reversed))
        {
            return true;
        }
        return false;
    }
    
    // Description: Write a method that converts a
    // string to uppercase.
    // Example Input: "hello"
    // Example Output: "HELLO"
    public string ConvertToUpper(string input)
    {
        return input.ToUpper();
    }

    // Description: Write a method that counts the number
    // of vowels in a string.
    // Example Input: "hello"
    // Example Output: 2
    public int CountVowels(string input)
    {
        int count = 0;
        var vowels = new char[]{'a', 'e', 'y', 'u', 'i', 'o', 'æ', 'å', 'ø'};
        foreach (var ch in input)
        {
            foreach (var vo in vowels)
            {
                if (ch == vo)
                {
                    count++;
                }
            }
        }
        return count;
    }
    
    // Description: Write a method that removes all
    // whitespaces from a string.
    // Example Input: "hello world"
    // Example Output: "helloworld"
    public string RemoveWhitespaces(string input)
    {
        foreach (var ch in input)
        {
            if (ch == ' ')
            {
                var index = input.IndexOf(ch);
                input = input.Remove(index,1);
            }
        }
        return input;
    }

    // Description: Write a method that finds the first non-repeated
    // character in a string.
    // Example Input: "swiss"
    // Example Output: "w"
    public char FirstNonRepeatedCharacter(string input)
    {
        char[] charArray = input.ToCharArray();
        char output = '\0';
        
        IDictionary<char, int> repeatedChar = new Dictionary<char, int>();
        ICollection<int> icoll = repeatedChar.Values;
        
        foreach (var c in charArray)
        {
            if (repeatedChar.ContainsKey(c))
            {
                repeatedChar[c] = repeatedChar[c] + 1;
            }
            else
            {
                repeatedChar.Add(c, 0);
            }
        }

        foreach (var charKey in repeatedChar)
        {
            if (charKey.Value == 0)
            {
                output = charKey.Key;
                break;
            }
        }
        return output;
    }
    
    // Description: Write a method that checks if two strings are anagrams.
    // Example Input: "listen", "silent"
    // Example Output: true
    public bool AreAnagrams(string str1, string str2)
    {
        char[] charArray1 = str1.ToCharArray();
        char[] charArray2 = str2.ToCharArray();

        List<char> l1 = charArray1.ToList();
        List<char> l2 = charArray2.ToList();

        l1.Sort();
        l2.Sort();
        
        int x = 0;
        
        if (str1.Length == str2.Length)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i].Equals(l2[i]))
                {
                    Console.WriteLine(l1[i]);
                    x++;
                }
                if (x == l1.Count)
                {
                    return true;
                }
            }
        }
        // TODO: Implement this method
        return false;
    }
    
    // Description: Write a method that replaces all spaces in a string with '%20'.
    // Example Input: "Mr John Smith"
    // Example Output: "Mr%20John%20Smith"
    public string ReplaceSpaces(string input)
    {
        string output = String.Format(Uri.EscapeDataString(input));
        return output;
    }
    
    // Description: Write a method that counts the occurrences of a specific character in a string.
    // Example Input: "hello", 'l'
    // Example Output: 2
    public int CountCharacterOccurrences(string input, char character)
    {
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Equals(character))
            {
                count++;
            }
        }
        return count;
    }
    
    // Description: Write a method that shortens a string by replacing sequences of the same character with that character followed by the count.
    // Example Input: "aaabbc"
    // Example Output: "a3b2c1"
    public string ShortenStringWithCounts(string input)
    {
        char[] charArray = input.ToCharArray();
        IDictionary<char, int> charCount = new Dictionary<char, int>();
        string output = null;
        
        foreach (var c in charArray)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c] = charCount[c] + 1;
            }
            else
            {
                charCount.Add(c, 0);
            }
        }

        foreach (var charKey in charCount)
        {
            output = output + charKey.Key + (charKey.Value+1);
        }
        return output;
    }
}