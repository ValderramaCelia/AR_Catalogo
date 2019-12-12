using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARManager : MonoBehaviour
{
    public string id;
    // Use this for initialization
    void Start()
    {
        id = PlayerPrefs.GetString("CatalogSelection");
        foreach (Transform child in transform)
        {


            if (child.name == id)
            {
                child.gameObject.SetActive(true);
            }

            else
            {
                child.gameObject.SetActive(false);
            }
        }

       

    }
}
