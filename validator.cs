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
        public string GuessValidate(guess, wordlist, wordprog)
        {

        }
    */
}
