using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bulletVel : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

        Destroy(gameObject, 5);
    }

    void Flip()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            transform.Rotate(0, 180, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
