// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloat_Vector2
{
	[CustomLabelInfo("X", nameof(Single), 0)]
	[CustomLabelInfo("Y", nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Vector2), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float) => (Vector2)/Vector2 New Operator")]
	public sealed class Vector2NewOperator : SingleReturnBinaryOperator<float, float, Vector2>
	{
		protected override Func<float, float, Vector2> operation => DefaultOperators.Vector2New;
	}
}
