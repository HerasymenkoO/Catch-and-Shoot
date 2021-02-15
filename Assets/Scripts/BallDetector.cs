using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BallDetector : MonoBehaviour
{
    public Animator animator;
    public float rotation;
    new int camera;
    public GameObject[] cameraSwitch;
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < cameraSwitch.Length; i++)
        {
            Debug.Log("entered");
            cameraSwitch[0].gameObject.SetActive(false); //camera
            cameraSwitch[1].gameObject.SetActive(true);
            cameraSwitch[2].gameObject.SetActive(false);
            cameraSwitch[3].gameObject.SetActive(true);
            cameraSwitch[4].gameObject.SetActive(false);
            //cameraSwitch[5].gameObject.SetActive(false); //player camera
            animator.SetTrigger("Move");
            //GetComponent<PlayerMovement>().rot = 0;
        }



    }
}
