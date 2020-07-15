// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;
using Object = UnityEngine.Object;

namespace Zor.EventBasedBlackboard.Components.Operators.ObjectObject_Bool
{
	[CustomLabelInfo(null, nameof(Object), 0)]
	[CustomLabelInfo(null, nameof(Object), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Object, Object) => (Bool)/Object Not Equal Operator")]
	public sealed class ObjectNotEqualOperator : SingleReturnBinaryOperator<Object, Object, bool>
	{
		protected override System.Func<Object, Object, bool> operation => DefaultOperators.ObjectNotEqual;
	}
}
