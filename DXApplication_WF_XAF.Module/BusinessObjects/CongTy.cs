using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DXApplication_WF_XAF.Module.Common;
using System;
using System.ComponentModel;
using System.Linq;

namespace DXApplication_WF_XAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem(Menu.MenuCatalog)]
    [DefaultProperty(nameof(TenCTY))]
    [ImageName("")]
    [XafDisplayName("Công ty")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]

    public class CongTy : BaseObject
    {
        public CongTy(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        bool trangThai;
        string diaChi;
        string email;
        string fAX;
        string soDienThoai;
        string tenCTY;

        [XafDisplayName("Tên công ty")]
        public string TenCTY
        {
            get => tenCTY;
            set => SetPropertyValue(nameof(TenCTY), ref tenCTY, value);
        }
        [XafDisplayName("Số điện thoại")]
        public string SoDienThoai
        {
            get => soDienThoai;
            set => SetPropertyValue(nameof(SoDienThoai), ref soDienThoai, value);
        }
        [XafDisplayName("FAX")]
        public string FAX
        {
            get => fAX;
            set => SetPropertyValue(nameof(FAX), ref fAX, value);
        }
        [XafDisplayName("Địa chỉ email")]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }
        [XafDisplayName("Địa chỉ")]
        public string DiaChi
        {
            get => diaChi;
            set => SetPropertyValue(nameof(DiaChi), ref diaChi, value);
        }
        [XafDisplayName("Trạng thái")]
        public bool TrangThai
        {
            get => trangThai;
            set => SetPropertyValue(nameof(TrangThai), ref trangThai, value);
        }
    }
}