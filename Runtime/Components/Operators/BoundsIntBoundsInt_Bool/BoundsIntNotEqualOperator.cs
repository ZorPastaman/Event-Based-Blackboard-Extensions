// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsIntBoundsInt_Bool
{
	[CustomLabelInfo(null, nameof(BoundsInt), 0)]
	[CustomLabelInfo(null, nameof(BoundsInt), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(BoundsInt, BoundsInt) => (Bool)/Bounds Int Not Equal Operator")]
	public sealed class BoundsIntNotEqualOperator : SingleReturnBinaryOperator<BoundsInt, BoundsInt, bool>
	{
		protected override Func<BoundsInt, BoundsInt, bool> operation => DefaultOperators.BoundIntNotEqual;
	}
}
