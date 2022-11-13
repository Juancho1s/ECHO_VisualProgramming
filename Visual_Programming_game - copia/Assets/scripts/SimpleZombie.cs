using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SimpleZombie : MonoBehaviour
{

    public CharacterController FP;
    public float fov = 120f;
    public float viewDistance = 10f;    
    public bool isAware = true;

    private NavMeshAgent agent;
    private Renderer renderer;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        renderer = GetComponent<Renderer>();
    }

    public void Update()
    {

        if(isAware)
        {
            
            agent.SetDestination(FP.transform.position);
            renderer.material.color = Color.red;
            offAware();
        }
        else
        {
            searchForPlayer();
            renderer.material.color = Color.blue ;
        }
    }

    public void searchForPlayer()
    {
        if(Vector3.Angle(Vector3.forward, transform.InverseTransformPoint(FP.transform.position)) < fov / 2f  )
        {
            if(Vector3.Distance(FP.transform.position, transform.position) < viewDistance)
            {
                onAware();
            }
        }
    }

    public void offAware()
    {
        isAware = false;
    }

    public void onAware()
    {
        isAware = true;
    }

    // Start is called before the first frame update
    //void Start()
    //{
    //    
    //}

    // Update is called once per frame
    //void Update()
    //{
    //   
    //}

}
