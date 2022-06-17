using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANDOM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ActionController.Test += Buenosdias;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buenosdias()
    {
        print("Buenos dias UnityAction");
        this.gameObject.transform.localScale += new Vector3(1,1,1);
    }
}
