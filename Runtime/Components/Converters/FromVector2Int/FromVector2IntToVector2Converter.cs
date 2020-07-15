// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector2Int
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector2 Int/From Vector2 Int To Vector2 Converter")]
	public sealed class FromVector2IntToVector2Converter : Converter<Vector2Int, Vector2>
	{
		protected override System.Converter<Vector2Int, Vector2> converter => DefaultConverters.FromVector2IntToVector2;
	}
}
