using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    void Start () {
        var canvas = GetComponent<Graphic>().canvas;
        DontDestroyOnLoad(canvas);
    }
    
    void Update () {
        Text text = GetComponent<Text>();
        text.text = "LEVEL: " + Application.loadedLevel + "/" + (Application.levelCount-2);
        text.fontSize = Screen.height / 30;
    }
}
