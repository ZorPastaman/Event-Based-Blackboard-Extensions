// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolComponentComponent_Component
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Component), 1)]
	[CustomLabelInfo("False", nameof(Component), 2)]
	[CustomLabelInfo(null, nameof(Component), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Component, Component) => (Component)/Component Conditional Operator")]
	public sealed class ComponentConditionalOperator :
		SingleReturnTernaryOperator<bool, Component, Component, Component>
	{
		protected override Func<bool, Component, Component, Component> operation =>
			DefaultOperators.ComponentConditional;
	}
}
