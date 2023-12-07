using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacable : MonoBehaviour
{
  public bool isInRange;
  public KeyCode interactKey;
  // public UnityEvent interactAction;
  public GameObject aButton;
  public GameObject panelSummary;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (isInRange)
    {
      aButton.SetActive(true);
      if (Input.GetKeyDown(interactKey))
      {
        panelSummary.SetActive(true);
      }
    }
    else
    {
      aButton.SetActive(false);
    }

    if (Input.GetKeyDown(KeyCode.Escape))
    {
      panelSummary.SetActive(false);
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      isInRange = true;
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      isInRange = false;
    }
  }
}
