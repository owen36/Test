using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WindowsTaskBarComponent : MonoBehaviour
{
    public Image icon;
    public Text windowTitle;
    public Button taskButton;

    public void Init(Sprite sprite, string title)
    {
        icon.sprite = sprite;
        windowTitle.text = title;
    }

}
