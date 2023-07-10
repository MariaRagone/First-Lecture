// See https://aka.ms/new-console-template for more information
//create a variable called x and give it a value of 5

using System.Transactions;

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
//assignment
value = 0;
value = age * 100 - Math.PI;

int assign = 0;
Console.WriteLine(assign);
assign += 2;

//null - nothing will appear in the console
string catName = null;
Console.WriteLine(catName);
catName = "Fluffy";

//nonnullable
//int z = null;

//exercises
//1
Console.WriteLine("Example 1: Enter some text.");
string example1 = Console.ReadLine();
Console.WriteLine(example1);

//2
Console.WriteLine("Example 2: Enter a number");
int example2 = int.Parse(Console.ReadLine());
example2++;
Console.WriteLine(example2);

//3
Console.WriteLine("Example 3: Enter a number.");
double example3 = double.Parse(Console.ReadLine());
example3 += .5;
Console.WriteLine(example3);

//4
Console.WriteLine("Example 4: Enter the first number");
double example4 =  double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
double anotherNumberExp4 = double.Parse(Console.ReadLine());
double sum = example4 + anotherNumberExp4;
Console.WriteLine($"Your 2 numbers multiply up to: {sum}");

//5
Console.WriteLine("Example 5: Enter a number");
double example5 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter another number");
double anotherNumberExp5 = double.Parse(Console.ReadLine());
double product = example5 * anotherNumberExp5;
Console.WriteLine($"Your 2 numbers multiply up to: { product}");