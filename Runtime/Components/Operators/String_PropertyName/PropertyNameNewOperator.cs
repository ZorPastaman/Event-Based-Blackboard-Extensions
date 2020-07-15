// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.String_PropertyName
{
	[CustomLabelInfo(null, nameof(String), 0)]
	[CustomLabelInfo(null, nameof(PropertyName), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(String) => (PropertyName)/Property Name New Operator")]
	public sealed class PropertyNameNewOperator : SingleReturnUnaryOperator<string, PropertyName>
	{
		protected override Func<string, PropertyName> operation => DefaultOperators.PropertyNameNew;
	}
}
