using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using CodeMonkey.Utils;

public class LauncherUI : MonoBehaviour
{
    private void Awake(){

        Application.runInBackground = false;
        Application.targetFrameRate = 100;

        transform.Find("16by9Btn").GetComponent<Button_UI>().ClickFunc = () => {
            Application.OpenURL("https://www.size43.com/16by9-aspect-ratio-calculator/");
        };

        transform.Find("AIDA64Btn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/AIDA64 Extreme/aida64.exe";
            Process.Start(path);
        };

        transform.Find("AudacityBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/Audacity/audacity.exe";
            Process.Start(path);
        };

        transform.Find("BlenderBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/Blender/blender.exe";
            Process.Start(path);
        };

        transform.Find("BoscaceoilBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/Bosca Ceoil/BoscaCeoil.exe";
            Process.Start(path);
        };

        transform.Find("BulkfilechangerBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/BulkFileChanger/BulkFileChanger.exe";
            Process.Start(path);
        };

        transform.Find("GIMPBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/GIMP 2/bin/gimp-2.10.exe";
            Process.Start(path);
        };

    }
}
