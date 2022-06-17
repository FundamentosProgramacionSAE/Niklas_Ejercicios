using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MainMouse
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
        print("soy una capsula");
    }
    IEnumerator timerForDeath()
    {
        yield return new WaitForSeconds(1);
        base.death();
    }
    protected override void death()
    {
        this.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        StartCoroutine(timerForDeath());
    }
}
