using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectRole : MonoBehaviour
{ //��װ��һ��������,��¼�ϴ�ѡ�еĽ�ɫindex
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
        //��ʼ����ɫ�б�
        int i = 0;
        foreach (var roleInfo in UserData.Instance.AllRole)
        {
            var roleItem = GameObject.Instantiate(Resources.Load<GameObject>("UI/SelectRole/RoleItem"));

            var textName = roleItem.transform.Find("Label").GetComponent<Text>();
            roleItem.transform.SetParent(roleListContent.transform,false);
var toggle =roleItem.GetComponent<Toggle>();
            textName.text = roleInfo.Name;
            toggle.group = roleListToggleGroup;
            //�ñհ�ʵ�ֽ�ɫ��������toggle�İ�
            var index = i;
            ++i;
            toggle.onValueChanged.AddListener((isOn)=> { OnToggleValueChanged(index,isOn); });
            //Ĭ��ѡ��
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
        Debug.Log("ѡ�еĽ�ɫ�ǣ�" + selectRoleIndex);
    }

}
