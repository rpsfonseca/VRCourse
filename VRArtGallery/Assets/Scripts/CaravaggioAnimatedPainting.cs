using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaravaggioAnimatedPainting : Interactable
{
    public bool playing = false;
    public Light light;

    public UnityEngine.Video.VideoPlayer videoPlayer;

    public override void StartInteraction()
    {
        //PlayVideo();
        videoPlayer.Stop();
        //StartCoroutine("CallEnd");
        InteractionManager.RemoveCurrentInteractable();
        SceneManager.LoadScene(1);
    }

    public override void Interaction()
    {
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
        playing = true;
    }

    public override void EndInteraction()
    {
    }

    IEnumerator CallEnd()
    {
        yield return new WaitForSeconds(104);
        InteractionManager.RemoveCurrentInteractable();
    }
}
