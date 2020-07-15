// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using UnityEngine.Scripting;
using Zor.EventBasedBlackboard.Core;
using Event = Zor.EventBasedBlackboard.CustomTypes.Event;

namespace Zor.EventBasedBlackboard.Components.Accessors
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.AccessorsFolder + "Event Accessor")]
	public sealed class EventSetter : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField] private BlackboardPropertyReference m_BlackboardPropertyReference;
#pragma warning restore CS0649

		private BlackboardPropertyName m_propertyName;
		private bool m_initialized;

		[Preserve]
		public void Dispatch()
		{
			if (!m_initialized)
			{
				m_propertyName = new BlackboardPropertyName(m_BlackboardPropertyReference.propertyName);
				m_initialized = true;
			}

			m_BlackboardPropertyReference.blackboardContainer.blackboard.SetValue(m_propertyName, new Event());
		}
	}
}
