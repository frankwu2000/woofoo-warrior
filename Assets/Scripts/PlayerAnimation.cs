using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rgbd2;
    private Unity2DController u2dc;

    // Start is called before the first frame update
    void Start()
    {
        rgbd2 = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        u2dc = gameObject.GetComponent<Unity2DController>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("xspeed", Mathf.Abs(rgbd2.velocity.x));
        anim.SetFloat("yspeed", rgbd2.velocity.y);
        anim.SetBool("grounded", u2dc.m_Grounded);
    }

    public void Crouching(bool crouching)
    {
        anim.SetBool("crouching", crouching);
    }

}
