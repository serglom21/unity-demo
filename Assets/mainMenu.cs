using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class mainMenu : MonoBehaviour
{
    public void exitGame() {
        Debug.Log("Exiting Sentry Game");
        Application.Quit();
    }
}
