// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.GameObject_GameObject
{
	[CustomLabelInfo(null, nameof(GameObject), 0)]
	[CustomLabelInfo(null, nameof(GameObject), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(GameObject) => (GameObject)/GameObject Instantiate Operator")]
	public sealed class GameObjectInstantiateOperator : SingleReturnUnaryOperator<GameObject, GameObject>
	{
		protected override Func<GameObject, GameObject> operation => DefaultOperators.GameObjectInstantiate;
	}
}
