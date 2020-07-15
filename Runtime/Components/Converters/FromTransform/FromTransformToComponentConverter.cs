// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromTransform
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Transform/From Transform To Component Converter")]
	public sealed class FromTransformToComponentConverter : Converter<Transform, Component>
	{
		protected override System.Converter<Transform, Component> converter =>
			DefaultConverters.FromTransformToComponent;
	}
}
