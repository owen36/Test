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

    public void Start()
    {
        closeButton.onClick.AddListener(OnCloseClick);
    }

    private void OnCloseClick()
    {
        if (icon != null)
        {
            if (icon.GetSpawnned())
                icon.SetSpawnned(false);
        }

        Destroy(gameObject);
    }

    public void SetHeader(string header)
    {
        titleText.text = header;
    }

    public void OnClick()
    {
        this.transform.SetSiblingIndex(this.transform.GetSiblingIndex() - (this.transform.GetSiblingIndex() + 1));
        
    }


}
