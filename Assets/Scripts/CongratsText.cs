using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CongratsText : MonoBehaviour
{
    void Start () {
        var deathText = GameObject.Find("DeathText").GetComponent<DeathText>();
        GUIText text = GetComponent<GUIText>();
        text.text = "Congratulations!\nYou Win!\n"
                  + "You only died " + deathText.deaths + " times!\n";
        if (deathText.deaths == 0) {
            text.text = text.text + "Probably because you cheated.\n";
        }
        text.text = text.text + "\nPress spacebar to play again!";
        text.fontSize = Screen.height / 25;

        deathText.deaths = 0;
    }
}
