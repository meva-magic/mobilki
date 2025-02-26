using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task5_1 : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 speed = Vector3.one * 5.0f;
    public TextMeshProUGUI textDisplay;
    public TMP_InputField speedXInputField;
    public TMP_InputField speedYInputField;
    public TMP_InputField speedZInputField;
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
        transform.Translate(speed * Time.deltaTime);

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
            if (float.TryParse(speedZInputField.text, out float newSpeedZ))
            {
                speed.z = newSpeedZ;
            }
        }
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
}