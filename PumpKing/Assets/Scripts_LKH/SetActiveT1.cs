using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveT1 : MonoBehaviour {

    public GameObject BBun;

   
    void Update()
    {

    }

    public void WindowOpen()
    {
        // Debug.Log("cl");
        BBun.SetActive(true);
        //BBun.GetComponent<TweenPosition>().PlayForward();


    }

    public void WindowClose()
    {
        BBun.SetActive(false);
        //BBun.GetComponent<TweenPosition>().PlayReverse();

    }
}
