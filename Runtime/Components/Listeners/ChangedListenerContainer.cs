// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using Zor.EventBasedBlackboard.Workers.Listening;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Components.Listeners
{
	/// <summary>
	/// <para>Listens to a blackboard property value of <typeparamref name="T"/> change
	/// and calls <see cref="UnityEvent"/>.</para>
	/// <para>Inherit this to implement a new type support.</para>
	/// </summary>
	/// <typeparam name="T">Value type.</typeparam>
	/// <remarks>
	/// It's a component wrapper over <see cref="Zor.EventBasedBlackboard.Workers.Listening.Listener{T}"/>.
	/// </remarks>
	public abstract class ChangedListener<T> : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField] private BlackboardPropertyReference m_Property;
		[SerializeField] private UnityEvent m_OnDispatched;
#pragma warning restore CS0649

		private Workers.Listening.ChangedListener<T> m_listener;

		public BlackboardPropertyReference property
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_Property;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_Property = value;
		}

		/// <summary>
		/// This event is called when a listened variable is changed or removed.
		/// </summary>
		[NotNull]
		public UnityEvent onDispatched
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_OnDispatched;
		}

		[ContextMenu("Recreate Listener")]
		public void RecreateListener()
		{
			if (m_listener == null)
			{
				return;
			}

			bool wasEnabled = m_listener.enabled;
			m_listener.enabled = false;
			Awake();
			m_listener.enabled = wasEnabled;
		}

		private void Awake()
		{
			m_listener = new Workers.Listening.ChangedListener<T>(m_Property.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_Property.propertyName),
				m_OnDispatched.Invoke);
		}

		private void OnEnable()
		{
			m_listener.enabled = true;
		}

		private void OnDisable()
		{
			m_listener.enabled = false;
		}
	}
}
