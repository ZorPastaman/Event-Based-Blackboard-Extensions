// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolVector2Vector2_Vector2
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Vector2), 1)]
	[CustomLabelInfo("False", nameof(Vector2), 2)]
	[CustomLabelInfo(null, nameof(Vector2), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Vector2, Vector2) => (Vector2)/Vector2 Conditional Operator")]
	public sealed class Vector2ConditionalOperator : SingleReturnTernaryOperator<bool, Vector2, Vector2, Vector2>
	{
		protected override Func<bool, Vector2, Vector2, Vector2> operation => DefaultOperators.Vector2Conditional;
	}
}
