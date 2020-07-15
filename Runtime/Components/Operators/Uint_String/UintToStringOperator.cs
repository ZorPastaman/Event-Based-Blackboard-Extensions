// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Uint_String
{
	[CustomLabelInfo(null, nameof(UInt32), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Uint) => (String)/Uint ToString Operator")]
	public sealed class UintToStringOperator : SingleReturnUnaryOperator<uint, string>
	{
		protected override Func<uint, string> operation => DefaultOperators.UintToString;
	}
}
