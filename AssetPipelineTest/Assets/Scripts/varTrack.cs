﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class varTrack : MonoBehaviour {

    public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeSelf == true)
        {
            print("set active");
            pauseMenu.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeSelf == false)
        {
            pauseMenu.SetActive(true);
        }
    }
}
