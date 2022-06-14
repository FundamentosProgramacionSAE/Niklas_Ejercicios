using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo2 : MonoBehaviour
{
    Mundo1 NewWorld;
    
    // Start is called before the first frame update
    void Start()
    {
        NewWorld = new Mundo1();

        NewWorld = new Mundo1(30);
        print("edad " + NewWorld.edad);

        NewWorld = new Mundo1(33, 100);
        print("edad " + NewWorld.edad + " " + NewWorld.Dinero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
