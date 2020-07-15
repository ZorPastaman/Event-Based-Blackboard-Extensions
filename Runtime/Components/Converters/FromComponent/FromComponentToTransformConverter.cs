// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromComponent
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Component/From Component To Transform Converter")]
	public sealed class FromComponentToTransformConverter : Converter<Component, Transform>
	{
		protected override System.Converter<Component, Transform> converter =>
			DefaultConverters.FromComponentToTransform;
	}
}
