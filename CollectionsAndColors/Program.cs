using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndColors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;   //for deciding if user wants to continue
            List<string> colorList = new List<string>();

            while (userContinue)
            {
                Console.WriteLine("Please give me a color!");
                colorList.Add(Console.ReadLine());
                Console.WriteLine("Do you want to add another color to  your list? y/n");
                string result = Console.ReadLine();
                while (result.ToLower() != "y" && result.ToLower() != "n")
                {
                    Console.WriteLine("I'm sorry! That's not a valid response!");
                    Console.WriteLine("Would you like to add another color to your list? y/n");
                    result = Console.ReadLine().ToLower();
                }
                if (result == "y")
                {
                    userContinue = true;
                }
                else
                {
                    userContinue = false;
                }
            }

            for (int i = 0; i < colorList.Count; i++)
            {
                Console.Write(colorList[i] + ", ");
                //Console.Write("{0}, ", colorList[i]); //this line is the same as the one above 
            }

            colorList[0] = "red";

            foreach (string color in colorList)
            {
                Console.Write(color + ", ");
            }

            Console.ReadLine();

        }
    }
}
