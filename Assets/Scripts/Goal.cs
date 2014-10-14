using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Goal : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll) {
        Player player = coll.gameObject.GetComponent<Player>();
        if (player != null) {
            WinLevel();
        }
    }

    void WinLevel() {
        Debug.Log("Win");
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
