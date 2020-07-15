// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectIntVector2Int_RectInt
{
	[CustomLabelInfo(null, nameof(RectInt), 0)]
	[CustomLabelInfo(null, nameof(Vector2Int), 1)]
	[CustomLabelInfo(null, nameof(RectInt), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(RectInt, Vector2Int) => (RectInt)/RectInt Set Max Operator")]
	public sealed class RectIntSetMaxOperator : SingleReturnBinaryOperator<RectInt, Vector2Int, RectInt>
	{
		protected override Func<RectInt, Vector2Int, RectInt> operation => DefaultOperators.RectIntSetMax;
	}
}
