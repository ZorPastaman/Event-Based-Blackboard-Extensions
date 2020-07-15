// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Bool_String
{
	[CustomLabelInfo(null, nameof(Boolean), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool) => (String)/Bool ToString Operator")]
	public sealed class BoolToStringOperator : SingleReturnUnaryOperator<bool, string>
	{
		protected override Func<bool, string> operation => DefaultOperators.BoolToString;
	}
}
