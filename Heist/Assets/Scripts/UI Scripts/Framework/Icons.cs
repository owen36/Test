using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Icons : MonoBehaviour
{
    public Image selectionImage;
    public Button selfButton;

    private int clickCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        clickCount = 0;
        selfButton.onClick.AddListener(OnClick);
    }


    private void OnClick()
    {
        clickCount++;

        selectionImage.enabled = clickCount >= 1;

        if(clickCount >= 2)
        {
            // open window here
            selectionImage.enabled = false;
            clickCount = 0;
        }
    }
}
