﻿// Ex1
// HelloWorld(); 

// Ex2
// TypeOfSomething();

//Ex 3
// CompleteName();

//Ex4 
// Media();

//Ex5

// Ex6
// NomeAoContrario();

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


void Arredonda(){
    Console.WriteLine("Digite um numero que deseja arredondar:");
    var numero = Console.ReadLine();
    

    var numeroArredondato = double.Parse(numero);
   Console.WriteLine(numeroArredondato);
   

};

void NomeAoContrario(){
    Console.WriteLine("Digite seu Nome");

    var nome = Console.ReadLine();
    var nomeInvertido = new string(nome.Reverse().ToArray());
    Console.WriteLine($"Seu nome possui {nome.Length} e fica {nomeInvertido} ao contrario ");
    
}
NomeAoContrario();