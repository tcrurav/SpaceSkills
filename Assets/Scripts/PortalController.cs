using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour
{
    public GameObject portalActivation;
    public void TogglePortal()
    {
        if (portalActivation.activeSelf)
        {

            portalActivation.SetActive(false);
            return;
        }

        portalActivation.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("VideoTemplate");
    }
}
