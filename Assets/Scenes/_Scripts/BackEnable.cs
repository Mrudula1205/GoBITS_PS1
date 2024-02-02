using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackEnable : MonoBehaviour
{

    public Button start;
    //public string newLable = "Start";
    public static Vector3[] indexes = SceneSwitcher.idx;
    // Start is called before the first frame update
    void Start()
    {
        start.GetComponentInChildren<Text>().text = "Start Location";
    }

    // Update is called once per frame
    void Update()
    {
        if (indexes[0]!=Vector3.zero)
        {
            start.GetComponentInChildren<Text>().text = "End Location";
        }
        else
        {
            start.GetComponentInChildren<Text>().text = "Start Location";
        }
    }


}
