using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HostGame : MonoBehaviour {

    public Text errorText;

    [SerializeField]
    private uint matchSize = 10;

    private string matchName;
    private string _matchName;

    private NetworkManager networkManager;
    private HostManager hm;

    void Start()
    {
        hm = GetComponent<HostManager>();

        _matchName = hm.matchName;

        networkManager = NetworkManager.singleton;

        if (networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }
    }

    public void SetMatchName (string _name)
    {
        matchName = _name;
    }

    public void MakeMatch ()
    {
        Debug.Log("Creating Match: " + _matchName + " with room for " + matchSize + " players.");

        networkManager.matchMaker.CreateMatch(_matchName, matchSize, true, "", "", "", 0, 0, networkManager.OnMatchCreate);
    }

    public void CreateMatch ()
    {
        if (matchName != "" && matchName != null)
        {
            Debug.Log("Creating Match: " + matchName + " with room for " + matchSize + " players.");

            networkManager.matchMaker.CreateMatch(matchName, matchSize, true, "", "", "", 0, 0, networkManager.OnMatchCreate);
        }
        else
        {
            errorText.text = "Please give the match a name!";
        }
    }

}
