using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public void hardRestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        Debug.Log("test");
    }
}
