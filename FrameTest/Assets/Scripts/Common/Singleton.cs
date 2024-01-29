using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 单例泛型
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> where T :new()
{
    static T instance;
    static Singleton()
    {
        instance =new T();
    }
    public static T Instance
    {
        get { return instance; }
    }

}
