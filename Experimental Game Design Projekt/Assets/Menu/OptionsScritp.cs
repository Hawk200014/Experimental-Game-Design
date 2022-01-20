using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsScritp : MonoBehaviour
{
    public AudioMixer sound;
    public AudioMixer music;
    public Dropdown resoDropdown;

    Resolution[] resolutions;
    void Start()
    {
        List<Resolution> resolutionslist = new List<Resolution>();

        Resolution fullhd = new Resolution();
        fullhd.width = 1920;
        fullhd.height = 1080;
        Resolution hd = new Resolution();
        hd.width = 1280;
        hd.height = 720;

        resolutionslist.Add(fullhd);
        resolutionslist.Add(hd);

        resolutions = resolutionslist.ToArray();


        Debug.Log(resolutions.Length);

        resoDropdown.ClearOptions();

        List<string> options = new List<string>();

        int resolutionIndex = 0;
        for(int i = 0;i < resolutions.Length; i++){
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if(Screen.width == resolutions[i].width && Screen.height == resolutions[i].height){
                   resolutionIndex = i;
            }
        }

        resoDropdown.AddOptions(options);
        resoDropdown.value = resolutionIndex;
        resoDropdown.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMusicVolume(float volume){
        Debug.Log("Music" + volume);
        music.SetFloat("musicVolume",volume);
    }

    public void SetSoundVolume(float volume){
        Debug.Log("soundVolume" + volume);
        sound.SetFloat("MasterVol",volume);
    }

    public void SetFullscreen(bool fullscreen){
        Screen.fullScreen = fullscreen;
    }

    public void SetResolution(int Index){
        Screen.SetResolution(resolutions[Index].width, resolutions[Index].height, Screen.fullScreen);
    }


}
