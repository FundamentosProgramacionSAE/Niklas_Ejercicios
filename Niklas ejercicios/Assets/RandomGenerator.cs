using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    private System.Random OPMRandomizer = new System.Random();

    public enum NombresOPM
    {
        garou,
        saitama,
        Tatsumaki,
    }
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(12321);
    }

    public void RandomOPMNamesPes()
    {
        int name = UnityEngine.Random.Range(0, 3);
        print((NombresOPM)name);
    }

    public void RandomOPMNamesReal()
    {
        int Nombres = OPMRandomizer.Next(0, 3);
        print((NombresOPM)Nombres);
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //RandomOPMNamesPes();
            RandomOPMNamesReal();
        }
    }
}
