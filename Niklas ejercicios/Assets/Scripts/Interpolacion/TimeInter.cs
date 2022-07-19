using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeInter : MonoBehaviour
{

    public GameObject cubo;

    public float Timer = 0;

    public float maxTimer = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        float paso = Timer / maxTimer;

        if (paso >= 1)
        {
            paso = 1;
        }

        float newPosition = Mathf.SmoothStep(paso, paso, paso);
        cubo.transform.localScale = new Vector3(newPosition, newPosition, newPosition);

        if (Timer/maxTimer >= 1)
        {
            Timer = 0;
        }
    }

    public void HacerPaso(float paso)
    {
           
    }
}
