using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Text itemNum;
	
	void Start ()
    {
        itemNum = GetComponentInParent<Text>();
        
	}
	
	
	public void OnClickedButton ()
    {
        PlayerPrefs.SetString("CatalogSelection", itemNum.text);
        PlayerPrefs.Save();

        Debug.Log("You pushed the select button and got number " + PlayerPrefs.GetString("CatalogSelection"));
        SceneManager.LoadScene(sceneBuildIndex: 1);
	}
}
