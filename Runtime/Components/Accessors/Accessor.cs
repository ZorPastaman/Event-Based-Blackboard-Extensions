// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Scripting;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Components.Accessors
{
	/// <summary>
	/// <para>Accessor for a property of <typeparamref name="T"/> in a blackboard.</para>
	/// <para>Inherit this to implement a new type support.</para>
	/// </summary>
	/// <typeparam name="T">Value type.</typeparam>
	public abstract class Accessor<T> : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField] private BlackboardPropertyReference m_Property;
#pragma warning restore CS0649

		private BlackboardPropertyName m_propertyName;
		private bool m_initialized;

		public BlackboardPropertyReference blackboardPropertyReference
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_Property;
			set
			{
				if (m_Property == value)
				{
					return;
				}

				m_Property = value;
				m_initialized = false;
			}
		}

		[Preserve, CanBeNull]
		public T value
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get
			{
				m_Property.blackboardContainer.blackboard.TryGetValue(propertyName, out T answer);
				return answer;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_Property.blackboardContainer.blackboard.SetValue(propertyName, value);
		}

		private BlackboardPropertyName propertyName
		{
			get
			{
				if (!m_initialized)
				{
					m_propertyName = new BlackboardPropertyName(m_Property.propertyName);
					m_initialized = true;
				}

				return m_propertyName;
			}
		}
	}
}
