using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryLevel : MonoBehaviour
{
    public void ReloadScene()
    {
        //SceneManager.LoadScene("Level02");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}