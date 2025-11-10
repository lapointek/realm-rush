using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int baseHealth = 10;
    [SerializeField] int healthDecrease = 1;
    [SerializeField] Text healthText;
    [SerializeField] AudioClip playerDamageSFX;


    private void Start()
    {
        healthText.text = baseHealth.ToString();
    }

    private void OnTriggerEnter(Collider enemyCollider)
    {        
        GetComponent<AudioSource>().PlayOneShot(playerDamageSFX);
        baseHealth -= healthDecrease;
        healthText.text = baseHealth.ToString();
    }
}
