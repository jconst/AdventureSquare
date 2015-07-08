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
        Move();
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

    void Move() {
        transform.Translate(heading * speed * Time.deltaTime);
    }

    void SetSailFor(Vector3 dest) {
        heading = (dest - transform.position).normalized;
    }

    void OnCollisionStay2D(Collision2D coll) {
        Player player = coll.gameObject.GetComponent<Player>();
        if (player != null) {            
            player.transform.Translate(heading * speed * Time.deltaTime);
        }
    }
}
