﻿using System.Collections;
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
}
