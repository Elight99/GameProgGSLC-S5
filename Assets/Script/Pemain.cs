using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemain : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject rawImageVideo;
    public UbahScene gs;

    void Start()
    {
        rawImageVideo.SetActive(false);   
    }

    public void playerAttack()
    {
        playerAnimator.SetTrigger("IsAtk");
    }
    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }
   public void playVideo()
    {
        rawImageVideo.SetActive(true);
    }
    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }
    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(13.5f);
        gs.changeMyScene("Menu");
    }
}
