using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_Controller : MonoBehaviour
{

    private GameObject UFO;

    // Start is called before the first frame update
    void Start()
    {
        UFO = this.gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Left")) 
        {
            moveLeft();
        }
         if (Input.GetButton("Right"))
        {
            moveRight();
        }
            
    }

    void moveLeft()
    {
        UFO.GetComponent<Rigidbody2D>().SetRotation(35f);
    }
    void moveRight()
    {
        UFO.GetComponent<Rigidbody2D>().SetRotation(-35f);
    }
}
