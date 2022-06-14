using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulbasur : Pokemon
{
    public int peso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Bulbasur(string NameOfPokemon, int Nivel, string Type, int Peso) : base("bulbasur ", 11, "planta")
    {
        peso = Peso;

       //Pokemon bulbasur = new Pokemon(NameOfPokemon, Nivel, Type);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
