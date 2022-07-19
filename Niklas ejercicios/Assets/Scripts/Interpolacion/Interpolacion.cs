using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolacion : MonoBehaviour
{

    Transform Tr;
    public float Cubo;
    public float firstposition;
    public float lastposition;

    private void Start()
    {
        Tr = GetComponent<Transform>();
        Tr.position = Vector3.zero;
    }
    private void Update()
    {
        
        Cubo = Mathf.SmoothStep(firstposition, lastposition, 0.7f * Time.deltaTime);
        this.transform.localScale = new Vector3(Cubo, Cubo, Cubo);
        lastposition = Cubo;
    }
}
