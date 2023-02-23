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
        //backgroundVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().clip =
        //    Resources.Load<UnityEngine.Video.VideoClip>("Videos360/" + panels.panels[currentVideoNumber].video);

        //string fileName = "GS010116-ArchivandoConTata.mp4";
        //Debug.Log(fileName);
        string persistentDataPath = Application.persistentDataPath;
        //Debug.Log(persistentDataPath);
        string path = Path.Combine(Path.Combine(persistentDataPath, "Videos360"), SpaceShip.videoToLoad);
        //Debug.Log(path);
        backgroundVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().url = path;
    }
}
