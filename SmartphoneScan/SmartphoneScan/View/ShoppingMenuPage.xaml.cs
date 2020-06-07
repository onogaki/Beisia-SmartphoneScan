using SmartphoneScan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartphoneScan.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShoppingMenuPage : ContentPage
	{
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        List<MenuType> MenuTypeList;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ShoppingMenuPage ()
		{
			InitializeComponent ();

            // メニューの設定
            List<MenuType> menuList = GetMenuList();
            MenuList.ItemsSource = menuList;
            MenuList.SelectedItem = menuList[0];

            // メニュー選択時のイベント処理を設定
            MenuList.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                // 選択したページタイプを取得
                var PageType = (int)((MenuType)e.SelectedItem).PageType;
                // 画面遷移処理
                await RootPage.NavigateFromMenu(PageType);
            };
        }

        /// <summary>
        /// メニューリストの取得
        /// </summary>
        /// <returns></returns>
        private List<MenuType> GetMenuList()
        {
            List<MenuType> ret = new List<MenuType>()
            {
                new MenuType { PageType = MenuPageType.StartPage, Title="スタート"},
                new MenuType { PageType = MenuPageType.Cart, Title="カート"},
                new MenuType { PageType = MenuPageType.Transfer, Title="転送"}
            };

            return ret;
        }
    }
}