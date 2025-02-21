using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField]  private GameObject mainMenu;
    [SerializeField] private GameObject inGame;
    [SerializeField]  private GameObject winScreen;
    [SerializeField]  private GameObject deathScreen;

    private string currentSceneName;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SetMenu();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (mainMenu.activeSelf)
            {
                SetInGameUI();
            }
        }
    }

    public void SetInGameUI()
    {
        DisableUI();
        Time.timeScale = 1;
        inGame.SetActive(true);
    }

    public void SetMenu()
    {
        DisableUI();
        Time.timeScale = 0;
        mainMenu.SetActive(true);
    }

    public void SetWin()
    {
        DisableUI();
        Time.timeScale = 0;
        winScreen.SetActive(true);
    }

    public void SetDeath()
    {
        DisableUI();
        Time.timeScale = 0;
        deathScreen.SetActive(true);
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
