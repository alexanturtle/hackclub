using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public SpriteRenderer sRenderer;
    Color changeColor = Color.red;
    Color baseColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            sRenderer.color = changeColor;
        }
        else
        {
            sRenderer.color = baseColor;
        }
    }
}
