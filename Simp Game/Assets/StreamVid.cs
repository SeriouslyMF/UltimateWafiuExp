using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVid : MonoBehaviour
{

    public RawImage rawImg;
    public VideoPlayer videoPlayer;
    //public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVideo())
;    }

   IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitforSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return waitforSeconds;
            break;
        }

        rawImg.texture = videoPlayer.texture;
        videoPlayer.Play();
        //audioSource.Play();
    }
}
