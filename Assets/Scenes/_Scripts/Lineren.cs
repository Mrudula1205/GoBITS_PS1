using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lineren : MonoBehaviour

{
    // Start is called before the first frame update
    public LineRenderer lineRenderer;
    
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
        lineRenderer.SetPosition(0, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        int currentPosition = lineRenderer.positionCount++;
        lineRenderer.SetPosition(currentPosition, transform.position);
        
    }   
}
