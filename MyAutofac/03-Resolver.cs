using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutofac
{
    /// <summary>
    /// 反射解析
    /// </summary>
    public class Resolver
    {
        /// <summary>
        /// 构造函数的参数类型
        /// </summary>
        public Type RealType { get; set; }

        /// <summary>
        /// 定义一个委托 来实例化构造函数的参数
        /// </summary>
        public Func<Type, object> GetParameterInstance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object GetInstance()
        {
            var constructors = RealType.GetConstructors();
            var parasInfos = constructors[0].GetParameters();
            var paras = new List<object>();
            foreach (var parasInfo in parasInfos)
            {
                var obj = GetParameterInstance(parasInfo.ParameterType);
                paras.Add(obj);
            }

            return constructors[0].Invoke(paras.ToArray());
        }
    }
}
