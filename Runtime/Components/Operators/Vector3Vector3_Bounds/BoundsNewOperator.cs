// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3Vector3_Bounds
{
	[CustomLabelInfo("Center", nameof(Vector3), 0)]
	[CustomLabelInfo("Size", nameof(Vector3), 1)]
	[CustomLabelInfo(null, nameof(Bounds), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3, Vector3) => (Bounds)/Bounds New Operator")]
	public sealed class BoundsNewOperator : SingleReturnBinaryOperator<Vector3, Vector3, Bounds>
	{
		protected override Func<Vector3, Vector3, Bounds> operation => DefaultOperators.BoundsNew;
	}
}
