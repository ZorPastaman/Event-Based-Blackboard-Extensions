// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.CharChar_Bool
{
	[CustomLabelInfo(null, nameof(Char), 0)]
	[CustomLabelInfo(null, nameof(Char), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Char, Char) => (Bool)/Char Equal Operator")]
	public sealed class CharEqualOperator : SingleReturnBinaryOperator<char, char, bool>
	{
		protected override Func<char, char, bool> operation => DefaultOperators.CharEqual;
	}
}
