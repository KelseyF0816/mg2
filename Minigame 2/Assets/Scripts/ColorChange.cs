using UnityEngine;
using TMPro;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private int health = 4;

    private void Start()
    {
        _healthText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Only a spell on this floor can damage the chest.
        if (!other.CompareTag("Spell") || other.gameObject.layer != gameObject.layer)
            return;

        health -= 1;
        float r = 1.0f;
        if (health == 0)
        {
            gameObject.SetActive(false);
            return;
        }
        else if (health == 3)
        {
            r = 1.0f;
        }
        else if (health == 2)
        {
            r = 0.5f;
        }
        else if (health == 1)
        {
            r = 0.0f;
        }

        _spriteRenderer.color = new Color(r, 0.2f, 0.2f);
        _healthText.gameObject.SetActive(true);
        _healthText.text = "h = " + health;
    }
}
