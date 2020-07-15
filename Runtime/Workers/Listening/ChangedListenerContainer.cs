// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using JetBrains.Annotations;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Workers.Listening
{
	/// <summary>
	/// Listens to a blackboard property value of <typeparamref name="T"/> change
	/// and calls a callback.
	/// </summary>
	/// <typeparam name="T">Value type.</typeparam>
	/// <remarks>
	/// <para>This works on subscriptions of <see cref="Blackboard"/>.</para>
	/// <para>Working is controlled by <see cref="enabled"/>. False by default.</para>
	/// </remarks>
	/// <seealso cref="Zor.EventBasedBlackboard.Components.Listeners.ChangedListener{T}"/>
	public sealed class ChangedListener<T>
	{
		private readonly Blackboard m_blackboard;
		private readonly BlackboardPropertyName m_propertyName;

		private readonly Action m_onChanged;

		private bool m_enabled;

		public ChangedListener([NotNull] Blackboard blackboard, BlackboardPropertyName propertyName,
			[NotNull] Action onChanged)
		{
			m_blackboard = blackboard;
			m_propertyName = propertyName;

			m_onChanged = onChanged;
		}

		/// <summary>
		/// If true, the <see cref="ChangedListener{T}"/> is subscribed;
		/// if false, the <see cref="ChangedListener{T}"/> is not subscribed and does nothing.
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
					m_blackboard.Subscribe<T>(m_propertyName, m_onChanged);
				}
				else
				{
					m_blackboard.Unsubscribe<T>(m_propertyName, m_onChanged);
				}
			}
		}
	}
}
