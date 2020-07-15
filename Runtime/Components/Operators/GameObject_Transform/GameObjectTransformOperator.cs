// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.GameObject_Transform
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(GameObject) => (Transform)/GameObject Transform Operator")]
	public sealed class GameObjectTransformOperator : SingleReturnUnaryOperator<GameObject, Transform>
	{
		protected override Func<GameObject, Transform> operation => DefaultOperators.GameObjectTransform;
	}
}
