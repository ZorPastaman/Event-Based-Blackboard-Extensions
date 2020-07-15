// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromComponent
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Component/From Component To Object Converter")]
	public sealed class FromComponentToObjectConverter : Converter<Component, Object>
	{
		protected override System.Converter<Component, Object> converter => DefaultConverters.FromComponentToObject;
	}
}
