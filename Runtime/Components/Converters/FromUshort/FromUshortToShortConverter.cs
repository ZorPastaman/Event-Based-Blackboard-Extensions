// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUshort
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Ushort/From Ushort To Short Converter")]
	public sealed class FromUshortToShortConverter : Converter<ushort, short>
	{
		protected override System.Converter<ushort, short> converter => DefaultConverters.FromUshortToShort;
	}
}
