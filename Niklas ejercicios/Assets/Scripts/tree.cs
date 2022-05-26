using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    // Start is called before the first frame update

    Animator m_Animator;

    float ControllerY = 0;
    float ControllerX = 0;
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
           ControllerX += 1.0f * Time.deltaTime;
           ControllerX = Mathf.Clamp(ControllerX,-2.0f, 2.0f);
           m_Animator.SetFloat("ControllerX", ControllerX);
           
        }

        if (Input.GetKey(KeyCode.A))
        {
            ControllerX -= 1.0f * Time.deltaTime;
            ControllerX = Mathf.Clamp(ControllerX, -2.0f, 2.0f);
            m_Animator.SetFloat("ControllerX", ControllerX);

        }

        if (Input.GetKey(KeyCode.W))
        {
            ControllerY += 1.0f * Time.deltaTime;
            ControllerY = Mathf.Clamp(ControllerY, -2.0f, 2.0f);
            m_Animator.SetFloat("ControllerY", ControllerY);

        }

        if (Input.GetKey(KeyCode.S))
        {
            ControllerY -= 1.0f * Time.deltaTime;
            ControllerY = Mathf.Clamp(ControllerY, -2.0f, 21.0f);
            m_Animator.SetFloat("ControllerY", ControllerY);

        }
    }
}
