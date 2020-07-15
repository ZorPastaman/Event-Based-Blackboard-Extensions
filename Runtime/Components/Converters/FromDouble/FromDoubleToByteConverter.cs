// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromDouble
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Double/From Double To Byte Converter")]
	public sealed class FromDoubleToByteConverter : Converter<double, byte>
	{
		protected override System.Converter<double, byte> converter => DefaultConverters.FromDoubleToByte;
	}
}
