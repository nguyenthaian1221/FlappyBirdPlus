using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private float dirX;
    private float dirY;
    private float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = false;
    private Vector3 localScale;
    private float timePressed =0f;

    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirX = 1f;
        dirY = 1f;
        moveSpeed = 1.5f;

    }

    private void Update()
    {
        transform.Translate(new Vector2(1f, 0f) * dirX * Time.deltaTime * moveSpeed);
        keyPressedTimer();
            
        
    }


    private void FixedUpdate()
    {
        //transform.Translate(new Vector2(0f, 1f) * dirY * Time.deltaTime * moveSpeed);
        
        
        
        

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallTop"))
        {
            dirY *= -1f;
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            dirX *= -1f;
        }

    }
    //void FixedUpdate()
    //{


    // if (Input.GetMouseButtonDown(0))
    // {
    //    rb.velocity = dirY * transform.up * moveSpeed; ;
    //}
    // else if (Input.GetMouseButtonUp(0))
    // {
    //    rb.velocity = dirX * transform.right * moveSpeed;
    // }



    //}

    private void LateUpdate()
    {
        CheckWhereToFace();
    }
    void CheckWhereToFace()
    {
        if (dirX > 0)
        {
            facingRight = true;
        }
        else if (dirX < 0)
        {
            facingRight = false;
        }

        if (((facingRight) && localScale.x < 0) || ((!facingRight) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }
        transform.localScale = localScale;
    }
    public void Death()
    {
        Destroy(gameObject);

    }

    void keyPressedTimer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timePressed = Time.time;
        }

        if (Input.GetMouseButtonUp(0))
        {
            timePressed = Time.time - timePressed;
            transform.Translate(new Vector2(0f, 0.5f) * dirY * timePressed * moveSpeed);
        }
        

    }
    void resetTimer()
    {
        timePressed = 0f;
    }
}


