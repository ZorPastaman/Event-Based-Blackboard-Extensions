// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUint
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Uint/From Uint To Bool Converter")]
	public sealed class FromUintToBoolConverter : Converter<uint, bool>
	{
		protected override System.Converter<uint, bool> converter => DefaultConverters.FromUintToBool;
	}
}
