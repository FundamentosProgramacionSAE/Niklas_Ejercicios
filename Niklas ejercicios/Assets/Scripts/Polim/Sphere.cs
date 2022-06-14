using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MainMouse
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            this.Picando();
        }
    }

    protected override void Picando()
    {
        base.Picando();
        print("soy una esfera");
    }
}
