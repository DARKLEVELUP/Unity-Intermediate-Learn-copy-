using PrimeTween;
using UnityEngine;

public static class ExtensionMethod
{
    public static void Fade(this CanvasGroup canvasGroup, bool _isShown,float fadeDuration)
    {
        float targetAlpha = _isShown ? 1f : 0f;
        if(Mathf.Approximately(canvasGroup.alpha, targetAlpha))
        {
            canvasGroup.setCanvasGroupInteraction(_isShown);
            return;
        }

        canvasGroup.setCanvasGroupInteraction(_isShown);
        Tween.Alpha(canvasGroup, targetAlpha, fadeDuration);
    }

    public static void Hide(this CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0f;
        canvasGroup.setCanvasGroupInteraction(false);
    }

    public static void setCanvasGroupInteraction(this CanvasGroup canvasGroup, bool _isEnable)
    {
        canvasGroup.blocksRaycasts = _isEnable;
        canvasGroup.interactable = _isEnable;
    }
    
}
