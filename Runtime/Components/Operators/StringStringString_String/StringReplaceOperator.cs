// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.StringStringString_String
{
	[CustomLabelInfo(null, nameof(String), 0)]
	[CustomLabelInfo("Old Value", nameof(String), 1)]
	[CustomLabelInfo("New Value", nameof(String), 2)]
	[CustomLabelInfo(null, nameof(String), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(String, String, String) => (String)/String Replace Operator")]
	public sealed class StringReplaceOperator : SingleReturnTernaryOperator<string, string, string, string>
	{
		protected override Func<string, string, string, string> operation => DefaultOperators.StringReplace;
	}
}
