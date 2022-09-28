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
        if(transform.position.z < -limite){
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward*Time.deltaTime*15);
    }
}
