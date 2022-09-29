/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda a que al momento que el objeto del tipo
* beer, choque con el objeto de tipo perro, estos de destrullan.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Funcion de colicion para destruir objetos
    void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
    }
}
