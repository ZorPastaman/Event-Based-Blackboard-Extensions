// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.StringString_String
{
	[CustomLabelInfo(null, nameof(String), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[CustomLabelInfo(null, nameof(String), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(String, String) => (String)/String Concat Operator")]
	public sealed class StringConcatOperator : SingleReturnBinaryOperator<string, string, string>
	{
		protected override Func<string, string, string> operation => DefaultOperators.StringConcat;
	}
}
