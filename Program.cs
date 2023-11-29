using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Celular Iphone!");
Iphone numeroIphone1 = new Iphone(numero: "94081-xxxx", modelo: "XII", imei: "123456", memoria: 256);
numeroIphone1.ReceberLigacao();
numeroIphone1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Celular Nokia!");
Nokia nokia = new Nokia(numero: "95468-xxxx", modelo: "NK75", imei: "123456", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");


