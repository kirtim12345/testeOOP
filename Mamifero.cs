public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        return "Rawr";
    }
}
public class Leao : Mamifero
{ 
    public int TamanhoDoGrupo { get; set; }

    public Leao (string nome, int idade) : base(nome, idade)
    {

    }
  public override string EmitirSom()
{
    return "Rawr";
}

}

    