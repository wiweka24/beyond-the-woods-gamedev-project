using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
  private Rigidbody2D rb;
  private Animator anim;

  public bool onTrap;

  [SerializeField] private AudioSource deathSoundEffect;

  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("Trap"))
    {
      Die();
    }
  }

  private void Die()
  {
    deathSoundEffect.Play();
    rb.bodyType = RigidbodyType2D.Static;
    onTrap = true;
  }

  private void RestartLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}