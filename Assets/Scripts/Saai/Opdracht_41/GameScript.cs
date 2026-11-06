using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public static GameScript instance;

    [Header("Kill Player")]
    [SerializeField] private GameObject playerObj;
    [SerializeField] private GameObject killPlayerPart;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private GameObject coinText;
    public bool canDie = true;
    private bool listensToKeycode;

    private void Start()
    {
        if (instance != null && instance != this) Destroy(this);
        else instance = this;
    }

    private void Update()
    {
        if (!listensToKeycode) return;
        else if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BeatGame() => canDie = false;
    public void KillPlayer()
    {
        listensToKeycode = true;

        deathScreen.SetActive(true);
        coinText.SetActive(false);  

        Instantiate(killPlayerPart, playerObj.transform.position, Quaternion.identity);
        Destroy(playerObj);
    }
}
