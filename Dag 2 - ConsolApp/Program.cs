//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Random dice = new Random();
//int roll = dice.Next(1, 7);
//Console.WriteLine(roll);

//int result = Random.Next();

//Random dice = new Random();
//int roll1 = dice.Next();
//int roll2 = dice.Next(101);
//int roll3 = dice.Next(50, 101);

//Console.WriteLine($"First roll: {roll1}");
//Console.WriteLine($"Second roll: {roll2}");
//Console.WriteLine($"Third roll: {roll3}");

//dice.Next();

//int firstValue = 700;
//int secondValue = 600;
//int largerValue;

//largerValue = Math.Max(firstValue, secondValue);

//Console.WriteLine(largerValue);

//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    if ((roll1 == roll2) && (roll2 == roll3))
//    {
//        Console.WriteLine("You rolled triples!  +6 bonus to total!");
//        total += 6;
//    }
//    else
//    {
//        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//        total += 2;
//    }
//}

//if (total >= 16)
//{
//    Console.WriteLine("You win a new car!");
//}
//else if (total >= 10)
//{
//    Console.WriteLine("You win a new laptop!");
//}
//else if (total == 7)
//{
//    Console.WriteLine("You win a trip for two!");
//}
//else
//{
//    Console.WriteLine("You win a kitten!");
//}

////////Random random = new Random();
////////int daysUntilExpiration = random.Next(12);
////////int discountPercentage = 0;
////////bool discountAvailable = false;

////////if(daysUntilExpiration > 10)
////////{
////////    Console.WriteLine(""); //this line is not needed, but is here for readability and to show that nothing will happen in this case
////////} 
////////else if(daysUntilExpiration <= 0)
////////{
////////    Console.WriteLine("Your subscription has expired.");
////////}
////////else if(daysUntilExpiration <= 1)
////////{
////////    Console.WriteLine("Your subscription expires within a day!");
////////    discountAvailable = true;
////////    discountPercentage = 20;
////////}
////////else if(daysUntilExpiration <= 5)
////////{
////////    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
////////    discountAvailable = true;
////////    discountPercentage = 10;
////////}
////////else if(daysUntilExpiration <= 10)
////////{
////////    Console.WriteLine("Your subscription will expire soon. Renew now!");
////////}

////////if(discountAvailable)
////////{
////////    Console.WriteLine($"Renew now and save {discountPercentage}%!");
////////}

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");