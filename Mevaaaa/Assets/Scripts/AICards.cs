using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AICards : MonoBehaviour
{
    public Sprite[] sprites;

    private int aiCard = 0;

    public Image aiImage;
    [SerializeField] Button actButton;
    [SerializeField] Button resetButton;
    [SerializeField] private TextMeshProUGUI narrator;

    public PlayerCards playerCards;

    private void Start()
    {
        aiImage.sprite = sprites[0];
        actButton.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(false);
    }

    public void ActButton()
    {
        aiImage.gameObject.SetActive(true);
        aiCard = Random.Range(1, sprites.Length);

        aiImage.sprite = sprites[aiCard];

        if (aiCard == playerCards.card)
        {
            narrator.text = "ничья";
        }

        else if ((aiCard == 2 && playerCards.card == 0 )|| (aiCard == 0 && playerCards.card == 1) || (aiCard == 1 && playerCards.card == 2))
        {
            narrator.text = "победа";
        }

        else if ((aiCard == 0 && playerCards.card == 2) || (aiCard == 1 && playerCards.card == 0) || (aiCard == 2 && playerCards.card == 1))
        {
            narrator.text = "проигрыш";
        }
        
        actButton.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(true);
    }

    public void Reset()
    {
        aiCard = 0;
        playerCards.EnableCards();

        narrator.text = " ";
        playerCards.narrator.text = " ";

        actButton.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(false);
    }
}
