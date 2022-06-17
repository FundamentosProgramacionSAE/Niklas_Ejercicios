using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escalecube : MonoBehaviour
{
  public void EscalarObjeto(float x, float z)
    {
        this.gameObject.transform.localScale += new Vector3(x, 1, z);
    }
}
