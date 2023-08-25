using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //player jump when screen is tapped
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector3(0, 12f, 0);
        }

        //player move forward on its own
        rb.velocity = new Vector3(4f, rb.velocity.y, 0);
    }
}
