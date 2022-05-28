using static System.Console;
public class Program
{
    static void Demo1()
    {  
        int a = 2;       
        a = Adicionar20(a);
        WriteLine($"O valor da variável a é {a}");

    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }

    static void TrocarNome(Pessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
    }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Amanda";
        p1.Idade = 30;
        p1.Documento = "1234";

        TrocarNome(p1, "Ana");

        WriteLine($"O novo nome é: {p1.Nome}");
    }

    
}