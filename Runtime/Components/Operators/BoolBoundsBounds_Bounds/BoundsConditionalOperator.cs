// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolBoundsBounds_Bounds
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Bounds), 1)]
	[CustomLabelInfo("False", nameof(Bounds), 2)]
	[CustomLabelInfo(null, nameof(Bounds), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Bounds, Bounds) => (Bounds)/Bounds Conditional Operator")]
	public sealed class BoundsConditionalOperator : SingleReturnTernaryOperator<bool, Bounds, Bounds, Bounds>
	{
		protected override Func<bool, Bounds, Bounds, Bounds> operation => DefaultOperators.BoundsConditional;
	}
}
