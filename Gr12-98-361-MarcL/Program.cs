using System;

namespace Gr12_98_361_MarcL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AskForNumberOfItems();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }

        private static void AskForNumberOfItems()
        {
            bool continueLoop = true;
            do
            {
                try
                {
                    Console.WriteLine("Give the number of items. Enter zero to stop.");
                    string stringNumberOfItems = Console.ReadLine();

                    int intNumberOfItems = int.Parse(stringNumberOfItems);

                    if ("0".Equals(stringNumberOfItems))
                    {
                        continueLoop = false;
                    }
                    int discount = CalculateDiscount(intNumberOfItems);
                    Console.WriteLine("Discount is {0}%", discount);
                }
                catch (FormatException)
                {

                    Console.WriteLine("Give a numbers between 1 to 2.147.483.647.");
                }
                catch (OverflowException)
                {

                    Console.WriteLine("Give a numbers between 1 to 2.147.483.647.");
                }
            } while (continueLoop);
        }

        private static int CalculateDiscount(int quantity)
        {
            int discount = 0;

            if (quantity >= 100)
            {
                discount = 20;
            }
            else if (quantity >= 50)
            {
                discount = 15;
            }
            else if (quantity >= 10)
            {
                discount = 10;
            }
            else if (quantity >= 1)
            {
                discount = 5;
            }

            return discount;
        }

    }
}
