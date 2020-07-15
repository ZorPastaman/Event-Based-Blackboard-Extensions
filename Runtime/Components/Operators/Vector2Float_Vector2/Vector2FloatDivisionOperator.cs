// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2Float_Vector2
{
	[CustomLabelInfo(null, nameof(Vector2), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Vector2), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2, Float) => (Vector2)/Vector2 Float Division Operator")]
	public sealed class Vector2FloatDivisionOperator : SingleReturnBinaryOperator<Vector2, float, Vector2>
	{
		protected override Func<Vector2, float, Vector2> operation => DefaultOperators.Vector2FloatDivision;
	}
}
