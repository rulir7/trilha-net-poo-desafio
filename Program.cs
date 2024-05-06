using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Criando um objeto da classe Nokia
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 128);

// Testando os métodos da classe Nokia
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

// Criando um objeto da classe Iphone
Iphone iphone = new Iphone("987654321", "Iphone X", "ABCDEFGHIJKLMNOP", 256);

// Testando os métodos da classe Iphone
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("FaceTime");

Console.WriteLine("Testes concluídos. Pressione qualquer tecla para sair...");
Console.ReadKey();