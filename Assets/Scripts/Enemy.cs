using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

/* Controls the Enemy AI */

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
            SceneManager.LoadScene("Lose");
        if (other.tag == "Win")
            SceneManager.LoadScene("Won");
    }
}