// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2Vector2_Vector2
{
	[CustomLabelInfo(null, nameof(Vector2), 0)]
	[CustomLabelInfo(null, nameof(Vector2), 1)]
	[CustomLabelInfo(null, nameof(Vector2), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2, Vector2) => (Vector2)/Vector2 Subtraction Operator")]
	public sealed class Vector2SubtractionOperator : SingleReturnBinaryOperator<Vector2, Vector2, Vector2>
	{
		protected override Func<Vector2, Vector2, Vector2> operation => DefaultOperators.Vector2Subtraction;
	}
}
