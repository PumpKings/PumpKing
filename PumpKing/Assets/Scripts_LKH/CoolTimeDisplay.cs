using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolTimeDisplay : MonoBehaviour
{

    public GameObject coolDisplaySprite;
    
    float cool;
    public float MaxCoolTime;
    public float coolTime;

    void Start ()
    {
        coolTime = MaxCoolTime;
    }	
	
	void Update ()
    {

        coolTime -= Time.deltaTime;
        cool = coolTime/MaxCoolTime;
        coolDisplaySprite.GetComponent<UISprite>().fillAmount = cool;
        
        if (coolTime <= 0)
        {
            coolTime = MaxCoolTime;
            coolDisplaySprite.SetActive(false);
        }

    }
}
