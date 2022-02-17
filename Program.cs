// Ex1
// HelloWorld(); 

// Ex2
// TypeOfSomething();

//Ex 3
// CompleteName();

//Ex4 
// Media();
void HelloWorld(){
    Console.WriteLine("Hello World");
};

void TypeOfSomething(){

    var nome = "Claudio";

    Console.WriteLine(nome.GetType());
};

void CompleteName(){
    Console.WriteLine("Olá, qual é seu nome?");
    var nome = Console.ReadLine();
    Console.WriteLine("E seu sobrenome?");
    var sobrenome = Console.ReadLine();
    Console.WriteLine($"Seja bem vindo {nome} {sobrenome}!");
    
};

void Media(){

    var nota1 = 8;
    var nota2 = 5;
    var nota3 = 6;

    var media = (nota1 + nota2 + nota3)/3;
    Console.WriteLine(media);
}

Media();
