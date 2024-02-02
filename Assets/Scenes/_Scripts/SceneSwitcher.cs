using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public Dropdown dropdown;
    public static int count = 0;
    public static Vector3[] idx = new Vector3[2] {Vector3.zero, Vector3.zero};
    public static int[] bIdx = new int[2];
    public static int[] val= new int[2];
    public static string[] names = new string[2];

    public void PlayApp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void GoBack()
    {
        count=0;
        SceneManager.LoadScene(1);
    }
    public void End()
    {
        SceneManager.LoadScene(bIdx[0]+4);
    }

    public void Reset()
    {
        if(SceneManager.GetActiveScene().buildIndex == bIdx[1]+4)
        {
            idx[0] = Vector3.zero;
            idx[1] = Vector3.zero;
            bIdx[0] = 0;
            bIdx[1] = 0;
            //count = 0;
            //GoBack();
        }
        count = 0;
        GoBack();
    }

    public void changeFloor()
    {
        //dropdown = GetComponent<Dropdown>();
        switch (dropdown.value)
        {
            
            case 1: SceneManager.LoadScene(3); break;
            case 2: SceneManager.LoadScene(4); break;
            case 3: SceneManager.LoadScene(5); break;
            case 4: SceneManager.LoadScene(6); break;
        }
        
    }

    public void goNext()
    {

        if (idx[count]==Vector3.zero)
        {
            bIdx[count]= SceneManager.GetActiveScene().buildIndex;
            idx[count] = selectLandmark(bIdx[count], dropdown.value);
            val[count]= dropdown.value;
            names[count]= dropdown.options[val[count]].text;

        }
        
        count++;
        if(idx[1] == Vector3.zero)
        {

            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(bIdx[0]+4);
        }


    }

    public Vector3 selectLandmark(int currentSceneBuildIndex, int selectedIndex)
    {
        Vector3 currPos = Vector3.zero;
        switch(currentSceneBuildIndex) {
            case 3: switch(selectedIndex)
                {
                    case 1: currPos = new Vector3(702.8f, 992.4f, 0);break;
                    case 2: currPos = new Vector3(652.1f, 1545.4f, 0); break;
                    case 3: currPos = new Vector3(231f, 884f, 0); break;
                    case 4: currPos = new Vector3(544.8f, 1164.4f, 0); break;
                    case 5: currPos = new Vector3(382.4f, 790f, 0); break;
                    case 6: currPos = new Vector3(286.4f, 944.4f, 0); break;
                    case 7: currPos = new Vector3(249f, 848f, 0); break;
                    case 8: currPos = new Vector3(645f, 1075f, 0); break;
                    case 9: currPos = new Vector3(865.3f, 1412.2f, 0); break;
                    case 10: currPos = new Vector3(109.8f, 749.4f, 0); break;
                }
                break;
            case 4:
                switch (selectedIndex)
                {
                    case 1: currPos = new Vector3(689.5f, 1073.9f, 0); break;
                    case 2: currPos = new Vector3(204.7f, 787.6f, 0); break;
                    case 3: currPos = new Vector3(833f, 1305f, 0); break;
                    case 4: currPos = new Vector3(817.6f, 989.6f, 0); break;
                    case 5: currPos = new Vector3(809.4f, 1713.3f, 0); break;
                    case 6: currPos = new Vector3(913.8f, 1715.7f, 0); break;

                }
                break;
            case 5:
                switch (selectedIndex)
                {
                    case 1: currPos = new Vector3(827f, 905f, 0); break;
                    case 2: currPos = new Vector3(731.3f, 1086.9f, 0); break;
                    case 3: currPos = new Vector3(917f, 1422f, 0); break;
                    case 4: currPos = new Vector3(270f, 784.9f, 0); break;
                    
                }
                break;
            case 6:
                switch (selectedIndex)
                {
                    case 1: currPos = new Vector3(700f, 1076f, 0); break;
                    case 2: currPos = new Vector3(175.4f, 814.8f, 0); break;
                    case 3: currPos = new Vector3(870.5f, 1275.7f, 0); break;
                    case 4: currPos = new Vector3(623f, 1553f, 0); break;
                    case 5: currPos = new Vector3(951f, 1554f, 0); break;
                    case 6: currPos = new Vector3(886f, 1576f, 0); break;
                    case 7: currPos = new Vector3(149f, 1052f, 0); break;
                    case 8: currPos = new Vector3(440f, 947f, 0); break;
                }
                break;
        }
        return currPos;
    }
}


