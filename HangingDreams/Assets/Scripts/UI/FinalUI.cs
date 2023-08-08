using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinalUI : MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;
    public Image image1; // Assuming you want to use a SpriteRenderer for the image
    private bool openText1 = false; 
    private bool openText2 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        text1.faceColor = new Color32(255, 128, 0, 0);
        text2.faceColor = new Color32(255, 128, 0, 0);
        StartCoroutine(FadeInText1());
    }

    IEnumerator FadeInText1()
    {
        yield return new WaitForSeconds(4);

        float fadeDuration = 2; // Duration of the fade-in effect in seconds
        float currentTime = 0;

        while (currentTime < fadeDuration)
        {
            float normalizedTime = currentTime / fadeDuration;
            Color newColor = new Color32(255, 128, 0, (byte)Mathf.Lerp(0, 255, normalizedTime));

            text1.faceColor = newColor;

            currentTime += Time.deltaTime;
            yield return null;
        }

        // Ensure that the alpha value is set to 255 (fully opaque) after the fade
        text1.faceColor = new Color32(255, 128, 0, 255);

        // Start fading in text2 after text1 has finished fading in
        StartCoroutine(FadeInText2());
    }

    IEnumerator FadeInText2()
    {
        float fadeDuration = 2; // Duration of the fade-in effect in seconds
        float currentTime = 0;

        yield return new WaitForSeconds(1); // Stagger the start of text2's fade-in

        while (currentTime < fadeDuration)
        {
            float normalizedTime = currentTime / fadeDuration;
            Color newColor = new Color32(255, 128, 0, (byte)Mathf.Lerp(0, 255, normalizedTime));

            text2.faceColor = newColor;

            currentTime += Time.deltaTime;
            yield return null;
        }

        // Ensure that the alpha value is set to 255 (fully opaque) after the fade
        text2.faceColor = new Color32(255, 128, 0, 255);

        // Start fading in image1 after text2 has finished fading in
        StartCoroutine(FadeInImage1());
    }

    IEnumerator FadeInImage1()
    {
        float fadeDuration = 2; // Duration of the fade-in effect in seconds
        float currentTime = 0;

        yield return new WaitForSeconds(1); // Stagger the start of image1's fade-in

        while (currentTime < fadeDuration)
        {
            float normalizedTime = currentTime / fadeDuration;
            Color newColor = new Color(image1.color.r, image1.color.g, image1.color.b, Mathf.Lerp(0, 1, normalizedTime));

            image1.color = newColor;

            currentTime += Time.deltaTime;
            yield return null;
        }

        // Ensure that the alpha value is set to 1 (fully opaque) after the fade
        Color finalImageColor = image1.color;
        finalImageColor.a = 1;
        image1.color = finalImageColor;
    }
}