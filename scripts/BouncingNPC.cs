using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingNPC : MonoBehaviour
{
    Vector2 direction = Vector2.right;
    Rigidbody2D rBody;
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();

        int randomNumber = Random.Range(0, 2);

        if(randomNumber == 0)
        {
            direction = Vector2.up;
        }
        if(randomNumber == 1)
        {
            direction = Vector2.right;
        }

        speed = Random.Range(2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 newPos = rBody.position + (direction * speed * Time.fixedDeltaTime);
        rBody.MovePosition(newPos);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction *= -1;
    }
}
