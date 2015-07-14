using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class IntroText : MonoBehaviour
{
    public bool resetToIntroText = false;

    void Start() {
        if (resetToIntroText) {
            GetComponent<GUIText>().text = @"This is a game about gravity!
Use WASD to change the gravity of the room.
(Try it right now!)
Use the arrow keys to move around on the floor.
(Keep in mind the ""floor"" will change with the gravity.)
Press R to restart the current level.
Press Spacebar to begin.
Good luck!";
        }
    }

    void Update() {
        GetComponent<GUIText>().fontSize = Screen.height / 26;
    }
}
