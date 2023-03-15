// See https://aka.ms/new-console-template for more information

string[] favouriteFood = { "Kebab", "Pizza", "Pasta", "Frutta", "Riso" };
Console.WriteLine(favouriteFood.Length);

for ( int i = 0; i < favouriteFood.Length; i++)
{
    Console.WriteLine( (i) + favouriteFood[i] );
}

Console.WriteLine("In poolposition c'è:" + favouriteFood[1]);

Console.WriteLine("In fondo alla classifica c'è:" + favouriteFood[4]);

Console.WriteLine("A metà della classifica c'è:" + favouriteFood[favouriteFood.Length / 2]);


