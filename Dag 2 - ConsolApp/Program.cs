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

//string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

//Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//fraudulentOrderIDs[0] = "F000";

//Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//string[] names = { "Rowena", "Robin", "Bao" };
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//int[] inventory = { 200, 450, 700, 175, 250 };
//int sum = 0;
//int bin = 0;

//foreach (int items in inventory)
//{
//    sum += items;
//    bin++;
//    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
//}

//Console.WriteLine($"We have {sum} items in inventory.");

//////string[] fraudulentorderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
//////string[] fraudulentOrderIDsWithB = new string[5];
//////int numberOfFraudulentIDsWithB = 0;

//////foreach(string ID in fraudulentorderIDs)
//////{
//////    if (ID.StartsWith("B"))
//////    {
//////        fraudulentOrderIDsWithB[numberOfFraudulentIDsWithB] = ID;
//////        numberOfFraudulentIDsWithB++;
//////    }
//////}
//////foreach (string ID in fraudulentOrderIDsWithB)
//////{
//////    Console.WriteLine(ID);
//////}

/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

//Random random = new Random();
//string[] orderIDs = new string[5];

//for (int i = 0; i < orderIDs.Length; i++)
//{
//    int prefixValue = random.Next(65, 70);
//    string prefix = Convert.ToChar(prefixValue).ToString();
//    string suffix = random.Next(1, 1000).ToString("000");

//    orderIDs[i] = prefix + suffix;
//}

//foreach (var orderID in orderIDs)
//{
//    Console.WriteLine(orderID);
//}

// Example 1:
//Console
//.
//WriteLine
//(
//"Hello Example 1!"
//)
//;

//// Example 2:
//string firstWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(firstWord + " " + lastWord + "!");

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

//string str = "The quick brown fox jumps over the lazy dog.";

//// convert the message into a char array
//char[] charMessage = str.ToCharArray();

//// Reverse the chars
//Array.Reverse(charMessage);
//int x = 0;

//// count the o's
//foreach (char i in charMessage) 
//{ 
//    if (i == 'o') 
//    { 
//        x++; 
//    } 
//}

//// convert it back to a string
//string new_message = new String(charMessage);

//// print it out
//Console.WriteLine(new_message);
//Console.WriteLine($"'o' appears {x} times.");

using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

foreach (string name in studentNames)
{
    if (name == "Sophia")
    {
        int sophiaSum = 0;

        decimal sophiaScore;

        foreach (int score in sophiaScores)
        {
            // add the exam score to the sum
            sophiaSum += score;
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    }
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();