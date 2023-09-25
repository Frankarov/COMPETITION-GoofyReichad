using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject OptionMenu;
    public int PauseInd = 0;
    public int OptionInd = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && PauseInd == 0 && OptionInd == 0)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && PauseInd == 1 && OptionInd == 0)
        {
            ResumeTime();

        }
    }

    public void Pause()
    {

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseInd = 1;
        

    }

    public void ResumeTime()
    {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            PauseInd = 0;
    }

    public void Option()
    {
        pauseMenu?.SetActive(false);
        OptionMenu.SetActive(true);
        OptionInd = 1;
    }

    public void OptionBack()
    {
        OptionMenu.SetActive(false);
        pauseMenu?.SetActive(true);
        OptionInd = 0;
    }

    public void MainMenu(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

}
