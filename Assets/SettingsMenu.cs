using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {
    #region Variables
    public AudioMixer audioMixer;
    #endregion
    #region Volume Slider


    //attach the volume slider to the mixer volume
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    #endregion
    #region Quality Settings
    //attach quality settings to dropdown options
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    #endregion
}
