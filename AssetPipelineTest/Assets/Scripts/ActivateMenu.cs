using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateMenu : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetMenu(GameObject inactiveMenu)
    {
        this.gameObject.SetActive(false);
        inactiveMenu.SetActive(true);
    }
}
