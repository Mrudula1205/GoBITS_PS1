using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomChange : MonoBehaviour
{
    public float ZoomChange, SmoothChange, minSize, maxSize;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            cam.orthographicSize -= ZoomChange * Time.deltaTime * SmoothChange;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cam.orthographicSize += ZoomChange * Time.deltaTime * SmoothChange;
        }
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minSize, maxSize);
    }
}
