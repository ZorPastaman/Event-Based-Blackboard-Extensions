// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromTransform
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Transform/From Transform To Object Converter")]
	public sealed class FromTransformToObjectConverter : Converter<Transform, Object>
	{
		protected override System.Converter<Transform, Object> converter => DefaultConverters.FromTransformToObject;
	}
}
