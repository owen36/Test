using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using windowsMap;

public class InternetIcon : Icons
{
    public InternetWindow windowPrefab;

   // private InternetWindow window;
    private GameObject windowObj;

    private void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        clickCount = 0;
        selfButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        clickCount++;

        InvokeRepeating("InactiveCheck", 0, 0.5f);

        selectionImage.enabled = clickCount >= 1;

        if (clickCount >= 2)
        {
            Instantiate(windowPrefab, canvas.transform);
            windowObj = windowPrefab.gameObject;
            windowPrefab.gameObject.SetActive(true);
            windowPrefab.Init(this);
            selectionImage.enabled = false;
            spawned = true;
            clickCount = 0;
        }
    }
}
