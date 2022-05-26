using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            m_Animator.SetTrigger("Grande");
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            m_Animator.SetTrigger("Peque");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Animator.SetTrigger("Color");
        }
    }
}
