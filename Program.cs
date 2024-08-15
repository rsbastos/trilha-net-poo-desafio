using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "11999993333", modelo: "Nokia 2780 Flip", imei: "001970-01-010000-0", memoria: 128);

Console.WriteLine("  ");
Console.WriteLine("----------------------");
Console.WriteLine("   Teste do Nokia");
Console.WriteLine("----------------------");
Console.WriteLine(" ");

Console.WriteLine($"Ligando meu aparelho {nokia.PegarModeloAparelho()} de número {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("Nubank");
nokia.ReceberLigacao();

Smartphone iphone = new Iphone(numero: "11977772222", modelo: "Apple Iphone 12 Pro Max", imei: "356728112023011", memoria: 256);

Console.WriteLine("  ");
Console.WriteLine("----------------------");
Console.WriteLine("   Teste do Iphone");
Console.WriteLine("----------------------");
Console.WriteLine(" ");

Console.WriteLine($"Ligando meu aparelho {iphone.PegarModeloAparelho()} de número {iphone.Numero}");
iphone.Ligar();
iphone.InstalarAplicativo("VLC Media Player");
iphone.ReceberLigacao();
