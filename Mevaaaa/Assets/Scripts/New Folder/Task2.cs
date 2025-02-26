using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task2 : MonoBehaviour
{
    public static Task2 instance;

    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float time = 0f;

    private Vector3 startPosition;
    private Vector3 currentPosition;
    [SerializeField] private TextMeshProUGUI textDisplay;
    [SerializeField] private TMP_InputField speedInputField;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        startPosition = transform.position; 
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        float distance = speed * time;
        currentPosition = startPosition + Vector3.right * distance;

        textDisplay.text = ("время: " + time + " | " + "пройдено: " + distance + " | " + "координата: " + currentPosition + " | ");
    }

    void TogglePause()
    {
            time = 0f;
            currentPosition = transform.position;
            startPosition = transform.position;
            if (float.TryParse(speedInputField.text, out float newSpeed))
            {
                speed = newSpeed;
            }
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("menu"); 
    }
}