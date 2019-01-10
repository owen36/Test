using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetWindow : Windows
{
    public void Init (Icons icon)
    {
        this.icon = icon;
        SetHeader("Internets");        
    }        
}
