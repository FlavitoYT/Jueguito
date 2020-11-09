using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void NextScene()
    {
        //SceneManager.LoadScene("Level02");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Pass()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        print("la escena actual es " + currentLevel);

        if (currentLevel == 4)
        {
            PlayerPrefs.SetInt("levelIsUnlocked", 2);
        }

        if (currentLevel == 7)
        {
            PlayerPrefs.SetInt("levelIsUnlocked", 3);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelIsUnlocked") + " UNLOCKED");

    }

}
