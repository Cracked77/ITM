using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitscript : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
