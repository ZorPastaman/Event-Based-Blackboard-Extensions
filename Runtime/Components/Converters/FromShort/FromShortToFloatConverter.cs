// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromShort
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Short/From Short To Float Converter")]
	public sealed class FromShortToFloatConverter : Converter<short, float>
	{
		protected override System.Converter<short, float> converter => DefaultConverters.FromShortToFloat;
	}
}
