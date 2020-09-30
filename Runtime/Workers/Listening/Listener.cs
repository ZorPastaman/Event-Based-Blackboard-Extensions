// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Workers.Listening
{
	/// <summary>
	/// <para>Listens to a blackboard property value of <typeparamref name="T"/> change
	/// and calls a callback.</para>
	/// </summary>
	/// <typeparam name="T">Value type.</typeparam>
	/// <remarks>
	/// <para>This works on subscriptions of <see cref="Blackboard"/>.</para>
	/// <para>Working is controlled by <see cref="enabled"/>. False by default.</para>
	/// </remarks>
	/// <seealso cref="Zor.EventBasedBlackboard.Components.Listeners.Listener{T,TEvent}"/>
	public sealed class Listener<T>
	{
		private readonly Blackboard m_blackboard;
		private readonly BlackboardPropertyName m_propertyName;

		private readonly OnEnableBehavior m_onEnableBehavior;

		private readonly Action<T> m_onChanged;
		private readonly Action m_onRemoved;

		private readonly Action<BlackboardChangeInfo<T>> m_onPropertyChanged;

		private bool m_enabled;

		public Listener([NotNull] Blackboard blackboard, BlackboardPropertyName propertyName,
			OnEnableBehavior onEnableBehavior,
			[NotNull] Action<T> onChanged, [NotNull] Action onRemoved)
		{
			m_blackboard = blackboard;
			m_propertyName = propertyName;

			m_onEnableBehavior = onEnableBehavior;

			m_onChanged = onChanged;
			m_onRemoved = onRemoved;

			m_onPropertyChanged = OnPropertyChanged;
		}

		/// <summary>
		/// If true, the <see cref="Listener{T}"/> is subscribed;
		/// if false, the <see cref="Listener{T}"/> is not subscribed and does nothing.
		/// </summary>
		/// <remarks>False by default.</remarks>
		public bool enabled
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
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
					Enable();
				}
				else
				{
					Disable();
				}
			}
		}

		private void Enable()
		{
			m_blackboard.Subscribe(m_propertyName, m_onPropertyChanged);

			if (m_onEnableBehavior == 0)
			{
				return;
			}

			if (m_blackboard.TryGetValue(m_propertyName, out T value))
			{
				if ((m_onEnableBehavior & OnEnableBehavior.InvokeOnChangedIfPropertyIsAvailable) != 0)
				{
					m_onChanged.Invoke(value);
				}
			}
			else
			{
				if ((m_onEnableBehavior & OnEnableBehavior.InvokeOnRemovedIfPropertyIsNotAvailable) != 0)
				{
					m_onRemoved.Invoke();
				}
			}
		}

		private void Disable()
		{
			m_blackboard.Unsubscribe(m_propertyName, m_onPropertyChanged);
		}

		private void OnPropertyChanged(BlackboardChangeInfo<T> info)
		{
			if (info.removed)
			{
				m_onRemoved();
			}
			else
			{
				m_onChanged(info.value);
			}
		}
	}
}
