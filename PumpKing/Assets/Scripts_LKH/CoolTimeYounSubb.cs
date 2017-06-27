using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolTimeYounSubb : MonoBehaviour
{
    public GameObject bOomEndControl;
    public GameObject bOomBotton;

    int count = 5;
    public bool eTime = false;
    public float cOolTime = 0;
    public float EndCoolTime;

    void Update()
    {
        //Debug.Log(Time.timeScale);
        if (eTime == true)
        {
            bOomBotton.SetActive(false);
            cOolTime += Time.deltaTime;
            //Debug.Log("2");
            if (cOolTime > EndCoolTime)
            {
                bOomBotton.SetActive(true);
                cOolTime = 0;
                eTime = false;
                //Debug.Log("2_Q");
            }
        }
    }

    public void BooMEnd()
    {
        count--;
        //Debug.Log("1");
        eTime = true;
        if (count == 0)
        {
            bOomEndControl.SetActive(false);
            //Debug.Log("1_Q");          
        }
    }
}
