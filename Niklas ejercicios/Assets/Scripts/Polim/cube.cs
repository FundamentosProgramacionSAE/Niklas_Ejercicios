using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MainMouse
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Picando();
        }
    }
    protected override void Picando()
    {
        base.Picando();
        print("soy un cubo");
    }
    protected override void death()
    {
        this.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
        base.death();
    }
}
