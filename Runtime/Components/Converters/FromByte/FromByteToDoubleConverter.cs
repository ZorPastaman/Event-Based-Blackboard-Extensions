// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromByte
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Byte/From Byte To Double Converter")]
	public sealed class FromByteToDoubleConverter : Converter<byte, double>
	{
		protected override System.Converter<byte, double> converter => DefaultConverters.FromByteToDouble;
	}
}
