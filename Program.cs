//Heba Derawi, NET23

int nummer = 15; //Ger ett värde till variabeln

if (nummer > 10) // Om värdet är över 10 
{
    Console.WriteLine("Talet är stort!"); //utskrift
}
else
{
    Console.WriteLine("Oj lågt tal!"); // Om värdet ej är över 10
}

Console.WriteLine("Vad heter du?");
var namn = Console.ReadLine(); // Användaren skriver in namn
Console.WriteLine("Hej" + namn + "!");

for (int i = 0; i <= nummer; i = i + 1) // En for loop som skriver ut 0-15.
{
    Console.WriteLine(i);
}