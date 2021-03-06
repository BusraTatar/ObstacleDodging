using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button pause;
    public Button restart;

    public GameObject pausePanel;
    public GameObject MenuPanel;
    public GameObject GameOverPanel;
    public GameObject WinPanel;
    public GameObject play;
    public GameObject scores;
    public GameObject life;
    

    

    void Start()
    {
        Time.timeScale = 0;

    }
    
    
    void Update()
    {

        
    }

    public void RestartEnter()
    { 
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game"); 
        MenuPanel.SetActive(false);
        
    }

    public void PauseEnter()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Play()
    {
        Time.timeScale = 1;
        MenuPanel.SetActive(false);
        scores.SetActive(true);
        play.SetActive(true);
        pause.gameObject.SetActive(true);
        life.gameObject.SetActive(true);
        
    }
    public void Resume()
    {
        WinPanel.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 1 ;
        
    }
   


}
