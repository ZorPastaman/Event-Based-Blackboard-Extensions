// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromByte
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Byte/From Byte To Uint Converter")]
	public sealed class FromByteToUintConverter : Converter<byte, uint>
	{
		protected override System.Converter<byte, uint> converter => DefaultConverters.FromByteToUint;
	}
}
