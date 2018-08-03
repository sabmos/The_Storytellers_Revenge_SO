using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoControl : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public UnityEngine.UI.Button nextButton;

    private UnityEngine.Video.VideoPlayer videoPlayer;
    private double minLength = 20;


    [SerializeField]
    private AudioSource audioSource;


    void Start()
    {
        videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();


        if (videoPlayer.clip != null)
        {
            videoPlayer.EnableAudioTrack(0, true);
            videoPlayer.SetTargetAudioSource(0, audioSource);

        }

    }

    //Check if input keys have been pressed and call methods accordingly.
    void Update()
    {
        //Play or pause the video.
        if (Input.GetKeyDown("space"))
        {
            if (videoPlayer.isPlaying)
                videoPlayer.Pause();
            else
                videoPlayer.Play();
            audioSource.Play();
        }

        if (!videoPlayer.isPlaying && !mainMenu.activeSelf) {
            mainMenu.SetActive(true);
            pauseMenu.SetActive(false);
        } else if (videoPlayer.isPlaying && mainMenu.activeSelf) {
            mainMenu.SetActive(false);
            pauseMenu.SetActive(true);
        }

        //  Change to next video at the end of the video

        if (videoPlayer.time >= minLength &&
            videoPlayer.frame >= (double)videoPlayer.frameCount - 100)
        {
            nextButton.onClick.Invoke();
        }
        Debug.Log(videoPlayer.frame.ToString() + " " + videoPlayer.frameCount.ToString());
    }

    public void Pause() {
        if (videoPlayer.isPlaying) 
            videoPlayer.Pause();
    }

    public void Play() {
        videoPlayer.Play();
        audioSource.Play();
    }

    public void Restart() {
        videoPlayer.Stop();
        videoPlayer.Play();
        audioSource.Play();
    }
}