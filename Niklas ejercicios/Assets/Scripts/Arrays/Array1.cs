using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array1 : MonoBehaviour
{

    public int[] NumerosEnteros;

    public int[] NumerosEnterosInvertidos;

    public int numEntero;
    // Start is called before the first frame update
    void Start()
    {
        Printenteros(); 
    }

    void Printenteros()
    {
        for (int i = 0; i < NumerosEnteros.Length; i++)
        {
            NumerosEnterosInvertidos[i] = NumerosEnteros[numEntero];
            numEntero--;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
