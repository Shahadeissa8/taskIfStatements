//Shahad Eissa
//1. Languages
Console.WriteLine("enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("enter your language: ");
string language = Console.ReadLine();
if (language == "en")
{
    Console.WriteLine("Hello " + name);
}
else if (language == "es")
{
    Console.WriteLine("Hola " + name);
}
else if (language == "fr")
{
    Console.WriteLine("Bonjour " + name);
}
else if (language == "tr")
{
    Console.WriteLine("Merhaba " + name);
}

Console.WriteLine("========================================");

//2. Max Number
Console.WriteLine("enter your first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("the bigger number is " + num1);
}
else if (num1 < num2)
{
    Console.WriteLine("the bigger number is " + num2);
}

Console.WriteLine("========================================");

//3. Mark
Console.WriteLine("enter your mark ");
int mark = Convert.ToInt32(Console.ReadLine());
if (mark >= 80)
{
    Console.WriteLine("your grade is A");
}
else if (mark >=70 && mark< 80)
{
    Console.WriteLine("your grade is B");
}
else if (mark >=  60 && mark < 70)
{
    Console.WriteLine("your grade is C");
}else if (mark >= 50 && mark <60)
{
    Console.WriteLine("your grade is D");
}else 
{
    Console.WriteLine("your grade is F");
}