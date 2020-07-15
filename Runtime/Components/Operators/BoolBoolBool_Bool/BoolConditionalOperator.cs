// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolBoolBool_Bool
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Boolean), 1)]
	[CustomLabelInfo("False", nameof(Boolean), 2)]
	[CustomLabelInfo(null, nameof(Boolean), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Bool, Bool) => (Bool)/Bool Conditional Operator")]
	public sealed class BoolConditionalOperator : SingleReturnTernaryOperator<bool, bool, bool, bool>
	{
		protected override Func<bool, bool, bool, bool> operation => DefaultOperators.BoolConditional;
	}
}
