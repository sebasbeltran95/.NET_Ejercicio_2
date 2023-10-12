// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var radio = 0d;
var resultado = 0d;

const double Pi = 3.14;

const double SiempreSeEscribeAsi = 200.0d;

Console.WriteLine("bienvenido calculemos circulos");
// PI * radio *  radio

Console.WriteLine("ingrese el valor del radio");
 //double radio = Convert.ToDouble(Console.ReadLine());
 radio = Convert.ToDouble(Console.ReadLine());

//resultado = Math.PI * radio * radio;
resultado = Pi * radio * radio;

Console.WriteLine(" El area de tu circulo es de: " + resultado);