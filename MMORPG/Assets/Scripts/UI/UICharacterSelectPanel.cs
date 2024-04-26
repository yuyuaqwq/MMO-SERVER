using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UnityEngine.SceneManagement;

namespace MMORPG.UI
{
	public class UICharacterSelectPanelData : UIPanelData
	{
	}
	public partial class UICharacterSelectPanel : UIPanel, IController
    {
        public IArchitecture GetArchitecture()
        {
            return GameApp.Interface;
        }

        protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UICharacterSelectPanelData ?? new UICharacterSelectPanelData();
            // please add init code here

            BtnPlay.onClick.AddListener(() => JoinMapScene(1));
        }
		
		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}


        private void JoinMapScene(int mapId)
        {
            //TODO mapid
            var op = SceneManager.LoadSceneAsync("Space1Scene");
            op.completed += _ =>
            {
                this.GetSystem<IMapManagerSystem>().JoinedMap(mapId);
            };
        }

    }
}