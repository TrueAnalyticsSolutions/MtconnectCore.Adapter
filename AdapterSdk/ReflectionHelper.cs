using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using System;
using System.Collections.Generic;

namespace Mtconnect
{
    internal static class ReflectionHelper
    {
        /// <summary>
        /// Determines if the provided type is an implementation of the <see cref="IComponentModel"/> interface.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to be evaluated</param>
        /// <returns>Flag for whether or not the provided type is an implementation of the <see cref="IComponentModel"/> interface</returns>
        internal static bool IsComponentType(this Type type)
        {
            if (type.GetInterface(nameof(IComponentModel)) != null)
                return true;
            if (type.IsDictionaryOfModel<IComponentModel>())
                return true;
            if (type.IsListOfModel<IComponentModel>())
                return true;
            return false;
        }

        internal static bool IsDataModelType(this Type type)
        {
            if (type.GetInterface(nameof(IAdapterDataModel)) != null)
                return true;
            return false;
        }
        internal static bool IsDataItemType(this Type type)
        {
            if (typeof(DataItem).IsAssignableFrom(type))
                return true;
            if (typeof(IDataItemValue).IsAssignableFrom(type))
                return true;
            return false;
        }

        /// <summary>
        /// Determines if the provided type is a <see cref="Dictionary{TKey, TValue}"/> containing values of the provided <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Generic type expected to be in the values of a <see cref="Dictionary{TKey, TValue}"/></typeparam>
        /// <param name="type">The <see cref="Type"/> to be evaluated</param>
        /// <returns>Flag for whether or not the provided type is an implementation of <see cref="Dictionary{TKey, TValue}"/> where TValue is of type <typeparamref name="T"/></returns>
        internal static bool IsDictionaryOfModel<T>(this Type type)
        {
            if (!type.IsGenericType)
                return false;
            if (type.GetGenericTypeDefinition() != typeof(Dictionary<,>))
                return false;
            var genericArguments = type.GetGenericArguments();
            if (genericArguments[0] != typeof(string) || genericArguments[1].GetInterface(typeof(T).Name) == null)
                return false;
            return true;
        }

        /// <summary>
        /// Determines if the provided type is a <see cref="List{T}"/> containing values of the provided <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Generic type expected to be in the values of a <see cref="List{T}"/></typeparam>
        /// <param name="type">The <see cref="Type"/> to be evaluated</param>
        /// <returns>Flag for whether or not the provided type is an implementation of <see cref="List{T}"/> where T is of type <typeparamref name="T"/></returns>
        internal static bool IsListOfModel<T>(this Type type)
        {
            if (!type.IsGenericType)
                return false;
            if (type.GetGenericTypeDefinition() != typeof(List<>))
                return false;
            var genericArguments = type.GetGenericArguments();
            if (genericArguments[0].GetInterface(typeof(T).Name) == null)
                return false;
            return true;
        }
    }
}