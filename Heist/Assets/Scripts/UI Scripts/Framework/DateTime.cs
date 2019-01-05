using System.Collections;
using System.Collections.Generic;
using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DateTime : MonoBehaviour
{
    public Text time;
    public Text date;

    private System.DateTime localTime;

    // Update is called once per frame
    void Update()
    {
        localTime = System.DateTime.Now;
        time.text = localTime.ToShortTimeString();
        date.text = localTime.ToShortDateString();
    }
}
