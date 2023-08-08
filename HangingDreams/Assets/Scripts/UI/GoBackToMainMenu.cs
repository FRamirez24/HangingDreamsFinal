using UnityEngine;
using TMPro;

public class GoBackToMainMenu : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private Color originalColor;
    public Color hoverColor = Color.red; // Change this to the desired hover color

    private void Start()
    {
        originalColor = textMeshPro.color;
    }

    private void OnMouseEnter()
    {
        textMeshPro.color = hoverColor;
        print("bozo");
    }

    private void OnMouseExit()
    {
        textMeshPro.color = originalColor;
        print("aaaaaaaaaaaaa");
    }
}