using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 10;

    private int monedas;
    
    private Rigidbody miRigidbody;
    private Vector3 posicionInicial;

    private void Start()
    {
        miRigidbody = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        
        miRigidbody.AddForce(new Vector3(horizontal, 0, vertical) * velocidad);
    }

    private void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("salida"))
        {
            Debug.Log("Has salido, enhorabuena. Has recogido " + monedas + "monedas");
        }
        else if (otro.CompareTag("enemigo"))
        {
            miRigidbody.MovePosition(posicionInicial);
            miRigidbody.velocity = Vector3.zero;
            miRigidbody.angularVelocity = Vector3.zero;
        }
        else if (otro.CompareTag("moneda"))
        {
            otro.gameObject.SetActive(false);
            monedas = monedas + 1;
        }
    }
}
