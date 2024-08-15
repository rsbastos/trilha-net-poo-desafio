using DesafioPOO.Models;

Smartphone iphone = new Iphone(numero: "11999993333", modelo: "Nokia 2780 Flip", imei: "001970-01-010000-0", memoria: 128);

Console.WriteLine(iphone.Numero);

iphone.Ligar();
iphone.InstalarAplicativo("Nubank");
iphone.ReceberLigacao();
