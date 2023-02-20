using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipSceneController : MonoBehaviour
{
    //public Material spaceShipMaterial;

    public GameObject group1Left;
    public GameObject group1Right;
    public GameObject group2Left;
    public GameObject group2Right;
    public GameObject group3Left;
    public GameObject group3Right;
    public GameObject group4Left;
    public GameObject group4Right;

    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Awake");
        //RenderSettings.skybox = spaceShipMaterial;
        switch (SpaceShip.Name)
        {
            case "Group-1":
                group1Left.gameObject.SetActive(true);
                group1Right.gameObject.SetActive(true);
                break;
            case "Group-2":
                group2Left.gameObject.SetActive(true);
                group2Right.gameObject.SetActive(true);
                break;
            case "Group-3":
                group3Left.gameObject.SetActive(true);
                group3Right.gameObject.SetActive(true);
                break;
            case "Group-4":
                group4Left.gameObject.SetActive(true);
                group4Right.gameObject.SetActive(true);
                break;
        }
    }
}
