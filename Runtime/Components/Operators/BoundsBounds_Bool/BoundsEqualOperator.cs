// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsBounds_Bool
{
	[CustomLabelInfo(null, nameof(Bounds), 0)]
	[CustomLabelInfo(null, nameof(Bounds), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bounds, Bounds) => (Bool)/Bounds Equal Operator")]
	public sealed class BoundsEqualOperator : SingleReturnBinaryOperator<Bounds, Bounds, bool>
	{
		protected override Func<Bounds, Bounds, bool> operation => DefaultOperators.BoundsEqual;
	}
}
