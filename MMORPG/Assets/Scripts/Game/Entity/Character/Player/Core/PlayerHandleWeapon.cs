using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MMORPG.Game
{
    public enum HandleWeaponMode
    {
        LeftHand,
        RightHand
    }

    public class PlayerHandleWeapon : MonoBehaviour
    {
        [Title("Weapon")]
        public Weapon InitialWeapon;

        [ReadOnly]
        [ShowInInspector]
        public Weapon CurrentWeapon { get; private set; }
        [Title("Binding")]
        public Transform WeaponAttachment;
        public HandleWeaponMode HandleMode = HandleWeaponMode.RightHand;
        public Transform LeftHandTarget;
        public Transform RightHandTarget;

        public delegate void WeaponChangedHandler(Weapon current, Weapon previous);
        public event WeaponChangedHandler OnWeaponChanged;

        public PlayerBrain Brain { get; private set; }

        [Button]
        private void UpdateWeaponAttachmentTransform()
        {
            if (WeaponAttachment)
            {
                switch (HandleMode)
                {
                    case HandleWeaponMode.LeftHand:
                        if (LeftHandTarget)
                            WeaponAttachment.SetPositionAndRotation(LeftHandTarget.position, LeftHandTarget.rotation);
                        break;
                    default:
                        if (RightHandTarget)
                            WeaponAttachment.SetPositionAndRotation(RightHandTarget.position, RightHandTarget.rotation);
                        break;
                }
            }
        }

        private void Start()
        {
            if (Brain.IsMine)
            {
                Brain.InputControls.Player.Fire.started += OnFireStarted;
            }
            if (InitialWeapon)
            {
                ChangeWeapon(InitialWeapon);
            }
        }

        private void Update()
        {
            UpdateWeaponAttachmentTransform();

            Debug.Log(CurrentWeapon?.StartAnimationParam);
        }

        public void Setup(PlayerBrain brain)
        {
            Brain = brain;
        }

        public void ChangeWeapon(Weapon newWeapon, bool combo = false)
        {
            if (CurrentWeapon)
            {
                CurrentWeapon.TurnWeaponOff();
                if (!combo)
                {
                    //TODO 销毁武器
                }
            }

            var tmp = CurrentWeapon;
            if (newWeapon != null)
            {
                InstantiateWeapon(newWeapon, combo);
            }
            else
            {
                CurrentWeapon = null;
            }
            OnWeaponChanged?.Invoke(newWeapon, tmp);
        }

        public void ShootStart()
        {
            CurrentWeapon.WeaponInputStart();
        }

        public void ShootStop()
        {
            CurrentWeapon.WeaponInputStop();
        }

        private void InstantiateWeapon(Weapon newWeapon, bool combo)
        {
            if (!combo)
            {
                CurrentWeapon = Instantiate(newWeapon,
                    WeaponAttachment.transform.position + newWeapon.WeaponAttachmentOffset,
                    WeaponAttachment.transform.rotation);
            }
            else
            {
                CurrentWeapon = newWeapon;
            }
            CurrentWeapon.transform.parent = WeaponAttachment.transform;
            CurrentWeapon.transform.localPosition = newWeapon.WeaponAttachmentOffset;
            CurrentWeapon.Setup(Brain);
            CurrentWeapon.Initialize();
        }

        private void OnFireStarted(InputAction.CallbackContext obj)
        {
            if (CurrentWeapon.FSM.CurrentStateId is Weapon.WeaponStates.Idle)
            {
                CurrentWeapon.WeaponInputStart();
            }
        }
    }
}