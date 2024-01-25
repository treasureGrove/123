using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

/// <summary>
/// 登录界面
/// </summary>
public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    private InputField inputAccountName;
    private InputField inputPassword;
    private Button loginButton;
    private void Awake()
    {
        inputAccountName = transform.Find("InputAccountName").GetComponent<InputField>();
        inputPassword = transform.Find("InputPassword").GetComponent<InputField>();
        loginButton=transform.Find("LoginButton").GetComponent<Button>();
        loginButton.onClick.AddListener(OnLoginButtonClick);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnLoginButtonClick()
    {//链接服务器数据,等待返回数据(暂时先用假数据直接进)
        Debug.Log("aaaa");
        SceneManager.LoadScene("SelectRoleScene");
         
    }
}
