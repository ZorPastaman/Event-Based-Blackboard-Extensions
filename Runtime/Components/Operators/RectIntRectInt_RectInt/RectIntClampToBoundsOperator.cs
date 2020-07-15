// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectIntRectInt_RectInt
{
	[CustomLabelInfo(null, nameof(RectInt), 0)]
	[CustomLabelInfo("Bounds", nameof(RectInt), 1)]
	[CustomLabelInfo(null, nameof(RectInt), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(RectInt, RectInt) => (RectInt)/RectInt Clamp To Bounds Operator")]
	public sealed class RectIntClampToBoundsOperator : SingleReturnBinaryOperator<RectInt, RectInt, RectInt>
	{
		protected override Func<RectInt, RectInt, RectInt> operation => DefaultOperators.RectIntClampToBounds;
	}
}
