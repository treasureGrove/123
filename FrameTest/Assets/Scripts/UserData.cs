﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 用户数据
/// </summary>
public static class UserData
{
    public static List<SelectRoleInfo> AllRole = new List<SelectRoleInfo>();
    //假的角色数据
    static UserData() 
    {
        var sri = new SelectRoleInfo();
        sri.Name = "第一个角色";
        AllRole.Add(sri);
        AllRole.Add(new SelectRoleInfo() { Name = "第二个角色", ModelResourcePath = "" });
        AllRole.Add(new SelectRoleInfo() { Name = "第三个角色", ModelResourcePath = "" });
    }

}
/// <summary>
/// 选人界面，角色结构
/// </summary>
public class SelectRoleInfo
{
    public string Name;//角色名
    public string ModelResourcePath;//模型资源路径

}