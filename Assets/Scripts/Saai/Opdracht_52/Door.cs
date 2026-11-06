using UnityEngine;
using UnityEngine.UI;
public class Door : MonoBehaviour
{
    [SerializeField] private GameObject keyObj;
    [SerializeField] private Transform keySpawnPos;
    [Space]
    [SerializeField] private Text hintText;
    [Space]
    [SerializeField] private GameObject levelFinishedScreen;
    public bool canOpen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (canOpen)
            {
                FinishLevel();
            }
            else
            {
                hintText.text = "you need a key!";
                Instantiate(keyObj, keySpawnPos.position, Quaternion.identity);
            }
        }
        
    }

    private void FinishLevel()
    {
        GameScript.instance.BeatGame();
        hintText.gameObject.SetActive(false);
        levelFinishedScreen.SetActive(true);
    }
    public void UnlockDoor()
    {
        hintText.text = "go back to the door!";
        canOpen = true;
    }
}
