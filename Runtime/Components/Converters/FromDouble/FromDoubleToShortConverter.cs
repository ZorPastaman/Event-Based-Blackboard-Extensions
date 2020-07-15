// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromDouble
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Double/From Double To Short Converter")]
	public sealed class FromDoubleToShortConverter : Converter<double, short>
	{
		protected override System.Converter<double, short> converter => DefaultConverters.FromDoubleToShort;
	}
}
