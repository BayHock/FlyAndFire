using UnityEngine;

public class GameAlpha : MonoBehaviour
{
    [SerializeField] private RectTransform fade;
    void Start()
    {
        fade.gameObject.SetActive(true);
        LeanTween.alpha(fade, 1, 0);
        LeanTween.alpha(fade, 0, 1.5f).setOnComplete(() =>
        {
            fade.gameObject.SetActive(false);
        });
    }
}
