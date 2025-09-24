using DG.Tweening;
using TMPro;
using UnityEngine;

public class SceneFade_Controller : MonoBehaviour
{
    public GameObject fadePanel;

    private void Start()
    {
        FadeScene(true, 1f);
    }

    public Tween FadeScene(bool fadeIn, float? time = null)
    {
        if (fadePanel != null)
        {
            fadePanel.SetActive(true);
        }
        CanvasGroup panelGroup = fadePanel.GetComponent<CanvasGroup>();
        panelGroup.DOKill();

        int endvalue = fadeIn ? 0 : 1;
        float fadeTime = time ?? 1.5f;

        return panelGroup.DOFade(endvalue, fadeTime).OnComplete(() =>
        {
            if (fadeIn)
            {
                fadePanel.SetActive(false);
            }
        });
    }
}
