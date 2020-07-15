// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Char_String
{
	[CustomLabelInfo(null, nameof(Char), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Char) => (String)/Char ToString Operator")]
	public sealed class CharToStringOperator : SingleReturnUnaryOperator<char, string>
	{
		protected override Func<char, string> operation => DefaultOperators.CharToString;
	}
}
