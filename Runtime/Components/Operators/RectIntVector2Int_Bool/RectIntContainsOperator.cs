// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectIntVector2Int_Bool
{
	[CustomLabelInfo(null, nameof(RectInt), 0)]
	[CustomLabelInfo(null, nameof(Vector2Int), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(RectInt, Vector2Int) => (Bool)/RectInt Contains Operator")]
	public sealed class RectIntContainsOperator : SingleReturnBinaryOperator<RectInt, Vector2Int, bool>
	{
		protected override Func<RectInt, Vector2Int, bool> operation => DefaultOperators.RectIntContains;
	}
}
