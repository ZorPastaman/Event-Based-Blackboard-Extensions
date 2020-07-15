// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUshort
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Ushort/From Ushort To Sbyte Converter")]
	public sealed class FromUshortToSbyteConverter : Converter<ushort, sbyte>
	{
		protected override System.Converter<ushort, sbyte> converter => DefaultConverters.FromUshortToSbyte;
	}
}
