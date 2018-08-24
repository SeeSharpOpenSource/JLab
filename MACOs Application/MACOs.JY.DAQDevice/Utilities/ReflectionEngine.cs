using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MACOs.JY.DAQDevice.Utilities
{
    public static class ReflectionEngine
    {
        #region Public Methods

        public static Type[] GetNamespaces(string dllPath)
        {
            try
            {
                return Assembly.LoadFile(dllPath).GetTypes().Distinct().ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Type[] GetClasses(string dllPath, string _namespace, bool onlyPublic = true)
        {
            try
            {
                Func<Type, bool> func = x => x.Namespace == _namespace && x.IsClass && !x.IsAbstract && (onlyPublic ? x.IsPublic : true);
                List<Type> list = Assembly.LoadFile(dllPath).GetTypes().Where(func).ToList();
                var sortlist = list.OrderBy(x => x.Name).ToList();
                return sortlist.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Type[] GetEnums(string dllPath, string _namespace, bool onlyPublic = true)
        {
            try
            {
                Func<Type, bool> func = x => x.Namespace == _namespace && x.IsEnum && (onlyPublic ? x.IsPublic : true);
                List<Type> list = Assembly.LoadFile(dllPath).GetTypes().Where(func).ToList();
                var sortlist = list.OrderBy(x => x.Name).ToList();
                return sortlist.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static ConstructorInfo[] GetConstructors(string dllPath, string _namespace, string _class)
        {
            try
            {
                Assembly assem = Assembly.LoadFile(dllPath);
                var t = assem.GetType(_namespace + "." + _class).GetConstructors();
                return t.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static MethodInfo[] GetMethods(string dllPath, string _namespace, string _class)
        {
            try
            {
                BindingFlags flags = BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Instance;

                Assembly assem = Assembly.LoadFile(dllPath);
                Type t = assem.GetType(_namespace + "." + _class);
                return t.GetMethods(flags).ToList().ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static MethodInfo[] GetMethods(object src)
        {
            try
            {
                BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

                Type t = src.GetType();
                return t.GetMethods(flags).ToList().ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static PropertyInfo[] GetProperties(string dllPath, string _namespace, string _class)
        {
            try
            {
                BindingFlags flags = BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Instance;

                Assembly assem = Assembly.LoadFile(dllPath);
                Type t = assem.GetType(_namespace + "." + _class);

                return t.GetProperties(flags);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static object CreateObject(ConstructorInfo ctor, params object[] parameters)
        {
            try
            {
                return ctor.Invoke(parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static object InvokeMethod(object src, MethodInfo method, params object[] parameter)
        {
            return method.Invoke(src, parameter);
        }

        #endregion Public Methods
    }
}