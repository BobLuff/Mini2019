using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGamePanel : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup canvasgroup = new CanvasGroup();
    [SerializeField]
    private GameObject btn;


    private void Awake()
    {
        if (btn.activeInHierarchy == true)
        {
            btn.SetActive(false);
        }
        if (canvasgroup.alpha != 0)
        {
            canvasgroup.alpha = 0;

        }
    }


    // start is called before the first frame update


    private void Start()
    {
        canvasgroup.DOFade(1, 5f);

        StartCoroutine(ShowBtn());
    }


    IEnumerator ShowBtn()
    {

        yield return new WaitForSeconds(2.5f);
       
        btn.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        btn.transform.DOScale(new Vector3(1.4f, 1.4f, 1), 0.3f);
        yield return new WaitForSeconds(0.5f);
        btn.transform.DOScale(new Vector3(1, 1, 1), 0.5f);

    }

    public void MouseEnterBtn()
    {
        btn.transform.DOScale(new Vector3(1.4f, 1.4f, 1), 0.3f);
    }

    public void MouseExitBtn()
    {
        btn.transform.DOScale(new Vector3(1, 1, 1), 0.5f);

    }


    public void EnterGame(string sceneName)
    {
       
        SceneManager.LoadScene(sceneName);
        
    }
 
}
