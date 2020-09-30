// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System.Runtime.CompilerServices;
using JetBrains.Annotations;
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

		[NotNull]
		public Animator animator
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_Animator;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_Animator = value;
		}

		[NotNull]
		public string animatorPropertyName
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_AnimatorPropertyName;
			set
			{
				if (m_AnimatorPropertyName == value)
				{
					return;
				}

				m_AnimatorPropertyName = value;
				m_initialized = false;
			}
		}

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

		[MethodImpl(MethodImplOptions.AggressiveInlining), Preserve]
		public void SetBool(bool value)
		{
			m_Animator.SetBool(propertyId, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining), Preserve]
		public void SetInt(int value)
		{
			m_Animator.SetInteger(propertyId, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining), Preserve]
		public void SetFloat(float value)
		{
			m_Animator.SetFloat(propertyId, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining), Preserve]
		public void SetTrigger()
		{
			m_Animator.SetTrigger(propertyId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining), Preserve]
		public void ResetTrigger()
		{
			m_Animator.ResetTrigger(propertyId);
		}
	}
}
