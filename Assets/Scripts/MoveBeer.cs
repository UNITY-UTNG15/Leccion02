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
        if(transform.position.z > distance) {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward*Time.deltaTime*20);
    }
}
