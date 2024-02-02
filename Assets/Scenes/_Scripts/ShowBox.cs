using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBox : MonoBehaviour
{
    public GameObject popUpPanel;
    // Start is called before the first frame update
    void Start()
    {
        popUpPanel.SetActive(false);
    }

    // Update is called once per frame
    public void ShowPopUp()
    {
        // Show the pop-up panel
        popUpPanel.SetActive(true);
    }

    public void ClosePopUp()
    {
        // Hide the pop-up panel
        popUpPanel.SetActive(false);
    }
}
