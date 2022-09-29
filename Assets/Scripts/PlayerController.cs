/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda al player a moverse sobre su eje x
* de derecha a izquierda, y a su misma vez ayuda a instanciar objetos de tipo beer
* que seran lanzados por el player.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject proyectilBeer;

    // Start is called before the first frame update
    float horInput;
    float limiteMov = 20;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Funcion de movilidad sobre el eje x
        if(transform.position.x > limiteMov){
            transform.position = new Vector3(limiteMov,
            transform.position.y, transform.position.z);
        }
        // Funcion de movilidad sobre el eje x
        if(transform.position.x < -limiteMov){
            transform.position = new Vector3(-limiteMov,
            transform.position.y, transform.position.z);
        }
        // Funcion para instanciar objetos de tipo beer
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(proyectilBeer, transform.position,
            proyectilBeer.transform.rotation);
        }
        // Movilidad del player de manera horizontal
        float horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput);
    }
}
