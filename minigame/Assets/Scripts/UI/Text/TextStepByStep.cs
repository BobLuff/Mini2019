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


    private void Start()
    {
        if (text.text != null)
        {
            text.text = null;
        }
        text.DOText(str,time);
    }


}
