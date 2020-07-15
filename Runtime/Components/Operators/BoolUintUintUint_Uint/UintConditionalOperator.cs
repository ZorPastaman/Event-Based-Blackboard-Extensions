// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolUintUint_Uint
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(UInt32), 1)]
	[CustomLabelInfo("False", nameof(UInt32), 2)]
	[CustomLabelInfo(null, nameof(UInt32), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Uint, Uint) => (Uint)/Uint Conditional Operator")]
	public sealed class UintConditionalOperator : SingleReturnTernaryOperator<bool, uint, uint, uint>
	{
		protected override Func<bool, uint, uint, uint> operation => DefaultOperators.UintConditional;
	}
}
