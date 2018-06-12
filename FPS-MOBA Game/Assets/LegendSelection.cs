using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LegendSelection : NetworkBehaviour {

    // Creates the IsOn bool for the pause menu and sets it to true
    public static bool IsOn = true;

    //[SerializeField]
    //GameObject playerGraphicsPrefab;

    // Getting the network manager
    private NetworkManager nm;

    void Start ()
    {
        nm = NetworkManager.singleton;
    }

    // This is a function for closing a game object. The game object is given in the inspector
    public void ClosePanel (GameObject disable)
    {
        // This will disable the game object you put in the inspector
        disable.SetActive(false);
    }

    // This is a function for opening a game object. The game object is given in the inspector
    public void OpenPanel (GameObject enable)
    {
        // This will enable the game object you put in the inspector
        enable.SetActive(true);
    }

    public void SetPlayerGraphic (GameObject graphics)
    {
        if (!PlayerSetup.IsLocalPlayer)
            return;

        //nm.playerPrefab = graphics;
    }

}
