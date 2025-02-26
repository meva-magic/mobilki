using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Task1 : MonoBehaviour
{
    public static Task1 instance;

    [SerializeField] private float speed = 5.0f; 
    [SerializeField] private float time = 0;

    [SerializeField] private TextMeshProUGUI textDisplay;
    [SerializeField] private TMP_InputField speedInputField;

    private void Awake()
    {
        instance = this;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        float currentDistance = speed * time;
        textDisplay.text = ("пройдено " + currentDistance + " за " + time + " секунд");
    }
}
