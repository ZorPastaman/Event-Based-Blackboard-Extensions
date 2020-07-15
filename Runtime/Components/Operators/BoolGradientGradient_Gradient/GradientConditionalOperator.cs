// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolGradientGradient_Gradient
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Gradient), 1)]
	[CustomLabelInfo("False", nameof(Gradient), 2)]
	[CustomLabelInfo(null, nameof(Gradient), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Gradient, Gradient) => (Gradient)/Gradient Conditional Operator")]
	public sealed class GradientConditionalOperator : SingleReturnTernaryOperator<bool, Gradient, Gradient, Gradient>
	{
		protected override Func<bool, Gradient, Gradient, Gradient> operation => DefaultOperators.GradientConditional;
	}
}
