using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public Image fadeImage;
    // Animation curves are built into unity and allow for more control of the fade in
    public AnimationCurve curve; 

    void Start ()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeTo (string scene)
    {
        StartCoroutine(FadeOut(scene));
    }
    
    IEnumerator FadeIn ()
    {
        float t = 1f;

        while (t > 0)
        {
            t -= Time.deltaTime;
            //If using a curve for an alpha channel implement like this 
            float a = curve.Evaluate(t);
            fadeImage.color = new Color (0f, 0f, 0f, a);
            yield return 0;
        }
        
    }

    IEnumerator FadeOut (string scene)
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime; 
            float a = curve.Evaluate(t);
            fadeImage.color = new Color (0f, 0f, 0f, a);
            yield return 0;
        }

        SceneManager.LoadScene(scene);
    }

}
