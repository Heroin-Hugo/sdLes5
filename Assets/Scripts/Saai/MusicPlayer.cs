using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private bool isPlayingSong; 
    [SerializeField] private string currentSong;

    [SerializeField] private string[] playlist;

    private void Start()
    {
        IsPlaying();
        SetVolume(101f);
        PlaySong("Joey Valence & Brae - No Hands");
        Debug.Log("Now Playing: " + GetCurrentSong());
        IsPlaying();
        StopSong();
    }

    public void PlaySong(string songName)
    {
        currentSong = songName;

        Debug.Log("Now Playing: " + songName);

        isPlayingSong = true;
    }

    public void PlayRandomSong()
    {

        int randomInt = Random.Range(0, playlist.Length);
        currentSong = playlist[randomInt];

        Debug.Log(currentSong);

        isPlayingSong = true;
    }

    public string GetCurrentSong()
    {
        return currentSong;
    }

    public bool IsPlaying()
    {
        Debug.Log($"Is Playing: {isPlayingSong}");
        return isPlayingSong;
    }
    public void StopSong()
    {
        isPlayingSong = false;
        Debug.Log("Stopped song");
    }

    public void SetVolume(float volume) => Debug.Log($"Music Volume: {volume}");
}
