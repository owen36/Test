using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Windows : MonoBehaviour
{

    public Text titleText;
    public Button closeButton;
    public Transform Content;

    public Icons icon;
    public Image iconImage;
    /// <summary>
    /// refrence to the taskbar prefab
    /// </summary>
    public WindowsTaskBarComponent windowsTaskBarPrefab;

    /// <summary>
    /// taskbar transform used for spawning the prefabs in
    /// </summary>
    public Transform taskBarTransform;

    /// <summary>
    /// Sets the header for the window, normally used when the window is first spawned
    /// </summary>
    /// <param name="header"></param>
    public void SetHeader(string header)
    {
        titleText.text = header;
    }

    /// <summary>
    /// Brings the window to the front, set up by defaut to work when clicked
    /// </summary>
    public void OnClick()
    {
        this.transform.SetSiblingIndex(this.transform.GetSiblingIndex() - (this.transform.GetSiblingIndex() + 1));        
    }
}
