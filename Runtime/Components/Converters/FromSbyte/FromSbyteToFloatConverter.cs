// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromSbyte
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Sbyte/From Sbyte To Float Converter")]
	public sealed class FromSbyteToFloatConverter : Converter<sbyte, float>
	{
		protected override System.Converter<sbyte, float> converter => DefaultConverters.FromSbyteToFloat;
	}
}
