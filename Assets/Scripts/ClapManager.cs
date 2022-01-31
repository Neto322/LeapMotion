using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapManager : MonoBehaviour
{
    [SerializeField]
    float ClapDistance;

    [SerializeField]
    Transform hand1;

    [SerializeField]
    Transform hand2;


    float distance;

    bool ClapReady = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(hand1.position,hand2.position) <= ClapDistance && ClapReady == true)
        {
            Debug.Log("CLAP");
            ClapReady = false;
        }

        if(Vector3.Distance(hand1.position,hand2.position) >= ClapDistance)
        {
            ClapReady = true;

        }
    }
}
