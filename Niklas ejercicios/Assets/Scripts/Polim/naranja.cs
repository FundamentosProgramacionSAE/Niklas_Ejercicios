using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naranja : Fruta
{
    // Start is called before the first frame update
    void Start()
    {
        this.QueSoy();
    }

    protected override void QueSoy()
    {
        base.QueSoy();
        print("yo soy una naranja");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
