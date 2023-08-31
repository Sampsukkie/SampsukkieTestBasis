using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    /* Muuttujat on jarjestetty seuraavasti:
     * 
     * 1. static
     * 2. Numerot
     * 3. Unity
     * 4. Booleanit (true/false)
     * 5. Muu
     * 
     * Public muuttujat ovat ylhaalla (PascalCase) privaatit alhaalla (camelCase)
     * 
     * 
     * 
     * Unity funktiot (Awake, Sart, jne.) nakyvat ennen muunneltuja 
     * (SetStartBoosting, SetStartingSound, jne.) funktioita
     * 
     * 
     */

    public static PlayerController Instance;

    private float playerSpeed;
    private float boostRecovery = 4.5f;
    private float nextBoost;

    private AudioSource playerSource;

    private Animator playerNator;

    Rigidbody2D rb;

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != null)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        playerSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        playerNator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.position += Vector3.right * playerSpeed * Time.deltaTime;

        if(rb.velocity.magnitude < playerSpeed)
        {

        }

        if(Time.time > nextBoost)
        {
            Debug.Log("BOOST");
            nextBoost = Time.time + boostRecovery;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        
    }
}
