using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
  public Image[] images;
  private int currentImageIndex = 0;

  void Start()
  {
    // Show the first image and hide the rest
    ShowImage(currentImageIndex);
  }

  void Update()
  {
    // Check for input (e.g., key press or button click)
    if (Input.GetKeyDown(KeyCode.A))
    {
      // Move to the next image if available
      if (currentImageIndex < images.Length - 1)
      {
        currentImageIndex++;
        ShowImage(currentImageIndex);
      }
      else
      {
        Debug.Log("No more images!");
        // You can perform an action when there are no more images
      }
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
}
