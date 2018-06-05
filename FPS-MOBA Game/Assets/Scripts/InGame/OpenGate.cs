﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class OpenGate : MonoBehaviour {

    // Getting the gates
    public Transform gate1;
    public Transform gate2;

    // Getting the countdown text
    public Text countdownText;
    // Making a float called curCountdownNum. Which will be storing the countdown
    private float curCountdownNum;

    // Getting the 2 colors
    public Color yellow;
    public Color red;

    // Start is called in the beginning
    void Start()
    {
        // Sets the length of the countdown
        curCountdownNum = 20f;

        // Disables the countdown text
        countdownText.enabled = false;
    }

    // Update is called once per frame
    void Update () {
        // Find a NetworkManager component
        NetworkManager nm = FindObjectOfType<NetworkManager>();
        // Makes a variable for the current amount of players
        int curPlayers = nm.numPlayers;
        // Makes a variable for the max amount of players
        float maxPlayers = nm.matchSize;

        // Checks if theres enough players in the match. (Change the amount later!)
        if (curPlayers == 2)
        {
            if (curCountdownNum <= 20 && curCountdownNum > 0)
            {
                // Enables the countdown text
                countdownText.enabled = true;

                // Makes the countdown number go 1 down every second
                curCountdownNum -= Time.deltaTime;

                // Makes the countdown text the same as the countdown number
                countdownText.text = curCountdownNum.ToString("F0");

                // Checks if the countdown text is within 10 to 5
                if (curCountdownNum <= 10 && curCountdownNum >= 6)
                {
                    // Sets the color of the countdown text to yellow
                    countdownText.color = yellow;
                }

                // Checks if the countdown text is within 5 to 0
                if (curCountdownNum <= 5 && curCountdownNum >= 0)
                {
                    // Sets the color of the countdown text to red
                    countdownText.color = red;
                }

                // Checks if the countdown has reached 0
                if (curCountdownNum == 0f || countdownText.text == "0")
                {
                    // Disables the countdown text
                    countdownText.enabled = false;
    
                    // Disables the gates
                    gate1.gameObject.SetActive(false);
                    gate2.gameObject.SetActive(false);
                }
            }
        }
        // This happens if there's less than the maximum of players (10) in the match
        else
        {
            // Enables the text
            countdownText.enabled = true;

            // Sets the font size to 20
            countdownText.fontSize = 20;

            // Sets the content of the text
            countdownText.text = "Waiting for players (" + curPlayers + "/" + maxPlayers + ")...";
        }

	}
}
