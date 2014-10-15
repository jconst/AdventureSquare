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
}
