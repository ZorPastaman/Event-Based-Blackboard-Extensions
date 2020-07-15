// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolRectIntRectInt_RectInt
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(RectInt), 1)]
	[CustomLabelInfo("False", nameof(RectInt), 2)]
	[CustomLabelInfo(null, nameof(RectInt), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, RectInt, RectInt) => (RectInt)/RectInt Conditional Operator")]
	public sealed class RectIntConditionalOperator : SingleReturnTernaryOperator<bool, RectInt, RectInt, RectInt>
	{
		protected override Func<bool, RectInt, RectInt, RectInt> operation => DefaultOperators.RectIntConditional;
	}
}
