using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{
    private bool paused;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) ) {
            Pause();
        }
    }
    public void Pause() {
        if (!paused)
        {
            Time.timeScale = 0.0f;
            paused = true;
            pauseMenu.SetActive(true);
        }
        else {
            Time.timeScale = 1.0f;
            paused = false;
            pauseMenu.SetActive(false);
        }
    }
}
