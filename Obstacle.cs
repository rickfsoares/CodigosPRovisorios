using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(-145, -45)));
    }

    // Update is called once per frame
    void FixedUpdate() // Toda vez que ultilizar fisica é bom usar o fixedUpadate
    {// para fazer o obstacle se mover
        rig.MovePosition(transform.position + transform.right * speed * Time.fixedDeltaTime);
    }
}