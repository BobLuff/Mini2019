using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGamePanel : MonoBehaviour
{

    //[SerializeField]
    //private CanvasGroup canvasGroup=new CanvasGroup();


    //private void Awake()
    //{

    //    if (canvasGroup.alpha != 0)
    //    {
    //        canvasGroup.alpha = 0;

    //    }
 
    //}

    //// Start is called before the first frame update
    //void Start()
    //{
    //    canvasGroup.DOFade(1, 2.5f);
 
        
    //}



    public void EnterGame(string sceneName)
    {
       
        SceneManager.LoadScene(sceneName);
        
    }
 
}
