// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolAnimationCurveAnimationCurve_AnimationCurve
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(AnimationCurve), 1)]
	[CustomLabelInfo("False", nameof(AnimationCurve), 2)]
	[CustomLabelInfo(null, nameof(AnimationCurve), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, AnimationCurve, AnimationCurve) => (AnimationCurve)/Animation Curve Conditional Operator")]
	public sealed class AnimationCurveConditional :
		SingleReturnTernaryOperator<bool, AnimationCurve, AnimationCurve, AnimationCurve>
	{
		protected override Func<bool, AnimationCurve, AnimationCurve, AnimationCurve> operation =>
			DefaultOperators.AnimationCurveConditional;
	}
}
