using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\n");

Console.WriteLine("====================================================");
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Mod 1", imei: "11111", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Mod 2", imei: "22222", memoria: 16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine("====================================================");
