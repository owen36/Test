using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetWindow : Windows
{
    private WindowsTaskBarComponent component;
    private GameObject obj;

    private void Start()
    {
        closeButton.onClick.AddListener(OnClose);

        if (component == null)
        {
            component = Instantiate(windowsTaskBarPrefab, taskBarTransform);
            obj = component.gameObject;
        }
        component.Init(icon.iconImage.sprite, "Internets");
        component.taskButton.onClick.AddListener(OnClick);
    }

    public void Init (Icons icon)
    {        
        this.icon = icon;
        SetHeader("Internets");
        taskBarTransform = GameObject.Find("Task Bar").transform;
    }

    public void OnClose()
    {
        if(obj != null)
        {
            Destroy(obj);
        }

        if (icon != null)
        {
            if (icon.GetSpawnned())
                icon.SetSpawnned(false);
        }

        Destroy(gameObject);
    }
}
