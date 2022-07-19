using System.Diagnostics;
using UnityEngine;
using CodeMonkey.Utils;
using System;

public class LauncherUI : MonoBehaviour
{
    private void Awake(){

        // TODO Linux verzio
        // Operacios rendszer lekerese:
        // UnityEngine.Debug.Log(SystemInfo.operatingSystem);
        // Ez egy Windows?:
        // String os = SystemInfo.operatingSystem;
        // if (os.Contains("Windows")){
        //    UnityEngine.Debug.Log("Ez egy Windows");
        // }

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

        transform.Find("GitHubBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/GitHubDesktop/GitHubDesktop.exe";
            Process.Start(path);
        };

        transform.Find("HDSentinelBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/Hard Disk Sentinel/HDSentinel.exe";
            Process.Start(path);
        };

        transform.Find("HxDBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/HxD/HxD.exe";
            Process.Start(path);
        };

        transform.Find("LibreOfficeBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/LibreOffice/program/soffice.exe";
            Process.Start(path);
        };

        transform.Find("LMMSBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/LMMS/lmms.exe";
            Process.Start(path);
        };

        transform.Find("OBSBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/obs-studio/bin/64bit/obs64.exe";
            Process.Start(path);
        };

        transform.Find("OTBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/OpenToonz/OpenToonz.exe";
            Process.Start(path);
        };

        transform.Find("RenPyBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/renpy-7.3.5-sdk/renpy.exe";
            Process.Start(path);
        };

        transform.Find("RHBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/ResourceHacker/ResourceHacker.exe";
            Process.Start(path);
        };

        transform.Find("RPGMBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/KADOKAWA/RPGMV/RPGMV.exe";
            Process.Start(path);
        };

        transform.Find("ShotcutBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/Shotcut/shotcut.exe";
            Process.Start(path);
        };

        transform.Find("UnityHubBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/UnityHub/UnityHub.exe";
            Process.Start(path);
        };
        
        transform.Find("VSCodeBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/MicrosoftVSCode/Code.exe";
            Process.Start(path);
        };
        
        transform.Find("VRoidBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/VRoidStudio/1.10.0/VRoidStudio.exe";
            Process.Start(path);
        };

        transform.Find("ZimBtn").GetComponent<Button_UI>().ClickFunc = () => {
            string path = Application.dataPath + "/../Builds/ZimDesktopWiki/zim.exe";
            Process.Start(path);
        };

    }
}
