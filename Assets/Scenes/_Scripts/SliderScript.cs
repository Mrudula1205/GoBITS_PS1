using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;
    public GameObject targetObject;
    //public Canvas canvas;
    public float minZoom = 0.5f;
    public float maxZoom = 2f;

    private Vector3 initialScale;
    //private float initialScale;


    // Start is called before the first frame update
    void Start()
    {
        // Add a listener to the slider's OnValueChanged event
        slider.onValueChanged.AddListener(OnSliderValueChanged);

        // Record the initial scale of the canvas
        initialScale = targetObject.transform.localScale;
        //initialScale = canvas.scaleFactor;
    }

    void OnSliderValueChanged(float value)
    {
        float zoomScale = Mathf.Lerp(minZoom, maxZoom, value);
        targetObject.transform.localScale = initialScale * zoomScale;
        //canvas.scaleFactor = initialScale * zoomScale;
    }
}


//Screenshot 2023-07-03 at 11.51.00 AM (1)
