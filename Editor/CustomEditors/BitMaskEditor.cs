// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEditor;
using UnityEngine;

namespace Zor.EventBasedBlackboard.PropertyAttributes
{
	[CustomPropertyDrawer(typeof(BitMaskAttribute))]
	public class BitMaskEditor : PropertyDrawer
	{
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return EditorGUI.GetPropertyHeight(property, label);
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var value = (Enum)Enum.ToObject(fieldInfo.FieldType, property.intValue);
			value = EditorGUI.EnumFlagsField(position, label, value);
			property.intValue = (int)Convert.ChangeType(value, typeof(int));
		}
	}
}
