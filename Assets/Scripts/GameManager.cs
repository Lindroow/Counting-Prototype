using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI[] puntajeColores;
    [SerializeField] GameObject victoria;
    [SerializeField] int pelotasVerdes;
    [SerializeField] int pelotasNaranjas;
    [SerializeField] int pelotasRojas;
    int pelotasTotales;
    bool enJuego;
    Base BaseVerde;
    Base BaseNaranja;
    Base BaseRoja;

    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        Pausa();
        BaseVerde = GameObject.Find("Base Verde").GetComponent<Base>();
        BaseNaranja = GameObject.Find("Base Naranja").GetComponent<Base>();
        BaseRoja = GameObject.Find("Base Roja").GetComponent<Base>();
        playerController = GameObject.Find("Superficie").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        pelotasNaranjas = GameObject.FindGameObjectsWithTag("Naranja").Length;
        pelotasVerdes = GameObject.FindGameObjectsWithTag("Verde").Length;
        pelotasRojas = GameObject.FindGameObjectsWithTag("Rojo").Length;
        pelotasTotales = pelotasVerdes + pelotasNaranjas + pelotasRojas;
        if (pelotasVerdes == BaseVerde.puntos && pelotasNaranjas == BaseNaranja.puntos && pelotasRojas == BaseRoja.puntos && enJuego && pelotasTotales != 0 && !playerController.compuertasAbieras)
        {
            victoria.SetActive(true);
        }
    }

    public void Pausa()
    {
        Time.timeScale = 0;
        if (Time.timeScale == 0)
        {
            enJuego = false;
        }
        else { enJuego = true; }
    }
    public void Despausa()
    {
        Time.timeScale = 1;
        if (Time.timeScale == 0)
        {
            enJuego = false;
        }
        else { enJuego = true; }
    }

    public void Reintentar()
    {
        SceneManager.LoadScene("Counting prototype");
    }

    

}
