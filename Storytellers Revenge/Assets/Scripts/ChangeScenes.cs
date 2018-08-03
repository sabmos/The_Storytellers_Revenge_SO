using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public Animator animator;

    private int levelToLoad;

	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            GoToScene("TitleScreen");
        }
        */
	}

    public void GoToMainMenu() {
        levelToLoad = 0;
        animator.SetTrigger("FadeOut");
    }

    public void GoToRainbow()
    {
        levelToLoad = 1;
        animator.SetTrigger("FadeOut");
    }

    public void GoToFerry() {
        levelToLoad = 2;
        animator.SetTrigger("FadeOut");
    }

    public void GoToCliffJump()
    {
        levelToLoad = 3;
        animator.SetTrigger("FadeOut");
    }

    public void GoToFar()
    {
        levelToLoad = 4;
        animator.SetTrigger("FadeOut");
    }

    public void GoToQatar()
    {
        levelToLoad = 5;
        animator.SetTrigger("FadeOut");
    }

    public void GoToCredits()
    {
        levelToLoad = 6;
        animator.SetTrigger("FadeOut");
    }

    public void LoadLevel ()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
