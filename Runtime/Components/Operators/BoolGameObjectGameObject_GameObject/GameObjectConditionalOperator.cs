// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolGameObjectGameObject_GameObject
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(GameObject), 1)]
	[CustomLabelInfo("False", nameof(GameObject), 2)]
	[CustomLabelInfo(null, nameof(GameObject), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, GameObject, GameObject) => (GameObject)/GameObject Conditional Operator")]
	public sealed class GameObjectConditionalOperator :
		SingleReturnTernaryOperator<bool, GameObject, GameObject, GameObject>
	{
		protected override Func<bool, GameObject, GameObject, GameObject> operation =>
			DefaultOperators.GameObjectConditional;
	}
}
