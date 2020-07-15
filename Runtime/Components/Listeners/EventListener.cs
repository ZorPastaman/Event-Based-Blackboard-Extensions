// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;

namespace Zor.EventBasedBlackboard.Components.Listeners
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ListenersFolder + "Event Listener")]
	public sealed class EventListener : ChangedListener<CustomTypes.Event>
	{
	}
}
