using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 12f;

    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xcontroller = Input.GetAxis("Horizontal");
        float Zcontroller = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(Xcontroller, 0, Zcontroller);

        controller.Move(move * Time.deltaTime * speed);
    }
}
