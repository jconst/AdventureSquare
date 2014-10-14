using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Deadly : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll) {
        Player player = coll.gameObject.GetComponent<Player>();
        if (player != null) {
            player.Die();
        }
    }
}
