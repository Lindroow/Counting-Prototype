using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] Pelotas;
    [SerializeField] TMP_Dropdown lstNumeroPelotas;
    Vector3 randomPos;
    int Indice;
    [SerializeField] int numPelotas;

    // Start is called before the first frame update
    void Start()
    {
        Indice = lstNumeroPelotas.value;
        indexLst(Indice);
        SpawnPelotas(numPelotas);
    }

    private void SpawnPelotas(int numeroPelotas)
    {
        for (int i = 0; i < numeroPelotas; i++)
        {
            randomPos = new Vector3(Random.Range(-6f, 6f), 5f, Random.Range(-0.5f, 2.5f));
            Instantiate(Pelotas[Random.Range(0, Pelotas.Length)], randomPos, Quaternion.identity);
        }
        
    }

    private void indexLst(int Index)
    {

        switch (Index)
        {
            case 0:
                numPelotas = 3;
                break;
            case 1:
                numPelotas = 6;
                break;
            case 2:
                numPelotas = 9;
                break;
        }
    }
}
