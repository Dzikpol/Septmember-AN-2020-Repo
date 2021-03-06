﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandMovement : MonoBehaviour
{

    public float m_moveSpeed = 3.5f;
    public float m_turnSpeed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.down * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * m_moveSpeed);
        }

        transform.Rotate(Vector3.up  * Input.GetAxis("Mouse X") * m_turnSpeed, Space.World);
        transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * m_turnSpeed);
    }
}