using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    public GameObject botaPrefab;
    public GameObject NoBotaPrefab;
    public GameObject EsLentaDeCJ;

 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bota")
        {
            Destroy(other.gameObject);
            Instantiate(botaPrefab);
        }

        if (other.tag == "no bota")
        {
            Destroy(other.gameObject);
            Instantiate(NoBotaPrefab);
        }

        if (other.tag == "es lenta de cj")
        {
            Destroy(other.gameObject);
            Instantiate(EsLentaDeCJ);
        }
    }
}
