using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Linq;

public class ARFilteredPlanes : MonoBehaviour
{

    public event Action OnVericalPlane;
    public event Action OnHorizontalPlane;

    private ARPlaneManager arPlaneManager;

    private List<ARPlane> arPlanes;

    private void onEnable(){
        arPlanes = new List<ARPlane>();
        arPlaneManager = FindObjectOfType<ARPlaneManager>();
        arPlaneManager.planesChanged += OnPlanesChanged;

    }

    private void onDisable(){
        arPlaneManager.planesChanged -= OnPlanesChanged;

    }

    private void OnPlanesChanged(ARPlanesChangedEventArgs args){
        if(args.added != null && args.added.Count > 0)
            arPlanes.AddRange(args.added);

        foreach (ARPlane plane in arPlanes.Where(plane => plane.extents.x * plane.extents.y >= 0.1f))
        {
            if(plane.alignment.IsVertical()){
                OnVericalPlane.Invoke();
            }
            else{
                OnHorizontalPlane.Invoke();
            }
        }
        
    }
}
