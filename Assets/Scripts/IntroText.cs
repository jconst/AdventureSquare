using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class IntroText : MonoBehaviour
{
    public bool resetToIntroText = false;

    void Start() {
        if (resetToIntroText) {
            guiText.text = @"This is a game about gravity!
Use WASD to change the gravity of the room.
Use the arrow keys to move around on the floor.
(Keep in mind the ""floor"" will change with the gravity.)
Press R to restart the current level.
There are 10 levels total.
Press Spacebar to begin.
Good luck!";
        }

        guiText.fontSize = Screen.height / 26;
    }
}
