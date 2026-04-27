using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] SceneLoaderTrigger sceneLoaderTrigger;

    private void OnTriggerEnter(Collider other)
    {
        sceneLoaderTrigger.LaunchLoadEvent("FinalExampleScene");
    }
}