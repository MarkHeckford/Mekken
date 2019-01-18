using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{

    //made this a totally dumb script, just posting the direction the player
    //wants to move based on input device, thus de-coupling device from actual movement

    public bool forward = false;
    public bool backward = false;
    public bool turnleft = false;
    public bool turnright = false;
    public bool strafeleft = false;
    public bool straferight = false;
    public bool fire = false;

    // Start is called before the first frame update
    void Start()
    {

    
    }

    // Update is called once per frame
    void Update()
    {

        //clear them all
        forward = false;
        backward = false;
        left = false;
        right = false;
        fire = false;
        
        if (Input.GetKey(KeyCode.W) )
        {
            forward = true;
        }
        if (Input.GetKey(KeyCode.A) )
        {
            strafeleft = true;
        }
        if (Input.GetKey(KeyCode.D) )
        {
            straferight = true;
        }
        if (Input.GetKey(KeyCode.S) )
        {
            backward = true;
        }
        if (Input.GetKey(KeyCode.Q) )
        {
            turnleft = true;
        }
        if (Input.GetKey(KeyCode.E) )
        {
            turnright = true;
        }
    }
}
