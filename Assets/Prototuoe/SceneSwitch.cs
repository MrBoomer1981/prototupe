using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void LoadScene(){
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        int sceneCount = SceneManager.sceneCount;
        int nextSceneIndex = (sceneIndex+1)%sceneCount;
        SceneManager.LoadScene(nextSceneIndex);
        Debug.Log(SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(nextSceneIndex)));
    }
    public void LoadSceneString(string nextSceneName){
        SceneManager.LoadScene(nextSceneName);
    }
        
    }



