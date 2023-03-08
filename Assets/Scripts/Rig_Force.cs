using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rig_Force : MonoBehaviour
{
    [SerializeField] private float force;
    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AddForce();
    }

    void AddForce()
    {
        if (this.gameObject.CompareTag("Ghost"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rig.AddForce(new Vector2(0, force * Time.deltaTime), ForceMode2D.Impulse);
            }
        }
        
    }
}
