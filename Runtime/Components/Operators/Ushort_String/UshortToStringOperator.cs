// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Ushort_String
{
	[CustomLabelInfo(null, nameof(UInt16), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ushort) => (String)/Ushort ToString Operator")]
	public sealed class UshortToStringOperator : SingleReturnUnaryOperator<ushort, string>
	{
		protected override Func<ushort, string> operation => DefaultOperators.UshortToString;
	}
}
