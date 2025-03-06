using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 3;
    [SerializeField] private int health;
    [SerializeField] private float lerpSpeed;

    public static PlayerHealth instance;
    
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider healthSliderDelay;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        health = maxHealth;
    }

    private void Update() 
    {
        if(healthSlider.value != health)
        {
            healthSlider.value = health;
        }

        if (healthSlider != healthSliderDelay)
        {
            healthSliderDelay.value = Mathf.Lerp(healthSliderDelay.value, health, lerpSpeed);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= 1;

        if (health <= 0)
        {
            //player dead
        }
    }
}
