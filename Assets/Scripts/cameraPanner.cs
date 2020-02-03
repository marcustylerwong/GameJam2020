using UnityEngine;
using System.Collections;

public class cameraPanner : MonoBehaviour
{

    public Transform target;//the target object
    private float speedMod = 10f;//a speed modifier
    private Vector3 point;//the coord to the point where the camera looks at

    void Start()
    {//Set up things on the start method
        //point = target.transform.position;//get target's coords
        point = (new Vector3(target.transform.position.x, target.transform.position.y + 10, target.transform.position.z));
        transform.LookAt(target);//makes the camera look to it
    }

    void Update()
    {//makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
        if (Input.GetKey("d")){
            Debug.Log("d");
            transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * speedMod);
        }
        if (Input.GetKey("a")){
            transform.RotateAround(point, new Vector3(0f, -1.0f, 0f), 20* Time.deltaTime* speedMod);
        }
    }
}
