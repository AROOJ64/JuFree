using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script on Player

public class PlayerStats : MonoBehaviour
{
    [Header("Health System Parameters")]
    [SerializeField] HealthBar healthBarUI;

    //
    [SerializeField] private Canvas GameOverCanvas;

    float maxHealth = 100;
    float currentHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBarUI.SetSliderMax(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
            Die();
    }

    public void TakeDamage(float amount)
    {
        //AudioManager.instance.PlaySFX("PlayerDamage");
        currentHealth -= amount;
        healthBarUI.SetSlider(currentHealth);
    }

    public void Heal(float amount)
    {
        //AudioManager.instance.PlaySFX("PlayerHeal");
        currentHealth += amount;
        healthBarUI.SetSlider(currentHealth);
    }

    public void Die()
    {
        //Death animation
        //GameConst.playerIsDead = true;
        //Time.timeScale = 0f;
        //AudioManager.instance.PlaySFX("PlayerDeath");
        //AudioManager.instance.PlayMusic("GameOver");
        GameOverCanvas.gameObject.SetActive(true);
       
        //disable any input script
        //Debug.Log("Dead");
    }
}
