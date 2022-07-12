using System.Methods;
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

int input;
int inputArrayNo;
int nameOrNumber;
string inputName;
string choice;
string repeatInput;

Console.WriteLine("Welcome to the student database! Students can be searched by name or index number. Pleease enter 1 to search by number, and 2 to search by name:"); //Prompt the user to ask about a particular student by number. Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name
//Allow the user to search by student name
do
{
    nameOrNumber = int.Parse(Console.ReadLine());
    if (nameOrNumber == 1)
    {
        do
        {

            {
                Console.WriteLine("Please enter a number 1-9 to search for the corresponding student, or enter the number 10 to see a list of all students");
                input = int.Parse(Console.ReadLine());
                inputArrayNo = input - 1;
                if ((inputArrayNo < 0) || (inputArrayNo > 9)) //Use an if statement to check if the number is out of range, i.e. either less than 0 or greater than the maximum index of the arrays. If so, display a friendly message and let the user try again.
                {
                    Console.WriteLine("I'm sorry, that is not a valid selection. Please enter a number 1-9");
                }
                if (inputArrayNo == 9)
                {
                    Console.WriteLine(StudentListNumber);
                    Console.WriteLine($"{studentNumber[1]} {studentName[1]}");
                    Console.WriteLine($"{studentNumber[2]} {studentName[2]}");
                    Console.WriteLine($"{studentNumber[3]} {studentName[3]}");
                    Console.WriteLine($"{studentNumber[4]} {studentName[4]}");
                    Console.WriteLine($"{studentNumber[5]} {studentName[5]}");
                    Console.WriteLine($"{studentNumber[6]} {studentName[6]}");
                    Console.WriteLine($"{studentNumber[7]} {studentName[7]}");
                    Console.WriteLine($"{studentNumber[8]} {studentName[8]}");
                }
            }
        } while ((inputArrayNo < 0) || (inputArrayNo > 8));
        if (nameOrNumber == 2)
        {
            Console.WriteLine("Please enter the name of the student you would like to search, or type List to see a list of all students");
            inputName = Console.ReadLine();
        }
        Console.WriteLine($"That's {studentName[inputArrayNo]}, would you like to know their Hometown, or their Favorite Food? Please enter your answer pricesly:"); //Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
        do
        {
            choice = Console.ReadLine();
            if ((choice.ToLower() == "hometown") || (choice.ToLower() == "home") || (choice.ToLower() == "town")) //Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"
            {
                Console.WriteLine($"{ studentName[inputArrayNo]}'s hometown is {homeTown[inputArrayNo]}");
                break;
            }
            if ((choice.ToLower() == "favorite food") || (choice.ToLower() == "favorite") || (choice.ToLower() == "food"))
            {
                Console.WriteLine($"{ studentName[inputArrayNo]}'s favorite food is {favoriteFood[inputArrayNo]}");
                break;
            }
            else
            {
                Console.WriteLine("I'm sorry, that is not a valid choice. Please enter either Hometown or Favorite Food: "); //Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question.
            }
        } while ((choice.ToLower() != "hometown") && (choice.ToLower() != "favorite food"));
    }
    Console.WriteLine("Would you like to look up information on another student? y/n:"); //Ask the user if they would like to learn about another student.
    repeatInput = Console.ReadLine();
} while ((repeatInput.ToLower() == "y"));
Console.WriteLine("Goodbye!");





// "Jacob", "Nathaniel", "Jacqueline", "Nancy", "Alex", "Samuel", "Alice", "Samantha", "Felix" };
