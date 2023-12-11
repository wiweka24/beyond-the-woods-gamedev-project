using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interacable : MonoBehaviour
{
  public bool isInRange;
  public KeyCode interactKey;
  public GameObject aButton;
  public GameObject panelSummary;
  public GameObject player;
  private Movement move;

  // if panel is dialog
  public bool isDialog;
  public Image[] images;
  private int currentImageIndex = 0;

  // Start is called before the first frame update
  void Start()
  {
    move = player.GetComponent<Movement>();
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
        move.canMove = false;

        // if dialog
        if (isDialog)
        {
          if (currentImageIndex < images.Length - 1)
          {
            currentImageIndex++;
            ShowImage(currentImageIndex);
          }
          else
          {
            panelSummary.SetActive(false);
            DisableImage();
            currentImageIndex = 0;
            move.canMove = true;
          }
        }
      }
    }
    else
    {
      aButton.SetActive(false);
    }

    if (Input.GetKeyDown(KeyCode.Escape))
    {
      panelSummary.SetActive(false);
      DisableImage();
      currentImageIndex = 0;
      move.canMove = true;
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

  void ShowImage(int indexToShow)
  {
    // Hide all images
    foreach (Image image in images)
    {
      image.enabled = false;
    }

    // Show the image at the specified index
    images[indexToShow].enabled = true;
  }

  void DisableImage()
  {
    // Hide all images
    foreach (Image image in images)
    {
      image.enabled = false;
    }
  }
}
