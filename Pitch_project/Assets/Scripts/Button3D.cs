using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3D : MonoBehaviour
{
    public void buttonFunction(string btnLink){
        Application.OpenURL(btnLink);
    }
}
