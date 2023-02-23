using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToSpaceController : MonoBehaviour
{
    public void OnClickBackToSpace()
    {
        SceneManager.LoadScene("SciFiCorridorScene");
    }

    public void OnClickBackToSpaceship()
    {
        SceneManager.LoadScene("SpaceShipScene");
    }
}
