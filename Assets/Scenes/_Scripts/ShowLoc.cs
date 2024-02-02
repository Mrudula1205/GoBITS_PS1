using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLoc : MonoBehaviour
{
    public Text start;
    public Text end;
    public static Vector3[] idx = SceneSwitcher.idx;
    public static string[] label = SceneSwitcher.names;
    
    // Start is called before the first frame update
    void Start()
    {
        print("label is :"+label[0] + " " + label[1]);
        showText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showText()
    {
        print(label[0] + " " + label[1]);
        start.text = label[0];
        end.text = label[1];
    }
}
