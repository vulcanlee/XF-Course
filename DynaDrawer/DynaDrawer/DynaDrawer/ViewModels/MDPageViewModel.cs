using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DynaDrawer.ViewModels
{
    public class MDPageViewModel : BindableBase
    {

        #region 功能表箭頭1
        private string _功能表箭頭1;
        /// <summary>
        /// 功能表箭頭1
        /// </summary>
        public string 功能表箭頭1
        {
            get { return this._功能表箭頭1; }
            set { this.SetProperty(ref this._功能表箭頭1, value); }
        }
        #endregion


        #region 功能表箭頭2
        private string _功能表箭頭2;
        /// <summary>
        /// 功能表箭頭2
        /// </summary>
        public string 功能表箭頭2
        {
            get { return this._功能表箭頭2; }
            set { this.SetProperty(ref this._功能表箭頭2, value); }
        }
        #endregion


        #region 功能表箭頭3
        private string _功能表箭頭3;
        /// <summary>
        /// 功能表箭頭3
        /// </summary>
        public string 功能表箭頭3
        {
            get { return this._功能表箭頭3; }
            set { this.SetProperty(ref this._功能表箭頭3, value); }
        }
        #endregion


        #region 功能表點選1
        private bool _功能表點選1;
        /// <summary>
        /// 功能表點選1
        /// </summary>
        public bool 功能表點選1
        {
            get { return this._功能表點選1; }
            set { this.SetProperty(ref this._功能表點選1, value); }
        }
        #endregion


        #region 功能表點選2
        private bool _功能表點選2;
        /// <summary>
        /// 功能表點選
        /// </summary>
        public bool 功能表點選2
        {
            get { return this._功能表點選2; }
            set { this.SetProperty(ref this._功能表點選2, value); }
        }
        #endregion


        #region 功能表點選3
        private bool _功能表點選3;
        /// <summary>
        /// 功能表點選3
        /// </summary>
        public bool 功能表點選3
        {
            get { return this._功能表點選3; }
            set { this.SetProperty(ref this._功能表點選3, value); }
        }
        #endregion

        public DelegateCommand 功能表SL1Command { get; private set; }
        public DelegateCommand 功能表SL2Command { get; private set; }
        public DelegateCommand 功能表SL3Command { get; private set; }

        public MDPageViewModel()
        {
            功能表點選1 = false;
            功能表點選2 = false;
            功能表點選3 = false;

            功能表SL1Command = new DelegateCommand(() =>
            {
                功能表點選1 = !功能表點選1;
                功能表樣式更新();
            });

            功能表SL2Command = new DelegateCommand(() =>
            {
                功能表點選2 = !功能表點選2;
                功能表樣式更新();
            });

            功能表SL3Command = new DelegateCommand(() =>
            {
                功能表點選3 = !功能表點選3;
                功能表樣式更新();
            });

            功能表樣式更新();
        }

        /// <summary>
        /// 根據功能表項目是否有展開，而變更相關表示符號
        /// 要更加好看，可以使用 Font Awesome字體或者圖片
        /// </summary>
        private void 功能表樣式更新()
        {
            if (功能表點選1 == false)
            {
                功能表箭頭1 = ">";
            }
            else
            {
                功能表箭頭1 = "V";
            }
            if (功能表點選2 == false)
            {
                功能表箭頭2 = ">";
            }
            else
            {
                功能表箭頭2 = "V";
            }
            if (功能表點選3 == false)
            {
                功能表箭頭3 = ">";
            }
            else
            {
                功能表箭頭3 = "V";
            }
        }
    }
}
