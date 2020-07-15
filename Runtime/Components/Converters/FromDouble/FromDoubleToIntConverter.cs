// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromDouble
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Double/From Double To Int Converter")]
	public sealed class FromDoubleToIntConverter : Converter<double, int>
	{
		protected override System.Converter<double, int> converter => DefaultConverters.FromDoubleToInt;
	}
}
