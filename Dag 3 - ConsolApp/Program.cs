//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(!pangram.Contains("fox"));
//Console.WriteLine(!pangram.Contains("cow"));

//int saleAmount = 1001;
//// int discount = saleAmount > 1000 ? 100 : 50;

//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//Random number = new Random(2);
//int coin = number.Next();

//Console.WriteLine($"{(coin == 0 ? "Heads" : "Tails")}");

//string permission = "Admin|Manager";
//int level = 55;

//if (permission.Contains("Admin"))
//{
//    if(level > 55)
//    {
//        Console.WriteLine("Welcome, Super Admin user.");
//    }
//    else
//    {
//        Console.WriteLine("Welcome, Admin user.");
//    }
//}
//else if(permission.Contains("Manager"))
//{
//    if(level >= 20)
//    {
//        Console.WriteLine("Contact an admin for access.");
//    }
//    else
//    {
//        Console.WriteLine("You do not have sufficient privileges.");
//    }
//}
//else
//{
//    Console.WriteLine("You do not have sufficient privileges.");
//}

//bool flag = true;
//int value = 0;

//if (flag)
//{
//    value = 10;
//    Console.WriteLine($"Inside of code block: {value}");
//}

//Console.WriteLine($"Outside of code block: {value}");

//bool flag = true;
//if (flag) Console.WriteLine(flag);
//else if (name == "steve") Console.WriteLine("Found Steve");
//else Console.WriteLine("Found Chuck");

//int[] numbers = { 4, 8, 15, 16, 23, 42 };
//int total = 0;
//bool found = false;

//foreach (int number in numbers)
//{
//    total += number;

//    if (number == 42)
//    {
//        found = true;
//    }
//}

//if (found)
//{
//    Console.WriteLine("Set contains 42");
//}

//Console.WriteLine($"Total: {total}");

//int employeeLevel = 100;
//string employeeName = "John Smith";

//string title = "";

//switch (employeeLevel)
//{
//    case 100:
//    case 200:
//        title = "Senior Associate";
//        break;
//    case 300:
//        title = "Manager";
//        break;
//    case 400:
//        title = "Senior Manager";
//        break;
//    default:
//        title = "Associate";
//        break;
//}

//Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";


//switch (product[0])
//{
//    case "01":
//        type = "Sweat shirt";
//        break;
//    case "02":
//        type = "T-Shirt";
//        break;
//    case "03":
//        type = "Sweat pants";
//        break;
//    default:
//        type = "Other";
//        break;
//}

//switch (product[1])
//{
//    case "BL":
//        color = "Black";
//        break;
//    case "MN":
//        color = "Maroon";
//        break;
//    default:
//        color = "White";
//        break;
//}

//switch (product[0])
//{
//    case "01":
//        size = "Small";
//        break;
//    case "02":
//        size = "Medium";
//        break;
//    case "03":
//        size = "Large";
//        break;
//    default:
//        size = "One Size Fits All";
//        break;
//}

//if (product[2] == "S")
//{
//    size = "Small";
//}
//else if (product[2] == "M")
//{
//    size = "Medium";
//}
//else if (product[2] == "L")
//{
//    size = "Large";
//}
//else
//{
//    size = "One Size Fits All";
//}

//Console.WriteLine($"Product: {size} {color} {type}");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 10; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i += 3)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 7)
//    {
//        break;
//    }
//}

//string[] names = { "Alex", "Eddie", "David", "Michael" };
//for (int i = names.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(names[i]);
//}

//string[] names = { "Alex", "Eddie", "David", "Michael" };
//foreach (var name in names)
//{
//    // Can't do this:
//    if (name == "David")
//    {
//        name = "Sammy";
//    }
//}

//string[] names = { "Alex", "Eddie", "David", "Michael" };
//for (int i = 0; i < names.Length; i++)
//    if (names[i] == "David")
//    {
//        names[i] = "Sammy";
//    }

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//for (int i = 1; i <= 100; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine($"{i} - FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine($"{i} - Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine($"{i} - Buzz");
//    }
//    else
//    {
//        Console.WriteLine($"{i}");
//    }
//}

//Random random = new Random();
//int current = random.Next(1, 11);

///*
//do
//{
//    current = random.Next(1, 11);
//    Console.WriteLine(current);
//} while (current != 7);
//*/

//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");

//Random random = new Random();
//int current = random.Next(1, 11);

//do
//{
//    current = random.Next(1, 11);

//    if (current >= 8)
//    {
//        continue;
//    }

//    Console.WriteLine(current);
//} while (current != 7);


//int heroHP = 10;
//int enemyHP = 10;

//Random random = new Random();
//int damage;

//Console.WriteLine($"A random enemy has appeared! \n You have {heroHP} HP left.\n The enemy has {enemyHP} HP.\n BATTLE!!!!");
//while(true)
//{
//    damage = random.Next(1, 11);
//    enemyHP -= damage;
//    Console.WriteLine($"You attacked for {damage} damage. \n The enemy has {enemyHP} HP left.");
//    if (enemyHP <= 0)
//    {
//        Console.WriteLine("YOU WIN!!!!!");
//        break;
//    }
//    damage = random.Next(1, 11);
//    heroHP -= damage;
//    Console.WriteLine($"The enemy attacked for {damage} damage. \n You have {heroHP} HP left.");
//    if (heroHP <= 0)
//    {
//        Console.WriteLine("YOU DIED");
//        break;
//    }
//}

//string? userInput = "";
//bool validInput = false;
//int chosenNumber = 0;

//Console.WriteLine("Choose a number between 5 and 10, only integers, no decimals");
//while(validInput == false)
//{
//    userInput = Console.ReadLine();
//    if(int.TryParse(userInput, out chosenNumber) == true)
//    {
//        if(chosenNumber <= 10 && chosenNumber >= 5)
//        {
//            validInput = true;
//        }
//        else
//        {
//            Console.WriteLine("Sorry, that input is invalid, please Choose a number between 5 and 10, only integers, no decimals or letters");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Sorry, that input is invalid, please Choose a number between 5 and 10, only integers, no decimals or letters");
//    }
//}

//Console.WriteLine($"Your input, {chosenNumber}, was valid and has been accepted");

//string? userInput = "";
//bool validInput = false;

//Console.WriteLine("What is your role, Administrator, Manager or User?");
//while (validInput == false)
//{
//    userInput = Console.ReadLine();
//    userInput = userInput.Trim().ToLower();
//    if (userInput.Contains("admin") || userInput.Contains("manager") || userInput.Contains("user"))
//    {
//        validInput = true;
//    }
//    else
//    {
//        Console.WriteLine("Sorry, that input is invalid, please Choose Administrator, Manager or User.");
//    }
//}

//Console.WriteLine($"Welcome, {userInput}, your role input has been accepted.");