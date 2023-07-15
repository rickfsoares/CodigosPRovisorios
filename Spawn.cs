using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float spawnTime; //tempo para spawnar os objetos
    private float timeCount; //Contador do Tempo

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeCount += Time.deltaTime;
        
        if(timeCount >= spawnTime) // Inicador do spawn
        {
            GameObject go = Instantiate(prefab, transform.position, transform.rotation, transform);
            Destroy(go, 5f); // para que depois de 5 segundos o objeto seja destruido
            timeCount = 0f;
        }
    }
}
