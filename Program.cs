using Calculadora;


string Escolha;
do
{
    Console.WriteLine(@$"
        Calculadora Menu:
    1-Calcular:
    0-Sair:    
");

    Escolha = Console.ReadLine();

    switch (Escolha)
    {
        case "1":
            Calculadora1 c1 = new Calculadora1();

            Console.WriteLine($"Digite o 1° número:");
            c1.n1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o 2° número:");
            c1.n2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine(@$"
            Qual operação:
        * = Multiplicação
        + = Adição
        / = Divisão
        - = Subtração
    ");
            string Operações = Console.ReadLine();

            switch (Operações)
            {
                case "*":
                    Console.WriteLine($"{c1.n1} X {c1.n2} = {c1.Multiplicar(c1.n1, c1.n2)}");
                    break;
                case "+":
                    Console.WriteLine($"{c1.n1} + {c1.n2} = {c1.adição(c1.n1, c1.n2)}");
                    break;
                case "-":
                    Console.WriteLine($"{c1.n1} - {c1.n2} = {c1.subtração(c1.n1, c1.n2)}");
                    break;
                case "/":
                    Console.WriteLine($"{c1.n1} / {c1.n2} = {c1.divisão(c1.n1, c1.n2)}");
                    break;
                default:
                    Console.WriteLine($"Operação inexistente nessa calculadora!");
                    break;
            }
        
            break;
        case "0":
            Console.WriteLine($"Tchau");
            
            break;
        default:
        Console.WriteLine($"Escolha errada");
            break;
    }
}
while(Escolha != "0");




