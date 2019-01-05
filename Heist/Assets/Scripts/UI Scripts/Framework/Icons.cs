using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !IsMouseOverStartMenu())
        {
            Debug.Log("trigger");
            selectionImage.enabled = false;
            clickCount = 0;
        }
    }

    private bool IsMouseOverStartMenu()
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;

        List<RaycastResult> raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, raycastResults);

        foreach (RaycastResult result in raycastResults)
        {
            if (result.gameObject.tag == "Icon")
                return true;
        }

        return false;
    }
}
