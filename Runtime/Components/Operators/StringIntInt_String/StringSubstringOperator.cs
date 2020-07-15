// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.StringIntInt_String
{
	[CustomLabelInfo("Value", nameof(String), 0)]
	[CustomLabelInfo("Start", nameof(Int32), 1)]
	[CustomLabelInfo("Length", nameof(Int32), 2)]
	[CustomLabelInfo(null, nameof(String), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(String, Int, Int) => (String)/String Substring Operator")]
	public sealed class StringSubstringOperator : SingleReturnTernaryOperator<string, int, int, string>
	{
		protected override Func<string, int, int, string> operation => DefaultOperators.StringSubstring;
	}
}
