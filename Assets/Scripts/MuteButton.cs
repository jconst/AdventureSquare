using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MuteButton : MonoBehaviour, IPointerClickHandler
{
    void Start() {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(GameObject.Find("EventSystem"));
    }

    public void OnPointerClick(PointerEventData eventData) {
        Debug.Log("click");
        MainCamera mainCamera = Camera.main.GetComponent<MainCamera>();
        bool muted = mainCamera.bgSound.source.mute;
        mainCamera.bgSound.source.mute = !muted;

        var text = GetComponentInChildren<Text>();
        text.text = muted ? "MUTE" : "UNMUTE";
    }
}
