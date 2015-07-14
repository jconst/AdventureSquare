using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerStart : MonoBehaviour
{
    bool shuttingDown = false;

    void Start() {
        if (GameObject.FindObjectOfType(typeof(Camera)) == null) {
            Debug.Log("No Camera");
            Application.LoadLevel(0);
            return;
        }
        GetComponent<Renderer>().enabled = false;
        GeneratePlayer();
    }

    public void GeneratePlayer() {
        if (shuttingDown)
            return;
        Instantiate(Resources.Load("Player", typeof(GameObject)),
                    transform.position - Vector3.forward,
                    Quaternion.identity);
    }

    void OnApplicationQuit() {
        shuttingDown = true;
    }
}
