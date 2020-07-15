// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Ulong_String
{
	[CustomLabelInfo(null, nameof(UInt64), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ulong) => (String)/Ulong ToString Operator")]
	public sealed class UlongToStringOperator : SingleReturnUnaryOperator<ulong, string>
	{
		protected override Func<ulong, string> operation => DefaultOperators.UlongToString;
	}
}
