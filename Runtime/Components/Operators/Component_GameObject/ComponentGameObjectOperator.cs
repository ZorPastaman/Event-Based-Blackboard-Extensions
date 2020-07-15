// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Component_Transform
{
	[CustomLabelInfo(null, nameof(Component), 0)]
	[CustomLabelInfo(null, nameof(GameObject), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Component) => (GameObject)/Component GameObject Operator")]
	public sealed class ComponentGameObjectOperator : SingleReturnUnaryOperator<Component, GameObject>
	{
		protected override Func<Component, GameObject> operation => DefaultOperators.ComponentGameObject;
	}
}
