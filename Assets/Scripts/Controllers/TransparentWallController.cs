using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TransparentWallController : MonoBehaviour
{
    public GameObject transparentWall;
    public GameObject canvasMessage;
    public ContinuousMoveProviderBase continousMoveProvider;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Debug.Log("hit hit   Holaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        //Debug.Log(hit.collider.tag);
        //Debug.Log(hit.gameObject.CompareTag("TransparentWall"));
        if (hit.gameObject.tag.Contains("TransparentWall"))
        {
            DisableContinousMove();
            transparentWall.gameObject.SetActive(false);
            canvasMessage.gameObject.SetActive(true);
        }
    }

    private void DisableContinousMove()
    {
        continousMoveProvider.enabled = false;
    }

    private void EnableContinousMove()
    {
        continousMoveProvider.enabled = true;
    }

    public void OnClickContinue()
    {
        Debug.Log("OnClickContinue");
        EnableContinousMove();
        transparentWall.gameObject.SetActive(true);
        canvasMessage.gameObject.SetActive(false);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("collision   Holaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
    //    canvasMessage.gameObject.SetActive(true);
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("trigerr   Holaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
    //    canvasMessage.gameObject.SetActive(true);
    //}
}
