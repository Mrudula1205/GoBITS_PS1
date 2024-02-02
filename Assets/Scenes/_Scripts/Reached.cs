using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Reached : MonoBehaviour
{
    public AudioSource audioSource;
    public NavMeshAgent agent;
    public GameObject panel;
    //public SceneSwitcher sceneSwitcher;
    public static Vector3[] idx = SceneSwitcher.idx;
    public static int[] Bidx = SceneSwitcher.bIdx;
    public static int count = SceneSwitcher.count;
    // Start is called before the first frame update
    void Start()
    {
        print("hey");
        audioSource.enabled = false;
        print(audioSource.enabled);
        panel.SetActive(false);
        
    }

    /*void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }*/

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == Bidx[1]+4)
        {
            
            if(agent.remainingDistance<=agent.stoppingDistance && !agent.pathPending)
            {
                
                panel.SetActive(true);
                audioSource.enabled= true;
            }
            else
            {
                
                panel.SetActive(false);
                audioSource.enabled = false;
            }
        }
        else
        {
            panel.SetActive(false);
            audioSource.enabled = false;
        }

    }

    

    public void close()
    {
        panel.SetActive(false);
    }

    public void goBacktoStart()
    {
        idx[0] = Vector3.zero; 
        Bidx[0] = 0;
        idx[1] = Vector3.zero; 
        Bidx[1] = 0;
        count = 0;
        SceneManager.LoadScene(1);
    }


}
