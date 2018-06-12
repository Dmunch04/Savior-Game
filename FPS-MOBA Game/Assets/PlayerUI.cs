using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour {

    [SerializeField]
    GameObject pauseMenu;

    [SerializeField]
    GameObject selectionMenu;

    // Use this for initialization
    void Start()
    {
        ToggleSelectionMenu();

        LegendSelection.IsOn = true;

        PauseMenu.IsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        while (OpenGate.IsGoing == true)
        {
            // Checks if the player presses the escape key
            if (Input.GetKeyDown(KeyCode.E))
            {
                ToggleSelectionMenu();
            }
        }

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

    public void ToggleSelectionMenu ()
    {
        if (LegendSelection.IsOn)
        {
            selectionMenu.SetActive(true);
        }

        // Toggles the selection menu on & off depending on it's current state
        selectionMenu.SetActive(!pauseMenu.activeSelf);
        // Sets the bool to the state of the selection menu (On or Off)
        LegendSelection.IsOn = selectionMenu.activeSelf;
    }
}
