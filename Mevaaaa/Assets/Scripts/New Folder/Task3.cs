using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task3 : MonoBehaviour
{
    public static Task3 instance;

    [SerializeField] private float time = 0f;
    [SerializeField] private float currentSpeed = 0f;
    [SerializeField] private float acceleration = 2.0f;
    [SerializeField] private float startSpeed = 5.0f;

    private Vector3 startPosition;

    [SerializeField] private TextMeshProUGUI textDisplay;
    [SerializeField] private TMP_InputField speedInputField;
    [SerializeField] private TMP_InputField accelerationInputField;

    void Start()
    {
        startPosition = transform.position;
        currentSpeed = startSpeed;
    }

    void FixedUpdate()
    {
        float speedChange = acceleration * Time.deltaTime;
        currentSpeed += speedChange;
        float distance = currentSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * distance);

        time += Time.deltaTime;
        float totalDistance = (startSpeed * time) + (acceleration * time * time * 0.5f);
        textDisplay.text = ("время: " + time + " | " + "пройдено: " + totalDistance + " | " + "скорость: " + currentSpeed + " | ");
    }
}
