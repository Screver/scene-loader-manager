using UnityEngine;

public class SceneLoaderTrigger : MonoBehaviour
{
    [Header("Presets")] [SerializeField] private string _scene;

    public void LaunchLoadEvent()
    {
        SceneLoaderManager.Instance.LoadScene(_scene);
    }
    public void LaunchLoadEvent(string sceneName)
    {
        SceneLoaderManager.Instance.LoadScene(sceneName);
    }
}