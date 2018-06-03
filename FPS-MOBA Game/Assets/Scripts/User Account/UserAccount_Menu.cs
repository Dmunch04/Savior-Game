﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserAccount_Menu : MonoBehaviour
{

    public Text usernameText;

    void Start()
    {
        if (UserAccountManager.IsLoggedIn)
        {
            usernameText.text = UserAccountManager.LoggedIn_Username;
        }
    }

    public void LogOut()
    {
        if (UserAccountManager.IsLoggedIn)
        {
            UserAccountManager.instance.LogOut();
        }
    }
}
