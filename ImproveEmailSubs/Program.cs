Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes below this line here.
daysUntilExpiration = 8;

     if (daysUntilExpiration >= 11)
         Console.WriteLine("Your subscription will expire soon. Renew now!");

         else if (daysUntilExpiration >= 6)
         {
            Console.WriteLine("Your subscription expires in ",daysUntilExpiration,"days.");
            Console.WriteLine("Renew now and save ",discountPercentage + 10,"%!");
         } 

        