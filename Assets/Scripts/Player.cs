using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player : MonoBehaviour
{

    public float speed;
    private Vector3 playerPos;
    private Rigidbody2D rb;
    
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        playerPos.x = Input.GetAxis("Horizontal");
        playerPos.y = Input.GetAxis("Vertical");

        rb.MovePosition(transform.position + playerPos * speed * Time.deltaTime);

        transform.right = new Vector3(playerPos.x, 0, 0);



    }
}
