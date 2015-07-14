using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeathText : MonoBehaviour
{
    public int deaths = 0;

    void Start () {
        DontDestroyOnLoad(gameObject);
    }
    
    void Update () {
        Text text = GetComponent<Text>();
        text.text = "DEATHS: " + deaths;
        text.fontSize = Screen.height / 30;
    }
}
