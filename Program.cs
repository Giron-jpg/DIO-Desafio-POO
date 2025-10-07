using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia telefone1 = new Nokia("41 9999-1234", "Nokia 3310", "12345", 15);
Iphone telefone2 = new Iphone("41 9876-1234", "Iphone 17", "54321", 1500);

telefone1.InstalarAplicativo();
telefone2.InstalarAplicativo();

telefone1.Ligar();
telefone2.Ligar();

telefone1.ReceberLigacao();
telefone2.ReceberLigacao();

Console.WriteLine(telefone1.Numero);
Console.WriteLine(telefone2.Numero);