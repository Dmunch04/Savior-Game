using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;
	
	// Update is called once per frame
	void Update () {

            if (Input.GetKey(KeyCode.Escape))
            {
                if (pauseMenu.activeInHierarchy == true)
                {
                    pauseMenu.SetActive(false);
                }
                else
                {
                    pauseMenu.SetActive(true);
                }
            }
        }
}
