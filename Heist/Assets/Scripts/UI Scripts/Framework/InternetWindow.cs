﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetWindow : Windows
{
    public WindowsTaskBarComponent component;
    public GameObject obj;
    public InternetNewsPanel internetNewsPanelPrefab;
    private InternetNewsPanel internetNewsPanel;

    // can copy this for the first few windows
    public void Init(Icons icon)
    {
        //this.icon = icon;     
    }

    // fires right after Init, used for set up of buttons & spawning objects
    private void Start()
    {
        taskBarTransform = GameObject.Find("Task Bar").transform;
        SetHeader("Web browser - Homepage - Underground.gov.org");
        if (icon != null)
            iconImage = icon.iconImage;

        // null check, we cannot refrence a null object
        if (component == null)
        {
            component = Instantiate(windowsTaskBarPrefab, taskBarTransform);
            obj = component.gameObject;
        }

        if (internetNewsPanel == null)
            internetNewsPanel = Instantiate(internetNewsPanelPrefab, Content);

        // initilize the component aka the windows taskbar element
        component.Init(iconImage.sprite, "Web browser - Homepage...");

        // set listeners - they wait for OnClick
        component.taskButton.onClick.AddListener(OnClick);
        closeButton.onClick.AddListener(OnClose);
    }

    
    public void OnClose()
    {
        // null check, cannot delete a null object
        if(obj != null)        
            Destroy(obj);
        
        if (internetNewsPanel != null)
            Destroy(internetNewsPanel.gameObject);

        //destroy this gameobject
        Destroy(gameObject);
    }
}
