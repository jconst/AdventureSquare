using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerStart : MonoBehaviour
{
    void Start() {
        Instantiate(Resources.Load("Player", typeof(GameObject)),
                    transform.position,
                    Quaternion.identity);
        Destroy(gameObject);
    }
}
