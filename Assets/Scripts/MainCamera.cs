using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MainCamera : MonoBehaviour
{
    void Start() {
        DontDestroyOnLoad(gameObject);
        AudioManager.Main.PlayNewSound("Background", loop: true);
    }
    
    void Update() {
    
    }
}
