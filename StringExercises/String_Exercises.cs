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
        // TODO: Implement this method
        return '\0';
    }
    
    // Description: Write a method that checks if two strings are anagrams.
    // Example Input: "listen", "silent"
    // Example Output: true
    public bool AreAnagrams(string str1, string str2)
    {
        // TODO: Implement this method
        return false;
    }
    
    // Description: Write a method that replaces all spaces in a string with '%20'.
    // Example Input: "Mr John Smith"
    // Example Output: "Mr%20John%20Smith"
    public string ReplaceSpaces(string input)
    {
        // TODO: Implement this method
        return "";
    }
    
    // Description: Write a method that counts the occurrences of a specific character in a string.
    // Example Input: "hello", 'l'
    // Example Output: 2
    public int CountCharacterOccurrences(string input, char character)
    {
        // TODO: Implement this method
        return 0;
    }
    
    // Description: Write a method that shortens a string by replacing sequences of the same character with that character followed by the count.
    // Example Input: "aaabbc"
    // Example Output: "a3b2c1"
    public string ShortenStringWithCounts(string input)
    {
        // TODO: Implement this method
        return "";
    }



}