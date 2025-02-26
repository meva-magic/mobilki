using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task4_1 : MonoBehaviour
{
    public Vector2 startPosition;
    public Vector2 speed = Vector2.one * 5.0f;
    public TextMeshProUGUI textDisplay;
    public TMP_InputField speedXInputField;
    public TMP_InputField speedYInputField;
    private float time = 0f;
    private bool isPaused = true;
    public Button menuButton;

    void Start()
    {
        transform.position = startPosition;
        menuButton.onClick.AddListener(LoadMenuScene);
    }

    void FixedUpdate()
    {
        if (isPaused) return;

        time += Time.deltaTime;
        transform.Translate(new Vector3(speed.x * Time.deltaTime, speed.y * Time.deltaTime, 0));

        float currentDistance = speed.magnitude * time;
        textDisplay.text = ("Текущий пройденный путь " + currentDistance + " за " + time + " секунд");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;
        if (!isPaused)
        {
            if (float.TryParse(speedXInputField.text, out float newSpeedX))
            {
                speed.x = newSpeedX;
            }
            if (float.TryParse(speedYInputField.text, out float newSpeedY))
            {
                speed.y = newSpeedY;
            }
        }
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
}