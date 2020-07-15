// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.GradientFloat_Color
{
	[CustomLabelInfo(null, nameof(Gradient), 0)]
	[CustomLabelInfo("Time", nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Color), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Gradient, Float) => (Color)/Gradient Evaluate Operator")]
	public sealed class GradientEvaluateOperator : SingleReturnBinaryOperator<Gradient, float, Color>
	{
		protected override Func<Gradient, float, Color> operation => DefaultOperators.GradientEvaluate;
	}
}
