using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] 
    GameObject settingsPanel;
    [SerializeField] 
    GameObject levelsPanel;

    private bool isOpen;
    void Start()
    {
        settingsPanel = GameObject.Find("Settings");
        levelsPanel = GameObject.Find("Levels");
        settingsPanel.SetActive(false);
        levelsPanel.SetActive(false);
    }
    public void openSetting()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            settingsPanel.GetComponent<CanvasGroup>().alpha = 1;
            settingsPanel.SetActive(true);
            levelsPanel.GetComponent<CanvasGroup>().alpha = 0;
            levelsPanel.SetActive(false);
        }
        else
        {
            settingsPanel.GetComponent<CanvasGroup>().alpha = 0;
            settingsPanel.SetActive(false);
            levelsPanel.GetComponent<CanvasGroup>().alpha = 1;
            levelsPanel.SetActive(true);
        }
    }
}
