// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUlong
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Ulong/From Ulong To Float Converter")]
	public sealed class FromUlongToFloatConverter : Converter<ulong, float>
	{
		protected override System.Converter<ulong, float> converter => DefaultConverters.FromUlongToFloat;
	}
}
