// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUlong
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Ulong/From Ulong To Byte Converter")]
	public sealed class FromUlongToByteConverter : Converter<ulong, byte>
	{
		protected override System.Converter<ulong, byte> converter => DefaultConverters.FromUlongToByte;
	}
}
