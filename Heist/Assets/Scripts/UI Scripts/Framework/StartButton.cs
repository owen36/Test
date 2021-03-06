﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject startMenu;
    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(OnClick);
    }

    private void Update()
    {
        startButton.enabled = !startMenu.activeSelf;
        this.transform.parent.transform.SetAsLastSibling();
    }

    private void OnClick()
    {
        if (!startMenu.activeSelf)
            startMenu.SetActive(true);           
    }
}
