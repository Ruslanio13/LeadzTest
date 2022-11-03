using UnityEngine;

public class GameOverButton : MonoBehaviour
{
    [SerializeField] private SceneName _sceneName;

    enum SceneName
    {
        Menu,
        Game
    }

    public void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName.ToString());
    }
}
