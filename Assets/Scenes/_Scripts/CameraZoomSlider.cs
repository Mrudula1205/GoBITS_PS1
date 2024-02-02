using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraZoomSlider : MonoBehaviour
{
    public float zoomSpeed = 0.1f; // Adjust this value to control the zoom speed
    public float minZoom = 1f;    // Minimum orthographic size
    public float maxZoom = 10f;   // Maximum orthographic size

    private float initialOrthoSize;
    private Vector2 initialTouchPosition;
    void Start()
    {
        initialOrthoSize = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (touch2.phase == TouchPhase.Began)
            {
                initialTouchPosition = (touch1.position + touch2.position) / 2f;
            }
            else if (touch1.phase == TouchPhase.Moved && touch2.phase == TouchPhase.Moved)
            {
                Vector2 currentTouchPosition = (touch1.position + touch2.position) / 2f;
                float pinchAmount = Vector2.Distance(currentTouchPosition, initialTouchPosition) * zoomSpeed;

                float newOrthoSize = Camera.main.orthographicSize - pinchAmount;
                Camera.main.orthographicSize = Mathf.Clamp(newOrthoSize, minZoom, maxZoom);
            }
        }
    }
}
