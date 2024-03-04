


using System;

class Program
{
    static void Main()
    {
        do
        {
            double ethAmount;
            double commissionRate;
            double ethPrice;
            double commissionTotal;
            bool stakeETH;
            double monthlyReward;
            double totalPurchased;

            Console.WriteLine("---- Crypto ETH Portfolio----");
            Console.WriteLine();
            Console.WriteLine("Current ETH spot price is $3,408.87");
            Console.WriteLine();

            try
            {
                do
                {
                    Console.Write("Enter Amount of ETH to purchase: ");
                    while (!double.TryParse(Console.ReadLine(), out ethAmount) || ethAmount < 0)
                    {
                        Console.WriteLine("Input invalid. Please enter a non-negative valid number.");
                    }
                } while (ethAmount < 0);

                Console.WriteLine("Current stake rate is 3.100%");
                Console.WriteLine();

                Console.Write("Stake your ETH (yes/no): ");
                stakeETH = Console.ReadLine().ToLower() == "yes";

                ethPrice = new Random().NextDouble() * (2999.99 - 2600.00) + 2600;

                if (ethAmount >= 0.00001 && ethAmount < 1)
                {
                    commissionRate = 0.019;
                }
                else if (ethAmount < 5)
                {
                    commissionRate = 0.0175;
                }
                else if (ethAmount < 10)
                {
                    commissionRate = 0.015;
                }
                else
                {
                    commissionRate = 0.0125;
                }

                commissionTotal = ethAmount * ethPrice * commissionRate;

                Console.WriteLine("Please review your order ...  ");
                Console.WriteLine();
                Console.WriteLine($"Total ETH purchased:        {ethAmount:F6}");
                Console.WriteLine();
                Console.WriteLine($"Eth Spot Price:             ${ethPrice:F2}");
                Console.WriteLine();
                Console.WriteLine($"Commission Rate:            {commissionRate:P}");
                Console.WriteLine();
                Console.WriteLine($"Total Commission:           ${commissionTotal:F2}");
                Console.WriteLine();

                if (stakeETH)
                {
                    monthlyReward = ethAmount * ethPrice * 0.031 / 12;
                    Console.WriteLine($"Monthly Reward:             ${monthlyReward:F2}");
                }
                else
                {
                    Console.WriteLine("Stacked? no");
                }

                Console.WriteLine();
                Console.WriteLine("---------------------------------------");

                // Calculate totalPurchased
                totalPurchased = ethAmount * ethPrice + commissionTotal;

                Console.WriteLine($"Total Purchased: ${totalPurchased:F2}");

                Console.WriteLine("Confirm the order? (yes/no)");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("Order Confirmed! Thank you for your order.");
                }
                else
                {
                    Console.WriteLine("Order canceled.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                Console.WriteLine("Please try again");
            }

            Console.WriteLine("Would you like to continue with your order (yes/no)?");
        } while (Console.ReadLine().ToLower() == "yes");

        Console.WriteLine("Thank you for using Crypto ETH Portfolio");

        Console.ReadKey();  // Wait for a key press before closing the console window
    }
}