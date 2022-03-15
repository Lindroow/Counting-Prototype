using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] Pelotas;
    Vector3 randomPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnPelotas(3);
        }
    }

    private void SpawnPelotas(int numeroPelotas)
    {
        for (int i = 0; i < numeroPelotas; i++)
        {
            randomPos = new Vector3(Random.Range(-6f, 6f), 5f, Random.Range(-0.5f, 2.5f));
            Instantiate(Pelotas[Random.Range(0, Pelotas.Length)], randomPos, Quaternion.identity);
        }
        
    }
}
