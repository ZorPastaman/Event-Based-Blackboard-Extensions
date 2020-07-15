// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;

namespace Zor.EventBasedBlackboard.Workers.Listening
{
	[Flags]
	public enum OnEnableBehavior
	{
		InvokeOnChangedIfPropertyIsAvailable = 1,
		InvokeOnRemovedIfPropertyIsNotAvailable = 1 << 1
	}
}
