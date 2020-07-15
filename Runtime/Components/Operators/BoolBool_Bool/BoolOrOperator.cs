// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolBool_Bool
{
	[CustomLabelInfo(null, nameof(Boolean), 0)]
	[CustomLabelInfo(null, nameof(Boolean), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Bool) => (Bool)/Bool Or Operator")]
	public sealed class BoolOrOperator : SingleReturnBinaryOperator<bool, bool, bool>
	{
		protected override Func<bool, bool, bool> operation => DefaultOperators.BoolOr;
	}
}
