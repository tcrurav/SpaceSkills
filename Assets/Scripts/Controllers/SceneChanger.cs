using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Material spaceShipMaterial;
    public Material sciFiCorridorMaterial;

    //public GameObject loadingCanvas;

    public void ChangeToSpaceShipScene()
    {
        Debug.Log("ChangeToSpaceShipScene");
        SceneManager.LoadSceneAsync("SpaceShipScene");

        //SceneManager.LoadScene("SpaceShipScene");
        //loadingCanvas.SetActive(true);
    }

    public void ChangeToSciFiCorridorScene()
    {
        Debug.Log("ChangeToSciFiCorridorScene");
        SceneManager.LoadSceneAsync("SciFiCorridorScene");

        //SceneManager.LoadScene("SciFiCorridorScene");
        //loadingCanvas.SetActive(true);
    }

    public void OnHover()
    {
        Debug.Log("Hover");
    }

    public void OnSelectToSpaceShip()
    {
        Debug.Log("Select");
        //ChangeWindowSkyboxToSpaceShip();
        ChangeToSpaceShipScene();
    }

    public void OnSelectToSciFiCorridor()
    {
        Debug.Log("Select");
        ChangeToSciFiCorridorScene();
    }

    public void OnActivate()
    {
        Debug.Log("Activate");
    }

    public void ChangeWindowSkyboxToSpaceShip()
    {
        Debug.Log("ChangeWindowSkyboxToSpaceShip");
        RenderSettings.skybox = spaceShipMaterial;
    }

    public void ChangeWindowSkyboxToSciFiCorridor()
    {
        Debug.Log("ChangeWindowSkyboxToSciFiCorridor");
        RenderSettings.skybox = sciFiCorridorMaterial;
    }
}
