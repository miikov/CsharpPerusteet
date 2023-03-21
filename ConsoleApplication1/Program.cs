using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Koodi tulee tänne
            // Syntax - syntaksi
            // syntax error
            // Tämä on kommentti
            // Kommentit eivät suorita mitään

            // Datatypes - datatyypit
            // Numeroita
            // 35 - kokonaisluku - integer
            // 13.5 - liukuluku - floating point
            // Merkkejä - char / Merkkijono - string
            // 't' / "word"
            // Bool
            // true/false 0/1
            // Literals
            // data on tallessa muuttujissa - variable
            // <data_type> <variable name>
            //
            // int
            int apu = 5;
            int integerValue = 10; // puolipiste rivin loppuun
            integerValue = 15;
            // double - liukuluku
            double doubleValue;
            doubleValue = 3.14;
            // char
            char characterValue = 'r';
            // string
            string stringValue = "Word";
            // Bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä

            // luokaa muuttuja nimeltä message
            // ja antakaa sille arvoksi "Hello"
            /*

            string message = "hello";
            Console.WriteLine(message);
            Console.ReadKey();
            string input; 
            input = Console.ReadLine();
            // "Vastasit x", jossa x on käyttäjän syöte (input).
            Console.WriteLine("Vastasit {0}", input); 
            Console.WriteLine($"Interpolating {input}"); 
            Console.WriteLine("Vastasit " + input);
            Console.ReadKey();

            #region 3 C# Perus: Ikä-tehtävä  
            //Koodi

            Console.Write("Syötä ikäsi. ");
            string userInput = Console.ReadLine();
            int ika = int.Parse(userInput);  
            Console.WriteLine("Olet " + ika + "vuotta. ");
            Console.ReadLine();

           
    */
           // Ilmoita käyttäjän ikä kuukausina
           // +, -, *, /, %

           // int sum = 5 + 4;
           // sum = 7 + ika;
           // sum = sum + ika;
           // sum += ika;
           // sum = 9

            Console.Write("Minka ikainen olet vuosina? ");
            string userInput = Console.ReadLine();
            int ika = int.Parse(userInput);
            int sum = 12 * ika;
            Console.WriteLine("Olet " + sum + " kuukautta. ");
            Console.ReadLine();

            




            

          

        }
    }
}
