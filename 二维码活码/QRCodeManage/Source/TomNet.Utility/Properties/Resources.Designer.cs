﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TomNet.Utility.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TomNet.Utility.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 参数中的字符\&quot;{0}\&quot;不是 {1} 进制数的有效字符。 的本地化字符串。
        /// </summary>
        internal static string AnyRadixConvert_CharacterIsNotValid {
            get {
                return ResourceManager.GetString("AnyRadixConvert_CharacterIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 0 的本地化字符串。
        /// </summary>
        internal static string AnyRadixConvert_Overflow {
            get {
                return ResourceManager.GetString("AnyRadixConvert_Overflow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 查询条件组中的操作类型错误，只能为And或者Or。 的本地化字符串。
        /// </summary>
        internal static string Filter_GroupOperateError {
            get {
                return ResourceManager.GetString("Filter_GroupOperateError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 指定的属性“{0}”在类型“{1}”中不存在。 的本地化字符串。
        /// </summary>
        internal static string Filter_RuleFieldInTypeNotFound {
            get {
                return ResourceManager.GetString("Filter_RuleFieldInTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 创建名称为“{0}”的日志实例时“{1}”返回空实例。 的本地化字符串。
        /// </summary>
        internal static string Logging_CreateLogInstanceReturnNull {
            get {
                return ResourceManager.GetString("Logging_CreateLogInstanceReturnNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前Http上下文中不存在Request有效范围的Mef部件容器。 的本地化字符串。
        /// </summary>
        internal static string Mef_HttpContextItems_NotFoundRequestContainer {
            get {
                return ResourceManager.GetString("Mef_HttpContextItems_NotFoundRequestContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 指定对象中不存在名称为“{0}”的属性。 的本地化字符串。
        /// </summary>
        internal static string ObjectExtensions_PropertyNameNotExistsInType {
            get {
                return ResourceManager.GetString("ObjectExtensions_PropertyNameNotExistsInType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 指定名称“{0}”的属性类型不是“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ObjectExtensions_PropertyNameNotFixedType {
            get {
                return ResourceManager.GetString("ObjectExtensions_PropertyNameNotFixedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须在“{1}”与“{2}”之间。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_Between {
            get {
                return ResourceManager.GetString("ParameterCheck_Between", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须在“{1}”与“{2}”之间，且不能等于“{3}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_BetweenNotEqual {
            get {
                return ResourceManager.GetString("ParameterCheck_BetweenNotEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 指定的目录路径“{0}”不存在。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_DirectoryNotExists {
            get {
                return ResourceManager.GetString("ParameterCheck_DirectoryNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 指定的文件路径“{0}”不存在。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_FileNotExists {
            get {
                return ResourceManager.GetString("ParameterCheck_FileNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值不能为Guid.Empty 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotEmpty_Guid {
            get {
                return ResourceManager.GetString("ParameterCheck_NotEmpty_Guid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须大于“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotGreaterThan {
            get {
                return ResourceManager.GetString("ParameterCheck_NotGreaterThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须大于或等于“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotGreaterThanOrEqual {
            get {
                return ResourceManager.GetString("ParameterCheck_NotGreaterThanOrEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须小于“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotLessThan {
            get {
                return ResourceManager.GetString("ParameterCheck_NotLessThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须小于或等于“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotLessThanOrEqual {
            get {
                return ResourceManager.GetString("ParameterCheck_NotLessThanOrEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”不能为空引用。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotNull {
            get {
                return ResourceManager.GetString("ParameterCheck_NotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”不能为空引用或空集合。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotNullOrEmpty_Collection {
            get {
                return ResourceManager.GetString("ParameterCheck_NotNullOrEmpty_Collection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”不能为空引用或空字符串。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotNullOrEmpty_String {
            get {
                return ResourceManager.GetString("ParameterCheck_NotNullOrEmpty_String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数key的长度必须为8或24，当前为{0}。 的本地化字符串。
        /// </summary>
        internal static string Security_DES_KeyLenght {
            get {
                return ResourceManager.GetString("Security_DES_KeyLenght", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数hashType必须为MD5或SHA1 的本地化字符串。
        /// </summary>
        internal static string Security_RSA_Sign_HashType {
            get {
                return ResourceManager.GetString("Security_RSA_Sign_HashType", resourceCulture);
            }
        }
    }
}
