using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 管理EscPanel面板
/// </summary>
public class EscPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject escPanel;




    private void HideUiObj()
    {
        escPanel.SetActive(false);

    }


    /// <summary>
    /// 继续游戏
    /// </summary>
    public void ContinueGame()
    {
        Time.timeScale = 1;
        HideUiObj();



    }

     /// <summary>
     /// 退出游戏
     /// </summary>
    public void QuitGame()
    {
        Application.Quit();

    }

    /// <summary>
    /// 游戏帮助
    /// </summary>
    public void GameHelp()
    {

    }

    /// <summary>
    /// 重新开始
    /// </summary>
    public void RestartGame()
    {
        //SceneManager.LoadScene();

    }








}
