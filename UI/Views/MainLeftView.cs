using CP_SDK.XUI;
using UnityEngine;

namespace CP_SDK.UI.Views
{
    /// <summary>
    /// Main left view controller
    /// </summary>
    public sealed class MainLeftView : ViewController<MainLeftView>
    {
        /// <summary>
        /// On view creation
        /// </summary>
        protected override sealed void OnViewCreation()
        {
            Templates.FullRectLayout(
                Templates.TitleBar("Інформація"),

                Templates.ScrollableInfos(50,
                    XUIText.Make($"<b>Ласкаво просимо до {FlowCoordinators.MainFlowCoordinator.Instance().Title}</b>\nЗроблено Laptinius!")
                        .SetAlign(TMPro.TextAlignmentOptions.CaplineLeft)
                ),

                Templates.ExpandedButtonsLine(
                    XUIPrimaryButton.Make("Документація", OnDocumentationButton),
                    XUIPrimaryButton.Make("Твіч", OnTwitchButton)
                ),
                Templates.ExpandedButtonsLine(
                    XUISecondaryButton.Make("Підтримати — Монобейс", OnDonateButton)
                )
            )
            .SetBackground(true, null, true)
            .BuildUI(transform);
        }

        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Documentation button
        /// </summary>
        private void OnDocumentationButton()
        {
            ShowMessageModal("Посилання відкрито у вашому браузері.");
            Application.OpenURL("https://github.com/Laptinius/BeatSaberPlus/wiki");
        }
        /// <summary>
        /// Go to twitch
        /// </summary>
        private void OnTwitchButton()
        {
            ShowMessageModal("Посилання відкрито у вашому браузері.");
            Application.OpenURL("https://www.twitch.tv/calypsopaw");
        }

        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Go to donate
        /// </summary>
        private void OnDonateButton()
        {
            ShowMessageModal("Посилання відкрито у вашому браузері.");
            Application.OpenURL("https://base.monobank.ua/calypsopaw");
        }
    }
}
