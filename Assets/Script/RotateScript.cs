using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateScript : MonoBehaviour
{
    public Slider slider;

    void Update()
    {
        transform.localEulerAngles = new Vector3(0, slider.value, 0); 
    }
}
