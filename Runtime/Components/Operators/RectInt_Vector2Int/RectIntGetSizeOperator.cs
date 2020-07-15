// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectInt_Vector2Int
{
	[CustomLabelInfo(null, nameof(RectInt), 0)]
	[CustomLabelInfo(null, nameof(Vector2Int), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(RectInt, Vector2Int)/RectInt Get Size Operator")]
	public sealed class RectIntGetSizeOperator : SingleReturnUnaryOperator<RectInt, Vector2Int>
	{
		protected override Func<RectInt, Vector2Int> operation => DefaultOperators.RectIntGetSize;
	}
}
