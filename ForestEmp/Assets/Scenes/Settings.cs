using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    private Resolution[] Resolutions;
    public Dropdown ResoDropdown;
   // public Dropdown ScreenDropdown;
    public bool Fullscreen;
    public Toggle FullscreenToggle;
    public Resolution resolution;
    // Use this for initialization
    void Start ()
    {


        //Fullscreen = false;


        Resolutions = Screen.resolutions;
        ResoDropdown.ClearOptions();
        List<string> resolutionoptions = new List<string>();

        
       /* ScreenDropdown.ClearOptions();
        List<string> screenoptions = new List<string>();
        screenoptions.Add("Fullscreen");
        screenoptions.Add("Windowed"); */


        int currentresolutionindex = 0;








        for (int i =0; i < Resolutions.Length; i++)
        {
            string resolutionoption = Resolutions[i].width + "x" + Resolutions[i].height;
            resolutionoptions.Add(resolutionoption);

            if(Resolutions[i].width==Screen.currentResolution.width && Resolutions[i].height==Screen.currentResolution.height)
            {
                currentresolutionindex = i;
            }

        }

        ResoDropdown.AddOptions(resolutionoptions);

        ResoDropdown.value = currentresolutionindex;
        ResoDropdown.RefreshShownValue();


	}


    public void SetResolution(int resolutionindex)
    {
        resolution = Resolutions[resolutionindex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void FullscreenActive(bool value)
    {
        if (value == true)
        {
            Screen.fullScreen = true;
        }
        if (value == false)
        {
            Screen.fullScreen = false;
        }
    }




    void Update ()
    {
		
	}
}
