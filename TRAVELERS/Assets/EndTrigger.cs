﻿using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    private void OnTriggerEnter2D()
    {
        gameManager.CompleteLevel();
    }

}
