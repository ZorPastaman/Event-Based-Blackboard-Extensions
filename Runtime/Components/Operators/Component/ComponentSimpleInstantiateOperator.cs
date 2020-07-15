// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.ComponentOperators
{
	[CustomLabelInfo(null, nameof(Component), 0)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Component) => (Void)/Component Simple Instantiate Operator")]
	public sealed class ComponentSimpleInstantiateOperator : NoReturnUnaryOperator<Component>
	{
		protected override Action<Component> operation => DefaultOperators.ComponentSimpleInstantiate;
	}
}
