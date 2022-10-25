using System;

namespace jumper;

public class validator

{
    public string GameEnd(int errors)
    {
        if (errors >= 4)
        {
           return "over"; 
        }
        else
        {
            return "continue";
        }
    }
    public string LetterCheck(string[] letterlist, string guess)
    {
        string dupe = "no";
        foreach (string i in letterlist)
        {
            if (i == guess)
            {
                dupe = "yes";
            }
        }
        if (dupe == "yes")
        {
            return "yes";
        }
        else
        {
            return "no";
        }
    }
    /*
        public string GuessValidate(guess, wordlist, wordprog, errors, guessedLetters[])
        {
            if (guess != in wordlist) 
                errors++;
                guessedLetters.append(guess)
            elseif (guess in guessedLetters[])
                Console.WriteLine("Sorry, '${guess}' has already been guessed.)
            else
                // Somehow display those letters and replace the dashes
                guessedLetters.append(guess)
        }
    */
}
