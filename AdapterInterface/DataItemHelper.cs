using Mtconnect.AdapterInterface.Contracts.Attributes;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Mtconnect
{
    public static class DataItemHelper
    {
        internal static string RemoveControlCharacters(this string input)
        {
            // Create a new string builder to hold the cleaned string
            var builder = new StringBuilder();

            // Loop through each character in the input string
            foreach (var c in input)
            {
                // If the character is not a control code character, add it to the builder
                if (!char.IsControl(c))
                {
                    builder.Append(c);
                }
            }

            // Return the cleaned string
            return builder.ToString();
        }


        /// <summary>
        /// <inheritdoc cref="GetSubTypes(Type, string)" path="/summary"/>
        /// </summary>
        /// <typeparam name="T">Generic type reference for the provided <paramref name="dataItemType"/>.</typeparam>
        /// <param name="dataItemType"><inheritdoc cref="GetSubTypes(Type, string)" path="/param[@name='dataItemType']"/></param>
        /// <returns><inheritdoc cref="GetSubTypes(Type, string)" path="/returns"/></returns>
        public static Type GetSubTypes<T>(T dataItemType) where T : Enum
            => GetSubTypes(typeof(T), dataItemType.ToString());
        /// <summary>
        /// Gets the type for the enum associated with any potential DataItem <c>subType</c> for the provided <paramref name="dataItemType"/>.
        /// </summary>
        /// <param name="enumType">Type reference for the provided <paramref name="dataItemType"/>.</param>
        /// <param name="dataItemType">Reference to the specific DataItem <c>type</c>.</param>
        /// <returns>Type of the enum containing available <c>subType</c>s for the provided <paramref name="dataItemType"/>. Returns <c>null</c> if the <paramref name="dataItemType"/> in the <paramref name="enumType"/> is not decorated with the <see cref="ObservationalSubTypeAttribute"/>.</returns>
        public static Type GetSubTypes(Type enumType, string dataItemType)
        {
            var subTypeAttribute = enumType.GetMember(dataItemType)
                ?.FirstOrDefault(o => o.DeclaringType == enumType)
                ?.GetCustomAttributes<ObservationalSubTypeAttribute>(true)
                ?.FirstOrDefault();

            if (subTypeAttribute != null && subTypeAttribute is ObservationalSubTypeAttribute)
                return (subTypeAttribute as ObservationalSubTypeAttribute).SubTypeEnum;

            return null;
        }

        /// <typeparam name="T">Generic type reference for the provided <paramref name="dataItemType"/>.</typeparam>
        /// <inheritdoc cref="GetSubType(Type, string, string)"/>
        public static Enum GetSubType<T>(T dataItemType, string dataItemSubType) where T : Enum
            => GetSubType(typeof(T), dataItemType.ToString(), dataItemSubType);
        /// <summary>
        /// Finds the enum value for the given <paramref name="dataItemSubType"/> after discovering an applicable DataItem <c>subType</c> enum from the provided <paramref name="enumType"/>.
        /// </summary>
        /// <param name="enumType"><inheritdoc cref="GetSubTypes(Type, string)" path="/param[@name='enumType']"/></param>
        /// <param name="dataItemType"><inheritdoc cref="GetSubTypes(Type, string)" path="/param[@name='dataItemType']"/></param>
        /// <param name="dataItemSubType"></param>
        /// <returns>Enum of the equivelant string from <paramref name="dataItemSubType"/>. Returns <c>null</c> if no <c>subType</c> enum could be found or if the value could not be parsed.</returns>
        public static Enum GetSubType(Type enumType, string dataItemType, string dataItemSubType)
        {
            Type subTypeEnum = GetSubTypes(enumType, dataItemType);
#if NET461_OR_GREATER
            if (subTypeEnum != null)
            {
                var enumValue = Enum.Parse(subTypeEnum, dataItemSubType);
                if (enumValue != null)
                    return enumValue as Enum;
            }
#else
            if (subTypeEnum != null && Enum.TryParse(subTypeEnum, dataItemSubType, true, out var subType)) return subType as Enum;
#endif
            return null;
        }

        /// <summary>
        /// <inheritdoc cref="GetValues(Type, string)" path="/summary"/>
        /// </summary>
        /// <typeparam name="T">Generic type reference for the provided <paramref name="dataItemType"/>.</typeparam>
        /// <param name="dataItemType"><inheritdoc cref="GetValues(Type, string)" path="/param[@name='dataItemType']"/></param>
        /// <returns><inheritdoc cref="GetValues(Type, string)" path="/returns"/></returns>
        public static Type GetValues<T>(T dataItemType) where T : Enum
            => GetValues(typeof(T), dataItemType.ToString());
        /// <summary>
        /// Gets the type for the enum associated with any potential DataItem <c>value</c> for the provided <paramref name="dataItemType"/>.
        /// </summary>
        /// <param name="enumType">Type reference for the provided <paramref name="dataItemType"/>.</param>
        /// <param name="dataItemType">Reference to the specific DataItem <c>type</c>.</param>
        /// <returns>Type of the enum containing available <c>value</c>s for the provided <paramref name="dataItemType"/>. Returns <c>null</c> if the <paramref name="dataItemType"/> in the <paramref name="enumType"/> is not decorated with the <see cref="ObservationalValueAttribute"/>.</returns>
        public static Type GetValues(Type enumType, string dataItemType)
        {
            var valueTypeAttribute = enumType.GetMember(dataItemType)
                ?.FirstOrDefault(o => o.DeclaringType == enumType)
                ?.GetCustomAttributes<ObservationalValueAttribute>(true)
                ?.FirstOrDefault();

            if (valueTypeAttribute != null && valueTypeAttribute is ObservationalValueAttribute)
                return (valueTypeAttribute as ObservationalValueAttribute).ValueEnum;

            return null;
        }

        /// <typeparam name="T">Generic type reference for the provided <paramref name="dataItemType"/>.</typeparam>
        /// <inheritdoc cref="GetValue(Type, string, string)"/>
        public static Enum GetValue<T>(T dataItemType, string dataItemValue) where T : Enum
            => GetValue(typeof(T), dataItemType.ToString(), dataItemValue);
        /// <summary>
        /// Finds the enum value for the given <paramref name="dataItemValue"/> after discovering an applicable DataItem <c>value</c> enum from the provided <paramref name="enumType"/>.
        /// </summary>
        /// <param name="enumType"><inheritdoc cref="GetValues(Type, string)" path="/param[@name='enumType']"/></param>
        /// <param name="dataItemType"><inheritdoc cref="GetValues(Type, string)" path="/param[@name='dataItemType']"/></param>
        /// <param name="dataItemValue"></param>
        /// <returns>Enum of the equivelant string from <paramref name="dataItemValue"/>. Returns <c>null</c> if no <c>value</c> enum could be found or if the value could not be parsed.</returns>
        public static Enum GetValue(Type enumType, string dataItemType, string dataItemValue)
        {
            Type valueTypeEnum = GetValues(enumType, dataItemType);
#if NET461_OR_GREATER
            if (valueTypeEnum != null)
            {
                var enumValue = Enum.Parse(valueTypeEnum, dataItemValue);
                if (enumValue != null)
                    return enumValue as Enum;
            }
#else
            if (valueTypeEnum != null && Enum.TryParse(valueTypeEnum, dataItemValue, true, out var value))
                return value as Enum;
#endif
            return null;
        }
    }
}