// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.SbyteSbyte_Sbyte
{
	[CustomLabelInfo(null, nameof(SByte), 0)]
	[CustomLabelInfo(null, nameof(SByte), 1)]
	[CustomLabelInfo(null, nameof(SByte), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Sbyte, Sbyte) => (Sbyte)/Sbyte Min Operator")]
	public sealed class SbyteMinOperator : SingleReturnBinaryOperator<sbyte, sbyte, sbyte>
	{
		protected override Func<sbyte, sbyte, sbyte> operation => DefaultOperators.SbyteMin;
	}
}
