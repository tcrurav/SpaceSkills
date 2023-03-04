using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;


public class HomePanelController : MonoBehaviour
{
    public AudioSource audioClickPanel;
    public string spaceShipName;
    public GameObject loadingCanvas;

    public void OnClickPanel()
    {
        audioClickPanel.Play();
        SpaceShip.groupName = spaceShipName;
        loadingCanvas.SetActive(true);
    }

}