using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MainController : MonoBehaviour
{
    public GameObject videoPlayer = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VideoStart()
    {
        videoPlayer.SetActive(true);
    }
}
