using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float Jumpforce;

    private bool IsGrounded;
    private Vector3 _moveDirection;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(myPlayer: this);
        InputManager.SetGameControls();

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _moveDirection * speed * Time.deltaTime;
        CheckGrounded();
    }

    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;

    }

    public void Jump()

    {
        Debug.Log("jump called");
        if (IsGrounded )
        {
            rb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
        }
    }

    private void CheckGrounded()
    {
        IsGrounded = Physics.Raycast(origin: transform.position, direction: Vector3.down, GetComponent<Collider>().bounds.size.y);
        Debug.DrawRay(transform.position, Vector3.down * GetComponent<Collider>().bounds.size.y, Color.blue,0,false);
    }
  
    public void EquipGun()
    {
        Debug.Log("Gun Equipped");
    }
    public void UnEquipGun()
    {
        Debug.Log("Gun Unequipped");
    }
}