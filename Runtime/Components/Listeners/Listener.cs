// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using Zor.EventBasedBlackboard.Core;
using Zor.EventBasedBlackboard.PropertyAttributes;
using Zor.EventBasedBlackboard.Workers.Listening;

namespace Zor.EventBasedBlackboard.Components.Listeners
{
	/// <summary>
	/// <para>Listens to a blackboard property value of <typeparamref name="T"/> change
	/// and calls <see cref="UnityEvent"/>.</para>
	/// <para>Inherit this to implement a new type support.</para>
	/// </summary>
	/// <typeparam name="T">Value type.</typeparam>
	/// <typeparam name="TEvent"><see cref="UnityEvent"/> type.</typeparam>
	/// <remarks>
	/// It's a component wrapper over <see cref="Zor.EventBasedBlackboard.Workers.Listening.Listener{T}"/>.
	/// </remarks>
	public abstract class Listener<T, TEvent> : MonoBehaviour where TEvent : UnityEvent<T>
	{
#pragma warning disable CS0649
		[SerializeField] private BlackboardPropertyReference m_Property;
		[SerializeField, BitMask] private OnEnableBehavior m_OnEnableBehavior = (OnEnableBehavior)~0;
		[SerializeField] private TEvent m_OnChanged;
		[SerializeField] private UnityEvent m_OnRemoved;
#pragma warning restore CS0649

		private Listener<T> m_listener;

		public BlackboardPropertyReference property
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_Property;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_Property = value;
		}

		public OnEnableBehavior onEnableBehavior
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_OnEnableBehavior;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_OnEnableBehavior = value;
		}

		/// <summary>
		/// This event is called when a listened variable is changed to another value.
		/// </summary>
		[NotNull]
		public TEvent onChanged
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_OnChanged;
		}

		/// <summary>
		/// This event is called when a listened variable is removed.
		/// </summary>
		[NotNull]
		public UnityEvent onRemoved
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_OnRemoved;
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
			m_listener = new Listener<T>(m_Property.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_Property.propertyName),
				m_OnEnableBehavior,
				m_OnChanged.Invoke,
				m_OnRemoved.Invoke);
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
