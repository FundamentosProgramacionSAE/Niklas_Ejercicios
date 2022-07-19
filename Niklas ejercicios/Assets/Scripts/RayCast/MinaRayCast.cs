using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinaRayCast : MonoBehaviour
{

    public LayerMask enemy;
    void Start()
    {
       
    }

    
    void Update()
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10f, enemy))
        {
            Destroy(hit.collider.gameObject);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            Debug.Log("Did Hit");
        }
    }
}
