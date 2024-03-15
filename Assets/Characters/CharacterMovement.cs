using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 12;
    private float movement;
    private Rigidbody2D rigid;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Debug.Log("Hello Word");
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2(movement * speed, rigid.velocity.y);

    }
}
