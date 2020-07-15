// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Sbyte_Sbyte
{
	[CustomLabelInfo(null, nameof(SByte), 0)]
	[CustomLabelInfo(null, nameof(SByte), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Sbyte) => (Sbyte)/Sbyte Increment Operator")]
	public sealed class SbyteIncrementOperator : SingleReturnUnaryOperator<sbyte, sbyte>
	{
		protected override Func<sbyte, sbyte> operation => DefaultOperators.SbyteIncrement;
	}
}
