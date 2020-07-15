// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromFloat
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Float/From Float To Short Converter")]
	public sealed class FromFloatToShortConverter : Converter<float, short>
	{
		protected override System.Converter<float, short> converter => DefaultConverters.FromFloatToShort;
	}
}
