using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadVideoController : MonoBehaviour
{
    public GameObject backgroundVideoPlayer;

    private void Awake()
    {
        UpdateCurrentVideo();
    }
    
    public void UpdateCurrentVideo()
    {
        string persistentDataPath = Application.persistentDataPath;
        string path = Path.Combine(Path.Combine(persistentDataPath, "Videos360"), SpaceShip.videoToLoad);
        backgroundVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().url = path;
    }
}
