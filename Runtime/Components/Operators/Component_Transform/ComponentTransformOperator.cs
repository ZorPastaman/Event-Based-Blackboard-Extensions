// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Component_Transform
{
	[CustomLabelInfo(null, nameof(Component), 0)]
	[CustomLabelInfo(null, nameof(Transform), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Component) => (Transform)/Component Transform Operator")]
	public sealed class ComponentTransformOperator : SingleReturnUnaryOperator<Component, Transform>
	{
		protected override Func<Component, Transform> operation => DefaultOperators.ComponentTransform;
	}
}
