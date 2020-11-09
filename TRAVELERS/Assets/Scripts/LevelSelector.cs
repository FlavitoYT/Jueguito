using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

    int levelIsUnlocked;


    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        levelIsUnlocked = PlayerPrefs.GetInt("levelIsUnlocked", 1);
        print("Nivel completado en Player Pref" + levelIsUnlocked);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelIsUnlocked; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("levelIsUnlocked");
    }

}