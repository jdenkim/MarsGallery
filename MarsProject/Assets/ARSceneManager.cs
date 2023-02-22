using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ARWT.WebXR

{
    public class ARSceneManager : MonoBehaviour
    {
        public void GoToMain()

        {
            SceneManager.LoadScene(0, LoadSceneMode.Single)
    ;
        }

        public void GoToScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }

}