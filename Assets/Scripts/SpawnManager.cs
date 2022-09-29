/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda a crear a varios animales para que aparezcan
* en la pantalla aleatoriamente al momento de precionar una tecla.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] arrDogs;
    // Start is called before the first frame update
    void Start()
    { 
        // Invoca la repeticion de los animales
        InvokeRepeating("CreateAnimal", 1.5F, 1.5F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateAnimal()
    {
        // Variables para crear los rangos para la creacion de los animales
        int aleatorio = Random.Range(0, 3);
        int valX = Random.Range(-20,20);
        // Instanciacion de los animales
        Instantiate(arrDogs[aleatorio], new Vector3(valX, transform.position.y, -10), arrDogs[aleatorio].transform.rotation);

    }
}
