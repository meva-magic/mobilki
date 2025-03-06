using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cards : MonoBehaviour
{
    public static Cards instance;

    public Button SwordButton;
    public Button RoseButton;
    public Button CrowButton;

    public int card = 0;

    [SerializeField] private TextMeshProUGUI narrator;

    private void Awake()
    {
        instance = this;
    }

    public void Sword()
    {
        card = 1;

        narrator.text = "Ты выбрал МЕЧ";

        DisableCards();
    }

    public void Rose()
    {
        card = 2;

        narrator.text = "Ты выбрал РОЗУ";

        DisableCards();
    }

    public void Crow()
    {
        card = 3;

        narrator.text = "Ты выбрал ВОРОНА";

        DisableCards();
    }

    private void DisableCards()
    {
        GameObject[] cards = GameObject.FindGameObjectsWithTag("Card");
        
        foreach (GameObject card in cards)
        {
            card.SetActive(false);
        }
    }
}
