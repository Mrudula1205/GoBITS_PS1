using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
//using static UnityEditor.PlayerSettings;


public class AgentMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 target;
    NavMeshAgent agent;
    public static Vector3[] indexes = SceneSwitcher.idx;
    static int[] Bindexes = SceneSwitcher.bIdx;
    int[] values = SceneSwitcher.val;
    static Vector3 startPos, endPos;
    public static Vector3[][] lifts = new Vector3[4][];

    public Vector3 callLift(Vector3 floor, int point)
    {
        
        lifts = new Vector3[4][];
        lifts[0] =
            new Vector3[]
            {
                new Vector3(307.4f, 801f, 0), new Vector3(598.7f, 1190.4f, 0), new Vector3(861f, 1457f, 0),
            };
        lifts[1] =
            new Vector3[]
            {
                new Vector3(283.5f, 691.4f, 0), new Vector3(617.7f, 1153.9f, 0), new Vector3(915.3f, 1469.4f, 0),
            };
        lifts[2] =
            new Vector3[]
            {
                new Vector3(287f, 697f, 0), new Vector3(654.3f, 1177.4f, 0), new Vector3(998.1f, 1492.4f, 0)
            };
        lifts[3] =
            new Vector3[]
            {
                new Vector3(279.1f, 765.9f, 0), new Vector3(643f, 1175f, 0), new Vector3(972.6f, 1450.5f, 0)
            };

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (lifts[i][j] == floor)
                {
                    floor = lifts[point][j];
                    break;
                }
            }
        }

        return floor;
    }



    void Start()
    {
        moveSprite();
    }

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame

    private void Update()
    {
        if (Bindexes[0] != Bindexes[1])
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (SceneManager.GetActiveScene().buildIndex == Bindexes[0] + 4)
                {
                    indexes[0] = callLift(nearestLift(Bindexes[0], values[0]), Bindexes[1]-3);
                    Bindexes[0] = Bindexes[1];
                    SceneManager.LoadScene(Bindexes[1] + 4);
                }
            }

        }
        
    }



    public void moveSprite()
    {
        agent.Warp(indexes[0]);
        

        if (Bindexes[0] != Bindexes[1])
        {
            //agent.Warp(indexes[0]);
            agent.SetDestination(nearestLift(Bindexes[0], values[0]));           
        }
        else
        {
            //agent.Warp(indexes[0]);
            agent.SetDestination(indexes[1]);
        }
        
    }   
    

    public Vector3 nearestLift(int currentSceneBuildIndex, int pos)
    {
        Vector3 currPos = Vector3.zero;
        switch (currentSceneBuildIndex)
        {
            case 3:
                switch (pos)
                {
                    case 3: case 5: case 6: case 7: case 10: currPos = new Vector3(307.4f, 801f, 0); break;
                    case 1: case 4: case 8: currPos = new Vector3(598.7f, 1190.4f, 0); break;
                    case 2: case 9: currPos = new Vector3(861f, 1457f, 0); break;
                    default: currPos = new Vector3(307.4f, 801f, 0); break;
                }
                break;
            case 4:
                switch (pos)
                {
                    case 2:  currPos = new Vector3(283.5f, 691.4f, 0); break;
                    case 1: case 4: currPos = new Vector3(617.7f, 1153.9f, 0); break;
                    case 3: case 5: case 6: currPos = new Vector3(915.3f, 1469.4f, 0); break;
                    default: currPos = new Vector3(283f, 812.4904f, 0); break;
                }
                break;
            case 5:
                switch (pos)
                {
                    case 4:  currPos = new Vector3(287f, 697f, 0); break;
                    case 1: case 2: currPos = new Vector3(654.3f, 1177.4f, 0); break;
                    case 3: currPos = new Vector3(998.1f, 1492.4f, 0); break;
                    default: currPos = new Vector3(292.7f, 697f, 0); break;
                }
                break;
            case 6:
                switch (pos)
                {
                    case 2: case 7: case 8: currPos = new Vector3(279.1f, 765.9f, 0); break;
                    case 1:  currPos = new Vector3(643f, 1175f, 0); break;
                    case 3: case 4: case 5: case 6: currPos = new Vector3(972.6f, 1450.5f, 0); break;
                    default: currPos = new Vector3(279.1f, 765.9f, 0); break;
                }
                break;
        }
        return currPos;
    }  

    
    
}





