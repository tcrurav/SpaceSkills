using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipSceneController : MonoBehaviour
{
    public Material spaceShipMaterial;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Awake");
        RenderSettings.skybox = spaceShipMaterial;
    }
}
