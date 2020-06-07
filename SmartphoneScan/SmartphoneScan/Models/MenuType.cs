using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneScan.Models
{
    /// <summary>
    /// ページを判断する定数
    /// </summary>
    public enum MenuPageType
    {
        StartPage,
        Cart,
        Transfer,
        SettingPage
    }

    /// <summary>
    /// メニュータイプ
    /// </summary>
    class MenuType
    {
        /// <summary>
        /// ページタイプ
        /// </summary>
        public MenuPageType PageType { get; set; }

        /// <summary>
        /// メニュータイトル
        /// </summary>
        public string Title { get; set; }
    }
}
