using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ReactionEventScript : MonoBehaviour {
    public float threshHold = 0.1f;

    void Start() {
        //this.GetComponent<Image>().alphaHitTestMinimumThreshold = threshHold;
    }

    void Update() {
        if (EventSystem.current.IsPointerOverGameObject()) {
            Debug.Log("Hovering2");
        }
    }

    public void react() {
        Debug.Log("Reactive");
    }

    void OnMouseOver() {
        Debug.Log("Hovering");
    }
	
}
