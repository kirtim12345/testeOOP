using System;
using System.Collections.Generic;

public class MiniZoo
{
    private List<Animal> _animais;

    public MiniZoo()
    {
        
        _animais = new List<Animal>();
    }

    private List<Animal> animais = new List<Animal>();

    public void EmitirSomDeTodosOsAnimais() {
        foreach (var animal in animais) {
            animal.EmitirSom();
        }
    }

    public void AdicionarAnimal(Animal animal) {
        animais.Add(animal);
    }
    public void ImprimirTodosOsAnimais() {
        foreach (var animal in animais) {
            Console.WriteLine($"Nome: {animal.Nome} | Tipo: {animal.GetType().Name} | Idade: {animal.Idade}");            
        }
    }

}



