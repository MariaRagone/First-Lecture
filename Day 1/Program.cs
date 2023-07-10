// See https://aka.ms/new-console-template for more information
//create a variable called x and give it a value of 5

int age = 5;
string name = "Justin";
string name2 = "Ethan";
/*
 * validate the number variable
 * do something if validated
 */
if (age == 1)
{

}

//declaring variables
int money;
//intialize variable
money = 5;
//combined
bool hungry = true;

//constant
const double taxRate = 0.06;
// taxRate = 6; // not allowed to change constants
//Console.WriteLine(taxRate);
Console.WriteLine("Please enter a radius: ");
//string entry = Console.ReadLine();
//double value = double.Parse(entry);
double value = double.Parse(Console.ReadLine());
// pie * value * value
double area = Math.PI * Math.Pow(value, 2);
Console.WriteLine(area);
//increment/decrementing
age++;
age--;
//odd or even
Console.WriteLine("Please enter a number: ");
int input = int.Parse(Console.ReadLine());
int oddCheck = input % 2;
if (oddCheck == 0)
{
    Console.WriteLine("even");
}
else if (oddCheck == 1)
{
    Console.WriteLine("odd");
}
