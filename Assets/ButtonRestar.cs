using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRestar : MonoBehaviour
{
    public void restartScene()
    {
        SceneManager.LoadScene("Main");
    }
}
