using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menubuttons : MonoBehaviour {

    public GameObject MenuPanel;
    public GameObject OptionsPanel;
    public GameObject StartPanel;
    public GameObject MainPanel;
	// Use this for initialization
	void Start ()
    {
        MainPanel.SetActive(true);
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        StartPanel.SetActive(false);

	}
	
    public void ShowMainPanel()
    {
        MainPanel.SetActive(true);
        MainPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        StartPanel.SetActive(false);
    }

    public void ShowOptionsPanel()
    {
        MainPanel.SetActive(true);
        MainPanel.SetActive(false);
        OptionsPanel.SetActive(true);
        StartPanel.SetActive(false);
    }

    public void ShowStartPanel()
    {
        MainPanel.SetActive(true);
        MainPanel.SetActive(false);
        OptionsPanel.SetActive(false);
        StartPanel.SetActive(true);
    }

    public void StartScene()
    {
        SceneManager.LoadScene("SampleScene");
    
    }

    public void Quit()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update () {
		
	}
}
