using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using windowsMap;

public class InternetIcon : Icons
{
    public InternetWindow windowPrefab;

   // private InternetWindow window;
    private GameObject windowObj;

    private void Update()
    {
        if(clickCount >= 2 && !spawned)
        {
            // launch window
            //window = WindowsMap.instance.GetInternetWindow();
            Instantiate(windowPrefab, canvas.transform);
            windowObj = windowPrefab.gameObject;
            windowPrefab.gameObject.SetActive(true);
            windowPrefab.Init(this);
            spawned = true;
        }
    }
}
