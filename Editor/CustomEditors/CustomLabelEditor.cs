// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using Zor.EventBasedBlackboard.Components;
using Zor.EventBasedBlackboard.EditorTools;

namespace Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel
{
	[CustomPropertyDrawer(typeof(CustomLabelAttribute))]
	public sealed class CustomLabelEditor : PropertyDrawer
	{
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return property.type == nameof(BlackboardPropertyReference)
				? BlackboardPropertyReferenceDrawer.GetPropertyHeight(property, label)
				: EditorGUI.GetPropertyHeight(property, true);
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			CustomLabelInfoAttribute info = FindCustomLabelInfo(property);

			if (info != null)
			{
				label.text = ModifyLabel(label.text, info);
			}

			if (property.type == nameof(BlackboardPropertyReference))
			{
				BlackboardPropertyReferenceDrawer.OnGUI(position, property, label);
			}
			else
			{
				EditorGUI.PropertyField(position, property, label, true);
			}
		}

		[CanBeNull]
		private CustomLabelInfoAttribute FindCustomLabelInfo([NotNull] SerializedProperty property)
		{
			Type propertyObjectType = property.serializedObject.targetObject.GetType();
			var customLabelInfos = (CustomLabelInfoAttribute[])propertyObjectType
				.GetCustomAttributes(typeof(CustomLabelInfoAttribute), true);
			int customLabelIndex = ((CustomLabelAttribute)attribute).index;

			for (int i = 0, count = customLabelInfos.Length; i < count; ++i)
			{
				CustomLabelInfoAttribute info = customLabelInfos[i];

				if (info.index == customLabelIndex)
				{
					return info;
				}
			}

			return null;
		}

		[NotNull]
		private static string ModifyLabel(string label, [NotNull] CustomLabelInfoAttribute info)
		{
			if (info.name != null && info.type != null)
			{
				return $"{label} ({info.name}) : {info.type}";
			}

			if (info.name != null)
			{
				return $"{label} ({info.name})";
			}

			if (info.type != null)
			{
				return $"{label} : {info.type}";
			}

			return label;
		}
	}
}
