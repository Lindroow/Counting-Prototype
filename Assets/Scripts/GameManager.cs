using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI[] puntajeColores;
    [SerializeField] int pelotasVerdes;
    [SerializeField] int pelotasNaranjas;
    [SerializeField] int pelotasRojas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pelotasVerdes = GameObject.FindGameObjectsWithTag("Verde").Length;
    }

    

}
