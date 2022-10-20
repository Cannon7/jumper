using System;

namespace dumper{

    
    public class WordGenerator
    {
            private string[] wordList;
            
            public WordGenerator(){
                wordList = System.IO.File.ReadAllLines(@"C:\CSE 210\dumper\wordlewords.txt");
                Random pickedWord = new Random();
                // foreach(string word in wordList){
                //     wordList.Append(word);
                // }
                int wordIndex = pickedWord.Next(wordList.Length);
                
                string ArrayedWord = wordList[wordIndex];
                string[] RandomWord = ArrayedWord.Split();
                foreach(string r in RandomWord){
                    Console.WriteLine(r);
                }
    } 
      
            
            
        
    }
}



// Reading a file
//https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-a-text-file-in-C-Sharp/