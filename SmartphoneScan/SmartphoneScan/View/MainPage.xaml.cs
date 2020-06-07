using SmartphoneScan.Models;
using SmartphoneScan.ViewModel;
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
    public partial class MainPage : MasterDetailPage
    {
        private readonly MainPageViewModel viewModel;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            // 最初に表示するページを取得
            var navi = (NavigationPage)Detail;

            // ビューモデルの生成
            viewModel = new MainPageViewModel(navi);
        }

        /// <summary>
        /// 画面遷移処理
        /// </summary>
        /// <param name="PageType"></param>
        /// <returns></returns>
        public async Task NavigateFromMenu(int PageType)
        {
            // メニューで選択した画面遷移したいページ(NavigationPage)を取得
            var newPage = viewModel.NavigationSetting(PageType);

            if (newPage != null && Detail != newPage)
            {
                // 取得したページ(NavigationPage)をDetaiに設定
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}