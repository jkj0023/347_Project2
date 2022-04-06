using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 10f;
    public Rigidbody2D rb;

    private float moveX;
    public int key = 0;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;

    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }

    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     if (col.gameObject.tag == "Key")
    //     {
    //         key++;
    //         Destroy(col.gameObject);
    //         print("Key has been obtained. Go to the finish line");
    //     }
    // }
}
