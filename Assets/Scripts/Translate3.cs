using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate3 : MonoBehaviour {

	void Start () 
    {
        Debug.Log("hola");
        //transform.position = new Vector3 (0, 0, 0 );
        transform.position = new Vector3(0,0,0);
        
 
    }

    // Update is called once per frame
    void Update () {


        if (Input.GetKeyDown(KeyCode.G)) 
        {
            transform.position = transform.position + (Vector3.down * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + (Vector3.up * Time.deltaTime);
            Debug.Log(transform.position.y);
        }
        
    }
}
