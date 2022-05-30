using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed = 5f;
    private Vector3 PlayerController;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 PlayerMovement = new Vector3(PlayerController.x, 0, PlayerController.z);    
        m_Rigidbody.MovePosition(transform.position + PlayerMovement * Time.fixedDeltaTime * m_Speed);
    }

    private void Update()
    {
        PlayerController.x = Input.GetAxis("Horizontal");
        PlayerController.z = Input.GetAxis("Vertical");

    }
}
