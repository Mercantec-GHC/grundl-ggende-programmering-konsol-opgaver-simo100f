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

//using System;

//// initialize variables - graded assignments 
//int examAssignments = 5;

//int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
//int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
//int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
//int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
//int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
//int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
//int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
//int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

//// Student names
//string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
//int[] studentScores = new int[10];
//string currentStudentLetterGrade = "";

//Console.WriteLine("Student\t\tGrade\n");

//foreach (string name in studentNames)
//{
//    string currentStudent = name;

//    if (currentStudent == "Sophia")
//    {
//        studentScores = sophiaScores;
//    }
//    else if (currentStudent == "Andrew")
//    {
//        studentScores = andrewScores;
//    }
//    else if (currentStudent == "Emma") 
//    {
//        studentScores = emmaScores;
//    }
//    else if (currentStudent == "Logan")
//    {
//        studentScores = loganScores;
//    }
//    else if (currentStudent == "Becky")
//    {
//        studentScores = beckyScores;
//    }
//    else if (currentStudent == "Chris")
//    {
//        studentScores = chrisScores;
//    }
//    else if (currentStudent == "Eric")
//    {
//        studentScores = ericScores;
//    }
//    else if (currentStudent == "Gregor")
//    {
//        studentScores = gregorScores;
//    }
//    else
//    {
//        continue;
//    }

//    int sumAssignmentScores = 0;
//    decimal currentStudentGrade = 0;
//    int gradedAssignments = 0;

//    foreach (int score in studentScores)
//    {
//        // increment the assignment counter
//        gradedAssignments += 1;

//        if (gradedAssignments <= examAssignments)
//        {
//            // add the exam score to the sum
//            sumAssignmentScores += score;
//        }
//        else
//        {
//            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
//            sumAssignmentScores += score / 10;
//        }
//    }

//    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

//    if (currentStudentGrade >= 97)
//    {
//        currentStudentLetterGrade = "A+";
//    }
//    else if (currentStudentGrade >= 93)
//    {
//        currentStudentLetterGrade = "A";
//    }
//    else if (currentStudentGrade >= 90)
//    {
//        currentStudentLetterGrade = "A-";
//    }
//    else if (currentStudentGrade >= 87)
//    {
//        currentStudentLetterGrade = "B+";
//    }
//    else if (currentStudentGrade >= 83)
//    {
//        currentStudentLetterGrade = "B";
//    }
//    else if (currentStudentGrade >= 80)
//    {
//        currentStudentLetterGrade = "B-";
//    }
//    else if (currentStudentGrade >= 77)
//    {
//        currentStudentLetterGrade = "C+";
//    }
//    else if (currentStudentGrade >= 73)
//    {
//        currentStudentLetterGrade = "C";
//    }
//    else if (currentStudentGrade >= 70)
//    {
//        currentStudentLetterGrade = "C-";
//    }
//    else if (currentStudentGrade >= 67)
//    {
//        currentStudentLetterGrade = "D+";
//    }
//    else if (currentStudentGrade >= 63)
//    {
//        currentStudentLetterGrade = "D";
//    }
//    else if (currentStudentGrade >= 60)
//    {
//        currentStudentLetterGrade = "D-";
//    }
//    else
//    {
//        currentStudentLetterGrade = "F";
//    }

//    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
//}

//Console.WriteLine("Press the Enter key to continue");
//Console.ReadLine();

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
using System;

int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }

    decimal currentStudentGrade = 0;
    decimal examScore = 0;
    decimal extraCredit = 0;
    decimal extraCreditPoints = 0;
    decimal sumAssignmentScores = 0;

    int sumExamScore = 0;
    int extraCreditSum = 0;
    int gradedAssignments = 0;
    int extraCreditAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
            sumExamScore += score;
            //Console.WriteLine(sumAssignmentScores);
            //Console.WriteLine((decimal)(sumAssignmentScores)/examAssignments);
            //Console.WriteLine(sumExamScore);
            //Console.WriteLine((decimal)(sumExamScore) / examAssignments);
        }
        else
        {
            extraCreditSum += score;

            if (score != 0)
            {
                extraCreditAssignments++;
            }
        }

    }
    sumAssignmentScores += ((decimal)(extraCreditSum) / 10);
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    examScore = (decimal)(sumExamScore) / examAssignments;
    extraCredit = (decimal)(extraCreditSum) / extraCreditAssignments;
    extraCreditPoints = currentStudentGrade - examScore;


    if (currentStudentGrade >= 97)
    {
        currentStudentLetterGrade = "A+";
    }
    else if (currentStudentGrade >= 93)
    {
        currentStudentLetterGrade = "A";
    }
    else if (currentStudentGrade >= 90)
    {
        currentStudentLetterGrade = "A-";
    }
    else if (currentStudentGrade >= 87)
    {
        currentStudentLetterGrade = "B+";
    }
    else if (currentStudentGrade >= 83)
    {
        currentStudentLetterGrade = "B";
    }
    else if (currentStudentGrade >= 80)
    {
        currentStudentLetterGrade = "B-";
    }
    else if (currentStudentGrade >= 77)
    {
        currentStudentLetterGrade = "C+";
    }
    else if (currentStudentGrade >= 73)
    {
        currentStudentLetterGrade = "C";
    }
    else if (currentStudentGrade >= 70)
    {
        currentStudentLetterGrade = "C-";
    }
    else if (currentStudentGrade >= 67)
    {
        currentStudentLetterGrade = "D+";
    }
    else if (currentStudentGrade >= 63)
    {
        currentStudentLetterGrade = "D";
    }
    else if (currentStudentGrade >= 60)
    {
        currentStudentLetterGrade = "D-";
    }
    else
    {
        currentStudentLetterGrade = "F";
    }


    // Student         Grade
    // Sophia:         92.2    A-

    Console.WriteLine($"{currentStudent}\t\t{examScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{extraCredit}({extraCreditPoints} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
