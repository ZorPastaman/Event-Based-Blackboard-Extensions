// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromBool
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Bool/From Bool To Ulong Converter")]
	public sealed class FromBoolToUlongConverter : Converter<bool, ulong>
	{
		protected override System.Converter<bool, ulong> converter => DefaultConverters.FromBoolToUlong;
	}
}
