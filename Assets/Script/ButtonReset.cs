using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonReset : MonoBehaviour {

    public void Reset()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
