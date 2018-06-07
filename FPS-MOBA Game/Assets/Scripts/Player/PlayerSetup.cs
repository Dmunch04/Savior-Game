﻿using UnityEngine;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour {

    [SerializeField]
    Behaviour[] componentsToDisable;

    [SerializeField]
    string remoteLayerName = "RemotePlayer";

    [SerializeField]
    GameObject playerUIPrefab;
    private GameObject playerUIInstance;

    string ID;

    void Start()
    {
        if (!isLocalPlayer)
        {
            DisableStartComponent();
            AssignRemoteLayer();
        }

        RegisterPlayer();

        // Create PlayerUI
        playerUIInstance = Instantiate(playerUIPrefab);
        playerUIInstance.name = ID + " - " + playerUIPrefab.name;
    }

    void RegisterPlayer()
    {
        ID = "Player: " + GetComponent<NetworkIdentity>().netId;
        transform.name = ID;
    }

    void DisableStartComponent()
    {
        for (int i = 0; i < componentsToDisable.Length; i++)
        {
            componentsToDisable[i].enabled = false;
        }
    }

    void AssignRemoteLayer()
    {
        gameObject.layer = LayerMask.NameToLayer(remoteLayerName);
    }

}
