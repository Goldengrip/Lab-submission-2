using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float Jumpforce;
    [SerializeField] private LayerMask groundLayers;

    private bool IsGrounded;
    private Vector3 _moveDirection;

    private Rigidbody rb;
    private float depth;// makes game lag less when useing float instead of just using Getcomponent<collider> in the tranform position 

    public GameObject Projectiel;
    public Transform ProjectielPos;

    [SerializeField]
    private Weapon weapon;

    [Header("Player UI")]
    [SerializeField] private Image heathbar;
    

    [SerializeField] private float maxHealth;
    private int shotsRemaningCounter;
    private float _health;

    private float Health
    {
        get => _health;
        set
        {
            _health = value;
            heathbar.fillAmount = _health / maxHealth;
        }
    }

    private bool isAttacking;
    [SerializeField] private int maxAmmo = 15;
    [SerializeField] private int magSize = 10;
    [SerializeField] private int defaultAmmo = 5;
    private int currentAmmo;
    private int storedAmmo;


    
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(myPlayer: this);
        InputManager.SetGameControls();

        rb = GetComponent<Rigidbody>();
        depth = GetComponent<Collider>().bounds.size.y;

        Health = maxHealth;

       if (defaultAmmo > maxAmmo)
        currentAmmo = magSize;
    }

    // Allows movement 
    void Update()
    {
        transform.position += _moveDirection * speed * Time.deltaTime;
        CheckGrounded();

        Health -= Time.deltaTime * 5;

        if (Input.GetButtonDown("RELOAD"))
             Reload();
           
    }

    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;

    }

    public void Jump() //Makes block jump

    {
        Debug.Log("jump called");
        if (IsGrounded )
        {
            rb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
        }
    }

    private void CheckGrounded()
    {
        IsGrounded = Physics.Raycast(origin: transform.position, direction: Vector3.down, depth, groundLayers);
        Debug.DrawRay(transform.position, Vector3.down * depth, Color.blue,0,false);
    }
  
    public void EquipGun() // code types gun equipped
    {
        Debug.Log("Gun Equipped");
    }
    public void UnEquipGun() //this line of code type gun uneuipped 
    {
        Debug.Log("Gun Unequipped");
    }
    public void Shoot()
    {
        if(currentAmmo < 0)
            Reload();

        isAttacking = !isAttacking;
         if (isAttacking)
         {
            weapon.StartAttack();
            currentAmmo--;
         }
         else
         {
             weapon.EndAttack();
         }   
    }
    public void Reload()
    {
        int ammo = currentAmmo;
        currentAmmo += magSize - ammo;
        storedAmmo -= magSize - ammo;
    }

}