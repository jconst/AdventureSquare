using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GravityArrow : MonoBehaviour
{
    Vector3 baseRotation = new Vector3(0, 0, 90);

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    void Update() {
        transform.eulerAngles = baseRotation;
        float rot = Physics2D.gravity.ToAngle();
        transform.Rotate(new Vector3(0, 0, -rot));
    }
}
