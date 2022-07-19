using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRayCast : MonoBehaviour
{

    public int RayDistance = 100000;

    Ray _MouseRay;
    RaycastHit _hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);


        if (Physics.Raycast(_MouseRay, out _hit, RayDistance))
        {
            Debug.DrawLine(_MouseRay.origin, _MouseRay.direction * RayDistance, Color.blue);
        }
        else
        {
            Debug.DrawLine(_MouseRay.origin, _MouseRay.direction * RayDistance, Color.green );
        }
    }
}
