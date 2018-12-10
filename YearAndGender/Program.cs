using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearAndGender
{
    class Program
    {
        public enum Genders
        {
            M=0,
            F=1
        }

        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            int year;
            int month;
            int day;
            string genderUser;

            Console.WriteLine("Introduceti anul:");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti luna:");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti ziua:");
            day = Convert.ToInt32(Console.ReadLine());

            DateTime birthdate = new DateTime(year, month, day);
            int age = today.Year - birthdate.Year;

            Console.WriteLine("Aveti " + age +" ani :)");

            // In curs de actualizare
            Genders genderEnum = Genders.M;
            int numericValue = (int)genderEnum;

            Console.WriteLine("Introduceti genul: ");
            genderUser = Console.ReadLine();

            if(numericValue==0 && age<=65)
            {
                Console.WriteLine("Sunteti barbat, dar nu v-ati pensionat inca. Mai aveti de muncit inca "+ (65-age) +" ani pana la pensionare");
            }
            else if(genderUser=="M" && age>=65)
            {
                Console.WriteLine("Felicitari, sunteti un barbat pensionar");
            }
            if(genderUser=="F" && age <=63)
            {
                Console.WriteLine("Sunteti femeie, dar nu v-ati pensionat inca.Mai aveti de muncit inca " + (63 - age) + " ani pana la pensionare");
            }
            else if (genderUser == "F" && age >= 63)
            {
                Console.WriteLine("Felicitari, sunteti o femeie pensionara");
            }

            Console.ReadLine();
        }
    }
}
