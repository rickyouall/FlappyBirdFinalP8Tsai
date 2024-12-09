using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float upForce = 200f;
    private bool IsDead = false;
    private Animator anim;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        if(IsDead == false)
        {
            if (Input.GetMouseButtonDown (0) || Input.GetKeyDown(KeyCode.Space)) 
            { 
            rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");

            }
        }
    }
    void OnCollisionEnter2D()
    {

        rb2d.velocity = Vector2.zero;
        IsDead = true;

        anim.SetTrigger("Die");
        GameControl.instance.BirdDied ();




    }









}
