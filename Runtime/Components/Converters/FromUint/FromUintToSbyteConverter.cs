// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUint
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Uint/From Uint To Sbyte Converter")]
	public sealed class FromUintToSbyteConverter : Converter<uint, sbyte>
	{
		protected override System.Converter<uint, sbyte> converter => DefaultConverters.FromUintToSbyte;
	}
}
