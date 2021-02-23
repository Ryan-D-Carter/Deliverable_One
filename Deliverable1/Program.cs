using System;

namespace Deliverable1
{
    class Program
    {
        public static double convertAmount;
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Imperial to  MilHip Converter!");

                Console.WriteLine("Please enter a measurement type. (EX: 'foot','inch','fidget spinner', 'meme')");

                string measurementInput = Console.ReadLine();

                Console.WriteLine("Please an enter an amount you would like to convert.");

                double amount = double.Parse(Console.ReadLine());

                switch (measurementInput)
                {
                    case "inch":
                        convertAmount = amount * 3.5;
                        Console.WriteLine($"{amount} inches is equal to {convertAmount} fidget spinners!");
                        break;

                    case "foot":
                        convertAmount = amount * 5;
                        Console.WriteLine($"{amount} feet is equal to {convertAmount} memes!");
                        break;

                    case "fidget spinner":
                        convertAmount = amount / 3.5;
                        Console.WriteLine($"{amount} fidget spinners is equal to {convertAmount} inches");
                        break;

                    case "meme":
                        convertAmount = amount / 5;
                        Console.WriteLine($"{amount} memes is equal to {convertAmount} feet");
                        break;

                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }
                Console.WriteLine("Would you like to do another calculation? y/n");
                var answer = Console.ReadLine();

                repeat = answer.ToLower() == "y";
            }
        }
    }
}
