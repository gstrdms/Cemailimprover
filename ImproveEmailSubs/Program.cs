Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes below this line here


if (daysUntilExpiration <= 11)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
    discountPercentage = 0;
}

