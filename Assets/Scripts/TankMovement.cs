using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Rigidbody2D myBodyy;

    // Start is called before the first frame update
    void Start()
    {
     myBodyy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiztonal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horiztonal, vertical);
        movement.Normalize();
        myBodyy.velocity = movement * moveSpeed;

    }
}
