// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromLong
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Long/From Long To Short Converter")]
	public sealed class FromLongToShortConverter : Converter<long, short>
	{
		protected override System.Converter<long, short> converter => DefaultConverters.FromLongToShort;
	}
}
