using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Aparelho Iphone");
Smartphone iphone = new Iphone (numero:"17992664042", modelo:"15 Plus", iMEI:"14015", memoria:8 );
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Aparelho Nokia");
Smartphone nokia = new Nokia (numero: "17991572531", modelo:"Nokia Por1", iMEI:"1533", memoria: 4);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

