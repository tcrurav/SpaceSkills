using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMessageController : MonoBehaviour
{
    public void OnContinueButtonClick(GameObject messageCanvas)
    {
        messageCanvas.gameObject.SetActive(false);
    }
}
