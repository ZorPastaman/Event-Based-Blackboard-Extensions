// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolShortShort_Short
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Int16), 1)]
	[CustomLabelInfo("False", nameof(Int16), 2)]
	[CustomLabelInfo(null, nameof(Int16), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Short, Short) => (Short)/Short Conditional Operator")]
	public sealed class ShortConditionalOperator : SingleReturnTernaryOperator<bool, short, short, short>
	{
		protected override Func<bool, short, short, short> operation => DefaultOperators.ShortConditional;
	}
}
