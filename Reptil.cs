public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) { }
    public override string EmitirSom()
    {
        return "shhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh";
    }
}
public class Cobra : Reptil
{ 
    public double Comprimento { get; set; }

    
    
 public Cobra(string nome, int idade) : base(nome, idade)
{
    
}

public override string EmitirSom()
{
    return "shhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh";
}

}


   