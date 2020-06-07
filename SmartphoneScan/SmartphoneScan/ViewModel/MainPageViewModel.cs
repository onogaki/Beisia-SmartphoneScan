using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SmartphoneScan.Models;
using SmartphoneScan.Views;

namespace SmartphoneScan.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        /// <summary>
        /// ハンバーガーメニューで選択したページ(NavigationPage)を格納する変数
        /// </summary>
        public Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="navi"></param>
        public MainPageViewModel(NavigationPage navi)
        {
            // 最初に表示するページを設定
            navi = NavigationColorSetting(navi);
            MenuPages.Add((int)MenuPageType.StartPage, navi);
        }

        /// <summary>
        /// 画面遷移するページ(NavigationPage)の取得
        /// </summary>
        /// <param name="PageType"></param>
        /// <returns></returns>
        public NavigationPage NavigationSetting(int PageType)
        {
            if (!MenuPages.ContainsKey(PageType))
            {
                NavigationPage navi = new NavigationPage();
                switch (PageType)
                {
                    case (int)MenuPageType.StartPage:
                        navi = new NavigationPage(new ShoppingStartPage());
                          break;
                    case (int)MenuPageType.Cart:
                        navi = new NavigationPage(new ShoppingCartPage());
                        break;
                    case (int)MenuPageType.Transfer:
                        navi = new NavigationPage(new ShoppingTransferPage());
                        break;
                }

                navi = NavigationColorSetting(navi);
                MenuPages.Add(PageType, navi);
            }

            return MenuPages[PageType];
        }

        /// <summary>
        /// 各ページのナビゲーションの背景＆テキストの色を設定
        /// </summary>
        /// <param name="navi"></param>
        /// <returns></returns>
        private NavigationPage NavigationColorSetting(NavigationPage navi)
        {
            // ナビゲーションの背景色
            navi.BarBackgroundColor = Color.White;
            // テキストの色&ハンバーガーメニューのアイコンの色
            navi.BarTextColor = Color.Red;
            
            return navi;
        }
    }
}
