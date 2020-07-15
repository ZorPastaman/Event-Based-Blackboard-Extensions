// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.IntInt_Bool
{
	[CustomLabelInfo("Value", nameof(Int32), 0)]
	[CustomLabelInfo("Mask", nameof(Int32), 1)]
	[CustomLabelInfo("Is Anything In Mask", nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int, Int) => (Bool)/Int Anything Mask Operator")]
	public sealed class IntAnythingMaskOperator : SingleReturnBinaryOperator<int, int, bool>
	{
		protected override Func<int, int, bool> operation => DefaultOperators.IntAnythingMask;
	}
}
