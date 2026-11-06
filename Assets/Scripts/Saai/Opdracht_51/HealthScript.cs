using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class HealthScript : MonoBehaviour
{
    [Header("Damage")]
    [SerializeField] private int damageAmount;
    [SerializeField] private int healingAmount;

    [Header("Health")]
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;

    [Header("UI")]
    [SerializeField] private Slider healthBar;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI healthWarningText;
    [SerializeField] private CanvasGroup hurtBorder;

    private bool isDead;
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;

        DisplayHealthEffects();
    }

    private void Update()
    {
        if (isDead) return;
        if (Input.GetKeyDown(KeyCode.J)) TakeDamage(damageAmount);
        if (Input.GetKeyDown(KeyCode.H)) TakeDamage(-healingAmount);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth < 0) currentHealth = 0;
        if (currentHealth > maxHealth) currentHealth = maxHealth;

        DisplayHealthEffects();
    }

    private void DisplayHealthEffects()
    {
        healthText.text = currentHealth.ToString();
        healthBar.value = currentHealth;

        float chFloat = currentHealth;
        float mhFloat = maxHealth;

        hurtBorder.alpha = 1 - chFloat / mhFloat;

        switch(currentHealth)
        {
            case > 80:
                healthWarningText.text = "Alive and kicking";
                break;
            case > 60:
                healthWarningText.text = "Doing allright";
                break;
            case > 40:
                healthWarningText.text = "Watch OUT bro";
                break;
            case > 20:
                healthWarningText.text = "Retreat bro :sob:";
                break;
            case > 0:
                healthWarningText.text = "You're donezo";
                break;
            case <= 0:
                healthWarningText.text = "Game Over";
                isDead = true;
                break;
        }
    }
}
