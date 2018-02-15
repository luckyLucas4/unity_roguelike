﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    public GameObject gameManager;
    public GameObject soundManager;

	// Use this for initialization
	void Awake () {
        Debug.Log("Loading");
        if (GameManager.instance == null)
            Instantiate(gameManager);

        if (SoundManager.instance == null)
            Instantiate(soundManager);
	}
	
}
