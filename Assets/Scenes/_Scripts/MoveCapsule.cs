using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{
    public float moveSpeed = 1000.00f;
    public LineRenderer lineRenderer;
    public GameObject capsule;
    // Start is called before the first frame update
    void Start()
    {

        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
        lineRenderer.SetPosition(0,transform.position);
    }

    // Update is called once per frame
    void Update()
    {
    
        lineRenderer.SetPosition(lineRenderer.positionCount++, transform.position);

    }
}
