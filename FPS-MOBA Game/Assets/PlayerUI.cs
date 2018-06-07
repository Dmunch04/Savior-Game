using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour {

    [SerializeField]
    GameObject pauseMenu;

    // Use this for initialization
    void Start()
    {
        PauseMenu.IsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if the player presses the escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        // Toggles the pause menu on & off depending on it's current state
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        // Sets the bool to the state of the pause menu (On or Off)
        PauseMenu.IsOn = pauseMenu.activeSelf;
    }
}
