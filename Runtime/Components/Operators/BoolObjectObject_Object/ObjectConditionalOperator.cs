// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;
using Object = UnityEngine.Object;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolObjectObject_Object
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Object), 1)]
	[CustomLabelInfo("False", nameof(Object), 2)]
	[CustomLabelInfo(null, nameof(Object), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Object, Object) => (Object)/Object Conditional Operator")]
	public sealed class ObjectConditionalOperator : SingleReturnTernaryOperator<bool, Object, Object, Object>
	{
		protected override Func<bool, Object, Object, Object> operation => DefaultOperators.ObjectConditional;
	}
}
