using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionController : MonoBehaviour
{
     public static UnityAction Test;

    private void OnEnable()
    {
        Test = Newaction;
        Test += NewAction2;
        Test += NewAction3;
    }

    public void Newaction()
    {
        print("El Sergi es un Merlon");
    }

    public void NewAction2()
    {
        print("Niklas es pro en programacion");
    }

    public void NewAction3()
    {
        this.gameObject.transform.localScale += new Vector3(3, 3, 3);
    }    
    private void Update()
    {
        if(Input.anyKeyDown)
        {
            Test.Invoke();
        }
    }
}
