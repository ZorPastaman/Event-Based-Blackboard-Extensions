// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromColor
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Color/From Color To Vector4 Converter")]
	public sealed class FromColorToVector4Converter : Converter<Color, Vector4>
	{
		protected override System.Converter<Color, Vector4> converter => DefaultConverters.FromColorToVector4;
	}
}
