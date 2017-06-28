using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolTimeYounSubb : MonoBehaviour
{
    public GameObject CoolTimeControl;
    public GameObject SkillBotton;
    public GameObject CoolTimeDisplay;
    public GameObject CoolTimeEndDisplay;

    int count = 5;
    public bool eTime = false;
    public float cOolTime = 0;
    public float EndCoolTime;

    void Update()
    {
        //Debug.Log(Time.timeScale);
        if (eTime == true)
        {            
            SkillBotton.SetActive(false);
            cOolTime += Time.deltaTime;
            //Debug.Log("2");
            if (cOolTime > EndCoolTime)
            {                
                SkillBotton.SetActive(true);
                cOolTime = 0;
                eTime = false;
                //Debug.Log("2_Q");
            }
        }
    }

    public void SkillCoolTime()
    {
        count--;
        Debug.Log(count);
        eTime = true;

        CoolTimeDisplay.SetActive(true);

        
        if (count == 0)
        {
            CoolTimeControl.SetActive(false);
            CoolTimeEndDisplay.SetActive(true);
        }
    }
}
