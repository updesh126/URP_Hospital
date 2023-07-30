using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuManager : MonoBehaviour
{
    public GameObject home;
    public GameObject tools;
    public GameObject user;
    public GameObject setting;

    private void Start()
    {
        home.SetActive(true);
        tools.SetActive(false);
        user.SetActive(false);
        setting.SetActive(false);
    }

    public void Home_UI()
    {
        home.SetActive(true);
        tools.SetActive(false);
        user.SetActive(false);
        setting.SetActive(false);
    }

    public void User_UI()
    {
        home.SetActive(false);
        tools.SetActive(false);
        user.SetActive(true);
        setting.SetActive(false);
    }

    public void Setting_UI()
    {
        home.SetActive(false);
        tools.SetActive(false);
        user.SetActive(false);
        setting.SetActive(true);
    }

    public void Tools_UI()
    {
        home.SetActive(false);
        tools.SetActive(true);
        user.SetActive(false);
        setting.SetActive(false);
    }
}
