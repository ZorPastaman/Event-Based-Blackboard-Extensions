// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromBool
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Bool/From Bool To Short Converter")]
	public sealed class FromBoolToShortConverter : Converter<bool, short>
	{
		protected override System.Converter<bool, short> converter => DefaultConverters.FromBoolToShort;
	}
}
