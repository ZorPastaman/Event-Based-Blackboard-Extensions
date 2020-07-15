// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.UnityEvents;

namespace Zor.EventBasedBlackboard.Components.Listeners
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ListenersFolder + "Vector3 Int Listener")]
	public sealed class Vector3IntListener : Listener<Vector3Int, Vector3IntEvent>
	{
	}
}
