// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromInt
{
	public class FromIntToLongConverter : Converter<int, long>
	{
		protected override System.Converter<int, long> converter => DefaultConverters.FromIntToLong;
	}
}
