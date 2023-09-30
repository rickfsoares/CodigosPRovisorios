using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 velocity;
    private Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        transform.Rotate(0f,0f,-90f, Space.Self);
    }
    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(3f, 3f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Enemy")) {

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
