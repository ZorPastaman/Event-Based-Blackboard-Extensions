// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolStringString_String
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(String), 1)]
	[CustomLabelInfo("False", nameof(String), 2)]
	[CustomLabelInfo(null, nameof(String), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, String, String) => (String)/String Conditional Operator")]
	public sealed class StringConditionalOperator : SingleReturnTernaryOperator<bool, string, string, string>
	{
		protected override Func<bool, string, string, string> operation => DefaultOperators.StringConditional;
	}
}
