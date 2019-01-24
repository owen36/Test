using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternetNewsPanel : MonoBehaviour
{
    public InternetHeaderPanel internetHeaderPanelPrefab;
    public WebsitePanel websitePanelPrefab;

    private InternetHeaderPanel internetHeaderPanel;
    private WebsitePanel websitePanel;

    // Start is called before the first frame update
    void Start()
    {
        if (internetHeaderPanel == null)
            internetHeaderPanel = Instantiate(internetHeaderPanelPrefab, this.transform);

        if (websitePanel == null)
            websitePanel = Instantiate(websitePanelPrefab, this.transform);
    }

    private void OnDisable()
    {
        if (internetHeaderPanel != null)
            Destroy(internetHeaderPanel.gameObject);

        if (websitePanel != null)
            Destroy(websitePanel.gameObject);
    }

}
