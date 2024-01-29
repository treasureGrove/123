using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectRole : MonoBehaviour
{ //假装有一个服务器,记录上次选中的角色index
    private int lastRoleIndex;
    private GameObject roleListContent;
    private Button enterButton;
    private ToggleGroup roleListToggleGroup;
    private int selectRoleIndex=-1;
    private void Awake()
    {
       
        roleListContent = transform.Find("RollList/Viewport/Content").gameObject;
        roleListToggleGroup = roleListContent.GetComponent<ToggleGroup>();
        enterButton=transform.Find("EnterButton").GetComponent<Button>();
        enterButton.onClick.AddListener(OnEnterButtonClick);
        //初始化角色列表
        int i = 0;
        foreach (var roleInfo in UserData.Instance.AllRole)
        {
            var roleItem = GameObject.Instantiate(Resources.Load<GameObject>("UI/SelectRole/RoleItem"));

            var textName = roleItem.transform.Find("Label").GetComponent<Text>();
            roleItem.transform.SetParent(roleListContent.transform,false);
var toggle =roleItem.GetComponent<Toggle>();
            textName.text = roleInfo.Name;
            toggle.group = roleListToggleGroup;
            //用闭包实现角色的索引和toggle的绑定
            var index = i;
            ++i;
            toggle.onValueChanged.AddListener((isOn)=> { OnToggleValueChanged(index,isOn); });
            //默认选中
            toggle.isOn = index == lastRoleIndex;
            
        }

    }
    private void OnToggleValueChanged(int roleIndex,bool isOn)
    {
        Debug.Log(string.Format("{0},{1}", roleIndex, isOn));
        if (isOn) {
          selectRoleIndex = roleIndex;
        }
    }
    void OnEnterButtonClick()
    {
        Debug.Log("选中的角色是：" + selectRoleIndex);
    }

}
