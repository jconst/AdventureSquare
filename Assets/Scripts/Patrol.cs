using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Patrol : MonoBehaviour
{
    public float speed = 3f;
    public GameObject destObject;
    Vector3 startPos;
    Vector3 destPos;
    Vector2 heading;

    void Start() {
        startPos = transform.position;
        destPos = destObject.GetComponent<Renderer>().bounds.center;
        SetSailFor(destPos);
        Destroy(destObject);
    }

    void Update() {
        UpdateHeading();
    }

    void UpdateHeading() {
        float distanceFromStart = (transform.position - startPos).magnitude;
        float distanceFromDest = (destPos - transform.position).magnitude;
        float maxDistance = (destPos - startPos).magnitude;

        if (distanceFromStart > maxDistance) {
            SetSailFor(startPos);
        } else if (distanceFromDest > maxDistance) {
            SetSailFor(destPos);
        }
    }

    void SetSailFor(Vector3 dest) {
        heading = (dest - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = heading * speed;
    }
}
