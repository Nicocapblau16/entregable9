using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneFlow : MonoBehaviour
{

    public void GoToScene1()
    {
        //UIManagerMenu.sharedInstance.SaveUserName();
        SceneManager.LoadScene("Escene1");
    }

    public void GoToScene2()
    {
        SceneManager.LoadScene("Escene2");
    }

}
