using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) დაწერეთ კონსოლ აპლიკაცია , შექმენით ფუნქცია რომელიც პარამეტრად მიიღებს სტრინგს და დააბრუნებს რიცხვს, რომელიც აღნიშნავს სტრინგში
             * სიტყვების რაოდენობას. დაწერეთ მეორე ფუნქცია, რომელიც დაბეჭდავს ამ რიცხვს*/

           // Output();

            /* 2) დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც პარამეტრად მიიღებს ტექსტს და დააბრუნებს ხმოვნებს ან თანხმოვნების რაოდენობას,
             ხმოვანი დაბრუნდება თუ თანხმოვანი მეთოდს უნდა გაყვეს პარამეტრად, გულისხმობის მიხედვით უნდა იყოს ხმოვანი.
            შექმენით მეორე ფუნქცია რომელიც შესაბამისად დაბეჭდავს მხოლოდ ხმოვნებს ან თანხმოვნებს იგივე პრინციპით */

            //Vowel();

            /* 3)დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქციები რომელსაც პარამეტრად გადაეწოდება სტრინგი. პირველი დააბრუნებს სტრინგში ასოების რაოდენობას
             * მე-2-ე სტრინგში დაბრუნებულ პარამეტრს და დამატებით ორიგინალ ტექსტს, იღებს არგუმენტად და ბეჭდავს მათ.
             * მაგ:Hello 1 ! -> letters:5 , numbers: 1, Others:3*/

            //Letters();

            /* 4)დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც პარამეტრად მიიღებს სტრინგს და დაბეჭდავს მას უკუღმა(თქვენი გადასაწყვეტია 
             * იუზერს შეაყვანინებთ თუ არა ინფუთს.)
             მაგ: Hello -> olleH*/

            //Reverse();

            /* 5) დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც პარამეტრად მიიღებს სტრინგს და დაბეჭდავს მას გამოყოფილს სფეისებით
             * მაგ: HELLO -> H E L L O*/

            //Spaces();
        }
        static void Vowel()
        {
            Console.Write("Enter a text: ");
            string userText = Console.ReadLine();

            int vowelCount = CountVowelsOrConsonants(userText);
            Console.WriteLine($"Number of vowels: {vowelCount}");

            
            Console.Write("Vowels:");
            PrintVowelsOrConsonants(userText);

            int consonantCount = CountVowelsOrConsonants(userText, isConsonant: true);
            Console.WriteLine($"Number of consonants: {consonantCount}");

            Console.Write("Consonants:");
            PrintVowelsOrConsonants(userText, isConsonant: true);
        }

    


        static void PrintVowelsOrConsonants(string text, bool isConsonant = false)
        {
            string vowels = "AEIOUaeiou";
            string consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";

            string characters = isConsonant ? consonants : vowels;

            foreach (char c in text)
            {
                if (characters.Contains(c))
                {
                    Console.Write(c+" ");
                }
            }

            Console.WriteLine();
        }


        static int CountVowelsOrConsonants(string text, bool isConsonant = false)
        {
            string vowels = "AEIOUaeiou";
            string consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";

            string characters = isConsonant ? consonants : vowels;

            int count = 0;
            foreach (char c in text)
            {
                if (characters.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        static void Reverse(string text = "HELLO")
        {
            var reverse = text.Reverse();
            foreach (var item in reverse)
            Console.Write(item);
            Console.WriteLine();

        }
        static void Spaces(string text = "HELLO")
        {
            var withSpaces = text.ToCharArray();
            foreach (var item in withSpaces)
                Console.Write(item+" ");
        }
        static void Letters(string txt = "Hello 1 !")
        {
            int letterCount = CountLetters(txt);
            int numberCount = CountNumbers(txt);
            int otherCount = txt.Length - (letterCount + numberCount);
         
            PrintOriginalAndCount(txt,letterCount,numberCount,otherCount);
        }
        static int CountLetters(string text)
        {
            return text.Count(char.IsLetter);
        }
        static int CountNumbers(string text)
        {
            return text.Count(char.IsDigit);
        }
        static void PrintOriginalAndCount(string original, int letterCount, int numberCount, int otherCount)
        {

            Console.WriteLine($"Original Text: {original}");
            Console.WriteLine($"Letters: {letterCount}, Numbers: {numberCount}, Others: {otherCount}");
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        

        static int Input(string input)
        {
            int x = 0;
            var result = input.Split(' ');
            foreach (string c in result)
            {
                x++;
            }
            return x;
        }
        static void Output()
        {
            Console.WriteLine("Enter a proposal");
            int answer = Input(Console.ReadLine());
            Console.WriteLine(answer);
        }
    }
}
