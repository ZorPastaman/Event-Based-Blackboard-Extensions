// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolVector2IntVector2Int_Vector2Int
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Vector2Int), 1)]
	[CustomLabelInfo("False", nameof(Vector2Int), 2)]
	[CustomLabelInfo(null, nameof(Vector2Int), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Vector2Int, Vector2Int) => (Vector2Int)/Vector2Int Conditional Operator")]
	public sealed class Vector2IntConditionalOperator :
		SingleReturnTernaryOperator<bool, Vector2Int, Vector2Int, Vector2Int>
	{
		protected override Func<bool, Vector2Int, Vector2Int, Vector2Int> operation =>
			DefaultOperators.Vector2IntConditional;
	}
}
