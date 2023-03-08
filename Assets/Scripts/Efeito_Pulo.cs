using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efeito_Pulo : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private float speed;
    private float Move_H;
    private bool isJumping = false;
    private int doubleJump = 2;
    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Move_H = Input.GetAxis("Horizontal") * speed;

        transform.Translate(new Vector2(Move_H*Time.deltaTime, 0));
    }

    void Jump()
    {
        if (doubleJump > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rig.AddForce(new Vector2(0, force * Time.deltaTime), ForceMode2D.Impulse);
                doubleJump--;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grond"))
        {
            doubleJump = 2;
            isJumping= true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grond"))
        {
            
            isJumping = false;
        }
    }
}
