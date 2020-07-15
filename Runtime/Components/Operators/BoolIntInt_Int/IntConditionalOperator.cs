// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolIntInt_Int
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Int32), 1)]
	[CustomLabelInfo("False", nameof(Int32), 2)]
	[CustomLabelInfo(null, nameof(Int32), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Int, Int) => (Int)/Int Conditional Operator")]
	public sealed class IntConditionalOperator : SingleReturnTernaryOperator<bool, int, int, int>
	{
		protected override Func<bool, int, int, int> operation => DefaultOperators.IntConditional;
	}
}
