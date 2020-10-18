using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    int levelIsUnlocked;


    public Button[] buttons;

    public Player player;

    // Start is called before the first frame update
    void Start()
    {

        player.LoadPlayer();
        int nivelCompletado = player.level;
        Debug.Log("Estoy en el nivel" + nivelCompletado);

        if (nivelCompletado == 0)
        {
            buttons[0].interactable = true;
            buttons[1].interactable = false;
            //buttons[2].interactable = false;
            //buttons[3].interactable = false;
        }

        if (nivelCompletado == 1)
        {
            buttons[0].interactable = true;
            buttons[1].interactable = true;
            //buttons[2].interactable = false;
            //buttons[3].interactable = false;
        }

        if (nivelCompletado == 2)
        {
            buttons[0].interactable = true;
            buttons[1].interactable = true;
            //buttons[2].interactable = true;
            //buttons[3].interactable = false;
        }


        //levelIsUnlocked = PlayerPrefs.GetInt("levelIsUnlocked", 1);

        //for (int i = 0; i < buttons.Length; i++)
        //{
        //buttons[i].interactable = false;
        // }

        //for (int i = 0; i < 2; i++)
        //{
        // buttons[i].interactable = true;
        //}
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    // Update is called once per frame
    void Update()
    {

    }
}