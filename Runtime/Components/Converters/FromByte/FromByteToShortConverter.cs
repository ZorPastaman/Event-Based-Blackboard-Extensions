// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromByte
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Byte/From Byte To Short Converter")]
	public sealed class FromByteToShortConverter : Converter<byte, short>
	{
		protected override System.Converter<byte, short> converter => DefaultConverters.FromByteToShort;
	}
}
