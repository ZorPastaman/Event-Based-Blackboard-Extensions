// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolCharChar_Char
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Char), 1)]
	[CustomLabelInfo("False", nameof(Char), 2)]
	[CustomLabelInfo(null, nameof(Char), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Char, Char) => (Char)/Char Conditional Operator")]
	public sealed class CharConditionalOperator : SingleReturnTernaryOperator<bool, char, char, char>
	{
		protected override Func<bool, char, char, char> operation => DefaultOperators.CharConditional;
	}
}
