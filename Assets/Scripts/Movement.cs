using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Obj; 
        public float moveSpeed;
        
        public Rigidbody2D rb;
        public Animator anim;

    Vector2 movement;

     void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizotal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("speed", movement.sqrMagnitude);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "itemy")
        {
            Obj.SetActive(true);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey(KeyCode.E) && collision.gameObject.tag == "itemy")
        {
           
            Destroy(collision.gameObject);
        }
   
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Obj.SetActive(false);
    }
}
