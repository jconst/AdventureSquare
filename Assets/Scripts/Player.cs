using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Player : MonoBehaviour
{
    const float FUPDATE_HZ = 50f;
    public float speed;

    const float GRAVITY_SCALE = 10f;
    public Vector2 gravity {
        get {
            return Physics2D.gravity.normalized;
        }
        set {
            Physics2D.gravity = value * GRAVITY_SCALE;
        }
    }

    void Start() {
        Physics2D.gravity = -Vector2.up * GRAVITY_SCALE;
    }
    
    void FixedUpdate() {
        UpdateGravity();
        Move();
    }

    void UpdateGravity() {
        KeyConfig.GravityForKey.Where(kvp => Input.GetKeyDown(kvp.Key))
                               .Select(kvp => kvp.Value)
                               .ToList()
                               .ForEach(vec => gravity = vec);
    }

    void Move() {

        Vector3 heading = KeyConfig.HeadingForKey.Where(kvp => Input.GetKey(kvp.Key))
                                                 .Select(kvp => kvp.Value)
                                                 .Where(v => v.Abs() != gravity.Abs())
                                                 .Aggregate(default(Vector2), (v1, v2) => v1 + v2);
        transform.position += heading * (speed / FUPDATE_HZ);
    }
}
