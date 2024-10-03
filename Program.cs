class CrimsonCrust
{    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("\nCrimson Crust Pizza Menu:");
            Console.WriteLine("1. No toppings");
            Console.WriteLine("2. Cheese Pizza");
            Console.WriteLine("3. Pepperoni Pizza");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
          
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Choice not valid, please try again.");
                continue;
            }
            
            switch (choice)
            {
                case 1:
                    NoToppings();
                    break;
                case 2:
                    CheesePizza();
                    break;
                case 3:
                    PepperoniPizza();
                    break;
                case 4:
                    Console.WriteLine("Thank you. Please come again!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void NoToppings()
    {
        Random rand = new Random();
        int rows = rand.Next(8, 13);  

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    static void CheesePizza()
    {
        Random rand = new Random();
        int rows = rand.Next(8, 13);  

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j == 1 || j == i || i == rows)  
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }
    static void PepperoniPizza()
    {
        Random rand = new Random();
        int rows = rand.Next(8, 13);  

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j == 1 || j == i || i == rows)  
                {
                    Console.Write("*");
                }
                else if (rand.Next(0, 5) == 0)
                {
                    Console.Write("[]");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }
}