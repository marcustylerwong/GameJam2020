using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mouseDrag : MonoBehaviour {

    private Vector3 mOffset;
    private float mZCoord;
    public Vector3 originalPosition;
    public Quaternion originalRotation;
    public Rigidbody rb;
    public MeshCollider mc;
    public Vector3 offsetPosition1;
    public Vector3 offsetPosition2;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
        offsetPosition1 = new Vector3(originalPosition.x +5, originalPosition.y +5, originalPosition.z +5);
        offsetPosition2 = new Vector3(originalPosition.x -5, originalPosition.y -5, originalPosition.z -5);
        
        //BoxCollider original = gameObject.AddComponent<BoxCollider>();
        //original.transform.SetPositionAndRotation(originalPosition, originalRotation);
    }

    void OnMouseDown() {

        mZCoord = Camera.main.WorldToScreenPoint(
        gameObject.transform.position).z;
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

        //on pick reset rotation and lock rotation
        transform.localRotation = originalRotation;
        rb.freezeRotation = true;
    }
    private Vector3 GetMouseAsWorldPoint() {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag() {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

    void OnMouseUp() {
        if (transform.position.x < offsetPosition1.x && 
        transform.position.y < offsetPosition1.y &&
        transform.position.z < offsetPosition1.z &&
        transform.position.x > offsetPosition2.x &&
        transform.position.y > offsetPosition2.y &&
        transform.position.z > offsetPosition2.z) {
            ///if close enough to original location snap to original location
            rb.isKinematic = true;
            rb.detectCollisions = false;
            transform.SetPositionAndRotation(originalPosition, originalRotation);
        }
        rb.freezeRotation = false;

    }
}
