using UnityEngine;

public class SaaiScript : MonoBehaviour
{
    //Tip: Met een header kun je titels plaatsen in de inspector
    [Header("Character Info")]
    public string playerName = "EdwardRobinson234";
    public int level = 1;
    public enum CharacterClass
    {
        Tank, Gnome, Wizard, Assassin
    }
    public CharacterClass characterClass;
    //add your own stats here

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;
    public int mana = 50;
    public int attack = 50;
    public int defense = 5;
    //add your own stats here

    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 150;
    public float playtimeHours = 2.5f;
    public bool hasCompletedTutorial = true;
    //add your own stats here

    [Header("Inventory")]
    public int healthPotions = 3;
    public int keys = 1;
    public string currentWeapon = "Raygun";
    //add your own stats here
    private void Start() => DisplayCharacterSheet();
    

    private void Update()
    {
        // Input om stats te updaten
        if (Input.GetKeyDown(KeyCode.L)) LevelUp();
        if (Input.GetKeyDown(KeyCode.H)) Heal();
        if (Input.GetKeyDown(KeyCode.I)) DisplayCharacterSheet();
        //Reset Stats here when R is pressed!
        if(Input.GetKeyDown(KeyCode.R)) ResetStats();   
    }

    private void LevelUp()
    {
        //Level UP!
        level++;
        maxHealth += 20;
        health = maxHealth; // Full heal bij level up
        attack += 5;
        defense += 3;
        mana += 10;

        Debug.Log("LEVEL UP! Now level " + level);
        Debug.Log("Stats increased!");
    }
    private void Heal()
    {
        //Use Health Potion
        if (healthPotions > 0 && health < maxHealth)
        {
            healthPotions--;
            health += 30;
            if (health > maxHealth) health = maxHealth;

            Debug.Log("Used health potion! Health: " + health + "/" + maxHealth);
            Debug.Log("Potions remaining: " + healthPotions);
        }
        else if (healthPotions <= 0)
        {
            Debug.Log("No health potions left!");
        }
        else
        {
            Debug.Log("Health is already full!");
        }
    }
    private void ResetStats()
    {
        level = 0;
        gold = 0;
        playtimeHours = 0;
        attack = 5;
        defense = 0;

        hasCompletedTutorial = false;

        playerName = "Noob";
        currentWeapon = "Fisticuffs";

        DisplayCharacterSheet();
    }
    private void DisplayCharacterSheet()
    {
        //Display Character Sheet
        Debug.Log("=== CHARACTER SHEET ===");
        Debug.Log("Name: " + playerName + " the " + characterClass);
        Debug.Log("Level: " + level);
        Debug.Log("Health: " + health + "/" + maxHealth);
        Debug.Log("Mana: " + mana);
        Debug.Log("Attack: " + attack + " | Defense: " + defense);
        Debug.Log("Experience: " + experience + " XP");
        Debug.Log("Gold: " + gold + " coins");
        Debug.Log("Playtime: " + playtimeHours + " hours");
        Debug.Log("Current Weapon: " + currentWeapon);
        Debug.Log("Items: " + healthPotions + " health potions, " + keys + " keys");
        Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
        Debug.Log("========================");
    }
}