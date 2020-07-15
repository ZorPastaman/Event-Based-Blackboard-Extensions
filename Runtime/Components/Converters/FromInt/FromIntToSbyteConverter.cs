// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromInt
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Int/From Int To Sbyte Converter")]
	public sealed class FromIntToSbyteConverter : Converter<int, sbyte>
	{
		protected override System.Converter<int, sbyte> converter => DefaultConverters.FromIntToSbyte;
	}
}
