// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsIntBoundsInt_BoundsInt
{
	[CustomLabelInfo("Value", nameof(BoundsInt), 0)]
	[CustomLabelInfo("Bounds", nameof(BoundsInt), 1)]
	[CustomLabelInfo(null, nameof(BoundsInt), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(BoundsInt, BoundsInt) => (BoundsInt)/Bounds Int Clamp To Bounds Operator")]
	public sealed class BoundsIntClampToBoundsOperator : SingleReturnBinaryOperator<BoundsInt, BoundsInt, BoundsInt>
	{
		protected override Func<BoundsInt, BoundsInt, BoundsInt> operation => DefaultOperators.BoundsIntClampToBounds;
	}
}
