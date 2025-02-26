using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task5_3 : MonoBehaviour
{
    private Vector3 startPosition;
    public Vector3 acceleration = Vector3.one * 2.0f;
    public Vector3 startSpeed = Vector3.one * 5.0f;
    public TextMeshProUGUI textDisplay;
    public TMP_InputField accelerationXInputField;
    public TMP_InputField accelerationYInputField;
    public TMP_InputField accelerationZInputField; 
    public TMP_InputField speedXInputField; 
    public TMP_InputField speedYInputField; 
    public TMP_InputField speedZInputField;
    private float time = 0f;
    private Vector3 currentSpeed = Vector3.zero;
    private bool isPaused = true;
    public Button menuButton;

    void Start()
    {
        transform.position = startPosition;
        currentSpeed = startSpeed;
        menuButton.onClick.AddListener(LoadMenuScene);
    }

    void FixedUpdate()
    {
        if (isPaused) return;

        Vector3 speedChange = acceleration * Time.deltaTime;
        currentSpeed += speedChange;

        transform.Translate(currentSpeed * Time.deltaTime);

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
            if (float.TryParse(accelerationZInputField.text, out float newAccelerationZ))
            {
                acceleration.z = newAccelerationZ;
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
            if (float.TryParse(speedZInputField.text, out float newSpeedZ))
            {
                startSpeed.z = newSpeedZ;
                currentSpeed.z = startSpeed.z; 
            }

            time = 0f;
        }
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
}