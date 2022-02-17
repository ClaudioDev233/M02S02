// Ex1
// HelloWorld(); 

// Ex2
// TypeOfSomething();

//Ex 3
// CompleteName();

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

