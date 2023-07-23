using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
//o valor bool do isRight está sempre no false
    public bool isRight; 
    public float speed;
    public Transform pointR;
    public Transform pointL;
    
    void Start()
    {
        
    }

    void Update()
    {
    if(isRight)
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    else
    {
        transform.Translate(-Vector2.right * speed * Time.deltaTime);
    }
    if(Input.GetMouseButton(0))
    {
        isRight = !isRight; 
    }
    //Checando se esta precionando o botão esquerdo do mouse ( 0 = esquerdo) (1 = direito)
    if(Vector2.Distance(transform.position, pointL.position) < 0.5 || Vector2.Distance(transform.position, pointR.position) < 0.5)
    {
        isRight = !isRight; //Para fazer a bola inverter
    }
    }
}
