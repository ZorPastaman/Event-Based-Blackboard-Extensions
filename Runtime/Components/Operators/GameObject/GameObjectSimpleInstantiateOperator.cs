// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.GameObjectOperators
{
	[CustomLabelInfo(null, nameof(GameObject), 0)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(GameObject) => (Void)/GameObject Simple Instantiate Operator")]
	public sealed class GameObjectSimpleInstantiateOperator : NoReturnUnaryOperator<GameObject>
	{
		protected override Action<GameObject> operation => DefaultOperators.GameObjectSimpleInstantiate;
	}
}
