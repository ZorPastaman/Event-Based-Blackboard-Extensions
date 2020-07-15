// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using UnityEngine.Scripting;

namespace Zor.EventBasedBlackboard.Components.Applicators
{
	/// <summary>
	/// <para>Applicator for <see cref="Animator"/>.</para>
	/// <para>It contains main set methods and make it easy to set values into an <see cref="Animator"/>.</para>
	/// </summary>
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ApplicatorsFolder + "Animator Applicator")]
	public sealed class AnimatorApplicator : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField] private Animator m_Animator;
		[SerializeField] private string m_AnimatorPropertyName;
#pragma warning restore CS0649

		private int m_propertyId;
		private bool m_initialized;

		private int propertyId
		{
			get
			{
				if (!m_initialized)
				{
					m_propertyId = Animator.StringToHash(m_AnimatorPropertyName);
					m_initialized = true;
				}

				return m_propertyId;
			}
		}

		[Preserve]
		public void SetBool(bool value)
		{
			m_Animator.SetBool(propertyId, value);
		}

		[Preserve]
		public void SetInt(int value)
		{
			m_Animator.SetInteger(propertyId, value);
		}

		[Preserve]
		public void SetFloat(float value)
		{
			m_Animator.SetFloat(propertyId, value);
		}

		[Preserve]
		public void SetTrigger()
		{
			m_Animator.SetTrigger(propertyId);
		}

		[Preserve]
		public void ResetTrigger()
		{
			m_Animator.ResetTrigger(propertyId);
		}
	}
}
