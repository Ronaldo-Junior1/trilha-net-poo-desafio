using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("1123465", "Modelo1", "1111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Candy Crush");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone("1234567", "Modelo2", "2222222", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("X");
