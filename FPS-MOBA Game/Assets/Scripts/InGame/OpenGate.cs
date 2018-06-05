using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class OpenGate : MonoBehaviour {

    public Transform gate1;
    public Transform gate2;

    public Text countdownText;
    private float curCountdownNum;

    void Start()
    {
        // Sets the length of the countdown
        curCountdownNum = 5f;

        // Disables the countdown text
        countdownText.enabled = false;
    }

    // Update is called once per frame
    void Update () {
        // Find a NetworkManager component
        NetworkManager nm = FindObjectOfType<NetworkManager>();

        // Checks if theres enough players in the match. (Change the amount later!)
        if (nm.numPlayers == 1)
        {
            if (curCountdownNum <= 5 && curCountdownNum > 0)
            {
                // Enables the countdown text
                countdownText.enabled = true;

                // Makes the countdown number go 1 down every second
                curCountdownNum -= Time.deltaTime;

                // Makes the countdown text the same as the countdown number
                countdownText.text = curCountdownNum.ToString("F0");

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

	}
}
