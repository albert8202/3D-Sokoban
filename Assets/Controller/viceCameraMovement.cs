﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class viceCameraMovement : MonoBehaviour
{
    public float sensitivity = 5.0f;
    private Vector3 centerPosition;

    // Start is called before the first frame update
    void Start()
    {
        centerPosition = new Vector3(2.5f, 2.5f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            print("rotated");
            float rotationX = Input.GetAxis("Mouse X") * sensitivity;
            float rotationY = Input.GetAxis("Mouse Y") * sensitivity;

            transform.RotateAround(centerPosition, transform.right, -rotationY);
            transform.RotateAround(centerPosition, Vector3.up, rotationX);
        }
    }
}