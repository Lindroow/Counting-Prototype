using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] string color;
    [SerializeField] int puntos;
    int indexColor;
    GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == color)
        {
            puntos++;
            switch (color)
            {
                case "Verde":
                    indexColor = 0;
                    break;
                case "Naranja":
                    indexColor = 1;
                    break;
                case "Rojo":
                    indexColor = 2;
                    break;
            }
            GameManager.puntajeColores[indexColor].text = "= " + puntos;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == color)
        {
            puntos--;
            switch (color)
            {
                case "Verde":
                    indexColor = 0;
                    break;
                case "Naranja":
                    indexColor = 1;
                    break;
                case "Rojo":
                    indexColor = 2;
                    break;
            }
            GameManager.puntajeColores[indexColor].text = "= " + puntos;
        }
    }

}
