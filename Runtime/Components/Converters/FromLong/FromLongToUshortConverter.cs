// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromLong
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Long/From Long To Ushort Converter")]
	public sealed class FromLongToUshortConverter : Converter<long, ushort>
	{
		protected override System.Converter<long, ushort> converter => DefaultConverters.FromLongToUshort;
	}
}
