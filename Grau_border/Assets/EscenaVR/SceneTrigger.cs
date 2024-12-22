using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public float time;
    public string sceneName;

    void Start()
    {
        StartCoroutine(WaitAndChangeScene(sceneName, time));
    }

    private IEnumerator WaitAndChangeScene(string sceneName, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneName);
    }
}
