// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromObject
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Object/From Object To Transform Converter")]
	public sealed class FromObjectToTransformConverter : Converter<Object, Transform>
	{
		protected override System.Converter<Object, Transform> converter => DefaultConverters.FromObjectToTransform;
	}
}
