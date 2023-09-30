using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    private float changeDirectionTime = 2f;
    private float timeCount; 

    private Vector2 velocity;
    private Rigidbody2D rb; 

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        velocity = new Vector2(-1f, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move() 
    {
        timeCount += Time.deltaTime;

        if (timeCount >= changeDirectionTime) {
            velocity.x = Random.Range(-3f, 0f);
            velocity.y = Random.Range(-3f, 3f);
            Debug.Log(velocity.x);
            Debug.Log(velocity.y);
            timeCount = 0f;
        }

        rb.MovePosition(rb.position + velocity * Time.deltaTime);
        // Debug.Log(rb.position);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Enemy")) {
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        }
    }
}
