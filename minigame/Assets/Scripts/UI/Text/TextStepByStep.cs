using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// 文字一个一个显示
/// </summary>

public class TextStepByStep : MonoBehaviour
{
    [SerializeField]
    private Text text;
    [SerializeField]
    private string str = "";
    [SerializeField]
    [Header("时间间隔")]
    private float time = 4f;

    [SerializeField]
    private CanvasGroup canvasGroup;


    private void Start()
    {
        if (text.text != null)
        {
            text.text = null;
        }
        text.DOText(str,time);
  

    }



    /// <summary>
    /// 渐隐UI ,需要添加canvasGroup组件
    /// </summary>
    void  FadeUI()
    {
        //DOTween.To(() => canvasGroup.alpha, x => canvasGroup.alpha = x, 1, 2);
        canvasGroup.DOFade(0, 2);
    }

}
