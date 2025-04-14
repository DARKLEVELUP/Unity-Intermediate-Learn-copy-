using System.Collections;
using UnityEngine;

public class InterFade : MonoBehaviour
{
    [SerializeField] private CanvasGroup _CanvasGroup;
    [SerializeField] private float _fadespeed = 1f;

    private bool _isShown;
    
    IEnumerator Fade()
    {
        float alpha = _isShown ? 0f : 1f;
        
        if (_isShown)
        {
            while (alpha < 1f)
            {
                alpha += Time.deltaTime * _fadespeed;
                _CanvasGroup.alpha = alpha;
                yield return null;
            }
        
        }
        else
        {
            while (alpha > 0f)
            {
                
                alpha -= Time.deltaTime * _fadespeed;
                _CanvasGroup.alpha = alpha;
                yield return null;
            }
        }

        yield return new WaitForSeconds(0.5f);
        Debug.Log("FADED!");
    } 

    [ContextMenu("Toggle UI")]
    public void ToggleUI()
    {
        _isShown = !_isShown;
        StartCoroutine(Fade()); 
    }
}
