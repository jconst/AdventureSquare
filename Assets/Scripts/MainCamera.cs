using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MainCamera : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        AudioManager.Main.PlayNewSound("Background", loop: true);

        OnLevelWasLoaded(Application.loadedLevel);
    }
    
    void OnLevelWasLoaded(int level) {
        DestroyAllPlayers();
        if (level == 0) {
            Application.LoadLevel(1);
        }
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
