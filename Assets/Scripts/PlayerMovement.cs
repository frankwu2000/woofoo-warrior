using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Unity2DController u2dc;
    private float horizontalMove;

    public float runSpeed;
    private bool jump = false;
    private bool crouch = false;


    void Start()
    {
        u2dc = gameObject.GetComponent<Unity2DController>();
    }

    void Update()
    {
        horizontalMove=Input.GetAxisRaw("Horizontal")*runSpeed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch")){
            crouch = false;
        }

    }

    void FixedUpdate()
    {
        u2dc.Move(horizontalMove*Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
