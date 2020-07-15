// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using JetBrains.Annotations;
using UnityEngine;
using Zor.EventBasedBlackboard.Core;
using Zor.EventBasedBlackboard.PropertyAttributes;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters
{
	/// <summary>
	/// <para>Automatically converts a blackboard property value of <typeparamref name="TFrom"/> into
	/// <typeparamref name="TTo"/> and sets it into a <see cref="Zor.EventBasedBlackboard.Core.Blackboard"/>.</para>
	/// <para>Inherit this to implement a new conversion support.</para>
	/// </summary>
	/// <typeparam name="TFrom">From value type.</typeparam>
	/// <typeparam name="TTo">To value type.</typeparam>
	/// <remarks>
	/// It's a component wrapper over <see cref="Zor.EventBasedBlackboard.Workers.Conversion.Converter{TFrom, TTo}"/>.
	/// </remarks>
	public abstract class Converter<TFrom, TTo> : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField] private BlackboardPropertyReference m_From;
		[SerializeField] private BlackboardPropertyReference m_To;
		[SerializeField, BitMask] private OnEnableBehavior m_OnEnableBehavior = (OnEnableBehavior)~0;
#pragma warning restore CS0649

		private Workers.Conversion.Converter<TFrom, TTo> m_converter;

		/// <summary>
		/// Conversion function.
		/// </summary>
		[NotNull]
		protected abstract System.Converter<TFrom, TTo> converter { get; }

		private void Awake()
		{
			m_converter = new Workers.Conversion.Converter<TFrom, TTo>(m_From.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_From.propertyName),
				m_To.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_To.propertyName),
				m_OnEnableBehavior,
				converter);
		}

		private void OnEnable()
		{
			m_converter.enabled = true;
		}

		private void OnDisable()
		{
			m_converter.enabled = false;
		}
	}
}
