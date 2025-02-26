using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class menucontroller : MonoBehaviour
{
    public Button task1Button;
    public Button task2Button;
    public Button task3Button;
    public Button task4Button;
    public Button task5Button;
    public Button quitButton; 

    void Start()
    {
        task1Button.onClick.AddListener(LoadTask1);
        task2Button.onClick.AddListener(LoadTask2);
        task3Button.onClick.AddListener(LoadTask3);
        task4Button.onClick.AddListener(LoadTask4);
        task5Button.onClick.AddListener(LoadTask5);
        quitButton.onClick.AddListener(QuitGame); 
    }

    public void LoadTask1()
    {
        SceneManager.LoadScene("scene1");
    }

    public void LoadTask2()
    {
        SceneManager.LoadScene("scene2");
    }

    public void LoadTask3()
    {
        SceneManager.LoadScene("scene3");
    }

    public void LoadTask4()
    {
        SceneManager.LoadScene("scene4");
    }

    public void LoadTask5()
    {
        SceneManager.LoadScene("scene5");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
