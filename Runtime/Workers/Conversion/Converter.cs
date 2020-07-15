// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using JetBrains.Annotations;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Workers.Conversion
{
	/// <summary>
	/// Automatically converts a blackboard property value of <typeparamref name="TFrom"/> into
	/// <typeparamref name="TTo"/> and sets it into a <see cref="Zor.EventBasedBlackboard.Core.Blackboard"/>.
	/// </summary>
	/// <typeparam name="TFrom">From value type.</typeparam>
	/// <typeparam name="TTo">To value type.</typeparam>
	/// <remarks>
	/// <para>This works on subscriptions of <see cref="Blackboard"/>.</para>
	/// <para>Working is controlled by <see cref="enabled"/>. False by default.</para>
	/// </remarks>
	/// <seealso cref="Zor.EventBasedBlackboard.Components.Converters.Converter{TFrom,TTo}"/>
	public sealed class Converter<TFrom, TTo>
	{
		private readonly Blackboard m_fromBlackboard;
		private readonly BlackboardPropertyName m_fromPropertyName;

		private readonly Blackboard m_toBlackboard;
		private readonly BlackboardPropertyName m_toPropertyName;

		private readonly OnEnableBehavior m_onEnableBehavior;

		private readonly System.Converter<TFrom, TTo> m_converter;

		private readonly Action<BlackboardChangeInfo<TFrom>> m_onFromChanged;

		private bool m_enabled;

		public Converter([NotNull] Blackboard fromBlackboard, BlackboardPropertyName fromPropertyName,
			[NotNull] Blackboard toBlackboard, BlackboardPropertyName toPropertyName,
			OnEnableBehavior onEnableBehavior,
			[NotNull] System.Converter<TFrom, TTo> converter)
		{
			m_fromBlackboard = fromBlackboard;
			m_fromPropertyName = fromPropertyName;

			m_toBlackboard = toBlackboard;
			m_toPropertyName = toPropertyName;

			m_onEnableBehavior = onEnableBehavior;

			m_converter = converter;

			m_onFromChanged = OnFromChanged;
		}

		/// <summary>
		/// If true, the <see cref="Converter{TFrom,TTo}"/> is subscribed;
		/// if false, the <see cref="Converter{TFrom,TTo}"/> is not subscribed and does nothing.
		/// </summary>
		/// <remarks>False by default.</remarks>
		public bool enabled
		{
			get => m_enabled;
			set
			{
				if (m_enabled == value)
				{
					return;
				}

				m_enabled = value;

				if (m_enabled)
				{
					OnEnable();
				}
				else
				{
					OnDisable();
				}
			}
		}

		private void OnEnable()
		{
			m_fromBlackboard.Subscribe(m_fromPropertyName, m_onFromChanged);

			if (m_onEnableBehavior == 0)
			{
				return;
			}

			if (m_fromBlackboard.TryGetValue(m_fromPropertyName, out TFrom fromValue))
			{
				if ((m_onEnableBehavior & OnEnableBehavior.InvokeConvertIfPropertyIsAvailable) != 0)
				{
					m_toBlackboard.SetValue(m_toPropertyName, m_converter(fromValue));
				}
			}
			else
			{
				if ((m_onEnableBehavior & OnEnableBehavior.InvokeConvertNothingIfPropertyIsNotAvailable) != 0)
				{
					m_toBlackboard.SetValue<TTo>(m_toPropertyName, default);
				}
			}
		}

		private void OnDisable()
		{
			m_fromBlackboard.Unsubscribe(m_fromPropertyName, m_onFromChanged);
		}

		private void OnFromChanged(BlackboardChangeInfo<TFrom> info)
		{
			TTo value = info.removed ? default : m_converter(info.value);
			m_toBlackboard.SetValue(m_toPropertyName, value);
		}
	}
}
