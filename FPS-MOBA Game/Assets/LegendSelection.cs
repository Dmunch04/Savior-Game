using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LegendSelection : MonoBehaviour {

    public static bool IsOn = true;

    private NetworkManager nm;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenCategoty (GameObject disable)
    {
        //enable.SetActive(true);
        disable.SetActive(false);
    }

    public void ClosePanel (GameObject disable)
    {
        disable.SetActive(false);
    }

    public void OpenPanel(GameObject enable)
    {
        enable.SetActive(true);
    }


}
