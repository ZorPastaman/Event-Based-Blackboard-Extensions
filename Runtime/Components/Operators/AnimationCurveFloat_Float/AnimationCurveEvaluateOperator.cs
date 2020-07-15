// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.AnimationCurveFloat_Float
{
	[CustomLabelInfo("Curve", nameof(AnimationCurve), 0)]
	[CustomLabelInfo("Time", nameof(Single), 1)]
	[CustomLabelInfo("Value", nameof(Single), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(AnimationCurve, Float) => (Float)/Animation Curve Evaluate Operator")]
	public sealed class AnimationCurveEvaluateOperator : SingleReturnBinaryOperator<AnimationCurve, float, float>
	{
		protected override Func<AnimationCurve, float, float> operation => DefaultOperators.AnimationCurveEvaluate;
	}
}
