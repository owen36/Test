using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebsitePanel : MonoBehaviour
{
    public NewsWebsiteHeader newsWebsiteHeaderPrefab;
    public NewsWebsiteCrimeContainer newsWebsiteCrimeContainerPrefab;
    public Transform content;

    private NewsWebsiteHeader newsWebsiteHeader;
    private NewsWebsiteCrimeContainer newsWebsiteCrimeContainer;
    private InternetHeaderPanel internetHeaderPanel;



    private void Start()
    {
        if (internetHeaderPanel == null)
            internetHeaderPanel = GameObject.Find("Header Panel(Clone)").GetComponent<InternetHeaderPanel>();

        if (newsWebsiteHeader == null)
            newsWebsiteHeader = Instantiate(newsWebsiteHeaderPrefab, content);

        if (newsWebsiteCrimeContainer == null)
            newsWebsiteCrimeContainer = Instantiate(newsWebsiteCrimeContainerPrefab, content);
    }
}

