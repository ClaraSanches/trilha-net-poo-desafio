using System.Data;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Iphone("12346", "14", "1645871", 132);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia("78910", "A30", "45668874", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");