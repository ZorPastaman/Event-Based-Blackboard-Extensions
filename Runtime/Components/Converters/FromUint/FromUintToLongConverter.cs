// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUint
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Uint/From Uint To Long Converter")]
	public sealed class FromUintToLongConverter : Converter<uint, long>
	{
		protected override System.Converter<uint, long> converter => DefaultConverters.FromUintToLong;
	}
}
