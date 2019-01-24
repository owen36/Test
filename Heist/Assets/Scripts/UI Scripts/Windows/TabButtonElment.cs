using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabButtonElment : MonoBehaviour
{
    public Text tabText;
    public Button tabButton;
    private WebsitePanel currentWebsite;

    public void SetCurrentWebsite(WebsitePanel websitePanel)
    {
        currentWebsite = websitePanel;
    }

    public WebsitePanel GetCurrentWebsite()
    {
        return currentWebsite;
    }
}
