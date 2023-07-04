using System;
using System.ComponentModel.Design;
using System.Text;

Random rnd = new Random();

int num1 = rnd.Next(1, 100);
int num2 = rnd.Next(1, 100);

string teacher1 = "Karel";
string teacher2 = "Hana";
string teacher3 = "Michal";

string[] teachers = { teacher1, teacher2, teacher3 };
char operace = Console.ReadLine()[0];

int randomIndex = rnd.Next(0, teachers.Length);

string exitString = teachers[randomIndex];



foreach (string name in teachers)
{

    string currentTeacher = name;

    if (currentTeacher == "Karel")
        Console.WriteLine($"{exitString}: vrhneme se na prvni priklad");


    else if (currentTeacher == "Hana")
             Console.WriteLine($"{exitString}: pojdme pocitat");

    else if (currentTeacher == "Michal")
        Console.WriteLine($"{exitString}: pojdme na matiku");

}

switch (operace)
{
    
    case '+':
        Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
        Console.WriteLine("Ez");
        break;

    case '-':
        Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
        Console.WriteLine("to je pohoda");
        break;

    case '*':
        Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
        Console.WriteLine("Ok, trochu obtizny");
        break;

    case '/':
        Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
        Console.WriteLine("tak to nedam mistre");
        break;

    default:
        Console.WriteLine("To nejde");
        break;
}    
