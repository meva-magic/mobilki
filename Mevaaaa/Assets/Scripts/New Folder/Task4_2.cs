using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task4_2 : MonoBehaviour
{
    private Vector3 startPosition;
    public Vector2 speed = Vector2.one * 5.0f;
    public TextMeshProUGUI textDisplay;
    public TMP_InputField speedXInputField;
    public TMP_InputField speedYInputField;
    private float time = 0f;
    private bool isPaused = true;
    public Button menuButton;
    private Vector3 currentPosition;

    void Start()
    {
        startPosition = transform.position;
        menuButton.onClick.AddListener(LoadMenuScene);
    }

    void FixedUpdate()
    {
        if (isPaused) return;

        time += Time.deltaTime;
        transform.Translate(new Vector3(speed.x * Time.deltaTime, speed.y * Time.deltaTime, 0));

        float distance = speed.magnitude * time;
        currentPosition = startPosition + new Vector3(speed.x * time, speed.y * time, 0); // Используем startPosition

        textDisplay.text = ("Текущее время: " + time + ", Пройденный путь: " + distance + ", Текущая координата: " + currentPosition);
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
            currentPosition = transform.position;
            startPosition = transform.position;
            time = 0f;

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