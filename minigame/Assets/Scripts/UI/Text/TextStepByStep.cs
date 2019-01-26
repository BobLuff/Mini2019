using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    [Header("文字显示的时间间隔")]
    private float intervalTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowWord(str.Length));
        
    }

    IEnumerator ShowWord(int len)
    {
        string s = null;
        int i = 0;
        while (i < len)
        {
            yield return new WaitForSeconds(intervalTime);
            s += str[i].ToString();
            text.text = s;
            i++;

        }
        

    }


}
