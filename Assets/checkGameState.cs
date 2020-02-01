using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkGameState : MonoBehaviour
{
    private bool isFinished;
    // Start is called before the first frame update
    void Start()
    {
        isFinished = false;
    }

    void Update() {
        mouseDrag[] allChildren = GetComponentsInChildren<mouseDrag>();
        int numberLeft = allChildren.Length;
        foreach (mouseDrag child in allChildren){
            Transform transform = child.GetComponent<Transform>();
            if (transform.position == child.originalPosition &&
            transform.rotation == child.originalRotation) {
                child.finish = true;
                Debug.Log("Help");
            }
        }
    }
}
