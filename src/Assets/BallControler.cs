using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();    
    }

    private bool isSpace = false;
    private bool isLog = false;

    private void FixedUpdate()
    {
        if (isLog)
        {
            Debug.Log("Fixed");
        }
        if (isSpace)
        {
            isSpace = false;
            rigidbody.AddForce(new Vector2(Random.Range(-1000, 1000), Random.Range(-1000, 1000)));
            Debug.Break();
            isLog = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        isLog = false;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpace = true;
        }
    }
}
