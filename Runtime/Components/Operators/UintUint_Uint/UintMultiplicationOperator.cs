// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UintUint_Uint
{
	[CustomLabelInfo(null, nameof(UInt32), 0)]
	[CustomLabelInfo(null, nameof(UInt32), 1)]
	[CustomLabelInfo(null, nameof(UInt32), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Uint, Uint) => (Uint)/Uint Multiplication Operator")]
	public sealed class UintMultiplicationOperator : SingleReturnBinaryOperator<uint, uint, uint>
	{
		protected override Func<uint, uint, uint> operation => DefaultOperators.UintMultiplication;
	}
}
