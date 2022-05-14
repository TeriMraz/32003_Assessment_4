using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using System;

public class egg02 : MonoBehaviour
{


    private Animator anim;
    private BoxCollider2D bx2d;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        bx2d = GetComponent<BoxCollider2D>();
        
    }

    // void ChangeLayer(Transform trans){
    //     // int count = trans.gameObject.layer.getSiblingIndex();
    //     trans.gameObject.layer = LayerMask.NameTolayer("StopWalkable");
    // }

    void hardTime(){
                bx2d.isTrigger = false;
                bx2d.enabled = true;
                // ChangeLayer();
                gameObject.layer = 6;
            }

    // Update is called once per frame
    void Update()
    {
 
    }
    
    void OnTriggerExit2D(Collider2D other){
        if(other.name=="player")
        {
            anim.SetTrigger("Collapse");
            Invoke("hardTime",0.1f);
            hardTime();
        }
    }
    void DisableBoxCollider2D(){
        bx2d.enabled = false;
    }
}
