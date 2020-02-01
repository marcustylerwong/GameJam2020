using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class originalPos : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        BoxCollider original = gameObject.AddComponent<BoxCollider>();
        original.transform.SetPositionAndRotation(originalPosition, originalRotation);
    }

    // Update is called once per frame
    void Update()
    {
        //if objects transform collides with instantiated box collider snap to original position
        
    }
}
