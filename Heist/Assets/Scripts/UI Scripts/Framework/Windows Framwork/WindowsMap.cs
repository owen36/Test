using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace windowsMap
{
    public class WindowsMap : MonoBehaviour
    {
        public Windows windowsMasterPrefab;
        public InternetWindow internetWindowPrefab;


        public static WindowsMap instance;

        private void Start()
        {
            instance = this;
        }

        public InternetWindow GetInternetWindow()
        {
            return internetWindowPrefab;
        }
    }
}
