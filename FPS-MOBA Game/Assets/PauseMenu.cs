using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class PauseMenu : MonoBehaviour {

    public static bool IsOn = false;

    private NetworkManager nm;

    void Start()
    {
        nm = NetworkManager.singleton;
    }

    public void ResumeGame ()
    {

    }

    public void LeaveGame ()
    {
        MatchInfo matchInfo = nm.matchInfo;

        nm.matchMaker.DropConnection(matchInfo.networkId, matchInfo.nodeId, 0, nm.OnDropConnection);
        nm.StopHost();
    }

}
