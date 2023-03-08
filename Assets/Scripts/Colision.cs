using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Codigo para detectar colisoes entre dois game objects
        if(collision.gameObject.CompareTag("Ghost"))
        {
            Destroy(collision.gameObject);
        }
    }
}
