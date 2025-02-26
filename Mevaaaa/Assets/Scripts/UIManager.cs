using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Button task1Button;
    public Button task2Button;
    public Button task3Button;
    public Button task4Button;
    public Button task5Button;
    public Button quitButton;

    private string currentSceneName;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //SetMenu();

        task1Button.onClick.AddListener(LoadTask1);
        task2Button.onClick.AddListener(LoadTask2);
        task3Button.onClick.AddListener(LoadTask3);
        task4Button.onClick.AddListener(LoadTask4);
        task5Button.onClick.AddListener(LoadTask5);
        quitButton.onClick.AddListener(QuitGame); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    public void SetMenu()
    {
        DisableUI();
        Time.timeScale = 0;
        //mainMenu.SetActive(true);
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

    public void LoadTask1()
    {
        //SceneManager.LoadScene("Task1");
    }

    public void LoadTask2()
    {
        //SceneManager.LoadScene("Task2");
    }

    public void LoadTask3()
    {
        //SceneManager.LoadScene("Task3");
    }

    public void LoadTask4()
    {
        //SceneManager.LoadScene("Task4");
    }

    public void LoadTask5()
    {
        //SceneManager.LoadScene("Task5");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
