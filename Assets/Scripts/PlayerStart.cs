using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerStart : MonoBehaviour
{
    void Start() {
        renderer.enabled = false;
        GeneratePlayer();
    }

    public void GeneratePlayer() {
        Instantiate(Resources.Load("Player", typeof(GameObject)),
                    transform.position - Vector3.forward,
                    Quaternion.identity);
    }
}
