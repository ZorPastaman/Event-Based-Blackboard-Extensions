// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromLayerMask
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Layer Mask/From Layer Mask To Int Converter")]
	public sealed class FromLayerMaskToIntConverter : Converter<LayerMask, int>
	{
		protected override System.Converter<LayerMask, int> converter => DefaultConverters.FromLayerMaskToInt;
	}
}
