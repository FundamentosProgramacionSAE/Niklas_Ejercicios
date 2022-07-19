using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightVision : MonoBehaviour
{

    public LayerMask m_NormalVision;
    public LayerMask m_NightVision;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.cullingMask = m_NormalVision;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Camera.main.cullingMask = m_NightVision;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Camera.main.cullingMask = m_NormalVision;
        }
    }
}
