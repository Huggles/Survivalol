using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.SceneManagement;

public class MutationButtons : MonoBehaviour
{
    public void MutationButton1()
    {
        UnityEngine.Debug.Log("MutationButton1");
        SceneManager.LoadScene(1);
    }
    
    public void MutationButton2()
    {
        UnityEngine.Debug.Log("MutationButton2");
        SceneManager.LoadScene(1);
    }
    
    public void MutationButton3()
    {
        UnityEngine.Debug.Log("MutationButton3");
        SceneManager.LoadScene(1);
    }
}
