﻿using System;
using System.Reflection;

namespace ShotCountEnabler {
    public static class ReflectionHelper {
        
        public static object InvokePrivateMethode(object instance, string methodname, object[] parameters) {
            Type type = instance.GetType();
            MethodInfo methodInfo = type.GetMethod(methodname, BindingFlags.NonPublic | BindingFlags.Instance);
            return methodInfo.Invoke(instance, parameters);
        }

        public static void SetPrivateField(object instance, string fieldname, object value) {
            Type type = instance.GetType();
            FieldInfo field = type.GetField(fieldname, BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(instance, value);
        }
    }
}