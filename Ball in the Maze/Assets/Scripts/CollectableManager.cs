using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    // public CollectableManager collectableManager;
    int childCount=0;


    public bool allCoinsCollected = false;
    // [HideInInspector] public bool allCoinsCollected = false;// With this,you can hide a public variable in the inspector
    // [SerializeField] private int x;//With this,you can show a private variable in the inspector
    private void Start(){
        childCount = transform.childCount;
    }
    private void Update(){
        // Check if the count of child objects has changed
        if(transform.childCount < childCount){
            Debug.Log("A child object has been destroyed");

            // Update the childCount variable
            childCount = transform.childCount;
            if(childCount==0){
                allCoinsCollected=true;
            }
        }
    }

}
