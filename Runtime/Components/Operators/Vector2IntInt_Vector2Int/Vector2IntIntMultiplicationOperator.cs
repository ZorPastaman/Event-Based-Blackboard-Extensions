// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2IntInt_Vector2Int
{
	[CustomLabelInfo(null, nameof(Vector2Int), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[CustomLabelInfo(null, nameof(Vector2Int), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2Int, Int) => (Vector2Int)/Vector2Int Int Multiplication Operator")]
	public sealed class Vector2IntIntMultiplicationOperator : SingleReturnBinaryOperator<Vector2Int, int, Vector2Int>
	{
		protected override Func<Vector2Int, int, Vector2Int> operation => DefaultOperators.Vector2IntIntMultiplication;
	}
}
