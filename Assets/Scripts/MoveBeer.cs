/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda al movimiento de los objetos de tipo beer.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBeer : MonoBehaviour
{
    // Start is called before the first frame update
    public float distance = 15;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Funcion para destruir los objetos de tipo beer
        if(transform.position.z > distance) {
            Destroy(gameObject);
        }  

        // Movimiento de los objetios de tipo beer
        transform.Translate(Vector3.forward*Time.deltaTime*20);
    }
}
