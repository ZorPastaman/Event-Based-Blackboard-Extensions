// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectVector2_Vector2
{
	[CustomLabelInfo(null, nameof(Rect), 0)]
	[CustomLabelInfo(null, nameof(Vector2), 1)]
	[CustomLabelInfo(null, nameof(Vector2), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Rect, Vector2) => (Vector2)/Rect Normalized To Point Operator")]
	public sealed class RectPointToNormalizedOperator : SingleReturnBinaryOperator<Rect, Vector2, Vector2>
	{
		protected override Func<Rect, Vector2, Vector2> operation => DefaultOperators.RectPointToNormalized;
	}
}
