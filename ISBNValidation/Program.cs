using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNValidation
{
    class ISBNValidation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The input ISBN is " + args[0] + " and it is {0}", IsValid(args[0]));
        }
        public static Boolean IsValid(String ISBN)
        {
            int antiCounter = 11;
            int sum = 0;
            int counter = 1;
            //could remove - from string ISBN
            //loop from start to end 
            for (int x = 0; x < ISBN.Length; x++)
            {
                //if char is hyphen skip it
                if (ISBN[x] == '-')
                {
                    x++;
                }

                //add digit * 11 - place.  in case of x replace with 10
                if (ISBN[x] == 'X')
                {
                    sum = sum + ((antiCounter - counter) * 10);
                }
                else
                {
                    sum = sum + ((antiCounter - counter) * Convert.ToInt32(ISBN[x]));
                }

                counter++;
            }

            //divide sum by 11.  
            if ((sum % 11) == 0)
            {
                return true;
            }
            else
                return false;
        }

    }
}
