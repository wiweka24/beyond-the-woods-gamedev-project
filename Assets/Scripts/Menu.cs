using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public GameObject PausePanel;

  // public void StartGame()
  // {
  //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  // }

  public void StartScene(string sceneName)
  {
    SceneManager.LoadScene(sceneName);
  }

  public void Pause()
  {
    PausePanel.SetActive(true);
    Time.timeScale = 0f;
  }

  public void Resume()
  {
    PausePanel.SetActive(false);
    Time.timeScale = 1f;
  }
}
