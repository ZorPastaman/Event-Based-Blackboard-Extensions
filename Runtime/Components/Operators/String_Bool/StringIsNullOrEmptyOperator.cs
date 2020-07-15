// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.String_Bool
{
	[CustomLabelInfo(null, nameof(String), 0)]
	[CustomLabelInfo(null, nameof(Boolean), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(String) => (Bool)/String Is Null Or Empty Operator")]
	public sealed class StringIsNullOrEmptyOperator : SingleReturnUnaryOperator<string, bool>
	{
		protected override Func<string, bool> operation => DefaultOperators.StringIsNullOrEmpty;
	}
}
