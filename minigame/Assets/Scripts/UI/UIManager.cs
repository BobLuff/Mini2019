using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    [SerializeField]
    private GameObject escPanel;


    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)&&!escPanel.activeSelf)
        {
            escPanel.SetActive(true);

        }
    }
 
}
