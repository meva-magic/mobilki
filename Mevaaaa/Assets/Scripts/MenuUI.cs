using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public static MenuUI instance;

    [SerializeField] private Button quitButton;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        quitButton.onClick.AddListener(QuitGame); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
