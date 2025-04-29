using System.Collections;
using UnityEngine;
using NaughtyAttributes;
public class InterFade : MonoBehaviour
{
    [SerializeField] private CanvasGroup _FadeCanvasGroup;
    [SerializeField] private float _fadeDuration = 1f;

    private bool _isShown;

    [ContextMenu("Toggle UI")]
    [Button]
    public void ToggleUI()
    {
        _isShown = !_isShown;
        _FadeCanvasGroup.Fade(_isShown, _fadeDuration);
    }
    
    // IEnumerator Fade()
    // {
    //     float alpha = _isShown ? 0f : 1f;
        
    //     if (_isShown)
    //     {
    //         while (alpha < 1f)
    //         {
    //             alpha += Time.deltaTime * _fadespeed;
    //             _CanvasGroup.alpha = alpha;
    //             yield return null;
    //         }
        
    //     }
    //     else
    //     {
    //         while (alpha > 0f)
    //         {
                
    //             alpha -= Time.deltaTime * _fadespeed;
    //             _CanvasGroup.alpha = alpha;
    //             yield return null;
    //         }
    //     }

    //     yield return new WaitForSeconds(0.5f);
    //     Debug.Log("FADED!");
    // } 


}
