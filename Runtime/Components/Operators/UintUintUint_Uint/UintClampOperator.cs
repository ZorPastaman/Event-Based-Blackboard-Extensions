// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UintUintUint_Uint
{
	[CustomLabelInfo("Value", nameof(UInt32), 0)]
	[CustomLabelInfo("Min", nameof(UInt32), 1)]
	[CustomLabelInfo("Max", nameof(UInt32), 2)]
	[CustomLabelInfo(null, nameof(UInt32), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Uint, Uint, Uint) => (Uint)/Uint Clamp Operator")]
	public sealed class UintClampOperator : SingleReturnTernaryOperator<uint, uint, uint, uint>
	{
		protected override Func<uint, uint, uint, uint> operation => DefaultOperators.UintClamp;
	}
}
