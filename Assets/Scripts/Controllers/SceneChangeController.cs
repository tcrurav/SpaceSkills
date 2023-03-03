using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    public void ChangeTo(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ChangeToVideoScene(string videoName)
    {
        SpaceShip.videoToLoad = videoName;
        ChangeTo("VRVideoScene");
    }
}
