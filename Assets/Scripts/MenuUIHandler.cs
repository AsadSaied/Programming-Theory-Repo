using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Loading Scene");
        SceneManager.LoadScene(1);
    }
}
