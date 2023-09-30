using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float spawnTime; //tempo para spawnar os objetos
    private float timeCount; //Contador do Tempo

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        
        if(timeCount >= spawnTime) // Inicador do spawn
        {
            GameObject go = Instantiate(prefab, transform.position, transform.localRotation);
            timeCount = 0f;
        }
    }
}
