using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilteredPlanesCanvas : MonoBehaviour
{
    [SerializeField] private Toggle verticalPlaneToggle;
    [SerializeField] private Toggle horizontalPlaneToggle;
    [SerializeField] private Button startButton;

    private ARFilteredPlanes arFilteredPlanes;

    public bool VerticalPlaneToggle { 
        get => verticalPlaneToggle.isOn;
        set{
            verticalPlaneToggle.isOn = value;
            CheckIfAllareTrue();
        }
    }

    public bool HorizontalPlaneToggle { 
        get => horizontalPlaneToggle.isOn;
        set{
            horizontalPlaneToggle.isOn = value;
            CheckIfAllareTrue();
        }
    }
        
    private void CheckIfAllareTrue()
    {
        if(VerticalPlaneToggle || HorizontalPlaneToggle){
            startButton.interactable = true;
        }
    }

    private void onEnable(){
        arFilteredPlanes = FindObjectOfType<ARFilteredPlanes>();

        arFilteredPlanes.OnVericalPlane += () => VerticalPlaneToggle = true;
        arFilteredPlanes.OnHorizontalPlane += () => HorizontalPlaneToggle = true;
    }
    private void onDisable(){

        arFilteredPlanes.OnVericalPlane -= () => VerticalPlaneToggle = true;
        arFilteredPlanes.OnHorizontalPlane -= () => HorizontalPlaneToggle = true;

    }

    
}
