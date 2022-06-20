using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateController : MonoBehaviour
{

    public delegate void onclickdelegate();
    public static onclickdelegate Mydelegate;

    // Start is called before the first frame update
    void Start()
    {
        Mydelegate += Attack;
    }


    public void Attack()
    {
        print("Golpe Basico");
    }   
    
    public void attackController()
    {
        if (Mydelegate != null)
        {
            Mydelegate();
        }
    }

    public void ClearUpgrades()
    {
        Mydelegate = null;
        Mydelegate += Attack;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
