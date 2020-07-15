// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.IntInt_Bool
{
	[CustomLabelInfo("Value", nameof(Int32), 0)]
	[CustomLabelInfo("Mask", nameof(Int32), 1)]
	[CustomLabelInfo("Is Everything In Mask", nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int, Int) => (Bool)/Int Everything Mask Operator")]
	public sealed class IntEverythingMaskOperator : SingleReturnBinaryOperator<int, int, bool>
	{
		protected override Func<int, int, bool> operation => DefaultOperators.IntEverythingMask;
	}
}
