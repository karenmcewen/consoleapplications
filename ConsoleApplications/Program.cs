using System;

namespace ConsoleApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take a string and reverse it
           
            string myPhrase = "Hello World!";
            int i = 0;           
            char[] myPhraseArray = myPhrase.ToCharArray();
            int j = myPhraseArray.Length - 1;
          
            Console.WriteLine(myPhraseArray);
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();

            while (i<j)
            {
                char tempLetter = myPhraseArray[i];
                myPhraseArray[i] = myPhraseArray[j];
                myPhraseArray[j] = tempLetter;
                i++;
                j--;
            }
           
            Console.Write("The reversed string is ");
            Console.WriteLine(myPhraseArray);
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
            //-----------------------------------------------------

            //-----------------------------------------------------
        }
    }
}
