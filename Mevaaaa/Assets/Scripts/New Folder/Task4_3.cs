using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task4_3 : MonoBehaviour
{
    private Vector3 startPosition;
    public Vector2 acceleration = Vector2.one * 2.0f;
    public Vector2 startSpeed = Vector2.one * 5.0f;
    public TextMeshProUGUI textDisplay;
    public TMP_InputField accelerationXInputField;
    public TMP_InputField accelerationYInputField;
    public TMP_InputField speedXInputField;
    public TMP_InputField speedYInputField;
    private float time = 0f;
    private Vector2 currentSpeed = Vector2.zero;
    private bool isPaused = true;
    public Button menuButton;

    void Start()
    {
        startPosition = transform.position;
        currentSpeed = startSpeed;
        menuButton.onClick.AddListener(LoadMenuScene);
    }

    void FixedUpdate()
    {
        if (isPaused) return;

        Vector2 speedChange = acceleration * Time.deltaTime;
        currentSpeed += speedChange;

        transform.Translate(new Vector3(currentSpeed.x * Time.deltaTime, currentSpeed.y * Time.deltaTime, 0));

        time += Time.deltaTime;

        float totalDistance = (startSpeed + acceleration * time * 0.5f).magnitude * time;
        float currentSpeedMagnitude = currentSpeed.magnitude;
        textDisplay.text = ("Время: " + time + ",пройденный путь:" + totalDistance + ", Текущая скорость: " + currentSpeedMagnitude);
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
            if (float.TryParse(accelerationXInputField.text, out float newAccelerationX))
            {
                acceleration.x = newAccelerationX;
            }
            if (float.TryParse(accelerationYInputField.text, out float newAccelerationY))
            {
                acceleration.y = newAccelerationY;
            }

            if (float.TryParse(speedXInputField.text, out float newSpeedX))
            {
                startSpeed.x = newSpeedX;
                currentSpeed.x = startSpeed.x;
            }
            if (float.TryParse(speedYInputField.text, out float newSpeedY))
            {
                startSpeed.y = newSpeedY;
                currentSpeed.y = startSpeed.y;
            }

            time = 0f;
        }
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
}