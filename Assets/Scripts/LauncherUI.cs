using System.Collections;
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
    }
}
