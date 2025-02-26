using TMPro;
using UnityEngine;

public class Task4Manager : MonoBehaviour
{
    public Task4_1 task4_1;
    public Task4_2 task4_2;
    public Task4_3 task4_3;
    public TextMeshProUGUI modeDisplay;
    public TMP_InputField[] accelerationInputFields;

    private bool scriptSelected = false;

    void Start()
    {
        DisableAllScripts();
        UpdateModeDisplay("");
    }

    void Update()
    {
        if (!scriptSelected)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                EnableScript(task4_1);
                scriptSelected = true;
                UpdateModeDisplay("Mode 1");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                EnableScript(task4_2);
                scriptSelected = true;
                UpdateModeDisplay("Mode 2");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                EnableScript(task4_3);
                scriptSelected = true;
                EnableAccelerationInputFields();
                UpdateModeDisplay("Mode 3");
            }
        }
    }

    void DisableAllScripts()
    {
        if (task4_1 != null) task4_1.enabled = false;
        if (task4_2 != null) task4_2.enabled = false;
        if (task4_3 != null) task4_3.enabled = false;
    }

    void EnableScript(MonoBehaviour script)
    {
        if (script != null) script.enabled = true;
    }

    void UpdateModeDisplay(string modeText)
    {
        if (modeDisplay != null)
        {
            modeDisplay.text = modeText;
        }
    }
    void EnableAccelerationInputFields()
    {
        foreach (var field in accelerationInputFields)
        {
            if (field != null) field.gameObject.SetActive(true);
        }
    }
}