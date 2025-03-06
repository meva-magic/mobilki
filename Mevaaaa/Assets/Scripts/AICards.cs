using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AICards : MonoBehaviour
{
    public Sprite[] sprites;

    private int aiCard = 0;

    public Image aiImage;

    private void Start()
    {
        aiImage.sprite = sprites[0];
    }

    public void ActButton()
    {
        aiImage.gameObject.SetActive(true);
        aiCard = Random.Range(1, sprites.Length);

        aiImage.sprite = sprites[aiCard];
    }
}
