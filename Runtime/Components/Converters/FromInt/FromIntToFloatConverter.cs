// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromInt
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Int/From Int To Float Converter")]
	public sealed class FromIntToFloatConverter : Converter<int, float>
	{
		protected override System.Converter<int, float> converter => DefaultConverters.FromIntToFloat;
	}
}
