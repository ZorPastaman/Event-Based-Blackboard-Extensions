// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

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
