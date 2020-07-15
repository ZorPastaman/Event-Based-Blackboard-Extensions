// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Sbyte_String
{
	[CustomLabelInfo(null, nameof(SByte), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Sbyte) => (String)/Sbyte ToString Operator")]
	public sealed class SbyteToStringOperator : SingleReturnUnaryOperator<sbyte, string>
	{
		protected override Func<sbyte, string> operation => DefaultOperators.SbyteToString;
	}
}
