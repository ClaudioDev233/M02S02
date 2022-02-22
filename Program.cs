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

//Ex8
// Fatorial();

//Ex9
//Pizza();
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
    var numeroArredondado =1;
    var numero = Int32.TryParse(Console.ReadLine(), out numeroArredondado);
   Console.WriteLine(numeroArredondado);
   
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

void Pizza(){

    var pedaco = 0;
     var pizza ="";
    

     while (pizza != "0"){
Console.WriteLine("Escolha um sabor de pizza: Digite 1 para Mussarela, 2 Para Calabresa e 3 para Portuguesa, se estiver satisfeito digite 0");
   pizza = (Console.ReadLine());
    
    if(pizza !="0")
    pedaco+=1 ;
     else
Console.WriteLine($"Você comeu {pedaco} pedaços");
}}


void TodasNotas(){
    Random numero = new Random();
    List <int> notas = new List <int>(); 
    List <string> alunos = new List <string>(); 

    List <int> maiorNota = new List <int>();
    List <string> alunoMaiorNota = new List <string>();
    var nota = 0;
    var aluno = 0;
    var i = 0;

    for( nota = 0 ; nota <= 29; nota ++){ 
     notas.Add(numero.Next(11));
    }
   
   for( aluno = 0 ; aluno <= 29; aluno ++){ 
     alunos.Add("aluno" + aluno);
    }
   for( i = 0 ; i <= 29; i ++){
       if(notas[i] == 10)
       maiorNota.Add(notas[i]);
       alunoMaiorNota.Add(alunos[i]);
   }

var media = 0;
   foreach(int todasNotas in notas){
       media+= todasNotas;
      Console.WriteLine(todasNotas);
   }
    
    Console.WriteLine($"A média da turma é : {media/notas.Count}");
    
}
TodasNotas();