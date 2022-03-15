using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float Velocidad;
    float HorizontalInput;
    float VerticalInput;
    [SerializeField] float rotacion;
    [SerializeField] Animator compuertaDer;
    [SerializeField] Animator compuertaIzq;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical"); //Inpit Vertical
        HorizontalInput = Input.GetAxis("Horizontal"); //Input Horizontal

        transform.Rotate(Vector3.right * Velocidad * VerticalInput * Time.deltaTime); //Rotacion de la superficie en x
        transform.Rotate(Vector3.forward * Velocidad * HorizontalInput * Time.deltaTime); //Rotación de la superficie en z

        transform.rotation = new Quaternion(transform.rotation.x, 0, Mathf.Clamp(transform.rotation.z, -15f, 15f), 1f); //Límite de rotacion


        //Input de las compuertas (Si se precionan las teclas Shift o Espacio se abren las compuertas)
        if (Input.GetKey(KeyCode.Space))
        {
            compuertaDer.SetBool("CompuertaAbierta", true);
        }else
        {
            compuertaDer.SetBool("CompuertaAbierta", false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            compuertaIzq.SetBool("CompuertaIzqAbierta", true);
        }
        else
        {
            compuertaIzq.SetBool("CompuertaIzqAbierta", false);
        }
    }
}
