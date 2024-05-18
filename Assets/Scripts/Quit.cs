using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void Reload()
    {
        Results.Score = 0;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
}
