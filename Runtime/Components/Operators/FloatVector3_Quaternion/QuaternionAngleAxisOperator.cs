// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatVector3_Quaternion
{
	[CustomLabelInfo("Angle", nameof(Single), 0)]
	[CustomLabelInfo("Axis", nameof(Vector3), 1)]
	[CustomLabelInfo(null, nameof(Quaternion), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Vector3) => (Quaternion)/Quaternion Angle Axis Operator")]
	public sealed class QuaternionAngleAxisOperator : SingleReturnBinaryOperator<float, Vector3, Quaternion>
	{
		protected override Func<float, Vector3, Quaternion> operation => DefaultOperators.QuaternionAngleAxis;
	}
}
