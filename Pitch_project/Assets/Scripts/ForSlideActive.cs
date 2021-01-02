using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSlideActive : MonoBehaviour
{
    public GameObject myobject;
    public bool activateme;
    //private Vector2 touchPosition;
    
    void Start(){
        myobject.SetActive(false);
    }
    
    // bool ForActivation(){
    //     if(Input.touchCount > 0){
    //         return true;
    //     }
    //     return false;
    // }
    /*public GameObject SphereObject;


    void Update () {
    if (Input.touchCount > 0) {
    if (Input.GetTouch (0).phase == TouchPhase.Ended) {

    SphereObject.SetActive (true);

    }

    }
    */
    
    void Update()
    {
        if(Input.touchCount > 0){
            if(Input.GetTouch(0).phase == TouchPhase.Ended){
                myobject.SetActive(true);
            }
        }
    }
}
