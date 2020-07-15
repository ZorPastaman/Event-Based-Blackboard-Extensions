// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromSbyte
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Sbyte/From Sbyte To Double Converter")]
	public sealed class FromSbyteToDoubleConverter : Converter<sbyte, double>
	{
		protected override System.Converter<sbyte, double> converter => DefaultConverters.FromSbyteToDouble;
	}
}
