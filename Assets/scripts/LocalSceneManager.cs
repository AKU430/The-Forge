using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalSceneManager : MonoBehaviour
{
    public string sceneName;
    
    public void OnClickSceneLoad() 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnClickQuit() 
    {
        Application.Quit(); 
    }
}
