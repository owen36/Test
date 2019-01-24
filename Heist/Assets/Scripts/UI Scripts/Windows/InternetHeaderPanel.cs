using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetHeaderPanel : MonoBehaviour
{
    public TabButtonElment tabButtonElmentPrefab;
    public Transform tabTransform;
    private List<TabButtonElment> tabButtonElments = new List<TabButtonElment>();

    public void OnNewWindow(WebsitePanel websitePanel)
    {
        TabButtonElment component = Instantiate(tabButtonElmentPrefab, tabTransform);
        component.SetCurrentWebsite(websitePanel);
    }

    private void OnDisable()
    {
        foreach(TabButtonElment tabButtonElment in tabButtonElments)
        {
            Destroy(tabButtonElment.gameObject);
        }
    }
}
