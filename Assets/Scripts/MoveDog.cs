/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda al movimiento de los objetos de tipo Dog
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDog : MonoBehaviour
{
    // Start is called before the first frame update
    float limite = 20;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Funcion para destruir a los objetos de tipo Dog cuando cruce los limites
        if(transform.position.z < -limite){
            Destroy(gameObject);
        }

        // Movimiento de los objetos de tipo Dog
        transform.Translate(Vector3.forward*Time.deltaTime*15);
    }
}
