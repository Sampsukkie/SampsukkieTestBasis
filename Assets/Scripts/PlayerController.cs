using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
//using DG.Tweening;

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

    //kutsutaan komentosarjan lataamisessa
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

    // Kutsutaan ensimmaisella kehyksella
    void Start()
    {
        //Application.targetFrameRate = -1;
        //Application.targetFrameRate = 60;

        playerSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        playerNator = GetComponent<Animator>();
    }

    // Kutsutaan joka kehyksella
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

    //Kutsutaan, kun peliobjekti tormaa laukaisijaan
    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    //Kutsutaan, kun peliobjekti tormaa toiseen tormaajaan
    private void OnCollisionEnter2D(Collision2D collider)
    {
        
    }
}
