using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolTimeOBJClose : MonoBehaviour
{

    public GameObject bOomOff;
    float cTime;
    public float FalseTime;

    void Start()
    {

    }

    void Update()
    {
        cTime += Time.deltaTime;

        if (cTime > FalseTime)
        {

            bOomOff.SetActive(false);
            cTime = 0;


        }


    }
}
