using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
  private Rigidbody2D rb;
  private Animator anim;


  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("NextLevel"))
    {
      GoToNextLevel();
    }
    else if (collision.gameObject.CompareTag("End"))
    {
      GoToMainMenu();
    }
  }

  private void GoToNextLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  private void GoToMainMenu()
  {
    SceneManager.LoadScene(0);
  }
}