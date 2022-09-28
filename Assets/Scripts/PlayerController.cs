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
        if(transform.position.x > limiteMov){
            transform.position = new Vector3(limiteMov,
            transform.position.y, transform.position.z);
        }

        if(transform.position.x < -limiteMov){
            transform.position = new Vector3(-limiteMov,
            transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(proyectilBeer, transform.position,
            proyectilBeer.transform.rotation);
        }

        float horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput);
    }
}
