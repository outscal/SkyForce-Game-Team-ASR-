using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 4.5f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        controller.Move(Vector3.up * speed * Time.deltaTime);
    }
}
