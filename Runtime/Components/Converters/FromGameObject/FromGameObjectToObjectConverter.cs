// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromGameObject
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From GameObject/From GameObject To Object Converter")]
	public sealed class FromGameObjectToObjectConverter : Converter<GameObject, Object>
	{
		protected override System.Converter<GameObject, Object> converter => DefaultConverters.FromGameObjectToObject;
	}
}
