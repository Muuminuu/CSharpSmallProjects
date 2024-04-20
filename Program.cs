Random dice = new Random();

int roll1 ;
int roll2 ;
int roll3 ;

int total = 0;


while(total < 15)
{
    roll1 = dice.Next(1, 7);
    roll2 = dice.Next(1, 7);
    roll3 = dice.Next(1, 7);
    total = roll1 + roll2 + roll3;

    Console.WriteLine($"Dice roll: {roll1}, {roll2}, {roll3} = {total}");


    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    {

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples ! +6 bonus to total !!");
            total += 6;
        }
        else
        {
            Console.WriteLine("You rolled doubles ! +2 bonus to total !!");
            total += 2;
        }
    }
    if(total < 15)
    {
        Console.WriteLine($"{total} - Sorry, you lose!");
    }
}


if(total >= 15)
{
    Console.WriteLine($"{total} - You win!");
}


