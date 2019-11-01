using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   // private Rigidbody2D rb;
    private float speed = 4.5f;
    void Start()
    {
       // controller = GetComponent<CharacterController>();
      // rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
      //  transform.Translate(Vector3.up * speed * Time.deltaTime);
     //  rb.MovePosition(Vector3.up*speed*Time.deltaTime);
     transform.position += new Vector3(0,4.5f * Time.deltaTime,0);
    }
}
