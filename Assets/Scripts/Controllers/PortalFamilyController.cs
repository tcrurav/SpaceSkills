using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PortalFamilyController : MonoBehaviour
{
    public AudioSource audioPortal;
    public GameObject portalActivation;
    public Dropdown dropdown;
    public Dropdown dropdownInFrontOf;
    public Toggle toggle;
    public Toggle toggleInFrontOf;
    public string videoToLoad;

    public GameObject messageCanvas;
    public void TogglePortal()
    {
        if (SpaceShip.justChangedToggle)
        {
            SpaceShip.justChangedToggle = false;
            return;
        }

        SpaceShip.justChangedToggle = true;
        toggleInFrontOf.isOn = toggle.isOn;

        if (portalActivation.activeSelf)
        {
            dropdown.interactable = true;
            dropdownInFrontOf.interactable = true;

            audioPortal.Stop();
            portalActivation.SetActive(false);
            return;
        }

        dropdown.interactable = false;
        dropdownInFrontOf.interactable = false;

        audioPortal.Play();
        portalActivation.SetActive(true);
        SpaceShip.videoToLoad = videoToLoad != null ? videoToLoad : "";

        //messageCanvas = GameObject.Find(SpaceShip.MESSAGE_CANVAS);
        messageCanvas.gameObject.SetActive(true);
    }
}
