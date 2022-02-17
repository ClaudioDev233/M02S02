// Ex1
// HelloWorld(); 

// Ex2
// TypeOfSomething();

//Ex 3
// CompleteName();

//Ex4 
// Media();

//Ex5
// Arredonda();

// Ex6
// NomeAoContrario();

//Ex7
// MediaAluno();

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
    var numero = float.Parse(Console.ReadLine());
    
   Console.WriteLine(Math.Round(numero));
   
};

void NomeAoContrario(){
    Console.WriteLine("Digite seu Nome");

    var nome = Console.ReadLine();
    var nomeInvertido = new string(nome.Reverse().ToArray());
    Console.WriteLine($"Seu nome possui {nome.Length} e fica {nomeInvertido} ao contrario ");
    
}

void MediaAluno(){

    Console.WriteLine("Digite sua nota :");
    var nota1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua nota :");
    var nota2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua nota :");
    var nota3 = float.Parse(Console.ReadLine());

    var media = (nota1 + nota2+nota3)/3;
    Console.WriteLine($"Sua média final é {media.ToString("F")}");
}

void Fatorial(){

    Console.WriteLine("Digite um número de 1 a 10");
    var numero = int.Parse(Console.ReadLine());
   var fatorial = numero;
    Console.WriteLine("-----------------");
    if(numero < 0 || numero > 10)
    Console.WriteLine("Numero não aceito");
    else 
    

    for ( int i = numero -1  ; i >= 0 ; i--){
        Console.WriteLine( fatorial *= i );
    }

}
Fatorial();