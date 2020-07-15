// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2Vector2Rect
{
	[CustomLabelInfo("Position", nameof(Vector2), 0)]
	[CustomLabelInfo("Size", nameof(Vector2), 1)]
	[CustomLabelInfo(null, nameof(Rect), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2, Vector2) => (Rect)/Rect New With Vectors Operator")]
	public sealed class RectNewWithVectorsOperator : SingleReturnBinaryOperator<Vector2, Vector2, Rect>
	{
		protected override Func<Vector2, Vector2, Rect> operation => DefaultOperators.RectNewWithVectors;
	}
}
