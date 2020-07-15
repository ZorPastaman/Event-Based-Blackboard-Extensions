// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromDouble
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Double/From Double To Uint Converter")]
	public sealed class FromDoubleToUintConverter : Converter<double, uint>
	{
		protected override System.Converter<double, uint> converter => DefaultConverters.FromDoubleToUint;
	}
}
