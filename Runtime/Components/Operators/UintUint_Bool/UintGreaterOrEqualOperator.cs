// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UintUint_Bool
{
	[CustomLabelInfo(null, nameof(UInt32), 0)]
	[CustomLabelInfo(null, nameof(UInt32), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Uint, Uint) => (Bool)/Uint Greater Or Equal Operator")]
	public sealed class UintGreaterOrEqualOperator : SingleReturnBinaryOperator<uint, uint, bool>
	{
		protected override Func<uint, uint, bool> operation => DefaultOperators.UintGreaterOrEqual;
	}
}
