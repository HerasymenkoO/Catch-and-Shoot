﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FlexibleCameraSwitch : MonoBehaviour
{

    public GameObject[] cameraList;
    public int currentCamera;

    void Start()
    {
        currentCamera = 0;
        for (int i = 0; i < cameraList.Length; i++)
        {
            cameraList[i].gameObject.SetActive(false);
        }

        if (cameraList.Length > 0)
        {
            cameraList[0].gameObject.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            currentCamera++;
            if (currentCamera < cameraList.Length)
            {
                cameraList[currentCamera - 1].gameObject.SetActive(false);
                cameraList[currentCamera].gameObject.SetActive(true);
            }
            else
            {
                cameraList[currentCamera - 1].gameObject.SetActive(false);
                currentCamera = 0;
                cameraList[currentCamera].gameObject.SetActive(true);
            }
        }

    }
}