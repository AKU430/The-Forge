using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalSceneManager : MonoBehaviour
{
    public string sceneName;
    
    public void OnClickStart()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnClickQuit()
    {
        Application.Quit(); 
    }
}
