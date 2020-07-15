// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromUshort
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Ushort/From Ushort To Bool Converter")]
	public sealed class FromUshortToBoolConverter : Converter<ushort, bool>
	{
		protected override System.Converter<ushort, bool> converter => DefaultConverters.FromUshortToBool;
	}
}
