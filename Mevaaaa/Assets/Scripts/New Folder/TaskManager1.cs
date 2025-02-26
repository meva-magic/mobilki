using TMPro;
using UnityEngine;

public class Task5Manager : MonoBehaviour
{
    public Task5_1 task5_1;
    public Task5_2 task5_2;
    public Task5_3 task5_3;
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
                EnableScript(task5_1);
                scriptSelected = true;
                UpdateModeDisplay("Mode 1");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                EnableScript(task5_2);
                scriptSelected = true;
                UpdateModeDisplay("Mode 2");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                EnableScript(task5_3);
                scriptSelected = true;
                EnableAccelerationInputFields();
                UpdateModeDisplay("Mode 3");
            }
        }
    }

    void DisableAllScripts()
    {
        if (task5_1 != null) task5_1.enabled = false;
        if (task5_2 != null) task5_2.enabled = false;
        if (task5_3 != null) task5_3.enabled = false;
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