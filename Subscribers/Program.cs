Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 5 && daysUntilExpiration != 0)
{
    discountPercentage = 10;
    if(daysUntilExpiration <= 1)
    {
        discountPercentage = 50;
    }
    
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} day(s). Your discount is {discountPercentage}% !");
}
else if (daysUntilExpiration >5){
    Console.WriteLine("Your subscription will expire soon. Renew now !");
}
else{
    Console.WriteLine("Your subscription have expired !");
}
