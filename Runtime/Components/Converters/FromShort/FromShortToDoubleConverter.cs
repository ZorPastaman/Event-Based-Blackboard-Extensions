// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromShort
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Short/From Short to Double Converter")]
	public sealed class FromShortToDoubleConverter : Converter<short, double>
	{
		protected override System.Converter<short, double> converter => DefaultConverters.FromShortToDouble;
	}
}
