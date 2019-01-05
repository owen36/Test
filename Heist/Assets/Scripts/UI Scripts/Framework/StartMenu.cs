using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    // gonna add in all the buttons and functions here


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !IsMouseOverStartMenu())
        {
                Debug.Log("trigger");
                this.gameObject.SetActive(false);    
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
            if (result.gameObject.name == "Start Menu")
                return true;
        }

        return false;
    }
}
