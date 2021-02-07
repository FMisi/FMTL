﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using CodeMonkey.Utils;

public class LauncherUI : MonoBehaviour
{
    private void Awake(){
        transform.Find("16by9Btn").GetComponent<Button_UI>().ClickFunc = () => {
            // Launch!
            Application.OpenURL("https://www.size43.com/16by9-aspect-ratio-calculator/");
        };

        transform.Find("AIDA64Btn").GetComponent<Button_UI>().ClickFunc = () => {
            // Launch!
            string path = Application.dataPath + "/../Builds/AIDA64 Extreme/aida64.exe";
            Process.Start(path);
        };

        transform.Find("AudacityBtn").GetComponent<Button_UI>().ClickFunc = () => {
            // Launch!
            string path = Application.dataPath + "/../Builds/Audacity/audacity.exe";
            Process.Start(path);
        };
    }
}
