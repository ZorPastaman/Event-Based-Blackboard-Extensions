// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolLongLong_Long
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Int64), 1)]
	[CustomLabelInfo("False", nameof(Int64), 2)]
	[CustomLabelInfo(null, nameof(Int64), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Long, Long) => (Long)/Long Conditional Operator")]
	public sealed class LongConditionalOperator : SingleReturnTernaryOperator<bool, long, long, long>
	{
		protected override Func<bool, long, long, long> operation => DefaultOperators.LongConditional;
	}
}
