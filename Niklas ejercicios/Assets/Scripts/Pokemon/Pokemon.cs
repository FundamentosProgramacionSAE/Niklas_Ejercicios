using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    protected string nombrePokemon;
    protected int level;
    protected string elementoPokemon;


  
    public Pokemon(string NameOfPokemon, int Nivel, string Type)
    {
        nombrePokemon = NameOfPokemon;
        level = Nivel;
        elementoPokemon = Type;
    }

    public void escape()
    {

    }

    public void ataque1()
    {

    }
}


