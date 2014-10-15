﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MovingPlatform : MonoBehaviour
{
    bool returning = false;
    float speed = 3f;
    public GameObject destPlatform;
    Vector3 startPos;
    Vector3 destPos;
    Vector2 heading;

    void Start() {
        startPos = transform.position;
        destPos = destPlatform.transform.position;
        Destroy(destPlatform);
    }

    void Update() {
        UpdateState();
        if (returning) {
            MoveTo(startPos);
        } else {
            MoveTo(destPos);
        }
    }

    void UpdateState() {
        float distanceFromStart = (transform.position - startPos).magnitude;
        float distanceFromDest = (destPos - transform.position).magnitude;
        float maxDistance = (destPos - startPos).magnitude;

        if (distanceFromStart > maxDistance) {
            returning = true;
        } else if (distanceFromDest > maxDistance) {
            returning = false;
        }
    }

    void MoveTo(Vector3 dest) {
        heading = (dest - transform.position).normalized;
        transform.Translate(heading * speed * Time.deltaTime);
    }

    void OnCollisionStay2D(Collision2D coll) {
        Player player = coll.gameObject.GetComponent<Player>();
        if (player != null) {
            player.transform.Translate(heading * speed * Time.deltaTime);
        }
    }
}
