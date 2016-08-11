using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MainCamera : MonoBehaviour
{
    public Sound bgSound;

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        bgSound = AudioManager.Main.PlayNewSound("Background", loop: true);
    }

    void OnApplicationQuit() {
        DestroyAllPlayers();
    }

    void DestroyAllPlayers() {
        GameObject.FindObjectsOfType(typeof(Player))
                  .ToList()
                  .ForEach(player => Destroy(((Player)player).gameObject));
    }
}
