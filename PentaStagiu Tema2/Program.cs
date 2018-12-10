using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaStagiu_Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string homework = "Choose 7 methods from the string build-in functionalities and create some examples with them";
            string add = "only if you want :)";
            string empty = string.Empty;

            string upper = homework.ToUpper();
            Console.WriteLine("String-ul uppercase este: " + upper + Environment.NewLine);

            string replace = add.Replace(":)", ";) ;) ;)");
            Console.WriteLine("Mood: " + replace + Environment.NewLine);

            if(string.IsNullOrEmpty(empty))
            {
                Console.WriteLine("E gol!" + Environment.NewLine);
            }

            int compare = string.Compare(homework, add);
            if(compare==-1)
            {
                Console.WriteLine("Primul string este mai lung!" + Environment.NewLine);
            }
            else if(compare==0)
            {
                Console.WriteLine("String-urile au aceeasi dimensiune!" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Al doilea string este mai lung!" + Environment.NewLine);
            }

            int index = homework.IndexOf(7.ToString());
            Console.WriteLine("7 are index-ul " + (index+1)  + Environment.NewLine);

            string concat = string.Concat(homework, add);
            Console.WriteLine("String-ul complet este: " + concat + Environment.NewLine);

            bool contains = add.Contains("only");
            if(contains==true)
            {
                Console.WriteLine("String-ul contine substring-ul precizat!" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Nu am gasit string-ul precizat!" + Environment.NewLine);
            }

            Console.ReadLine();
        }
    }
}
