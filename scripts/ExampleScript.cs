using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // variables go here
    public int health = 4;
    public float speed = 2.4f;
    public string myName = "Richard";
    public bool wearsGlasses = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello " + myName);

        if (wearsGlasses) {
            Debug.Log("wears glasses");
        }
        else {
            Debug.Log("doesn't wear glasses");
        }

        if (health <= 0) {
            Debug.Log("game over");
        }
        else if(health <= 2) {
            Debug.Log("low health");
        }
        else
        {
            Debug.Log("doing great");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("updating");
    }
}
