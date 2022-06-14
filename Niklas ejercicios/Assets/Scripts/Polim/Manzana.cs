using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzana : Fruta
{

    private void Start()
    {
        this.QueSoy();
    }
    protected override void QueSoy()
    {
        base.QueSoy();
        print("yo soy una manzana");
    }
}
