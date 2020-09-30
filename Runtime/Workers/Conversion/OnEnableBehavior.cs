// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;

namespace Zor.EventBasedBlackboard.Workers.Conversion
{
	[Flags]
	public enum OnEnableBehavior
	{
		InvokeConvertIfPropertyIsAvailable = 1 << 0,
		InvokeConvertNothingIfPropertyIsNotAvailable = 1 << 1
	}
}
