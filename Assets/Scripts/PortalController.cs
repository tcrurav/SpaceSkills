using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour
{
    public AudioSource audioPortal;
    public GameObject portalActivation;
    public void TogglePortal()
    {
        if (portalActivation.activeSelf)
        {
            audioPortal.Stop();
            portalActivation.SetActive(false);
            return;
        }

        audioPortal.Play();
        portalActivation.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        audioPortal.Stop();
        SceneManager.LoadScene("VRVideoScene");
    }
}
