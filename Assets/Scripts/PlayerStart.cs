using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerStart : MonoBehaviour
{
    void Start() {
        if (GameObject.FindObjectOfType(typeof(Camera)) == null) {
            Debug.Log("No Camera");
            Application.LoadLevel(0);
            return;
        }
        renderer.enabled = false;
        GeneratePlayer();
    }

    public void GeneratePlayer() {
        Instantiate(Resources.Load("Player", typeof(GameObject)),
                    transform.position - Vector3.forward,
                    Quaternion.identity);
    }
}
