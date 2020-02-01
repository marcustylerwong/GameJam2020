    using UnityEngine;
    using System.Collections;
     
    public class CameraPanner : MonoBehaviour {
       
        public Transform target;//the target object
        public float speedMod = 2.0f;//a speed modifier
        private Vector3 point;//the coord to the point where the camera looks at
       
        void Start () {//Set up things on the start method
            point = new Vector3(target.transform.position.x, target.transform.position.y +5, target.transform.position.z);//get target's coords
            transform.LookAt(target);//makes the camera look to it
        }
       
        void Update () {//makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
            transform.RotateAround (point,new Vector3(0.0f,1.0f,0.0f),20 * Time.deltaTime * speedMod);
        }
    }
     
