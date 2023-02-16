using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;


public class HomePanelController : MonoBehaviour
{
    public AudioSource audioClickPanel;
    public string spaceShipName;

    //public XRRayInteractor rayInteractor;

    public void OnClickPanel()
    {
        audioClickPanel.Play();
        SpaceShip.Name = spaceShipName;
        SceneManager.LoadScene("SciFiCorridorScene");
    }

}