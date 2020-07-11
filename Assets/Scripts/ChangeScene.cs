using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void NextScene(string next_scene)
    {
        SceneManager.LoadScene(next_scene);
    }
}