// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolLayerMaskLayerMask_LayerMask
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(LayerMask), 1)]
	[CustomLabelInfo("False", nameof(LayerMask), 2)]
	[CustomLabelInfo(null, nameof(LayerMask), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, LayerMask, LayerMask) => (LayerMask)/LayerMask Conditional Operator")]
	public sealed class LayerMaskConditionalOperator :
		SingleReturnTernaryOperator<bool, LayerMask, LayerMask, LayerMask>
	{
		protected override Func<bool, LayerMask, LayerMask, LayerMask> operation =>
			DefaultOperators.LayerMaskConditional;
	}
}
