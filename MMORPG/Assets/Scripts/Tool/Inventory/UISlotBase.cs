using UnityEngine;
using QFramework;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace MMORPG.UI
{
    [RequireComponent(typeof(Toggle))]
	public class UISlotBase : MonoBehaviour
    {
        public Toggle Toggle { get; protected set; }
        public TextMeshProUGUI TextSlotId;
        public UIInventoryBase Inventory { get; protected set; }

        /// <summary>
        /// 槽在容器中的Id(也就是Index)
        /// </summary>
        public int SlotId
        {
            get => _slotId;
            set
            {
                _slotId = value;
                TextSlotId.SetText(_slotId.ToString());
            }
        }

        private int _slotId;

        public void Setup(UIInventoryBase inventory, int slotId)
        {
            Inventory = inventory;
            SlotId = slotId;
        }

        protected virtual void Awake()
        {
            Toggle = this.GetComponent<Toggle>();
        }
	}
}