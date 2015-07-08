using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Goal : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll) {
        Player player = coll.gameObject.GetComponent<Player>();
        if (player != null) {
            WinLevel(player);
        }
    }

    void WinLevel(Player player) {
        Destroy(player.gameObject);

        int nextLevel = Application.loadedLevel + 1;
        if (nextLevel >= Application.levelCount) {
            nextLevel = 1;
        }
        Application.LoadLevel(nextLevel);
    }

    void Update() {
        int level = Application.loadedLevel;
        bool firstOrLastLevel = level == 0 || level == Application.levelCount - 1;
        bool normalContinue = Input.GetKeyDown(KeyCode.Space) && firstOrLastLevel;
        bool secretCombo = Input.GetKey(KeyCode.J)
                        && Input.GetKey(KeyCode.O)
                        && Input.GetKeyDown(KeyCode.E);
        if (normalContinue || secretCombo) {
            WinLevel((Player)GameObject.FindObjectOfType(typeof(Player)));
        }
    }
}
