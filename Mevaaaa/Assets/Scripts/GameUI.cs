using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public static GameUI instance;

    private string currentSceneName;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    private void Reload()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    private void DisableUI()
    {
        GameObject[] uIObjects = GameObject.FindGameObjectsWithTag("UI");

        foreach (GameObject uiObject in uIObjects)
        {
            uiObject.SetActive(false);
        }
    }
}
