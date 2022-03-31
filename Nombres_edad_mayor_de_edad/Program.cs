string nombre1;
string nombre2;
int edad1;
int edad2;
string num;

Console.WriteLine("Ingrese el Nombre: ");
nombre1 = Console.ReadLine();
Console.Write("Ingrese  la Edad ==>");
num = Console.ReadLine();
edad1 = int.Parse(num);

Console.WriteLine("Ingrese el Nombre: ");
nombre2 = Console.ReadLine();
Console.Write("Ingrese  la Edad ==>");
num = Console.ReadLine();
edad2 = int.Parse(num);

Console.WriteLine("La Persona Mayor de Edad es: ");

if (edad1 > edad2)
{
    Console.Write(nombre1);
}
else
{
    Console.Write(nombre2);
}
Console.ReadKey(true);