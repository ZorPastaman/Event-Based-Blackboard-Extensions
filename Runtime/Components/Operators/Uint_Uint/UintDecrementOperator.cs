// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Uint_Uint
{
	[CustomLabelInfo(null, nameof(UInt32), 0)]
	[CustomLabelInfo(null, nameof(UInt32), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Uint) => (Uint)/Uint Decrement Operator")]
	public sealed class UintDecrementOperator : SingleReturnUnaryOperator<uint, uint>
	{
		protected override Func<uint, uint> operation => DefaultOperators.UintDecrement;
	}
}
