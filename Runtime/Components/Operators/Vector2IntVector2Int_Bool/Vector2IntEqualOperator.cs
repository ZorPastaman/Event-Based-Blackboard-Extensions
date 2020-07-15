// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2IntVector2Int_Bool
{
	[CustomLabelInfo(null, nameof(Vector2Int), 0)]
	[CustomLabelInfo(null, nameof(Vector2Int), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2Int, Vector2Int) => (Bool)/Vector2Int Equal Operator")]
	public sealed class Vector2IntEqualOperator : SingleReturnBinaryOperator<Vector2Int, Vector2Int, bool>
	{
		protected override Func<Vector2Int, Vector2Int, bool> operation => DefaultOperators.Vector2IntEqual;
	}
}
