// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolTransformTransform_Transform
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Transform), 1)]
	[CustomLabelInfo("False", nameof(Transform), 2)]
	[CustomLabelInfo(null, nameof(Transform), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Transform, Transform) => (Transform)/Transform Conditional Operator")]
	public sealed class TransformConditionalOperator :
		SingleReturnTernaryOperator<bool, Transform, Transform, Transform>
	{
		protected override Func<bool, Transform, Transform, Transform> operation =>
			DefaultOperators.TransformConditional;
	}
}
