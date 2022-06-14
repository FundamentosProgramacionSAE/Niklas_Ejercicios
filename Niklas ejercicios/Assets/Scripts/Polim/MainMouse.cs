using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMouse : MonoBehaviour
{
    public Material[] materials;
    public Renderer rend;
    public int vida = 1;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnMouseDown()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            this.Picando();
        }
    }

    protected virtual void Picando()
    {
        vida += 1;
        if (vida == materials.Length + 1)
        {
            this.death();
        }

        rend.sharedMaterial = materials[vida - 1];
    }

    protected virtual void death()
    {
        Destroy(this.gameObject);
    }
}