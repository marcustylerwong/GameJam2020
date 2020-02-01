using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCheckState : MonoBehaviour
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
            }
            if (allChildren[0].finish == true && 
            allChildren[1].finish == true && 
            allChildren[2].finish == true && 
            allChildren[3].finish == true && 
            allChildren[4].finish == true &&
            allChildren[5].finish == true && 
            allChildren[6].finish == true ) {
                Debug.Log("ok");
                isFinished = true;
            }
        }
    }
}
