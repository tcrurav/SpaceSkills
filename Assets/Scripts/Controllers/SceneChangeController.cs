using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    //private string[] videoNames; 
    //private void Start()
    //{
    //    initializeVideoArray();
    //}

    //private void initializeVideoArray()
    //{
    //    videoNames[0] = "GS010116-ArchivandoConTata.mp4";
    //    videoNames[1] = "GS010122-Conserjeria-PapelJustificante.mp4";
    //    videoNames[2] = "GS010123-Conserjeria-PidiendoLlaves.mp4";
    //    videoNames[3] = "GS010129-Presentación-Gisela.mp4";
    //    videoNames[4] = "GS010135-SalidasProfesionales.mp4";
    //    videoNames[5] = "GS010137-HectorAprendeAFotocopiar.mp4";
    //    videoNames[6] = "GS010139-UsoMaquinaPlastificar.mp4";
    //    videoNames[7] = "GS010144-FotocopiandoYAtendiendoTelefono.mp4";
    //}

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
