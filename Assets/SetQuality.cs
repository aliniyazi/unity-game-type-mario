using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetQuality : MonoBehaviour
{
    [SerializeField] GameObject togge;
    public void Update()
    {
        if(togge.GetComponent<Toggle>().isOn)
        {
            ChangeToFullScreen();
        }
        else
        {
            ExitFullScreen();
        }
    }
    public void ChangeQualityToLow()
    {
        QualitySettings.SetQualityLevel(0,true);
    }
    public void ChangeQualityToMdium()
    {
        QualitySettings.SetQualityLevel(2,true);
    }
    public void ChangeQualityToHight()
    {
        QualitySettings.SetQualityLevel(4,true);
    }
    public void ChangeRezolutionToFullHd()
    {
        Screen.SetResolution(1920, 1080,false);
    }
    public void ChangeRezolutionTo2K()
    {
        Screen.SetResolution(2560, 1440, false);

    }
    private void ChangeToFullScreen()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;

    }
    private void ExitFullScreen()
    {
        Screen.fullScreenMode = FullScreenMode.Windowed;

    }

}
