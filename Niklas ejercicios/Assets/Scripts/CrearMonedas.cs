using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearMonedas : MonoBehaviour
{

    public GameObject MonedasPrefab;

    public float NumeroDeInstancias = 1f;

    public float XparaInstancias;
    // Start is called before the first frame update
    void Start()
    {
        NumeroDeInstancias = Random.Range(1f, 10f);
        Mathf.Round(NumeroDeInstancias);
        print(NumeroDeInstancias);

    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < NumeroDeInstancias; i++)
        {
            float radio = 2 * Mathf.PI / NumeroDeInstancias * i;

            float vertrical = Mathf.Sin(radio);
            float horizontal = Mathf.Cos(radio);

            Vector3 spawnDir = new Vector3(horizontal, 1, vertrical);


            Vector3 spawnPos = spawnDir * radio;


            Instantiate(MonedasPrefab, spawnPos, this.transform.rotation);
        }
    }
}