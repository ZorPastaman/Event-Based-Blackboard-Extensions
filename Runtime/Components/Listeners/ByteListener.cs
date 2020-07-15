// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.UnityEvents;

namespace Zor.EventBasedBlackboard.Components.Listeners
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ListenersFolder + "Byte Listener")]
	public sealed class ByteListener : Listener<byte, ByteEvent>
	{
	}
}
