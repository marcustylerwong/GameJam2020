using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionController : MonoBehaviour
{
    public GameObject remains;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            Instantiate(remains, new Vector3(0.167f, 1.758f, 1.861f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
