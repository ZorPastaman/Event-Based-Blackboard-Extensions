// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUlong
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Ulong/From Ulong To Uint Converter")]
	public sealed class FromUlongToUintConverter : Converter<ulong, uint>
	{
		protected override System.Converter<ulong, uint> converter => DefaultConverters.FromUlongToUint;
	}
}
