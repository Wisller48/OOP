class Pessoa{
    //Atributos
    public string nome = "";
    public int idade = 0;

    // Metodo
    public void Apresentar(){
        Console.WriteLine("Bom dia, "+nome+"! Você tem "+idade+" anos");
    }
}

class Program{
    public static void Main(string[] args){
        Pessoa pessoa_1 = new Pessoa();
        pessoa_1.nome = "Alex";
        pessoa_1.idade = 15;

        pessoa_1.Apresentar();

        Pessoa pessoa_2 = new Pessoa();
        pessoa_2.nome = "Maria";
        pessoa_2.idade = 57;

        pessoa_2.Apresentar();

    }
}