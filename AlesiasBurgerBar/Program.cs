using System;

namespace AlesiasBurgerBar
{
    class Program
    {

        static void Main(string[] args)
        {
            var menuItem = " ";
            var burgerCounter = "";
            var sodaCounter = "";
            double subtotal = 0;
            double total = 0;
            do
            {
                Console.WriteLine("1. Burger\n2. Soda \n3. Exit");
                menuItem = Console.ReadLine();
                            if (menuItem=="1")
                            {
                                burgerCounter = burgerCounter + "*";
                            }
                            if(menuItem=="2")
                            {
                                sodaCounter = sodaCounter + "*";
                            }
                if (menuItem != "1" && menuItem != "2" && menuItem != "3")
                {
                    Console.WriteLine("Sorry I didn't understand, let's try again");
                }
            }
            while (menuItem != "3");

            Console.WriteLine("Burgers: " + burgerCounter);
            Console.WriteLine("Sodas: " + sodaCounter);
            subtotal=CalculateSubTotal(burgerCounter,sodaCounter);
            Console.WriteLine($"Subtotal:  {subtotal:c}");// {subtotal:c} formats currency with string interpolation
            total = CalculateTotalWithTax(subtotal);
            Console.WriteLine( $"Your order total with tax is: {total:c}" );
        }

        public static double CalculateSubTotal(string burgerCounter, string sodaCounter)
        {
            double burger = 2.50;
            double soda = 1.25;
            double subTotal = 0;

            for(int Starcounter = 0; Starcounter<burgerCounter.Length; Starcounter++)
            {
                subTotal = subTotal + burger;
            }
            for (int Starcounter = 0; Starcounter < sodaCounter.Length; Starcounter++)
            {
                subTotal = subTotal + soda;
            }

            return subTotal;
        }

        private static double CalculateTotalWithTax(double subtotal)
        {
            double total = 0;
            double tax = .07;
            total = ((tax * subtotal) + subtotal);
            return total;
        }






    }
}
