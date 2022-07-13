//Arrays
string[] studentName = new string[9]; //Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
studentName[0] = "Jacob"; //Use the first array’s Length property in your code instead of hardcoding it.
studentName[1] = "Nathaniel";
studentName[2] = "Jacqueline";
studentName[3] = "Nancy";
studentName[4] = "Alex";
studentName[5] = "Samuel";
studentName[6] = "Alice";
studentName[7] = "Samantha";
studentName[8] = "Felix";
string[] homeTown = new string[9];
homeTown[0] = "Detroit";
homeTown[1] = "Lansing";
homeTown[2] = "New York City";
homeTown[3] = "Salt Lake City";
homeTown[4] = "Seattle";
homeTown[5] = "Phoenix";
homeTown[6] = "Cleveland";
homeTown[7] = "San Fransisco";
homeTown[8] = "St. Louis";
string[] favoriteFood = new string[9];
favoriteFood[0] = "Burritos";
favoriteFood[1] = "Apples";
favoriteFood[2] = "Chicken Stir Fry";
favoriteFood[3] = "Pizza";
favoriteFood[4] = "Cucumbers";
favoriteFood[5] = "Turkey Subs";
favoriteFood[6] = "Spaghetti";
favoriteFood[7] = "Sushi";
favoriteFood[8] = "Ice Cream";
int[] studentNumber = new int[9];
studentNumber[0] = 1;
studentNumber[1] = 2;
studentNumber[2] = 3;
studentNumber[3] = 4;
studentNumber[4] = 5;
studentNumber[5] = 6;
studentNumber[6] = 7;
studentNumber[7] = 8;
studentNumber[8] = 9;

//Variables
int input;
int nameOrNumber;
int inputArrayNo;
string name;
string choice;
string repeatInput = "";

//Methods
string StudentListNumber(int num)
{
    string numAndName = "";
    for (int i = 0; i < studentNumber.Length; i++)
    {
        numAndName = $"{studentNumber[i]} {studentName[i]}";
        Console.WriteLine(numAndName);
    }
    return "";
}
string StudentHomeTown(string name)
{
    int inputArrayNoTwo = 0;
    if (name == studentName[0].ToLower())
    {
        inputArrayNoTwo = 0;
    }
    if (name == studentName[1].ToLower())
    {
        inputArrayNoTwo = 1;
    }
    if (name == studentName[2].ToLower())
    {
        inputArrayNoTwo = 2;
    }
    if (name == studentName[3].ToLower())
    {
        inputArrayNoTwo = 3;
    }
    if (name == studentName[4].ToLower())
    {
        inputArrayNoTwo = 4;
    }
    if (name == studentName[5].ToLower())
    {
        inputArrayNoTwo = 5;
    }
    if (name == studentName[6].ToLower())
    {
        inputArrayNoTwo = 6;
    }
    if (name == studentName[7].ToLower())
    {
        inputArrayNoTwo = 7;
    }
    if (name == studentName[8].ToLower())
    {
        inputArrayNoTwo = 8;
    }
    string studentHome = $"{studentName[inputArrayNoTwo]}'s hometown is {homeTown[inputArrayNoTwo]}.";
    Console.WriteLine(studentHome);
    return "";
}

string StudentHomeTownNum(int num)
{
    string studentHome = $"{studentName[num]}'s hometown is {homeTown[num]}.";
    Console.WriteLine(studentHome);
    return "";
}

string StudentFavoriteFood(string name)
{
    int inputArrayNoThree = 0;
    if (name == studentName[0].ToLower())
    {
        inputArrayNoThree = 0;
    }
    if (name == studentName[1].ToLower())
    {
        inputArrayNoThree = 1;
    }
    if (name == studentName[2].ToLower())
    {
        inputArrayNoThree = 2;
    }
    if (name == studentName[3].ToLower())
    {
        inputArrayNoThree = 3;
    }
    if (name == studentName[4].ToLower())
    {
        inputArrayNoThree = 4;
    }
    if (name == studentName[5].ToLower())
    {
        inputArrayNoThree = 5;
    }
    if (name == studentName[6].ToLower())
    {
        inputArrayNoThree = 6;
    }
    if (name == studentName[7].ToLower())
    {
        inputArrayNoThree = 7;
    }
    if (name == studentName[8].ToLower())
    {
        inputArrayNoThree = 8;
    }
    string studentFav = $"{studentName[inputArrayNoThree]}'s Favorite Food is {favoriteFood[inputArrayNoThree]}.";
    Console.WriteLine(studentFav);
    return "";
}

string StudentFavoriteFoodNum(int num)
{
    string studentFav = $"{studentName[num]}'s Favorite Food is {favoriteFood[num]}.";
    Console.WriteLine(studentFav);
    return "";
}

//Program
do
{ 
    Console.WriteLine("Welcome to the student database! Students can be searched by index number or name. Please enter 1 to search by number, and 2 to search by name:"); //Prompt the user to ask about a particular student by number. Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name
    do
    {
        nameOrNumber = int.Parse(Console.ReadLine());
        if ((nameOrNumber != 1) && (nameOrNumber != 2))
        {
            Console.WriteLine("That is an invalid input. Please select 1 to look up a student by number, or 2 to look up a student by name:");
        }
        if (nameOrNumber == 1)
            do
            {
                do
                {
                    Console.WriteLine("Please enter a number 1-9 to search for the corresponding student, or enter the number 10 to see a list of all students");
                    input = int.Parse(Console.ReadLine());
                    inputArrayNo = (input - 1);
                    if ((inputArrayNo >= 0) && (inputArrayNo < 9))
                    {
                        Console.WriteLine($"That's {studentName[inputArrayNo]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                    }
                    if (inputArrayNo == 9)
                    {
                        Console.WriteLine(StudentListNumber(0));
                    }
                    if ((inputArrayNo < 0) || (inputArrayNo > 9)) //Use an if statement to check if the number is out of range, i.e. either less than 0 or greater than the maximum index of the arrays. If so, display a friendly message and let the user try again.
                    {
                        Console.WriteLine("I'm sorry, that is not a valid selection. Please enter a number 1-9, or enter 10 to see a list of all students:");
                    }
                } while ((inputArrayNo < 0) || (inputArrayNo > 9) || (inputArrayNo == 9));
                do
                {
                    choice = Console.ReadLine();
                    if ((choice.ToLower() == "hometown") || (choice.ToLower() == "home") || (choice.ToLower() == "town")) //Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"
                    {
                        StudentHomeTownNum(inputArrayNo);
                        break;
                    }
                    if ((choice.ToLower() == "favorite food") || (choice.ToLower() == "favorite") || (choice.ToLower() == "food"))
                    {
                        StudentFavoriteFoodNum(inputArrayNo);
                        break;
                    }
                    if ((choice.ToLower() != "hometown") && (choice.ToLower() != "home") && (choice.ToLower() != "town") && (choice.ToLower() != "favorite food") && (choice.ToLower() != "favorite") && (choice.ToLower() != "food"))
                    {
                        Console.WriteLine("I'm sorry, that is not a valid choice. Please enter either Hometown or Favorite Food: "); //Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question.
                    }
                } while ((choice.ToLower() != "hometown") && (choice.ToLower() != "favorite food"));
            } while ((inputArrayNo < 0) || (inputArrayNo > 8));
        if (nameOrNumber == 2) //Allow the user to search by student name
            do
            {
                do
                {
                    Console.WriteLine("Please enter the name of the student you would like to search, or type List to see a list of all students");
                    name = Console.ReadLine();
                    if (name.ToLower() == "list")
                    {
                        Console.WriteLine(StudentListNumber(0));
                    }
                    if ((name.ToLower() != "list") && (name != studentName[0].ToLower()) && (name != studentName[1].ToLower()) && (name != studentName[2].ToLower()) && (name != studentName[3].ToLower()) && (name != studentName[4].ToLower()) && (name != studentName[5].ToLower()) && (name != studentName[6].ToLower()) && (name != studentName[7].ToLower()) && (name != studentName[8].ToLower()))
                    {
                        Console.WriteLine("I'm sorry, that is not a valid choice, please enter the name of the student you would like to search, or type List to see a list of all students:");
                    }
                    if ((name == studentName[0].ToLower()) || (name == studentName[1].ToLower()) || (name == studentName[2].ToLower()) || (name == studentName[3].ToLower()) || (name == studentName[4].ToLower()) || (name == studentName[5].ToLower()) || (name == studentName[6].ToLower()) || (name == studentName[7].ToLower()) || (name == studentName[8].ToLower()))
                    
                        if (name == studentName[0].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[0]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                        if (name == studentName[1].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[1]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                        if (name == studentName[2].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[2]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                        if (name == studentName[3].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[3]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                        if (name == studentName[4].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[4]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                        if (name == studentName[5].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[5]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                        if (name == studentName[6].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[6]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                        if (name == studentName[7].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[7]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                        if (name == studentName[8].ToLower())
                        {
                            Console.WriteLine($"That's {studentName[8]}, would you like to know their Hometown, or their Favorite Food? Please select:");
                        }
                } while ((name != studentName[0].ToLower()) && (name != studentName[1].ToLower()) && (name != studentName[2].ToLower()) && (name != studentName[3].ToLower()) && (name != studentName[4].ToLower()) && (name != studentName[5].ToLower()) && (name != studentName[6].ToLower()) && (name != studentName[7].ToLower()) && (name != studentName[8].ToLower()));
                if ((name == studentName[0].ToLower()) || (name == studentName[1].ToLower()) || (name == studentName[2].ToLower()) || (name == studentName[3].ToLower()) || (name == studentName[4].ToLower()) || (name == studentName[5].ToLower()) || (name == studentName[6].ToLower()) || (name == studentName[7].ToLower()) || (name == studentName[8].ToLower())) 
                {
                    do
                    {
                        choice = Console.ReadLine();
                        if ((choice.ToLower() == "hometown") || (choice.ToLower() == "home") || (choice.ToLower() == "town")) //Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"
                        {
                            StudentHomeTown(name);
                        }
                        if ((choice.ToLower() == "favorite food") || (choice.ToLower() == "favorite") || (choice.ToLower() == "food"))
                        {
                            StudentFavoriteFood(name);
                        }
                        else if ((choice.ToLower() != "hometown") && (choice.ToLower() != "home") && (choice.ToLower() != "town") && (choice.ToLower() != "favorite food") && (choice.ToLower() != "favorite") && (choice.ToLower() != "food"))
                        {
                            Console.WriteLine("I'm sorry, that is not a valid choice. Please enter either Hometown or Favorite Food: "); //Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question.
                        }
                    } while ((choice.ToLower() != "hometown") && (choice.ToLower() != "favorite food") && (choice.ToLower() != "home") & (choice.ToLower() != "town") && (choice.ToLower() != "favorite") && (choice.ToLower() != "food"));
                }
            } while ((name.ToLower() == "list") && ((name != studentName[0].ToLower()) && (name != studentName[1].ToLower()) && (name != studentName[2].ToLower()) && (name != studentName[3].ToLower()) && (name != studentName[4].ToLower()) && (name != studentName[5].ToLower()) && (name != studentName[6].ToLower()) && (name != studentName[7].ToLower()) && (name != studentName[8].ToLower())));
    } while ((nameOrNumber != 1) && (nameOrNumber !=2));
    //Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
    Console.WriteLine("Would you like to enter another search? y/n:"); //Ask the user if they would like to learn about another student.
    repeatInput = Console.ReadLine();
} while((repeatInput.ToLower() == "y")) ;
Console.WriteLine("Goodbye!");