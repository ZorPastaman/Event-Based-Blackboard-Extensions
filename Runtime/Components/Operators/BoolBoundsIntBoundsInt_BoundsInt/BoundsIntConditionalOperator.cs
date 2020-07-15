// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolBoundsIntBoundsInt_BoundsInt
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(BoundsInt), 1)]
	[CustomLabelInfo("False", nameof(BoundsInt), 2)]
	[CustomLabelInfo(null, nameof(BoundsInt), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, BoundsInt, BoundsInt) => (BoundsInt)/BoundsInt Conditional Operator")]
	public sealed class BoundsIntConditional : SingleReturnTernaryOperator<bool, BoundsInt, BoundsInt, BoundsInt>
	{
		protected override Func<bool, BoundsInt, BoundsInt, BoundsInt> operation =>
			DefaultOperators.BoundsIntConditional;
	}
}
