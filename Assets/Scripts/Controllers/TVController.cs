using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TVController : MonoBehaviour
{
    public GameObject tvVideoPlayer;
    public UnityEngine.UI.RawImage tvRawImageThumbnail;
    public UnityEngine.UI.RawImage tvRawImage;

    public GameObject tvVideoPlayerInFrontOf;
    public UnityEngine.UI.RawImage tvRawImageThumbnailInFrontOf;


    private void Awake()
    {
        ////Set time of the VideoPlayer to 0
        //tvVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().time = 1;
        ////Plays the video for one frame
        //tvVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
        ////Sets the frame to display on the RawImage
        //tvRawImage.texture = tvVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().texture;
        ////Pauses the video after one frame so that the first frame
        ////of the video is displayed during idle
        //tvVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().Pause();
    }

    public void OnHover()
    {
        Debug.Log("Hover");
    }

    public void OnSelectPlayOrStop()
    {
        Debug.Log("OnSelectPlayOrStop");
        if (tvVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().isPlaying)
        {
            tvRawImageThumbnail.gameObject.SetActive(true);
            tvVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().Stop();
            return;
        }

        if (tvVideoPlayerInFrontOf.GetComponent<UnityEngine.Video.VideoPlayer>().isPlaying)
        {
            tvRawImageThumbnailInFrontOf.gameObject.SetActive(true);
            tvVideoPlayerInFrontOf.GetComponent<UnityEngine.Video.VideoPlayer>().Stop();
        }

        tvRawImageThumbnail.gameObject.SetActive(false);
        tvVideoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
    }

    public void OnActivate()
    {
        Debug.Log("Activate");
    }

  

    
}
